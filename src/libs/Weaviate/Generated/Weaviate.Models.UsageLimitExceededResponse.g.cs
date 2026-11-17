
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Returned with HTTP 429 when a configured Weaviate usage limit (objects/collections/tenants/shards) is exceeded. The structured fields (`errorCode`, `limit`, `value`) are stable contract; the `message` text is operator-overridable via the `USAGE_LIMITS_ERROR_MESSAGE` template.
    /// </summary>
    public sealed partial class UsageLimitExceededResponse
    {
        /// <summary>
        /// Machine-stable identifier. Always `USAGE_LIMIT_EXCEEDED` for this response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.UsageLimitExceededResponseErrorCodeJsonConverter))]
        public global::Weaviate.UsageLimitExceededResponseErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// Which limit was hit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.UsageLimitExceededResponseLimitJsonConverter))]
        public global::Weaviate.UsageLimitExceededResponseLimit? Limit { get; set; }

        /// <summary>
        /// The configured threshold value (the cap, not the current count).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public long? Value { get; set; }

        /// <summary>
        /// Human-readable message rendered from the `USAGE_LIMITS_ERROR_MESSAGE` template with `{limit}` and `{value}` placeholders substituted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimitExceededResponse" /> class.
        /// </summary>
        /// <param name="errorCode">
        /// Machine-stable identifier. Always `USAGE_LIMIT_EXCEEDED` for this response.
        /// </param>
        /// <param name="limit">
        /// Which limit was hit.
        /// </param>
        /// <param name="value">
        /// The configured threshold value (the cap, not the current count).
        /// </param>
        /// <param name="message">
        /// Human-readable message rendered from the `USAGE_LIMITS_ERROR_MESSAGE` template with `{limit}` and `{value}` placeholders substituted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageLimitExceededResponse(
            global::Weaviate.UsageLimitExceededResponseErrorCode? errorCode,
            global::Weaviate.UsageLimitExceededResponseLimit? limit,
            long? value,
            string? message)
        {
            this.ErrorCode = errorCode;
            this.Limit = limit;
            this.Value = value;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimitExceededResponse" /> class.
        /// </summary>
        public UsageLimitExceededResponse()
        {
        }

    }
}