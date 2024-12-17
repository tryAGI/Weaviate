#nullable enable

namespace Weaviate
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Deletes Objects based on a match filter as a batch.<br/>
        /// Batch delete objects that match a particular filter. &lt;br/&gt;&lt;br/&gt;The request body takes a single `where` filter and will delete all objects matched. &lt;br/&gt;&lt;br/&gt;Note that there is a limit to the number of objects to be deleted at once using this filter, in order to protect against unexpected memory surges and very-long-running requests. The default limit is 10,000 and may be configured by setting the `QUERY_MAXIMUM_RESULTS` environment variable. &lt;br/&gt;&lt;br/&gt;Objects are deleted in the same order that they would be returned in an equivalent Get query. To delete more objects than the limit, run the same query multiple times.
        /// </summary>
        /// <param name="consistencyLevel"></param>
        /// <param name="tenant"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.BatchDeleteResponse> BatchObjectsDeleteAsync(
            global::Weaviate.BatchDelete request,
            string? consistencyLevel = default,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes Objects based on a match filter as a batch.<br/>
        /// Batch delete objects that match a particular filter. &lt;br/&gt;&lt;br/&gt;The request body takes a single `where` filter and will delete all objects matched. &lt;br/&gt;&lt;br/&gt;Note that there is a limit to the number of objects to be deleted at once using this filter, in order to protect against unexpected memory surges and very-long-running requests. The default limit is 10,000 and may be configured by setting the `QUERY_MAXIMUM_RESULTS` environment variable. &lt;br/&gt;&lt;br/&gt;Objects are deleted in the same order that they would be returned in an equivalent Get query. To delete more objects than the limit, run the same query multiple times.
        /// </summary>
        /// <param name="consistencyLevel"></param>
        /// <param name="tenant"></param>
        /// <param name="match">
        /// Outlines how to find the objects to be deleted.
        /// </param>
        /// <param name="output">
        /// Controls the verbosity of the output, possible values are: "minimal", "verbose". Defaults to "minimal".<br/>
        /// Default Value: minimal
        /// </param>
        /// <param name="deletionTimeUnixMilli">
        /// Timestamp of deletion in milliseconds since epoch UTC.
        /// </param>
        /// <param name="dryRun">
        /// If true, the call will show which objects would be matched using the specified filter without deleting any objects. &lt;br/&gt;&lt;br/&gt;Depending on the configured verbosity, you will either receive a count of affected objects, or a list of IDs.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.BatchDeleteResponse> BatchObjectsDeleteAsync(
            string? consistencyLevel = default,
            string? tenant = default,
            global::Weaviate.BatchDeleteMatch? match = default,
            string? output = default,
            long? deletionTimeUnixMilli = default,
            bool? dryRun = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}