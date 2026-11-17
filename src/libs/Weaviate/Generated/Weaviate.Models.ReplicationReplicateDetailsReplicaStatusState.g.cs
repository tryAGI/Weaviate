
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The current operational state of the replica during the replication process.
    /// </summary>
    public enum ReplicationReplicateDetailsReplicaStatusState
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Dehydrating,
        /// <summary>
        ///
        /// </summary>
        Finalizing,
        /// <summary>
        ///
        /// </summary>
        Hydrating,
        /// <summary>
        ///
        /// </summary>
        Integrating,
        /// <summary>
        ///
        /// </summary>
        Ready,
        /// <summary>
        ///
        /// </summary>
        Registered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReplicationReplicateDetailsReplicaStatusStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReplicationReplicateDetailsReplicaStatusState value)
        {
            return value switch
            {
                ReplicationReplicateDetailsReplicaStatusState.Cancelled => "CANCELLED",
                ReplicationReplicateDetailsReplicaStatusState.Dehydrating => "DEHYDRATING",
                ReplicationReplicateDetailsReplicaStatusState.Finalizing => "FINALIZING",
                ReplicationReplicateDetailsReplicaStatusState.Hydrating => "HYDRATING",
                ReplicationReplicateDetailsReplicaStatusState.Integrating => "INTEGRATING",
                ReplicationReplicateDetailsReplicaStatusState.Ready => "READY",
                ReplicationReplicateDetailsReplicaStatusState.Registered => "REGISTERED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReplicationReplicateDetailsReplicaStatusState? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ReplicationReplicateDetailsReplicaStatusState.Cancelled,
                "DEHYDRATING" => ReplicationReplicateDetailsReplicaStatusState.Dehydrating,
                "FINALIZING" => ReplicationReplicateDetailsReplicaStatusState.Finalizing,
                "HYDRATING" => ReplicationReplicateDetailsReplicaStatusState.Hydrating,
                "INTEGRATING" => ReplicationReplicateDetailsReplicaStatusState.Integrating,
                "READY" => ReplicationReplicateDetailsReplicaStatusState.Ready,
                "REGISTERED" => ReplicationReplicateDetailsReplicaStatusState.Registered,
                _ => null,
            };
        }
    }
}