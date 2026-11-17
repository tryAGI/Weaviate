#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://raw.githubusercontent.com/weaviate/weaviate/main/openapi-specs/schema.json
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L -o openapi.json https://raw.githubusercontent.com/weaviate/weaviate/main/openapi-specs/schema.json
# Weaviate declares `"type": ["string", "null"]` on seven properties -- JSON Schema / OpenAPI 3.1
# syntax inside a `swagger: "2.0"` document, which the 2.0 schema object does not allow. AutoSDK
# normalizes the array to no type at all and then throws on the first one it reaches
# (`DBUserInfo.createdAt`), so nothing generates. Swagger 2.0 spells the same thing `x-nullable`.
python3 -I - openapi.json <<'NULLABLE_EOF'
import json, sys

path = sys.argv[1]
document = json.loads(open(path, encoding="utf-8").read())
patched = 0


def normalize(node):
    global patched
    if isinstance(node, dict):
        declared = node.get("type")
        if isinstance(declared, list):
            concrete = [t for t in declared if t != "null"]
            if len(concrete) == 1:
                node["type"] = concrete[0]
                if len(concrete) != len(declared):
                    node["x-nullable"] = True
                patched += 1
        for value in node.values():
            normalize(value)
    elif isinstance(node, list):
        for value in node:
            normalize(value)


normalize(document)
if patched == 0:
    raise SystemExit("no array-valued `type` left to collapse -- upstream fixed it, drop this step")
open(path, "w", encoding="utf-8").write(json.dumps(document, indent=2) + "\n")
print(f"collapsed {patched} array-valued `type` declarations to Swagger 2.0 `x-nullable`")
NULLABLE_EOF

# `POST /mcp` lists `text/event-stream` among its `produces`, which is what makes AutoSDK emit a
# streaming variant, but its 200 carries no `schema` at all -- so the generator has a stream with no
# response type and throws on `McpPostAsStream`. The endpoint is a JSON-RPC passthrough and the spec
# says no more about the payload than "JSON-RPC response or SSE stream", so declare it free-form
# rather than inventing an envelope the API does not promise.
python3 -I - openapi.json <<'MCP_EOF'
import json, sys

path = sys.argv[1]
document = json.loads(open(path, encoding="utf-8").read())
response = document["paths"]["/mcp"]["post"]["responses"]["200"]
if "schema" in response:
    raise SystemExit("`POST /mcp` 200 now declares a schema -- drop this step")
response["schema"] = {
    "type": "object",
    "description": "JSON-RPC response object, or one SSE event's data when streaming.",
}
open(path, "w", encoding="utf-8").write(json.dumps(document, indent=2) + "\n")
print("declared a free-form schema for the `POST /mcp` 200 response")
MCP_EOF

# `SearchResultObject.properties` and `SearchResultReference.properties` are maps of a *property
# value*, which is any JSON - a string, a number, an array - but the spec types each value as
# `JsonObject` (`type: object`). The server is right and the spec is wrong: a BM25 search over a
# text property answers HTTP 200 with `{"properties": {"body": "a sentence..."}}`, and the generated
# `IDictionary<string, JsonObject>` throws `JsonException` on it, which makes the entire new Search
# surface unusable for the ordinary case. `PropertySchema`, the same thing on the objects endpoints,
# is already free-form. `GraphQLResponse.data` keeps its typing: there the values really are objects.
python3 -I - openapi.json <<'PROPERTIES_EOF'
import json, sys

path = sys.argv[1]
document = json.loads(open(path, encoding="utf-8").read())
patched = []
for name in ("SearchResultObject", "SearchResultReference"):
    schema = document["definitions"][name]["properties"]["properties"]
    if schema.get("additionalProperties") != {"$ref": "#/definitions/JsonObject"}:
        continue
    # `true` is "any JSON", which is what a property value is. The map shape does not survive it:
    # AutoSDK emits a bare `object` for the whole property rather than a dictionary of `object`.
    # That was measured against both alternatives - an inline `{}` and a `$ref` to a named free-form
    # definition - and all three produce the same `object`, so this is the simplest of the three
    # rather than a compromise. `object` deserializes the real payload, which the typed map did not.
    schema["additionalProperties"] = True
    patched.append(name)

if not patched:
    raise SystemExit(
        "neither Search result schema types its property values as JsonObject any more -- drop this step")
open(path, "w", encoding="utf-8").write(json.dumps(document, indent=2) + "\n")
print(f"made the property maps of {', '.join(patched)} free-form")
PROPERTIES_EOF

autosdk generate openapi.json \
  --namespace Weaviate \
  --clientClassName WeaviateClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
