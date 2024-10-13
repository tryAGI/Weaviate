
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumber
    {
        /// <summary>
        /// The raw input as the phone number is present in your raw data set. It will be parsed into the standardized formats if valid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// Read-only. Parsed result in the international format (e.g. +49 123 ...)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internationalFormatted")]
        public string? InternationalFormatted { get; set; }

        /// <summary>
        /// Optional. The ISO 3166-1 alpha-2 country code. This is used to figure out the correct countryCode and international format if only a national number (e.g. 0123 4567) is provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultCountry")]
        public string? DefaultCountry { get; set; }

        /// <summary>
        /// Read-only. The numerical country code (e.g. 49)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countryCode")]
        public double? CountryCode { get; set; }

        /// <summary>
        /// Read-only. The numerical representation of the national part
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("national")]
        public double? National { get; set; }

        /// <summary>
        /// Read-only. Parsed result in the national format (e.g. 0123 456789)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nationalFormatted")]
        public string? NationalFormatted { get; set; }

        /// <summary>
        /// Read-only. Indicates whether the parsed number is a valid phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        public bool? Valid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        public static global::Weaviate.PhoneNumber? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Weaviate.PhoneNumber),
                jsonSerializerContext) as global::Weaviate.PhoneNumber;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Weaviate.PhoneNumber? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Weaviate.PhoneNumber>(
                json,
                jsonSerializerOptions);
        }

    }
}