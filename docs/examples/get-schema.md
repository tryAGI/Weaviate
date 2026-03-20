# Get Schema



This example assumes `using Weaviate;` is in scope and `apiKey` contains your Weaviate API key.

```csharp
using var client = new WeaviateClient(apiKey);

Schema schema = await client.Schema.SchemaDumpAsync();

foreach (var cls in schema.Classes ?? [])
{
    Console.WriteLine($"Class: {cls.Class1}");
    Console.WriteLine($"  Description: {cls.Description}");

    foreach (var prop in cls.Properties ?? [])
    {
        Console.WriteLine($"  Property: {prop.Name} ({string.Join(", ", prop.DataType ?? [])})");
    }

    Console.WriteLine();
}
```