# Get Meta



This example assumes `using Weaviate;` is in scope and `apiKey` contains your Weaviate API key.

```csharp
using var client = new WeaviateClient(apiKey);

Meta meta = await client.Meta.MetaGetAsync();

Console.WriteLine($"Weaviate version: {meta.Version}");
Console.WriteLine($"Hostname: {meta.Hostname}");
```