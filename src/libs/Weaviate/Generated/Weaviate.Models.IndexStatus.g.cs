
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IndexStatus
    {
        /// <summary>
        /// Canonical inverted-index type. Always one of `filterable`, `searchable`, `rangeFilters` — never the `rangeable` write-path alias.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.IndexStatusTypeJsonConverter))]
        public global::Weaviate.IndexStatusType? Type { get; set; }

        /// <summary>
        /// `partial`: the latest reindex task failed or was cancelled after some tenants had migrated; those tenants have the new index. After a tokenization change they answer queries with it; after enabling an index they answer with it only once the migration finishes. A replica that still owes a tenant's swap answers with the old index until its retry lands. See `migratedTenants` and `totalTenants`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.IndexStatusStatusJsonConverter))]
        public global::Weaviate.IndexStatusStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public float? Progress { get; set; }

        /// <summary>
        /// Number of tenants already migrated, counted over the failed or cancelled runs of this migration since the property last finished one; `taskId` names the latest run. Present only on a `partial` entry, and only to a caller who may read the collection's tenants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("migratedTenants")]
        public long? MigratedTenants { get; set; }

        /// <summary>
        /// Number of tenants those runs cover, counted the same way as `migratedTenants`. Present only on a `partial` entry, and only to a caller who may read the collection's tenants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTenants")]
        public long? TotalTenants { get; set; }

        /// <summary>
        /// ID of the reindex task driving this index entry. Present on every task-driven entry (`pending`, `indexing`, `failed`, `cancelled`, `partial`); absent on a plain `ready` entry. A coupled searchable+filterable tokenization migration reports the same `taskId` on both affected entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        public string? TaskId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenization")]
        public string? Tokenization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetTokenization")]
        public string? TargetTokenization { get; set; }

        /// <summary>
        /// BM25 algorithm currently backing this searchable index. 'wand' is the legacy map-based bucket strategy; 'blockmax' is the Block Max WAND inverted strategy. Only populated for `type=searchable` entries. Not populated for filterable or rangeable indexes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.IndexStatusAlgorithmJsonConverter))]
        public global::Weaviate.IndexStatusAlgorithm? Algorithm { get; set; }

        /// <summary>
        /// BM25 algorithm this searchable index is being rebuilt onto. Populated only while an in-flight rebuild is changing the algorithm; mirrors `targetTokenization` for the change-tokenization verb. Today the only supported transition is wand -&gt; blockmax.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetAlgorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.IndexStatusTargetAlgorithmJsonConverter))]
        public global::Weaviate.IndexStatusTargetAlgorithm? TargetAlgorithm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexStatus" /> class.
        /// </summary>
        /// <param name="type">
        /// Canonical inverted-index type. Always one of `filterable`, `searchable`, `rangeFilters` — never the `rangeable` write-path alias.
        /// </param>
        /// <param name="status">
        /// `partial`: the latest reindex task failed or was cancelled after some tenants had migrated; those tenants have the new index. After a tokenization change they answer queries with it; after enabling an index they answer with it only once the migration finishes. A replica that still owes a tenant's swap answers with the old index until its retry lands. See `migratedTenants` and `totalTenants`.
        /// </param>
        /// <param name="progress"></param>
        /// <param name="migratedTenants">
        /// Number of tenants already migrated, counted over the failed or cancelled runs of this migration since the property last finished one; `taskId` names the latest run. Present only on a `partial` entry, and only to a caller who may read the collection's tenants.
        /// </param>
        /// <param name="totalTenants">
        /// Number of tenants those runs cover, counted the same way as `migratedTenants`. Present only on a `partial` entry, and only to a caller who may read the collection's tenants.
        /// </param>
        /// <param name="taskId">
        /// ID of the reindex task driving this index entry. Present on every task-driven entry (`pending`, `indexing`, `failed`, `cancelled`, `partial`); absent on a plain `ready` entry. A coupled searchable+filterable tokenization migration reports the same `taskId` on both affected entries.
        /// </param>
        /// <param name="tokenization"></param>
        /// <param name="targetTokenization"></param>
        /// <param name="algorithm">
        /// BM25 algorithm currently backing this searchable index. 'wand' is the legacy map-based bucket strategy; 'blockmax' is the Block Max WAND inverted strategy. Only populated for `type=searchable` entries. Not populated for filterable or rangeable indexes.
        /// </param>
        /// <param name="targetAlgorithm">
        /// BM25 algorithm this searchable index is being rebuilt onto. Populated only while an in-flight rebuild is changing the algorithm; mirrors `targetTokenization` for the change-tokenization verb. Today the only supported transition is wand -&gt; blockmax.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexStatus(
            global::Weaviate.IndexStatusType? type,
            global::Weaviate.IndexStatusStatus? status,
            float? progress,
            long? migratedTenants,
            long? totalTenants,
            string? taskId,
            string? tokenization,
            string? targetTokenization,
            global::Weaviate.IndexStatusAlgorithm? algorithm,
            global::Weaviate.IndexStatusTargetAlgorithm? targetAlgorithm)
        {
            this.Type = type;
            this.Status = status;
            this.Progress = progress;
            this.MigratedTenants = migratedTenants;
            this.TotalTenants = totalTenants;
            this.TaskId = taskId;
            this.Tokenization = tokenization;
            this.TargetTokenization = targetTokenization;
            this.Algorithm = algorithm;
            this.TargetAlgorithm = targetAlgorithm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexStatus" /> class.
        /// </summary>
        public IndexStatus()
        {
        }

    }
}