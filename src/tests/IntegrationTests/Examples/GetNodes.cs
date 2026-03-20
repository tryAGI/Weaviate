/*
order: 40
title: Get Nodes
slug: get-nodes
*/

namespace Weaviate.IntegrationTests;

public partial class Tests
{
    //// Retrieve information about all nodes in the Weaviate cluster,
    //// including their status and shard details.

    [TestMethod]
    public async Task Example_GetNodes()
    {
        using var client = GetAuthenticatedClient();

        NodesStatusResponse nodesStatus = await client.Nodes.NodesGetAsync();

        nodesStatus.Should().NotBeNull();
        nodesStatus.Nodes.Should().NotBeNull();

        foreach (var node in nodesStatus.Nodes ?? [])
        {
            Console.WriteLine($"Node: {node.Name}");
            Console.WriteLine($"  Status: {node.Status}");
            Console.WriteLine($"  Version: {node.Version}");
            Console.WriteLine($"  Shards: {node.Shards?.Count ?? 0}");
            Console.WriteLine();
        }
    }
}
