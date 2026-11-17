
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Request body for restoring a backup. A backup with no collections can restore users or roles when the matching restore option is enabled.
    /// </summary>
    public sealed partial class BackupRestoreRequest
    {
        /// <summary>
        /// Backup custom configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Weaviate.RestoreConfig? Config { get; set; }

        /// <summary>
        /// List of collections (classes) to include in the backup restoration process. If not set, all collections in the backup the caller may restore are included. Permits wildcards, e.g. `*` or `prefix*`, which match only collections the caller may restore. A list that matches no collection is rejected. Any entry is rejected when the backup contains no collections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<string>? Include { get; set; }

        /// <summary>
        /// List of collections (classes) to exclude from the backup restoration process. Any entry is rejected when the backup contains no collections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<string>? Exclude { get; set; }

        /// <summary>
        /// Allows overriding the node names stored in the backup with different ones. Useful when restoring backups to a different environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_mapping")]
        public global::System.Collections.Generic.Dictionary<string, string>? NodeMapping { get; set; }

        /// <summary>
        /// Allows ovewriting the collection alias if there is a conflict
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overwriteAlias")]
        public bool? OverwriteAlias { get; set; }

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
        /// List of collections (classes) to include in the backup restoration process. If not set, all collections in the backup the caller may restore are included. Permits wildcards, e.g. `*` or `prefix*`, which match only collections the caller may restore. A list that matches no collection is rejected. Any entry is rejected when the backup contains no collections.
        /// </param>
        /// <param name="exclude">
        /// List of collections (classes) to exclude from the backup restoration process. Any entry is rejected when the backup contains no collections.
        /// </param>
        /// <param name="nodeMapping">
        /// Allows overriding the node names stored in the backup with different ones. Useful when restoring backups to a different environment.
        /// </param>
        /// <param name="overwriteAlias">
        /// Allows ovewriting the collection alias if there is a conflict
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupRestoreRequest(
            global::Weaviate.RestoreConfig? config,
            global::System.Collections.Generic.IList<string>? include,
            global::System.Collections.Generic.IList<string>? exclude,
            global::System.Collections.Generic.Dictionary<string, string>? nodeMapping,
            bool? overwriteAlias)
        {
            this.Config = config;
            this.Include = include;
            this.Exclude = exclude;
            this.NodeMapping = nodeMapping;
            this.OverwriteAlias = overwriteAlias;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRestoreRequest" /> class.
        /// </summary>
        public BackupRestoreRequest()
        {
        }

    }
}