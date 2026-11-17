#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Tokenize text using a property's configuration<br/>
        /// Tokenizes the provided text using the tokenization method configured for the specified property. This endpoint automatically applies the property's tokenization setting and the collection's stopword configuration, making it useful for understanding exactly how text will be processed for a given property during indexing and querying.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="propertyName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.TokenizeResponse> SchemaObjectsPropertiesTokenizeAsync(
            string className,
            string propertyName,

            global::Weaviate.PropertyTokenizeRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tokenize text using a property's configuration<br/>
        /// Tokenizes the provided text using the tokenization method configured for the specified property. This endpoint automatically applies the property's tokenization setting and the collection's stopword configuration, making it useful for understanding exactly how text will be processed for a given property during indexing and querying.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="propertyName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.TokenizeResponse>> SchemaObjectsPropertiesTokenizeAsResponseAsync(
            string className,
            string propertyName,

            global::Weaviate.PropertyTokenizeRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tokenize text using a property's configuration<br/>
        /// Tokenizes the provided text using the tokenization method configured for the specified property. This endpoint automatically applies the property's tokenization setting and the collection's stopword configuration, making it useful for understanding exactly how text will be processed for a given property during indexing and querying.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="propertyName"></param>
        /// <param name="text">
        /// The text to tokenize using the property's configured tokenization.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.TokenizeResponse> SchemaObjectsPropertiesTokenizeAsync(
            string className,
            string propertyName,
            string text,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}