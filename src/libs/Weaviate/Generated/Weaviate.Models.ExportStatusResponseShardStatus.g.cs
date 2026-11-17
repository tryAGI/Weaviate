
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Per-shard progress: className -&gt; shardName -&gt; status
    /// </summary>
    public sealed partial class ExportStatusResponseShardStatus
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}