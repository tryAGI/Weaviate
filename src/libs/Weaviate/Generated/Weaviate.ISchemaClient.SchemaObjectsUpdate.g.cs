#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Update collection definition<br/>
        /// Updates the configuration settings of an existing collection (`className`) based on the provided definition. Note: This operation modifies mutable settings specified in the request body. It does not add properties (use `POST /schema/{className}/properties` for that) or change the collection name.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Class> SchemaObjectsUpdateAsync(
            string className,

            global::Weaviate.Class request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update collection definition<br/>
        /// Updates the configuration settings of an existing collection (`className`) based on the provided definition. Note: This operation modifies mutable settings specified in the request body. It does not add properties (use `POST /schema/{className}/properties` for that) or change the collection name.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.Class>> SchemaObjectsUpdateAsResponseAsync(
            string className,

            global::Weaviate.Class request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update collection definition<br/>
        /// Updates the configuration settings of an existing collection (`className`) based on the provided definition. Note: This operation modifies mutable settings specified in the request body. It does not add properties (use `POST /schema/{className}/properties` for that) or change the collection name.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="class1">
        /// Name of the collection (formerly 'class') (required). Multiple words should be concatenated in CamelCase, e.g. `ArticleAuthor`.
        /// </param>
        /// <param name="vectorConfig">
        /// Configure named vectors. Either use this field or `vectorizer`, `vectorIndexType`, and `vectorIndexConfig` fields. Available from `v1.24.0`.
        /// </param>
        /// <param name="vectorIndexType">
        /// Name of the vector index type to use for the collection (e.g. `hnsw` or `flat`).
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
        /// Configure the inverted index built into Weaviate. See [Reference: Inverted index](https://docs.weaviate.io/weaviate/config-refs/indexing/inverted-index#inverted-index-parameters) for details.
        /// </param>
        /// <param name="multiTenancyConfig">
        /// Configuration related to multi-tenancy within a collection (class)
        /// </param>
        /// <param name="objectTtlConfig">
        /// Configuration of objects' time-to-live
        /// </param>
        /// <param name="vectorizer">
        /// Specify how the vectors for this collection should be determined. The options are either `none` - this means you have to import a vector with each object yourself - or the name of a module that provides vectorization capabilities, such as `text2vec-weaviate`. If left empty, it defaults to `none`.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Class> SchemaObjectsUpdateAsync(
            string className,
            string? class1 = default,
            global::System.Collections.Generic.Dictionary<string, global::Weaviate.VectorConfig>? vectorConfig = default,
            string? vectorIndexType = default,
            object? vectorIndexConfig = default,
            object? shardingConfig = default,
            global::Weaviate.ReplicationConfig? replicationConfig = default,
            global::Weaviate.InvertedIndexConfig? invertedIndexConfig = default,
            global::Weaviate.MultiTenancyConfig? multiTenancyConfig = default,
            global::Weaviate.ObjectTtlConfig? objectTtlConfig = default,
            string? vectorizer = default,
            object? moduleConfig = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Weaviate.Property>? properties = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}