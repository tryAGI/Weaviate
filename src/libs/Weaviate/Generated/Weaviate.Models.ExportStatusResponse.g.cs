
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Current status of an export operation
    /// </summary>
    public sealed partial class ExportStatusResponse
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
        /// Full path where the export is stored
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Current status of the export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.ExportStatusResponseStatusJsonConverter))]
        public global::Weaviate.ExportStatusResponseStatus? Status { get; set; }

        /// <summary>
        /// When the export started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the export completed (successfully, with failure, or was canceled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Duration of the export in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tookInMs")]
        public long? TookInMs { get; set; }

        /// <summary>
        /// List of collections in this export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classes")]
        public global::System.Collections.Generic.IList<string>? Classes { get; set; }

        /// <summary>
        /// Per-shard progress: className -&gt; shardName -&gt; status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shardStatus")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Weaviate.ShardProgress>>? ShardStatus { get; set; }

        /// <summary>
        /// Error message if export failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportStatusResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this export
        /// </param>
        /// <param name="backend">
        /// The backend storage system used
        /// </param>
        /// <param name="path">
        /// Full path where the export is stored
        /// </param>
        /// <param name="status">
        /// Current status of the export
        /// </param>
        /// <param name="startedAt">
        /// When the export started
        /// </param>
        /// <param name="completedAt">
        /// When the export completed (successfully, with failure, or was canceled)
        /// </param>
        /// <param name="tookInMs">
        /// Duration of the export in milliseconds
        /// </param>
        /// <param name="classes">
        /// List of collections in this export
        /// </param>
        /// <param name="shardStatus">
        /// Per-shard progress: className -&gt; shardName -&gt; status
        /// </param>
        /// <param name="error">
        /// Error message if export failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportStatusResponse(
            string? id,
            string? backend,
            string? path,
            global::Weaviate.ExportStatusResponseStatus? status,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt,
            long? tookInMs,
            global::System.Collections.Generic.IList<string>? classes,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Weaviate.ShardProgress>>? shardStatus,
            string? error)
        {
            this.Id = id;
            this.Backend = backend;
            this.Path = path;
            this.Status = status;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.TookInMs = tookInMs;
            this.Classes = classes;
            this.ShardStatus = shardStatus;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportStatusResponse" /> class.
        /// </summary>
        public ExportStatusResponse()
        {
        }

    }
}