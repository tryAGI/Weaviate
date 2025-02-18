
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// A vector representation of the object. If provided at object creation, this wil take precedence over any vectorizer setting.
    /// </summary>
    public sealed partial class Vector
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}