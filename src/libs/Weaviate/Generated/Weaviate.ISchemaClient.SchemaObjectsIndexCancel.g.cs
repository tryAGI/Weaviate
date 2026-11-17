#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Cancel the in-flight reindex task on a property's inverted index<br/>
        /// Cancels the in-flight reindex task targeting this property's index. No request body. Idempotent: succeeds whether or not a task was in flight (a `202` with `{"status":"NO_OP"}` is returned when there is nothing to cancel). A task that is in flight but no longer cancellable is refused with `409`. `indexName` accepts `rangeable` as an alias for `rangeFilters`.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="propertyName"></param>
        /// <param name="indexName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.IndexUpdateResponse> SchemaObjectsIndexCancelAsync(
            string className,
            string propertyName,
            global::Weaviate.SchemaObjectsIndexCancelIndexName indexName,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel the in-flight reindex task on a property's inverted index<br/>
        /// Cancels the in-flight reindex task targeting this property's index. No request body. Idempotent: succeeds whether or not a task was in flight (a `202` with `{"status":"NO_OP"}` is returned when there is nothing to cancel). A task that is in flight but no longer cancellable is refused with `409`. `indexName` accepts `rangeable` as an alias for `rangeFilters`.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="propertyName"></param>
        /// <param name="indexName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.IndexUpdateResponse>> SchemaObjectsIndexCancelAsResponseAsync(
            string className,
            string propertyName,
            global::Weaviate.SchemaObjectsIndexCancelIndexName indexName,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}