
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Reserved for aggregate-over-search (aggregating the results of a vector, keyword or hybrid search). Returns 422 (not yet supported).
    /// </summary>
    public sealed partial class AggregateRequestOver
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}