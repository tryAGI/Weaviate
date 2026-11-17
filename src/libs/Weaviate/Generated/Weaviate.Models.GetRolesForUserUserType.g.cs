
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public enum GetRolesForUserUserType
    {
        /// <summary>
        ///
        /// </summary>
        Db,
        /// <summary>
        ///
        /// </summary>
        Oidc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRolesForUserUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRolesForUserUserType value)
        {
            return value switch
            {
                GetRolesForUserUserType.Db => "db",
                GetRolesForUserUserType.Oidc => "oidc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRolesForUserUserType? ToEnum(string value)
        {
            return value switch
            {
                "db" => GetRolesForUserUserType.Db,
                "oidc" => GetRolesForUserUserType.Oidc,
                _ => null,
            };
        }
    }
}