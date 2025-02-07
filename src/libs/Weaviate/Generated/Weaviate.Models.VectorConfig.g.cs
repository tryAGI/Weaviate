
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorConfig
    {
        /// <summary>
        /// Configuration of a specific vectorizer used by this vector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorizer")]
        public object? Vectorizer { get; set; }

        /// <summary>
        /// Name of the vector index to use, eg. (HNSW)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorIndexType")]
        public string? VectorIndexType { get; set; }

        /// <summary>
        /// Vector-index config, that is specific to the type of index selected in vectorIndexType
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorIndexConfig")]
        public object? VectorIndexConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorConfig" /> class.
        /// </summary>
        /// <param name="vectorizer">
        /// Configuration of a specific vectorizer used by this vector
        /// </param>
        /// <param name="vectorIndexType">
        /// Name of the vector index to use, eg. (HNSW)
        /// </param>
        /// <param name="vectorIndexConfig">
        /// Vector-index config, that is specific to the type of index selected in vectorIndexType
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorConfig(
            object? vectorizer,
            string? vectorIndexType,
            object? vectorIndexConfig)
        {
            this.Vectorizer = vectorizer;
            this.VectorIndexType = vectorIndexType;
            this.VectorIndexConfig = vectorIndexConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorConfig" /> class.
        /// </summary>
        public VectorConfig()
        {
        }
    }
}