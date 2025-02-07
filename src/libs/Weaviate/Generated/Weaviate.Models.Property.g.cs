
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Property
    {
        /// <summary>
        /// Data type of the property (required). If it starts with a capital (for example Person), may be a reference to another type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataType")]
        public global::System.Collections.Generic.IList<string>? DataType { get; set; }

        /// <summary>
        /// Description of the property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Configuration specific to modules this Weaviate instance has installed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moduleConfig")]
        public object? ModuleConfig { get; set; }

        /// <summary>
        /// The name of the property (required). Multiple words should be concatenated in camelCase, e.g. `nameOfAuthor`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// (Deprecated). Whether to include this property in the inverted index. If `false`, this property cannot be used in `where` filters, `bm25` or `hybrid` search. &lt;br/&gt;&lt;br/&gt;Unrelated to vectorization behavior (deprecated as of v1.19; use indexFilterable or/and indexSearchable instead)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexInverted")]
        public bool? IndexInverted { get; set; }

        /// <summary>
        /// Whether to include this property in the filterable, Roaring Bitmap index. If `false`, this property cannot be used in `where` filters. &lt;br/&gt;&lt;br/&gt;Note: Unrelated to vectorization behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexFilterable")]
        public bool? IndexFilterable { get; set; }

        /// <summary>
        /// Optional. Should this property be indexed in the inverted index. Defaults to true. Applicable only to properties of data type text and text[]. If you choose false, you will not be able to use this property in bm25 or hybrid search. This property has no affect on vectorization decisions done by modules
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexSearchable")]
        public bool? IndexSearchable { get; set; }

        /// <summary>
        /// Whether to include this property in the filterable, range-based Roaring Bitmap index. Provides better performance for range queries compared to filterable index in large datasets. Applicable only to properties of data type int, number, date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexRangeFilters")]
        public bool? IndexRangeFilters { get; set; }

        /// <summary>
        /// Determines tokenization of the property as separate words or whole field. Optional. Applies to text and text[] data types. Allowed values are `word` (default; splits on any non-alphanumerical, lowercases), `lowercase` (splits on white spaces, lowercases), `whitespace` (splits on white spaces), `field` (trims). Not supported for remaining data types
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.PropertyTokenizationJsonConverter))]
        public global::Weaviate.PropertyTokenization? Tokenization { get; set; }

        /// <summary>
        /// The properties of the nested object(s). Applies to object and object[] data types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nestedProperties")]
        public global::System.Collections.Generic.IList<global::Weaviate.NestedProperty>? NestedProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Property" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Property(
            global::System.Collections.Generic.IList<string>? dataType,
            string? description,
            object? moduleConfig,
            string? name,
            bool? indexInverted,
            bool? indexFilterable,
            bool? indexSearchable,
            bool? indexRangeFilters,
            global::Weaviate.PropertyTokenization? tokenization,
            global::System.Collections.Generic.IList<global::Weaviate.NestedProperty>? nestedProperties)
        {
            this.DataType = dataType;
            this.Description = description;
            this.ModuleConfig = moduleConfig;
            this.Name = name;
            this.IndexInverted = indexInverted;
            this.IndexFilterable = indexFilterable;
            this.IndexSearchable = indexSearchable;
            this.IndexRangeFilters = indexRangeFilters;
            this.Tokenization = tokenization;
            this.NestedProperties = nestedProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Property" /> class.
        /// </summary>
        public Property()
        {
        }
    }
}