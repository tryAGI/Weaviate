namespace Weaviate.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static Environment _environment = null!;

    public static WeaviateClient Client => _environment.Client;

    [AssemblyInitialize]
    public static async Task AssemblyInit(TestContext context)
    {
        _environment = await Environment.PrepareAsync();
    }

    [AssemblyCleanup]
    public static async Task AssemblyCleanup()
    {
        await _environment.DisposeAsync();
    }
}
