
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// A unit of a distributed task.
    /// </summary>
    public sealed partial class DistributedTaskUnit
    {
        /// <summary>
        /// The ID of the unit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The node that owns this unit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeId")]
        public string? NodeId { get; set; }

        /// <summary>
        /// The status of the unit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The progress of the unit (0.0 to 1.0).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public float? Progress { get; set; }

        /// <summary>
        /// The error message if the unit failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The time when the unit was last updated, including its transition to a terminal status. Absent for a unit that has not started yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The time when the unit reached a terminal status. Absent while the unit is still running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishedAt")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedTaskUnit" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the unit.
        /// </param>
        /// <param name="nodeId">
        /// The node that owns this unit.
        /// </param>
        /// <param name="status">
        /// The status of the unit.
        /// </param>
        /// <param name="progress">
        /// The progress of the unit (0.0 to 1.0).
        /// </param>
        /// <param name="error">
        /// The error message if the unit failed.
        /// </param>
        /// <param name="updatedAt">
        /// The time when the unit was last updated, including its transition to a terminal status. Absent for a unit that has not started yet.
        /// </param>
        /// <param name="finishedAt">
        /// The time when the unit reached a terminal status. Absent while the unit is still running.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistributedTaskUnit(
            string? id,
            string? nodeId,
            string? status,
            float? progress,
            string? error,
            global::System.DateTime? updatedAt,
            global::System.DateTime? finishedAt)
        {
            this.Id = id;
            this.NodeId = nodeId;
            this.Status = status;
            this.Progress = progress;
            this.Error = error;
            this.UpdatedAt = updatedAt;
            this.FinishedAt = finishedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedTaskUnit" /> class.
        /// </summary>
        public DistributedTaskUnit()
        {
        }

    }
}