
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeactivateUserRequest
    {
        /// <summary>
        /// Whether the API key should be revoked when deactivating the user.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoke_key")]
        public bool? RevokeKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateUserRequest" /> class.
        /// </summary>
        /// <param name="revokeKey">
        /// Whether the API key should be revoked when deactivating the user.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeactivateUserRequest(
            bool? revokeKey)
        {
            this.RevokeKey = revokeKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeactivateUserRequest" /> class.
        /// </summary>
        public DeactivateUserRequest()
        {
        }

    }
}