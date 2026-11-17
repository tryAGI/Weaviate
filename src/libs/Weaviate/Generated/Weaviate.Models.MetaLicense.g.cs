
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// License state of the current Weaviate instance.
    /// </summary>
    public sealed partial class MetaLicense
    {
        /// <summary>
        /// The product edition: community (no license key) or enterprise (license key configured).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edition")]
        public string? Edition { get; set; }

        /// <summary>
        /// Documentation page for the Weaviate Enterprise Edition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentationHref")]
        public string? DocumentationHref { get; set; }

        /// <summary>
        /// Current license status. Only present on Enterprise Edition; a Community Edition node has no license and therefore no license status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The non-secret id of the configured license, empty when unlicensed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("licenseId")]
        public string? LicenseId { get; set; }

        /// <summary>
        /// When the license expires, if known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// When the license was last verified with the license service, if ever.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastCheckedAt")]
        public global::System.DateTime? LastCheckedAt { get; set; }

        /// <summary>
        /// When the grace period ends, if the license is not currently valid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gracePeriodEndsAt")]
        public global::System.DateTime? GracePeriodEndsAt { get; set; }

        /// <summary>
        /// Whether license enforcement is active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcing")]
        public bool? Enforcing { get; set; }

        /// <summary>
        /// Whether the license is used on a cluster other than the one it was issued for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusterMismatch")]
        public bool? ClusterMismatch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaLicense" /> class.
        /// </summary>
        /// <param name="edition">
        /// The product edition: community (no license key) or enterprise (license key configured).
        /// </param>
        /// <param name="documentationHref">
        /// Documentation page for the Weaviate Enterprise Edition.
        /// </param>
        /// <param name="status">
        /// Current license status. Only present on Enterprise Edition; a Community Edition node has no license and therefore no license status.
        /// </param>
        /// <param name="licenseId">
        /// The non-secret id of the configured license, empty when unlicensed.
        /// </param>
        /// <param name="expiresAt">
        /// When the license expires, if known.
        /// </param>
        /// <param name="lastCheckedAt">
        /// When the license was last verified with the license service, if ever.
        /// </param>
        /// <param name="gracePeriodEndsAt">
        /// When the grace period ends, if the license is not currently valid.
        /// </param>
        /// <param name="enforcing">
        /// Whether license enforcement is active.
        /// </param>
        /// <param name="clusterMismatch">
        /// Whether the license is used on a cluster other than the one it was issued for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetaLicense(
            string? edition,
            string? documentationHref,
            string? status,
            string? licenseId,
            global::System.DateTime? expiresAt,
            global::System.DateTime? lastCheckedAt,
            global::System.DateTime? gracePeriodEndsAt,
            bool? enforcing,
            bool? clusterMismatch)
        {
            this.Edition = edition;
            this.DocumentationHref = documentationHref;
            this.Status = status;
            this.LicenseId = licenseId;
            this.ExpiresAt = expiresAt;
            this.LastCheckedAt = lastCheckedAt;
            this.GracePeriodEndsAt = gracePeriodEndsAt;
            this.Enforcing = enforcing;
            this.ClusterMismatch = clusterMismatch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaLicense" /> class.
        /// </summary>
        public MetaLicense()
        {
        }

    }
}