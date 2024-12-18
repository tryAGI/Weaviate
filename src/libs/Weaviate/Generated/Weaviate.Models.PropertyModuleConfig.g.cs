
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Configuration specific to modules this Weaviate instance has installed
    /// </summary>
    public sealed partial class PropertyModuleConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}