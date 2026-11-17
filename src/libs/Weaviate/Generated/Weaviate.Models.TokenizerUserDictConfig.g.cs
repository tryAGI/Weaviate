
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// A list of pairs of strings that should be replaced with another string during tokenization.
    /// </summary>
    public sealed partial class TokenizerUserDictConfig
    {
        /// <summary>
        /// The tokenizer to which the user dictionary should be applied. Currently, only the `kagame` ja and kr tokenizers supports user dictionaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenizer")]
        public string? Tokenizer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replacements")]
        public global::System.Collections.Generic.IList<global::Weaviate.TokenizerUserDictConfigReplacement>? Replacements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizerUserDictConfig" /> class.
        /// </summary>
        /// <param name="tokenizer">
        /// The tokenizer to which the user dictionary should be applied. Currently, only the `kagame` ja and kr tokenizers supports user dictionaries.
        /// </param>
        /// <param name="replacements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenizerUserDictConfig(
            string? tokenizer,
            global::System.Collections.Generic.IList<global::Weaviate.TokenizerUserDictConfigReplacement>? replacements)
        {
            this.Tokenizer = tokenizer;
            this.Replacements = replacements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizerUserDictConfig" /> class.
        /// </summary>
        public TokenizerUserDictConfig()
        {
        }

    }
}