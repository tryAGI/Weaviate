#nullable enable

namespace Weaviate
{
    public partial interface IReplicationClient
    {
        /// <summary>
        /// Apply replication scaling plan<br/>
        /// Apply a replication scaling plan that specifies nodes to add or remove per shard for a given collection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ReplicationScaleApplyResponse> ApplyReplicationScalePlanAsync(

            global::Weaviate.ReplicationScalePlan request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply replication scaling plan<br/>
        /// Apply a replication scaling plan that specifies nodes to add or remove per shard for a given collection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.ReplicationScaleApplyResponse>> ApplyReplicationScalePlanAsResponseAsync(

            global::Weaviate.ReplicationScalePlan request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply replication scaling plan<br/>
        /// Apply a replication scaling plan that specifies nodes to add or remove per shard for a given collection.
        /// </summary>
        /// <param name="planId">
        /// A unique identifier for this replication scaling plan, useful for tracking and auditing purposes.
        /// </param>
        /// <param name="collection">
        /// The name of the collection to which this replication scaling plan applies.
        /// </param>
        /// <param name="shardScaleActions">
        /// A mapping of shard names to their corresponding scaling actions. Each key corresponds to a shard name, and its value defines which nodes should be removed and which should be added for that shard. If a source node listed for an addition is also in 'removeNodes' for the same shard, that addition is treated as a move operation. Such a node can appear only once as a source in that shard. Otherwise, if the source node is not being removed, it represents a copy operation and can be referenced multiple times as a source for additions.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ReplicationScaleApplyResponse> ApplyReplicationScalePlanAsync(
            global::System.Guid planId,
            string collection,
            global::System.Collections.Generic.Dictionary<string, global::Weaviate.ReplicationScalePlanShardScaleActions2> shardScaleActions,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}