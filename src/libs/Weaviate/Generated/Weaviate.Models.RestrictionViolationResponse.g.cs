
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Returned with HTTP 422 from class create/update endpoints. For restriction violations (operator-disallowed config via ALLOWED_VECTOR_INDEX_TYPES or ALLOWED_COMPRESSION_TYPES) the structured fields (`errorCode`, `restriction`, `value`, `allowed`, `message`) are populated; the `message` text is rendered from the operator-overridable `RESTRICTIONS_ERROR_MESSAGE` template. For unrelated 422 errors the `error` array is populated (matching the legacy ErrorResponse shape) and the structured fields are omitted.
    /// </summary>
    public sealed partial class RestrictionViolationResponse
    {
        /// <summary>
        /// Legacy ErrorResponse-style error list, populated for non-restriction 422 errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::System.Collections.Generic.IList<global::Weaviate.RestrictionViolationResponseErrorItem>? Error { get; set; }

        /// <summary>
        /// Machine-stable identifier. Set to `CONFIG_NOT_ALLOWED` for restriction violations; omitted otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.RestrictionViolationResponseErrorCodeJsonConverter))]
        public global::Weaviate.RestrictionViolationResponseErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// Which restriction was violated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restriction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.RestrictionViolationResponseRestrictionJsonConverter))]
        public global::Weaviate.RestrictionViolationResponseRestriction? Restriction { get; set; }

        /// <summary>
        /// The disallowed value the client submitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// The operator-configured allow-list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed")]
        public global::System.Collections.Generic.IList<string>? Allowed { get; set; }

        /// <summary>
        /// Human-readable message rendered from the `RESTRICTIONS_ERROR_MESSAGE` template with `{restriction}`, `{value}`, `{allowed}` placeholders substituted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionViolationResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Legacy ErrorResponse-style error list, populated for non-restriction 422 errors.
        /// </param>
        /// <param name="errorCode">
        /// Machine-stable identifier. Set to `CONFIG_NOT_ALLOWED` for restriction violations; omitted otherwise.
        /// </param>
        /// <param name="restriction">
        /// Which restriction was violated.
        /// </param>
        /// <param name="value">
        /// The disallowed value the client submitted.
        /// </param>
        /// <param name="allowed">
        /// The operator-configured allow-list.
        /// </param>
        /// <param name="message">
        /// Human-readable message rendered from the `RESTRICTIONS_ERROR_MESSAGE` template with `{restriction}`, `{value}`, `{allowed}` placeholders substituted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RestrictionViolationResponse(
            global::System.Collections.Generic.IList<global::Weaviate.RestrictionViolationResponseErrorItem>? error,
            global::Weaviate.RestrictionViolationResponseErrorCode? errorCode,
            global::Weaviate.RestrictionViolationResponseRestriction? restriction,
            string? value,
            global::System.Collections.Generic.IList<string>? allowed,
            string? message)
        {
            this.Error = error;
            this.ErrorCode = errorCode;
            this.Restriction = restriction;
            this.Value = value;
            this.Allowed = allowed;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionViolationResponse" /> class.
        /// </summary>
        public RestrictionViolationResponse()
        {
        }

    }
}