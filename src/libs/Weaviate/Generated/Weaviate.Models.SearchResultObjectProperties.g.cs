
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The selected non-reference properties of the object; nested (object / object[]) properties are pruned to the selected nested fields. Always present — `{}` when the request selects no properties.
    /// </summary>
    public sealed partial class SearchResultObjectProperties
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}