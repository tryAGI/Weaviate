#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Add a property to a collection<br/>
        /// Adds a new property definition to an existing collection (`className`) definition.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Property> SchemaObjectsPropertiesAddAsync(
            string className,

            global::Weaviate.Property request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a property to a collection<br/>
        /// Adds a new property definition to an existing collection (`className`) definition.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.Property>> SchemaObjectsPropertiesAddAsResponseAsync(
            string className,

            global::Weaviate.Property request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a property to a collection<br/>
        /// Adds a new property definition to an existing collection (`className`) definition.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="dataType">
        /// Data type of the property (required). If it starts with a capital (for example Person), may be a reference to another type.
        /// </param>
        /// <param name="description">
        /// Description of the property.
        /// </param>
        /// <param name="moduleConfig">
        /// Configuration specific to modules in a collection context.
        /// </param>
        /// <param name="name">
        /// The name of the property (required). Multiple words should be concatenated in camelCase, e.g. `nameOfAuthor`.
        /// </param>
        /// <param name="indexInverted">
        /// (Deprecated). Whether to include this property in the inverted index. If `false`, this property cannot be used in `where` filters, `bm25` or `hybrid` search. &lt;br/&gt;&lt;br/&gt;Unrelated to vectorization behavior (deprecated as of v1.19; use indexFilterable or/and indexSearchable instead)
        /// </param>
        /// <param name="bucketGeneration">
        /// Internal RAFT-replicated counter bumped by semantic runtime-reindex migrations (e.g. change-tokenization, enable-filterable, enable-searchable). Used by the data path to resolve the property's inverted-index bucket name; a single RAFT commit flipping the schema flag AND bumping this counter atomically cuts the cluster from the old bucket to the new one. Defaults to 0. Internal use; clients should not set this.
        /// </param>
        /// <param name="searchableBlockmax">
        /// Internal RAFT-replicated per-property flag: true iff this property's searchable (BM25) bucket is on the blockmax (StrategyInverted) index. Stamped at migration cutover. Absent/null means "not stamped" and is resolved against the class-wide UsingBlockMaxWAND flag. Internal use; clients must not set this.
        /// </param>
        /// <param name="indexFilterable">
        /// Whether to include this property in the filterable, Roaring Bitmap index. If `false`, this property cannot be used in `where` filters. &lt;br/&gt;&lt;br/&gt;Note: Unrelated to vectorization behavior.
        /// </param>
        /// <param name="indexSearchable">
        /// Optional. Should this property be indexed in the inverted index. Defaults to true. Applicable only to properties of data type text and text[]. If you choose false, you will not be able to use this property in bm25 or hybrid search. This property has no affect on vectorization decisions done by modules
        /// </param>
        /// <param name="indexRangeFilters">
        /// Whether to include this property in the filterable, range-based Roaring Bitmap index. Provides better performance for range queries compared to filterable index in large datasets. Applicable only to properties of data type int, number, date.
        /// </param>
        /// <param name="tokenization">
        /// Determines how a property is indexed. This setting applies to `text` and `text[]` data types. The following tokenization methods are available:&lt;br/&gt;&lt;br/&gt;- `word` (default): Splits the text on any non-alphanumeric characters and lowercases the tokens.&lt;br/&gt;- `lowercase`: Splits the text on whitespace and lowercases the tokens.&lt;br/&gt;- `whitespace`: Splits the text on whitespace. This tokenization is case-sensitive.&lt;br/&gt;- `field`: Indexes the entire property value as a single token after trimming whitespace.&lt;br/&gt;- `trigram`: Splits the property into rolling trigrams (three-character sequences).&lt;br/&gt;- `gse`: Uses the `gse` tokenizer, suitable for Chinese language text. [See `gse` docs](https://pkg.go.dev/github.com/go-ego/gse#section-readme).&lt;br/&gt;- `kagome_ja`: Uses the `Kagome` tokenizer with a Japanese (IPA) dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;- `kagome_kr`: Uses the `Kagome` tokenizer with a Korean dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;&lt;br/&gt;See [Reference: Tokenization](https://docs.weaviate.io/weaviate/config-refs/collections#tokenization) for details.
        /// </param>
        /// <param name="nestedProperties">
        /// The properties of the nested object(s). Applies to object and object[] data types.
        /// </param>
        /// <param name="disableDuplicatedReferences">
        /// If set to false, allows multiple references to the same target object within this property. Setting it to true will enforce uniqueness of references within this property. By default, this is set to true.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="textAnalyzer">
        /// Text analysis options for a property. These settings are immutable after the property is created. Applies only to text and text[] data types that use an inverted index (searchable or filterable).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Property> SchemaObjectsPropertiesAddAsync(
            string className,
            global::System.Collections.Generic.IList<string>? dataType = default,
            string? description = default,
            object? moduleConfig = default,
            string? name = default,
            bool? indexInverted = default,
            long? bucketGeneration = default,
            bool? searchableBlockmax = default,
            bool? indexFilterable = default,
            bool? indexSearchable = default,
            bool? indexRangeFilters = default,
            global::Weaviate.PropertyTokenization? tokenization = default,
            global::System.Collections.Generic.IList<global::Weaviate.NestedProperty>? nestedProperties = default,
            bool? disableDuplicatedReferences = default,
            global::Weaviate.TextAnalyzerConfig? textAnalyzer = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}