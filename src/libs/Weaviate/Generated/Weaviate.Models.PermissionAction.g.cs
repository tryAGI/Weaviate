
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
        AssignAndRevokeUsers,
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
        CreateRoles,
        /// <summary>
        /// 
        /// </summary>
        CreateTenants,
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
        DeleteRoles,
        /// <summary>
        /// 
        /// </summary>
        DeleteTenants,
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
        ReadCollections,
        /// <summary>
        /// 
        /// </summary>
        ReadData,
        /// <summary>
        /// 
        /// </summary>
        ReadNodes,
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
        UpdateCollections,
        /// <summary>
        /// 
        /// </summary>
        UpdateData,
        /// <summary>
        /// 
        /// </summary>
        UpdateRoles,
        /// <summary>
        /// 
        /// </summary>
        UpdateTenants,
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
                PermissionAction.AssignAndRevokeUsers => "assign_and_revoke_users",
                PermissionAction.CreateCollections => "create_collections",
                PermissionAction.CreateData => "create_data",
                PermissionAction.CreateRoles => "create_roles",
                PermissionAction.CreateTenants => "create_tenants",
                PermissionAction.DeleteCollections => "delete_collections",
                PermissionAction.DeleteData => "delete_data",
                PermissionAction.DeleteRoles => "delete_roles",
                PermissionAction.DeleteTenants => "delete_tenants",
                PermissionAction.ManageBackups => "manage_backups",
                PermissionAction.ReadCluster => "read_cluster",
                PermissionAction.ReadCollections => "read_collections",
                PermissionAction.ReadData => "read_data",
                PermissionAction.ReadNodes => "read_nodes",
                PermissionAction.ReadRoles => "read_roles",
                PermissionAction.ReadTenants => "read_tenants",
                PermissionAction.ReadUsers => "read_users",
                PermissionAction.UpdateCollections => "update_collections",
                PermissionAction.UpdateData => "update_data",
                PermissionAction.UpdateRoles => "update_roles",
                PermissionAction.UpdateTenants => "update_tenants",
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
                "assign_and_revoke_users" => PermissionAction.AssignAndRevokeUsers,
                "create_collections" => PermissionAction.CreateCollections,
                "create_data" => PermissionAction.CreateData,
                "create_roles" => PermissionAction.CreateRoles,
                "create_tenants" => PermissionAction.CreateTenants,
                "delete_collections" => PermissionAction.DeleteCollections,
                "delete_data" => PermissionAction.DeleteData,
                "delete_roles" => PermissionAction.DeleteRoles,
                "delete_tenants" => PermissionAction.DeleteTenants,
                "manage_backups" => PermissionAction.ManageBackups,
                "read_cluster" => PermissionAction.ReadCluster,
                "read_collections" => PermissionAction.ReadCollections,
                "read_data" => PermissionAction.ReadData,
                "read_nodes" => PermissionAction.ReadNodes,
                "read_roles" => PermissionAction.ReadRoles,
                "read_tenants" => PermissionAction.ReadTenants,
                "read_users" => PermissionAction.ReadUsers,
                "update_collections" => PermissionAction.UpdateCollections,
                "update_data" => PermissionAction.UpdateData,
                "update_roles" => PermissionAction.UpdateRoles,
                "update_tenants" => PermissionAction.UpdateTenants,
                _ => null,
            };
        }
    }
}