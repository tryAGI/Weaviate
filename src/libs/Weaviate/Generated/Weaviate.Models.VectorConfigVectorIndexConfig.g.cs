
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Vector-index config, that is specific to the type of index selected in vectorIndexType
    /// </summary>
    public sealed partial class VectorConfigVectorIndexConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}