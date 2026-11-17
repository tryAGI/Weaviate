#nullable enable

namespace Weaviate
{
    public partial interface IAggregateClient
    {
        /// <summary>
        /// Aggregate over a collection<br/>
        /// Aggregates over the objects of a collection. Phase 1 supports counts: the number of matching objects, either in total (flat `count` response) or per group of a `groupBy` property (`groups` response). A `where` filter limits the objects that are aggregated; an empty body returns the collection's total object count.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AggregateResponse> AggregateAsync(
            string collection,

            global::Weaviate.AggregateRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Aggregate over a collection<br/>
        /// Aggregates over the objects of a collection. Phase 1 supports counts: the number of matching objects, either in total (flat `count` response) or per group of a `groupBy` property (`groups` response). A `where` filter limits the objects that are aggregated; an empty body returns the collection's total object count.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.AggregateResponse>> AggregateAsResponseAsync(
            string collection,

            global::Weaviate.AggregateRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Aggregate over a collection<br/>
        /// Aggregates over the objects of a collection. Phase 1 supports counts: the number of matching objects, either in total (flat `count` response) or per group of a `groupBy` property (`groups` response). A `where` filter limits the objects that are aggregated; an empty body returns the collection's total object count.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="groupBy">
        /// The property to group by, as a bare property name. Each distinct value of the property forms one group (an object whose property holds several values counts toward each of them). Omitted or empty aggregates over all matching objects without grouping.
        /// </param>
        /// <param name="returnMetrics">
        /// The aggregation metrics to return. Phase 1 supports only `count` (the number of matching objects, per group when `groupBy` is set); omitted or empty is equivalent to `["count"]`. The property-scoped `property:statistic` grammar (e.g. `price:mean`) is reserved and returns 422 (not yet supported).
        /// </param>
        /// <param name="where">
        /// Filter search results using a where filter.
        /// </param>
        /// <param name="limit">
        /// The maximum number of groups to return, largest first. Must be positive and requires `groupBy`; omitted falls back to the server default (100 groups).
        /// </param>
        /// <param name="tenant">
        /// The tenant to aggregate in a multi-tenant collection.
        /// </param>
        /// <param name="over">
        /// Reserved for aggregate-over-search (aggregating the results of a vector, keyword or hybrid search). Returns 422 (not yet supported).
        /// </param>
        /// <param name="objectLimit">
        /// Reserved for aggregate-over-search (the maximum number of search results to aggregate). Returns 422 (not yet supported).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AggregateResponse> AggregateAsync(
            string collection,
            string? groupBy = default,
            global::System.Collections.Generic.IList<string>? returnMetrics = default,
            global::Weaviate.WhereFilter? where = default,
            long? limit = default,
            string? tenant = default,
            object? over = default,
            long? objectLimit = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}