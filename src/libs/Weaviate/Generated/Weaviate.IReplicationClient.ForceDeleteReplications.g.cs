#nullable enable

namespace Weaviate
{
    public partial interface IReplicationClient
    {
        /// <summary>
        /// Force delete replication operations<br/>
        /// USE AT OWN RISK! Synchronously force delete operations from the FSM. This will not perform any checks on which state the operation is in so may lead to data corruption or loss. It is recommended to first scale the number of replication engine workers to 0 before calling this endpoint to ensure no operations are in-flight.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ReplicationReplicateForceDeleteResponse> ForceDeleteReplicationsAsync(

            global::Weaviate.ReplicationReplicateForceDeleteRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Force delete replication operations<br/>
        /// USE AT OWN RISK! Synchronously force delete operations from the FSM. This will not perform any checks on which state the operation is in so may lead to data corruption or loss. It is recommended to first scale the number of replication engine workers to 0 before calling this endpoint to ensure no operations are in-flight.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.ReplicationReplicateForceDeleteResponse>> ForceDeleteReplicationsAsResponseAsync(

            global::Weaviate.ReplicationReplicateForceDeleteRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Force delete replication operations<br/>
        /// USE AT OWN RISK! Synchronously force delete operations from the FSM. This will not perform any checks on which state the operation is in so may lead to data corruption or loss. It is recommended to first scale the number of replication engine workers to 0 before calling this endpoint to ensure no operations are in-flight.
        /// </summary>
        /// <param name="id">
        /// The unique identifier (ID) of the replication operation to be forcefully deleted.
        /// </param>
        /// <param name="collection">
        /// The name of the collection to which the shard being replicated belongs.
        /// </param>
        /// <param name="shard">
        /// The identifier of the shard involved in the replication operations.
        /// </param>
        /// <param name="node">
        /// The name of the target node where the replication operations are registered.
        /// </param>
        /// <param name="dryRun">
        /// If true, the operation will not actually delete anything but will return the expected outcome of the deletion.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ReplicationReplicateForceDeleteResponse> ForceDeleteReplicationsAsync(
            global::System.Guid? id = default,
            string? collection = default,
            string? shard = default,
            string? node = default,
            bool? dryRun = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}