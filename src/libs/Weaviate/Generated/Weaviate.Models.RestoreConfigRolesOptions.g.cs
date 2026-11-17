
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// How roles should be restored<br/>
    /// Default Value: noRestore
    /// </summary>
    public enum RestoreConfigRolesOptions
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        NoRestore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RestoreConfigRolesOptionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RestoreConfigRolesOptions value)
        {
            return value switch
            {
                RestoreConfigRolesOptions.All => "all",
                RestoreConfigRolesOptions.NoRestore => "noRestore",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RestoreConfigRolesOptions? ToEnum(string value)
        {
            return value switch
            {
                "all" => RestoreConfigRolesOptions.All,
                "noRestore" => RestoreConfigRolesOptions.NoRestore,
                _ => null,
            };
        }
    }
}