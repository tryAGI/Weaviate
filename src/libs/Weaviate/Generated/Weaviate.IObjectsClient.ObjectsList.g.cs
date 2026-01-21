#nullable enable

namespace Weaviate
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Get a list of Objects.<br/>
        /// Lists all Objects in reverse order of creation, owned by the user that belongs to the used token.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="sort"></param>
        /// <param name="order"></param>
        /// <param name="class"></param>
        /// <param name="tenant"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ObjectsListResponse> ObjectsListAsync(
            string? after = default,
            long? offset = default,
            long? limit = default,
            string? include = default,
            string? sort = default,
            string? order = default,
            string? @class = default,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}