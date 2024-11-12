
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Configure named vectors (https://weaviate.io/developers/weaviate/config-refs/schema/multi-vector). Either use this field or `vectorizer`, `vectorIndexType`, and `vectorIndexConfig` fields. Available from `v1.24.0`.
    /// </summary>
    public sealed partial class ClassVectorConfig
    {
        /// <summary>
        /// Configuration of each named vector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("<vector_name>")]
        public global::Weaviate.VectorConfig? x_vectorName_ { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassVectorConfig" /> class.
        /// </summary>
        /// <param name="x_vectorName_">
        /// Configuration of each named vector.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ClassVectorConfig(
            global::Weaviate.VectorConfig? x_vectorName_)
        {
            this.x_vectorName_ = x_vectorName_;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassVectorConfig" /> class.
        /// </summary>
        public ClassVectorConfig()
        {
        }
    }
}