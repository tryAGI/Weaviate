
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The type of the user. `db` users are managed by Weaviate, `oidc` users are managed by an external OIDC provider.
    /// </summary>
    public enum UserTypeInput
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
    public static class UserTypeInputExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserTypeInput value)
        {
            return value switch
            {
                UserTypeInput.Db => "db",
                UserTypeInput.Oidc => "oidc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserTypeInput? ToEnum(string value)
        {
            return value switch
            {
                "db" => UserTypeInput.Db,
                "oidc" => UserTypeInput.Oidc,
                _ => null,
            };
        }
    }
}