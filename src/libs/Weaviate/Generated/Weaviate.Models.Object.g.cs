
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Object
    {
        /// <summary>
        /// The object collection name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        public string? Class { get; set; }

        /// <summary>
        /// Allow custom overrides of vector weights as math expressions in word-based vectorization models. E.g. "pancake": "7" will set the weight for the word pancake to 7 in the vectorization, whereas "w * 3" would triple the originally calculated word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorWeights")]
        public global::Weaviate.VectorWeights? VectorWeights { get; set; }

        /// <summary>
        /// Names and values of an individual property. A returned response may also contain additional metadata, such as from classification or feature projection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::Weaviate.PropertySchema? Properties { get; set; }

        /// <summary>
        /// ID of the object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// (Response only) Timestamp of creation of this object in milliseconds since epoch UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creationTimeUnix")]
        public long? CreationTimeUnix { get; set; }

        /// <summary>
        /// (Response only) Timestamp of the last object update in milliseconds since epoch UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdateTimeUnix")]
        public long? LastUpdateTimeUnix { get; set; }

        /// <summary>
        /// A vector representation of the object. If provided at object creation, this wil take precedence over any vectorizer setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        public global::System.Collections.Generic.IList<float>? Vector { get; set; }

        /// <summary>
        /// A map of named vectors for multi-vector representations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectors")]
        public global::Weaviate.Vectors? Vectors { get; set; }

        /// <summary>
        /// Name of the tenant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        public string? Tenant { get; set; }

        /// <summary>
        /// (Response only) Additional meta information about a single object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional")]
        public global::Weaviate.AdditionalProperties? Additional { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}