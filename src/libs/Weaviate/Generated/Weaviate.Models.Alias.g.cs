
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Represents the mapping between an alias name and a collection. An alias provides an alternative name for accessing a collection.
    /// </summary>
    public sealed partial class Alias
    {
        /// <summary>
        /// The unique name of the alias that serves as an alternative identifier for the collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias1 { get; set; }

        /// <summary>
        /// The name of the collection (class) to which this alias is mapped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        public string? Class { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Alias" /> class.
        /// </summary>
        /// <param name="alias1">
        /// The unique name of the alias that serves as an alternative identifier for the collection.
        /// </param>
        /// <param name="class">
        /// The name of the collection (class) to which this alias is mapped.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Alias(
            string? alias1,
            string? @class)
        {
            this.Alias1 = alias1;
            this.Class = @class;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Alias" /> class.
        /// </summary>
        public Alias()
        {
        }

    }
}