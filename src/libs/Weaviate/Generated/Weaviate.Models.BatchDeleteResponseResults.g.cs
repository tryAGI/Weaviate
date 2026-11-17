
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchDeleteResponseResults
    {
        /// <summary>
        /// How many objects matched the filter. With a positive `limit` the count stops one above `limit`: at or below `limit` this is the exact number of matching objects and every one of them was handled by this call, and above `limit` more objects match than one call deletes, so call again. With a `limit` of 0 or below this is the exact number of matching objects and the call deletes none of them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        public double? Matches { get; set; }

        /// <summary>
        /// The most amount of objects that can be deleted in a single query, equals [`QUERY_MAXIMUM_RESULTS`](https://docs.weaviate.io/deploy/configuration/env-vars#QUERY_MAXIMUM_RESULTS).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// How many objects were successfully deleted in this round.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        public double? Successful { get; set; }

        /// <summary>
        /// How many objects should have been deleted but could not be deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public double? Failed { get; set; }

        /// <summary>
        /// With output set to `minimal` only objects with error occurred will the be described. Successfully deleted objects would be omitted. Output set to `verbose` will list all of the objects with their respective statuses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objects")]
        public global::System.Collections.Generic.IList<global::Weaviate.BatchDeleteResponseResultsObject>? Objects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteResponseResults" /> class.
        /// </summary>
        /// <param name="matches">
        /// How many objects matched the filter. With a positive `limit` the count stops one above `limit`: at or below `limit` this is the exact number of matching objects and every one of them was handled by this call, and above `limit` more objects match than one call deletes, so call again. With a `limit` of 0 or below this is the exact number of matching objects and the call deletes none of them.
        /// </param>
        /// <param name="limit">
        /// The most amount of objects that can be deleted in a single query, equals [`QUERY_MAXIMUM_RESULTS`](https://docs.weaviate.io/deploy/configuration/env-vars#QUERY_MAXIMUM_RESULTS).
        /// </param>
        /// <param name="successful">
        /// How many objects were successfully deleted in this round.
        /// </param>
        /// <param name="failed">
        /// How many objects should have been deleted but could not be deleted.
        /// </param>
        /// <param name="objects">
        /// With output set to `minimal` only objects with error occurred will the be described. Successfully deleted objects would be omitted. Output set to `verbose` will list all of the objects with their respective statuses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchDeleteResponseResults(
            double? matches,
            double? limit,
            double? successful,
            double? failed,
            global::System.Collections.Generic.IList<global::Weaviate.BatchDeleteResponseResultsObject>? objects)
        {
            this.Matches = matches;
            this.Limit = limit;
            this.Successful = successful;
            this.Failed = failed;
            this.Objects = objects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteResponseResults" /> class.
        /// </summary>
        public BatchDeleteResponseResults()
        {
        }

    }
}