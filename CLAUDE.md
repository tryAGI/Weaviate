# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Weaviate](https://weaviate.io/) vector database, auto-generated from the Weaviate OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Weaviate.slnx

# Build for release (also produces NuGet package)
dotnet build Weaviate.slnx -c Release

# Run integration tests
# - Release/CI: automatically spins up a Weaviate Docker container via Testcontainers
# - Debug/local: connects to Weaviate Cloud (requires WEAVIATE_API_KEY and WEAVIATE_URL env vars)
dotnet test src/tests/IntegrationTests/Weaviate.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Weaviate && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/Weaviate/Generated/`.

1. `src/libs/Weaviate/openapi.json` -- the Weaviate OpenAPI spec, fetched from
   `https://raw.githubusercontent.com/weaviate/weaviate/main/openapi-specs/schema.json`
2. `src/libs/Weaviate/generate.sh` -- orchestrates: download spec, fix spec, run AutoSDK CLI, output to `Generated/`
3. CI auto-updates the spec and creates PRs if changes are detected

### The spec source must stay on the default branch

Until 2026-11-17 the fetch pointed at the `openapi_docs` branch, which upstream froze on
**2025-02-18**. Auto-update compares the fetched spec with the committed one, so a frozen source
never differs, no PR is ever opened, and the SDK looks current: this one shipped **1.29.0** while
the server reached **1.41.0-rc.0**, missing 63 operations - half the API. Point the fetch at
`main`; the workspace-wide check is `scripts/audit_spec_source_branches.py` in the tryAGI repo.

### Three spec defects the `generate.sh` steps work around

Each step exits non-zero when the defect is gone, so none can rot into a silent no-op:

| Defect | Why it matters |
|--------|----------------|
| Seven properties declare `"type": ["string", "null"]` | JSON Schema syntax inside a `swagger: "2.0"` document. The reader cannot represent it, hands over a schema with no type, and generation aborted on `DBUserInfo.createdAt`. Collapsed to `type` plus Swagger 2.0's own `x-nullable`. |
| `POST /mcp` lists `text/event-stream` with no response `schema` | A streaming media type is what makes AutoSDK emit an `IAsyncEnumerable` method, and it then has no type to enumerate - generation threw on `McpPostAsStream`. Declared free-form, since the spec promises no more than "JSON-RPC response or SSE stream". |
| `SearchResultObject.properties` / `SearchResultReference.properties` type each value as `JsonObject` | A property value is any JSON. A BM25 search over a text property answers HTTP **200** with `{"properties": {"body": "..."}}` and the generated `IDictionary<string, JsonObject>` threw `JsonException`, so the whole new Search surface was unusable for the ordinary case. Made free-form. |

### What the container can and cannot test

The Testcontainers node runs `semitechnologies/weaviate:latest` with
`EXPERIMENTAL_REST_SEARCH_ENABLED=true`, without which every `/v1/search/{collection}/*` endpoint
answers *"rest search api is experimental and not enabled"*. Namespaces cannot be enabled at all:
upstream gates them on `NAMESPACES_ENABLED` **and** a licence, so the community image always
refuses them - `Tests.NewSurface.cs` asserts that refusal rather than skipping. The replication,
rebalance, backup, export and user-management writes need a real cluster or a configured backend
and have no coverage here.

Replication is worth one specific note, because the way it fails is misleading. The spec is a
**release candidate** and the image is an older stable, so `/v1/replication/replicate/list` answers
**501 with an empty body**. The generated error path then runs `ErrorResponse.FromJson("")`, which
throws `JsonException: The input does not contain any JSON tokens`. The status is not lost - the
generator catches that and still throws `ApiException<ErrorResponse>` carrying 501 - but the
message is the empty body rather than the reason phrase, so what a caller sees reads like a
deserialization bug where the server said 501 plainly. `Tests.NewSurface.cs` pins both facts.

One trap while probing this by hand: `Client.BaseUri` has no trailing slash, so
`new Uri(BaseUri, "replication/replicate/list")` silently drops the `/v1` segment and hits a path
the server answers with a JSON 404 - which looks like an entirely different finding. That cost one
wrong diagnosis here.

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Weaviate/` | Main SDK library (`WeaviateClient`) |
| `src/tests/IntegrationTests/` | Integration tests (Testcontainers in CI, Weaviate Cloud locally) |

### Documentation Generation

Tests in `src/tests/IntegrationTests/Examples` are the single source of truth for both test coverage and documentation:
- Each file has a JSDoc header (`order`, `title`, `slug`) consumed by `autosdk docs sync .`
- Comments prefixed with `////` become prose paragraphs in generated docs
- CI workflow (`.github/workflows/mkdocs.yml`) auto-generates `docs/examples/` and populates `EXAMPLES:START/END` markers in README.md, docs/index.md, and mkdocs.yml
- Config: `autosdk.docs.json` points to `src/tests/IntegrationTests/Examples`

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
