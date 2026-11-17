
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Backup custom configuration.
    /// </summary>
    public sealed partial class BackupConfig
    {
        /// <summary>
        /// Name of the endpoint, e.g. s3.amazonaws.com.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// Name of the bucket, container, volume, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Bucket")]
        public string? Bucket { get; set; }

        /// <summary>
        /// Path or key within the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Path")]
        public string? Path { get; set; }

        /// <summary>
        /// Desired CPU core utilization ranging from 1%-80%<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("CPUPercentage")]
        public int? CPUPercentage { get; set; }

        /// <summary>
        /// Deprecated, has no effect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ChunkSize")]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// compression level used by compression algorithm<br/>
        /// Default Value: DefaultCompression
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("CompressionLevel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.BackupConfigCompressionLevelJsonConverter))]
        public global::Weaviate.BackupConfigCompressionLevel? CompressionLevel { get; set; }

        /// <summary>
        /// If true, shards of replicated collections proven in sync by async-replication checkpoints are archived by one replica instead of all, and restore copies them back to every replica; other shards are archived by every replica. Requires async replication, BACKUP_DEDUPE_ENABLED=true (else 422) and a Weaviate license key (else 403) on every node. Such backups restore only on versions that support this option; restoring needs no license.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dedupeReplicas")]
        public bool? DedupeReplicas { get; set; }

        /// <summary>
        /// How long the coordinator waits for replica convergence proof before shards fall back to being archived by every replica. Only used when dedupeReplicas is set. When omitted, BACKUP_DEDUPE_CONVERGENCE_TIMEOUT applies (15 seconds unless configured). The wait happens synchronously inside the backup creation request, which blocks for roughly 10 seconds plus up to this timeout; size client timeouts accordingly.<br/>
        /// Default Value: 15
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dedupeConvergenceTimeoutSeconds")]
        public int? DedupeConvergenceTimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupConfig" /> class.
        /// </summary>
        /// <param name="endpoint">
        /// Name of the endpoint, e.g. s3.amazonaws.com.
        /// </param>
        /// <param name="bucket">
        /// Name of the bucket, container, volume, etc.
        /// </param>
        /// <param name="path">
        /// Path or key within the bucket.
        /// </param>
        /// <param name="cPUPercentage">
        /// Desired CPU core utilization ranging from 1%-80%<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="chunkSize">
        /// Deprecated, has no effect.
        /// </param>
        /// <param name="compressionLevel">
        /// compression level used by compression algorithm<br/>
        /// Default Value: DefaultCompression
        /// </param>
        /// <param name="dedupeReplicas">
        /// If true, shards of replicated collections proven in sync by async-replication checkpoints are archived by one replica instead of all, and restore copies them back to every replica; other shards are archived by every replica. Requires async replication, BACKUP_DEDUPE_ENABLED=true (else 422) and a Weaviate license key (else 403) on every node. Such backups restore only on versions that support this option; restoring needs no license.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dedupeConvergenceTimeoutSeconds">
        /// How long the coordinator waits for replica convergence proof before shards fall back to being archived by every replica. Only used when dedupeReplicas is set. When omitted, BACKUP_DEDUPE_CONVERGENCE_TIMEOUT applies (15 seconds unless configured). The wait happens synchronously inside the backup creation request, which blocks for roughly 10 seconds plus up to this timeout; size client timeouts accordingly.<br/>
        /// Default Value: 15
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupConfig(
            string? endpoint,
            string? bucket,
            string? path,
            int? cPUPercentage,
            int? chunkSize,
            global::Weaviate.BackupConfigCompressionLevel? compressionLevel,
            bool? dedupeReplicas,
            int? dedupeConvergenceTimeoutSeconds)
        {
            this.Endpoint = endpoint;
            this.Bucket = bucket;
            this.Path = path;
            this.CPUPercentage = cPUPercentage;
            this.ChunkSize = chunkSize;
            this.CompressionLevel = compressionLevel;
            this.DedupeReplicas = dedupeReplicas;
            this.DedupeConvergenceTimeoutSeconds = dedupeConvergenceTimeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupConfig" /> class.
        /// </summary>
        public BackupConfig()
        {
        }

    }
}