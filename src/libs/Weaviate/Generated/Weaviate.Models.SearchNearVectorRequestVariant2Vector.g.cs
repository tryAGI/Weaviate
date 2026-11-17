
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The query vector, as a non-empty array of numbers that fit a 32-bit float, e.g. `[0.12, -0.3, 0.98]`. It must have the dimensionality of the vector space it is searched against, that is of the collection's (target) vector.
    /// </summary>
    public sealed partial class SearchNearVectorRequestVariant2Vector
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}