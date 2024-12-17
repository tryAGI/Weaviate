
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Conflict resolution strategy for deleted objects.
    /// </summary>
    public enum ReplicationConfigDeletionStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        NoAutomatedResolution,
        /// <summary>
        /// 
        /// </summary>
        DeleteOnConflict,
        /// <summary>
        /// 
        /// </summary>
        TimeBasedResolution,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReplicationConfigDeletionStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReplicationConfigDeletionStrategy value)
        {
            return value switch
            {
                ReplicationConfigDeletionStrategy.NoAutomatedResolution => "NoAutomatedResolution",
                ReplicationConfigDeletionStrategy.DeleteOnConflict => "DeleteOnConflict",
                ReplicationConfigDeletionStrategy.TimeBasedResolution => "TimeBasedResolution",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReplicationConfigDeletionStrategy? ToEnum(string value)
        {
            return value switch
            {
                "NoAutomatedResolution" => ReplicationConfigDeletionStrategy.NoAutomatedResolution,
                "DeleteOnConflict" => ReplicationConfigDeletionStrategy.DeleteOnConflict,
                "TimeBasedResolution" => ReplicationConfigDeletionStrategy.TimeBasedResolution,
                _ => null,
            };
        }
    }
}