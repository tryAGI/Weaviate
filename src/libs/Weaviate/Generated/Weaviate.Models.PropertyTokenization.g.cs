
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
    public static class PropertyTokenizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertyTokenization value)
        {
            return value switch
            {
                PropertyTokenization.Field => "field",
                PropertyTokenization.Gse => "gse",
                PropertyTokenization.KagomeJa => "kagome_ja",
                PropertyTokenization.KagomeKr => "kagome_kr",
                PropertyTokenization.Lowercase => "lowercase",
                PropertyTokenization.Trigram => "trigram",
                PropertyTokenization.Whitespace => "whitespace",
                PropertyTokenization.Word => "word",
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
                "field" => PropertyTokenization.Field,
                "gse" => PropertyTokenization.Gse,
                "kagome_ja" => PropertyTokenization.KagomeJa,
                "kagome_kr" => PropertyTokenization.KagomeKr,
                "lowercase" => PropertyTokenization.Lowercase,
                "trigram" => PropertyTokenization.Trigram,
                "whitespace" => PropertyTokenization.Whitespace,
                "word" => PropertyTokenization.Word,
                _ => null,
            };
        }
    }
}