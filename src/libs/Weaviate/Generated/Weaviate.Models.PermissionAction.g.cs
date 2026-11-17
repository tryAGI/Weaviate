
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Allowed actions in weaviate.
    /// </summary>
    public enum PermissionAction
    {
        /// <summary>
        ///
        /// </summary>
        AssignAndRevokeGroups,
        /// <summary>
        ///
        /// </summary>
        AssignAndRevokeUsers,
        /// <summary>
        ///
        /// </summary>
        CreateAliases,
        /// <summary>
        ///
        /// </summary>
        CreateCollections,
        /// <summary>
        ///
        /// </summary>
        CreateData,
        /// <summary>
        ///
        /// </summary>
        CreateMcp,
        /// <summary>
        ///
        /// </summary>
        CreateReplicate,
        /// <summary>
        ///
        /// </summary>
        CreateRoles,
        /// <summary>
        ///
        /// </summary>
        CreateTenants,
        /// <summary>
        ///
        /// </summary>
        CreateUsers,
        /// <summary>
        ///
        /// </summary>
        DeleteAliases,
        /// <summary>
        ///
        /// </summary>
        DeleteCollections,
        /// <summary>
        ///
        /// </summary>
        DeleteData,
        /// <summary>
        ///
        /// </summary>
        DeleteReplicate,
        /// <summary>
        ///
        /// </summary>
        DeleteRoles,
        /// <summary>
        ///
        /// </summary>
        DeleteTenants,
        /// <summary>
        ///
        /// </summary>
        DeleteUsers,
        /// <summary>
        ///
        /// </summary>
        ManageBackups,
        /// <summary>
        ///
        /// </summary>
        ManageNamespaces,
        /// <summary>
        ///
        /// </summary>
        ReadAliases,
        /// <summary>
        ///
        /// </summary>
        ReadBackups,
        /// <summary>
        ///
        /// </summary>
        ReadCluster,
        /// <summary>
        ///
        /// </summary>
        ReadCollections,
        /// <summary>
        ///
        /// </summary>
        ReadData,
        /// <summary>
        ///
        /// </summary>
        ReadGroups,
        /// <summary>
        ///
        /// </summary>
        ReadMcp,
        /// <summary>
        ///
        /// </summary>
        ReadNodes,
        /// <summary>
        ///
        /// </summary>
        ReadReplicate,
        /// <summary>
        ///
        /// </summary>
        ReadRoles,
        /// <summary>
        ///
        /// </summary>
        ReadTenants,
        /// <summary>
        ///
        /// </summary>
        ReadUsers,
        /// <summary>
        ///
        /// </summary>
        UpdateAliases,
        /// <summary>
        ///
        /// </summary>
        UpdateCollections,
        /// <summary>
        ///
        /// </summary>
        UpdateData,
        /// <summary>
        ///
        /// </summary>
        UpdateMcp,
        /// <summary>
        ///
        /// </summary>
        UpdateReplicate,
        /// <summary>
        ///
        /// </summary>
        UpdateRoles,
        /// <summary>
        ///
        /// </summary>
        UpdateTenants,
        /// <summary>
        ///
        /// </summary>
        UpdateUsers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PermissionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PermissionAction value)
        {
            return value switch
            {
                PermissionAction.AssignAndRevokeGroups => "assign_and_revoke_groups",
                PermissionAction.AssignAndRevokeUsers => "assign_and_revoke_users",
                PermissionAction.CreateAliases => "create_aliases",
                PermissionAction.CreateCollections => "create_collections",
                PermissionAction.CreateData => "create_data",
                PermissionAction.CreateMcp => "create_mcp",
                PermissionAction.CreateReplicate => "create_replicate",
                PermissionAction.CreateRoles => "create_roles",
                PermissionAction.CreateTenants => "create_tenants",
                PermissionAction.CreateUsers => "create_users",
                PermissionAction.DeleteAliases => "delete_aliases",
                PermissionAction.DeleteCollections => "delete_collections",
                PermissionAction.DeleteData => "delete_data",
                PermissionAction.DeleteReplicate => "delete_replicate",
                PermissionAction.DeleteRoles => "delete_roles",
                PermissionAction.DeleteTenants => "delete_tenants",
                PermissionAction.DeleteUsers => "delete_users",
                PermissionAction.ManageBackups => "manage_backups",
                PermissionAction.ManageNamespaces => "manage_namespaces",
                PermissionAction.ReadAliases => "read_aliases",
                PermissionAction.ReadBackups => "read_backups",
                PermissionAction.ReadCluster => "read_cluster",
                PermissionAction.ReadCollections => "read_collections",
                PermissionAction.ReadData => "read_data",
                PermissionAction.ReadGroups => "read_groups",
                PermissionAction.ReadMcp => "read_mcp",
                PermissionAction.ReadNodes => "read_nodes",
                PermissionAction.ReadReplicate => "read_replicate",
                PermissionAction.ReadRoles => "read_roles",
                PermissionAction.ReadTenants => "read_tenants",
                PermissionAction.ReadUsers => "read_users",
                PermissionAction.UpdateAliases => "update_aliases",
                PermissionAction.UpdateCollections => "update_collections",
                PermissionAction.UpdateData => "update_data",
                PermissionAction.UpdateMcp => "update_mcp",
                PermissionAction.UpdateReplicate => "update_replicate",
                PermissionAction.UpdateRoles => "update_roles",
                PermissionAction.UpdateTenants => "update_tenants",
                PermissionAction.UpdateUsers => "update_users",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PermissionAction? ToEnum(string value)
        {
            return value switch
            {
                "assign_and_revoke_groups" => PermissionAction.AssignAndRevokeGroups,
                "assign_and_revoke_users" => PermissionAction.AssignAndRevokeUsers,
                "create_aliases" => PermissionAction.CreateAliases,
                "create_collections" => PermissionAction.CreateCollections,
                "create_data" => PermissionAction.CreateData,
                "create_mcp" => PermissionAction.CreateMcp,
                "create_replicate" => PermissionAction.CreateReplicate,
                "create_roles" => PermissionAction.CreateRoles,
                "create_tenants" => PermissionAction.CreateTenants,
                "create_users" => PermissionAction.CreateUsers,
                "delete_aliases" => PermissionAction.DeleteAliases,
                "delete_collections" => PermissionAction.DeleteCollections,
                "delete_data" => PermissionAction.DeleteData,
                "delete_replicate" => PermissionAction.DeleteReplicate,
                "delete_roles" => PermissionAction.DeleteRoles,
                "delete_tenants" => PermissionAction.DeleteTenants,
                "delete_users" => PermissionAction.DeleteUsers,
                "manage_backups" => PermissionAction.ManageBackups,
                "manage_namespaces" => PermissionAction.ManageNamespaces,
                "read_aliases" => PermissionAction.ReadAliases,
                "read_backups" => PermissionAction.ReadBackups,
                "read_cluster" => PermissionAction.ReadCluster,
                "read_collections" => PermissionAction.ReadCollections,
                "read_data" => PermissionAction.ReadData,
                "read_groups" => PermissionAction.ReadGroups,
                "read_mcp" => PermissionAction.ReadMcp,
                "read_nodes" => PermissionAction.ReadNodes,
                "read_replicate" => PermissionAction.ReadReplicate,
                "read_roles" => PermissionAction.ReadRoles,
                "read_tenants" => PermissionAction.ReadTenants,
                "read_users" => PermissionAction.ReadUsers,
                "update_aliases" => PermissionAction.UpdateAliases,
                "update_collections" => PermissionAction.UpdateCollections,
                "update_data" => PermissionAction.UpdateData,
                "update_mcp" => PermissionAction.UpdateMcp,
                "update_replicate" => PermissionAction.UpdateReplicate,
                "update_roles" => PermissionAction.UpdateRoles,
                "update_tenants" => PermissionAction.UpdateTenants,
                "update_users" => PermissionAction.UpdateUsers,
                _ => null,
            };
        }
    }
}