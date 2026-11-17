
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// If the group contains OIDC or database users.
    /// </summary>
    public enum GroupType
    {
        /// <summary>
        ///
        /// </summary>
        Oidc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupType value)
        {
            return value switch
            {
                GroupType.Oidc => "oidc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupType? ToEnum(string value)
        {
            return value switch
            {
                "oidc" => GroupType.Oidc,
                _ => null,
            };
        }
    }
}