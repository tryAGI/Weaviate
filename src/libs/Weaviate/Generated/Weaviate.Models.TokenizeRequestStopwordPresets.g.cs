
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Optional user-defined named stopword presets. Shape matches InvertedIndexConfig.stopwordPresets on a collection: each key is a preset name, each value is a plain list of stopwords. A preset name that matches a built-in ('en', 'none') fully replaces the built-in. Preset names must not be empty or whitespace-only; each word list must contain at least one word; individual words must not be empty or whitespace-only. Mutually exclusive with stopwords — pass one or the other, not both.
    /// </summary>
    public sealed partial class TokenizeRequestStopwordPresets
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}