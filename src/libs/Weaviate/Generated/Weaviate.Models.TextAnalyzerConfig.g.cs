
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Text analysis options for a property. These settings are immutable after the property is created. Applies only to text and text[] data types that use an inverted index (searchable or filterable).
    /// </summary>
    public sealed partial class TextAnalyzerConfig
    {
        /// <summary>
        /// If true, accent/diacritic marks are folded to their base characters during indexing and search. For example, 'école' matches 'ecole'. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asciiFold")]
        public bool? AsciiFold { get; set; }

        /// <summary>
        /// If provided, specifies a list of characters that should be excluded from ascii folding. For example, if ['é'] is provided, then 'é' will not be folded to 'e' during indexing and search. This list is immutable after the property is created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asciiFoldIgnore")]
        public global::System.Collections.Generic.IList<string>? AsciiFoldIgnore { get; set; }

        /// <summary>
        /// Stopword preset name. Overrides the collection-level invertedIndexConfig.stopwords for this property. Only applies to properties using 'word' tokenization. Can be a built-in preset ('en', 'none') or a user-defined preset from invertedIndexConfig.stopwordPresets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopwordPreset")]
        public string? StopwordPreset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAnalyzerConfig" /> class.
        /// </summary>
        /// <param name="asciiFold">
        /// If true, accent/diacritic marks are folded to their base characters during indexing and search. For example, 'école' matches 'ecole'. Defaults to false.
        /// </param>
        /// <param name="asciiFoldIgnore">
        /// If provided, specifies a list of characters that should be excluded from ascii folding. For example, if ['é'] is provided, then 'é' will not be folded to 'e' during indexing and search. This list is immutable after the property is created.
        /// </param>
        /// <param name="stopwordPreset">
        /// Stopword preset name. Overrides the collection-level invertedIndexConfig.stopwords for this property. Only applies to properties using 'word' tokenization. Can be a built-in preset ('en', 'none') or a user-defined preset from invertedIndexConfig.stopwordPresets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextAnalyzerConfig(
            bool? asciiFold,
            global::System.Collections.Generic.IList<string>? asciiFoldIgnore,
            string? stopwordPreset)
        {
            this.AsciiFold = asciiFold;
            this.AsciiFoldIgnore = asciiFoldIgnore;
            this.StopwordPreset = stopwordPreset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAnalyzerConfig" /> class.
        /// </summary>
        public TextAnalyzerConfig()
        {
        }

    }
}