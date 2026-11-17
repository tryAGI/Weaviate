#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Get index status for all properties of a collection<br/>
        /// Returns per-property index state including active reindex progress. This powers the UI to show live migration status. The response reflects the state of the node that answered, which may briefly omit the entry for a just-submitted migration or still report its pre-migration state.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.IndexStatusResponse> SchemaObjectsIndexesGetAsync(
            string className,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get index status for all properties of a collection<br/>
        /// Returns per-property index state including active reindex progress. This powers the UI to show live migration status. The response reflects the state of the node that answered, which may briefly omit the entry for a just-submitted migration or still report its pre-migration state.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.IndexStatusResponse>> SchemaObjectsIndexesGetAsResponseAsync(
            string className,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}