
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public enum SchemaObjectsIndexUpsertIndexName
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
    public static class SchemaObjectsIndexUpsertIndexNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemaObjectsIndexUpsertIndexName value)
        {
            return value switch
            {
                SchemaObjectsIndexUpsertIndexName.Filterable => "filterable",
                SchemaObjectsIndexUpsertIndexName.RangeFilters => "rangeFilters",
                SchemaObjectsIndexUpsertIndexName.Rangeable => "rangeable",
                SchemaObjectsIndexUpsertIndexName.Searchable => "searchable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemaObjectsIndexUpsertIndexName? ToEnum(string value)
        {
            return value switch
            {
                "filterable" => SchemaObjectsIndexUpsertIndexName.Filterable,
                "rangeFilters" => SchemaObjectsIndexUpsertIndexName.RangeFilters,
                "rangeable" => SchemaObjectsIndexUpsertIndexName.Rangeable,
                "searchable" => SchemaObjectsIndexUpsertIndexName.Searchable,
                _ => null,
            };
        }
    }
}