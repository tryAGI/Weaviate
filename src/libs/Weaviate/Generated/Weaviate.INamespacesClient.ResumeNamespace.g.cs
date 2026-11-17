#nullable enable

namespace Weaviate
{
    public partial interface INamespacesClient
    {
        /// <summary>
        /// Resume a namespace<br/>
        /// Return a suspended namespace to the "active" state, so its dynamic users authenticate again and its resources accept writes. Repeated calls against an already-active namespace are idempotent and return 202.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task ResumeNamespaceAsync(
            string namespaceId,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resume a namespace<br/>
        /// Return a suspended namespace to the "active" state, so its dynamic users authenticate again and its resources accept writes. Repeated calls against an already-active namespace are idempotent and return 202.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> ResumeNamespaceAsResponseAsync(
            string namespaceId,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}