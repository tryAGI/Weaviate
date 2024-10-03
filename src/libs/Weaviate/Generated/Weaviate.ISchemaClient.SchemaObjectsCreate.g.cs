#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Create a collection.<br/>
        /// Create a new data object collection. &lt;br/&gt;&lt;br/&gt;If [AutoSchema](https://weaviate.io/developers/weaviate/config-refs/schema#auto-schema) is enabled, Weaviate will attempt to infer the schema from the data at import time. However, manual schema definition is recommended for production environments. &lt;br/&gt;&lt;br/&gt;For further discussions of parameters, please see the [schema reference page](https://weaviate.io/developers/weaviate/config-refs/schema).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Class> SchemaObjectsCreateAsync(
            global::Weaviate.Class request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a collection.<br/>
        /// Create a new data object collection. &lt;br/&gt;&lt;br/&gt;If [AutoSchema](https://weaviate.io/developers/weaviate/config-refs/schema#auto-schema) is enabled, Weaviate will attempt to infer the schema from the data at import time. However, manual schema definition is recommended for production environments. &lt;br/&gt;&lt;br/&gt;For further discussions of parameters, please see the [schema reference page](https://weaviate.io/developers/weaviate/config-refs/schema).
        /// </summary>
        /// <param name="class1">
        /// Name of the collection (a.k.a. class). Multiple words should be concatenated in CamelCase, e.g. `ArticleAuthor`.
        /// </param>
        /// <param name="vectorConfig">
        /// Configure named vectors (https://weaviate.io/developers/weaviate/config-refs/schema/multi-vector). Either use this field or `vectorizer`, `vectorIndexType`, and `vectorIndexConfig` fields. Available from `v1.24.0`.
        /// </param>
        /// <param name="vectorIndexType">
        /// Name of the vector index to use, eg. (HNSW)<br/>
        /// Default Value: hnsw
        /// </param>
        /// <param name="vectorIndexConfig">
        /// Vector index type specific settings. See the [vector index configuration page](https://weaviate.io/developers/weaviate/config-refs/schema/vector-index) for more details
        /// </param>
        /// <param name="shardingConfig">
        /// Specify how the index should be sharded and distributed in the cluster
        /// </param>
        /// <param name="replicationConfig">
        /// Configure how replication is executed in a cluster
        /// </param>
        /// <param name="invertedIndexConfig">
        /// Configure the inverted index built into Weaviate
        /// </param>
        /// <param name="multiTenancyConfig">
        /// Configuration related to multi-tenancy within a class
        /// </param>
        /// <param name="vectorizer">
        /// Vectorizer for this collection (e.g. `text2vec-transformers`). This will override any cluster-wide default set by an environment variable. &lt;br/&gt;&lt;br/&gt;If `none`, you must import a vector with each object yourself.
        /// </param>
        /// <param name="moduleConfig">
        /// Configuration specific to modules in a collection context.
        /// </param>
        /// <param name="description">
        /// Description of the collection for documentation purposes.
        /// </param>
        /// <param name="properties">
        /// Define properties of the collection.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Class> SchemaObjectsCreateAsync(
            string class1,
            global::Weaviate.ClassVectorConfig? vectorConfig = default,
            global::Weaviate.VectorIndexType? vectorIndexType = global::Weaviate.VectorIndexType.Hnsw,
            global::Weaviate.VectorIndexConfig? vectorIndexConfig = default,
            global::Weaviate.ShardingConfig? shardingConfig = default,
            global::Weaviate.ReplicationConfig? replicationConfig = default,
            global::Weaviate.InvertedIndexConfig? invertedIndexConfig = default,
            global::Weaviate.MultiTenancyConfig? multiTenancyConfig = default,
            global::Weaviate.Vectorizer? vectorizer = default,
            global::Weaviate.ClassModuleConfig? moduleConfig = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Weaviate.Property>? properties = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}