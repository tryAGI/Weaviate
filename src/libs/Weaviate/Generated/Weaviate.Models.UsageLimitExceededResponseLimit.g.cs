
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Which limit was hit.
    /// </summary>
    public enum UsageLimitExceededResponseLimit
    {
        /// <summary>
        ///
        /// </summary>
        Collections,
        /// <summary>
        ///
        /// </summary>
        Objects,
        /// <summary>
        ///
        /// </summary>
        Shards,
        /// <summary>
        ///
        /// </summary>
        Tenants,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageLimitExceededResponseLimitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageLimitExceededResponseLimit value)
        {
            return value switch
            {
                UsageLimitExceededResponseLimit.Collections => "collections",
                UsageLimitExceededResponseLimit.Objects => "objects",
                UsageLimitExceededResponseLimit.Shards => "shards",
                UsageLimitExceededResponseLimit.Tenants => "tenants",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageLimitExceededResponseLimit? ToEnum(string value)
        {
            return value switch
            {
                "collections" => UsageLimitExceededResponseLimit.Collections,
                "objects" => UsageLimitExceededResponseLimit.Objects,
                "shards" => UsageLimitExceededResponseLimit.Shards,
                "tenants" => UsageLimitExceededResponseLimit.Tenants,
                _ => null,
            };
        }
    }
}