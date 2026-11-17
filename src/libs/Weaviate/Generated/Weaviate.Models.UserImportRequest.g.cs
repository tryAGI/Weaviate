
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// A batch of database-user credentials to recreate on the target, bound to a single target namespace.
    /// </summary>
    public sealed partial class UserImportRequest
    {
        /// <summary>
        /// The target namespace every user in this request is created under. Required on namespace-enabled clusters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// The credential records to import. Only records with a strong (argon2id) secureHash are importable.
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
        /// Initializes a new instance of the <see cref="UserImportRequest" /> class.
        /// </summary>
        /// <param name="users">
        /// The credential records to import. Only records with a strong (argon2id) secureHash are importable.
        /// </param>
        /// <param name="namespace">
        /// The target namespace every user in this request is created under. Required on namespace-enabled clusters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserImportRequest(
            global::System.Collections.Generic.IList<global::Weaviate.DBUserCredential> users,
            string? @namespace)
        {
            this.Namespace = @namespace;
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserImportRequest" /> class.
        /// </summary>
        public UserImportRequest()
        {
        }

    }
}