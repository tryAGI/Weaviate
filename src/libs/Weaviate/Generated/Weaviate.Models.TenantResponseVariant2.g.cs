
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
        /// Experimental. The data version of the tenant is a monotonically increasing number starting from 0 which is incremented each time a tenant's data is offloaded to cloud storage.<br/>
        /// Default Value: 0<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataVersion")]
        public int? DataVersion { get; set; }

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
        /// <param name="dataVersion">
        /// Experimental. The data version of the tenant is a monotonically increasing number starting from 0 which is incremented each time a tenant's data is offloaded to cloud storage.<br/>
        /// Default Value: 0<br/>
        /// Example: 3
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TenantResponseVariant2(
            global::System.Collections.Generic.IList<string>? belongsToNodes,
            int? dataVersion)
        {
            this.BelongsToNodes = belongsToNodes;
            this.DataVersion = dataVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantResponseVariant2" /> class.
        /// </summary>
        public TenantResponseVariant2()
        {
        }
    }
}