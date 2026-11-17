
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Status of this shard's export
    /// </summary>
    public enum ShardProgressStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Success,
        /// <summary>
        ///
        /// </summary>
        Transferring,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShardProgressStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShardProgressStatus value)
        {
            return value switch
            {
                ShardProgressStatus.Failed => "FAILED",
                ShardProgressStatus.Skipped => "SKIPPED",
                ShardProgressStatus.Success => "SUCCESS",
                ShardProgressStatus.Transferring => "TRANSFERRING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShardProgressStatus? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => ShardProgressStatus.Failed,
                "SKIPPED" => ShardProgressStatus.Skipped,
                "SUCCESS" => ShardProgressStatus.Success,
                "TRANSFERRING" => ShardProgressStatus.Transferring,
                _ => null,
            };
        }
    }
}