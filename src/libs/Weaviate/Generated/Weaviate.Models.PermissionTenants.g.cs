
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Resources applicable for tenant actions.
    /// </summary>
    public sealed partial class PermissionTenants
    {
        /// <summary>
        /// A string that specifies which collections this permission applies to. Can be an exact collection name or a regex pattern. The default value `*` applies the permission to all collections.<br/>
        /// Default Value: *
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public string? Collection { get; set; }

        /// <summary>
        /// A string that specifies which tenants this permission applies to. Can be an exact tenant name or a regex pattern. The default value `*` applies the permission to all tenants.<br/>
        /// Default Value: *
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        public string? Tenant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionTenants" /> class.
        /// </summary>
        /// <param name="collection">
        /// A string that specifies which collections this permission applies to. Can be an exact collection name or a regex pattern. The default value `*` applies the permission to all collections.<br/>
        /// Default Value: *
        /// </param>
        /// <param name="tenant">
        /// A string that specifies which tenants this permission applies to. Can be an exact tenant name or a regex pattern. The default value `*` applies the permission to all tenants.<br/>
        /// Default Value: *
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PermissionTenants(
            string? collection,
            string? tenant)
        {
            this.Collection = collection;
            this.Tenant = tenant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionTenants" /> class.
        /// </summary>
        public PermissionTenants()
        {
        }

    }
}