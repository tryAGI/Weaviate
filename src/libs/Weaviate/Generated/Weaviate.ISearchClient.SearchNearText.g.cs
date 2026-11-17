#nullable enable

namespace Weaviate
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search a collection with near-text<br/>
        /// Performs a semantic (near-text) search over the objects of a collection. The query text is vectorized server-side by the collection's vectorizer module and the closest objects are returned, each as an envelope of its `id`, the selected `properties`, the selected `references` and, when requested, its retrieval `metadata`.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.SearchResponse> SearchNearTextAsync(
            string collection,

            global::Weaviate.SearchNearTextRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search a collection with near-text<br/>
        /// Performs a semantic (near-text) search over the objects of a collection. The query text is vectorized server-side by the collection's vectorizer module and the closest objects are returned, each as an envelope of its `id`, the selected `properties`, the selected `references` and, when requested, its retrieval `metadata`.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.SearchResponse>> SearchNearTextAsResponseAsync(
            string collection,

            global::Weaviate.SearchNearTextRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search a collection with near-text<br/>
        /// Performs a semantic (near-text) search over the objects of a collection. The query text is vectorized server-side by the collection's vectorizer module and the closest objects are returned, each as an envelope of its `id`, the selected `properties`, the selected `references` and, when requested, its retrieval `metadata`.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.SearchResponse> SearchNearTextAsync(
            string collection,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}