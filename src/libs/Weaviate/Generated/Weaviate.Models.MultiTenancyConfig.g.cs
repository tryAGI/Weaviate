
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Configuration related to multi-tenancy within a class
    /// </summary>
    public sealed partial class MultiTenancyConfig
    {
        /// <summary>
        /// Whether or not multi-tenancy is enabled for this class (default: false).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Nonexistent tenants should (not) be created implicitly (default: false).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoTenantCreation")]
        public bool? AutoTenantCreation { get; set; }

        /// <summary>
        /// Existing tenants should (not) be turned HOT implicitly when they are accessed and in another activity status (default: false).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoTenantActivation")]
        public bool? AutoTenantActivation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiTenancyConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether or not multi-tenancy is enabled for this class (default: false).
        /// </param>
        /// <param name="autoTenantCreation">
        /// Nonexistent tenants should (not) be created implicitly (default: false).
        /// </param>
        /// <param name="autoTenantActivation">
        /// Existing tenants should (not) be turned HOT implicitly when they are accessed and in another activity status (default: false).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiTenancyConfig(
            bool? enabled,
            bool? autoTenantCreation,
            bool? autoTenantActivation)
        {
            this.Enabled = enabled;
            this.AutoTenantCreation = autoTenantCreation;
            this.AutoTenantActivation = autoTenantActivation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiTenancyConfig" /> class.
        /// </summary>
        public MultiTenancyConfig()
        {
        }
    }
}