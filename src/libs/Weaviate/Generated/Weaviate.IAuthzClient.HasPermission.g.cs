#nullable enable

namespace Weaviate
{
    public partial interface IAuthzClient
    {
        /// <summary>
        /// Check whether role possesses this permission.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> HasPermissionAsync(
            string id,
            global::Weaviate.Permission request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check whether role possesses this permission.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="backups">
        /// resources applicable for backup actions
        /// </param>
        /// <param name="data">
        /// resources applicable for data actions
        /// </param>
        /// <param name="nodes">
        /// resources applicable for cluster actions
        /// </param>
        /// <param name="roles">
        /// resources applicable for role actions
        /// </param>
        /// <param name="collections">
        /// resources applicable for collection and/or tenant actions
        /// </param>
        /// <param name="action">
        /// allowed actions in weaviate.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> HasPermissionAsync(
            string id,
            global::Weaviate.PermissionAction action,
            global::Weaviate.PermissionBackups? backups = default,
            global::Weaviate.PermissionData? data = default,
            global::Weaviate.PermissionNodes? nodes = default,
            global::Weaviate.PermissionRoles? roles = default,
            global::Weaviate.PermissionCollections? collections = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}