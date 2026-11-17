
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public enum GetGroupsGroupType
    {
        /// <summary>
        ///
        /// </summary>
        Oidc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetGroupsGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetGroupsGroupType value)
        {
            return value switch
            {
                GetGroupsGroupType.Oidc => "oidc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetGroupsGroupType? ToEnum(string value)
        {
            return value switch
            {
                "oidc" => GetGroupsGroupType.Oidc,
                _ => null,
            };
        }
    }
}