
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateUserRequest
    {
        /// <summary>
        /// EXPERIMENTAL, DONT USE. THIS WILL BE REMOVED AGAIN. - import api key from static user<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import")]
        public bool? Import { get; set; }

        /// <summary>
        /// EXPERIMENTAL, DONT USE. THIS WILL BE REMOVED AGAIN. - set the given time as creation time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Date and time in ISO 8601 format at which the user's API key stops authenticating, stored in UTC with millisecond precision. It must be in the future. Setting it needs a Weaviate license key on the node, else the request answers 403. On a node with a license key, a request that also sets `import` to true answers 422. Absent means the key never expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequest" /> class.
        /// </summary>
        /// <param name="import">
        /// EXPERIMENTAL, DONT USE. THIS WILL BE REMOVED AGAIN. - import api key from static user<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createTime">
        /// EXPERIMENTAL, DONT USE. THIS WILL BE REMOVED AGAIN. - set the given time as creation time
        /// </param>
        /// <param name="expiresAt">
        /// Date and time in ISO 8601 format at which the user's API key stops authenticating, stored in UTC with millisecond precision. It must be in the future. Setting it needs a Weaviate license key on the node, else the request answers 403. On a node with a license key, a request that also sets `import` to true answers 422. Absent means the key never expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateUserRequest(
            bool? import,
            global::System.DateTime? createTime,
            global::System.DateTime? expiresAt)
        {
            this.Import = import;
            this.CreateTime = createTime;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequest" /> class.
        /// </summary>
        public CreateUserRequest()
        {
        }

    }
}