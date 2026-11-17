#nullable enable

namespace Weaviate
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Replace object references<br/>
        /// Replaces all existing references for a specific reference property (`propertyName`) on a source data object. The source object is identified by its collection name (`className`) and UUID (`id`). The new set of references is provided in the request body.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="propertyName"></param>
        /// <param name="consistencyLevel"></param>
        /// <param name="tenant"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task ObjectsClassReferencesPutAsync(
            string className,
            global::System.Guid id,
            string propertyName,

            global::System.Collections.Generic.IList<global::Weaviate.SingleRef> request,
            string? consistencyLevel = default,
            string? tenant = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace object references<br/>
        /// Replaces all existing references for a specific reference property (`propertyName`) on a source data object. The source object is identified by its collection name (`className`) and UUID (`id`). The new set of references is provided in the request body.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="propertyName"></param>
        /// <param name="consistencyLevel"></param>
        /// <param name="tenant"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> ObjectsClassReferencesPutAsResponseAsync(
            string className,
            global::System.Guid id,
            string propertyName,

            global::System.Collections.Generic.IList<global::Weaviate.SingleRef> request,
            string? consistencyLevel = default,
            string? tenant = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}