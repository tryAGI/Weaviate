
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Response from creating an export operation
    /// </summary>
    public sealed partial class ExportCreateResponse
    {
        /// <summary>
        /// Unique identifier for this export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The backend storage system used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backend")]
        public string? Backend { get; set; }

        /// <summary>
        /// Full path where the export is being written
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Current status of the export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.ExportCreateResponseStatusJsonConverter))]
        public global::Weaviate.ExportCreateResponseStatus? Status { get; set; }

        /// <summary>
        /// When the export started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// List of collections being exported
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classes")]
        public global::System.Collections.Generic.IList<string>? Classes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportCreateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this export
        /// </param>
        /// <param name="backend">
        /// The backend storage system used
        /// </param>
        /// <param name="path">
        /// Full path where the export is being written
        /// </param>
        /// <param name="status">
        /// Current status of the export
        /// </param>
        /// <param name="startedAt">
        /// When the export started
        /// </param>
        /// <param name="classes">
        /// List of collections being exported
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportCreateResponse(
            string? id,
            string? backend,
            string? path,
            global::Weaviate.ExportCreateResponseStatus? status,
            global::System.DateTime? startedAt,
            global::System.Collections.Generic.IList<string>? classes)
        {
            this.Id = id;
            this.Backend = backend;
            this.Path = path;
            this.Status = status;
            this.StartedAt = startedAt;
            this.Classes = classes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportCreateResponse" /> class.
        /// </summary>
        public ExportCreateResponse()
        {
        }

    }
}