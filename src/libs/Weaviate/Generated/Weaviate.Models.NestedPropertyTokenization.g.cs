
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
        Field,
        /// <summary>
        /// 
        /// </summary>
        Gse,
        /// <summary>
        /// 
        /// </summary>
        KagomeJa,
        /// <summary>
        /// 
        /// </summary>
        KagomeKr,
        /// <summary>
        /// 
        /// </summary>
        Lowercase,
        /// <summary>
        /// 
        /// </summary>
        Trigram,
        /// <summary>
        /// 
        /// </summary>
        Whitespace,
        /// <summary>
        /// 
        /// </summary>
        Word,
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
                NestedPropertyTokenization.Field => "field",
                NestedPropertyTokenization.Gse => "gse",
                NestedPropertyTokenization.KagomeJa => "kagome_ja",
                NestedPropertyTokenization.KagomeKr => "kagome_kr",
                NestedPropertyTokenization.Lowercase => "lowercase",
                NestedPropertyTokenization.Trigram => "trigram",
                NestedPropertyTokenization.Whitespace => "whitespace",
                NestedPropertyTokenization.Word => "word",
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
                "field" => NestedPropertyTokenization.Field,
                "gse" => NestedPropertyTokenization.Gse,
                "kagome_ja" => NestedPropertyTokenization.KagomeJa,
                "kagome_kr" => NestedPropertyTokenization.KagomeKr,
                "lowercase" => NestedPropertyTokenization.Lowercase,
                "trigram" => NestedPropertyTokenization.Trigram,
                "whitespace" => NestedPropertyTokenization.Whitespace,
                "word" => NestedPropertyTokenization.Word,
                _ => null,
            };
        }
    }
}