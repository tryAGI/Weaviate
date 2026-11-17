#nullable enable

namespace Weaviate
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search a collection with bm25<br/>
        /// Performs a keyword (BM25F) search over the objects of a collection. Objects are scored against the query with the BM25F ranking function over the searchable text properties (all of them, or the `queryProperties` subset) and the best-scoring objects are returned, each as an envelope of its `id`, the selected `properties`, the selected `references` and, when requested, its retrieval `metadata`.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.SearchResponse> SearchBm25Async(
            string collection,

            global::Weaviate.SearchBm25Request request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search a collection with bm25<br/>
        /// Performs a keyword (BM25F) search over the objects of a collection. Objects are scored against the query with the BM25F ranking function over the searchable text properties (all of them, or the `queryProperties` subset) and the best-scoring objects are returned, each as an envelope of its `id`, the selected `properties`, the selected `references` and, when requested, its retrieval `metadata`.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.SearchResponse>> SearchBm25AsResponseAsync(
            string collection,

            global::Weaviate.SearchBm25Request request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search a collection with bm25<br/>
        /// Performs a keyword (BM25F) search over the objects of a collection. Objects are scored against the query with the BM25F ranking function over the searchable text properties (all of them, or the `queryProperties` subset) and the best-scoring objects are returned, each as an envelope of its `id`, the selected `properties`, the selected `references` and, when requested, its retrieval `metadata`.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.SearchResponse> SearchBm25Async(
            string collection,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}