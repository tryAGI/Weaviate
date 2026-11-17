
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchNearTextRequestVariant2
    {
        /// <summary>
        /// The concept(s) to search for, as an array of strings. Multiple entries perform a multi-concept search. A single concept is a one-element array, e.g. `["space opera"]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Query { get; set; }

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
        /// The named vector to search. Required when the collection has more than one named vector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetVector")]
        public string? TargetVector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchNearTextRequestVariant2" /> class.
        /// </summary>
        /// <param name="query">
        /// The concept(s) to search for, as an array of strings. Multiple entries perform a multi-concept search. A single concept is a one-element array, e.g. `["space opera"]`.
        /// </param>
        /// <param name="certainty">
        /// Minimum normalized certainty of a match. Only for cosine-distance vector indexes. Mutually exclusive with `distance`.
        /// </param>
        /// <param name="distance">
        /// Maximum vector distance of a match. Mutually exclusive with `certainty`.
        /// </param>
        /// <param name="targetVector">
        /// The named vector to search. Required when the collection has more than one named vector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchNearTextRequestVariant2(
            global::System.Collections.Generic.IList<string> query,
            double? certainty,
            double? distance,
            string? targetVector)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Certainty = certainty;
            this.Distance = distance;
            this.TargetVector = targetVector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchNearTextRequestVariant2" /> class.
        /// </summary>
        public SearchNearTextRequestVariant2()
        {
        }

    }
}