#nullable enable

namespace Weaviate
{
    public partial interface INodesClient
    {
        /// <summary>
        /// Get node status by collection<br/>
        /// Retrieves status information only for the nodes that host shards for the specified collection (`className`). Use the `output` query parameter to control the level of detail.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="shardName"></param>
        /// <param name="output">
        /// Default Value: minimal
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.NodesStatusResponse> NodesGetClassAsync(
            string className,
            string? shardName = default,
            string? output = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get node status by collection<br/>
        /// Retrieves status information only for the nodes that host shards for the specified collection (`className`). Use the `output` query parameter to control the level of detail.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="shardName"></param>
        /// <param name="output">
        /// Default Value: minimal
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.NodesStatusResponse>> NodesGetClassAsResponseAsync(
            string className,
            string? shardName = default,
            string? output = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}