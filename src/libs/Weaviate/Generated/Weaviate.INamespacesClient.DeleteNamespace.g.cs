#nullable enable

namespace Weaviate
{
    public partial interface INamespacesClient
    {
        /// <summary>
        /// Delete a namespace<br/>
        /// Mark a namespace for deletion. The endpoint is asynchronous: the namespace is flipped to the "deleting" state, which stops its dynamic users from authenticating; their rows, along with classes and aliases, are reclaimed by the leader on a periodic cleanup tick. Repeated calls while the namespace is still in the "deleting" state are idempotent and return 202.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteNamespaceAsync(
            string namespaceId,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a namespace<br/>
        /// Mark a namespace for deletion. The endpoint is asynchronous: the namespace is flipped to the "deleting" state, which stops its dynamic users from authenticating; their rows, along with classes and aliases, are reclaimed by the leader on a periodic cleanup tick. Repeated calls while the namespace is still in the "deleting" state are idempotent and return 202.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> DeleteNamespaceAsResponseAsync(
            string namespaceId,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}