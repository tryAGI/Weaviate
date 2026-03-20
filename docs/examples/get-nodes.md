# Get Nodes



This example assumes `using Weaviate;` is in scope and `apiKey` contains your Weaviate API key.

```csharp
using var client = new WeaviateClient(apiKey);

NodesStatusResponse nodesStatus = await client.Nodes.NodesGetAsync();

foreach (var node in nodesStatus.Nodes ?? [])
{
    Console.WriteLine($"Node: {node.Name}");
    Console.WriteLine($"  Status: {node.Status}");
    Console.WriteLine($"  Version: {node.Version}");
    Console.WriteLine($"  Shards: {node.Shards?.Count ?? 0}");
    Console.WriteLine();
}
```