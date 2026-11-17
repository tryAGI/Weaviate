
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Link
    {
        /// <summary>
        /// Target of the link.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// Relationship if both resources are related, e.g. 'next', 'previous', 'parent', etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rel")]
        public string? Rel { get; set; }

        /// <summary>
        /// Human readable name of the resource group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Weaviate documentation about this resource group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentationHref")]
        public string? DocumentationHref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Link" /> class.
        /// </summary>
        /// <param name="href">
        /// Target of the link.
        /// </param>
        /// <param name="rel">
        /// Relationship if both resources are related, e.g. 'next', 'previous', 'parent', etc.
        /// </param>
        /// <param name="name">
        /// Human readable name of the resource group.
        /// </param>
        /// <param name="documentationHref">
        /// Weaviate documentation about this resource group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Link(
            string? href,
            string? rel,
            string? name,
            string? documentationHref)
        {
            this.Href = href;
            this.Rel = rel;
            this.Name = name;
            this.DocumentationHref = documentationHref;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Link" /> class.
        /// </summary>
        public Link()
        {
        }

    }
}