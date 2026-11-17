
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Resources applicable for data actions.
    /// </summary>
    public sealed partial class PermissionData
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
        /// Deprecated: Object-level permissions are not supported. This field is ignored; the permission always applies to all objects. Kept for backward compatibility.<br/>
        /// Default Value: *
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionData" /> class.
        /// </summary>
        /// <param name="collection">
        /// A string that specifies which collections this permission applies to. Can be an exact collection name or a regex pattern. The default value `*` applies the permission to all collections.<br/>
        /// Default Value: *
        /// </param>
        /// <param name="tenant">
        /// A string that specifies which tenants this permission applies to. Can be an exact tenant name or a regex pattern. The default value `*` applies the permission to all tenants.<br/>
        /// Default Value: *
        /// </param>
        /// <param name="object">
        /// Deprecated: Object-level permissions are not supported. This field is ignored; the permission always applies to all objects. Kept for backward compatibility.<br/>
        /// Default Value: *
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PermissionData(
            string? collection,
            string? tenant,
            string? @object)
        {
            this.Collection = collection;
            this.Tenant = tenant;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionData" /> class.
        /// </summary>
        public PermissionData()
        {
        }

    }
}