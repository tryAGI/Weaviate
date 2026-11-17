
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetWellKnownOpenidConfigurationResponse
    {
        /// <summary>
        /// The OIDC issuer URL to redirect to for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// The OAuth Client ID configured for Weaviate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        /// The required OAuth scopes for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWellKnownOpenidConfigurationResponse" /> class.
        /// </summary>
        /// <param name="href">
        /// The OIDC issuer URL to redirect to for authentication.
        /// </param>
        /// <param name="clientId">
        /// The OAuth Client ID configured for Weaviate.
        /// </param>
        /// <param name="scopes">
        /// The required OAuth scopes for authentication.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWellKnownOpenidConfigurationResponse(
            string? href,
            string? clientId,
            global::System.Collections.Generic.IList<string>? scopes)
        {
            this.Href = href;
            this.ClientId = clientId;
            this.Scopes = scopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWellKnownOpenidConfigurationResponse" /> class.
        /// </summary>
        public GetWellKnownOpenidConfigurationResponse()
        {
        }

    }
}