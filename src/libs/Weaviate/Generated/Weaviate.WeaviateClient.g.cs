
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// # Introduction&lt;br/&gt; Weaviate is an open source, AI-native vector database that helps developers create intuitive and reliable AI-powered applications. &lt;br/&gt; ### Base Path &lt;br/&gt;The base path for the Weaviate server is structured as `[YOUR-WEAVIATE-HOST]:[PORT]/v1`. As an example, if you wish to access the `schema` endpoint on a local instance, you would navigate to `http://localhost:8080/v1/schema`. Ensure you replace `[YOUR-WEAVIATE-HOST]` and `[PORT]` with your actual server host and port number respectively. &lt;br/&gt; ### Questions? &lt;br/&gt;If you have any comments or questions, please feel free to reach out to us at the community forum [https://forum.weaviate.io/](https://forum.weaviate.io/). &lt;br/&gt;### Issues? &lt;br/&gt;If you find a bug or want to file a feature request, please open an issue on our GitHub repository for [Weaviate](https://github.com/weaviate/weaviate). &lt;br/&gt;### Need more documentation? &lt;br/&gt;For a quickstart, code examples, concepts and more, please visit our [documentation page](https://docs.weaviate.io/weaviate).<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class WeaviateClient : global::Weaviate.IWeaviateClient, global::System.IDisposable
    {
        /// <summary>
        ///
        /// </summary>
        public const string DefaultBaseUrl = "https:///v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Weaviate.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::Weaviate.AutoSDKClientOptions Options { get; }

        internal global::System.Lazy<global::System.Text.Json.Serialization.JsonSerializerContext>? JsonSerializerContextProvider { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext
        {
            get => JsonSerializerContextProvider?.Value ?? global::Weaviate.SourceGenerationContext.Default;
            set => JsonSerializerContextProvider = new(() => value);
        }


        /// <summary>
        /// Operations for aggregating over collections. The aggregate endpoint counts the objects that match an optional `where` filter, in total or grouped by a property's distinct values.
        /// </summary>
        public AggregateClient Aggregate => new AggregateClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Endpoints for managing Weaviate's Role-Based Access Control (RBAC) system. Access to Weaviate resources is granted through roles, which are collections of fine-grained permissions. &lt;br/&gt;&lt;br/&gt;**Permissions:** Define allowed actions (e.g., `read_data`, `create_collections`, `delete_users`) on specific resources. Resources can be specified broadly (e.g., all collections: `*`) or narrowly (e.g., a specific collection name, tenant pattern, user name, or role name).&lt;br/&gt;&lt;br/&gt;**Roles:** Are named sets of permissions. Managing roles involves creating roles with specific permissions, retrieving role definitions, deleting roles, and adding or removing permissions from existing roles.&lt;br/&gt;&lt;br/&gt;**Role assignment:** Roles grant their contained permissions to users or groups. These endpoints allow assigning roles to:&lt;br/&gt;* `db` users: Users managed directly by Weaviate via API or environment variables, authenticating with API keys.&lt;br/&gt;* `oidc` users: Users authenticated via an external OpenID Connect provider, managed externally but assigned roles within Weaviate.&lt;br/&gt;* OIDC `groups`: Users authenticated via OIDC who belong to a group automatically inherit roles assigned to that group.&lt;br/&gt;&lt;br/&gt;Operations also include revoking roles, checking if a role has a specific permission, listing roles assigned to a user, and listing users/groups assigned to a role. The authorization framework applies universally to both `db` and `oidc` users based on their assigned roles.
        /// </summary>
        public AuthzClient Authz => new AuthzClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Operations related to creating and managing backups of Weaviate data. This feature allows you to create snapshots of your collections and store them on external storage backends such as cloud object storage (S3, GCS, Azure) or a shared filesystem. These endpoints enable you to initiate backup and restore processes, monitor their status, list available backups on a backend, and delete unwanted backups. Backups are essential for disaster recovery, data migration, and maintaining point-in-time copies of your vector database.
        /// </summary>
        public BackupsClient Backups => new BackupsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Operations for performing actions on multiple data items (objects or references) in a single API request. Batch operations significantly improve performance and efficiency, especially for bulk data imports or large-scale deletions, by reducing network overhead compared to sending individual requests. These endpoints allow for creating multiple objects or deleting objects based on filters.
        /// </summary>
        public BatchClient Batch => new BatchClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        ///
        /// </summary>
        public ClassificationsClient Classifications => new ClassificationsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        ///
        /// </summary>
        public ClusterClient Cluster => new ClusterClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        ///
        /// </summary>
        public DistributedTasksClient DistributedTasks => new DistributedTasksClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        ///
        /// </summary>
        public ExperimentalClient Experimental => new ExperimentalClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        ///
        /// </summary>
        public ExportClient Export => new ExportClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        ///
        /// </summary>
        public GraphqlClient Graphql => new GraphqlClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Model Context Protocol (MCP) endpoint. Provides tool discovery and invocation for LLM agents via the MCP Streamable HTTP transport.
        /// </summary>
        public McpClient Mcp => new McpClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        ///
        /// </summary>
        public MetaClient Meta => new MetaClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Operations for managing cluster-level namespaces. Namespaces group resources under a common administrative unit. Access is gated by the operator-tier `manage_namespaces` action and, on namespace-enabled clusters, a well-formed Weaviate license key on the serving node.
        /// </summary>
        public NamespacesClient Namespaces => new NamespacesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        ///
        /// </summary>
        public NodesClient Nodes => new NodesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Operations for managing individual data objects. Objects are the primary units of data stored within Weaviate collections. Each object conforms to the data schema definition of its parent collection, containing specific properties (data fields). Objects have one or multiple associated vector embeddings and can link to other objects via cross-references. These endpoints allow you to perform CRUD (Create, Read, Update, Delete) operations on individual data objects.
        /// </summary>
        public ObjectsClient Objects => new ObjectsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Operations related to managing data replication, including initiating and monitoring shard replica movements between nodes, querying current sharding states, and managing the lifecycle of replication tasks.
        /// </summary>
        public ReplicationClient Replication => new ReplicationClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Operations related to managing collections. In Weaviate, 'collections' (formerly called 'classes') store your data objects. Each collection has a definition that specifies its data structure (properties and their data types), vectorizer settings (how vectors are generated or managed), and indexing configuration (how data is indexed for efficient search). These endpoints allow you to create, retrieve, update, and delete collection definitions. For detailed usage and code examples on interacting with collections, see the documentation: [https://docs.weaviate.io/weaviate/manage-collections](https://docs.weaviate.io/weaviate/manage-collections).
        /// </summary>
        public SchemaClient Schema => new SchemaClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Operations for querying collections over REST. The near-text endpoint performs semantic vector search with server-side embedding of the query text; the bm25 endpoint performs keyword (BM25F) search over the searchable text properties. Each result carries the object's `id`, the selected `properties`, the selected `references` and, when requested, its retrieval `metadata`.
        /// </summary>
        public SearchClient Search => new SearchClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        ///
        /// </summary>
        public TokenizeClient Tokenize => new TokenizeClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Endpoints for user account management in Weaviate. This includes operations specific to Weaviate-managed database users (`db` users), such as creation (which generates an API key), listing, deletion, activation/deactivation, and API key rotation. It also provides operations applicable to any authenticated user (`db` or `oidc`), like retrieving their own information (username and assigned roles).&lt;br/&gt;&lt;br/&gt;**User Types:**&lt;br/&gt;* **`db` users:** Managed entirely within Weaviate (creation, deletion, API keys). Use these endpoints for full lifecycle management.&lt;br/&gt;* **`oidc` users:** Authenticated via an external OpenID Connect provider. Their lifecycle (creation, credentials) is managed externally, but their role assignments *within Weaviate* are managed via the `authz` endpoints.
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        ///
        /// </summary>
        public WellKnownClient WellKnown => new WellKnownClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Creates a new instance of the WeaviateClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public WeaviateClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Weaviate.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the WeaviateClient with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public WeaviateClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Collections.Generic.List<global::Weaviate.EndPointAuthorization>? authorizations,
            global::Weaviate.AutoSDKClientOptions? options,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri: null,
                authorizations,
                options,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the WeaviateClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public WeaviateClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::Weaviate.EndPointAuthorization>? authorizations,
            global::Weaviate.AutoSDKClientOptions? options,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Weaviate.EndPointAuthorization>();
            Options = options ?? new global::Weaviate.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}