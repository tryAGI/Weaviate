/*
order: 10
title: Test
slug: test
*/

namespace Weaviate.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Generate()
    {
        using var client = GetAuthenticatedClient();

        Class @class = await client.Schema.SchemaObjectsCreateAsync(
            class1: "Question");
    }
}
