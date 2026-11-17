
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchDelete
    {
        /// <summary>
        /// Outlines how to find the objects to be deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match")]
        public global::Weaviate.BatchDeleteMatch? Match { get; set; }

        /// <summary>
        /// Controls the verbosity of the output, possible values are: `minimal`, `verbose`. Defaults to `minimal`.<br/>
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
        /// If true, the call reports what the filter matches and deletes nothing. &lt;br/&gt;&lt;br/&gt;Depending on the configured verbosity, you will either receive a count of matched objects, or a list of IDs. With a positive [`QUERY_MAXIMUM_RESULTS`](https://docs.weaviate.io/deploy/configuration/env-vars#QUERY_MAXIMUM_RESULTS) the count stops one above it, and the list holds at most `QUERY_MAXIMUM_RESULTS` IDs. Repeating the dry run reports the same count; for an exact total use an aggregate count, which resolves no objects.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dryRun")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDelete" /> class.
        /// </summary>
        /// <param name="match">
        /// Outlines how to find the objects to be deleted.
        /// </param>
        /// <param name="output">
        /// Controls the verbosity of the output, possible values are: `minimal`, `verbose`. Defaults to `minimal`.<br/>
        /// Default Value: minimal
        /// </param>
        /// <param name="deletionTimeUnixMilli">
        /// Timestamp of deletion in milliseconds since epoch UTC.
        /// </param>
        /// <param name="dryRun">
        /// If true, the call reports what the filter matches and deletes nothing. &lt;br/&gt;&lt;br/&gt;Depending on the configured verbosity, you will either receive a count of matched objects, or a list of IDs. With a positive [`QUERY_MAXIMUM_RESULTS`](https://docs.weaviate.io/deploy/configuration/env-vars#QUERY_MAXIMUM_RESULTS) the count stops one above it, and the list holds at most `QUERY_MAXIMUM_RESULTS` IDs. Repeating the dry run reports the same count; for an exact total use an aggregate count, which resolves no objects.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchDelete(
            global::Weaviate.BatchDeleteMatch? match,
            string? output,
            long? deletionTimeUnixMilli,
            bool? dryRun)
        {
            this.Match = match;
            this.Output = output;
            this.DeletionTimeUnixMilli = deletionTimeUnixMilli;
            this.DryRun = dryRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDelete" /> class.
        /// </summary>
        public BatchDelete()
        {
        }

    }
}