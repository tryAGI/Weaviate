
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Fields shared by every REST search request (near-text, bm25, hybrid, near-object). Unknown fields are ignored (platform parity with the other endpoints). Reserved fields are accepted by the schema but rejected by the server with 422 until the corresponding feature ships.
    /// </summary>
    public sealed partial class SearchCommon
    {
        /// <summary>
        /// Filter search results using a where filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("where")]
        public global::Weaviate.WhereFilter? Where { get; set; }

        /// <summary>
        /// The maximum number of objects to return. Omitted or `0` falls back to the server default (`QUERY_DEFAULTS_LIMIT`); a value above `QUERY_MAXIMUM_RESULTS` is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// The number of objects to skip before returning results. Used with `limit` for pagination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// Cut results off at the first steep drop in score (autocut). The value is the number of score jumps to allow before cutting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoLimit")]
        public long? AutoLimit { get; set; }

        /// <summary>
        /// The non-reference properties to return. Omitted returns all non-reference, non-blob properties; an empty array returns no properties. References are selected with `returnReferences`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnProperties")]
        public global::System.Collections.Generic.IList<string>? ReturnProperties { get; set; }

        /// <summary>
        /// The cross-references to return under each result's `references` key. Each entry selects one reference property and what to return from the referenced objects. Omitted or empty returns no references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnReferences")]
        public global::System.Collections.Generic.IList<global::Weaviate.SearchReferenceSelector>? ReturnReferences { get; set; }

        /// <summary>
        /// The retrieval metadata to return under each result's `metadata` key. The object `id` is always returned as each result's `id` field. Omitted or empty returns no `metadata` block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnMetadata")]
        public global::System.Collections.Generic.IList<global::Weaviate.SearchCommonReturnMetadataItem>? ReturnMetadata { get; set; }

        /// <summary>
        /// The tenant to search in a multi-tenant collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        public string? Tenant { get; set; }

        /// <summary>
        /// The consistency level for the read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consistencyLevel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.SearchCommonConsistencyLevelJsonConverter))]
        public global::Weaviate.SearchCommonConsistencyLevel? ConsistencyLevel { get; set; }

        /// <summary>
        /// Reserved for per-object retrieval-augmented generation. Returns 422 (not yet supported).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("singlePrompt")]
        public string? SinglePrompt { get; set; }

        /// <summary>
        /// Reserved for grouped retrieval-augmented generation. Returns 422 (not yet supported).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupedTask")]
        public string? GroupedTask { get; set; }

        /// <summary>
        /// Reserved for grouped search. Returns 422 (not yet supported).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupBy")]
        public string? GroupBy { get; set; }

        /// <summary>
        /// Reserved for grouped search. Returns 422 (not yet supported).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberOfGroups")]
        public long? NumberOfGroups { get; set; }

        /// <summary>
        /// Reserved for grouped search. Returns 422 (not yet supported).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectsPerGroup")]
        public long? ObjectsPerGroup { get; set; }

        /// <summary>
        /// Reserved for reranking. Returns 422 (not yet supported).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank")]
        public global::Weaviate.SearchRerank? Rerank { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCommon" /> class.
        /// </summary>
        /// <param name="where">
        /// Filter search results using a where filter.
        /// </param>
        /// <param name="limit">
        /// The maximum number of objects to return. Omitted or `0` falls back to the server default (`QUERY_DEFAULTS_LIMIT`); a value above `QUERY_MAXIMUM_RESULTS` is rejected.
        /// </param>
        /// <param name="offset">
        /// The number of objects to skip before returning results. Used with `limit` for pagination.
        /// </param>
        /// <param name="autoLimit">
        /// Cut results off at the first steep drop in score (autocut). The value is the number of score jumps to allow before cutting.
        /// </param>
        /// <param name="returnProperties">
        /// The non-reference properties to return. Omitted returns all non-reference, non-blob properties; an empty array returns no properties. References are selected with `returnReferences`.
        /// </param>
        /// <param name="returnReferences">
        /// The cross-references to return under each result's `references` key. Each entry selects one reference property and what to return from the referenced objects. Omitted or empty returns no references.
        /// </param>
        /// <param name="returnMetadata">
        /// The retrieval metadata to return under each result's `metadata` key. The object `id` is always returned as each result's `id` field. Omitted or empty returns no `metadata` block.
        /// </param>
        /// <param name="tenant">
        /// The tenant to search in a multi-tenant collection.
        /// </param>
        /// <param name="consistencyLevel">
        /// The consistency level for the read.
        /// </param>
        /// <param name="singlePrompt">
        /// Reserved for per-object retrieval-augmented generation. Returns 422 (not yet supported).
        /// </param>
        /// <param name="groupedTask">
        /// Reserved for grouped retrieval-augmented generation. Returns 422 (not yet supported).
        /// </param>
        /// <param name="groupBy">
        /// Reserved for grouped search. Returns 422 (not yet supported).
        /// </param>
        /// <param name="numberOfGroups">
        /// Reserved for grouped search. Returns 422 (not yet supported).
        /// </param>
        /// <param name="objectsPerGroup">
        /// Reserved for grouped search. Returns 422 (not yet supported).
        /// </param>
        /// <param name="rerank">
        /// Reserved for reranking. Returns 422 (not yet supported).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchCommon(
            global::Weaviate.WhereFilter? where,
            long? limit,
            long? offset,
            long? autoLimit,
            global::System.Collections.Generic.IList<string>? returnProperties,
            global::System.Collections.Generic.IList<global::Weaviate.SearchReferenceSelector>? returnReferences,
            global::System.Collections.Generic.IList<global::Weaviate.SearchCommonReturnMetadataItem>? returnMetadata,
            string? tenant,
            global::Weaviate.SearchCommonConsistencyLevel? consistencyLevel,
            string? singlePrompt,
            string? groupedTask,
            string? groupBy,
            long? numberOfGroups,
            long? objectsPerGroup,
            global::Weaviate.SearchRerank? rerank)
        {
            this.Where = where;
            this.Limit = limit;
            this.Offset = offset;
            this.AutoLimit = autoLimit;
            this.ReturnProperties = returnProperties;
            this.ReturnReferences = returnReferences;
            this.ReturnMetadata = returnMetadata;
            this.Tenant = tenant;
            this.ConsistencyLevel = consistencyLevel;
            this.SinglePrompt = singlePrompt;
            this.GroupedTask = groupedTask;
            this.GroupBy = groupBy;
            this.NumberOfGroups = numberOfGroups;
            this.ObjectsPerGroup = objectsPerGroup;
            this.Rerank = rerank;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCommon" /> class.
        /// </summary>
        public SearchCommon()
        {
        }

    }
}