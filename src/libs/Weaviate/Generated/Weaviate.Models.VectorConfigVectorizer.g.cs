
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Configuration of a specific vectorizer used by this vector
    /// </summary>
    public sealed partial class VectorConfigVectorizer
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}