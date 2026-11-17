#nullable enable

namespace Weaviate
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Patch an object<br/>
        /// Updates specific properties of an existing data object using JSON merge patch semantics (RFC 7396). The object is identified by its collection name (`className`) and UUID (`id`). Only the fields provided in the request body are modified. Metadata and schema values are validated, and the object's `lastUpdateTimeUnix` is updated.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="consistencyLevel"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task ObjectsClassPatchAsync(
            string className,
            global::System.Guid id,

            global::Weaviate.Object request,
            string? consistencyLevel = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch an object<br/>
        /// Updates specific properties of an existing data object using JSON merge patch semantics (RFC 7396). The object is identified by its collection name (`className`) and UUID (`id`). Only the fields provided in the request body are modified. Metadata and schema values are validated, and the object's `lastUpdateTimeUnix` is updated.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="consistencyLevel"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> ObjectsClassPatchAsResponseAsync(
            string className,
            global::System.Guid id,

            global::Weaviate.Object request,
            string? consistencyLevel = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch an object<br/>
        /// Updates specific properties of an existing data object using JSON merge patch semantics (RFC 7396). The object is identified by its collection name (`className`) and UUID (`id`). Only the fields provided in the request body are modified. Metadata and schema values are validated, and the object's `lastUpdateTimeUnix` is updated.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="consistencyLevel"></param>
        /// <param name="class">
        /// Name of the collection (class) the object belongs to.
        /// </param>
        /// <param name="vectorWeights">
        /// Allow custom overrides of vector weights as math expressions. E.g. `pancake`: `7` will set the weight for the word pancake to 7 in the vectorization, whereas `w * 3` would triple the originally calculated word. This is an open object, with OpenAPI Specification 3.0 this will be more detailed. See Weaviate docs for more info. In the future this will become a key/value (string/string) object.
        /// </param>
        /// <param name="properties">
        /// Names and values of an individual property. A returned response may also contain additional metadata, such as from classification or feature projection.
        /// </param>
        /// <param name="requestId">
        /// The UUID of the object.
        /// </param>
        /// <param name="creationTimeUnix">
        /// (Response only) Timestamp of creation of this object in milliseconds since epoch UTC.
        /// </param>
        /// <param name="lastUpdateTimeUnix">
        /// (Response only) Timestamp of the last object update in milliseconds since epoch UTC.
        /// </param>
        /// <param name="vector">
        /// A vector representation of the object in the Contextionary. If provided at object creation, this wil take precedence over any vectorizer setting.
        /// </param>
        /// <param name="vectors">
        /// A map of named vectors for multi-vector representations.
        /// </param>
        /// <param name="tenant">
        /// The name of the tenant the object belongs to.
        /// </param>
        /// <param name="additional">
        /// (Response only) Additional meta information about a single object.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ObjectsClassPatchAsync(
            string className,
            global::System.Guid id,
            string? consistencyLevel = default,
            string? @class = default,
            global::Weaviate.VectorWeights? vectorWeights = default,
            global::Weaviate.PropertySchema? properties = default,
            global::System.Guid? requestId = default,
            long? creationTimeUnix = default,
            long? lastUpdateTimeUnix = default,
            global::System.Collections.Generic.IList<float>? vector = default,
            global::System.Collections.Generic.Dictionary<string, global::Weaviate.Vector>? vectors = default,
            string? tenant = default,
            global::System.Collections.Generic.Dictionary<string, object>? additional = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}