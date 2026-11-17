
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The cluster's rebalance plan: the request it was created from, its current state, and the node measurements and baseline balance taken by its planning run.
    /// </summary>
    public sealed partial class ReplicationRebalancePlan
    {
        /// <summary>
        /// The unique identifier (ID) of the rebalance plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The current state of the rebalance plan. A plan starts in `PLANNING`. A planning run ends it `NOT_NEEDED`, `PROPOSED`, `NO_ACCEPTABLE_PLAN` or `PLANNING_FAILED`, and a stop ends it `STOPPED`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.ReplicationRebalancePlanStateJsonConverter))]
        public global::Weaviate.ReplicationRebalancePlanState? State { get; set; }

        /// <summary>
        /// The UNIX timestamp in ms when the plan was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAtUnixMs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CreatedAtUnixMs { get; set; }

        /// <summary>
        /// The UNIX timestamp in ms when the applied planning run started measuring the nodes. Zero until a planning run completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measuredAtUnixMs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? MeasuredAtUnixMs { get; set; }

        /// <summary>
        /// A human-readable explanation of the planning outcome, e.g. why planning failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// The names of the nodes that replicas move away from, as given in the create request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceNodes")]
        public global::System.Collections.Generic.IList<string>? SourceNodes { get; set; }

        /// <summary>
        /// The names of the nodes that replicas move to, as given in the create request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetNodes")]
        public global::System.Collections.Generic.IList<string>? TargetNodes { get; set; }

        /// <summary>
        /// The names of the collections given in the create request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        public global::System.Collections.Generic.IList<string>? Collections { get; set; }

        /// <summary>
        /// The resource measurement of each listed node, taken by the applied planning run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::System.Collections.Generic.IList<global::Weaviate.ReplicationRebalancePlanNode>? Nodes { get; set; }

        /// <summary>
        /// The measured load of each listed node before any move.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline")]
        public global::System.Collections.Generic.IList<global::Weaviate.ReplicationRebalancePlanBaselineItem>? Baseline { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationRebalancePlan" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier (ID) of the rebalance plan.
        /// </param>
        /// <param name="state">
        /// The current state of the rebalance plan. A plan starts in `PLANNING`. A planning run ends it `NOT_NEEDED`, `PROPOSED`, `NO_ACCEPTABLE_PLAN` or `PLANNING_FAILED`, and a stop ends it `STOPPED`.
        /// </param>
        /// <param name="createdAtUnixMs">
        /// The UNIX timestamp in ms when the plan was created.
        /// </param>
        /// <param name="measuredAtUnixMs">
        /// The UNIX timestamp in ms when the applied planning run started measuring the nodes. Zero until a planning run completes.
        /// </param>
        /// <param name="reason">
        /// A human-readable explanation of the planning outcome, e.g. why planning failed.
        /// </param>
        /// <param name="sourceNodes">
        /// The names of the nodes that replicas move away from, as given in the create request.
        /// </param>
        /// <param name="targetNodes">
        /// The names of the nodes that replicas move to, as given in the create request.
        /// </param>
        /// <param name="collections">
        /// The names of the collections given in the create request.
        /// </param>
        /// <param name="nodes">
        /// The resource measurement of each listed node, taken by the applied planning run.
        /// </param>
        /// <param name="baseline">
        /// The measured load of each listed node before any move.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationRebalancePlan(
            string? id,
            global::Weaviate.ReplicationRebalancePlanState? state,
            global::System.DateTimeOffset? createdAtUnixMs,
            global::System.DateTimeOffset? measuredAtUnixMs,
            string? reason,
            global::System.Collections.Generic.IList<string>? sourceNodes,
            global::System.Collections.Generic.IList<string>? targetNodes,
            global::System.Collections.Generic.IList<string>? collections,
            global::System.Collections.Generic.IList<global::Weaviate.ReplicationRebalancePlanNode>? nodes,
            global::System.Collections.Generic.IList<global::Weaviate.ReplicationRebalancePlanBaselineItem>? baseline)
        {
            this.Id = id;
            this.State = state;
            this.CreatedAtUnixMs = createdAtUnixMs;
            this.MeasuredAtUnixMs = measuredAtUnixMs;
            this.Reason = reason;
            this.SourceNodes = sourceNodes;
            this.TargetNodes = targetNodes;
            this.Collections = collections;
            this.Nodes = nodes;
            this.Baseline = baseline;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationRebalancePlan" /> class.
        /// </summary>
        public ReplicationRebalancePlan()
        {
        }

    }
}