
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// resources applicable for cluster actions
    /// </summary>
    public sealed partial class PermissionNodes
    {
        /// <summary>
        /// whether to allow (verbose) returning shards and stats data in the response<br/>
        /// Default Value: minimal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.PermissionNodesVerbosityJsonConverter))]
        public global::Weaviate.PermissionNodesVerbosity? Verbosity { get; set; }

        /// <summary>
        /// string or regex. if a specific collection name, if left empty it will be ALL or *<br/>
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
        /// whether to allow (verbose) returning shards and stats data in the response<br/>
        /// Default Value: minimal
        /// </param>
        /// <param name="collection">
        /// string or regex. if a specific collection name, if left empty it will be ALL or *<br/>
        /// Default Value: *
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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