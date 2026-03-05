
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Node's status.<br/>
    /// Default Value: HEALTHY
    /// </summary>
    public enum NodeStatusStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Healthy,
        /// <summary>
        /// 
        /// </summary>
        Unhealthy,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeStatusStatus value)
        {
            return value switch
            {
                NodeStatusStatus.Healthy => "HEALTHY",
                NodeStatusStatus.Unhealthy => "UNHEALTHY",
                NodeStatusStatus.Unavailable => "UNAVAILABLE",
                NodeStatusStatus.Timeout => "TIMEOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "HEALTHY" => NodeStatusStatus.Healthy,
                "UNHEALTHY" => NodeStatusStatus.Unhealthy,
                "UNAVAILABLE" => NodeStatusStatus.Unavailable,
                "TIMEOUT" => NodeStatusStatus.Timeout,
                _ => null,
            };
        }
    }
}