#nullable enable

namespace Weaviate
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Delete objects in batch<br/>
        /// Removes multiple data objects based on a filter specified in the request body.&lt;br/&gt;&lt;br/&gt;Deletion occurs based on the filter criteria provided in the `where` clause. There is a configurable limit (default 10,000, set via `QUERY_MAXIMUM_RESULTS`) on how many objects can be deleted in a single batch request to prevent excessive resource usage. Objects are deleted in the order they match the filter. To delete more objects than the limit allows, repeat the request until no more matching objects are found.
        /// </summary>
        /// <param name="consistencyLevel"></param>
        /// <param name="tenant"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.BatchDeleteResponse> BatchObjectsDeleteAsync(

            global::Weaviate.BatchDelete request,
            string? consistencyLevel = default,
            string? tenant = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete objects in batch<br/>
        /// Removes multiple data objects based on a filter specified in the request body.&lt;br/&gt;&lt;br/&gt;Deletion occurs based on the filter criteria provided in the `where` clause. There is a configurable limit (default 10,000, set via `QUERY_MAXIMUM_RESULTS`) on how many objects can be deleted in a single batch request to prevent excessive resource usage. Objects are deleted in the order they match the filter. To delete more objects than the limit allows, repeat the request until no more matching objects are found.
        /// </summary>
        /// <param name="consistencyLevel"></param>
        /// <param name="tenant"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.BatchDeleteResponse>> BatchObjectsDeleteAsResponseAsync(

            global::Weaviate.BatchDelete request,
            string? consistencyLevel = default,
            string? tenant = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete objects in batch<br/>
        /// Removes multiple data objects based on a filter specified in the request body.&lt;br/&gt;&lt;br/&gt;Deletion occurs based on the filter criteria provided in the `where` clause. There is a configurable limit (default 10,000, set via `QUERY_MAXIMUM_RESULTS`) on how many objects can be deleted in a single batch request to prevent excessive resource usage. Objects are deleted in the order they match the filter. To delete more objects than the limit allows, repeat the request until no more matching objects are found.
        /// </summary>
        /// <param name="consistencyLevel"></param>
        /// <param name="tenant"></param>
        /// <param name="match">
        /// Outlines how to find the objects to be deleted.
        /// </param>
        /// <param name="output">
        /// Controls the verbosity of the output, possible values are: `minimal`, `verbose`. Defaults to `minimal`.<br/>
        /// Default Value: minimal
        /// </param>
        /// <param name="deletionTimeUnixMilli">
        /// Timestamp of deletion in milliseconds since epoch UTC.
        /// </param>
        /// <param name="dryRun">
        /// If true, the call reports what the filter matches and deletes nothing. &lt;br/&gt;&lt;br/&gt;Depending on the configured verbosity, you will either receive a count of matched objects, or a list of IDs. With a positive [`QUERY_MAXIMUM_RESULTS`](https://docs.weaviate.io/deploy/configuration/env-vars#QUERY_MAXIMUM_RESULTS) the count stops one above it, and the list holds at most `QUERY_MAXIMUM_RESULTS` IDs. Repeating the dry run reports the same count; for an exact total use an aggregate count, which resolves no objects.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.BatchDeleteResponse> BatchObjectsDeleteAsync(
            string? consistencyLevel = default,
            string? tenant = default,
            global::Weaviate.BatchDeleteMatch? match = default,
            string? output = default,
            long? deletionTimeUnixMilli = default,
            bool? dryRun = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}