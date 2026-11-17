
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// BM25 algorithm currently backing this searchable index. 'wand' is the legacy map-based bucket strategy; 'blockmax' is the Block Max WAND inverted strategy. Only populated for `type=searchable` entries. Not populated for filterable or rangeable indexes.
    /// </summary>
    public enum IndexStatusAlgorithm
    {
        /// <summary>
        ///
        /// </summary>
        Blockmax,
        /// <summary>
        ///
        /// </summary>
        Wand,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IndexStatusAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexStatusAlgorithm value)
        {
            return value switch
            {
                IndexStatusAlgorithm.Blockmax => "blockmax",
                IndexStatusAlgorithm.Wand => "wand",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexStatusAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "blockmax" => IndexStatusAlgorithm.Blockmax,
                "wand" => IndexStatusAlgorithm.Wand,
                _ => null,
            };
        }
    }
}