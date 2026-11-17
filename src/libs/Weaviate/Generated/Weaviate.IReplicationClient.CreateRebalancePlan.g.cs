#nullable enable

namespace Weaviate
{
    public partial interface IReplicationClient
    {
        /// <summary>
        /// Create a rebalance plan<br/>
        /// Creates the cluster's rebalance plan in the `PLANNING` state and starts an asynchronous planning run. The run measures the listed source and target nodes and decides whether their shard replicas need rebalancing. GET /replication/rebalance reports the plan and its outcome. A new plan replaces a finished one; an unfinished plan blocks it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ReplicationRebalanceCreateResponse> CreateRebalancePlanAsync(

            global::Weaviate.ReplicationRebalanceRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a rebalance plan<br/>
        /// Creates the cluster's rebalance plan in the `PLANNING` state and starts an asynchronous planning run. The run measures the listed source and target nodes and decides whether their shard replicas need rebalancing. GET /replication/rebalance reports the plan and its outcome. A new plan replaces a finished one; an unfinished plan blocks it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.ReplicationRebalanceCreateResponse>> CreateRebalancePlanAsResponseAsync(

            global::Weaviate.ReplicationRebalanceRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a rebalance plan<br/>
        /// Creates the cluster's rebalance plan in the `PLANNING` state and starts an asynchronous planning run. The run measures the listed source and target nodes and decides whether their shard replicas need rebalancing. GET /replication/rebalance reports the plan and its outcome. A new plan replaces a finished one; an unfinished plan blocks it.
        /// </summary>
        /// <param name="sourceNodes">
        /// The names of the nodes that replicas move away from. The list must be non-empty, must not repeat a node, and must not share a node with `targetNodes`.
        /// </param>
        /// <param name="targetNodes">
        /// The names of the nodes that replicas move to. The list must be non-empty, must not repeat a node, and must not share a node with `sourceNodes`.
        /// </param>
        /// <param name="collections">
        /// The names of the collections the plan covers. The value is stored with the plan and does not yet affect planning.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ReplicationRebalanceCreateResponse> CreateRebalancePlanAsync(
            global::System.Collections.Generic.IList<string>? sourceNodes = default,
            global::System.Collections.Generic.IList<string>? targetNodes = default,
            global::System.Collections.Generic.IList<string>? collections = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}