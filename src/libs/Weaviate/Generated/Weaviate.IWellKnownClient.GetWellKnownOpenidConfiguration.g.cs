#nullable enable

namespace Weaviate
{
    public partial interface IWellKnownClient
    {
        /// <summary>
        /// Get OIDC configuration<br/>
        /// Provides OpenID Connect (OIDC) discovery information if OIDC authentication is configured for Weaviate. Returns details like the token issuer URL, client ID, and required scopes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.GetWellKnownOpenidConfigurationResponse> GetWellKnownOpenidConfigurationAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get OIDC configuration<br/>
        /// Provides OpenID Connect (OIDC) discovery information if OIDC authentication is configured for Weaviate. Returns details like the token issuer URL, client ID, and required scopes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.GetWellKnownOpenidConfigurationResponse>> GetWellKnownOpenidConfigurationAsResponseAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}