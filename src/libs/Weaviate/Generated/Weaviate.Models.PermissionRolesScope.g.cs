
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// set the scope for the manage role permission<br/>
    /// Default Value: match
    /// </summary>
    public enum PermissionRolesScope
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Match,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PermissionRolesScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PermissionRolesScope value)
        {
            return value switch
            {
                PermissionRolesScope.All => "all",
                PermissionRolesScope.Match => "match",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PermissionRolesScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => PermissionRolesScope.All,
                "match" => PermissionRolesScope.Match,
                _ => null,
            };
        }
    }
}