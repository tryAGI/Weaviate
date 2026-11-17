#nullable enable

namespace Weaviate
{
    public partial interface IBackupsClient
    {
        /// <summary>
        /// Create a backup<br/>
        /// Initiates the creation of a backup for specified collections on a designated backend storage.&lt;br/&gt;&lt;br/&gt;Notes:&lt;br/&gt;- Backups are compressed using gzip by default.&lt;br/&gt;- Weaviate remains operational during the backup process.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.BackupCreateResponse> BackupsCreateAsync(
            string backend,

            global::Weaviate.BackupCreateRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a backup<br/>
        /// Initiates the creation of a backup for specified collections on a designated backend storage.&lt;br/&gt;&lt;br/&gt;Notes:&lt;br/&gt;- Backups are compressed using gzip by default.&lt;br/&gt;- Weaviate remains operational during the backup process.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.BackupCreateResponse>> BackupsCreateAsResponseAsync(
            string backend,

            global::Weaviate.BackupCreateRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a backup<br/>
        /// Initiates the creation of a backup for specified collections on a designated backend storage.&lt;br/&gt;&lt;br/&gt;Notes:&lt;br/&gt;- Backups are compressed using gzip by default.&lt;br/&gt;- Weaviate remains operational during the backup process.
        /// </summary>
        /// <param name="backend"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.BackupCreateResponse> BackupsCreateAsync(
            string backend,
            string? id = default,
            global::Weaviate.BackupConfig? config = default,
            global::System.Collections.Generic.IList<string>? include = default,
            global::System.Collections.Generic.IList<string>? exclude = default,
            global::System.Collections.Generic.IList<string>? includeUsers = default,
            global::System.Collections.Generic.IList<string>? includeRoles = default,
            string? incrementalBaseBackupId = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}