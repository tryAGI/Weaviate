#nullable enable

namespace Weaviate
{
    public partial interface IReplicationClient
    {
        /// <summary>
        /// Retrieve a replication operation<br/>
        /// Fetches the current status and detailed information for a specific replication operation, identified by its unique ID. Optionally includes historical data of the operation's progress if requested.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeHistory"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ReplicationReplicateDetailsReplicaResponse> ReplicationDetailsAsync(
            global::System.Guid id,
            bool? includeHistory = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a replication operation<br/>
        /// Fetches the current status and detailed information for a specific replication operation, identified by its unique ID. Optionally includes historical data of the operation's progress if requested.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeHistory"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.ReplicationReplicateDetailsReplicaResponse>> ReplicationDetailsAsResponseAsync(
            global::System.Guid id,
            bool? includeHistory = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}