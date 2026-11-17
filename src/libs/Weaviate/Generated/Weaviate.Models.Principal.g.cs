
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Principal
    {
        /// <summary>
        /// The username that was extracted either from the authentication information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<string>? Groups { get; set; }

        /// <summary>
        /// The type of the user. `db` users are managed by Weaviate, `oidc` users are managed by an external OIDC provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.UserTypeInputJsonConverter))]
        public global::Weaviate.UserTypeInput? UserType { get; set; }

        /// <summary>
        /// The namespace this principal is bound to. Empty for global principals (e.g. static API keys).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// True for principals that operate across all namespaces (e.g. static API keys). Authoritative marker for operator-level principals; do not infer from an empty namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isGlobalOperator")]
        public bool? IsGlobalOperator { get; set; }

        /// <summary>
        /// This is true when the API key resolved to a DB user record, which covers a dynamic DB user's own key and an imported static key. A login through the static API key list leaves it false, even when a DB user shares its name, though both carry userType db.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDynamicDbUser")]
        public bool? IsDynamicDbUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Principal" /> class.
        /// </summary>
        /// <param name="username">
        /// The username that was extracted either from the authentication information
        /// </param>
        /// <param name="groups"></param>
        /// <param name="userType">
        /// The type of the user. `db` users are managed by Weaviate, `oidc` users are managed by an external OIDC provider.
        /// </param>
        /// <param name="namespace">
        /// The namespace this principal is bound to. Empty for global principals (e.g. static API keys).
        /// </param>
        /// <param name="isGlobalOperator">
        /// True for principals that operate across all namespaces (e.g. static API keys). Authoritative marker for operator-level principals; do not infer from an empty namespace.
        /// </param>
        /// <param name="isDynamicDbUser">
        /// This is true when the API key resolved to a DB user record, which covers a dynamic DB user's own key and an imported static key. A login through the static API key list leaves it false, even when a DB user shares its name, though both carry userType db.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Principal(
            string? username,
            global::System.Collections.Generic.IList<string>? groups,
            global::Weaviate.UserTypeInput? userType,
            string? @namespace,
            bool? isGlobalOperator,
            bool? isDynamicDbUser)
        {
            this.Username = username;
            this.Groups = groups;
            this.UserType = userType;
            this.Namespace = @namespace;
            this.IsGlobalOperator = isGlobalOperator;
            this.IsDynamicDbUser = isDynamicDbUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Principal" /> class.
        /// </summary>
        public Principal()
        {
        }

    }
}