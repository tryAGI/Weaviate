#nullable enable

namespace Weaviate
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Replace cross-references.<br/>
        /// Replace **all** references in cross-reference property of an object.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="propertyName"></param>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="tenant"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ErrorResponse> ObjectsClassReferencesPutAsync(
            string className,
            global::System.Guid id,
            string propertyName,
            global::System.Collections.Generic.IList<global::Weaviate.SingleRef> request,
            global::Weaviate.ObjectsClassReferencesPutConsistencyLevel? consistencyLevel = default,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}