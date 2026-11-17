
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The tokenization method to apply.
    /// </summary>
    public enum TokenizeRequestTokenization
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
        GseCh,
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
    public static class TokenizeRequestTokenizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenizeRequestTokenization value)
        {
            return value switch
            {
                TokenizeRequestTokenization.Field => "field",
                TokenizeRequestTokenization.Gse => "gse",
                TokenizeRequestTokenization.GseCh => "gse_ch",
                TokenizeRequestTokenization.KagomeJa => "kagome_ja",
                TokenizeRequestTokenization.KagomeKr => "kagome_kr",
                TokenizeRequestTokenization.Lowercase => "lowercase",
                TokenizeRequestTokenization.Trigram => "trigram",
                TokenizeRequestTokenization.Whitespace => "whitespace",
                TokenizeRequestTokenization.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenizeRequestTokenization? ToEnum(string value)
        {
            return value switch
            {
                "field" => TokenizeRequestTokenization.Field,
                "gse" => TokenizeRequestTokenization.Gse,
                "gse_ch" => TokenizeRequestTokenization.GseCh,
                "kagome_ja" => TokenizeRequestTokenization.KagomeJa,
                "kagome_kr" => TokenizeRequestTokenization.KagomeKr,
                "lowercase" => TokenizeRequestTokenization.Lowercase,
                "trigram" => TokenizeRequestTokenization.Trigram,
                "whitespace" => TokenizeRequestTokenization.Whitespace,
                "word" => TokenizeRequestTokenization.Word,
                _ => null,
            };
        }
    }
}