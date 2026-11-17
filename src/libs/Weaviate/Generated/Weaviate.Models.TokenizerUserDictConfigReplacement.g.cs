
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TokenizerUserDictConfigReplacement
    {
        /// <summary>
        /// The string to be replaced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// The string to replace with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizerUserDictConfigReplacement" /> class.
        /// </summary>
        /// <param name="source">
        /// The string to be replaced.
        /// </param>
        /// <param name="target">
        /// The string to replace with.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenizerUserDictConfigReplacement(
            string source,
            string target)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizerUserDictConfigReplacement" /> class.
        /// </summary>
        public TokenizerUserDictConfigReplacement()
        {
        }

    }
}