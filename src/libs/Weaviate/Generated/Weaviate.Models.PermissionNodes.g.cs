
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Resources applicable for cluster actions.
    /// </summary>
    public sealed partial class PermissionNodes
    {
        /// <summary>
        /// Whether to allow (verbose) returning shards and stats data in the response.<br/>
        /// Default Value: minimal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.PermissionNodesVerbosityJsonConverter))]
        public global::Weaviate.PermissionNodesVerbosity? Verbosity { get; set; }

        /// <summary>
        /// A string that specifies which collections this permission applies to. Can be an exact collection name or a regex pattern. The default value `*` applies the permission to all collections.<br/>
        /// Default Value: *
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public string? Collection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionNodes" /> class.
        /// </summary>
        /// <param name="verbosity">
        /// Whether to allow (verbose) returning shards and stats data in the response.<br/>
        /// Default Value: minimal
        /// </param>
        /// <param name="collection">
        /// A string that specifies which collections this permission applies to. Can be an exact collection name or a regex pattern. The default value `*` applies the permission to all collections.<br/>
        /// Default Value: *
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PermissionNodes(
            global::Weaviate.PermissionNodesVerbosity? verbosity,
            string? collection)
        {
            this.Verbosity = verbosity;
            this.Collection = collection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionNodes" /> class.
        /// </summary>
        public PermissionNodes()
        {
        }

    }
}