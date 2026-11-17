
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PropertyIndexStatus
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataType")]
        public string? DataType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexes")]
        public global::System.Collections.Generic.IList<global::Weaviate.IndexStatus>? Indexes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyIndexStatus" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dataType"></param>
        /// <param name="description"></param>
        /// <param name="indexes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertyIndexStatus(
            string? name,
            string? dataType,
            string? description,
            global::System.Collections.Generic.IList<global::Weaviate.IndexStatus>? indexes)
        {
            this.Name = name;
            this.DataType = dataType;
            this.Description = description;
            this.Indexes = indexes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyIndexStatus" /> class.
        /// </summary>
        public PropertyIndexStatus()
        {
        }

    }
}