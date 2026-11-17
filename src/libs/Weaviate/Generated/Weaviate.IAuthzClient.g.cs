
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Endpoints for managing Weaviate's Role-Based Access Control (RBAC) system. Access to Weaviate resources is granted through roles, which are collections of fine-grained permissions. &lt;br/&gt;&lt;br/&gt;**Permissions:** Define allowed actions (e.g., `read_data`, `create_collections`, `delete_users`) on specific resources. Resources can be specified broadly (e.g., all collections: `*`) or narrowly (e.g., a specific collection name, tenant pattern, user name, or role name).&lt;br/&gt;&lt;br/&gt;**Roles:** Are named sets of permissions. Managing roles involves creating roles with specific permissions, retrieving role definitions, deleting roles, and adding or removing permissions from existing roles.&lt;br/&gt;&lt;br/&gt;**Role assignment:** Roles grant their contained permissions to users or groups. These endpoints allow assigning roles to:&lt;br/&gt;* `db` users: Users managed directly by Weaviate via API or environment variables, authenticating with API keys.&lt;br/&gt;* `oidc` users: Users authenticated via an external OpenID Connect provider, managed externally but assigned roles within Weaviate.&lt;br/&gt;* OIDC `groups`: Users authenticated via OIDC who belong to a group automatically inherit roles assigned to that group.&lt;br/&gt;&lt;br/&gt;Operations also include revoking roles, checking if a role has a specific permission, listing roles assigned to a user, and listing users/groups assigned to a role. The authorization framework applies universally to both `db` and `oidc` users based on their assigned roles.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IAuthzClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Weaviate.AutoSDKClientOptions Options { get; }


        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}