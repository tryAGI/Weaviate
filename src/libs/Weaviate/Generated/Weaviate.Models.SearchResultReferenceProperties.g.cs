
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The selected non-reference properties of the referenced object; nested (object / object[]) properties are pruned to the selected nested fields. Always present — `{}` when the selector selects no properties.
    /// </summary>
    public sealed partial class SearchResultReferenceProperties
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}