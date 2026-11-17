
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Response object containing a list of alias mappings.
    /// </summary>
    public sealed partial class AliasResponse
    {
        /// <summary>
        /// Array of alias objects, each containing an alias-to-collection mapping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::System.Collections.Generic.IList<global::Weaviate.Alias>? Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasResponse" /> class.
        /// </summary>
        /// <param name="aliases">
        /// Array of alias objects, each containing an alias-to-collection mapping.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AliasResponse(
            global::System.Collections.Generic.IList<global::Weaviate.Alias>? aliases)
        {
            this.Aliases = aliases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasResponse" /> class.
        /// </summary>
        public AliasResponse()
        {
        }

    }
}