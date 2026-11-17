
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// JSON-RPC response object, or one SSE event's data when streaming.
    /// </summary>
    public sealed partial class McpPostResponse
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}