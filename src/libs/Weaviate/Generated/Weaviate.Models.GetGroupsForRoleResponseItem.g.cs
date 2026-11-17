
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetGroupsForRoleResponseItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupId")]
        public string? GroupId { get; set; }

        /// <summary>
        /// If the group contains OIDC or database users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.GroupTypeJsonConverter))]
        public global::Weaviate.GroupType GroupType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGroupsForRoleResponseItem" /> class.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="groupType">
        /// If the group contains OIDC or database users.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetGroupsForRoleResponseItem(
            string? groupId,
            global::Weaviate.GroupType groupType)
        {
            this.GroupId = groupId;
            this.GroupType = groupType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGroupsForRoleResponseItem" /> class.
        /// </summary>
        public GetGroupsForRoleResponseItem()
        {
        }

    }
}