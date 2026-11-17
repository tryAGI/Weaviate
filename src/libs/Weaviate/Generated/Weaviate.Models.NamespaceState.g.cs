
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Lifecycle state. "active" namespaces accept all operations. "suspended" namespaces reject new classes, aliases, users, roles, role assignments, and replica movements, and their users can no longer authenticate; everything the namespace already owns is retained. "resuming" namespaces are on their way back to "active" and are still restricted the same way, replica movements included. "deleting" namespaces are being removed: new classes, aliases, users, and replica movements can no longer be created in the namespace, and the namespace itself disappears once removal completes.
    /// </summary>
    public enum NamespaceState
    {
        /// <summary>
        /// new classes, aliases, users, and replica movements can no longer be created in the namespace, and the namespace itself disappears once removal completes.
        /// </summary>
        Active,
        /// <summary>
        /// new classes, aliases, users, and replica movements can no longer be created in the namespace, and the namespace itself disappears once removal completes.
        /// </summary>
        Deleting,
        /// <summary>
        /// new classes, aliases, users, and replica movements can no longer be created in the namespace, and the namespace itself disappears once removal completes.
        /// </summary>
        Resuming,
        /// <summary>
        /// new classes, aliases, users, and replica movements can no longer be created in the namespace, and the namespace itself disappears once removal completes.
        /// </summary>
        Suspended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NamespaceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NamespaceState value)
        {
            return value switch
            {
                NamespaceState.Active => "active",
                NamespaceState.Deleting => "deleting",
                NamespaceState.Resuming => "resuming",
                NamespaceState.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NamespaceState? ToEnum(string value)
        {
            return value switch
            {
                "active" => NamespaceState.Active,
                "deleting" => NamespaceState.Deleting,
                "resuming" => NamespaceState.Resuming,
                "suspended" => NamespaceState.Suspended,
                _ => null,
            };
        }
    }
}