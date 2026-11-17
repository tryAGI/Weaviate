
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The property value that formed the group. Typed as the property is: text values are strings, numeric values numbers, boolean values booleans; grouping by a reference property yields the reference's beacon URI as a string.
    /// </summary>
    public sealed partial class AggregateGroupedByValue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}