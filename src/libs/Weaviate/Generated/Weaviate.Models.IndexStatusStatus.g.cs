
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// `partial`: the latest reindex task failed or was cancelled after some tenants had migrated; those tenants have the new index. After a tokenization change they answer queries with it; after enabling an index they answer with it only once the migration finishes. A replica that still owes a tenant's swap answers with the old index until its retry lands. See `migratedTenants` and `totalTenants`.
    /// </summary>
    public enum IndexStatusStatus
    {
        /// <summary>
        /// the latest reindex task failed or was cancelled after some tenants had migrated; those tenants have the new index. After a tokenization change they answer queries with it; after enabling an index they answer with it only once the migration finishes. A replica that still owes a tenant's swap answers with the old index until its retry lands. See `migratedTenants` and `totalTenants`.
        /// </summary>
        Cancelled,
        /// <summary>
        /// the latest reindex task failed or was cancelled after some tenants had migrated; those tenants have the new index. After a tokenization change they answer queries with it; after enabling an index they answer with it only once the migration finishes. A replica that still owes a tenant's swap answers with the old index until its retry lands. See `migratedTenants` and `totalTenants`.
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Indexing,
        /// <summary>
        /// the latest reindex task failed or was cancelled after some tenants had migrated; those tenants have the new index. After a tokenization change they answer queries with it; after enabling an index they answer with it only once the migration finishes. A replica that still owes a tenant's swap answers with the old index until its retry lands. See `migratedTenants` and `totalTenants`.
        /// </summary>
        Partial,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IndexStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexStatusStatus value)
        {
            return value switch
            {
                IndexStatusStatus.Cancelled => "cancelled",
                IndexStatusStatus.Failed => "failed",
                IndexStatusStatus.Indexing => "indexing",
                IndexStatusStatus.Partial => "partial",
                IndexStatusStatus.Pending => "pending",
                IndexStatusStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => IndexStatusStatus.Cancelled,
                "failed" => IndexStatusStatus.Failed,
                "indexing" => IndexStatusStatus.Indexing,
                "partial" => IndexStatusStatus.Partial,
                "pending" => IndexStatusStatus.Pending,
                "ready" => IndexStatusStatus.Ready,
                _ => null,
            };
        }
    }
}