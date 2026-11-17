
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Request body for creating a backup. The resolved selection must contain at least one collection, dynamic user, or RBAC role.
    /// </summary>
    public sealed partial class BackupCreateRequest
    {
        /// <summary>
        /// The ID of the backup (required). Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Backup custom configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Weaviate.BackupConfig? Config { get; set; }

        /// <summary>
        /// List of collections to include in the backup creation process. If not set, all collections the caller may back up are included. Cannot be used together with `exclude`. Permits wildcards, e.g. `*` or `prefix*`, which match only collections the caller may back up. A list that matches no collection is allowed when users or roles are selected, including through omitted identity selectors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<string>? Include { get; set; }

        /// <summary>
        /// List of collections to exclude from the backup creation process. If not set, all collections the caller may back up are included. Cannot be used together with `include`. Permits wildcards, e.g. `*` or `prefix*`. Excluding every collection is allowed when users or roles are selected, including through omitted identity selectors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<string>? Exclude { get; set; }

        /// <summary>
        /// List of dynamic DB users to include in the backup. Permits `*` and `?` wildcards, e.g. `*` or `prefix*`. When omitted or null, the whole dynamic-user store is captured. An empty list or wildcards matching nothing omit the user snapshot; restoring it leaves existing users untouched. Otherwise, only matching users are captured. An exact user name that does not exist is rejected. Selected users, including those selected by omission, permit a backup with zero collections. No per-user permission check is applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeUsers")]
        public global::System.Collections.Generic.IList<string>? IncludeUsers { get; set; }

        /// <summary>
        /// List of RBAC roles to include in the backup. Permits `*` and `?` wildcards, e.g. `*` or `prefix*`. When omitted or null, the whole RBAC state is captured, including built-in roles and assignments. An empty list or wildcards matching nothing omit the RBAC snapshot; restoring it leaves existing roles untouched. Otherwise, only matching roles are captured. An exact role name that does not exist is rejected. Explicit selectors cannot select built-in roles: exact names are rejected and wildcards exclude them. Selected roles, including built-in roles selected by omission, permit a backup with zero collections. No per-role permission check is applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeRoles")]
        public global::System.Collections.Generic.IList<string>? IncludeRoles { get; set; }

        /// <summary>
        /// The ID of an existing backup to use as the base for a file-based incremental backup. If set, only files that have changed since the base backup will be included in the new backup.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incremental_base_backup_id")]
        public string? IncrementalBaseBackupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupCreateRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the backup (required). Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </param>
        /// <param name="config">
        /// Backup custom configuration.
        /// </param>
        /// <param name="include">
        /// List of collections to include in the backup creation process. If not set, all collections the caller may back up are included. Cannot be used together with `exclude`. Permits wildcards, e.g. `*` or `prefix*`, which match only collections the caller may back up. A list that matches no collection is allowed when users or roles are selected, including through omitted identity selectors.
        /// </param>
        /// <param name="exclude">
        /// List of collections to exclude from the backup creation process. If not set, all collections the caller may back up are included. Cannot be used together with `include`. Permits wildcards, e.g. `*` or `prefix*`. Excluding every collection is allowed when users or roles are selected, including through omitted identity selectors.
        /// </param>
        /// <param name="includeUsers">
        /// List of dynamic DB users to include in the backup. Permits `*` and `?` wildcards, e.g. `*` or `prefix*`. When omitted or null, the whole dynamic-user store is captured. An empty list or wildcards matching nothing omit the user snapshot; restoring it leaves existing users untouched. Otherwise, only matching users are captured. An exact user name that does not exist is rejected. Selected users, including those selected by omission, permit a backup with zero collections. No per-user permission check is applied.
        /// </param>
        /// <param name="includeRoles">
        /// List of RBAC roles to include in the backup. Permits `*` and `?` wildcards, e.g. `*` or `prefix*`. When omitted or null, the whole RBAC state is captured, including built-in roles and assignments. An empty list or wildcards matching nothing omit the RBAC snapshot; restoring it leaves existing roles untouched. Otherwise, only matching roles are captured. An exact role name that does not exist is rejected. Explicit selectors cannot select built-in roles: exact names are rejected and wildcards exclude them. Selected roles, including built-in roles selected by omission, permit a backup with zero collections. No per-role permission check is applied.
        /// </param>
        /// <param name="incrementalBaseBackupId">
        /// The ID of an existing backup to use as the base for a file-based incremental backup. If set, only files that have changed since the base backup will be included in the new backup.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupCreateRequest(
            string? id,
            global::Weaviate.BackupConfig? config,
            global::System.Collections.Generic.IList<string>? include,
            global::System.Collections.Generic.IList<string>? exclude,
            global::System.Collections.Generic.IList<string>? includeUsers,
            global::System.Collections.Generic.IList<string>? includeRoles,
            string? incrementalBaseBackupId)
        {
            this.Id = id;
            this.Config = config;
            this.Include = include;
            this.Exclude = exclude;
            this.IncludeUsers = includeUsers;
            this.IncludeRoles = includeRoles;
            this.IncrementalBaseBackupId = incrementalBaseBackupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupCreateRequest" /> class.
        /// </summary>
        public BackupCreateRequest()
        {
        }

    }
}