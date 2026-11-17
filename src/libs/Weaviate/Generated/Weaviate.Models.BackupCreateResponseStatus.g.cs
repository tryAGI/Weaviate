
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// phase of backup creation process<br/>
    /// Default Value: STARTED
    /// </summary>
    public enum BackupCreateResponseStatus
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
    public static class BackupCreateResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupCreateResponseStatus value)
        {
            return value switch
            {
                BackupCreateResponseStatus.Canceled => "CANCELED",
                BackupCreateResponseStatus.Cancelling => "CANCELLING",
                BackupCreateResponseStatus.Failed => "FAILED",
                BackupCreateResponseStatus.Finalizing => "FINALIZING",
                BackupCreateResponseStatus.Started => "STARTED",
                BackupCreateResponseStatus.Success => "SUCCESS",
                BackupCreateResponseStatus.Transferred => "TRANSFERRED",
                BackupCreateResponseStatus.Transferring => "TRANSFERRING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackupCreateResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => BackupCreateResponseStatus.Canceled,
                "CANCELLING" => BackupCreateResponseStatus.Cancelling,
                "FAILED" => BackupCreateResponseStatus.Failed,
                "FINALIZING" => BackupCreateResponseStatus.Finalizing,
                "STARTED" => BackupCreateResponseStatus.Started,
                "SUCCESS" => BackupCreateResponseStatus.Success,
                "TRANSFERRED" => BackupCreateResponseStatus.Transferred,
                "TRANSFERRING" => BackupCreateResponseStatus.Transferring,
                _ => null,
            };
        }
    }
}