
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Request body for restoring a backup for a set of classes
    /// </summary>
    public sealed partial class BackupRestoreRequest
    {
        /// <summary>
        /// Backup custom configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Weaviate.RestoreConfig? Config { get; set; }

        /// <summary>
        /// List of classes to include in the backup restoration process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<string>? Include { get; set; }

        /// <summary>
        /// List of classes to exclude from the backup restoration process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<string>? Exclude { get; set; }

        /// <summary>
        /// Allows overriding the node names stored in the backup with different ones. Useful when restoring backups to a different environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_mapping")]
        public global::System.Collections.Generic.Dictionary<string, string>? NodeMapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRestoreRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// Backup custom configuration
        /// </param>
        /// <param name="include">
        /// List of classes to include in the backup restoration process
        /// </param>
        /// <param name="exclude">
        /// List of classes to exclude from the backup restoration process
        /// </param>
        /// <param name="nodeMapping">
        /// Allows overriding the node names stored in the backup with different ones. Useful when restoring backups to a different environment.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BackupRestoreRequest(
            global::Weaviate.RestoreConfig? config,
            global::System.Collections.Generic.IList<string>? include,
            global::System.Collections.Generic.IList<string>? exclude,
            global::System.Collections.Generic.Dictionary<string, string>? nodeMapping)
        {
            this.Config = config;
            this.Include = include;
            this.Exclude = exclude;
            this.NodeMapping = nodeMapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRestoreRequest" /> class.
        /// </summary>
        public BackupRestoreRequest()
        {
        }
    }
}