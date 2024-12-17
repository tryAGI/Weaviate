#nullable enable

namespace Weaviate
{
    public partial interface IBackupsClient
    {
        /// <summary>
        /// Start a backup process<br/>
        /// Start creating a backup for a set of collections. &lt;br/&gt;&lt;br/&gt;Notes: &lt;br/&gt;- Weaviate uses gzip compression by default. &lt;br/&gt;- Weaviate stays usable while a backup process is ongoing.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.BackupCreateResponse> BackupsCreateAsync(
            string backend,
            global::Weaviate.BackupCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Start a backup process<br/>
        /// Start creating a backup for a set of collections. &lt;br/&gt;&lt;br/&gt;Notes: &lt;br/&gt;- Weaviate uses gzip compression by default. &lt;br/&gt;- Weaviate stays usable while a backup process is ongoing.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="id">
        /// The ID of the backup (required). Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </param>
        /// <param name="config">
        /// Backup custom configuration
        /// </param>
        /// <param name="include">
        /// List of collections to include in the backup creation process. If not set, all collections are included. Cannot be used together with `exclude`.
        /// </param>
        /// <param name="exclude">
        /// List of collections to exclude from the backup creation process. If not set, all collections are included. Cannot be used together with `include`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.BackupCreateResponse> BackupsCreateAsync(
            string backend,
            string? id = default,
            global::Weaviate.BackupConfig? config = default,
            global::System.Collections.Generic.IList<string>? include = default,
            global::System.Collections.Generic.IList<string>? exclude = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}