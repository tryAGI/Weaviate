/*
order: 30
title: Get Schema
slug: get-schema
*/

namespace Weaviate.IntegrationTests;

public partial class Tests
{
    //// Retrieve the full schema definition from the Weaviate instance,
    //// which describes all configured classes and their properties.

    [TestMethod]
    public async Task Example_GetSchema()
    {
        using var client = GetAuthenticatedClient();

        Schema schema = await client.Schema.SchemaObjectsGetAsync();

        schema.Should().NotBeNull();

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
    }
}
