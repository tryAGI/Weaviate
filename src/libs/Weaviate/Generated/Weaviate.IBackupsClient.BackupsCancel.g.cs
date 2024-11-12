#nullable enable

namespace Weaviate
{
    public partial interface IBackupsClient
    {
        /// <summary>
        /// Cancel backup<br/>
        /// Cancel created backup with specified ID
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task BackupsCancelAsync(
            string backend,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}