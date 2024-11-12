
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphQLErrorLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        public long? Column { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        public long? Line { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQLErrorLocation" /> class.
        /// </summary>
        /// <param name="column"></param>
        /// <param name="line"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GraphQLErrorLocation(
            long? column,
            long? line)
        {
            this.Column = column;
            this.Line = line;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQLErrorLocation" /> class.
        /// </summary>
        public GraphQLErrorLocation()
        {
        }
    }
}