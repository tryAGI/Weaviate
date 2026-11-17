
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The consistency level for the read.
    /// </summary>
    public enum SearchCommonConsistencyLevel
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        One,
        /// <summary>
        ///
        /// </summary>
        Quorum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchCommonConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchCommonConsistencyLevel value)
        {
            return value switch
            {
                SearchCommonConsistencyLevel.All => "ALL",
                SearchCommonConsistencyLevel.One => "ONE",
                SearchCommonConsistencyLevel.Quorum => "QUORUM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchCommonConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => SearchCommonConsistencyLevel.All,
                "ONE" => SearchCommonConsistencyLevel.One,
                "QUORUM" => SearchCommonConsistencyLevel.Quorum,
                _ => null,
            };
        }
    }
}