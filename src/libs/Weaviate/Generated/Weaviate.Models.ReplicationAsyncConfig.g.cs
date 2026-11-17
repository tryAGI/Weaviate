
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Configuration for asynchronous replication.
    /// </summary>
    public sealed partial class ReplicationAsyncConfig
    {
        /// <summary>
        /// Height of the hashtree used for diffing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashtreeHeight")]
        public long? HashtreeHeight { get; set; }

        /// <summary>
        /// Base frequency in milliseconds at which async replication runs diff calculations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency")]
        public long? Frequency { get; set; }

        /// <summary>
        /// Frequency in milliseconds at which async replication runs while propagation is active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequencyWhilePropagating")]
        public long? FrequencyWhilePropagating { get; set; }

        /// <summary>
        /// Interval in seconds at which async replication logs its status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loggingFrequency")]
        public long? LoggingFrequency { get; set; }

        /// <summary>
        /// Maximum number of object keys included in a single diff batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diffBatchSize")]
        public long? DiffBatchSize { get; set; }

        /// <summary>
        /// Timeout in seconds for computing a diff against a single node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diffPerNodeTimeout")]
        public long? DiffPerNodeTimeout { get; set; }

        /// <summary>
        /// Overall timeout in seconds for the pre-propagation phase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prePropagationTimeout")]
        public long? PrePropagationTimeout { get; set; }

        /// <summary>
        /// Timeout in seconds for propagating batch of changes to a node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propagationTimeout")]
        public long? PropagationTimeout { get; set; }

        /// <summary>
        /// Maximum number of objects to propagate in a single async replication run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propagationLimit")]
        public long? PropagationLimit { get; set; }

        /// <summary>
        /// Delay in milliseconds before newly added or updated objects are propagated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propagationDelay")]
        public long? PropagationDelay { get; set; }

        /// <summary>
        /// Maximum number of concurrent propagation workers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propagationConcurrency")]
        public long? PropagationConcurrency { get; set; }

        /// <summary>
        /// Number of objects to include in a single propagation batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propagationBatchSize")]
        public long? PropagationBatchSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationAsyncConfig" /> class.
        /// </summary>
        /// <param name="hashtreeHeight">
        /// Height of the hashtree used for diffing.
        /// </param>
        /// <param name="frequency">
        /// Base frequency in milliseconds at which async replication runs diff calculations.
        /// </param>
        /// <param name="frequencyWhilePropagating">
        /// Frequency in milliseconds at which async replication runs while propagation is active.
        /// </param>
        /// <param name="loggingFrequency">
        /// Interval in seconds at which async replication logs its status.
        /// </param>
        /// <param name="diffBatchSize">
        /// Maximum number of object keys included in a single diff batch.
        /// </param>
        /// <param name="diffPerNodeTimeout">
        /// Timeout in seconds for computing a diff against a single node.
        /// </param>
        /// <param name="prePropagationTimeout">
        /// Overall timeout in seconds for the pre-propagation phase.
        /// </param>
        /// <param name="propagationTimeout">
        /// Timeout in seconds for propagating batch of changes to a node.
        /// </param>
        /// <param name="propagationLimit">
        /// Maximum number of objects to propagate in a single async replication run.
        /// </param>
        /// <param name="propagationDelay">
        /// Delay in milliseconds before newly added or updated objects are propagated.
        /// </param>
        /// <param name="propagationConcurrency">
        /// Maximum number of concurrent propagation workers.
        /// </param>
        /// <param name="propagationBatchSize">
        /// Number of objects to include in a single propagation batch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationAsyncConfig(
            long? hashtreeHeight,
            long? frequency,
            long? frequencyWhilePropagating,
            long? loggingFrequency,
            long? diffBatchSize,
            long? diffPerNodeTimeout,
            long? prePropagationTimeout,
            long? propagationTimeout,
            long? propagationLimit,
            long? propagationDelay,
            long? propagationConcurrency,
            long? propagationBatchSize)
        {
            this.HashtreeHeight = hashtreeHeight;
            this.Frequency = frequency;
            this.FrequencyWhilePropagating = frequencyWhilePropagating;
            this.LoggingFrequency = loggingFrequency;
            this.DiffBatchSize = diffBatchSize;
            this.DiffPerNodeTimeout = diffPerNodeTimeout;
            this.PrePropagationTimeout = prePropagationTimeout;
            this.PropagationTimeout = propagationTimeout;
            this.PropagationLimit = propagationLimit;
            this.PropagationDelay = propagationDelay;
            this.PropagationConcurrency = propagationConcurrency;
            this.PropagationBatchSize = propagationBatchSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationAsyncConfig" /> class.
        /// </summary>
        public ReplicationAsyncConfig()
        {
        }

    }
}