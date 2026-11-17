#nullable enable

namespace Weaviate
{
    public partial interface ITokenizeClient
    {
        /// <summary>
        /// Tokenize text<br/>
        /// Tokenizes the provided text using the specified tokenization method. This is a stateless utility endpoint useful for debugging and understanding how text will be processed during indexing and querying. The response includes both the indexed tokens (as stored in the inverted index) and query tokens (after optional stopword removal).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.TokenizeResponse> TokenizeAsync(

            global::Weaviate.TokenizeRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tokenize text<br/>
        /// Tokenizes the provided text using the specified tokenization method. This is a stateless utility endpoint useful for debugging and understanding how text will be processed during indexing and querying. The response includes both the indexed tokens (as stored in the inverted index) and query tokens (after optional stopword removal).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.TokenizeResponse>> TokenizeAsResponseAsync(

            global::Weaviate.TokenizeRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tokenize text<br/>
        /// Tokenizes the provided text using the specified tokenization method. This is a stateless utility endpoint useful for debugging and understanding how text will be processed during indexing and querying. The response includes both the indexed tokens (as stored in the inverted index) and query tokens (after optional stopword removal).
        /// </summary>
        /// <param name="text">
        /// The text to tokenize.
        /// </param>
        /// <param name="tokenization">
        /// The tokenization method to apply.
        /// </param>
        /// <param name="analyzerConfig">
        /// Text analysis options for a property. These settings are immutable after the property is created. Applies only to text and text[] data types that use an inverted index (searchable or filterable).
        /// </param>
        /// <param name="stopwords">
        /// Fine-grained control over stopword list usage.
        /// </param>
        /// <param name="stopwordPresets">
        /// Optional user-defined named stopword presets. Shape matches InvertedIndexConfig.stopwordPresets on a collection: each key is a preset name, each value is a plain list of stopwords. A preset name that matches a built-in ('en', 'none') fully replaces the built-in. Preset names must not be empty or whitespace-only; each word list must contain at least one word; individual words must not be empty or whitespace-only. Mutually exclusive with stopwords — pass one or the other, not both.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.TokenizeResponse> TokenizeAsync(
            string text,
            global::Weaviate.TokenizeRequestTokenization tokenization,
            global::Weaviate.TextAnalyzerConfig? analyzerConfig = default,
            global::Weaviate.StopwordConfig? stopwords = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? stopwordPresets = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}