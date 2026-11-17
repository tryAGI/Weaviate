
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Output file format for the export.
    /// </summary>
    public enum ExportCreateRequestFileFormat
    {
        /// <summary>
        ///
        /// </summary>
        Parquet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportCreateRequestFileFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportCreateRequestFileFormat value)
        {
            return value switch
            {
                ExportCreateRequestFileFormat.Parquet => "parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportCreateRequestFileFormat? ToEnum(string value)
        {
            return value switch
            {
                "parquet" => ExportCreateRequestFileFormat.Parquet,
                _ => null,
            };
        }
    }
}