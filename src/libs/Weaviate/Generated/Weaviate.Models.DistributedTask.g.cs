
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Distributed task metadata.
    /// </summary>
    public sealed partial class DistributedTask
    {
        /// <summary>
        /// The ID of the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The version of the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// The status of the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The time when the task was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// The time when the task reached a terminal status. Absent while the task is still running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishedAt")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// The nodes that finished the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishedNodes")]
        public global::System.Collections.Generic.IList<string>? FinishedNodes { get; set; }

        /// <summary>
        /// The high level reason why the task failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The payload of the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Units of the task. Only present for tasks that use unit tracking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        public global::System.Collections.Generic.IList<global::Weaviate.DistributedTaskUnit>? Units { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedTask" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the task.
        /// </param>
        /// <param name="version">
        /// The version of the task.
        /// </param>
        /// <param name="status">
        /// The status of the task.
        /// </param>
        /// <param name="startedAt">
        /// The time when the task was created.
        /// </param>
        /// <param name="finishedAt">
        /// The time when the task reached a terminal status. Absent while the task is still running.
        /// </param>
        /// <param name="finishedNodes">
        /// The nodes that finished the task.
        /// </param>
        /// <param name="error">
        /// The high level reason why the task failed.
        /// </param>
        /// <param name="payload">
        /// The payload of the task.
        /// </param>
        /// <param name="units">
        /// Units of the task. Only present for tasks that use unit tracking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistributedTask(
            string? id,
            int? version,
            string? status,
            global::System.DateTime? startedAt,
            global::System.DateTime? finishedAt,
            global::System.Collections.Generic.IList<string>? finishedNodes,
            string? error,
            object? payload,
            global::System.Collections.Generic.IList<global::Weaviate.DistributedTaskUnit>? units)
        {
            this.Id = id;
            this.Version = version;
            this.Status = status;
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.FinishedNodes = finishedNodes;
            this.Error = error;
            this.Payload = payload;
            this.Units = units;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedTask" /> class.
        /// </summary>
        public DistributedTask()
        {
        }

    }
}