
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The outcome of importing a single database-user credential.
    /// </summary>
    public sealed partial class UserImportResult
    {
        /// <summary>
        /// The name (ID) of the user, without any namespace prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The outcome for this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.UserImportResultStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weaviate.UserImportResultStatus Status { get; set; }

        /// <summary>
        /// The reason, present only when status is 'error'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserImportResult" /> class.
        /// </summary>
        /// <param name="userId">
        /// The name (ID) of the user, without any namespace prefix.
        /// </param>
        /// <param name="status">
        /// The outcome for this user.
        /// </param>
        /// <param name="error">
        /// The reason, present only when status is 'error'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserImportResult(
            string userId,
            global::Weaviate.UserImportResultStatus status,
            string? error)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Status = status;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserImportResult" /> class.
        /// </summary>
        public UserImportResult()
        {
        }

    }
}