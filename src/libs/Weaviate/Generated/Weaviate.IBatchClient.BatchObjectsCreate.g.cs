#nullable enable

namespace Weaviate
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Creates new Objects based on a Object template as a batch.<br/>
        /// Create new objects in bulk. &lt;br/&gt;&lt;br/&gt;Meta-data and schema values are validated. &lt;br/&gt;&lt;br/&gt;**Note: idempotence of `/batch/objects`**: &lt;br/&gt;`POST /batch/objects` is idempotent, and will overwrite any existing object given the same id.
        /// </summary>
        /// <param name="consistencyLevel"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.ObjectsGetResponse>> BatchObjectsCreateAsync(
            global::Weaviate.BatchObjectsCreateRequest request,
            string? consistencyLevel = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates new Objects based on a Object template as a batch.<br/>
        /// Create new objects in bulk. &lt;br/&gt;&lt;br/&gt;Meta-data and schema values are validated. &lt;br/&gt;&lt;br/&gt;**Note: idempotence of `/batch/objects`**: &lt;br/&gt;`POST /batch/objects` is idempotent, and will overwrite any existing object given the same id.
        /// </summary>
        /// <param name="consistencyLevel"></param>
        /// <param name="fields">
        /// Define which fields need to be returned. Default value is ALL
        /// </param>
        /// <param name="objects"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.ObjectsGetResponse>> BatchObjectsCreateAsync(
            string? consistencyLevel = default,
            global::System.Collections.Generic.IList<global::Weaviate.BatchObjectsCreateRequestField>? fields = default,
            global::System.Collections.Generic.IList<global::Weaviate.Object>? objects = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}