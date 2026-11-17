
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The identity of one group: the `groupBy` property (as a one-element path) and the property value that formed the group.
    /// </summary>
    public sealed partial class AggregateGroupedBy
    {
        /// <summary>
        /// The grouped property, as a one-element path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Path { get; set; }

        /// <summary>
        /// The property value that formed the group. Typed as the property is: text values are strings, numeric values numbers, boolean values booleans; grouping by a reference property yields the reference's beacon URI as a string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateGroupedBy" /> class.
        /// </summary>
        /// <param name="path">
        /// The grouped property, as a one-element path.
        /// </param>
        /// <param name="value">
        /// The property value that formed the group. Typed as the property is: text values are strings, numeric values numbers, boolean values booleans; grouping by a reference property yields the reference's beacon URI as a string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AggregateGroupedBy(
            global::System.Collections.Generic.IList<string> path,
            object value)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateGroupedBy" /> class.
        /// </summary>
        public AggregateGroupedBy()
        {
        }

    }
}