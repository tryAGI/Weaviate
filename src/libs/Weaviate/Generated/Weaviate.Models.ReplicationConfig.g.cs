
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Configure how replication is executed in a cluster
    /// </summary>
    public sealed partial class ReplicationConfig
    {
        /// <summary>
        /// Number of times a collection (class) is replicated (default: 1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("factor")]
        public int? Factor { get; set; }

        /// <summary>
        /// Configuration for asynchronous replication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asyncConfig")]
        public global::Weaviate.ReplicationAsyncConfig? AsyncConfig { get; set; }

        /// <summary>
        /// Conflict resolution strategy for deleted objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletionStrategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.ReplicationConfigDeletionStrategyJsonConverter))]
        public global::Weaviate.ReplicationConfigDeletionStrategy? DeletionStrategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationConfig" /> class.
        /// </summary>
        /// <param name="factor">
        /// Number of times a collection (class) is replicated (default: 1).
        /// </param>
        /// <param name="asyncConfig">
        /// Configuration for asynchronous replication.
        /// </param>
        /// <param name="deletionStrategy">
        /// Conflict resolution strategy for deleted objects.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationConfig(
            int? factor,
            global::Weaviate.ReplicationAsyncConfig? asyncConfig,
            global::Weaviate.ReplicationConfigDeletionStrategy? deletionStrategy)
        {
            this.Factor = factor;
            this.AsyncConfig = asyncConfig;
            this.DeletionStrategy = deletionStrategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationConfig" /> class.
        /// </summary>
        public ReplicationConfig()
        {
        }

    }
}