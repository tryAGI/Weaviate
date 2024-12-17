#nullable enable

namespace Weaviate
{
    public partial interface IAuthzClient
    {
        /// <summary>
        /// get roles assigned to user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.Role>> GetRolesForUserAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}