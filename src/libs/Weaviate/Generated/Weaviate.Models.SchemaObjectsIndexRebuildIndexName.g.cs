
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public enum SchemaObjectsIndexRebuildIndexName
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
    public static class SchemaObjectsIndexRebuildIndexNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemaObjectsIndexRebuildIndexName value)
        {
            return value switch
            {
                SchemaObjectsIndexRebuildIndexName.Filterable => "filterable",
                SchemaObjectsIndexRebuildIndexName.RangeFilters => "rangeFilters",
                SchemaObjectsIndexRebuildIndexName.Rangeable => "rangeable",
                SchemaObjectsIndexRebuildIndexName.Searchable => "searchable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemaObjectsIndexRebuildIndexName? ToEnum(string value)
        {
            return value switch
            {
                "filterable" => SchemaObjectsIndexRebuildIndexName.Filterable,
                "rangeFilters" => SchemaObjectsIndexRebuildIndexName.RangeFilters,
                "rangeable" => SchemaObjectsIndexRebuildIndexName.Rangeable,
                "searchable" => SchemaObjectsIndexRebuildIndexName.Searchable,
                _ => null,
            };
        }
    }
}