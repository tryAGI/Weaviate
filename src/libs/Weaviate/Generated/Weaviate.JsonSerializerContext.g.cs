
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    #pragma warning disable CS3016 // Converter type array in this attribute is not CLS-compliant.
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Weaviate.JsonConverters.UserTypeInputJsonConverter),

            typeof(global::Weaviate.JsonConverters.UserTypeInputNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.GroupTypeJsonConverter),

            typeof(global::Weaviate.JsonConverters.GroupTypeNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.UserTypeOutputJsonConverter),

            typeof(global::Weaviate.JsonConverters.UserTypeOutputNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.DBUserInfoDbUserTypeJsonConverter),

            typeof(global::Weaviate.JsonConverters.DBUserInfoDbUserTypeNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.DBUserCredentialStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.DBUserCredentialStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.UserImportResultStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.UserImportResultStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.PermissionNodesVerbosityJsonConverter),

            typeof(global::Weaviate.JsonConverters.PermissionNodesVerbosityNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.PermissionRolesScopeJsonConverter),

            typeof(global::Weaviate.JsonConverters.PermissionRolesScopeNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.PermissionActionJsonConverter),

            typeof(global::Weaviate.JsonConverters.PermissionActionNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.IndexStatusTypeJsonConverter),

            typeof(global::Weaviate.JsonConverters.IndexStatusTypeNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.IndexStatusStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.IndexStatusStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.IndexStatusAlgorithmJsonConverter),

            typeof(global::Weaviate.JsonConverters.IndexStatusAlgorithmNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.IndexStatusTargetAlgorithmJsonConverter),

            typeof(global::Weaviate.JsonConverters.IndexStatusTargetAlgorithmNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.UsageLimitExceededResponseErrorCodeJsonConverter),

            typeof(global::Weaviate.JsonConverters.UsageLimitExceededResponseErrorCodeNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.UsageLimitExceededResponseLimitJsonConverter),

            typeof(global::Weaviate.JsonConverters.UsageLimitExceededResponseLimitNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.RestrictionViolationResponseErrorCodeJsonConverter),

            typeof(global::Weaviate.JsonConverters.RestrictionViolationResponseErrorCodeNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.RestrictionViolationResponseRestrictionJsonConverter),

            typeof(global::Weaviate.JsonConverters.RestrictionViolationResponseRestrictionNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.ExportCreateRequestFileFormatJsonConverter),

            typeof(global::Weaviate.JsonConverters.ExportCreateRequestFileFormatNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.ExportCreateResponseStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.ExportCreateResponseStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.ExportStatusResponseStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.ExportStatusResponseStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.ShardProgressStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.ShardProgressStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.ReplicationConfigDeletionStrategyJsonConverter),

            typeof(global::Weaviate.JsonConverters.ReplicationConfigDeletionStrategyNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.TokenizeRequestTokenizationJsonConverter),

            typeof(global::Weaviate.JsonConverters.TokenizeRequestTokenizationNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.ReplicationReplicateReplicaRequestTypeJsonConverter),

            typeof(global::Weaviate.JsonConverters.ReplicationReplicateReplicaRequestTypeNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.ReplicationReplicateDetailsReplicaStatusStateJsonConverter),

            typeof(global::Weaviate.JsonConverters.ReplicationReplicateDetailsReplicaStatusStateNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.ReplicationReplicateDetailsReplicaResponseTypeJsonConverter),

            typeof(global::Weaviate.JsonConverters.ReplicationReplicateDetailsReplicaResponseTypeNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.ReplicationRebalancePlanStateJsonConverter),

            typeof(global::Weaviate.JsonConverters.ReplicationRebalancePlanStateNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.ReplicationRebalancePlanDraftingItemStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.ReplicationRebalancePlanDraftingItemStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.PropertyTokenizationJsonConverter),

            typeof(global::Weaviate.JsonConverters.PropertyTokenizationNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.NestedPropertyTokenizationJsonConverter),

            typeof(global::Weaviate.JsonConverters.NestedPropertyTokenizationNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.BackupCreateStatusResponseStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.BackupCreateStatusResponseStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.BackupRestoreStatusResponseStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.BackupRestoreStatusResponseStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.BackupConfigCompressionLevelJsonConverter),

            typeof(global::Weaviate.JsonConverters.BackupConfigCompressionLevelNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.RestoreConfigRolesOptionsJsonConverter),

            typeof(global::Weaviate.JsonConverters.RestoreConfigRolesOptionsNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.RestoreConfigUsersOptionsJsonConverter),

            typeof(global::Weaviate.JsonConverters.RestoreConfigUsersOptionsNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.BackupCreateResponseStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.BackupCreateResponseStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.BackupListResponseItemStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.BackupListResponseItemStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.BackupRestoreResponseStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.BackupRestoreResponseStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.NodeStatusStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.NodeStatusStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.NodeStatusOperationalModeJsonConverter),

            typeof(global::Weaviate.JsonConverters.NodeStatusOperationalModeNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.StatisticsStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.StatisticsStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.BatchReferenceResponseVariant2ResultStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.BatchReferenceResponseVariant2ResultStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.ObjectsGetResponseVariant3ResultStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.ObjectsGetResponseVariant3ResultStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.BatchDeleteResponseResultsObjectStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.BatchDeleteResponseResultsObjectStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.ClassificationStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.ClassificationStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.WhereFilterOperatorJsonConverter),

            typeof(global::Weaviate.JsonConverters.WhereFilterOperatorNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.TenantActivityStatusJsonConverter),

            typeof(global::Weaviate.JsonConverters.TenantActivityStatusNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.NamespaceStateJsonConverter),

            typeof(global::Weaviate.JsonConverters.NamespaceStateNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.SearchCommonReturnMetadataItemJsonConverter),

            typeof(global::Weaviate.JsonConverters.SearchCommonReturnMetadataItemNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.SearchCommonConsistencyLevelJsonConverter),

            typeof(global::Weaviate.JsonConverters.SearchCommonConsistencyLevelNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.SearchReferenceSelectorReturnMetadataItemJsonConverter),

            typeof(global::Weaviate.JsonConverters.SearchReferenceSelectorReturnMetadataItemNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.SearchHybridRequestVariant2FusionTypeJsonConverter),

            typeof(global::Weaviate.JsonConverters.SearchHybridRequestVariant2FusionTypeNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.BatchObjectsCreateRequestFieldJsonConverter),

            typeof(global::Weaviate.JsonConverters.BatchObjectsCreateRequestFieldNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.GetRolesForUserUserTypeJsonConverter),

            typeof(global::Weaviate.JsonConverters.GetRolesForUserUserTypeNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.GetRolesForGroupGroupTypeJsonConverter),

            typeof(global::Weaviate.JsonConverters.GetRolesForGroupGroupTypeNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.GetGroupsGroupTypeJsonConverter),

            typeof(global::Weaviate.JsonConverters.GetGroupsGroupTypeNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.SchemaObjectsIndexUpsertIndexNameJsonConverter),

            typeof(global::Weaviate.JsonConverters.SchemaObjectsIndexUpsertIndexNameNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.SchemaObjectsPropertiesDeleteIndexNameJsonConverter),

            typeof(global::Weaviate.JsonConverters.SchemaObjectsPropertiesDeleteIndexNameNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.SchemaObjectsIndexRebuildIndexNameJsonConverter),

            typeof(global::Weaviate.JsonConverters.SchemaObjectsIndexRebuildIndexNameNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.SchemaObjectsIndexCancelIndexNameJsonConverter),

            typeof(global::Weaviate.JsonConverters.SchemaObjectsIndexCancelIndexNameNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.BackupsListOrderJsonConverter),

            typeof(global::Weaviate.JsonConverters.BackupsListOrderNullableJsonConverter),

            typeof(global::Weaviate.JsonConverters.BatchReferenceResponseJsonConverter),

            typeof(global::Weaviate.JsonConverters.ObjectsGetResponseJsonConverter),

            typeof(global::Weaviate.JsonConverters.SearchBm25RequestJsonConverter),

            typeof(global::Weaviate.JsonConverters.SearchHybridRequestJsonConverter),

            typeof(global::Weaviate.JsonConverters.SearchNearObjectRequestJsonConverter),

            typeof(global::Weaviate.JsonConverters.SearchNearTextRequestJsonConverter),

            typeof(global::Weaviate.JsonConverters.SearchNearVectorRequestJsonConverter),

            typeof(global::Weaviate.JsonConverters.UnixTimestampJsonConverter),
        })]
    #pragma warning restore CS3016
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "ListObject_System_Collections_Generic_List_object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UserTypeInput), TypeInfoPropertyName = "UserTypeInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.GroupType), TypeInfoPropertyName = "GroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UserTypeOutput), TypeInfoPropertyName = "UserTypeOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UserOwnInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.DBUserInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.DBUserInfoDbUserType), TypeInfoPropertyName = "DBUserInfoDbUserType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UserApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.DBUserCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.DBUserCredentialStatus), TypeInfoPropertyName = "DBUserCredentialStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UserExportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.DBUserCredential>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UserImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UserImportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.UserImportResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UserImportResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UserImportResultStatus), TypeInfoPropertyName = "UserImportResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Permission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Permission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PermissionBackups))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PermissionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PermissionNodes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PermissionNodesVerbosity), TypeInfoPropertyName = "PermissionNodesVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PermissionUsers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PermissionGroups))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PermissionTenants))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PermissionRoles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PermissionRolesScope), TypeInfoPropertyName = "PermissionRolesScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PermissionCollections))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PermissionReplicate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PermissionAliases))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PermissionNamespaces))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PermissionAction), TypeInfoPropertyName = "PermissionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Link))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Principal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Vector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weaviate.Vector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Deprecation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ErrorResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ErrorResponseErrorItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.PropertyIndexStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PropertyIndexStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.IndexStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatusType), TypeInfoPropertyName = "IndexStatusType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatusStatus), TypeInfoPropertyName = "IndexStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatusAlgorithm), TypeInfoPropertyName = "IndexStatusAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatusTargetAlgorithm), TypeInfoPropertyName = "IndexStatusTargetAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexUpsertRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UsageLimitExceededResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UsageLimitExceededResponseErrorCode), TypeInfoPropertyName = "UsageLimitExceededResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UsageLimitExceededResponseLimit), TypeInfoPropertyName = "UsageLimitExceededResponseLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RestrictionViolationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.RestrictionViolationResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RestrictionViolationResponseErrorItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RestrictionViolationResponseErrorCode), TypeInfoPropertyName = "RestrictionViolationResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RestrictionViolationResponseRestriction), TypeInfoPropertyName = "RestrictionViolationResponseRestriction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ExportCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ExportCreateRequestFileFormat), TypeInfoPropertyName = "ExportCreateRequestFileFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ExportCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ExportCreateResponseStatus), TypeInfoPropertyName = "ExportCreateResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ExportStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ExportStatusResponseStatus), TypeInfoPropertyName = "ExportStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Weaviate.ShardProgress>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weaviate.ShardProgress>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ShardProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ShardProgressStatus), TypeInfoPropertyName = "ShardProgressStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.GraphQLError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.GraphQLErrorLocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.GraphQLErrorLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.GraphQLQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.GraphQLQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.GraphQLResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weaviate.JsonObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.JsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.GraphQLError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.GraphQLResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.InvertedIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BM25Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.StopwordConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.TokenizerUserDictConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TokenizerUserDictConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationAsyncConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationConfigDeletionStrategy), TypeInfoPropertyName = "ReplicationConfigDeletionStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.TokenizerUserDictConfigReplacement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TokenizerUserDictConfigReplacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TokenizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TokenizeRequestTokenization), TypeInfoPropertyName = "TokenizeRequestTokenization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TextAnalyzerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TokenizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PropertyTokenizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.MultiTenancyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ObjectTtlConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Meta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.MetaLicense))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.SingleRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SingleRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateReplicaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateReplicaRequestType), TypeInfoPropertyName = "ReplicationReplicateReplicaRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateReplicaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationShardingStateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationShardingState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationScalePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weaviate.ReplicationScalePlanShardScaleActions2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationScalePlanShardScaleActions2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationScaleApplyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationShardReplicas))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ReplicationShardReplicas>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateDetailsReplicaStatusError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateDetailsReplicaStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateDetailsReplicaStatusState), TypeInfoPropertyName = "ReplicationReplicateDetailsReplicaStatusState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ReplicationReplicateDetailsReplicaStatusError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateDetailsReplicaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateDetailsReplicaResponseType), TypeInfoPropertyName = "ReplicationReplicateDetailsReplicaResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ReplicationReplicateDetailsReplicaStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateForceDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateForceDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationRebalanceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationRebalanceCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationRebalancePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationRebalancePlanState), TypeInfoPropertyName = "ReplicationRebalancePlanState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ReplicationRebalancePlanNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationRebalancePlanNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ReplicationRebalancePlanBaselineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationRebalancePlanBaselineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ReplicationRebalancePlanDraftingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationRebalancePlanDraftingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationRebalancePlanDraftingItemStatus), TypeInfoPropertyName = "ReplicationRebalancePlanDraftingItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PeerUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.VectorWeights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PropertySchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Schema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Class>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Class))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weaviate.VectorConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.VectorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Property>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Property))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PropertyTokenization), TypeInfoPropertyName = "PropertyTokenization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.NestedProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.NestedProperty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.NestedPropertyTokenization), TypeInfoPropertyName = "NestedPropertyTokenization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ShardStatusGetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ShardStatusGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ShardStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupCreateStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupCreateStatusResponseStatus), TypeInfoPropertyName = "BackupCreateStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupRestoreStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupRestoreStatusResponseStatus), TypeInfoPropertyName = "BackupRestoreStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupConfigCompressionLevel), TypeInfoPropertyName = "BackupConfigCompressionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RestoreConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RestoreConfigRolesOptions), TypeInfoPropertyName = "RestoreConfigRolesOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RestoreConfigUsersOptions), TypeInfoPropertyName = "RestoreConfigUsersOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupCreateResponseStatus), TypeInfoPropertyName = "BackupCreateResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.BackupListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupListResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupListResponseItemStatus), TypeInfoPropertyName = "BackupListResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupRestoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupRestoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupRestoreResponseStatus), TypeInfoPropertyName = "BackupRestoreResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.NodeStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.NodeShardStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.AsyncReplicationStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.AsyncReplicationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.NodeStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.NodeStatusStatus), TypeInfoPropertyName = "NodeStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.NodeShardStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.NodeStatusOperationalMode), TypeInfoPropertyName = "NodeStatusOperationalMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.NodesStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.NodeStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.DistributedTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.DistributedTaskUnit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.DistributedTaskUnit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Weaviate.DistributedTask>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.DistributedTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RaftStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Statistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.StatisticsStatus), TypeInfoPropertyName = "StatisticsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ClusterStatisticsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Statistics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReferenceMetaClassification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchReferenceResponse), TypeInfoPropertyName = "BatchReferenceResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchReferenceResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchReferenceResponseVariant2Result))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchReferenceResponseVariant2ResultStatus), TypeInfoPropertyName = "BatchReferenceResponseVariant2ResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.GeoCoordinates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Object), TypeInfoPropertyName = "Object_Weaviate_Object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ObjectsGetResponse), TypeInfoPropertyName = "ObjectsGetResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ObjectsGetResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Deprecation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ObjectsGetResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ObjectsGetResponseVariant3Result))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ObjectsGetResponseVariant3ResultStatus), TypeInfoPropertyName = "ObjectsGetResponseVariant3ResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchDeleteMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.WhereFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchDeleteResponseMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchDeleteResponseResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.BatchDeleteResponseResultsObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchDeleteResponseResultsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchDeleteResponseResultsObjectStatus), TypeInfoPropertyName = "BatchDeleteResponseResultsObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ObjectsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Classification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ClassificationStatus), TypeInfoPropertyName = "ClassificationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ClassificationMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ClassificationFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.WhereFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.WhereFilterOperator), TypeInfoPropertyName = "WhereFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.WhereFilterGeoRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.WhereFilterGeoRangeDistance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Tenant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TenantActivityStatus), TypeInfoPropertyName = "TenantActivityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Alias))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.AliasResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Alias>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Namespace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.NamespaceState), TypeInfoPropertyName = "NamespaceState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.NamespaceCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.NamespaceUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Namespace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.AggregateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.AggregateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.AggregateGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.AggregateGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.AggregateGroupedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchBm25Request), TypeInfoPropertyName = "SearchBm25Request2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchCommon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchBm25RequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.SearchReferenceSelector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchReferenceSelector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.SearchCommonReturnMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchCommonReturnMetadataItem), TypeInfoPropertyName = "SearchCommonReturnMetadataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchCommonConsistencyLevel), TypeInfoPropertyName = "SearchCommonConsistencyLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchRerank))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.SearchReferenceSelectorReturnMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchReferenceSelectorReturnMetadataItem), TypeInfoPropertyName = "SearchReferenceSelectorReturnMetadataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchHybridRequest), TypeInfoPropertyName = "SearchHybridRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchHybridRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchHybridRequestVariant2FusionType), TypeInfoPropertyName = "SearchHybridRequestVariant2FusionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchNearObjectRequest), TypeInfoPropertyName = "SearchNearObjectRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchNearObjectRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchNearTextRequest), TypeInfoPropertyName = "SearchNearTextRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchNearTextRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchNearVectorRequest), TypeInfoPropertyName = "SearchNearVectorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchNearVectorRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.SearchResultObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchResultObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchResultMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchResultReferenceMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchResultReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Weaviate.SearchResultReference>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.SearchResultReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.CreateUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.DeactivateUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SetUserExpirationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.AddPermissionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RemovePermissionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.AssignRoleToUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RevokeRoleFromUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.AssignRoleToGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RevokeRoleFromGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchObjectsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.BatchObjectsCreateRequestField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchObjectsCreateRequestField), TypeInfoPropertyName = "BatchObjectsCreateRequestField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.BatchReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Tenant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.AliasesUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.GetRolesForUserUserType), TypeInfoPropertyName = "GetRolesForUserUserType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.GetRolesForGroupGroupType), TypeInfoPropertyName = "GetRolesForGroupGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.GetGroupsGroupType), TypeInfoPropertyName = "GetGroupsGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SchemaObjectsIndexUpsertIndexName), TypeInfoPropertyName = "SchemaObjectsIndexUpsertIndexName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SchemaObjectsPropertiesDeleteIndexName), TypeInfoPropertyName = "SchemaObjectsPropertiesDeleteIndexName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SchemaObjectsIndexRebuildIndexName), TypeInfoPropertyName = "SchemaObjectsIndexRebuildIndexName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SchemaObjectsIndexCancelIndexName), TypeInfoPropertyName = "SchemaObjectsIndexCancelIndexName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupsListOrder), TypeInfoPropertyName = "BackupsListOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.WeaviateRootResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Link>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.GetWellKnownOpenidConfigurationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ReplicationReplicateDetailsReplicaResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.DBUserInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.GetUsersForRoleResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.GetUsersForRoleResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.GetGroupsForRoleResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.GetGroupsForRoleResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ObjectsGetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.BatchReferenceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.McpPostResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.McpPostResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.McpDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.DBUserCredential>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.UserImportResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Permission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ErrorResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.PropertyIndexStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.IndexStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.RestrictionViolationResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.GraphQLErrorLocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.GraphQLQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.GraphQLError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.GraphQLResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.TokenizerUserDictConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.TokenizerUserDictConfigReplacement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.SingleRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ReplicationShardReplicas>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ReplicationReplicateDetailsReplicaStatusError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ReplicationReplicateDetailsReplicaStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ReplicationRebalancePlanNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ReplicationRebalancePlanBaselineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ReplicationRebalancePlanDraftingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Class>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Property>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.NestedProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ShardStatusGetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.BackupListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.AsyncReplicationStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.NodeShardStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.NodeStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.DistributedTaskUnit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Weaviate.DistributedTask>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.DistributedTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Statistics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Deprecation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.BatchDeleteResponseResultsObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Object>), TypeInfoPropertyName = "ListObject_System_Collections_Generic_List_global_Weaviate_Object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.WhereFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Alias>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Namespace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.AggregateGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.SearchReferenceSelector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.SearchCommonReturnMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.SearchReferenceSelectorReturnMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.SearchResultObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Weaviate.SearchResultReference>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.SearchResultReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.BatchObjectsCreateRequestField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.BatchReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Tenant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Link>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ReplicationReplicateDetailsReplicaResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.DBUserInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.GetUsersForRoleResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.GetGroupsForRoleResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ObjectsGetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.BatchReferenceResponse>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}