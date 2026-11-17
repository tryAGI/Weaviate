
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AliasesUpdateRequest
    {
        /// <summary>
        /// The new collection (class) that the alias should point to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        public string? Class { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasesUpdateRequest" /> class.
        /// </summary>
        /// <param name="class">
        /// The new collection (class) that the alias should point to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AliasesUpdateRequest(
            string? @class)
        {
            this.Class = @class;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasesUpdateRequest" /> class.
        /// </summary>
        public AliasesUpdateRequest()
        {
        }

    }
}