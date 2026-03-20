# Test



This example assumes `using Weaviate;` is in scope and `apiKey` contains your Weaviate API key.

```csharp
using var client = new WeaviateClient(apiKey);

Class @class = await client.Schema.SchemaObjectsCreateAsync(
    class1: "Question");
```