
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// compression level used by compression algorithm<br/>
    /// Default Value: DefaultCompression
    /// </summary>
    public enum BackupConfigCompressionLevel
    {
        /// <summary>
        ///
        /// </summary>
        BestCompression,
        /// <summary>
        ///
        /// </summary>
        BestSpeed,
        /// <summary>
        ///
        /// </summary>
        DefaultCompression,
        /// <summary>
        ///
        /// </summary>
        NoCompression,
        /// <summary>
        ///
        /// </summary>
        ZstdBestCompression,
        /// <summary>
        ///
        /// </summary>
        ZstdBestSpeed,
        /// <summary>
        ///
        /// </summary>
        ZstdDefaultCompression,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackupConfigCompressionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupConfigCompressionLevel value)
        {
            return value switch
            {
                BackupConfigCompressionLevel.BestCompression => "BestCompression",
                BackupConfigCompressionLevel.BestSpeed => "BestSpeed",
                BackupConfigCompressionLevel.DefaultCompression => "DefaultCompression",
                BackupConfigCompressionLevel.NoCompression => "NoCompression",
                BackupConfigCompressionLevel.ZstdBestCompression => "ZstdBestCompression",
                BackupConfigCompressionLevel.ZstdBestSpeed => "ZstdBestSpeed",
                BackupConfigCompressionLevel.ZstdDefaultCompression => "ZstdDefaultCompression",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackupConfigCompressionLevel? ToEnum(string value)
        {
            return value switch
            {
                "BestCompression" => BackupConfigCompressionLevel.BestCompression,
                "BestSpeed" => BackupConfigCompressionLevel.BestSpeed,
                "DefaultCompression" => BackupConfigCompressionLevel.DefaultCompression,
                "NoCompression" => BackupConfigCompressionLevel.NoCompression,
                "ZstdBestCompression" => BackupConfigCompressionLevel.ZstdBestCompression,
                "ZstdBestSpeed" => BackupConfigCompressionLevel.ZstdBestSpeed,
                "ZstdDefaultCompression" => BackupConfigCompressionLevel.ZstdDefaultCompression,
                _ => null,
            };
        }
    }
}