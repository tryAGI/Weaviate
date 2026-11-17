#nullable enable

namespace Weaviate
{
    public partial interface IBackupsClient
    {
        /// <summary>
        /// List all created backups<br/>
        /// List all created backups IDs, Status
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.BackupListResponseItem>> BackupsListAsync(
            string backend,
            global::Weaviate.BackupsListOrder? order = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all created backups<br/>
        /// List all created backups IDs, Status
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Weaviate.BackupListResponseItem>>> BackupsListAsResponseAsync(
            string backend,
            global::Weaviate.BackupsListOrder? order = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}