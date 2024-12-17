#nullable enable

namespace Weaviate
{
    public partial interface IAuthzClient
    {
        /// <summary>
        /// Add permission to a given role.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task AddPermissionsAsync(
            string id,
            global::Weaviate.AddPermissionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add permission to a given role.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="permissions">
        /// permissions to be added to the role
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AddPermissionsAsync(
            string id,
            global::System.Collections.Generic.IList<global::Weaviate.Permission> permissions,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}