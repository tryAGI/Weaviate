
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Manage how the index should be sharded and distributed in the cluster
    /// </summary>
    public sealed partial class ClassShardingConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassShardingConfig" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ClassShardingConfig(
 )
        {
        }
    }
}