
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Indicates whether the operation is a `COPY` (source replica remains) or a `MOVE` (source replica is removed after successful transfer).
    /// </summary>
    public enum ReplicationReplicateDetailsReplicaResponseType
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
    public static class ReplicationReplicateDetailsReplicaResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReplicationReplicateDetailsReplicaResponseType value)
        {
            return value switch
            {
                ReplicationReplicateDetailsReplicaResponseType.Copy => "COPY",
                ReplicationReplicateDetailsReplicaResponseType.Move => "MOVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReplicationReplicateDetailsReplicaResponseType? ToEnum(string value)
        {
            return value switch
            {
                "COPY" => ReplicationReplicateDetailsReplicaResponseType.Copy,
                "MOVE" => ReplicationReplicateDetailsReplicaResponseType.Move,
                _ => null,
            };
        }
    }
}