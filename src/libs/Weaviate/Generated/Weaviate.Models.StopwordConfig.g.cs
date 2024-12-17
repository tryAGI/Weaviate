
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// fine-grained control over stopword list usage
    /// </summary>
    public sealed partial class StopwordConfig
    {
        /// <summary>
        /// Pre-existing list of common words by language (default: 'en'). Options: ['en', 'none'].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        public string? Preset { get; set; }

        /// <summary>
        /// Stopwords to be considered additionally (default: []). Can be any array of custom strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additions")]
        public global::System.Collections.Generic.IList<string>? Additions { get; set; }

        /// <summary>
        /// Stopwords to be removed from consideration (default: []). Can be any array of custom strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removals")]
        public global::System.Collections.Generic.IList<string>? Removals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopwordConfig" /> class.
        /// </summary>
        /// <param name="preset">
        /// Pre-existing list of common words by language (default: 'en'). Options: ['en', 'none'].
        /// </param>
        /// <param name="additions">
        /// Stopwords to be considered additionally (default: []). Can be any array of custom strings.
        /// </param>
        /// <param name="removals">
        /// Stopwords to be removed from consideration (default: []). Can be any array of custom strings.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StopwordConfig(
            string? preset,
            global::System.Collections.Generic.IList<string>? additions,
            global::System.Collections.Generic.IList<string>? removals)
        {
            this.Preset = preset;
            this.Additions = additions;
            this.Removals = removals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopwordConfig" /> class.
        /// </summary>
        public StopwordConfig()
        {
        }
    }
}