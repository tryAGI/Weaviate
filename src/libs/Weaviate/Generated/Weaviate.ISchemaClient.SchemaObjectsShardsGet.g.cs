#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Get the shards status of a collection<br/>
        /// Retrieves the status of all shards associated with the specified collection (`className`). For multi-tenant collections, use the `tenant` query parameter to retrieve status for a specific tenant's shards.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="tenant"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.ShardStatusGetResponse>> SchemaObjectsShardsGetAsync(
            string className,
            string? tenant = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the shards status of a collection<br/>
        /// Retrieves the status of all shards associated with the specified collection (`className`). For multi-tenant collections, use the `tenant` query parameter to retrieve status for a specific tenant's shards.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="tenant"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Weaviate.ShardStatusGetResponse>>> SchemaObjectsShardsGetAsResponseAsync(
            string className,
            string? tenant = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}