
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The metadata of a referenced object, populated according to the selector's `returnMetadata`. Every field is optional and only present when it was requested.
    /// </summary>
    public sealed partial class SearchResultReferenceMetadata
    {
        /// <summary>
        /// The referenced object's UUID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The referenced object's creation time, as epoch milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creationTime")]
        public long? CreationTime { get; set; }

        /// <summary>
        /// The referenced object's last-update time, as epoch milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdateTime")]
        public long? LastUpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultReferenceMetadata" /> class.
        /// </summary>
        /// <param name="id">
        /// The referenced object's UUID.
        /// </param>
        /// <param name="creationTime">
        /// The referenced object's creation time, as epoch milliseconds.
        /// </param>
        /// <param name="lastUpdateTime">
        /// The referenced object's last-update time, as epoch milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultReferenceMetadata(
            global::System.Guid? id,
            long? creationTime,
            long? lastUpdateTime)
        {
            this.Id = id;
            this.CreationTime = creationTime;
            this.LastUpdateTime = lastUpdateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultReferenceMetadata" /> class.
        /// </summary>
        public SearchResultReferenceMetadata()
        {
        }

    }
}