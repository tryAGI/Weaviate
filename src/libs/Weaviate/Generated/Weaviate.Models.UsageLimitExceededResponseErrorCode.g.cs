
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Machine-stable identifier. Always `USAGE_LIMIT_EXCEEDED` for this response.
    /// </summary>
    public enum UsageLimitExceededResponseErrorCode
    {
        /// <summary>
        ///
        /// </summary>
        UsageLimitExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageLimitExceededResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageLimitExceededResponseErrorCode value)
        {
            return value switch
            {
                UsageLimitExceededResponseErrorCode.UsageLimitExceeded => "USAGE_LIMIT_EXCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageLimitExceededResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "USAGE_LIMIT_EXCEEDED" => UsageLimitExceededResponseErrorCode.UsageLimitExceeded,
                _ => null,
            };
        }
    }
}