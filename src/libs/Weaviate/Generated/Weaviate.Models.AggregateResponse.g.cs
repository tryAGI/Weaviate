
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The result of an aggregation. An ungrouped aggregation returns the flat form (`count` plus `tookMs`); a grouped aggregation returns `groups` plus `tookMs`. Exactly one of `count`/`groups` is present, except that a grouped aggregation which produced no groups (nothing matched, or no matching object carries the property) omits `groups` entirely.
    /// </summary>
    public sealed partial class AggregateResponse
    {
        /// <summary>
        /// The number of matching objects. Present only for ungrouped aggregations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The groups, ordered by descending count. Present only for grouped aggregations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<global::Weaviate.AggregateGroup>? Groups { get; set; }

        /// <summary>
        /// Server-side processing time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tookMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TookMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateResponse" /> class.
        /// </summary>
        /// <param name="tookMs">
        /// Server-side processing time in milliseconds.
        /// </param>
        /// <param name="count">
        /// The number of matching objects. Present only for ungrouped aggregations.
        /// </param>
        /// <param name="groups">
        /// The groups, ordered by descending count. Present only for grouped aggregations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AggregateResponse(
            long tookMs,
            long? count,
            global::System.Collections.Generic.IList<global::Weaviate.AggregateGroup>? groups)
        {
            this.Count = count;
            this.Groups = groups;
            this.TookMs = tookMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateResponse" /> class.
        /// </summary>
        public AggregateResponse()
        {
        }

    }
}