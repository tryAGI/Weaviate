
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The outcome for this user.
    /// </summary>
    public enum UserImportResultStatus
    {
        /// <summary>
        ///
        /// </summary>
        Created,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Reconciled,
        /// <summary>
        ///
        /// </summary>
        SkippedExists,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserImportResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserImportResultStatus value)
        {
            return value switch
            {
                UserImportResultStatus.Created => "created",
                UserImportResultStatus.Error => "error",
                UserImportResultStatus.Reconciled => "reconciled",
                UserImportResultStatus.SkippedExists => "skipped_exists",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserImportResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => UserImportResultStatus.Created,
                "error" => UserImportResultStatus.Error,
                "reconciled" => UserImportResultStatus.Reconciled,
                "skipped_exists" => UserImportResultStatus.SkippedExists,
                _ => null,
            };
        }
    }
}