#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Delete a collection's vector index.<br/>
        /// Deletes a specific vector index within a collection (`className`). The vector index to delete is identified by `vectorIndexName`.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="vectorIndexName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task SchemaObjectsVectorsDeleteAsync(
            string className,
            string vectorIndexName,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a collection's vector index.<br/>
        /// Deletes a specific vector index within a collection (`className`). The vector index to delete is identified by `vectorIndexName`.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="vectorIndexName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> SchemaObjectsVectorsDeleteAsResponseAsync(
            string className,
            string vectorIndexName,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}