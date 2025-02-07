
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TenantResponseVariant2
    {
        /// <summary>
        /// The list of nodes that owns that tenant data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("belongsToNodes")]
        public global::System.Collections.Generic.IList<string>? BelongsToNodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantResponseVariant2" /> class.
        /// </summary>
        /// <param name="belongsToNodes">
        /// The list of nodes that owns that tenant data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TenantResponseVariant2(
            global::System.Collections.Generic.IList<string>? belongsToNodes)
        {
            this.BelongsToNodes = belongsToNodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantResponseVariant2" /> class.
        /// </summary>
        public TenantResponseVariant2()
        {
        }
    }
}