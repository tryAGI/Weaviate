#nullable enable

namespace Weaviate
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search a collection with near-object<br/>
        /// Performs a similarity search over the objects of a collection, anchored at an existing object: the stored vector of the source object (referenced by `id`) is searched against the vector index and the closest objects are returned — the source object itself included — each as an envelope of its `id`, the selected `properties`, the selected `references` and, when requested, its retrieval `metadata`. No query is vectorized, so collections without a vectorizer module are fully searchable.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.SearchResponse> SearchNearObjectAsync(
            string collection,

            global::Weaviate.SearchNearObjectRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search a collection with near-object<br/>
        /// Performs a similarity search over the objects of a collection, anchored at an existing object: the stored vector of the source object (referenced by `id`) is searched against the vector index and the closest objects are returned — the source object itself included — each as an envelope of its `id`, the selected `properties`, the selected `references` and, when requested, its retrieval `metadata`. No query is vectorized, so collections without a vectorizer module are fully searchable.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.SearchResponse>> SearchNearObjectAsResponseAsync(
            string collection,

            global::Weaviate.SearchNearObjectRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search a collection with near-object<br/>
        /// Performs a similarity search over the objects of a collection, anchored at an existing object: the stored vector of the source object (referenced by `id`) is searched against the vector index and the closest objects are returned — the source object itself included — each as an envelope of its `id`, the selected `properties`, the selected `references` and, when requested, its retrieval `metadata`. No query is vectorized, so collections without a vectorizer module are fully searchable.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.SearchResponse> SearchNearObjectAsync(
            string collection,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}