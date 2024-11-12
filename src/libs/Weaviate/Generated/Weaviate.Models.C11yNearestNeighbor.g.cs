
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class C11yNearestNeighbor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        public string? Word { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yNearestNeighbor" /> class.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="distance"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public C11yNearestNeighbor(
            string? word,
            float? distance)
        {
            this.Word = word;
            this.Distance = distance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="C11yNearestNeighbor" /> class.
        /// </summary>
        public C11yNearestNeighbor()
        {
        }
    }
}