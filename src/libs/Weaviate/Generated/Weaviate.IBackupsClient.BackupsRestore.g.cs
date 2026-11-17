#nullable enable

namespace Weaviate
{
    public partial interface IBackupsClient
    {
        /// <summary>
        /// Restore from a backup<br/>
        /// Initiates the restoration of collections from a specified backup located on a designated backend.&lt;br/&gt;&lt;br/&gt;Requirements:&lt;br/&gt;- Target cluster must have the same number of nodes as the source cluster where the backup was created.&lt;br/&gt;- Collections included in the restore must not already exist on the target cluster.&lt;br/&gt;- Node names must match between the backup and the target cluster.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.BackupRestoreResponse> BackupsRestoreAsync(
            string backend,
            string id,

            global::Weaviate.BackupRestoreRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore from a backup<br/>
        /// Initiates the restoration of collections from a specified backup located on a designated backend.&lt;br/&gt;&lt;br/&gt;Requirements:&lt;br/&gt;- Target cluster must have the same number of nodes as the source cluster where the backup was created.&lt;br/&gt;- Collections included in the restore must not already exist on the target cluster.&lt;br/&gt;- Node names must match between the backup and the target cluster.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.BackupRestoreResponse>> BackupsRestoreAsResponseAsync(
            string backend,
            string id,

            global::Weaviate.BackupRestoreRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore from a backup<br/>
        /// Initiates the restoration of collections from a specified backup located on a designated backend.&lt;br/&gt;&lt;br/&gt;Requirements:&lt;br/&gt;- Target cluster must have the same number of nodes as the source cluster where the backup was created.&lt;br/&gt;- Collections included in the restore must not already exist on the target cluster.&lt;br/&gt;- Node names must match between the backup and the target cluster.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="id"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.BackupRestoreResponse> BackupsRestoreAsync(
            string backend,
            string id,
            global::Weaviate.RestoreConfig? config = default,
            global::System.Collections.Generic.IList<string>? include = default,
            global::System.Collections.Generic.IList<string>? exclude = default,
            global::System.Collections.Generic.Dictionary<string, string>? nodeMapping = default,
            bool? overwriteAlias = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}