
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchReferenceSelectorReturnMetadataItem
    {
        /// <summary>
        ///
        /// </summary>
        CreationTime,
        /// <summary>
        ///
        /// </summary>
        Id,
        /// <summary>
        ///
        /// </summary>
        LastUpdateTime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchReferenceSelectorReturnMetadataItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchReferenceSelectorReturnMetadataItem value)
        {
            return value switch
            {
                SearchReferenceSelectorReturnMetadataItem.CreationTime => "creationTime",
                SearchReferenceSelectorReturnMetadataItem.Id => "id",
                SearchReferenceSelectorReturnMetadataItem.LastUpdateTime => "lastUpdateTime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchReferenceSelectorReturnMetadataItem? ToEnum(string value)
        {
            return value switch
            {
                "creationTime" => SearchReferenceSelectorReturnMetadataItem.CreationTime,
                "id" => SearchReferenceSelectorReturnMetadataItem.Id,
                "lastUpdateTime" => SearchReferenceSelectorReturnMetadataItem.LastUpdateTime,
                _ => null,
            };
        }
    }
}