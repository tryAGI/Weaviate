
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Determines tokenization of the property as separate words or whole field. Optional. Applies to text and text[] data types. Allowed values are `word` (default; splits on any non-alphanumerical, lowercases), `lowercase` (splits on white spaces, lowercases), `whitespace` (splits on white spaces), `field` (trims). Not supported for remaining data types
    /// </summary>
    public enum PropertyTokenization
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
    public static class PropertyTokenizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertyTokenization value)
        {
            return value switch
            {
                PropertyTokenization.Word => "word",
                PropertyTokenization.Lowercase => "lowercase",
                PropertyTokenization.Whitespace => "whitespace",
                PropertyTokenization.Field => "field",
                PropertyTokenization.Trigram => "trigram",
                PropertyTokenization.Gse => "gse",
                PropertyTokenization.KagomeKr => "kagome_kr",
                PropertyTokenization.KagomeJa => "kagome_ja",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertyTokenization? ToEnum(string value)
        {
            return value switch
            {
                "word" => PropertyTokenization.Word,
                "lowercase" => PropertyTokenization.Lowercase,
                "whitespace" => PropertyTokenization.Whitespace,
                "field" => PropertyTokenization.Field,
                "trigram" => PropertyTokenization.Trigram,
                "gse" => PropertyTokenization.Gse,
                "kagome_kr" => PropertyTokenization.KagomeKr,
                "kagome_ja" => PropertyTokenization.KagomeJa,
                _ => null,
            };
        }
    }
}