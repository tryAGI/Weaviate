#nullable enable

namespace Weaviate
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// get info relevant to own user, e.g. username, roles
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.UserInfo> GetOwnInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}