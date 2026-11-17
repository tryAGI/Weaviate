
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Progress information for exporting a single shard
    /// </summary>
    public sealed partial class ShardProgress
    {
        /// <summary>
        /// Status of this shard's export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.ShardProgressStatusJsonConverter))]
        public global::Weaviate.ShardProgressStatus? Status { get; set; }

        /// <summary>
        /// Number of objects exported from this shard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectsExported")]
        public long? ObjectsExported { get; set; }

        /// <summary>
        /// Error message if this shard's export failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Reason why this shard was skipped (e.g. tenant status)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipReason")]
        public string? SkipReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardProgress" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of this shard's export
        /// </param>
        /// <param name="objectsExported">
        /// Number of objects exported from this shard
        /// </param>
        /// <param name="error">
        /// Error message if this shard's export failed
        /// </param>
        /// <param name="skipReason">
        /// Reason why this shard was skipped (e.g. tenant status)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShardProgress(
            global::Weaviate.ShardProgressStatus? status,
            long? objectsExported,
            string? error,
            string? skipReason)
        {
            this.Status = status;
            this.ObjectsExported = objectsExported;
            this.Error = error;
            this.SkipReason = skipReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardProgress" /> class.
        /// </summary>
        public ShardProgress()
        {
        }

    }
}