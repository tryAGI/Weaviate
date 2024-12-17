
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Backup custom configuration
    /// </summary>
    public sealed partial class RestoreConfig
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
        /// Path within the bucket
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreConfig" /> class.
        /// </summary>
        /// <param name="endpoint">
        /// name of the endpoint, e.g. s3.amazonaws.com
        /// </param>
        /// <param name="bucket">
        /// Name of the bucket, container, volume, etc
        /// </param>
        /// <param name="path">
        /// Path within the bucket
        /// </param>
        /// <param name="cPUPercentage">
        /// Desired CPU core utilization ranging from 1%-80%<br/>
        /// Default Value: 50
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RestoreConfig(
            string? endpoint,
            string? bucket,
            string? path,
            int? cPUPercentage)
        {
            this.Endpoint = endpoint;
            this.Bucket = bucket;
            this.Path = path;
            this.CPUPercentage = cPUPercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreConfig" /> class.
        /// </summary>
        public RestoreConfig()
        {
        }
    }
}