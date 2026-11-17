
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// One group of a grouped aggregation: the group's identity under `groupedBy` and its aggregated metrics (phase 1: `count`).
    /// </summary>
    public sealed partial class AggregateGroup
    {
        /// <summary>
        /// The identity of one group: the `groupBy` property (as a one-element path) and the property value that formed the group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weaviate.AggregateGroupedBy GroupedBy { get; set; }

        /// <summary>
        /// The number of objects in the group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateGroup" /> class.
        /// </summary>
        /// <param name="groupedBy">
        /// The identity of one group: the `groupBy` property (as a one-element path) and the property value that formed the group.
        /// </param>
        /// <param name="count">
        /// The number of objects in the group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AggregateGroup(
            global::Weaviate.AggregateGroupedBy groupedBy,
            long count)
        {
            this.GroupedBy = groupedBy ?? throw new global::System.ArgumentNullException(nameof(groupedBy));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateGroup" /> class.
        /// </summary>
        public AggregateGroup()
        {
        }

    }
}