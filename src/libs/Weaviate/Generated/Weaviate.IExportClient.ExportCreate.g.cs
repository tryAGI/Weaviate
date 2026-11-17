#nullable enable

namespace Weaviate
{
    public partial interface IExportClient
    {
        /// <summary>
        /// Start a new export<br/>
        /// Initiates an export operation on the specified backend storage (S3, GCS, Azure, or filesystem). The output format is controlled by the required 'file_format' field in the request body (currently only 'parquet' is supported). Each collection is exported to a separate file.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ExportCreateResponse> ExportCreateAsync(
            string backend,

            global::Weaviate.ExportCreateRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a new export<br/>
        /// Initiates an export operation on the specified backend storage (S3, GCS, Azure, or filesystem). The output format is controlled by the required 'file_format' field in the request body (currently only 'parquet' is supported). Each collection is exported to a separate file.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.ExportCreateResponse>> ExportCreateAsResponseAsync(
            string backend,

            global::Weaviate.ExportCreateRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a new export<br/>
        /// Initiates an export operation on the specified backend storage (S3, GCS, Azure, or filesystem). The output format is controlled by the required 'file_format' field in the request body (currently only 'parquet' is supported). Each collection is exported to a separate file.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="id">
        /// Unique identifier for this export. Must be URL-safe.
        /// </param>
        /// <param name="fileFormat">
        /// Output file format for the export.
        /// </param>
        /// <param name="include">
        /// List of collection names to include in the export. Cannot be used with 'exclude'.
        /// </param>
        /// <param name="exclude">
        /// List of collection names to exclude from the export. Cannot be used with 'include'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ExportCreateResponse> ExportCreateAsync(
            string backend,
            string id,
            global::Weaviate.ExportCreateRequestFileFormat fileFormat = default,
            global::System.Collections.Generic.IList<string>? include = default,
            global::System.Collections.Generic.IList<string>? exclude = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}