
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchCommonReturnMetadataItem
    {
        /// <summary>
        ///
        /// </summary>
        Certainty,
        /// <summary>
        ///
        /// </summary>
        CreationTime,
        /// <summary>
        ///
        /// </summary>
        Distance,
        /// <summary>
        ///
        /// </summary>
        ExplainScore,
        /// <summary>
        ///
        /// </summary>
        LastUpdateTime,
        /// <summary>
        ///
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchCommonReturnMetadataItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchCommonReturnMetadataItem value)
        {
            return value switch
            {
                SearchCommonReturnMetadataItem.Certainty => "certainty",
                SearchCommonReturnMetadataItem.CreationTime => "creationTime",
                SearchCommonReturnMetadataItem.Distance => "distance",
                SearchCommonReturnMetadataItem.ExplainScore => "explainScore",
                SearchCommonReturnMetadataItem.LastUpdateTime => "lastUpdateTime",
                SearchCommonReturnMetadataItem.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchCommonReturnMetadataItem? ToEnum(string value)
        {
            return value switch
            {
                "certainty" => SearchCommonReturnMetadataItem.Certainty,
                "creationTime" => SearchCommonReturnMetadataItem.CreationTime,
                "distance" => SearchCommonReturnMetadataItem.Distance,
                "explainScore" => SearchCommonReturnMetadataItem.ExplainScore,
                "lastUpdateTime" => SearchCommonReturnMetadataItem.LastUpdateTime,
                "score" => SearchCommonReturnMetadataItem.Score,
                _ => null,
            };
        }
    }
}