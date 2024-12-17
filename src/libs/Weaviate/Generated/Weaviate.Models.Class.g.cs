
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Class
    {
        /// <summary>
        /// Name of the class (a.k.a. 'collection') (required). Multiple words should be concatenated in CamelCase, e.g. `ArticleAuthor`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        public string? Class1 { get; set; }

        /// <summary>
        /// Configure named vectors. Either use this field or `vectorizer`, `vectorIndexType`, and `vectorIndexConfig` fields. Available from `v1.24.0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorConfig")]
        public global::System.Collections.Generic.Dictionary<string, global::Weaviate.VectorConfig>? VectorConfig { get; set; }

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
        /// Manage how the index should be sharded and distributed in the cluster
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shardingConfig")]
        public object? ShardingConfig { get; set; }

        /// <summary>
        /// Configure how replication is executed in a cluster
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicationConfig")]
        public global::Weaviate.ReplicationConfig? ReplicationConfig { get; set; }

        /// <summary>
        /// Configure the inverted index built into Weaviate (default: 60).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invertedIndexConfig")]
        public global::Weaviate.InvertedIndexConfig? InvertedIndexConfig { get; set; }

        /// <summary>
        /// Configuration related to multi-tenancy within a class
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multiTenancyConfig")]
        public global::Weaviate.MultiTenancyConfig? MultiTenancyConfig { get; set; }

        /// <summary>
        /// Specify how the vectors for this class should be determined. The options are either 'none' - this means you have to import a vector with each object yourself - or the name of a module that provides vectorization capabilities, such as 'text2vec-contextionary'. If left empty, it will use the globally configured default which can itself either be 'none' or a specific module.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorizer")]
        public string? Vectorizer { get; set; }

        /// <summary>
        /// Configuration specific to modules in a collection context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moduleConfig")]
        public object? ModuleConfig { get; set; }

        /// <summary>
        /// Description of the collection for metadata purposes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Define properties of the collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.IList<global::Weaviate.Property>? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Class" /> class.
        /// </summary>
        /// <param name="class1">
        /// Name of the class (a.k.a. 'collection') (required). Multiple words should be concatenated in CamelCase, e.g. `ArticleAuthor`.
        /// </param>
        /// <param name="vectorConfig">
        /// Configure named vectors. Either use this field or `vectorizer`, `vectorIndexType`, and `vectorIndexConfig` fields. Available from `v1.24.0`.
        /// </param>
        /// <param name="vectorIndexType">
        /// Name of the vector index to use, eg. (HNSW)
        /// </param>
        /// <param name="vectorIndexConfig">
        /// Vector-index config, that is specific to the type of index selected in vectorIndexType
        /// </param>
        /// <param name="shardingConfig">
        /// Manage how the index should be sharded and distributed in the cluster
        /// </param>
        /// <param name="replicationConfig">
        /// Configure how replication is executed in a cluster
        /// </param>
        /// <param name="invertedIndexConfig">
        /// Configure the inverted index built into Weaviate (default: 60).
        /// </param>
        /// <param name="multiTenancyConfig">
        /// Configuration related to multi-tenancy within a class
        /// </param>
        /// <param name="vectorizer">
        /// Specify how the vectors for this class should be determined. The options are either 'none' - this means you have to import a vector with each object yourself - or the name of a module that provides vectorization capabilities, such as 'text2vec-contextionary'. If left empty, it will use the globally configured default which can itself either be 'none' or a specific module.
        /// </param>
        /// <param name="moduleConfig">
        /// Configuration specific to modules in a collection context.
        /// </param>
        /// <param name="description">
        /// Description of the collection for metadata purposes.
        /// </param>
        /// <param name="properties">
        /// Define properties of the collection.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Class(
            string? class1,
            global::System.Collections.Generic.Dictionary<string, global::Weaviate.VectorConfig>? vectorConfig,
            string? vectorIndexType,
            object? vectorIndexConfig,
            object? shardingConfig,
            global::Weaviate.ReplicationConfig? replicationConfig,
            global::Weaviate.InvertedIndexConfig? invertedIndexConfig,
            global::Weaviate.MultiTenancyConfig? multiTenancyConfig,
            string? vectorizer,
            object? moduleConfig,
            string? description,
            global::System.Collections.Generic.IList<global::Weaviate.Property>? properties)
        {
            this.Class1 = class1;
            this.VectorConfig = vectorConfig;
            this.VectorIndexType = vectorIndexType;
            this.VectorIndexConfig = vectorIndexConfig;
            this.ShardingConfig = shardingConfig;
            this.ReplicationConfig = replicationConfig;
            this.InvertedIndexConfig = invertedIndexConfig;
            this.MultiTenancyConfig = multiTenancyConfig;
            this.Vectorizer = vectorizer;
            this.ModuleConfig = moduleConfig;
            this.Description = description;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Class" /> class.
        /// </summary>
        public Class()
        {
        }
    }
}