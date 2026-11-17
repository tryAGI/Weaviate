
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The selected cross-references: reference property name to the array of referenced objects. Omitted when the request selects no references, or when the hit has no entry for any of the selected references.
    /// </summary>
    public sealed partial class SearchResultObjectReferences
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}