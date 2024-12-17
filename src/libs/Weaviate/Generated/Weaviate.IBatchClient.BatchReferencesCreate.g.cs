#nullable enable

namespace Weaviate
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Creates new Cross-References between arbitrary classes in bulk.<br/>
        /// Batch create cross-references between collections items (objects or objects) in bulk.
        /// </summary>
        /// <param name="consistencyLevel"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.BatchReferenceResponse>> BatchReferencesCreateAsync(
            global::System.Collections.Generic.IList<global::Weaviate.BatchReference> request,
            string? consistencyLevel = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}