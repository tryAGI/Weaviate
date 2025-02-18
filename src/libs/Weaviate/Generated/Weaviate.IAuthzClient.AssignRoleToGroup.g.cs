#nullable enable

namespace Weaviate
{
    public partial interface IAuthzClient
    {
        /// <summary>
        /// Assign a role to a group
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task AssignRoleToGroupAsync(
            string id,
            global::Weaviate.AssignRoleToGroupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Assign a role to a group
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roles">
        /// the roles that assigned to group
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AssignRoleToGroupAsync(
            string id,
            global::System.Collections.Generic.IList<string>? roles = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}