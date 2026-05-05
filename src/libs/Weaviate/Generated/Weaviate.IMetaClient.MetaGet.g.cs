#nullable enable

namespace Weaviate
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// Returns meta information of the current Weaviate instance.<br/>
        /// Returns meta information about the server. Can be used to provide information to another Weaviate instance that wants to interact with the current instance.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Meta> MetaGetAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns meta information of the current Weaviate instance.<br/>
        /// Returns meta information about the server. Can be used to provide information to another Weaviate instance that wants to interact with the current instance.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.Meta>> MetaGetAsResponseAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}