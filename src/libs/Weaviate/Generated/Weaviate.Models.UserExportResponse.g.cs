
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The full set of database-user credential records on the source, one per user.
    /// </summary>
    public sealed partial class UserExportResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weaviate.DBUserCredential> Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserExportResponse" /> class.
        /// </summary>
        /// <param name="users"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserExportResponse(
            global::System.Collections.Generic.IList<global::Weaviate.DBUserCredential> users)
        {
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserExportResponse" /> class.
        /// </summary>
        public UserExportResponse()
        {
        }

    }
}