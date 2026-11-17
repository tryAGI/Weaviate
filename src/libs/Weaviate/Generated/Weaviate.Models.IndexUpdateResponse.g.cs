
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IndexUpdateResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        public string? TaskId { get; set; }

        /// <summary>
        /// What the server did. `STARTED`: a reindex task was submitted and `taskId` names it. `CANCELLED`: a cancel stopped the in-flight task named by `taskId`. `NO_OP`: a cancel found nothing in flight, and `taskId` is absent. Not a closed set: a newer server may answer with a value this client does not know, so report an unrecognized status rather than rejecting the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexUpdateResponse" /> class.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="status">
        /// What the server did. `STARTED`: a reindex task was submitted and `taskId` names it. `CANCELLED`: a cancel stopped the in-flight task named by `taskId`. `NO_OP`: a cancel found nothing in flight, and `taskId` is absent. Not a closed set: a newer server may answer with a value this client does not know, so report an unrecognized status rather than rejecting the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexUpdateResponse(
            string? taskId,
            string? status)
        {
            this.TaskId = taskId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexUpdateResponse" /> class.
        /// </summary>
        public IndexUpdateResponse()
        {
        }

    }
}