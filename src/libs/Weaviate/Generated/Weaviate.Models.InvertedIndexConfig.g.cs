
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Configure the inverted index built into Weaviate. See [Reference: Inverted index](https://docs.weaviate.io/weaviate/config-refs/indexing/inverted-index#inverted-index-parameters) for details.
    /// </summary>
    public sealed partial class InvertedIndexConfig
    {
        /// <summary>
        /// Asynchronous index clean up happens every n seconds (default: 60).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cleanupIntervalSeconds")]
        public double? CleanupIntervalSeconds { get; set; }

        /// <summary>
        /// Tuning parameters for the BM25 algorithm.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bm25")]
        public global::Weaviate.BM25Config? Bm25 { get; set; }

        /// <summary>
        /// Fine-grained control over stopword list usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopwords")]
        public global::Weaviate.StopwordConfig? Stopwords { get; set; }

        /// <summary>
        /// Index each object by its internal timestamps (default: `false`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexTimestamps")]
        public bool? IndexTimestamps { get; set; }

        /// <summary>
        /// Index each object with the null state (default: `false`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexNullState")]
        public bool? IndexNullState { get; set; }

        /// <summary>
        /// Index length of properties (default: `false`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexPropertyLength")]
        public bool? IndexPropertyLength { get; set; }

        /// <summary>
        /// Using BlockMax WAND for query execution (default: `false`, will be `true` for new collections created after 1.30).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usingBlockMaxWAND")]
        public bool? UsingBlockMaxWAND { get; set; }

        /// <summary>
        /// User-defined dictionary for tokenization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenizerUserDict")]
        public global::System.Collections.Generic.IList<global::Weaviate.TokenizerUserDictConfig>? TokenizerUserDict { get; set; }

        /// <summary>
        /// User-defined named stopword lists. Each key is a preset name that can be referenced by a property's textAnalyzer.stopwordPreset field. The value is an array of stopword strings. Preset names must not be empty or whitespace-only; each list must contain at least one word; individual words must not be empty or whitespace-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopwordPresets")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? StopwordPresets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvertedIndexConfig" /> class.
        /// </summary>
        /// <param name="cleanupIntervalSeconds">
        /// Asynchronous index clean up happens every n seconds (default: 60).
        /// </param>
        /// <param name="bm25">
        /// Tuning parameters for the BM25 algorithm.
        /// </param>
        /// <param name="stopwords">
        /// Fine-grained control over stopword list usage.
        /// </param>
        /// <param name="indexTimestamps">
        /// Index each object by its internal timestamps (default: `false`).
        /// </param>
        /// <param name="indexNullState">
        /// Index each object with the null state (default: `false`).
        /// </param>
        /// <param name="indexPropertyLength">
        /// Index length of properties (default: `false`).
        /// </param>
        /// <param name="usingBlockMaxWAND">
        /// Using BlockMax WAND for query execution (default: `false`, will be `true` for new collections created after 1.30).
        /// </param>
        /// <param name="tokenizerUserDict">
        /// User-defined dictionary for tokenization.
        /// </param>
        /// <param name="stopwordPresets">
        /// User-defined named stopword lists. Each key is a preset name that can be referenced by a property's textAnalyzer.stopwordPreset field. The value is an array of stopword strings. Preset names must not be empty or whitespace-only; each list must contain at least one word; individual words must not be empty or whitespace-only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvertedIndexConfig(
            double? cleanupIntervalSeconds,
            global::Weaviate.BM25Config? bm25,
            global::Weaviate.StopwordConfig? stopwords,
            bool? indexTimestamps,
            bool? indexNullState,
            bool? indexPropertyLength,
            bool? usingBlockMaxWAND,
            global::System.Collections.Generic.IList<global::Weaviate.TokenizerUserDictConfig>? tokenizerUserDict,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? stopwordPresets)
        {
            this.CleanupIntervalSeconds = cleanupIntervalSeconds;
            this.Bm25 = bm25;
            this.Stopwords = stopwords;
            this.IndexTimestamps = indexTimestamps;
            this.IndexNullState = indexNullState;
            this.IndexPropertyLength = indexPropertyLength;
            this.UsingBlockMaxWAND = usingBlockMaxWAND;
            this.TokenizerUserDict = tokenizerUserDict;
            this.StopwordPresets = stopwordPresets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvertedIndexConfig" /> class.
        /// </summary>
        public InvertedIndexConfig()
        {
        }

    }
}