#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Rebuild a property's inverted index with unchanged configuration<br/>
        /// Rebuilds the inverted index from the stored objects with its current configuration (repair / format refresh). No request body. Index-mutating work is asynchronous: a `202` with a task ID is returned. `indexName` accepts `rangeable` as an alias for `rangeFilters`.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="propertyName"></param>
        /// <param name="indexName"></param>
        /// <param name="tenants"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.IndexUpdateResponse> SchemaObjectsIndexRebuildAsync(
            string className,
            string propertyName,
            global::Weaviate.SchemaObjectsIndexRebuildIndexName indexName,
            global::System.Collections.Generic.IList<string>? tenants = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rebuild a property's inverted index with unchanged configuration<br/>
        /// Rebuilds the inverted index from the stored objects with its current configuration (repair / format refresh). No request body. Index-mutating work is asynchronous: a `202` with a task ID is returned. `indexName` accepts `rangeable` as an alias for `rangeFilters`.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="propertyName"></param>
        /// <param name="indexName"></param>
        /// <param name="tenants"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.IndexUpdateResponse>> SchemaObjectsIndexRebuildAsResponseAsync(
            string className,
            string propertyName,
            global::Weaviate.SchemaObjectsIndexRebuildIndexName indexName,
            global::System.Collections.Generic.IList<string>? tenants = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}