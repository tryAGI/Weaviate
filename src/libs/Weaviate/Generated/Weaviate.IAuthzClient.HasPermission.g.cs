#nullable enable

namespace Weaviate
{
    public partial interface IAuthzClient
    {
        /// <summary>
        /// Check whether a role possesses a permission<br/>
        /// Check whether a role has the specified permissions.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> HasPermissionAsync(
            string id,

            global::Weaviate.Permission request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check whether a role possesses a permission<br/>
        /// Check whether a role has the specified permissions.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<bool>> HasPermissionAsResponseAsync(
            string id,

            global::Weaviate.Permission request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check whether a role possesses a permission<br/>
        /// Check whether a role has the specified permissions.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="backups">
        /// Resources applicable for backup actions.
        /// </param>
        /// <param name="data">
        /// Resources applicable for data actions.
        /// </param>
        /// <param name="nodes">
        /// Resources applicable for cluster actions.
        /// </param>
        /// <param name="users">
        /// Resources applicable for user actions.
        /// </param>
        /// <param name="groups">
        /// Resources applicable for group actions.
        /// </param>
        /// <param name="tenants">
        /// Resources applicable for tenant actions.
        /// </param>
        /// <param name="roles">
        /// Resources applicable for role actions.
        /// </param>
        /// <param name="collections">
        /// Resources applicable for collection and/or tenant actions.
        /// </param>
        /// <param name="replicate">
        /// resources applicable for replicate actions
        /// </param>
        /// <param name="aliases">
        /// Resource definition for alias-related actions and permissions. Used to specify which aliases and collections can be accessed or modified.
        /// </param>
        /// <param name="namespaces">
        /// Resources applicable for namespace actions.
        /// </param>
        /// <param name="action">
        /// Allowed actions in weaviate.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> HasPermissionAsync(
            string id,
            global::Weaviate.PermissionAction action,
            global::Weaviate.PermissionBackups? backups = default,
            global::Weaviate.PermissionData? data = default,
            global::Weaviate.PermissionNodes? nodes = default,
            global::Weaviate.PermissionUsers? users = default,
            global::Weaviate.PermissionGroups? groups = default,
            global::Weaviate.PermissionTenants? tenants = default,
            global::Weaviate.PermissionRoles? roles = default,
            global::Weaviate.PermissionCollections? collections = default,
            global::Weaviate.PermissionReplicate? replicate = default,
            global::Weaviate.PermissionAliases? aliases = default,
            global::Weaviate.PermissionNamespaces? namespaces = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}