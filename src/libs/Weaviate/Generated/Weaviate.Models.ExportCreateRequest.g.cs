
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Request to create a new export operation
    /// </summary>
    public sealed partial class ExportCreateRequest
    {
        /// <summary>
        /// Unique identifier for this export. Must be URL-safe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Output file format for the export.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.ExportCreateRequestFileFormatJsonConverter))]
        public global::Weaviate.ExportCreateRequestFileFormat FileFormat { get; set; }

        /// <summary>
        /// List of collection names to include in the export. Cannot be used with 'exclude'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<string>? Include { get; set; }

        /// <summary>
        /// List of collection names to exclude from the export. Cannot be used with 'include'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<string>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportCreateRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this export. Must be URL-safe.
        /// </param>
        /// <param name="fileFormat">
        /// Output file format for the export.
        /// </param>
        /// <param name="include">
        /// List of collection names to include in the export. Cannot be used with 'exclude'.
        /// </param>
        /// <param name="exclude">
        /// List of collection names to exclude from the export. Cannot be used with 'include'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportCreateRequest(
            string id,
            global::Weaviate.ExportCreateRequestFileFormat fileFormat,
            global::System.Collections.Generic.IList<string>? include,
            global::System.Collections.Generic.IList<string>? exclude)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FileFormat = fileFormat;
            this.Include = include;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportCreateRequest" /> class.
        /// </summary>
        public ExportCreateRequest()
        {
        }

    }
}