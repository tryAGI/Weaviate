
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Endpoints for user account management in Weaviate. This includes operations specific to Weaviate-managed database users (`db` users), such as creation (which generates an API key), listing, deletion, activation/deactivation, and API key rotation. It also provides operations applicable to any authenticated user (`db` or `oidc`), like retrieving their own information (username and assigned roles).&lt;br/&gt;&lt;br/&gt;**User Types:**&lt;br/&gt;* **`db` users:** Managed entirely within Weaviate (creation, deletion, API keys). Use these endpoints for full lifecycle management.&lt;br/&gt;* **`oidc` users:** Authenticated via an external OpenID Connect provider. Their lifecycle (creation, credentials) is managed externally, but their role assignments *within Weaviate* are managed via the `authz` endpoints.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IUsersClient : global::System.IDisposable
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