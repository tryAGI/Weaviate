
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.UserTypeInput? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.GroupType? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.UserTypeOutput? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.UserOwnInfo? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.Role>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.Role? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.DBUserInfo? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.DBUserInfoDbUserType? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.UserApiKey? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.DBUserCredential? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.DBUserCredentialStatus? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.UserExportResponse? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.DBUserCredential>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.UserImportRequest? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.UserImportResponse? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.UserImportResult>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.UserImportResult? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.UserImportResultStatus? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.Permission>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.Permission? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PermissionBackups? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PermissionData? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PermissionNodes? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PermissionNodesVerbosity? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PermissionUsers? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PermissionGroups? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PermissionTenants? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PermissionRoles? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PermissionRolesScope? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PermissionCollections? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PermissionReplicate? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PermissionAliases? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PermissionNamespaces? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PermissionAction? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.Link? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.Principal? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.Vector? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weaviate.Vector>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.Deprecation? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ErrorResponse? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.ErrorResponseErrorItem>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ErrorResponseErrorItem? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.IndexStatusResponse? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.PropertyIndexStatus>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PropertyIndexStatus? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.IndexStatus>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.IndexStatus? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.IndexStatusType? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.IndexStatusStatus? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.IndexStatusAlgorithm? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.IndexStatusTargetAlgorithm? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.IndexUpsertRequest? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.IndexUpdateResponse? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.UsageLimitExceededResponse? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.UsageLimitExceededResponseErrorCode? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.UsageLimitExceededResponseLimit? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.RestrictionViolationResponse? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.RestrictionViolationResponseErrorItem>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.RestrictionViolationResponseErrorItem? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.RestrictionViolationResponseErrorCode? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.RestrictionViolationResponseRestriction? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ExportCreateRequest? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ExportCreateRequestFileFormat? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ExportCreateResponse? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ExportCreateResponseStatus? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ExportStatusResponse? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ExportStatusResponseStatus? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Weaviate.ShardProgress>>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weaviate.ShardProgress>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ShardProgress? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ShardProgressStatus? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.GraphQLError? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.GraphQLErrorLocation>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.GraphQLErrorLocation? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.GraphQLQuery? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.GraphQLQuery>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.GraphQLResponse? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weaviate.JsonObject>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.JsonObject? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.GraphQLError>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.GraphQLResponse>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.InvertedIndexConfig? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BM25Config? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.StopwordConfig? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.TokenizerUserDictConfig>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.TokenizerUserDictConfig? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationConfig? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationAsyncConfig? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationConfigDeletionStrategy? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.TokenizerUserDictConfigReplacement>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.TokenizerUserDictConfigReplacement? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.TokenizeRequest? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.TokenizeRequestTokenization? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.TextAnalyzerConfig? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.TokenizeResponse? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PropertyTokenizeRequest? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.MultiTenancyConfig? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ObjectTtlConfig? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.Meta? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.MetaLicense? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.SingleRef>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SingleRef? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationReplicateReplicaRequest? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationReplicateReplicaRequestType? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationReplicateReplicaResponse? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationShardingStateResponse? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationShardingState? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationScalePlan? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weaviate.ReplicationScalePlanShardScaleActions2>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationScalePlanShardScaleActions2? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationScaleApplyResponse? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationShardReplicas? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.ReplicationShardReplicas>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationReplicateDetailsReplicaStatusError? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationReplicateDetailsReplicaStatus? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationReplicateDetailsReplicaStatusState? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.ReplicationReplicateDetailsReplicaStatusError>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationReplicateDetailsReplicaResponse? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationReplicateDetailsReplicaResponseType? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.ReplicationReplicateDetailsReplicaStatus>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationReplicateForceDeleteRequest? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationReplicateForceDeleteResponse? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationRebalanceRequest? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationRebalanceCreateResponse? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationRebalancePlan? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationRebalancePlanState? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.ReplicationRebalancePlanNode>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationRebalancePlanNode? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.ReplicationRebalancePlanBaselineItem>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationRebalancePlanBaselineItem? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.ReplicationRebalancePlanDraftingItem>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationRebalancePlanDraftingItem? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReplicationRebalancePlanDraftingItemStatus? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PeerUpdate? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.VectorWeights? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PropertySchema? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.Schema? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.Class>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.Class? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Weaviate.VectorConfig>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.VectorConfig? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.Property>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.Property? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PropertyTokenization? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.NestedProperty>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.NestedProperty? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.NestedPropertyTokenization? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.ShardStatusGetResponse>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ShardStatusGetResponse? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ShardStatus? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BackupCreateStatusResponse? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BackupCreateStatusResponseStatus? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BackupRestoreStatusResponse? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BackupRestoreStatusResponseStatus? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BackupConfig? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BackupConfigCompressionLevel? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.RestoreConfig? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.RestoreConfigRolesOptions? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.RestoreConfigUsersOptions? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BackupCreateRequest? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BackupCreateResponse? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BackupCreateResponseStatus? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.BackupListResponseItem>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BackupListResponseItem? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BackupListResponseItemStatus? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BackupRestoreRequest? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BackupRestoreResponse? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BackupRestoreResponseStatus? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.NodeStats? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BatchStats? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.NodeShardStatus? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.AsyncReplicationStatus>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.AsyncReplicationStatus? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.NodeStatus? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.NodeStatusStatus? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.NodeShardStatus>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.NodeStatusOperationalMode? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.NodesStatusResponse? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.NodeStatus>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.DistributedTask? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.DistributedTaskUnit>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.DistributedTaskUnit? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Weaviate.DistributedTask>>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.DistributedTask>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.RaftStatistics? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.Statistics? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.StatisticsStatus? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ClusterStatisticsResponse? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.Statistics>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ReferenceMetaClassification? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BatchReference? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BatchReferenceResponse? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BatchReferenceResponseVariant2? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BatchReferenceResponseVariant2Result? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BatchReferenceResponseVariant2ResultStatus? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.GeoCoordinates? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.PhoneNumber? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ObjectsGetResponse? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ObjectsGetResponseVariant2? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.Deprecation>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ObjectsGetResponseVariant3? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ObjectsGetResponseVariant3Result? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ObjectsGetResponseVariant3ResultStatus? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BatchDelete? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BatchDeleteMatch? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.WhereFilter? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BatchDeleteResponse? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BatchDeleteResponseMatch? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BatchDeleteResponseResults? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.BatchDeleteResponseResultsObject>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BatchDeleteResponseResultsObject? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BatchDeleteResponseResultsObjectStatus? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ObjectsListResponse? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.Object>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.Classification? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ClassificationStatus? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ClassificationMeta? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.ClassificationFilters? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.WhereFilter>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.WhereFilterOperator? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<bool>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.WhereFilterGeoRange? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.WhereFilterGeoRangeDistance? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.Tenant? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.TenantActivityStatus? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.Alias? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.AliasResponse? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.Alias>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.Namespace? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.NamespaceState? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.NamespaceCreateRequest? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.NamespaceUpdateRequest? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.Namespace>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.AggregateRequest? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.AggregateResponse? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.AggregateGroup>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.AggregateGroup? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.AggregateGroupedBy? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchBm25Request? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchCommon? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchBm25RequestVariant2? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.SearchReferenceSelector>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchReferenceSelector? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.SearchCommonReturnMetadataItem>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchCommonReturnMetadataItem? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchCommonConsistencyLevel? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchRerank? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.SearchReferenceSelectorReturnMetadataItem>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchReferenceSelectorReturnMetadataItem? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchHybridRequest? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchHybridRequestVariant2? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchHybridRequestVariant2FusionType? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchNearObjectRequest? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchNearObjectRequestVariant2? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchNearTextRequest? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchNearTextRequestVariant2? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchNearVectorRequest? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchNearVectorRequestVariant2? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchResponse? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.SearchResultObject>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchResultObject? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchResultMetadata? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchResultReferenceMetadata? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchResultReference? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Weaviate.SearchResultReference>>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.SearchResultReference>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.CreateUserRequest? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.DeactivateUserRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SetUserExpirationRequest? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.AddPermissionsRequest? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.RemovePermissionsRequest? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.AssignRoleToUserRequest? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.RevokeRoleFromUserRequest? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.AssignRoleToGroupRequest? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.RevokeRoleFromGroupRequest? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BatchObjectsCreateRequest? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.BatchObjectsCreateRequestField>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BatchObjectsCreateRequestField? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.BatchReference>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.Tenant>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.AliasesUpdateRequest? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.GetRolesForUserUserType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.GetRolesForGroupGroupType? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.GetGroupsGroupType? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SchemaObjectsIndexUpsertIndexName? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SchemaObjectsPropertiesDeleteIndexName? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SchemaObjectsIndexRebuildIndexName? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SchemaObjectsIndexCancelIndexName? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.BackupsListOrder? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.WeaviateRootResponse? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.Link>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.GetWellKnownOpenidConfigurationResponse? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.ReplicationReplicateDetailsReplicaResponse>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.DBUserInfo>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.GetUsersForRoleResponseItem>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.GetUsersForRoleResponseItem? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.GetGroupsForRoleResponseItem>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.GetGroupsForRoleResponseItem? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.ObjectsGetResponse>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Weaviate.BatchReferenceResponse>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.McpPostResponse2? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.McpPostResponse3? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.McpDeleteResponse? Type318 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.Role>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.DBUserCredential>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.UserImportResult>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.Permission>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.ErrorResponseErrorItem>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.PropertyIndexStatus>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.IndexStatus>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.RestrictionViolationResponseErrorItem>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.GraphQLErrorLocation>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.GraphQLQuery>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.GraphQLError>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.GraphQLResponse>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.TokenizerUserDictConfig>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.TokenizerUserDictConfigReplacement>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.SingleRef>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.ReplicationShardReplicas>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.ReplicationReplicateDetailsReplicaStatusError>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.ReplicationReplicateDetailsReplicaStatus>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.ReplicationRebalancePlanNode>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.ReplicationRebalancePlanBaselineItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.ReplicationRebalancePlanDraftingItem>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.Class>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.Property>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.NestedProperty>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.ShardStatusGetResponse>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.BackupListResponseItem>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.AsyncReplicationStatus>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.NodeShardStatus>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.NodeStatus>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.DistributedTaskUnit>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Weaviate.DistributedTask>>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.DistributedTask>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.Statistics>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.Deprecation>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.BatchDeleteResponseResultsObject>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.Object>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.WhereFilter>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<bool>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.Alias>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.Namespace>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.AggregateGroup>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.SearchReferenceSelector>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.SearchCommonReturnMetadataItem>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.SearchReferenceSelectorReturnMetadataItem>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.SearchResultObject>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Weaviate.SearchResultReference>>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.SearchResultReference>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.BatchObjectsCreateRequestField>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.BatchReference>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.Tenant>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.Link>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.ReplicationReplicateDetailsReplicaResponse>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.DBUserInfo>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.GetUsersForRoleResponseItem>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.GetGroupsForRoleResponseItem>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.ObjectsGetResponse>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Weaviate.BatchReferenceResponse>? ListType62 { get; set; }
    }
}