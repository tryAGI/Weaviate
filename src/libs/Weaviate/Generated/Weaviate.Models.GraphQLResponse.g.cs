
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// GraphQL based response: http://facebook.github.io/graphql/.
    /// </summary>
    public sealed partial class GraphQLResponse
    {
        /// <summary>
        /// GraphQL data object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Weaviate.GraphQLResponseData? Data { get; set; }

        /// <summary>
        /// Array with errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Weaviate.GraphQLError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}