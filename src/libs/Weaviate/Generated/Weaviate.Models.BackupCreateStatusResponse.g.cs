
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The definition of a backup create metadata
    /// </summary>
    public sealed partial class BackupCreateStatusResponse
    {
        /// <summary>
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Backup backend name e.g. filesystem, gcs, s3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backend")]
        public string? Backend { get; set; }

        /// <summary>
        /// Destination path of backup files valid for the selected backend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// error message if creation failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// phase of backup creation process<br/>
        /// Default Value: STARTED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.BackupCreateStatusResponseStatusJsonConverter))]
        public global::Weaviate.BackupCreateStatusResponseStatus? Status { get; set; }

        /// <summary>
        /// Timestamp when the backup process started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Timestamp when the backup process completed (successfully or with failure)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Size of the backup in Gibs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public double? Size { get; set; }

        /// <summary>
        /// The ID of the base backup this incremental backup was built on; empty if the backup is not incremental.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incremental_base_backup_id")]
        public string? IncrementalBaseBackupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupCreateStatusResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </param>
        /// <param name="backend">
        /// Backup backend name e.g. filesystem, gcs, s3.
        /// </param>
        /// <param name="path">
        /// Destination path of backup files valid for the selected backend.
        /// </param>
        /// <param name="error">
        /// error message if creation failed
        /// </param>
        /// <param name="status">
        /// phase of backup creation process<br/>
        /// Default Value: STARTED
        /// </param>
        /// <param name="startedAt">
        /// Timestamp when the backup process started
        /// </param>
        /// <param name="completedAt">
        /// Timestamp when the backup process completed (successfully or with failure)
        /// </param>
        /// <param name="size">
        /// Size of the backup in Gibs
        /// </param>
        /// <param name="incrementalBaseBackupId">
        /// The ID of the base backup this incremental backup was built on; empty if the backup is not incremental.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupCreateStatusResponse(
            string? id,
            string? backend,
            string? path,
            string? error,
            global::Weaviate.BackupCreateStatusResponseStatus? status,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt,
            double? size,
            string? incrementalBaseBackupId)
        {
            this.Id = id;
            this.Backend = backend;
            this.Path = path;
            this.Error = error;
            this.Status = status;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Size = size;
            this.IncrementalBaseBackupId = incrementalBaseBackupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupCreateStatusResponse" /> class.
        /// </summary>
        public BackupCreateStatusResponse()
        {
        }

    }
}