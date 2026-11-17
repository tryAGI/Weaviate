#nullable enable

namespace Weaviate
{
    public partial interface IReplicationClient
    {
        /// <summary>
        /// Get replication scale plan<br/>
        /// Computes and returns a replication scale plan for a given collection and desired replication factor. The plan includes, for each shard, a list of nodes to be added and a list of nodes to be removed.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="replicationFactor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ReplicationScalePlan> GetReplicationScalePlanAsync(
            string collection,
            int replicationFactor,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get replication scale plan<br/>
        /// Computes and returns a replication scale plan for a given collection and desired replication factor. The plan includes, for each shard, a list of nodes to be added and a list of nodes to be removed.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="replicationFactor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.ReplicationScalePlan>> GetReplicationScalePlanAsResponseAsync(
            string collection,
            int replicationFactor,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}