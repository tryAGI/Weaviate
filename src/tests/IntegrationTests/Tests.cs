namespace Weaviate.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static Environment? _environment;

    public static WeaviateClient Client => _environment!.Client;

    [AssemblyInitialize]
    public static async Task AssemblyInit(TestContext context)
    {
        _environment = await Environment.PrepareAsync();
    }

    [AssemblyCleanup]
    public static async Task AssemblyCleanup()
    {
        if (_environment != null)
        {
            await _environment.DisposeAsync();
        }
    }
}
