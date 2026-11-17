
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Request body for the generic tokenize endpoint.
    /// </summary>
    public sealed partial class TokenizeRequest
    {
        /// <summary>
        /// The text to tokenize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The tokenization method to apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.TokenizeRequestTokenizationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weaviate.TokenizeRequestTokenization Tokenization { get; set; }

        /// <summary>
        /// Text analysis options for a property. These settings are immutable after the property is created. Applies only to text and text[] data types that use an inverted index (searchable or filterable).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyzerConfig")]
        public global::Weaviate.TextAnalyzerConfig? AnalyzerConfig { get; set; }

        /// <summary>
        /// Fine-grained control over stopword list usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopwords")]
        public global::Weaviate.StopwordConfig? Stopwords { get; set; }

        /// <summary>
        /// Optional user-defined named stopword presets. Shape matches InvertedIndexConfig.stopwordPresets on a collection: each key is a preset name, each value is a plain list of stopwords. A preset name that matches a built-in ('en', 'none') fully replaces the built-in. Preset names must not be empty or whitespace-only; each word list must contain at least one word; individual words must not be empty or whitespace-only. Mutually exclusive with stopwords — pass one or the other, not both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopwordPresets")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? StopwordPresets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenizeRequest(
            string text,
            global::Weaviate.TokenizeRequestTokenization tokenization,
            global::Weaviate.TextAnalyzerConfig? analyzerConfig,
            global::Weaviate.StopwordConfig? stopwords,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? stopwordPresets)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Tokenization = tokenization;
            this.AnalyzerConfig = analyzerConfig;
            this.Stopwords = stopwords;
            this.StopwordPresets = stopwordPresets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeRequest" /> class.
        /// </summary>
        public TokenizeRequest()
        {
        }

    }
}