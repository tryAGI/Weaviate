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

1. `src/libs/Weaviate/openapi.yaml` -- the Weaviate OpenAPI spec (fetched from `https://raw.githubusercontent.com/weaviate/weaviate/openapi_docs/openapi-specs/schema.json`)
3. `src/libs/Weaviate/generate.sh` -- orchestrates: download spec, fix spec, run AutoSDK CLI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

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
