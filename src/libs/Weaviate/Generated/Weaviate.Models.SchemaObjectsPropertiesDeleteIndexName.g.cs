
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public enum SchemaObjectsPropertiesDeleteIndexName
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
    public static class SchemaObjectsPropertiesDeleteIndexNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemaObjectsPropertiesDeleteIndexName value)
        {
            return value switch
            {
                SchemaObjectsPropertiesDeleteIndexName.Filterable => "filterable",
                SchemaObjectsPropertiesDeleteIndexName.RangeFilters => "rangeFilters",
                SchemaObjectsPropertiesDeleteIndexName.Rangeable => "rangeable",
                SchemaObjectsPropertiesDeleteIndexName.Searchable => "searchable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemaObjectsPropertiesDeleteIndexName? ToEnum(string value)
        {
            return value switch
            {
                "filterable" => SchemaObjectsPropertiesDeleteIndexName.Filterable,
                "rangeFilters" => SchemaObjectsPropertiesDeleteIndexName.RangeFilters,
                "rangeable" => SchemaObjectsPropertiesDeleteIndexName.Rangeable,
                "searchable" => SchemaObjectsPropertiesDeleteIndexName.Searchable,
                _ => null,
            };
        }
    }
}