
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Current status of the export
    /// </summary>
    public enum ExportCreateResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportCreateResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportCreateResponseStatus value)
        {
            return value switch
            {
                ExportCreateResponseStatus.Started => "STARTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportCreateResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "STARTED" => ExportCreateResponseStatus.Started,
                _ => null,
            };
        }
    }
}