
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DBUserInfo
    {
        /// <summary>
        /// The roles associated with the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Roles { get; set; }

        /// <summary>
        /// The name (ID) of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Type of the returned user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbUserType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.DBUserInfoDbUserTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weaviate.DBUserInfoDbUserType DbUserType { get; set; }

        /// <summary>
        /// Activity status of the returned user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Date and time in ISO 8601 format: YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// First 3 letters of the associated API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyFirstLetters")]
        public string? ApiKeyFirstLetters { get; set; }

        /// <summary>
        /// Date and time in ISO 8601 format: YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUsedAt")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// Date and time in ISO 8601 format, in UTC, at which the user's API key stops authenticating. Absent means the key never expires. Expiry does not change `active`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The namespace this user is bound to. Only populated for callers with global-operator privileges; omitted otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DBUserInfo" /> class.
        /// </summary>
        /// <param name="roles">
        /// The roles associated with the user.
        /// </param>
        /// <param name="userId">
        /// The name (ID) of the user.
        /// </param>
        /// <param name="dbUserType">
        /// Type of the returned user.
        /// </param>
        /// <param name="active">
        /// Activity status of the returned user.
        /// </param>
        /// <param name="createdAt">
        /// Date and time in ISO 8601 format: YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="apiKeyFirstLetters">
        /// First 3 letters of the associated API key.
        /// </param>
        /// <param name="lastUsedAt">
        /// Date and time in ISO 8601 format: YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="expiresAt">
        /// Date and time in ISO 8601 format, in UTC, at which the user's API key stops authenticating. Absent means the key never expires. Expiry does not change `active`.
        /// </param>
        /// <param name="namespace">
        /// The namespace this user is bound to. Only populated for callers with global-operator privileges; omitted otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DBUserInfo(
            global::System.Collections.Generic.IList<string> roles,
            string userId,
            global::Weaviate.DBUserInfoDbUserType dbUserType,
            bool active,
            global::System.DateTime? createdAt,
            string? apiKeyFirstLetters,
            global::System.DateTime? lastUsedAt,
            global::System.DateTime? expiresAt,
            string? @namespace)
        {
            this.Roles = roles ?? throw new global::System.ArgumentNullException(nameof(roles));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.DbUserType = dbUserType;
            this.Active = active;
            this.CreatedAt = createdAt;
            this.ApiKeyFirstLetters = apiKeyFirstLetters;
            this.LastUsedAt = lastUsedAt;
            this.ExpiresAt = expiresAt;
            this.Namespace = @namespace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DBUserInfo" /> class.
        /// </summary>
        public DBUserInfo()
        {
        }

    }
}