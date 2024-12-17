
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Configuration specific to modules in a collection context.
    /// </summary>
    public sealed partial class ClassModuleConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassModuleConfig" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ClassModuleConfig(
 )
        {
        }
    }
}