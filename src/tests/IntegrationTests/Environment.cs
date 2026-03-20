using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;

namespace Weaviate.IntegrationTests;

public sealed class Environment : IAsyncDisposable
{
    private const string WeaviateImage = "semitechnologies/weaviate:latest";
    private const ushort WeaviatePort = 8080;
    private static readonly TimeSpan StartupTimeout = TimeSpan.FromMinutes(2);

    public IContainer? Container { get; init; }
    public required WeaviateClient Client { get; init; }

    public async ValueTask DisposeAsync()
    {
        Client.Dispose();
        if (Container != null)
        {
            await Container.DisposeAsync();
        }
    }

    public static async Task<Environment> PrepareAsync(EnvironmentType? environmentType = null)
    {
        environmentType ??= InferEnvironment();
        switch (environmentType)
        {
            case EnvironmentType.Local:
            {
                var apiKey =
                    System.Environment.GetEnvironmentVariable("WEAVIATE_API_KEY") is { Length: > 0 } apiKeyValue
                        ? apiKeyValue
                        : throw new AssertInconclusiveException(
                            "WEAVIATE_API_KEY environment variable is not found.");
                var url =
                    System.Environment.GetEnvironmentVariable("WEAVIATE_URL") is { Length: > 0 } urlValue
                        ? urlValue
                        : throw new AssertInconclusiveException(
                            "WEAVIATE_URL environment variable is not found.");

                var client = new WeaviateClient(baseUri: new Uri(url));
                client.AuthorizeUsingBearer(apiKey);

                return new Environment
                {
                    Client = client,
                };
            }
            case EnvironmentType.Container:
            {
                var container = new ContainerBuilder(WeaviateImage)
                    .WithEnvironment("AUTHENTICATION_ANONYMOUS_ACCESS_ENABLED", "true")
                    .WithEnvironment("PERSISTENCE_DATA_PATH", "/var/lib/weaviate")
                    .WithPortBinding(WeaviatePort, assignRandomHostPort: true)
                    .WithWaitStrategy(
                        Wait.ForUnixContainer()
                            .UntilHttpRequestIsSucceeded(request => request
                                .ForPath("/v1/.well-known/ready")
                                .ForPort(WeaviatePort)))
                    .Build();

                using var cts = new CancellationTokenSource(StartupTimeout);
                await container.StartAsync(cts.Token);

                var baseUri = new UriBuilder(
                    Uri.UriSchemeHttp,
                    container.Hostname,
                    container.GetMappedPublicPort(WeaviatePort),
                    "/v1").Uri;

                var client = new WeaviateClient(baseUri: baseUri);

                return new Environment
                {
                    Container = container,
                    Client = client,
                };
            }
            default:
                throw new ArgumentOutOfRangeException(nameof(environmentType), environmentType, null);
        }
    }

    private static EnvironmentType InferEnvironment()
    {
#if DEBUG
        return EnvironmentType.Local;
#else
        return EnvironmentType.Container;
#endif
    }
}

public enum EnvironmentType
{
    Local,
    Container,
}
