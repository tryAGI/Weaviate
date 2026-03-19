namespace Weaviate.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static WeaviateClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("WEAVIATE_API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            throw new AssertInconclusiveException("WEAVIATE_API_KEY environment variable is not found.");
        var url =
            Environment.GetEnvironmentVariable("WEAVIATE_URL") is { Length: > 0 } urlValue ? urlValue :
            throw new AssertInconclusiveException("WEAVIATE_URL environment variable is not found.");

        var client = new WeaviateClient(baseUri: new Uri(url));
        client.AuthorizeUsingBearer(apiKey);
        
        return client;
    }
}
