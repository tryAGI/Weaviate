
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Additional variables for the query.
    /// </summary>
    public sealed partial class GraphQLQueryVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQLQueryVariables" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GraphQLQueryVariables(
 )
        {
        }
    }
}