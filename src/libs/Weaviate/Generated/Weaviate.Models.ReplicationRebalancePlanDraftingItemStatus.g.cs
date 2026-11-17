
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// `REPORTED` once the node has saved and reported its draft, `FAILED` if its drafting failed, and `DRAFTING` otherwise.
    /// </summary>
    public enum ReplicationRebalancePlanDraftingItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Drafting,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Reported,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReplicationRebalancePlanDraftingItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReplicationRebalancePlanDraftingItemStatus value)
        {
            return value switch
            {
                ReplicationRebalancePlanDraftingItemStatus.Drafting => "DRAFTING",
                ReplicationRebalancePlanDraftingItemStatus.Failed => "FAILED",
                ReplicationRebalancePlanDraftingItemStatus.Reported => "REPORTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReplicationRebalancePlanDraftingItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "DRAFTING" => ReplicationRebalancePlanDraftingItemStatus.Drafting,
                "FAILED" => ReplicationRebalancePlanDraftingItemStatus.Failed,
                "REPORTED" => ReplicationRebalancePlanDraftingItemStatus.Reported,
                _ => null,
            };
        }
    }
}