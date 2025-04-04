#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Get the shards status of an Object class<br/>
        /// Get the status of every shard in the cluster.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="tenant"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.ShardStatusGetResponse>> SchemaObjectsShardsGetAsync(
            string className,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}