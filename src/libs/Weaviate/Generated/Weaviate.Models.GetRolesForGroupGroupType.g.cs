
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public enum GetRolesForGroupGroupType
    {
        /// <summary>
        ///
        /// </summary>
        Oidc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRolesForGroupGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRolesForGroupGroupType value)
        {
            return value switch
            {
                GetRolesForGroupGroupType.Oidc => "oidc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRolesForGroupGroupType? ToEnum(string value)
        {
            return value switch
            {
                "oidc" => GetRolesForGroupGroupType.Oidc,
                _ => null,
            };
        }
    }
}