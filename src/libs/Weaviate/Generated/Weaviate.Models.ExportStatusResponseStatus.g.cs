
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Current status of the export
    /// </summary>
    public enum ExportStatusResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Started,
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
    public static class ExportStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportStatusResponseStatus value)
        {
            return value switch
            {
                ExportStatusResponseStatus.Canceled => "CANCELED",
                ExportStatusResponseStatus.Failed => "FAILED",
                ExportStatusResponseStatus.Started => "STARTED",
                ExportStatusResponseStatus.Success => "SUCCESS",
                ExportStatusResponseStatus.Transferring => "TRANSFERRING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => ExportStatusResponseStatus.Canceled,
                "FAILED" => ExportStatusResponseStatus.Failed,
                "STARTED" => ExportStatusResponseStatus.Started,
                "SUCCESS" => ExportStatusResponseStatus.Success,
                "TRANSFERRING" => ExportStatusResponseStatus.Transferring,
                _ => null,
            };
        }
    }
}