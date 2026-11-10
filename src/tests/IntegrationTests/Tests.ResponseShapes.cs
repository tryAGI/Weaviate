namespace Weaviate.IntegrationTests;

/// <summary>
/// Calls that exist to prove the generated models can read what the server actually sends.
/// </summary>
/// <remarks>
/// This spec is the odd one out: it enforces <b>no</b> <c>required</c> fields on any response
/// schema, so the failure mode that bit the other SDKs here - a required field the server omits,
/// which turns a successful HTTP 200 into a <c>JsonException</c> - cannot happen. What these probes
/// can still catch is everything else a response can get wrong: a numeric field too narrow for the
/// value, a union that matches no variant, a property the spec spells differently from the server.
///
/// They run against the Testcontainers instance, so they cost nothing and need no key. Liveness and
/// readiness are deliberately included: they return no body, which is its own shape to get right.
/// </remarks>
public partial class Tests
{
    [TestMethod]
    public async Task Root_Deserializes()
    {
        var root = await Client.Root.WeaviateRootAsync();

        root.Should().NotBeNull();
    }

    [TestMethod]
    public async Task ClusterStatistics_Deserializes()
    {
        var statistics = await Client.Cluster.ClusterGetStatisticsAsync();

        statistics.Should().NotBeNull();
    }

    [TestMethod]
    public async Task ObjectsList_Deserializes()
    {
        // An empty instance still answers with the envelope, which is the part being read here.
        var objects = await Client.Objects.ObjectsListAsync(limit: 1);

        objects.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Roles_Deserialize()
    {
        var roles = await Client.Authz.GetRolesAsync();

        roles.Should().NotBeNull();
    }

    [TestMethod]
    public async Task OwnUserInfo_Deserializes()
    {
        var user = await Client.Users.GetOwnInfoAsync();

        user.Should().NotBeNull();
    }

    [TestMethod]
    public async Task LivenessAndReadiness_Respond()
    {
        await Client.WellKnown.WeaviateWellknownLivenessAsync();
        await Client.WellKnown.WeaviateWellknownReadinessAsync();
    }
}
