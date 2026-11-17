#nullable enable

namespace Weaviate
{
    public partial interface INamespacesClient
    {
        /// <summary>
        /// Get a namespace<br/>
        /// Retrieve details about a specific namespace by its name.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Namespace> GetNamespaceAsync(
            string namespaceId,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a namespace<br/>
        /// Retrieve details about a specific namespace by its name.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.Namespace>> GetNamespaceAsResponseAsync(
            string namespaceId,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}