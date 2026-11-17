
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The current state of the rebalance plan. A plan starts in `PLANNING`. A planning run ends it `NOT_NEEDED`, `PROPOSED`, `NO_ACCEPTABLE_PLAN` or `PLANNING_FAILED`, and a stop ends it `STOPPED`.
    /// </summary>
    public enum ReplicationRebalancePlanState
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        NotNeeded,
        /// <summary>
        ///
        /// </summary>
        NoAcceptablePlan,
        /// <summary>
        ///
        /// </summary>
        Planning,
        /// <summary>
        ///
        /// </summary>
        PlanningFailed,
        /// <summary>
        ///
        /// </summary>
        Proposed,
        /// <summary>
        ///
        /// </summary>
        Running,
        /// <summary>
        ///
        /// </summary>
        Stopped,
        /// <summary>
        ///
        /// </summary>
        Stopping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReplicationRebalancePlanStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReplicationRebalancePlanState value)
        {
            return value switch
            {
                ReplicationRebalancePlanState.Completed => "COMPLETED",
                ReplicationRebalancePlanState.Failed => "FAILED",
                ReplicationRebalancePlanState.NotNeeded => "NOT_NEEDED",
                ReplicationRebalancePlanState.NoAcceptablePlan => "NO_ACCEPTABLE_PLAN",
                ReplicationRebalancePlanState.Planning => "PLANNING",
                ReplicationRebalancePlanState.PlanningFailed => "PLANNING_FAILED",
                ReplicationRebalancePlanState.Proposed => "PROPOSED",
                ReplicationRebalancePlanState.Running => "RUNNING",
                ReplicationRebalancePlanState.Stopped => "STOPPED",
                ReplicationRebalancePlanState.Stopping => "STOPPING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReplicationRebalancePlanState? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => ReplicationRebalancePlanState.Completed,
                "FAILED" => ReplicationRebalancePlanState.Failed,
                "NOT_NEEDED" => ReplicationRebalancePlanState.NotNeeded,
                "NO_ACCEPTABLE_PLAN" => ReplicationRebalancePlanState.NoAcceptablePlan,
                "PLANNING" => ReplicationRebalancePlanState.Planning,
                "PLANNING_FAILED" => ReplicationRebalancePlanState.PlanningFailed,
                "PROPOSED" => ReplicationRebalancePlanState.Proposed,
                "RUNNING" => ReplicationRebalancePlanState.Running,
                "STOPPED" => ReplicationRebalancePlanState.Stopped,
                "STOPPING" => ReplicationRebalancePlanState.Stopping,
                _ => null,
            };
        }
    }
}