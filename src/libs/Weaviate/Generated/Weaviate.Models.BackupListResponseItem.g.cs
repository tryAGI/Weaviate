
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BackupListResponseItem
    {
        /// <summary>
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The list of collections (classes) for which the backup process was started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classes")]
        public global::System.Collections.Generic.IList<string>? Classes { get; set; }

        /// <summary>
        /// Status of backup process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.BackupListResponseItemStatusJsonConverter))]
        public global::Weaviate.BackupListResponseItemStatus? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="BackupListResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </param>
        /// <param name="classes">
        /// The list of collections (classes) for which the backup process was started.
        /// </param>
        /// <param name="status">
        /// Status of backup process.
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
        public BackupListResponseItem(
            string? id,
            global::System.Collections.Generic.IList<string>? classes,
            global::Weaviate.BackupListResponseItemStatus? status,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt,
            double? size,
            string? incrementalBaseBackupId)
        {
            this.Id = id;
            this.Classes = classes;
            this.Status = status;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Size = size;
            this.IncrementalBaseBackupId = incrementalBaseBackupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupListResponseItem" /> class.
        /// </summary>
        public BackupListResponseItem()
        {
        }

    }
}