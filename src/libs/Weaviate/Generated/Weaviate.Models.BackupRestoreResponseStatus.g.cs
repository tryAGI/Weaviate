
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Phase of backup restoration process.<br/>
    /// Default Value: STARTED
    /// </summary>
    public enum BackupRestoreResponseStatus
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
    public static class BackupRestoreResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupRestoreResponseStatus value)
        {
            return value switch
            {
                BackupRestoreResponseStatus.Canceled => "CANCELED",
                BackupRestoreResponseStatus.Cancelling => "CANCELLING",
                BackupRestoreResponseStatus.Failed => "FAILED",
                BackupRestoreResponseStatus.Finalizing => "FINALIZING",
                BackupRestoreResponseStatus.Started => "STARTED",
                BackupRestoreResponseStatus.Success => "SUCCESS",
                BackupRestoreResponseStatus.Transferred => "TRANSFERRED",
                BackupRestoreResponseStatus.Transferring => "TRANSFERRING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackupRestoreResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => BackupRestoreResponseStatus.Canceled,
                "CANCELLING" => BackupRestoreResponseStatus.Cancelling,
                "FAILED" => BackupRestoreResponseStatus.Failed,
                "FINALIZING" => BackupRestoreResponseStatus.Finalizing,
                "STARTED" => BackupRestoreResponseStatus.Started,
                "SUCCESS" => BackupRestoreResponseStatus.Success,
                "TRANSFERRED" => BackupRestoreResponseStatus.Transferred,
                "TRANSFERRING" => BackupRestoreResponseStatus.Transferring,
                _ => null,
            };
        }
    }
}