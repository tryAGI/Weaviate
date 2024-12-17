
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Object
    {
        /// <summary>
        /// Class of the Object, defined in the schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        public string? Class { get; set; }

        /// <summary>
        /// Allow custom overrides of vector weights as math expressions. E.g. "pancake": "7" will set the weight for the word pancake to 7 in the vectorization, whereas "w * 3" would triple the originally calculated word. This is an open object, with OpenAPI Specification 3.0 this will be more detailed. See Weaviate docs for more info. In the future this will become a key/value (string/string) object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorWeights")]
        public object? VectorWeights { get; set; }

        /// <summary>
        /// Names and values of an individual property. A returned response may also contain additional metadata, such as from classification or feature projection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// ID of the Object.
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
        /// A vector representation of the object in the Contextionary. If provided at object creation, this wil take precedence over any vectorizer setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        public global::System.Collections.Generic.IList<float>? Vector { get; set; }

        /// <summary>
        /// A map of named vectors for multi-vector representations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectors")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<float>>? Vectors { get; set; }

        /// <summary>
        /// Name of the Objects tenant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        public string? Tenant { get; set; }

        /// <summary>
        /// (Response only) Additional meta information about a single object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional")]
        public global::System.Collections.Generic.Dictionary<string, object>? Additional { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Object" /> class.
        /// </summary>
        /// <param name="class">
        /// Class of the Object, defined in the schema.
        /// </param>
        /// <param name="vectorWeights">
        /// Allow custom overrides of vector weights as math expressions. E.g. "pancake": "7" will set the weight for the word pancake to 7 in the vectorization, whereas "w * 3" would triple the originally calculated word. This is an open object, with OpenAPI Specification 3.0 this will be more detailed. See Weaviate docs for more info. In the future this will become a key/value (string/string) object.
        /// </param>
        /// <param name="properties">
        /// Names and values of an individual property. A returned response may also contain additional metadata, such as from classification or feature projection.
        /// </param>
        /// <param name="id">
        /// ID of the Object.
        /// </param>
        /// <param name="creationTimeUnix">
        /// (Response only) Timestamp of creation of this object in milliseconds since epoch UTC.
        /// </param>
        /// <param name="lastUpdateTimeUnix">
        /// (Response only) Timestamp of the last object update in milliseconds since epoch UTC.
        /// </param>
        /// <param name="vector">
        /// A vector representation of the object in the Contextionary. If provided at object creation, this wil take precedence over any vectorizer setting.
        /// </param>
        /// <param name="vectors">
        /// A map of named vectors for multi-vector representations.
        /// </param>
        /// <param name="tenant">
        /// Name of the Objects tenant.
        /// </param>
        /// <param name="additional">
        /// (Response only) Additional meta information about a single object.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Object(
            string? @class,
            object? vectorWeights,
            object? properties,
            global::System.Guid? id,
            long? creationTimeUnix,
            long? lastUpdateTimeUnix,
            global::System.Collections.Generic.IList<float>? vector,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<float>>? vectors,
            string? tenant,
            global::System.Collections.Generic.Dictionary<string, object>? additional)
        {
            this.Class = @class;
            this.VectorWeights = vectorWeights;
            this.Properties = properties;
            this.Id = id;
            this.CreationTimeUnix = creationTimeUnix;
            this.LastUpdateTimeUnix = lastUpdateTimeUnix;
            this.Vector = vector;
            this.Vectors = vectors;
            this.Tenant = tenant;
            this.Additional = additional;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Object" /> class.
        /// </summary>
        public Object()
        {
        }
    }
}