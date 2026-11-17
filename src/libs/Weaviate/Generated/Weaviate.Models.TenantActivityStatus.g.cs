
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The activity status of the tenant, which determines if it is queryable and where its data is stored.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Available Statuses:&lt;/b&gt;&lt;br/&gt;- `ACTIVE`: The tenant is fully operational and ready for queries. Data is stored on local, hot storage.&lt;br/&gt;- `INACTIVE`: The tenant is not queryable. Data is stored locally.&lt;br/&gt;- `OFFLOADED`: The tenant is inactive and its data is stored in a remote cloud backend.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Usage Rules:&lt;/b&gt;&lt;br/&gt;- &lt;b&gt;On Create:&lt;/b&gt; This field is optional and defaults to `ACTIVE`. Allowed values are `ACTIVE` and `INACTIVE`.&lt;br/&gt;- &lt;b&gt;On Update:&lt;/b&gt; This field is required. Allowed values are `ACTIVE`, `INACTIVE`, and `OFFLOADED`.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Read-Only Statuses:&lt;/b&gt;&lt;br/&gt;The following statuses are set by the server and indicate a tenant is transitioning between states:&lt;br/&gt;- `OFFLOADING`&lt;br/&gt;- `ONLOADING`&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Note on Deprecated Names:&lt;/b&gt;&lt;br/&gt;For backward compatibility, deprecated names are still accepted and are mapped to their modern equivalents: `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
    /// </summary>
    public enum TenantActivityStatus
    {
        /// <summary>
        /// &lt;/b&gt;&lt;br/&gt;- `ACTIVE`: The tenant is fully operational and ready for queries. Data is stored on local, hot storage.&lt;br/&gt;- `INACTIVE`: The tenant is not queryable. Data is stored locally.&lt;br/&gt;- `OFFLOADED`: The tenant is inactive and its data is stored in a remote cloud backend.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Usage Rules:&lt;/b&gt;&lt;br/&gt;- &lt;b&gt;On Create:&lt;/b&gt; This field is optional and defaults to `ACTIVE`. Allowed values are `ACTIVE` and `INACTIVE`.&lt;br/&gt;- &lt;b&gt;On Update:&lt;/b&gt; This field is required. Allowed values are `ACTIVE`, `INACTIVE`, and `OFFLOADED`.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Read-Only Statuses:&lt;/b&gt;&lt;br/&gt;The following statuses are set by the server and indicate a tenant is transitioning between states:&lt;br/&gt;- `OFFLOADING`&lt;br/&gt;- `ONLOADING`&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Note on Deprecated Names:&lt;/b&gt;&lt;br/&gt;For backward compatibility, deprecated names are still accepted and are mapped to their modern equivalents: `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Active,
        /// <summary>
        /// &lt;/b&gt;&lt;br/&gt;- `ACTIVE`: The tenant is fully operational and ready for queries. Data is stored on local, hot storage.&lt;br/&gt;- `INACTIVE`: The tenant is not queryable. Data is stored locally.&lt;br/&gt;- `OFFLOADED`: The tenant is inactive and its data is stored in a remote cloud backend.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Usage Rules:&lt;/b&gt;&lt;br/&gt;- &lt;b&gt;On Create:&lt;/b&gt; This field is optional and defaults to `ACTIVE`. Allowed values are `ACTIVE` and `INACTIVE`.&lt;br/&gt;- &lt;b&gt;On Update:&lt;/b&gt; This field is required. Allowed values are `ACTIVE`, `INACTIVE`, and `OFFLOADED`.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Read-Only Statuses:&lt;/b&gt;&lt;br/&gt;The following statuses are set by the server and indicate a tenant is transitioning between states:&lt;br/&gt;- `OFFLOADING`&lt;br/&gt;- `ONLOADING`&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Note on Deprecated Names:&lt;/b&gt;&lt;br/&gt;For backward compatibility, deprecated names are still accepted and are mapped to their modern equivalents: `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Cold,
        /// <summary>
        /// &lt;/b&gt;&lt;br/&gt;- `ACTIVE`: The tenant is fully operational and ready for queries. Data is stored on local, hot storage.&lt;br/&gt;- `INACTIVE`: The tenant is not queryable. Data is stored locally.&lt;br/&gt;- `OFFLOADED`: The tenant is inactive and its data is stored in a remote cloud backend.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Usage Rules:&lt;/b&gt;&lt;br/&gt;- &lt;b&gt;On Create:&lt;/b&gt; This field is optional and defaults to `ACTIVE`. Allowed values are `ACTIVE` and `INACTIVE`.&lt;br/&gt;- &lt;b&gt;On Update:&lt;/b&gt; This field is required. Allowed values are `ACTIVE`, `INACTIVE`, and `OFFLOADED`.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Read-Only Statuses:&lt;/b&gt;&lt;br/&gt;The following statuses are set by the server and indicate a tenant is transitioning between states:&lt;br/&gt;- `OFFLOADING`&lt;br/&gt;- `ONLOADING`&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Note on Deprecated Names:&lt;/b&gt;&lt;br/&gt;For backward compatibility, deprecated names are still accepted and are mapped to their modern equivalents: `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Freezing,
        /// <summary>
        /// &lt;/b&gt;&lt;br/&gt;- `ACTIVE`: The tenant is fully operational and ready for queries. Data is stored on local, hot storage.&lt;br/&gt;- `INACTIVE`: The tenant is not queryable. Data is stored locally.&lt;br/&gt;- `OFFLOADED`: The tenant is inactive and its data is stored in a remote cloud backend.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Usage Rules:&lt;/b&gt;&lt;br/&gt;- &lt;b&gt;On Create:&lt;/b&gt; This field is optional and defaults to `ACTIVE`. Allowed values are `ACTIVE` and `INACTIVE`.&lt;br/&gt;- &lt;b&gt;On Update:&lt;/b&gt; This field is required. Allowed values are `ACTIVE`, `INACTIVE`, and `OFFLOADED`.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Read-Only Statuses:&lt;/b&gt;&lt;br/&gt;The following statuses are set by the server and indicate a tenant is transitioning between states:&lt;br/&gt;- `OFFLOADING`&lt;br/&gt;- `ONLOADING`&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Note on Deprecated Names:&lt;/b&gt;&lt;br/&gt;For backward compatibility, deprecated names are still accepted and are mapped to their modern equivalents: `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Frozen,
        /// <summary>
        /// &lt;/b&gt;&lt;br/&gt;- `ACTIVE`: The tenant is fully operational and ready for queries. Data is stored on local, hot storage.&lt;br/&gt;- `INACTIVE`: The tenant is not queryable. Data is stored locally.&lt;br/&gt;- `OFFLOADED`: The tenant is inactive and its data is stored in a remote cloud backend.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Usage Rules:&lt;/b&gt;&lt;br/&gt;- &lt;b&gt;On Create:&lt;/b&gt; This field is optional and defaults to `ACTIVE`. Allowed values are `ACTIVE` and `INACTIVE`.&lt;br/&gt;- &lt;b&gt;On Update:&lt;/b&gt; This field is required. Allowed values are `ACTIVE`, `INACTIVE`, and `OFFLOADED`.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Read-Only Statuses:&lt;/b&gt;&lt;br/&gt;The following statuses are set by the server and indicate a tenant is transitioning between states:&lt;br/&gt;- `OFFLOADING`&lt;br/&gt;- `ONLOADING`&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Note on Deprecated Names:&lt;/b&gt;&lt;br/&gt;For backward compatibility, deprecated names are still accepted and are mapped to their modern equivalents: `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Hot,
        /// <summary>
        /// &lt;/b&gt;&lt;br/&gt;- `ACTIVE`: The tenant is fully operational and ready for queries. Data is stored on local, hot storage.&lt;br/&gt;- `INACTIVE`: The tenant is not queryable. Data is stored locally.&lt;br/&gt;- `OFFLOADED`: The tenant is inactive and its data is stored in a remote cloud backend.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Usage Rules:&lt;/b&gt;&lt;br/&gt;- &lt;b&gt;On Create:&lt;/b&gt; This field is optional and defaults to `ACTIVE`. Allowed values are `ACTIVE` and `INACTIVE`.&lt;br/&gt;- &lt;b&gt;On Update:&lt;/b&gt; This field is required. Allowed values are `ACTIVE`, `INACTIVE`, and `OFFLOADED`.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Read-Only Statuses:&lt;/b&gt;&lt;br/&gt;The following statuses are set by the server and indicate a tenant is transitioning between states:&lt;br/&gt;- `OFFLOADING`&lt;br/&gt;- `ONLOADING`&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Note on Deprecated Names:&lt;/b&gt;&lt;br/&gt;For backward compatibility, deprecated names are still accepted and are mapped to their modern equivalents: `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Inactive,
        /// <summary>
        /// &lt;/b&gt;&lt;br/&gt;- `ACTIVE`: The tenant is fully operational and ready for queries. Data is stored on local, hot storage.&lt;br/&gt;- `INACTIVE`: The tenant is not queryable. Data is stored locally.&lt;br/&gt;- `OFFLOADED`: The tenant is inactive and its data is stored in a remote cloud backend.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Usage Rules:&lt;/b&gt;&lt;br/&gt;- &lt;b&gt;On Create:&lt;/b&gt; This field is optional and defaults to `ACTIVE`. Allowed values are `ACTIVE` and `INACTIVE`.&lt;br/&gt;- &lt;b&gt;On Update:&lt;/b&gt; This field is required. Allowed values are `ACTIVE`, `INACTIVE`, and `OFFLOADED`.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Read-Only Statuses:&lt;/b&gt;&lt;br/&gt;The following statuses are set by the server and indicate a tenant is transitioning between states:&lt;br/&gt;- `OFFLOADING`&lt;br/&gt;- `ONLOADING`&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Note on Deprecated Names:&lt;/b&gt;&lt;br/&gt;For backward compatibility, deprecated names are still accepted and are mapped to their modern equivalents: `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Offloaded,
        /// <summary>
        /// &lt;/b&gt;&lt;br/&gt;- `ACTIVE`: The tenant is fully operational and ready for queries. Data is stored on local, hot storage.&lt;br/&gt;- `INACTIVE`: The tenant is not queryable. Data is stored locally.&lt;br/&gt;- `OFFLOADED`: The tenant is inactive and its data is stored in a remote cloud backend.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Usage Rules:&lt;/b&gt;&lt;br/&gt;- &lt;b&gt;On Create:&lt;/b&gt; This field is optional and defaults to `ACTIVE`. Allowed values are `ACTIVE` and `INACTIVE`.&lt;br/&gt;- &lt;b&gt;On Update:&lt;/b&gt; This field is required. Allowed values are `ACTIVE`, `INACTIVE`, and `OFFLOADED`.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Read-Only Statuses:&lt;/b&gt;&lt;br/&gt;The following statuses are set by the server and indicate a tenant is transitioning between states:&lt;br/&gt;- `OFFLOADING`&lt;br/&gt;- `ONLOADING`&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Note on Deprecated Names:&lt;/b&gt;&lt;br/&gt;For backward compatibility, deprecated names are still accepted and are mapped to their modern equivalents: `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Offloading,
        /// <summary>
        /// &lt;/b&gt;&lt;br/&gt;- `ACTIVE`: The tenant is fully operational and ready for queries. Data is stored on local, hot storage.&lt;br/&gt;- `INACTIVE`: The tenant is not queryable. Data is stored locally.&lt;br/&gt;- `OFFLOADED`: The tenant is inactive and its data is stored in a remote cloud backend.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Usage Rules:&lt;/b&gt;&lt;br/&gt;- &lt;b&gt;On Create:&lt;/b&gt; This field is optional and defaults to `ACTIVE`. Allowed values are `ACTIVE` and `INACTIVE`.&lt;br/&gt;- &lt;b&gt;On Update:&lt;/b&gt; This field is required. Allowed values are `ACTIVE`, `INACTIVE`, and `OFFLOADED`.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Read-Only Statuses:&lt;/b&gt;&lt;br/&gt;The following statuses are set by the server and indicate a tenant is transitioning between states:&lt;br/&gt;- `OFFLOADING`&lt;br/&gt;- `ONLOADING`&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Note on Deprecated Names:&lt;/b&gt;&lt;br/&gt;For backward compatibility, deprecated names are still accepted and are mapped to their modern equivalents: `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Onloading,
        /// <summary>
        /// &lt;/b&gt;&lt;br/&gt;- `ACTIVE`: The tenant is fully operational and ready for queries. Data is stored on local, hot storage.&lt;br/&gt;- `INACTIVE`: The tenant is not queryable. Data is stored locally.&lt;br/&gt;- `OFFLOADED`: The tenant is inactive and its data is stored in a remote cloud backend.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Usage Rules:&lt;/b&gt;&lt;br/&gt;- &lt;b&gt;On Create:&lt;/b&gt; This field is optional and defaults to `ACTIVE`. Allowed values are `ACTIVE` and `INACTIVE`.&lt;br/&gt;- &lt;b&gt;On Update:&lt;/b&gt; This field is required. Allowed values are `ACTIVE`, `INACTIVE`, and `OFFLOADED`.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Read-Only Statuses:&lt;/b&gt;&lt;br/&gt;The following statuses are set by the server and indicate a tenant is transitioning between states:&lt;br/&gt;- `OFFLOADING`&lt;br/&gt;- `ONLOADING`&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Note on Deprecated Names:&lt;/b&gt;&lt;br/&gt;For backward compatibility, deprecated names are still accepted and are mapped to their modern equivalents: `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Unfreezing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TenantActivityStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TenantActivityStatus value)
        {
            return value switch
            {
                TenantActivityStatus.Active => "ACTIVE",
                TenantActivityStatus.Cold => "COLD",
                TenantActivityStatus.Freezing => "FREEZING",
                TenantActivityStatus.Frozen => "FROZEN",
                TenantActivityStatus.Hot => "HOT",
                TenantActivityStatus.Inactive => "INACTIVE",
                TenantActivityStatus.Offloaded => "OFFLOADED",
                TenantActivityStatus.Offloading => "OFFLOADING",
                TenantActivityStatus.Onloading => "ONLOADING",
                TenantActivityStatus.Unfreezing => "UNFREEZING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TenantActivityStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => TenantActivityStatus.Active,
                "COLD" => TenantActivityStatus.Cold,
                "FREEZING" => TenantActivityStatus.Freezing,
                "FROZEN" => TenantActivityStatus.Frozen,
                "HOT" => TenantActivityStatus.Hot,
                "INACTIVE" => TenantActivityStatus.Inactive,
                "OFFLOADED" => TenantActivityStatus.Offloaded,
                "OFFLOADING" => TenantActivityStatus.Offloading,
                "ONLOADING" => TenantActivityStatus.Onloading,
                "UNFREEZING" => TenantActivityStatus.Unfreezing,
                _ => null,
            };
        }
    }
}