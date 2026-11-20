#nullable enable

namespace Weaviate
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Create objects in batch<br/>
        /// Registers multiple data objects in a single request for efficiency. Metadata and schema values for each object are validated.&lt;br/&gt;&lt;br/&gt;**Note (idempotence)**:&lt;br/&gt;This operation is idempotent based on the object UUIDs provided. If an object with a given UUID already exists, it will be overwritten (similar to a PUT operation for that specific object within the batch).
        /// </summary>
        /// <param name="consistencyLevel"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.ObjectsGetResponse>> BatchObjectsCreateAsync(

            global::Weaviate.BatchObjectsCreateRequest request,
            string? consistencyLevel = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create objects in batch<br/>
        /// Registers multiple data objects in a single request for efficiency. Metadata and schema values for each object are validated.&lt;br/&gt;&lt;br/&gt;**Note (idempotence)**:&lt;br/&gt;This operation is idempotent based on the object UUIDs provided. If an object with a given UUID already exists, it will be overwritten (similar to a PUT operation for that specific object within the batch).
        /// </summary>
        /// <param name="consistencyLevel"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Weaviate.ObjectsGetResponse>>> BatchObjectsCreateAsResponseAsync(

            global::Weaviate.BatchObjectsCreateRequest request,
            string? consistencyLevel = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create objects in batch<br/>
        /// Registers multiple data objects in a single request for efficiency. Metadata and schema values for each object are validated.&lt;br/&gt;&lt;br/&gt;**Note (idempotence)**:&lt;br/&gt;This operation is idempotent based on the object UUIDs provided. If an object with a given UUID already exists, it will be overwritten (similar to a PUT operation for that specific object within the batch).
        /// </summary>
        /// <param name="consistencyLevel"></param>
        /// <param name="fields">
        /// Controls which fields are returned in the response for each object. Default is `ALL`.
        /// </param>
        /// <param name="objects">
        /// Array of objects to be created. Each object needs a `class`; an object without one fails on its own and the rest of the batch is still imported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.ObjectsGetResponse>> BatchObjectsCreateAsync(
            string? consistencyLevel = default,
            global::System.Collections.Generic.IList<global::Weaviate.BatchObjectsCreateRequestField>? fields = default,
            global::System.Collections.Generic.IList<global::Weaviate.Object>? objects = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}