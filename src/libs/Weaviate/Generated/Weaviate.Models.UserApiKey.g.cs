
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserApiKey
    {
        /// <summary>
        /// The API key associated with the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apikey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Apikey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApiKey" /> class.
        /// </summary>
        /// <param name="apikey">
        /// The API key associated with the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserApiKey(
            string apikey)
        {
            this.Apikey = apikey ?? throw new global::System.ArgumentNullException(nameof(apikey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApiKey" /> class.
        /// </summary>
        public UserApiKey()
        {
        }

    }
}