
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The definition of a backup create response body
    /// </summary>
    public sealed partial class BackupCreateResponse
    {
        /// <summary>
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The list of classes for which the backup creation process was started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classes")]
        public global::System.Collections.Generic.IList<string>? Classes { get; set; }

        /// <summary>
        /// Backup backend name e.g. filesystem, gcs, s3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backend")]
        public string? Backend { get; set; }

        /// <summary>
        /// Name of the bucket, container, volume, etc
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        public string? Bucket { get; set; }

        /// <summary>
        /// Path within bucket of backup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// error message if creation failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// phase of backup creation process<br/>
        /// Default Value: STARTED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.BackupCreateResponseStatusJsonConverter))]
        public global::Weaviate.BackupCreateResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupCreateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </param>
        /// <param name="classes">
        /// The list of classes for which the backup creation process was started
        /// </param>
        /// <param name="backend">
        /// Backup backend name e.g. filesystem, gcs, s3.
        /// </param>
        /// <param name="bucket">
        /// Name of the bucket, container, volume, etc
        /// </param>
        /// <param name="path">
        /// Path within bucket of backup
        /// </param>
        /// <param name="error">
        /// error message if creation failed
        /// </param>
        /// <param name="status">
        /// phase of backup creation process<br/>
        /// Default Value: STARTED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupCreateResponse(
            string? id,
            global::System.Collections.Generic.IList<string>? classes,
            string? backend,
            string? bucket,
            string? path,
            string? error,
            global::Weaviate.BackupCreateResponseStatus? status)
        {
            this.Id = id;
            this.Classes = classes;
            this.Backend = backend;
            this.Bucket = bucket;
            this.Path = path;
            this.Error = error;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupCreateResponse" /> class.
        /// </summary>
        public BackupCreateResponse()
        {
        }
    }
}