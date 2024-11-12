
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// List of Objects.
    /// </summary>
    public sealed partial class ObjectsListResponse
    {
        /// <summary>
        /// The actual list of Objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objects")]
        public global::System.Collections.Generic.IList<global::Weaviate.Object>? Objects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecations")]
        public global::System.Collections.Generic.IList<global::Weaviate.Deprecation>? Deprecations { get; set; }

        /// <summary>
        /// The total number of Objects for the query. The number of items in a response may be smaller due to paging.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalResults")]
        public long? TotalResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsListResponse" /> class.
        /// </summary>
        /// <param name="objects">
        /// The actual list of Objects.
        /// </param>
        /// <param name="deprecations"></param>
        /// <param name="totalResults">
        /// The total number of Objects for the query. The number of items in a response may be smaller due to paging.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ObjectsListResponse(
            global::System.Collections.Generic.IList<global::Weaviate.Object>? objects,
            global::System.Collections.Generic.IList<global::Weaviate.Deprecation>? deprecations,
            long? totalResults)
        {
            this.Objects = objects;
            this.Deprecations = deprecations;
            this.TotalResults = totalResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsListResponse" /> class.
        /// </summary>
        public ObjectsListResponse()
        {
        }
    }
}