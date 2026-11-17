#nullable enable

namespace Weaviate
{
    public partial interface IReplicationClient
    {
        /// <summary>
        /// Delete the rebalance plan<br/>
        /// Removes the cluster's rebalance plan. Only a `PROPOSED` plan or a plan in an end state can be deleted; stop a `PLANNING` plan first. Succeeds when no plan exists.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteRebalancePlanAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete the rebalance plan<br/>
        /// Removes the cluster's rebalance plan. Only a `PROPOSED` plan or a plan in an end state can be deleted; stop a `PLANNING` plan first. Succeeds when no plan exists.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> DeleteRebalancePlanAsResponseAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}