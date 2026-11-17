
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// How users should be restored<br/>
    /// Default Value: noRestore
    /// </summary>
    public enum RestoreConfigUsersOptions
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
    public static class RestoreConfigUsersOptionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RestoreConfigUsersOptions value)
        {
            return value switch
            {
                RestoreConfigUsersOptions.All => "all",
                RestoreConfigUsersOptions.NoRestore => "noRestore",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RestoreConfigUsersOptions? ToEnum(string value)
        {
            return value switch
            {
                "all" => RestoreConfigUsersOptions.All,
                "noRestore" => RestoreConfigUsersOptions.NoRestore,
                _ => null,
            };
        }
    }
}