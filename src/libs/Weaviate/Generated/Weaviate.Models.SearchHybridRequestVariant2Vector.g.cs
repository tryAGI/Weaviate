
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The query vector for the vector part of the search, used instead of vectorizing `query`. A non-empty array of numbers that fit a 32-bit float, e.g. `[0.12, -0.3, 0.98]`. It must have the dimensionality of the vector space it is searched against, that is of the collection's (target) vector. Requires `alpha` &gt; 0.
    /// </summary>
    public sealed partial class SearchHybridRequestVariant2Vector
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}