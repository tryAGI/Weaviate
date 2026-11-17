
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Type of the returned user.
    /// </summary>
    public enum DBUserInfoDbUserType
    {
        /// <summary>
        ///
        /// </summary>
        DbEnvUser,
        /// <summary>
        ///
        /// </summary>
        DbUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DBUserInfoDbUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DBUserInfoDbUserType value)
        {
            return value switch
            {
                DBUserInfoDbUserType.DbEnvUser => "db_env_user",
                DBUserInfoDbUserType.DbUser => "db_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DBUserInfoDbUserType? ToEnum(string value)
        {
            return value switch
            {
                "db_env_user" => DBUserInfoDbUserType.DbEnvUser,
                "db_user" => DBUserInfoDbUserType.DbUser,
                _ => null,
            };
        }
    }
}