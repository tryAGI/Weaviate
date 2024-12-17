
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// phase of backup restoration process<br/>
    /// Default Value: STARTED
    /// </summary>
    public enum BackupRestoreResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        STARTED,
        /// <summary>
        /// 
        /// </summary>
        TRANSFERRING,
        /// <summary>
        /// 
        /// </summary>
        TRANSFERRED,
        /// <summary>
        /// 
        /// </summary>
        SUCCESS,
        /// <summary>
        /// 
        /// </summary>
        FAILED,
        /// <summary>
        /// 
        /// </summary>
        CANCELED,
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
                BackupRestoreResponseStatus.STARTED => "STARTED",
                BackupRestoreResponseStatus.TRANSFERRING => "TRANSFERRING",
                BackupRestoreResponseStatus.TRANSFERRED => "TRANSFERRED",
                BackupRestoreResponseStatus.SUCCESS => "SUCCESS",
                BackupRestoreResponseStatus.FAILED => "FAILED",
                BackupRestoreResponseStatus.CANCELED => "CANCELED",
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
                "STARTED" => BackupRestoreResponseStatus.STARTED,
                "TRANSFERRING" => BackupRestoreResponseStatus.TRANSFERRING,
                "TRANSFERRED" => BackupRestoreResponseStatus.TRANSFERRED,
                "SUCCESS" => BackupRestoreResponseStatus.SUCCESS,
                "FAILED" => BackupRestoreResponseStatus.FAILED,
                "CANCELED" => BackupRestoreResponseStatus.CANCELED,
                _ => null,
            };
        }
    }
}