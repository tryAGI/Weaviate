
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The value to be used within the operations.
    /// </summary>
    public sealed partial class PatchDocumentObjectValue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}