
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The algorithm that fuses the keyword and vector rankings: `ranked` (reciprocal-rank fusion) or `relativeScore` (normalized-score fusion). Omitted defaults to `relativeScore`.
    /// </summary>
    public enum SearchHybridRequestVariant2FusionType
    {
        /// <summary>
        /// `ranked` (reciprocal-rank fusion) or `relativeScore` (normalized-score fusion). Omitted defaults to `relativeScore`.
        /// </summary>
        Ranked,
        /// <summary>
        /// `ranked` (reciprocal-rank fusion) or `relativeScore` (normalized-score fusion). Omitted defaults to `relativeScore`.
        /// </summary>
        RelativeScore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchHybridRequestVariant2FusionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchHybridRequestVariant2FusionType value)
        {
            return value switch
            {
                SearchHybridRequestVariant2FusionType.Ranked => "ranked",
                SearchHybridRequestVariant2FusionType.RelativeScore => "relativeScore",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchHybridRequestVariant2FusionType? ToEnum(string value)
        {
            return value switch
            {
                "ranked" => SearchHybridRequestVariant2FusionType.Ranked,
                "relativeScore" => SearchHybridRequestVariant2FusionType.RelativeScore,
                _ => null,
            };
        }
    }
}