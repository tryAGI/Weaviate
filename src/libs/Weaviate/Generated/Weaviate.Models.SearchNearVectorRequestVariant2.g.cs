
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchNearVectorRequestVariant2
    {
        /// <summary>
        /// The query vector, as a non-empty array of numbers that fit a 32-bit float, e.g. `[0.12, -0.3, 0.98]`. It must have the dimensionality of the vector space it is searched against, that is of the collection's (target) vector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Vector { get; set; }

        /// <summary>
        /// Minimum normalized certainty of a match. Only for cosine-distance vector indexes. Mutually exclusive with `distance`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certainty")]
        public double? Certainty { get; set; }

        /// <summary>
        /// Maximum vector distance of a match. Mutually exclusive with `certainty`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public double? Distance { get; set; }

        /// <summary>
        /// The named vector to search (the query vector is compared against the vectors stored under this name, and must match their dimensionality). Required when the collection has more than one named vector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetVector")]
        public string? TargetVector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchNearVectorRequestVariant2" /> class.
        /// </summary>
        /// <param name="vector">
        /// The query vector, as a non-empty array of numbers that fit a 32-bit float, e.g. `[0.12, -0.3, 0.98]`. It must have the dimensionality of the vector space it is searched against, that is of the collection's (target) vector.
        /// </param>
        /// <param name="certainty">
        /// Minimum normalized certainty of a match. Only for cosine-distance vector indexes. Mutually exclusive with `distance`.
        /// </param>
        /// <param name="distance">
        /// Maximum vector distance of a match. Mutually exclusive with `certainty`.
        /// </param>
        /// <param name="targetVector">
        /// The named vector to search (the query vector is compared against the vectors stored under this name, and must match their dimensionality). Required when the collection has more than one named vector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchNearVectorRequestVariant2(
            object vector,
            double? certainty,
            double? distance,
            string? targetVector)
        {
            this.Vector = vector ?? throw new global::System.ArgumentNullException(nameof(vector));
            this.Certainty = certainty;
            this.Distance = distance;
            this.TargetVector = targetVector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchNearVectorRequestVariant2" /> class.
        /// </summary>
        public SearchNearVectorRequestVariant2()
        {
        }

    }
}