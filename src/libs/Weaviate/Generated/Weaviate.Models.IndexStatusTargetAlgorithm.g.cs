
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// BM25 algorithm this searchable index is being rebuilt onto. Populated only while an in-flight rebuild is changing the algorithm; mirrors `targetTokenization` for the change-tokenization verb. Today the only supported transition is wand -&gt; blockmax.
    /// </summary>
    public enum IndexStatusTargetAlgorithm
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
    public static class IndexStatusTargetAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexStatusTargetAlgorithm value)
        {
            return value switch
            {
                IndexStatusTargetAlgorithm.Blockmax => "blockmax",
                IndexStatusTargetAlgorithm.Wand => "wand",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexStatusTargetAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "blockmax" => IndexStatusTargetAlgorithm.Blockmax,
                "wand" => IndexStatusTargetAlgorithm.Wand,
                _ => null,
            };
        }
    }
}