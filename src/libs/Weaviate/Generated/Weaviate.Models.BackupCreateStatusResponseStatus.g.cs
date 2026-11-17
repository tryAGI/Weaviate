
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// phase of backup creation process<br/>
    /// Default Value: STARTED
    /// </summary>
    public enum BackupCreateStatusResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Cancelling,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Finalizing,
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
        Transferred,
        /// <summary>
        ///
        /// </summary>
        Transferring,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackupCreateStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupCreateStatusResponseStatus value)
        {
            return value switch
            {
                BackupCreateStatusResponseStatus.Canceled => "CANCELED",
                BackupCreateStatusResponseStatus.Cancelling => "CANCELLING",
                BackupCreateStatusResponseStatus.Failed => "FAILED",
                BackupCreateStatusResponseStatus.Finalizing => "FINALIZING",
                BackupCreateStatusResponseStatus.Started => "STARTED",
                BackupCreateStatusResponseStatus.Success => "SUCCESS",
                BackupCreateStatusResponseStatus.Transferred => "TRANSFERRED",
                BackupCreateStatusResponseStatus.Transferring => "TRANSFERRING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackupCreateStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => BackupCreateStatusResponseStatus.Canceled,
                "CANCELLING" => BackupCreateStatusResponseStatus.Cancelling,
                "FAILED" => BackupCreateStatusResponseStatus.Failed,
                "FINALIZING" => BackupCreateStatusResponseStatus.Finalizing,
                "STARTED" => BackupCreateStatusResponseStatus.Started,
                "SUCCESS" => BackupCreateStatusResponseStatus.Success,
                "TRANSFERRED" => BackupCreateStatusResponseStatus.Transferred,
                "TRANSFERRING" => BackupCreateStatusResponseStatus.Transferring,
                _ => null,
            };
        }
    }
}