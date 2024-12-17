
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Backup custom configuration
    /// </summary>
    public sealed partial class BackupConfig
    {
        /// <summary>
        /// name of the endpoint, e.g. s3.amazonaws.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// Name of the bucket, container, volume, etc
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Bucket")]
        public string? Bucket { get; set; }

        /// <summary>
        /// Path or key within the bucket
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
        /// Aimed chunk size, with a minimum of 2MB, default of 128MB, and a maximum of 512MB. The actual chunk size may vary.<br/>
        /// Default Value: 128
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupConfig" /> class.
        /// </summary>
        /// <param name="endpoint">
        /// name of the endpoint, e.g. s3.amazonaws.com
        /// </param>
        /// <param name="bucket">
        /// Name of the bucket, container, volume, etc
        /// </param>
        /// <param name="path">
        /// Path or key within the bucket
        /// </param>
        /// <param name="cPUPercentage">
        /// Desired CPU core utilization ranging from 1%-80%<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="chunkSize">
        /// Aimed chunk size, with a minimum of 2MB, default of 128MB, and a maximum of 512MB. The actual chunk size may vary.<br/>
        /// Default Value: 128
        /// </param>
        /// <param name="compressionLevel">
        /// compression level used by compression algorithm<br/>
        /// Default Value: DefaultCompression
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BackupConfig(
            string? endpoint,
            string? bucket,
            string? path,
            int? cPUPercentage,
            int? chunkSize,
            global::Weaviate.BackupConfigCompressionLevel? compressionLevel)
        {
            this.Endpoint = endpoint;
            this.Bucket = bucket;
            this.Path = path;
            this.CPUPercentage = cPUPercentage;
            this.ChunkSize = chunkSize;
            this.CompressionLevel = compressionLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupConfig" /> class.
        /// </summary>
        public BackupConfig()
        {
        }
    }
}