
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Request body for the aggregate endpoint. Phase 1 supports counts: the number of matching objects, in total or per group. Unknown fields are ignored (platform parity with the other endpoints). Reserved fields are accepted by the schema but rejected by the server with 422 until the corresponding feature ships. An empty body `{}` returns the collection's total object count.
    /// </summary>
    public sealed partial class AggregateRequest
    {
        /// <summary>
        /// The property to group by, as a bare property name. Each distinct value of the property forms one group (an object whose property holds several values counts toward each of them). Omitted or empty aggregates over all matching objects without grouping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupBy")]
        public string? GroupBy { get; set; }

        /// <summary>
        /// The aggregation metrics to return. Phase 1 supports only `count` (the number of matching objects, per group when `groupBy` is set); omitted or empty is equivalent to `["count"]`. The property-scoped `property:statistic` grammar (e.g. `price:mean`) is reserved and returns 422 (not yet supported).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnMetrics")]
        public global::System.Collections.Generic.IList<string>? ReturnMetrics { get; set; }

        /// <summary>
        /// Filter search results using a where filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("where")]
        public global::Weaviate.WhereFilter? Where { get; set; }

        /// <summary>
        /// The maximum number of groups to return, largest first. Must be positive and requires `groupBy`; omitted falls back to the server default (100 groups).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// The tenant to aggregate in a multi-tenant collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        public string? Tenant { get; set; }

        /// <summary>
        /// Reserved for aggregate-over-search (aggregating the results of a vector, keyword or hybrid search). Returns 422 (not yet supported).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("over")]
        public object? Over { get; set; }

        /// <summary>
        /// Reserved for aggregate-over-search (the maximum number of search results to aggregate). Returns 422 (not yet supported).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectLimit")]
        public long? ObjectLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AggregateRequest(
            string? groupBy,
            global::System.Collections.Generic.IList<string>? returnMetrics,
            global::Weaviate.WhereFilter? where,
            long? limit,
            string? tenant,
            object? over,
            long? objectLimit)
        {
            this.GroupBy = groupBy;
            this.ReturnMetrics = returnMetrics;
            this.Where = where;
            this.Limit = limit;
            this.Tenant = tenant;
            this.Over = over;
            this.ObjectLimit = objectLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateRequest" /> class.
        /// </summary>
        public AggregateRequest()
        {
        }

    }
}