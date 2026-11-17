
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum BackupsListOrder
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackupsListOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupsListOrder value)
        {
            return value switch
            {
                BackupsListOrder.Asc => "asc",
                BackupsListOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackupsListOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BackupsListOrder.Asc,
                "desc" => BackupsListOrder.Desc,
                _ => null,
            };
        }
    }
}