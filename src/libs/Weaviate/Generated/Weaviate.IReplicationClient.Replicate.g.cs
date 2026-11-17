#nullable enable

namespace Weaviate
{
    public partial interface IReplicationClient
    {
        /// <summary>
        /// Initiate a replica movement<br/>
        /// Begins an asynchronous operation to move or copy a specific shard replica from its current node to a designated target node. The operation involves copying data, synchronizing, and potentially decommissioning the source replica.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ReplicationReplicateReplicaResponse> ReplicateAsync(

            global::Weaviate.ReplicationReplicateReplicaRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Initiate a replica movement<br/>
        /// Begins an asynchronous operation to move or copy a specific shard replica from its current node to a designated target node. The operation involves copying data, synchronizing, and potentially decommissioning the source replica.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.ReplicationReplicateReplicaResponse>> ReplicateAsResponseAsync(

            global::Weaviate.ReplicationReplicateReplicaRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Initiate a replica movement<br/>
        /// Begins an asynchronous operation to move or copy a specific shard replica from its current node to a designated target node. The operation involves copying data, synchronizing, and potentially decommissioning the source replica.
        /// </summary>
        /// <param name="sourceNode">
        /// The name of the Weaviate node currently hosting the shard replica that needs to be moved or copied.
        /// </param>
        /// <param name="targetNode">
        /// The name of the Weaviate node where the new shard replica will be created as part of the movement or copy operation.
        /// </param>
        /// <param name="collection">
        /// The name of the collection to which the target shard belongs.
        /// </param>
        /// <param name="shard">
        /// The name of the shard whose replica is to be moved or copied.
        /// </param>
        /// <param name="type">
        /// Specifies the type of replication operation to perform. `COPY` creates a new replica on the target node while keeping the source replica. `MOVE` creates a new replica on the target node and then removes the source replica upon successful completion. Defaults to `COPY` if omitted.<br/>
        /// Default Value: COPY
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ReplicationReplicateReplicaResponse> ReplicateAsync(
            string sourceNode,
            string targetNode,
            string collection,
            string shard,
            global::Weaviate.ReplicationReplicateReplicaRequestType? type = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}