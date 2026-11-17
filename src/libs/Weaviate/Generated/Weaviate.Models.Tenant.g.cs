
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Attributes representing a single tenant within Weaviate.
    /// </summary>
    public sealed partial class Tenant
    {
        /// <summary>
        /// The name of the tenant (required).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The activity status of the tenant, which determines if it is queryable and where its data is stored.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Available Statuses:&lt;/b&gt;&lt;br/&gt;- `ACTIVE`: The tenant is fully operational and ready for queries. Data is stored on local, hot storage.&lt;br/&gt;- `INACTIVE`: The tenant is not queryable. Data is stored locally.&lt;br/&gt;- `OFFLOADED`: The tenant is inactive and its data is stored in a remote cloud backend.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Usage Rules:&lt;/b&gt;&lt;br/&gt;- &lt;b&gt;On Create:&lt;/b&gt; This field is optional and defaults to `ACTIVE`. Allowed values are `ACTIVE` and `INACTIVE`.&lt;br/&gt;- &lt;b&gt;On Update:&lt;/b&gt; This field is required. Allowed values are `ACTIVE`, `INACTIVE`, and `OFFLOADED`.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Read-Only Statuses:&lt;/b&gt;&lt;br/&gt;The following statuses are set by the server and indicate a tenant is transitioning between states:&lt;br/&gt;- `OFFLOADING`&lt;br/&gt;- `ONLOADING`&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Note on Deprecated Names:&lt;/b&gt;&lt;br/&gt;For backward compatibility, deprecated names are still accepted and are mapped to their modern equivalents: `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activityStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.TenantActivityStatusJsonConverter))]
        public global::Weaviate.TenantActivityStatus? ActivityStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tenant" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the tenant (required).
        /// </param>
        /// <param name="activityStatus">
        /// The activity status of the tenant, which determines if it is queryable and where its data is stored.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Available Statuses:&lt;/b&gt;&lt;br/&gt;- `ACTIVE`: The tenant is fully operational and ready for queries. Data is stored on local, hot storage.&lt;br/&gt;- `INACTIVE`: The tenant is not queryable. Data is stored locally.&lt;br/&gt;- `OFFLOADED`: The tenant is inactive and its data is stored in a remote cloud backend.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Usage Rules:&lt;/b&gt;&lt;br/&gt;- &lt;b&gt;On Create:&lt;/b&gt; This field is optional and defaults to `ACTIVE`. Allowed values are `ACTIVE` and `INACTIVE`.&lt;br/&gt;- &lt;b&gt;On Update:&lt;/b&gt; This field is required. Allowed values are `ACTIVE`, `INACTIVE`, and `OFFLOADED`.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Read-Only Statuses:&lt;/b&gt;&lt;br/&gt;The following statuses are set by the server and indicate a tenant is transitioning between states:&lt;br/&gt;- `OFFLOADING`&lt;br/&gt;- `ONLOADING`&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Note on Deprecated Names:&lt;/b&gt;&lt;br/&gt;For backward compatibility, deprecated names are still accepted and are mapped to their modern equivalents: `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Tenant(
            string? name,
            global::Weaviate.TenantActivityStatus? activityStatus)
        {
            this.Name = name;
            this.ActivityStatus = activityStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tenant" /> class.
        /// </summary>
        public Tenant()
        {
        }

    }
}