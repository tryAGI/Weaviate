#nullable enable

namespace Weaviate
{
    public partial interface INamespacesClient
    {
        /// <summary>
        /// Suspend a namespace<br/>
        /// Move a namespace to the "suspended" state. Suspending stops the namespace's users from authenticating and blocks the creation of new classes, aliases, users, roles, and role assignments, but retains the namespace and everything it owns. Repeated calls against an already-suspended namespace are idempotent and return 202. Use the resume endpoint to return it to "active".
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task SuspendNamespaceAsync(
            string namespaceId,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Suspend a namespace<br/>
        /// Move a namespace to the "suspended" state. Suspending stops the namespace's users from authenticating and blocks the creation of new classes, aliases, users, roles, and role assignments, but retains the namespace and everything it owns. Repeated calls against an already-suspended namespace are idempotent and return 202. Use the resume endpoint to return it to "active".
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> SuspendNamespaceAsResponseAsync(
            string namespaceId,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}