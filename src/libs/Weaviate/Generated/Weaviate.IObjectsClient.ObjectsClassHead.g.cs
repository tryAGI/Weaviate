#nullable enable

namespace Weaviate
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Check if an object exists<br/>
        /// Verifies the existence of a specific data object within a collection (class), identified by its collection name (`className`) and UUID (`id`), without returning the object itself.&lt;br/&gt;&lt;br/&gt;This is faster than a GET request as it avoids retrieving and processing object data. Existence is confirmed by a 204 No Content status code, while non-existence results in a 404 Not Found.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="consistencyLevel"></param>
        /// <param name="tenant"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task ObjectsClassHeadAsync(
            string className,
            global::System.Guid id,
            string? consistencyLevel = default,
            string? tenant = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check if an object exists<br/>
        /// Verifies the existence of a specific data object within a collection (class), identified by its collection name (`className`) and UUID (`id`), without returning the object itself.&lt;br/&gt;&lt;br/&gt;This is faster than a GET request as it avoids retrieving and processing object data. Existence is confirmed by a 204 No Content status code, while non-existence results in a 404 Not Found.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="consistencyLevel"></param>
        /// <param name="tenant"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> ObjectsClassHeadAsResponseAsync(
            string className,
            global::System.Guid id,
            string? consistencyLevel = default,
            string? tenant = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}