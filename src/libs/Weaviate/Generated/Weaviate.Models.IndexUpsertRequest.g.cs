
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Desired index configuration for `PUT /v1/schema/{className}/properties/{propertyName}/index/{indexType}`. The server diffs the body against the current state and either creates the index, migrates its configuration, or returns a NO_OP. Only fields relevant to the target index type are honored: `tokenization` applies to `searchable`/`filterable`, `algorithm` applies to `searchable`. `rangeFilters` takes no config fields. An empty body `{}` is valid and means "ensure the index exists with its current/default config". At most one configuration change may be requested per call (a body implying both a tokenization and an algorithm change is rejected).
    /// </summary>
    public sealed partial class IndexUpsertRequest
    {
        /// <summary>
        /// Target tokenization for a `searchable` or `filterable` index. Required when creating a `searchable` index; optional otherwise (omitted = keep the current value). On `filterable` creation it must be omitted or equal the property's current tokenization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenization")]
        public string? Tokenization { get; set; }

        /// <summary>
        /// Target BM25 algorithm for a `searchable` index. Only `blockmax` is a valid target (input aliases `block-max`, `block_max`, `blockmaxwand`, `bmw` are accepted case-insensitively). From WAND this triggers the Map → BlockMax migration; on an already-`blockmax` index it is a NO_OP. `wand` is rejected (deprecated); downgrade is intentionally not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        public string? Algorithm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexUpsertRequest" /> class.
        /// </summary>
        /// <param name="tokenization">
        /// Target tokenization for a `searchable` or `filterable` index. Required when creating a `searchable` index; optional otherwise (omitted = keep the current value). On `filterable` creation it must be omitted or equal the property's current tokenization.
        /// </param>
        /// <param name="algorithm">
        /// Target BM25 algorithm for a `searchable` index. Only `blockmax` is a valid target (input aliases `block-max`, `block_max`, `blockmaxwand`, `bmw` are accepted case-insensitively). From WAND this triggers the Map → BlockMax migration; on an already-`blockmax` index it is a NO_OP. `wand` is rejected (deprecated); downgrade is intentionally not supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexUpsertRequest(
            string? tokenization,
            string? algorithm)
        {
            this.Tokenization = tokenization;
            this.Algorithm = algorithm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexUpsertRequest" /> class.
        /// </summary>
        public IndexUpsertRequest()
        {
        }

    }
}