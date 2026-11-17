
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Machine-stable identifier. Set to `CONFIG_NOT_ALLOWED` for restriction violations; omitted otherwise.
    /// </summary>
    public enum RestrictionViolationResponseErrorCode
    {
        /// <summary>
        ///
        /// </summary>
        ConfigNotAllowed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RestrictionViolationResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RestrictionViolationResponseErrorCode value)
        {
            return value switch
            {
                RestrictionViolationResponseErrorCode.ConfigNotAllowed => "CONFIG_NOT_ALLOWED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RestrictionViolationResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "CONFIG_NOT_ALLOWED" => RestrictionViolationResponseErrorCode.ConfigNotAllowed,
                _ => null,
            };
        }
    }
}