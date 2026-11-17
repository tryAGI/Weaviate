
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Which mode of operation the node is running in.
    /// </summary>
    public enum NodeStatusOperationalMode
    {
        /// <summary>
        ///
        /// </summary>
        ReadOnly,
        /// <summary>
        ///
        /// </summary>
        ReadWrite,
        /// <summary>
        ///
        /// </summary>
        ScaleOut,
        /// <summary>
        ///
        /// </summary>
        WriteOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeStatusOperationalModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeStatusOperationalMode value)
        {
            return value switch
            {
                NodeStatusOperationalMode.ReadOnly => "ReadOnly",
                NodeStatusOperationalMode.ReadWrite => "ReadWrite",
                NodeStatusOperationalMode.ScaleOut => "ScaleOut",
                NodeStatusOperationalMode.WriteOnly => "WriteOnly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeStatusOperationalMode? ToEnum(string value)
        {
            return value switch
            {
                "ReadOnly" => NodeStatusOperationalMode.ReadOnly,
                "ReadWrite" => NodeStatusOperationalMode.ReadWrite,
                "ScaleOut" => NodeStatusOperationalMode.ScaleOut,
                "WriteOnly" => NodeStatusOperationalMode.WriteOnly,
                _ => null,
            };
        }
    }
}