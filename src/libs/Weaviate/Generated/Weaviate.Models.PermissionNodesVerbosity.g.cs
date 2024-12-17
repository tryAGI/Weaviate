
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// whether to allow (verbose) returning shards and stats data in the response<br/>
    /// Default Value: minimal
    /// </summary>
    public enum PermissionNodesVerbosity
    {
        /// <summary>
        /// 
        /// </summary>
        Verbose,
        /// <summary>
        /// 
        /// </summary>
        Minimal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PermissionNodesVerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PermissionNodesVerbosity value)
        {
            return value switch
            {
                PermissionNodesVerbosity.Verbose => "verbose",
                PermissionNodesVerbosity.Minimal => "minimal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PermissionNodesVerbosity? ToEnum(string value)
        {
            return value switch
            {
                "verbose" => PermissionNodesVerbosity.Verbose,
                "minimal" => PermissionNodesVerbosity.Minimal,
                _ => null,
            };
        }
    }
}