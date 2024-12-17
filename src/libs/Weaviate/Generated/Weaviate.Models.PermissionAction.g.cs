
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
        ManageData,
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
        ManageRoles,
        /// <summary>
        /// 
        /// </summary>
        ReadRoles,
        /// <summary>
        /// 
        /// </summary>
        ManageCollections,
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
                PermissionAction.ManageData => "manage_data",
                PermissionAction.CreateData => "create_data",
                PermissionAction.ReadData => "read_data",
                PermissionAction.UpdateData => "update_data",
                PermissionAction.DeleteData => "delete_data",
                PermissionAction.ReadNodes => "read_nodes",
                PermissionAction.ManageRoles => "manage_roles",
                PermissionAction.ReadRoles => "read_roles",
                PermissionAction.ManageCollections => "manage_collections",
                PermissionAction.CreateCollections => "create_collections",
                PermissionAction.ReadCollections => "read_collections",
                PermissionAction.UpdateCollections => "update_collections",
                PermissionAction.DeleteCollections => "delete_collections",
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
                "manage_data" => PermissionAction.ManageData,
                "create_data" => PermissionAction.CreateData,
                "read_data" => PermissionAction.ReadData,
                "update_data" => PermissionAction.UpdateData,
                "delete_data" => PermissionAction.DeleteData,
                "read_nodes" => PermissionAction.ReadNodes,
                "manage_roles" => PermissionAction.ManageRoles,
                "read_roles" => PermissionAction.ReadRoles,
                "manage_collections" => PermissionAction.ManageCollections,
                "create_collections" => PermissionAction.CreateCollections,
                "read_collections" => PermissionAction.ReadCollections,
                "update_collections" => PermissionAction.UpdateCollections,
                "delete_collections" => PermissionAction.DeleteCollections,
                _ => null,
            };
        }
    }
}