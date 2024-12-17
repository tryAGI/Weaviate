#nullable enable

namespace Weaviate
{
    public partial interface IBackupsClient
    {
        /// <summary>
        /// Start a restoration process<br/>
        /// Starts a process of restoring a backup for a set of collections. &lt;br/&gt;&lt;br/&gt;Any backup can be restored to any machine, as long as the number of nodes between source and target are identical.&lt;br/&gt;&lt;br/&gt;Requrements:&lt;br/&gt;&lt;br/&gt;- None of the collections to be restored already exist on the target restoration node(s).&lt;br/&gt;- The node names of the backed-up collections' must match those of the target restoration node(s).
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.BackupRestoreResponse> BackupsRestoreAsync(
            string backend,
            string id,
            global::Weaviate.BackupRestoreRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Start a restoration process<br/>
        /// Starts a process of restoring a backup for a set of collections. &lt;br/&gt;&lt;br/&gt;Any backup can be restored to any machine, as long as the number of nodes between source and target are identical.&lt;br/&gt;&lt;br/&gt;Requrements:&lt;br/&gt;&lt;br/&gt;- None of the collections to be restored already exist on the target restoration node(s).&lt;br/&gt;- The node names of the backed-up collections' must match those of the target restoration node(s).
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="id"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.BackupRestoreResponse> BackupsRestoreAsync(
            string backend,
            string id,
            global::Weaviate.RestoreConfig? config = default,
            global::System.Collections.Generic.IList<string>? include = default,
            global::System.Collections.Generic.IList<string>? exclude = default,
            global::System.Collections.Generic.Dictionary<string, string>? nodeMapping = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}