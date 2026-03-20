#nullable enable

namespace Weaviate
{
    public partial interface IBackupsClient
    {
        /// <summary>
        /// List backups in progress<br/>
        /// [Coming soon] List all backups in progress not implemented yet.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.BackupListResponseItem>> BackupsListAsync(
            string backend,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}