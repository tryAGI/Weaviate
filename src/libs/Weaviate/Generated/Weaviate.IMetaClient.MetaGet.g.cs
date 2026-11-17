#nullable enable

namespace Weaviate
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// Get instance metadata<br/>
        /// Provides meta-information about the running Weaviate instance, including its version, loaded modules, and network hostname. This information can be useful for monitoring, compatibility checks, or inter-instance communication.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Meta> MetaGetAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get instance metadata<br/>
        /// Provides meta-information about the running Weaviate instance, including its version, loaded modules, and network hostname. This information can be useful for monitoring, compatibility checks, or inter-instance communication.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.Meta>> MetaGetAsResponseAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}