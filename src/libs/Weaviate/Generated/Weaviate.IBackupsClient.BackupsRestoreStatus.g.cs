#nullable enable

namespace Weaviate
{
    public partial interface IBackupsClient
    {
        /// <summary>
        /// Get restore process status<br/>
        /// Returns status of a backup restoration attempt for a set of classes. &lt;br/&gt;&lt;br/&gt;All client implementations have a `wait for completion` option which will poll the backup status in the background and only return once the backup has completed (successfully or unsuccessfully). If you set the `wait for completion` option to false, you can also check the status yourself using the this endpoint.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="id"></param>
        /// <param name="bucket"></param>
        /// <param name="path"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.BackupRestoreStatusResponse> BackupsRestoreStatusAsync(
            string backend,
            string id,
            string? bucket = default,
            string? path = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}