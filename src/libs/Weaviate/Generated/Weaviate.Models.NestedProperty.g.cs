
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NestedProperty
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataType")]
        public global::System.Collections.Generic.IList<string>? DataType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexFilterable")]
        public bool? IndexFilterable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexSearchable")]
        public bool? IndexSearchable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexRangeFilters")]
        public bool? IndexRangeFilters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.NestedPropertyTokenizationJsonConverter))]
        public global::Weaviate.NestedPropertyTokenization? Tokenization { get; set; }

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
        /// Initializes a new instance of the <see cref="NestedProperty" /> class.
        /// </summary>
        /// <param name="dataType"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="indexFilterable"></param>
        /// <param name="indexSearchable"></param>
        /// <param name="indexRangeFilters"></param>
        /// <param name="tokenization"></param>
        /// <param name="nestedProperties">
        /// The properties of the nested object(s). Applies to object and object[] data types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NestedProperty(
            global::System.Collections.Generic.IList<string>? dataType,
            string? description,
            string? name,
            bool? indexFilterable,
            bool? indexSearchable,
            bool? indexRangeFilters,
            global::Weaviate.NestedPropertyTokenization? tokenization,
            global::System.Collections.Generic.IList<global::Weaviate.NestedProperty>? nestedProperties)
        {
            this.DataType = dataType;
            this.Description = description;
            this.Name = name;
            this.IndexFilterable = indexFilterable;
            this.IndexSearchable = indexSearchable;
            this.IndexRangeFilters = indexRangeFilters;
            this.Tokenization = tokenization;
            this.NestedProperties = nestedProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NestedProperty" /> class.
        /// </summary>
        public NestedProperty()
        {
        }
    }
}