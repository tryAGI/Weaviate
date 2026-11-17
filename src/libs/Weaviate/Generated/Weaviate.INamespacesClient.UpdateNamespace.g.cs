#nullable enable

namespace Weaviate
{
    public partial interface INamespacesClient
    {
        /// <summary>
        /// Update a namespace<br/>
        /// Update a namespace's `home_nodes`. The new list replaces the namespace's list and applies to future placement decisions only (new collection create, new tenant create, offloaded-tenant reactivation). Existing live shards are not moved.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Namespace> UpdateNamespaceAsync(
            string namespaceId,

            global::Weaviate.NamespaceUpdateRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a namespace<br/>
        /// Update a namespace's `home_nodes`. The new list replaces the namespace's list and applies to future placement decisions only (new collection create, new tenant create, offloaded-tenant reactivation). Existing live shards are not moved.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.Namespace>> UpdateNamespaceAsResponseAsync(
            string namespaceId,

            global::Weaviate.NamespaceUpdateRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a namespace<br/>
        /// Update a namespace's `home_nodes`. The new list replaces the namespace's list and applies to future placement decisions only (new collection create, new tenant create, offloaded-tenant reactivation). Existing live shards are not moved.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="homeNodes">
        /// Cluster nodes to place this namespace's shards on. The list replaces the namespace's home nodes for placements made after the update, and existing shards stay on their nodes. Entries must be distinct current storage candidates, at least `REPLICATION_MINIMUM_FACTOR` of them, and at least the largest replication factor among the namespace's collections. Unlike on create, an empty list does not auto-pick, so a body with neither this nor `home_node` is a 422. List order decides placement. A collection or tenant with replication factor N goes on the first N entries that are storage nodes, so the first of those receives every factor-1 placement. Until every node runs this release, send only home_node: older nodes refuse an update without it.
        /// </param>
        /// <param name="homeNode">
        /// Deprecated: use home_nodes. A value is taken as a one-entry `home_nodes`. Sending it with a non-empty `home_nodes` is a 422, even when it equals the first entry.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Namespace> UpdateNamespaceAsync(
            string namespaceId,
            global::System.Collections.Generic.IList<string>? homeNodes = default,
            string? homeNode = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}