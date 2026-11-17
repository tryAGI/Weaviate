#nullable enable

namespace Weaviate
{
    public partial interface INamespacesClient
    {
        /// <summary>
        /// Create a new namespace<br/>
        /// Create a new cluster-level namespace with the given name. Names must contain only lowercase letters, digits, and hyphens, must start and end with a letter or digit, must be 3-36 characters long, and must not be a reserved name.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Namespace> CreateNamespaceAsync(
            string namespaceId,

            global::Weaviate.NamespaceCreateRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new namespace<br/>
        /// Create a new cluster-level namespace with the given name. Names must contain only lowercase letters, digits, and hyphens, must start and end with a letter or digit, must be 3-36 characters long, and must not be a reserved name.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.Namespace>> CreateNamespaceAsResponseAsync(
            string namespaceId,

            global::Weaviate.NamespaceCreateRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new namespace<br/>
        /// Create a new cluster-level namespace with the given name. Names must contain only lowercase letters, digits, and hyphens, must start and end with a letter or digit, must be 3-36 characters long, and must not be a reserved name.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="homeNodes">
        /// Optional cluster nodes to place this namespace's shards on. Entries must be distinct current storage candidates, at least `REPLICATION_MINIMUM_FACTOR` of them. When this and `home_node` are both omitted or empty, the cluster picks `REPLICATION_MAXIMUM_FACTOR` nodes, or every storage node when there are fewer. It refuses that create when `REPLICATION_MAXIMUM_FACTOR` is unset or 0 or below, or when there are fewer storage nodes than `REPLICATION_MINIMUM_FACTOR`. List order decides placement. A collection or tenant with replication factor N goes on the first N entries that are storage nodes, so the first of those receives every factor-1 placement. Until every node runs this release, send only home_node: older nodes ignore home_nodes on create and pick a home node themselves.
        /// </param>
        /// <param name="homeNode">
        /// Deprecated: use home_nodes. A value is taken as a one-entry `home_nodes`. Sending it with a non-empty `home_nodes` is a 422, even when it equals the first entry.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Namespace> CreateNamespaceAsync(
            string namespaceId,
            global::System.Collections.Generic.IList<string>? homeNodes = default,
            string? homeNode = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}