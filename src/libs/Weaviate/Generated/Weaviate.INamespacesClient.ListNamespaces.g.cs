#nullable enable

namespace Weaviate
{
    public partial interface INamespacesClient
    {
        /// <summary>
        /// List namespaces<br/>
        /// Retrieve the list of all namespaces the caller has permission to see. Callers without any applicable `manage_namespaces` permission receive an empty list rather than 403.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.Namespace>> ListNamespacesAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List namespaces<br/>
        /// Retrieve the list of all namespaces the caller has permission to see. Callers without any applicable `manage_namespaces` permission receive an empty list rather than 403.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Weaviate.Namespace>>> ListNamespacesAsResponseAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}