
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Configure the inverted index built into Weaviate (default: 60).
    /// </summary>
    public sealed partial class InvertedIndexConfig
    {
        /// <summary>
        /// Asynchronous index clean up happens every n seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cleanupIntervalSeconds")]
        public double? CleanupIntervalSeconds { get; set; }

        /// <summary>
        /// tuning parameters for the BM25 algorithm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bm25")]
        public global::Weaviate.BM25Config? Bm25 { get; set; }

        /// <summary>
        /// fine-grained control over stopword list usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopwords")]
        public global::Weaviate.StopwordConfig? Stopwords { get; set; }

        /// <summary>
        /// Index each object by its internal timestamps (default: 'false').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexTimestamps")]
        public bool? IndexTimestamps { get; set; }

        /// <summary>
        /// Index each object with the null state (default: 'false').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexNullState")]
        public bool? IndexNullState { get; set; }

        /// <summary>
        /// Index length of properties (default: 'false').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexPropertyLength")]
        public bool? IndexPropertyLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvertedIndexConfig" /> class.
        /// </summary>
        /// <param name="cleanupIntervalSeconds">
        /// Asynchronous index clean up happens every n seconds
        /// </param>
        /// <param name="bm25">
        /// tuning parameters for the BM25 algorithm
        /// </param>
        /// <param name="stopwords">
        /// fine-grained control over stopword list usage
        /// </param>
        /// <param name="indexTimestamps">
        /// Index each object by its internal timestamps (default: 'false').
        /// </param>
        /// <param name="indexNullState">
        /// Index each object with the null state (default: 'false').
        /// </param>
        /// <param name="indexPropertyLength">
        /// Index length of properties (default: 'false').
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public InvertedIndexConfig(
            double? cleanupIntervalSeconds,
            global::Weaviate.BM25Config? bm25,
            global::Weaviate.StopwordConfig? stopwords,
            bool? indexTimestamps,
            bool? indexNullState,
            bool? indexPropertyLength)
        {
            this.CleanupIntervalSeconds = cleanupIntervalSeconds;
            this.Bm25 = bm25;
            this.Stopwords = stopwords;
            this.IndexTimestamps = indexTimestamps;
            this.IndexNullState = indexNullState;
            this.IndexPropertyLength = indexPropertyLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvertedIndexConfig" /> class.
        /// </summary>
        public InvertedIndexConfig()
        {
        }
    }
}