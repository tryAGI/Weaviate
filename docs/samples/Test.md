```csharp
using var client = new WeaviateClient(apiKey);

Class @class = await client.Schema.SchemaObjectsCreateAsync(
    class1: "Question");
```