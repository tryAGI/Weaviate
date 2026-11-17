#nullable enable

namespace Weaviate
{
    public partial interface IReplicationClient
    {
        /// <summary>
        /// List replication operations<br/>
        /// Retrieves a list of currently registered replication operations, optionally filtered by collection, shard, or node ID.
        /// </summary>
        /// <param name="targetNode"></param>
        /// <param name="collection"></param>
        /// <param name="shard"></param>
        /// <param name="includeHistory"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.ReplicationReplicateDetailsReplicaResponse>> ListReplicationAsync(
            string? targetNode = default,
            string? collection = default,
            string? shard = default,
            bool? includeHistory = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List replication operations<br/>
        /// Retrieves a list of currently registered replication operations, optionally filtered by collection, shard, or node ID.
        /// </summary>
        /// <param name="targetNode"></param>
        /// <param name="collection"></param>
        /// <param name="shard"></param>
        /// <param name="includeHistory"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Weaviate.ReplicationReplicateDetailsReplicaResponse>>> ListReplicationAsResponseAsync(
            string? targetNode = default,
            string? collection = default,
            string? shard = default,
            bool? includeHistory = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}