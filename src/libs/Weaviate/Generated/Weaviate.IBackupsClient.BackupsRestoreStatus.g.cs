#nullable enable

namespace Weaviate
{
    public partial interface IBackupsClient
    {
        /// <summary>
        /// Get backup restoration status<br/>
        /// Checks the status of a specific backup restoration process identified by the backup ID on the specified backend.&lt;br/&gt;&lt;br/&gt;Client libraries often provide a 'wait for completion' feature that polls this endpoint automatically. Use this endpoint for manual status checks or if 'wait for completion' is disabled.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="id"></param>
        /// <param name="bucket"></param>
        /// <param name="path"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.BackupRestoreStatusResponse> BackupsRestoreStatusAsync(
            string backend,
            string id,
            string? bucket = default,
            string? path = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get backup restoration status<br/>
        /// Checks the status of a specific backup restoration process identified by the backup ID on the specified backend.&lt;br/&gt;&lt;br/&gt;Client libraries often provide a 'wait for completion' feature that polls this endpoint automatically. Use this endpoint for manual status checks or if 'wait for completion' is disabled.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="id"></param>
        /// <param name="bucket"></param>
        /// <param name="path"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.BackupRestoreStatusResponse>> BackupsRestoreStatusAsResponseAsync(
            string backend,
            string id,
            string? bucket = default,
            string? path = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}