#nullable enable

namespace Weaviate
{
    public partial interface IExportClient
    {
        /// <summary>
        /// Get export status<br/>
        /// Retrieves the current status of an export operation, including progress for each collection being exported.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ExportStatusResponse> ExportStatusAsync(
            string backend,
            string id,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get export status<br/>
        /// Retrieves the current status of an export operation, including progress for each collection being exported.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.ExportStatusResponse>> ExportStatusAsResponseAsync(
            string backend,
            string id,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}