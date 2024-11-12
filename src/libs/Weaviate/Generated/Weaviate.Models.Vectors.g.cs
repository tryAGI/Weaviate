
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// A map of named vectors for multi-vector representations.
    /// </summary>
    public sealed partial class Vectors
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Vectors" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Vectors(
 )
        {
        }
    }
}