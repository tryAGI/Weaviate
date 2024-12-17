#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Add a property to an Object class.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Property> SchemaObjectsPropertiesAddAsync(
            string className,
            global::Weaviate.Property request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add a property to an Object class.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="dataType">
        /// Data type of the property (required). If it starts with a capital (for example Person), may be a reference to another type.
        /// </param>
        /// <param name="description">
        /// Description of the property.
        /// </param>
        /// <param name="moduleConfig">
        /// Configuration specific to modules this Weaviate instance has installed
        /// </param>
        /// <param name="name">
        /// The name of the property (required). Multiple words should be concatenated in camelCase, e.g. `nameOfAuthor`.
        /// </param>
        /// <param name="indexInverted">
        /// (Deprecated). Whether to include this property in the inverted index. If `false`, this property cannot be used in `where` filters, `bm25` or `hybrid` search. &lt;br/&gt;&lt;br/&gt;Unrelated to vectorization behavior (deprecated as of v1.19; use indexFilterable or/and indexSearchable instead)
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
        /// Determines tokenization of the property as separate words or whole field. Optional. Applies to text and text[] data types. Allowed values are `word` (default; splits on any non-alphanumerical, lowercases), `lowercase` (splits on white spaces, lowercases), `whitespace` (splits on white spaces), `field` (trims). Not supported for remaining data types
        /// </param>
        /// <param name="nestedProperties">
        /// The properties of the nested object(s). Applies to object and object[] data types.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Property> SchemaObjectsPropertiesAddAsync(
            string className,
            global::System.Collections.Generic.IList<string>? dataType = default,
            string? description = default,
            object? moduleConfig = default,
            string? name = default,
            bool? indexInverted = default,
            bool? indexFilterable = default,
            bool? indexSearchable = default,
            bool? indexRangeFilters = default,
            global::Weaviate.PropertyTokenization? tokenization = default,
            global::System.Collections.Generic.IList<global::Weaviate.NestedProperty>? nestedProperties = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}