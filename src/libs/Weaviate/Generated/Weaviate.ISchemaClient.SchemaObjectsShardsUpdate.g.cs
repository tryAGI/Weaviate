#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Update a shard status<br/>
        /// Updates the status of a specific shard within a collection (e.g., sets it to `READY` or `READONLY`). This is typically used after resolving an underlying issue (like disk space) that caused a shard to become non-operational. There is also a convenience function in each client to set the status of all shards of a collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="shardName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ShardStatus> SchemaObjectsShardsUpdateAsync(
            string className,
            string shardName,

            global::Weaviate.ShardStatus request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a shard status<br/>
        /// Updates the status of a specific shard within a collection (e.g., sets it to `READY` or `READONLY`). This is typically used after resolving an underlying issue (like disk space) that caused a shard to become non-operational. There is also a convenience function in each client to set the status of all shards of a collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="shardName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.ShardStatus>> SchemaObjectsShardsUpdateAsResponseAsync(
            string className,
            string shardName,

            global::Weaviate.ShardStatus request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a shard status<br/>
        /// Updates the status of a specific shard within a collection (e.g., sets it to `READY` or `READONLY`). This is typically used after resolving an underlying issue (like disk space) that caused a shard to become non-operational. There is also a convenience function in each client to set the status of all shards of a collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="shardName"></param>
        /// <param name="status">
        /// Status of the shard
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ShardStatus> SchemaObjectsShardsUpdateAsync(
            string className,
            string shardName,
            string? status = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}