#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Create a new Object class in the schema.<br/>
        /// Create a new data object collection. &lt;br/&gt;&lt;br/&gt;If AutoSchema is enabled, Weaviate will attempt to infer the schema from the data at import time. However, manual schema definition is recommended for production environments.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Class> SchemaObjectsCreateAsync(
            global::Weaviate.Class request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new Object class in the schema.<br/>
        /// Create a new data object collection. &lt;br/&gt;&lt;br/&gt;If AutoSchema is enabled, Weaviate will attempt to infer the schema from the data at import time. However, manual schema definition is recommended for production environments.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Class> SchemaObjectsCreateAsync(
            string? class1 = default,
            global::System.Collections.Generic.Dictionary<string, global::Weaviate.VectorConfig>? vectorConfig = default,
            string? vectorIndexType = default,
            object? vectorIndexConfig = default,
            object? shardingConfig = default,
            global::Weaviate.ReplicationConfig? replicationConfig = default,
            global::Weaviate.InvertedIndexConfig? invertedIndexConfig = default,
            global::Weaviate.MultiTenancyConfig? multiTenancyConfig = default,
            string? vectorizer = default,
            object? moduleConfig = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Weaviate.Property>? properties = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}