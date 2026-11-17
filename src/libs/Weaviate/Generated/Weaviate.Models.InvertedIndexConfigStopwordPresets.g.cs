
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// User-defined named stopword lists. Each key is a preset name that can be referenced by a property's textAnalyzer.stopwordPreset field. The value is an array of stopword strings. Preset names must not be empty or whitespace-only; each list must contain at least one word; individual words must not be empty or whitespace-only.
    /// </summary>
    public sealed partial class InvertedIndexConfigStopwordPresets
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}