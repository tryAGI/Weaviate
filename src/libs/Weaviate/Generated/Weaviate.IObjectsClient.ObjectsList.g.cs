#nullable enable

namespace Weaviate
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Get a list of objects.<br/>
        /// Lists all objects in reverse order of creation. The data will be returned as an array of objects. &lt;br/&gt;&lt;br/&gt;Tip: If you are looking to list all objects in a collection, use the `after` parameter.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="offset">
        /// Default Value: 0L
        /// </param>
        /// <param name="limit">
        /// Default Value: 25L
        /// </param>
        /// <param name="include"></param>
        /// <param name="sort"></param>
        /// <param name="order"></param>
        /// <param name="class"></param>
        /// <param name="tenant"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ObjectsListResponse> ObjectsListAsync(
            string? after = default,
            long? offset = 0L,
            long? limit = 25L,
            string? include = default,
            string? sort = default,
            global::Weaviate.ObjectsListOrder? order = default,
            string? @class = default,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}