
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Request body for the property-specific tokenize endpoint.
    /// </summary>
    public sealed partial class PropertyTokenizeRequest
    {
        /// <summary>
        /// The text to tokenize using the property's configured tokenization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyTokenizeRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to tokenize using the property's configured tokenization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertyTokenizeRequest(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyTokenizeRequest" /> class.
        /// </summary>
        public PropertyTokenizeRequest()
        {
        }

    }
}