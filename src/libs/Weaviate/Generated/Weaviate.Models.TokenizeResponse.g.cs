
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Response from the tokenize endpoints. Returns `indexed` text and text used at `query` time
    /// </summary>
    public sealed partial class TokenizeResponse
    {
        /// <summary>
        /// The tokens as they would be stored in the inverted index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexed")]
        public global::System.Collections.Generic.IList<string>? Indexed { get; set; }

        /// <summary>
        /// The tokens as they would be used for query matching (e.g., after stopword removal).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public global::System.Collections.Generic.IList<string>? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeResponse" /> class.
        /// </summary>
        /// <param name="indexed">
        /// The tokens as they would be stored in the inverted index.
        /// </param>
        /// <param name="query">
        /// The tokens as they would be used for query matching (e.g., after stopword removal).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenizeResponse(
            global::System.Collections.Generic.IList<string>? indexed,
            global::System.Collections.Generic.IList<string>? query)
        {
            this.Indexed = indexed;
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeResponse" /> class.
        /// </summary>
        public TokenizeResponse()
        {
        }

    }
}