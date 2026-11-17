
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Canonical inverted-index type. Always one of `filterable`, `searchable`, `rangeFilters` — never the `rangeable` write-path alias.
    /// </summary>
    public enum IndexStatusType
    {
        /// <summary>
        ///
        /// </summary>
        Filterable,
        /// <summary>
        ///
        /// </summary>
        RangeFilters,
        /// <summary>
        ///
        /// </summary>
        Searchable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IndexStatusTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexStatusType value)
        {
            return value switch
            {
                IndexStatusType.Filterable => "filterable",
                IndexStatusType.RangeFilters => "rangeFilters",
                IndexStatusType.Searchable => "searchable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexStatusType? ToEnum(string value)
        {
            return value switch
            {
                "filterable" => IndexStatusType.Filterable,
                "rangeFilters" => IndexStatusType.RangeFilters,
                "searchable" => IndexStatusType.Searchable,
                _ => null,
            };
        }
    }
}