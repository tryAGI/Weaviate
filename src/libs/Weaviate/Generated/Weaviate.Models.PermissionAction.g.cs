
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// allowed actions in weaviate.
    /// </summary>
    public enum PermissionAction
    {
        /// <summary>
        /// 
        /// </summary>
        ManageBackups,
        /// <summary>
        /// 
        /// </summary>
        ReadCluster,
        /// <summary>
        /// 
        /// </summary>
        CreateData,
        /// <summary>
        /// 
        /// </summary>
        ReadData,
        /// <summary>
        /// 
        /// </summary>
        UpdateData,
        /// <summary>
        /// 
        /// </summary>
        DeleteData,
        /// <summary>
        /// 
        /// </summary>
        ReadNodes,
        /// <summary>
        /// 
        /// </summary>
        CreateRoles,
        /// <summary>
        /// 
        /// </summary>
        ReadRoles,
        /// <summary>
        /// 
        /// </summary>
        UpdateRoles,
        /// <summary>
        /// 
        /// </summary>
        DeleteRoles,
        /// <summary>
        /// 
        /// </summary>
        CreateCollections,
        /// <summary>
        /// 
        /// </summary>
        ReadCollections,
        /// <summary>
        /// 
        /// </summary>
        UpdateCollections,
        /// <summary>
        /// 
        /// </summary>
        DeleteCollections,
        /// <summary>
        /// 
        /// </summary>
        AssignAndRevokeUsers,
        /// <summary>
        /// 
        /// </summary>
        ReadUsers,
        /// <summary>
        /// 
        /// </summary>
        CreateTenants,
        /// <summary>
        /// 
        /// </summary>
        ReadTenants,
        /// <summary>
        /// 
        /// </summary>
        UpdateTenants,
        /// <summary>
        /// 
        /// </summary>
        DeleteTenants,
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
                PermissionAction.ManageBackups => "manage_backups",
                PermissionAction.ReadCluster => "read_cluster",
                PermissionAction.CreateData => "create_data",
                PermissionAction.ReadData => "read_data",
                PermissionAction.UpdateData => "update_data",
                PermissionAction.DeleteData => "delete_data",
                PermissionAction.ReadNodes => "read_nodes",
                PermissionAction.CreateRoles => "create_roles",
                PermissionAction.ReadRoles => "read_roles",
                PermissionAction.UpdateRoles => "update_roles",
                PermissionAction.DeleteRoles => "delete_roles",
                PermissionAction.CreateCollections => "create_collections",
                PermissionAction.ReadCollections => "read_collections",
                PermissionAction.UpdateCollections => "update_collections",
                PermissionAction.DeleteCollections => "delete_collections",
                PermissionAction.AssignAndRevokeUsers => "assign_and_revoke_users",
                PermissionAction.ReadUsers => "read_users",
                PermissionAction.CreateTenants => "create_tenants",
                PermissionAction.ReadTenants => "read_tenants",
                PermissionAction.UpdateTenants => "update_tenants",
                PermissionAction.DeleteTenants => "delete_tenants",
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
                "manage_backups" => PermissionAction.ManageBackups,
                "read_cluster" => PermissionAction.ReadCluster,
                "create_data" => PermissionAction.CreateData,
                "read_data" => PermissionAction.ReadData,
                "update_data" => PermissionAction.UpdateData,
                "delete_data" => PermissionAction.DeleteData,
                "read_nodes" => PermissionAction.ReadNodes,
                "create_roles" => PermissionAction.CreateRoles,
                "read_roles" => PermissionAction.ReadRoles,
                "update_roles" => PermissionAction.UpdateRoles,
                "delete_roles" => PermissionAction.DeleteRoles,
                "create_collections" => PermissionAction.CreateCollections,
                "read_collections" => PermissionAction.ReadCollections,
                "update_collections" => PermissionAction.UpdateCollections,
                "delete_collections" => PermissionAction.DeleteCollections,
                "assign_and_revoke_users" => PermissionAction.AssignAndRevokeUsers,
                "read_users" => PermissionAction.ReadUsers,
                "create_tenants" => PermissionAction.CreateTenants,
                "read_tenants" => PermissionAction.ReadTenants,
                "update_tenants" => PermissionAction.UpdateTenants,
                "delete_tenants" => PermissionAction.DeleteTenants,
                _ => null,
            };
        }
    }
}