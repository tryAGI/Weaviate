#nullable enable

namespace Weaviate
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// List objects<br/>
        /// Retrieves a list of data objects from the collection named in the `class` parameter. By default, objects are returned in reverse order of creation. &lt;br/&gt;&lt;br/&gt;**Note**: Calling this endpoint without `class` is deprecated and will be removed in a future version. Without `class`, it lists objects across all collections. Some cluster configurations do not support a request without `class`.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
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
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List objects<br/>
        /// Retrieves a list of data objects from the collection named in the `class` parameter. By default, objects are returned in reverse order of creation. &lt;br/&gt;&lt;br/&gt;**Note**: Calling this endpoint without `class` is deprecated and will be removed in a future version. Without `class`, it lists objects across all collections. Some cluster configurations do not support a request without `class`.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.ObjectsListResponse>> ObjectsListAsResponseAsync(
            string? after = default,
            long? offset = default,
            long? limit = default,
            string? include = default,
            string? sort = default,
            string? order = default,
            string? @class = default,
            string? tenant = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}