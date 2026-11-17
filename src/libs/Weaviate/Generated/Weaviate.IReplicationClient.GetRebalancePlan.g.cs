#nullable enable

namespace Weaviate
{
    public partial interface IReplicationClient
    {
        /// <summary>
        /// Get the rebalance plan<br/>
        /// Returns the cluster's rebalance plan, including the node measurements and baseline balance taken by its planning run.
        /// </summary>
        /// <param name="consistency">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ReplicationRebalancePlan> GetRebalancePlanAsync(
            bool? consistency = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the rebalance plan<br/>
        /// Returns the cluster's rebalance plan, including the node measurements and baseline balance taken by its planning run.
        /// </summary>
        /// <param name="consistency">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.ReplicationRebalancePlan>> GetRebalancePlanAsResponseAsync(
            bool? consistency = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}