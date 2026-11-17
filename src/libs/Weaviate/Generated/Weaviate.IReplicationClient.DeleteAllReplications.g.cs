#nullable enable

namespace Weaviate
{
    public partial interface IReplicationClient
    {
        /// <summary>
        /// Delete all replication operations<br/>
        /// Schedules all replication operations for deletion across all collections, shards, and nodes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAllReplicationsAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete all replication operations<br/>
        /// Schedules all replication operations for deletion across all collections, shards, and nodes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> DeleteAllReplicationsAsResponseAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}