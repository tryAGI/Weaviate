
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SetUserExpirationRequest
    {
        /// <summary>
        /// Date and time in ISO 8601 format, stored in UTC with millisecond precision, at which the user's API key stops authenticating. It must be in the future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// True clears the user's expiry, so the API key never expires. False answers 422.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neverExpires")]
        public bool? NeverExpires { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetUserExpirationRequest" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// Date and time in ISO 8601 format, stored in UTC with millisecond precision, at which the user's API key stops authenticating. It must be in the future.
        /// </param>
        /// <param name="neverExpires">
        /// True clears the user's expiry, so the API key never expires. False answers 422.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetUserExpirationRequest(
            global::System.DateTime? expiresAt,
            bool? neverExpires)
        {
            this.ExpiresAt = expiresAt;
            this.NeverExpires = neverExpires;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetUserExpirationRequest" /> class.
        /// </summary>
        public SetUserExpirationRequest()
        {
        }

    }
}