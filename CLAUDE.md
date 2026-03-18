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

# Run integration tests (requires WEAVIATE_API_KEY and WEAVIATE_URL env vars)
dotnet test src/tests/IntegrationTests/Weaviate.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Weaviate && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/Weaviate/Generated/`.

1. `src/libs/Weaviate/openapi.yaml` -- the Weaviate OpenAPI spec (fetched from `https://raw.githubusercontent.com/weaviate/weaviate/openapi_docs/openapi-specs/schema.json`)
2. `src/helpers/FixOpenApiSpec/` -- converts OpenAPI 3.1 to 3.0 format for compatibility
3. `src/libs/Weaviate/generate.sh` -- orchestrates: download spec, fix spec, run AutoSDK CLI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Weaviate/` | Main SDK library (`WeaviateClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real Weaviate API |
| `src/helpers/FixOpenApiSpec/` | OpenAPI spec fixer tool |
| `src/helpers/GenerateDocs/` | Documentation generator from integration tests |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
