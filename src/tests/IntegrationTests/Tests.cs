namespace Weaviate.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static WeaviateClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("WEAVIATE_API_KEY") ??
            throw new AssertInconclusiveException("WEAVIATE_API_KEY environment variable is not found.");
        var url =
            Environment.GetEnvironmentVariable("WEAVIATE_URL") ??
            throw new AssertInconclusiveException("WEAVIATE_URL environment variable is not found.");

        var client = new WeaviateClient(apiKey, baseUri: new Uri(url));
        
        return client;
    }
}
