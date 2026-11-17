#nullable enable

namespace Weaviate
{
    public partial interface IReplicationClient
    {
        /// <summary>
        /// Get sharding state<br/>
        /// Fetches the current sharding state, including replica locations and statuses, for all collections or a specified collection. If a shard name is provided along with a collection, the state for that specific shard is returned.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="shard"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ReplicationShardingStateResponse> GetCollectionShardingStateAsync(
            string? collection = default,
            string? shard = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get sharding state<br/>
        /// Fetches the current sharding state, including replica locations and statuses, for all collections or a specified collection. If a shard name is provided along with a collection, the state for that specific shard is returned.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="shard"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.ReplicationShardingStateResponse>> GetCollectionShardingStateAsResponseAsync(
            string? collection = default,
            string? shard = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}