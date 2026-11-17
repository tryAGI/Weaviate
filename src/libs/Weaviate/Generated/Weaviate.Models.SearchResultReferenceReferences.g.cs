
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The cross-references selected one hop deeper. Omitted when the selector selects none, or when the referenced object has no entry for any of them.
    /// </summary>
    public sealed partial class SearchResultReferenceReferences
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}