
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Configuration specific to modules in a property context.
    /// </summary>
    public sealed partial class PropertyModuleConfig
    {
        /// <summary>
        /// E.g. `text2vec-transformers`, `text2vec-openai`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("<module_name>")]
        public global::Weaviate.PropertyModuleConfig2? x_moduleName_ { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyModuleConfig" /> class.
        /// </summary>
        /// <param name="x_moduleName_">
        /// E.g. `text2vec-transformers`, `text2vec-openai`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PropertyModuleConfig(
            global::Weaviate.PropertyModuleConfig2? x_moduleName_)
        {
            this.x_moduleName_ = x_moduleName_;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyModuleConfig" /> class.
        /// </summary>
        public PropertyModuleConfig()
        {
        }
    }
}