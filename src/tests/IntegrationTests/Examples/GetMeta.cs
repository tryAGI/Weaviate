/*
order: 20
title: Get Meta
slug: get-meta
*/

namespace Weaviate.IntegrationTests;

public partial class Tests
{
    //// Retrieve metadata about the Weaviate instance, including version
    //// and enabled modules.

    [TestMethod]
    public async Task Example_GetMeta()
    {
        var client = Client;

        Meta meta = await client.Meta.MetaGetAsync();

        meta.Should().NotBeNull();
        meta.Version.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Weaviate version: {meta.Version}");
        Console.WriteLine($"Hostname: {meta.Hostname}");
    }
}
