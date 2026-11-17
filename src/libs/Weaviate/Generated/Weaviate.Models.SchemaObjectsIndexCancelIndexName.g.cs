
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public enum SchemaObjectsIndexCancelIndexName
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
        Rangeable,
        /// <summary>
        ///
        /// </summary>
        Searchable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SchemaObjectsIndexCancelIndexNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemaObjectsIndexCancelIndexName value)
        {
            return value switch
            {
                SchemaObjectsIndexCancelIndexName.Filterable => "filterable",
                SchemaObjectsIndexCancelIndexName.RangeFilters => "rangeFilters",
                SchemaObjectsIndexCancelIndexName.Rangeable => "rangeable",
                SchemaObjectsIndexCancelIndexName.Searchable => "searchable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemaObjectsIndexCancelIndexName? ToEnum(string value)
        {
            return value switch
            {
                "filterable" => SchemaObjectsIndexCancelIndexName.Filterable,
                "rangeFilters" => SchemaObjectsIndexCancelIndexName.RangeFilters,
                "rangeable" => SchemaObjectsIndexCancelIndexName.Rangeable,
                "searchable" => SchemaObjectsIndexCancelIndexName.Searchable,
                _ => null,
            };
        }
    }
}