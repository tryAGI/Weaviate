#nullable enable

namespace Weaviate
{
    public partial interface IAuthzClient
    {
        /// <summary>
        /// create new role
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateRoleAsync(
            global::Weaviate.Role request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// create new role
        /// </summary>
        /// <param name="name">
        /// role name
        /// </param>
        /// <param name="permissions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateRoleAsync(
            string name,
            global::System.Collections.Generic.IList<global::Weaviate.Permission> permissions,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}