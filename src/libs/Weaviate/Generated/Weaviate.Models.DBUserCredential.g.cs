
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// A single database user's exportable API-key credential. Carries the argon2id key hash for strong-key users; for users whose key cannot be migrated (imported/weak, revoked, or missing a hash) secureHash is null and status names the reason.
    /// </summary>
    public sealed partial class DBUserCredential
    {
        /// <summary>
        /// The name (ID) of the user, without any namespace prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The random identifier embedded in the user's API key, used to resolve the key hash. Exactly 16 characters for an importable record; empty when the export reports a user whose key is not carried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userIdentifier")]
        public string? UserIdentifier { get; set; }

        /// <summary>
        /// The argon2id PHC hash of the user's API key. Null when the key cannot be migrated (see status).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secureHash")]
        public string? SecureHash { get; set; }

        /// <summary>
        /// First 3 letters of the associated API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyFirstLetters")]
        public string? ApiKeyFirstLetters { get; set; }

        /// <summary>
        /// Whether the user is active. A deactivated (not revoked) user is carried with active=false and reproduced on import.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Date and time in ISO 8601 format: YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Date and time in ISO 8601 format, in UTC, at which the user's API key stops authenticating. Absent or null means the key never expires, except that import never changes an existing user's expiry, so a record without one keeps the stored value. A new user takes the record's value, even one that has passed. A differing future value for an existing user gives that record an error result naming `PUT /v1/users/db/{user_id}/expiration`. A differing past value gives `skipped_exists` for a deactivated user. For an active one it gives an error result advising to deactivate the user, or delete it and re-import, because that PUT refuses a past time. A node without a Weaviate license key refuses the whole import with 403 when any record sets a non-null `expiresAt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The namespace the user was bound to on the source. Informational on export; import binds the user to the request's target namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// Export classification. Only 'exported' carries a usable secureHash; the others report why the user was not carried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.DBUserCredentialStatusJsonConverter))]
        public global::Weaviate.DBUserCredentialStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DBUserCredential" /> class.
        /// </summary>
        /// <param name="userId">
        /// The name (ID) of the user, without any namespace prefix.
        /// </param>
        /// <param name="userIdentifier">
        /// The random identifier embedded in the user's API key, used to resolve the key hash. Exactly 16 characters for an importable record; empty when the export reports a user whose key is not carried.
        /// </param>
        /// <param name="secureHash">
        /// The argon2id PHC hash of the user's API key. Null when the key cannot be migrated (see status).
        /// </param>
        /// <param name="apiKeyFirstLetters">
        /// First 3 letters of the associated API key.
        /// </param>
        /// <param name="active">
        /// Whether the user is active. A deactivated (not revoked) user is carried with active=false and reproduced on import.
        /// </param>
        /// <param name="createdAt">
        /// Date and time in ISO 8601 format: YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="expiresAt">
        /// Date and time in ISO 8601 format, in UTC, at which the user's API key stops authenticating. Absent or null means the key never expires, except that import never changes an existing user's expiry, so a record without one keeps the stored value. A new user takes the record's value, even one that has passed. A differing future value for an existing user gives that record an error result naming `PUT /v1/users/db/{user_id}/expiration`. A differing past value gives `skipped_exists` for a deactivated user. For an active one it gives an error result advising to deactivate the user, or delete it and re-import, because that PUT refuses a past time. A node without a Weaviate license key refuses the whole import with 403 when any record sets a non-null `expiresAt`.
        /// </param>
        /// <param name="namespace">
        /// The namespace the user was bound to on the source. Informational on export; import binds the user to the request's target namespace.
        /// </param>
        /// <param name="status">
        /// Export classification. Only 'exported' carries a usable secureHash; the others report why the user was not carried.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DBUserCredential(
            string userId,
            string? userIdentifier,
            string? secureHash,
            string? apiKeyFirstLetters,
            bool? active,
            global::System.DateTime? createdAt,
            global::System.DateTime? expiresAt,
            string? @namespace,
            global::Weaviate.DBUserCredentialStatus? status)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserIdentifier = userIdentifier;
            this.SecureHash = secureHash;
            this.ApiKeyFirstLetters = apiKeyFirstLetters;
            this.Active = active;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.Namespace = @namespace;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DBUserCredential" /> class.
        /// </summary>
        public DBUserCredential()
        {
        }

    }
}