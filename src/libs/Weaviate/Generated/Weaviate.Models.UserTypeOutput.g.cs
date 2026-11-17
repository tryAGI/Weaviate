
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The type of the user. `db_user` users are created through the `users` API, `db_env_user` users are created through environment variables, and `oidc` users are managed by an external OIDC provider.
    /// </summary>
    public enum UserTypeOutput
    {
        /// <summary>
        ///
        /// </summary>
        DbEnvUser,
        /// <summary>
        ///
        /// </summary>
        DbUser,
        /// <summary>
        ///
        /// </summary>
        Oidc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserTypeOutputExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserTypeOutput value)
        {
            return value switch
            {
                UserTypeOutput.DbEnvUser => "db_env_user",
                UserTypeOutput.DbUser => "db_user",
                UserTypeOutput.Oidc => "oidc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserTypeOutput? ToEnum(string value)
        {
            return value switch
            {
                "db_env_user" => UserTypeOutput.DbEnvUser,
                "db_user" => UserTypeOutput.DbUser,
                "oidc" => UserTypeOutput.Oidc,
                _ => null,
            };
        }
    }
}