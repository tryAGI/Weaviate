
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Endpoints for managing Weaviate's Role-Based Access Control (RBAC) system. Access to Weaviate resources is granted through roles, which are collections of fine-grained permissions. &lt;br/&gt;&lt;br/&gt;**Permissions:** Define allowed actions (e.g., `read_data`, `create_collections`, `delete_users`) on specific resources. Resources can be specified broadly (e.g., all collections: `*`) or narrowly (e.g., a specific collection name, tenant pattern, user name, or role name).&lt;br/&gt;&lt;br/&gt;**Roles:** Are named sets of permissions. Managing roles involves creating roles with specific permissions, retrieving role definitions, deleting roles, and adding or removing permissions from existing roles.&lt;br/&gt;&lt;br/&gt;**Role assignment:** Roles grant their contained permissions to users or groups. These endpoints allow assigning roles to:&lt;br/&gt;* `db` users: Users managed directly by Weaviate via API or environment variables, authenticating with API keys.&lt;br/&gt;* `oidc` users: Users authenticated via an external OpenID Connect provider, managed externally but assigned roles within Weaviate.&lt;br/&gt;* OIDC `groups`: Users authenticated via OIDC who belong to a group automatically inherit roles assigned to that group.&lt;br/&gt;&lt;br/&gt;Operations also include revoking roles, checking if a role has a specific permission, listing roles assigned to a user, and listing users/groups assigned to a role. The authorization framework applies universally to both `db` and `oidc` users based on their assigned roles.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class AuthzClient : global::Weaviate.IAuthzClient, global::System.IDisposable
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
            get => JsonSerializerContextProvider?.Value ?? global::Weaviate.AuthzSourceGenerationContext.Default;
            set => JsonSerializerContextProvider = new(() => value);
        }


        /// <summary>
        /// Creates a new instance of the AuthzClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public AuthzClient(
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
        /// Creates a new instance of the AuthzClient with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public AuthzClient(
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
        /// Creates a new instance of the AuthzClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public AuthzClient(
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