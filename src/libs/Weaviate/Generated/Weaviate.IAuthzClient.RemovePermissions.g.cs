#nullable enable

namespace Weaviate
{
    public partial interface IAuthzClient
    {
        /// <summary>
        /// Remove permissions from a role. If this results in an empty role, the role will be deleted.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task RemovePermissionsAsync(
            string id,
            global::Weaviate.RemovePermissionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove permissions from a role. If this results in an empty role, the role will be deleted.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="permissions">
        /// permissions to remove from the role
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RemovePermissionsAsync(
            string id,
            global::System.Collections.Generic.IList<global::Weaviate.Permission> permissions,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}