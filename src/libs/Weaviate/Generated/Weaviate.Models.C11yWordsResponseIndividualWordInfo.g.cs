
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class C11yWordsResponseIndividualWordInfo
    {
        /// <summary>
        /// A vector representation of the object. If provided at object creation, this wil take precedence over any vectorizer setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        public global::System.Collections.Generic.IList<float>? Vector { get; set; }

        /// <summary>
        /// C11y function to show the nearest neighbors to a word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nearestNeighbors")]
        public global::System.Collections.Generic.IList<global::Weaviate.C11yNearestNeighbor>? NearestNeighbors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}