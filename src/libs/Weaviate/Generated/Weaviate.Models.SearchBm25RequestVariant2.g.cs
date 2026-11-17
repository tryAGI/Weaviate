
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchBm25RequestVariant2
    {
        /// <summary>
        /// The keyword query to score objects against, as a plain string. Must not be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The properties to keyword-search, each optionally weighted with a `^boost` suffix (e.g. `title^2`). Omitted or empty searches every searchable text property. A property without a searchable index is rejected with 422.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queryProperties")]
        public global::System.Collections.Generic.IList<string>? QueryProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchBm25RequestVariant2" /> class.
        /// </summary>
        /// <param name="query">
        /// The keyword query to score objects against, as a plain string. Must not be empty.
        /// </param>
        /// <param name="queryProperties">
        /// The properties to keyword-search, each optionally weighted with a `^boost` suffix (e.g. `title^2`). Omitted or empty searches every searchable text property. A property without a searchable index is rejected with 422.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchBm25RequestVariant2(
            string query,
            global::System.Collections.Generic.IList<string>? queryProperties)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.QueryProperties = queryProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchBm25RequestVariant2" /> class.
        /// </summary>
        public SearchBm25RequestVariant2()
        {
        }

    }
}