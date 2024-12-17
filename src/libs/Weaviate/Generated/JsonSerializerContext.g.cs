
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Weaviate.JsonConverters.PermissionNodesVerbosityJsonConverter),
            typeof(global::Weaviate.JsonConverters.PermissionNodesVerbosityNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.PermissionActionJsonConverter),
            typeof(global::Weaviate.JsonConverters.PermissionActionNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.ReplicationConfigDeletionStrategyJsonConverter),
            typeof(global::Weaviate.JsonConverters.ReplicationConfigDeletionStrategyNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.PatchDocumentObjectOpJsonConverter),
            typeof(global::Weaviate.JsonConverters.PatchDocumentObjectOpNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.PatchDocumentActionOpJsonConverter),
            typeof(global::Weaviate.JsonConverters.PatchDocumentActionOpNullableJsonConverter),
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
            typeof(global::Weaviate.JsonConverters.BackupCreateResponseStatusJsonConverter),
            typeof(global::Weaviate.JsonConverters.BackupCreateResponseStatusNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.BackupListResponseItemStatusJsonConverter),
            typeof(global::Weaviate.JsonConverters.BackupListResponseItemStatusNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.BackupRestoreResponseStatusJsonConverter),
            typeof(global::Weaviate.JsonConverters.BackupRestoreResponseStatusNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.NodeStatusStatusJsonConverter),
            typeof(global::Weaviate.JsonConverters.NodeStatusStatusNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.StatisticsStatusJsonConverter),
            typeof(global::Weaviate.JsonConverters.StatisticsStatusNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.BatchReferenceResponseVariant2ResultStatusJsonConverter),
            typeof(global::Weaviate.JsonConverters.BatchReferenceResponseVariant2ResultStatusNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.ObjectsGetResponseVariant3ResultStatusJsonConverter),
            typeof(global::Weaviate.JsonConverters.ObjectsGetResponseVariant3ResultStatusNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.WhereFilterOperatorJsonConverter),
            typeof(global::Weaviate.JsonConverters.WhereFilterOperatorNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.BatchDeleteResponseResultsObjectStatusJsonConverter),
            typeof(global::Weaviate.JsonConverters.BatchDeleteResponseResultsObjectStatusNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.ClassificationStatusJsonConverter),
            typeof(global::Weaviate.JsonConverters.ClassificationStatusNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.TenantActivityStatusJsonConverter),
            typeof(global::Weaviate.JsonConverters.TenantActivityStatusNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.BatchObjectsCreateRequestFieldJsonConverter),
            typeof(global::Weaviate.JsonConverters.BatchObjectsCreateRequestFieldNullableJsonConverter),
            typeof(global::Weaviate.JsonConverters.BatchReferenceResponseJsonConverter),
            typeof(global::Weaviate.JsonConverters.ObjectsGetResponseJsonConverter),
            typeof(global::Weaviate.JsonConverters.TenantResponseJsonConverter),
            typeof(global::Weaviate.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}