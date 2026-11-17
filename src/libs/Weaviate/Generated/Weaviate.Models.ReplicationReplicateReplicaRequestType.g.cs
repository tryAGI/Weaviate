
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Specifies the type of replication operation to perform. `COPY` creates a new replica on the target node while keeping the source replica. `MOVE` creates a new replica on the target node and then removes the source replica upon successful completion. Defaults to `COPY` if omitted.<br/>
    /// Default Value: COPY
    /// </summary>
    public enum ReplicationReplicateReplicaRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Copy,
        /// <summary>
        ///
        /// </summary>
        Move,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReplicationReplicateReplicaRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReplicationReplicateReplicaRequestType value)
        {
            return value switch
            {
                ReplicationReplicateReplicaRequestType.Copy => "COPY",
                ReplicationReplicateReplicaRequestType.Move => "MOVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReplicationReplicateReplicaRequestType? ToEnum(string value)
        {
            return value switch
            {
                "COPY" => ReplicationReplicateReplicaRequestType.Copy,
                "MOVE" => ReplicationReplicateReplicaRequestType.Move,
                _ => null,
            };
        }
    }
}