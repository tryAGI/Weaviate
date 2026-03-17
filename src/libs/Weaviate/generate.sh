set -e
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -o openapi.json https://raw.githubusercontent.com/weaviate/weaviate/openapi_docs/openapi-specs/schema.json
autosdk generate openapi.json \
  --namespace Weaviate \
  --clientClassName WeaviateClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
