#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Delete a property's inverted index<br/>
        /// Deletes an inverted index of a specific property within a collection (`className`). The index to delete is identified by `indexName` and must be one of `filterable`, `searchable`, or `rangeFilters` (with `rangeable` accepted as an alias for `rangeFilters`).
        /// </summary>
        /// <param name="className"></param>
        /// <param name="propertyName"></param>
        /// <param name="indexName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task SchemaObjectsPropertiesDeleteAsync(
            string className,
            string propertyName,
            global::Weaviate.SchemaObjectsPropertiesDeleteIndexName indexName,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a property's inverted index<br/>
        /// Deletes an inverted index of a specific property within a collection (`className`). The index to delete is identified by `indexName` and must be one of `filterable`, `searchable`, or `rangeFilters` (with `rangeable` accepted as an alias for `rangeFilters`).
        /// </summary>
        /// <param name="className"></param>
        /// <param name="propertyName"></param>
        /// <param name="indexName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> SchemaObjectsPropertiesDeleteAsResponseAsync(
            string className,
            string propertyName,
            global::Weaviate.SchemaObjectsPropertiesDeleteIndexName indexName,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}