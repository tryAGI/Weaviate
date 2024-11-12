
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class C11yVectorBasedQuestionItem
    {
        /// <summary>
        /// Vectorized classname.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classVectors")]
        public global::System.Collections.Generic.IList<float>? ClassVectors { get; set; }

        /// <summary>
        /// Vectorized properties.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classProps")]
        public global::System.Collections.Generic.IList<global::Weaviate.C11yVectorBasedQuestionItemClassProp>? ClassProps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yVectorBasedQuestionItem" /> class.
        /// </summary>
        /// <param name="classVectors">
        /// Vectorized classname.
        /// </param>
        /// <param name="classProps">
        /// Vectorized properties.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public C11yVectorBasedQuestionItem(
            global::System.Collections.Generic.IList<float>? classVectors,
            global::System.Collections.Generic.IList<global::Weaviate.C11yVectorBasedQuestionItemClassProp>? classProps)
        {
            this.ClassVectors = classVectors;
            this.ClassProps = classProps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yVectorBasedQuestionItem" /> class.
        /// </summary>
        public C11yVectorBasedQuestionItem()
        {
        }
    }
}