
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Determines how a property is indexed. This setting applies to `text` and `text[]` data types. The following tokenization methods are available:&lt;br/&gt;&lt;br/&gt;- `word` (default): Splits the text on any non-alphanumeric characters and lowercases the tokens.&lt;br/&gt;- `lowercase`: Splits the text on whitespace and lowercases the tokens.&lt;br/&gt;- `whitespace`: Splits the text on whitespace. This tokenization is case-sensitive.&lt;br/&gt;- `field`: Indexes the entire property value as a single token after trimming whitespace.&lt;br/&gt;- `trigram`: Splits the property into rolling trigrams (three-character sequences).&lt;br/&gt;- `gse`: Uses the `gse` tokenizer, suitable for Chinese language text. [See `gse` docs](https://pkg.go.dev/github.com/go-ego/gse#section-readme).&lt;br/&gt;- `kagome_ja`: Uses the `Kagome` tokenizer with a Japanese (IPA) dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;- `kagome_kr`: Uses the `Kagome` tokenizer with a Korean dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;&lt;br/&gt;See [Reference: Tokenization](https://docs.weaviate.io/weaviate/config-refs/collections#tokenization) for details.
    /// </summary>
    public enum PropertyTokenization
    {
        /// <summary>
        /// &lt;br/&gt;&lt;br/&gt;- `word` (default): Splits the text on any non-alphanumeric characters and lowercases the tokens.&lt;br/&gt;- `lowercase`: Splits the text on whitespace and lowercases the tokens.&lt;br/&gt;- `whitespace`: Splits the text on whitespace. This tokenization is case-sensitive.&lt;br/&gt;- `field`: Indexes the entire property value as a single token after trimming whitespace.&lt;br/&gt;- `trigram`: Splits the property into rolling trigrams (three-character sequences).&lt;br/&gt;- `gse`: Uses the `gse` tokenizer, suitable for Chinese language text. [See `gse` docs](https://pkg.go.dev/github.com/go-ego/gse#section-readme).&lt;br/&gt;- `kagome_ja`: Uses the `Kagome` tokenizer with a Japanese (IPA) dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;- `kagome_kr`: Uses the `Kagome` tokenizer with a Korean dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;&lt;br/&gt;See [Reference: Tokenization](https://docs.weaviate.io/weaviate/config-refs/collections#tokenization) for details.
        /// </summary>
        Field,
        /// <summary>
        /// &lt;br/&gt;&lt;br/&gt;- `word` (default): Splits the text on any non-alphanumeric characters and lowercases the tokens.&lt;br/&gt;- `lowercase`: Splits the text on whitespace and lowercases the tokens.&lt;br/&gt;- `whitespace`: Splits the text on whitespace. This tokenization is case-sensitive.&lt;br/&gt;- `field`: Indexes the entire property value as a single token after trimming whitespace.&lt;br/&gt;- `trigram`: Splits the property into rolling trigrams (three-character sequences).&lt;br/&gt;- `gse`: Uses the `gse` tokenizer, suitable for Chinese language text. [See `gse` docs](https://pkg.go.dev/github.com/go-ego/gse#section-readme).&lt;br/&gt;- `kagome_ja`: Uses the `Kagome` tokenizer with a Japanese (IPA) dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;- `kagome_kr`: Uses the `Kagome` tokenizer with a Korean dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;&lt;br/&gt;See [Reference: Tokenization](https://docs.weaviate.io/weaviate/config-refs/collections#tokenization) for details.
        /// </summary>
        Gse,
        /// <summary>
        ///
        /// </summary>
        GseCh,
        /// <summary>
        /// &lt;br/&gt;&lt;br/&gt;- `word` (default): Splits the text on any non-alphanumeric characters and lowercases the tokens.&lt;br/&gt;- `lowercase`: Splits the text on whitespace and lowercases the tokens.&lt;br/&gt;- `whitespace`: Splits the text on whitespace. This tokenization is case-sensitive.&lt;br/&gt;- `field`: Indexes the entire property value as a single token after trimming whitespace.&lt;br/&gt;- `trigram`: Splits the property into rolling trigrams (three-character sequences).&lt;br/&gt;- `gse`: Uses the `gse` tokenizer, suitable for Chinese language text. [See `gse` docs](https://pkg.go.dev/github.com/go-ego/gse#section-readme).&lt;br/&gt;- `kagome_ja`: Uses the `Kagome` tokenizer with a Japanese (IPA) dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;- `kagome_kr`: Uses the `Kagome` tokenizer with a Korean dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;&lt;br/&gt;See [Reference: Tokenization](https://docs.weaviate.io/weaviate/config-refs/collections#tokenization) for details.
        /// </summary>
        KagomeJa,
        /// <summary>
        /// &lt;br/&gt;&lt;br/&gt;- `word` (default): Splits the text on any non-alphanumeric characters and lowercases the tokens.&lt;br/&gt;- `lowercase`: Splits the text on whitespace and lowercases the tokens.&lt;br/&gt;- `whitespace`: Splits the text on whitespace. This tokenization is case-sensitive.&lt;br/&gt;- `field`: Indexes the entire property value as a single token after trimming whitespace.&lt;br/&gt;- `trigram`: Splits the property into rolling trigrams (three-character sequences).&lt;br/&gt;- `gse`: Uses the `gse` tokenizer, suitable for Chinese language text. [See `gse` docs](https://pkg.go.dev/github.com/go-ego/gse#section-readme).&lt;br/&gt;- `kagome_ja`: Uses the `Kagome` tokenizer with a Japanese (IPA) dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;- `kagome_kr`: Uses the `Kagome` tokenizer with a Korean dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;&lt;br/&gt;See [Reference: Tokenization](https://docs.weaviate.io/weaviate/config-refs/collections#tokenization) for details.
        /// </summary>
        KagomeKr,
        /// <summary>
        /// &lt;br/&gt;&lt;br/&gt;- `word` (default): Splits the text on any non-alphanumeric characters and lowercases the tokens.&lt;br/&gt;- `lowercase`: Splits the text on whitespace and lowercases the tokens.&lt;br/&gt;- `whitespace`: Splits the text on whitespace. This tokenization is case-sensitive.&lt;br/&gt;- `field`: Indexes the entire property value as a single token after trimming whitespace.&lt;br/&gt;- `trigram`: Splits the property into rolling trigrams (three-character sequences).&lt;br/&gt;- `gse`: Uses the `gse` tokenizer, suitable for Chinese language text. [See `gse` docs](https://pkg.go.dev/github.com/go-ego/gse#section-readme).&lt;br/&gt;- `kagome_ja`: Uses the `Kagome` tokenizer with a Japanese (IPA) dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;- `kagome_kr`: Uses the `Kagome` tokenizer with a Korean dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;&lt;br/&gt;See [Reference: Tokenization](https://docs.weaviate.io/weaviate/config-refs/collections#tokenization) for details.
        /// </summary>
        Lowercase,
        /// <summary>
        /// &lt;br/&gt;&lt;br/&gt;- `word` (default): Splits the text on any non-alphanumeric characters and lowercases the tokens.&lt;br/&gt;- `lowercase`: Splits the text on whitespace and lowercases the tokens.&lt;br/&gt;- `whitespace`: Splits the text on whitespace. This tokenization is case-sensitive.&lt;br/&gt;- `field`: Indexes the entire property value as a single token after trimming whitespace.&lt;br/&gt;- `trigram`: Splits the property into rolling trigrams (three-character sequences).&lt;br/&gt;- `gse`: Uses the `gse` tokenizer, suitable for Chinese language text. [See `gse` docs](https://pkg.go.dev/github.com/go-ego/gse#section-readme).&lt;br/&gt;- `kagome_ja`: Uses the `Kagome` tokenizer with a Japanese (IPA) dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;- `kagome_kr`: Uses the `Kagome` tokenizer with a Korean dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;&lt;br/&gt;See [Reference: Tokenization](https://docs.weaviate.io/weaviate/config-refs/collections#tokenization) for details.
        /// </summary>
        Trigram,
        /// <summary>
        /// &lt;br/&gt;&lt;br/&gt;- `word` (default): Splits the text on any non-alphanumeric characters and lowercases the tokens.&lt;br/&gt;- `lowercase`: Splits the text on whitespace and lowercases the tokens.&lt;br/&gt;- `whitespace`: Splits the text on whitespace. This tokenization is case-sensitive.&lt;br/&gt;- `field`: Indexes the entire property value as a single token after trimming whitespace.&lt;br/&gt;- `trigram`: Splits the property into rolling trigrams (three-character sequences).&lt;br/&gt;- `gse`: Uses the `gse` tokenizer, suitable for Chinese language text. [See `gse` docs](https://pkg.go.dev/github.com/go-ego/gse#section-readme).&lt;br/&gt;- `kagome_ja`: Uses the `Kagome` tokenizer with a Japanese (IPA) dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;- `kagome_kr`: Uses the `Kagome` tokenizer with a Korean dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;&lt;br/&gt;See [Reference: Tokenization](https://docs.weaviate.io/weaviate/config-refs/collections#tokenization) for details.
        /// </summary>
        Whitespace,
        /// <summary>
        /// &lt;br/&gt;&lt;br/&gt;- `word` (default): Splits the text on any non-alphanumeric characters and lowercases the tokens.&lt;br/&gt;- `lowercase`: Splits the text on whitespace and lowercases the tokens.&lt;br/&gt;- `whitespace`: Splits the text on whitespace. This tokenization is case-sensitive.&lt;br/&gt;- `field`: Indexes the entire property value as a single token after trimming whitespace.&lt;br/&gt;- `trigram`: Splits the property into rolling trigrams (three-character sequences).&lt;br/&gt;- `gse`: Uses the `gse` tokenizer, suitable for Chinese language text. [See `gse` docs](https://pkg.go.dev/github.com/go-ego/gse#section-readme).&lt;br/&gt;- `kagome_ja`: Uses the `Kagome` tokenizer with a Japanese (IPA) dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;- `kagome_kr`: Uses the `Kagome` tokenizer with a Korean dictionary. [See `kagome` docs](https://github.com/ikawaha/kagome).&lt;br/&gt;&lt;br/&gt;See [Reference: Tokenization](https://docs.weaviate.io/weaviate/config-refs/collections#tokenization) for details.
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
                PropertyTokenization.GseCh => "gse_ch",
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
                "gse_ch" => PropertyTokenization.GseCh,
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