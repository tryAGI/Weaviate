
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchNearObjectRequestVariant2
    {
        /// <summary>
        /// The UUID of the source object whose stored vector anchors the search. A structurally invalid UUID is rejected at request validation; a well-formed UUID that matches no object in the collection is rejected with 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

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
        /// The named vector to search (the source object's vector for this name anchors the search). Required when the collection has more than one named vector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetVector")]
        public string? TargetVector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchNearObjectRequestVariant2" /> class.
        /// </summary>
        /// <param name="id">
        /// The UUID of the source object whose stored vector anchors the search. A structurally invalid UUID is rejected at request validation; a well-formed UUID that matches no object in the collection is rejected with 400.
        /// </param>
        /// <param name="certainty">
        /// Minimum normalized certainty of a match. Only for cosine-distance vector indexes. Mutually exclusive with `distance`.
        /// </param>
        /// <param name="distance">
        /// Maximum vector distance of a match. Mutually exclusive with `certainty`.
        /// </param>
        /// <param name="targetVector">
        /// The named vector to search (the source object's vector for this name anchors the search). Required when the collection has more than one named vector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchNearObjectRequestVariant2(
            global::System.Guid id,
            double? certainty,
            double? distance,
            string? targetVector)
        {
            this.Id = id;
            this.Certainty = certainty;
            this.Distance = distance;
            this.TargetVector = targetVector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchNearObjectRequestVariant2" /> class.
        /// </summary>
        public SearchNearObjectRequestVariant2()
        {
        }

    }
}