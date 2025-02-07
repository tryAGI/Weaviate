
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Delete Objects response.
    /// </summary>
    public sealed partial class BatchDeleteResponse
    {
        /// <summary>
        /// Outlines how to find the objects to be deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match")]
        public global::Weaviate.BatchDeleteResponseMatch? Match { get; set; }

        /// <summary>
        /// Controls the verbosity of the output, possible values are: "minimal", "verbose". Defaults to "minimal".<br/>
        /// Default Value: minimal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Timestamp of deletion in milliseconds since epoch UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletionTimeUnixMilli")]
        public long? DeletionTimeUnixMilli { get; set; }

        /// <summary>
        /// If true, objects will not be deleted yet, but merely listed. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dryRun")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::Weaviate.BatchDeleteResponseResults? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteResponse" /> class.
        /// </summary>
        /// <param name="match">
        /// Outlines how to find the objects to be deleted.
        /// </param>
        /// <param name="output">
        /// Controls the verbosity of the output, possible values are: "minimal", "verbose". Defaults to "minimal".<br/>
        /// Default Value: minimal
        /// </param>
        /// <param name="deletionTimeUnixMilli">
        /// Timestamp of deletion in milliseconds since epoch UTC.
        /// </param>
        /// <param name="dryRun">
        /// If true, objects will not be deleted yet, but merely listed. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchDeleteResponse(
            global::Weaviate.BatchDeleteResponseMatch? match,
            string? output,
            long? deletionTimeUnixMilli,
            bool? dryRun,
            global::Weaviate.BatchDeleteResponseResults? results)
        {
            this.Match = match;
            this.Output = output;
            this.DeletionTimeUnixMilli = deletionTimeUnixMilli;
            this.DryRun = dryRun;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteResponse" /> class.
        /// </summary>
        public BatchDeleteResponse()
        {
        }
    }
}