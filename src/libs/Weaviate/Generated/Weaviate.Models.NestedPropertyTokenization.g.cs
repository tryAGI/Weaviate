
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public enum NestedPropertyTokenization
    {
        /// <summary>
        /// 
        /// </summary>
        Word,
        /// <summary>
        /// 
        /// </summary>
        Lowercase,
        /// <summary>
        /// 
        /// </summary>
        Whitespace,
        /// <summary>
        /// 
        /// </summary>
        Field,
        /// <summary>
        /// 
        /// </summary>
        Trigram,
        /// <summary>
        /// 
        /// </summary>
        Gse,
        /// <summary>
        /// 
        /// </summary>
        KagomeKr,
        /// <summary>
        /// 
        /// </summary>
        KagomeJa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NestedPropertyTokenizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NestedPropertyTokenization value)
        {
            return value switch
            {
                NestedPropertyTokenization.Word => "word",
                NestedPropertyTokenization.Lowercase => "lowercase",
                NestedPropertyTokenization.Whitespace => "whitespace",
                NestedPropertyTokenization.Field => "field",
                NestedPropertyTokenization.Trigram => "trigram",
                NestedPropertyTokenization.Gse => "gse",
                NestedPropertyTokenization.KagomeKr => "kagome_kr",
                NestedPropertyTokenization.KagomeJa => "kagome_ja",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NestedPropertyTokenization? ToEnum(string value)
        {
            return value switch
            {
                "word" => NestedPropertyTokenization.Word,
                "lowercase" => NestedPropertyTokenization.Lowercase,
                "whitespace" => NestedPropertyTokenization.Whitespace,
                "field" => NestedPropertyTokenization.Field,
                "trigram" => NestedPropertyTokenization.Trigram,
                "gse" => NestedPropertyTokenization.Gse,
                "kagome_kr" => NestedPropertyTokenization.KagomeKr,
                "kagome_ja" => NestedPropertyTokenization.KagomeJa,
                _ => null,
            };
        }
    }
}