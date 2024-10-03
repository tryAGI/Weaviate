
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The summary of a nodes batch queue congestion status.
    /// </summary>
    public sealed partial class BatchStats
    {
        /// <summary>
        /// How many objects are currently in the batch queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queueLength")]
        public double? QueueLength { get; set; }

        /// <summary>
        /// How many objects are approximately processed from the batch queue per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratePerSecond")]
        public double? RatePerSecond { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}