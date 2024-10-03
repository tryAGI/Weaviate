dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Weaviate \
  WeaviateClient \
  https://raw.githubusercontent.com/weaviate/weaviate/openapi_docs/openapi-specs/schema.json \
  tryAGI \
  --output .
