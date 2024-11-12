
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Results for this specific Object.
    /// </summary>
    public sealed partial class ObjectsGetResponseVariant3Result
    {
        /// <summary>
        /// Default Value: SUCCESS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.ObjectsGetResponseVariant3ResultStatusJsonConverter))]
        public global::Weaviate.ObjectsGetResponseVariant3ResultStatus? Status { get; set; }

        /// <summary>
        /// An error response given by Weaviate end-points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::Weaviate.ErrorResponse? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsGetResponseVariant3Result" /> class.
        /// </summary>
        /// <param name="status">
        /// Default Value: SUCCESS
        /// </param>
        /// <param name="errors">
        /// An error response given by Weaviate end-points.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ObjectsGetResponseVariant3Result(
            global::Weaviate.ObjectsGetResponseVariant3ResultStatus? status,
            global::Weaviate.ErrorResponse? errors)
        {
            this.Status = status;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsGetResponseVariant3Result" /> class.
        /// </summary>
        public ObjectsGetResponseVariant3Result()
        {
        }
    }
}