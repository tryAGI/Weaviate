#nullable enable

namespace Weaviate
{
    public partial interface IAuthzClient
    {
        /// <summary>
        /// Revoke a role from a group
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task RevokeRoleFromGroupAsync(
            string id,
            global::Weaviate.RevokeRoleFromGroupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Revoke a role from a group
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roles">
        /// the roles that revoked from group
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RevokeRoleFromGroupAsync(
            string id,
            global::System.Collections.Generic.IList<string>? roles = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}