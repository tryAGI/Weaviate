#nullable enable

namespace Weaviate
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Delete an object<br/>
        /// Removes a data object from a specific collection, identified by its collection name (`className`) and UUID (`id`).&lt;br/&gt;&lt;br/&gt;**Note on deleting references (legacy format):**&lt;br/&gt;For backward compatibility with older beacon formats (lacking a collection name), deleting a reference requires the beacon in the request to exactly match the stored format. Beacons always use `localhost` as the host, indicating the target is within the same Weaviate instance.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="consistencyLevel"></param>
        /// <param name="tenant"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task ObjectsClassDeleteAsync(
            string className,
            global::System.Guid id,
            string? consistencyLevel = default,
            string? tenant = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an object<br/>
        /// Removes a data object from a specific collection, identified by its collection name (`className`) and UUID (`id`).&lt;br/&gt;&lt;br/&gt;**Note on deleting references (legacy format):**&lt;br/&gt;For backward compatibility with older beacon formats (lacking a collection name), deleting a reference requires the beacon in the request to exactly match the stored format. Beacons always use `localhost` as the host, indicating the target is within the same Weaviate instance.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="consistencyLevel"></param>
        /// <param name="tenant"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> ObjectsClassDeleteAsResponseAsync(
            string className,
            global::System.Guid id,
            string? consistencyLevel = default,
            string? tenant = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}