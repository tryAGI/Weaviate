#nullable enable

namespace Weaviate
{
    public partial interface IGraphqlClient
    {
        /// <summary>
        /// Get a response based on GraphQL.<br/>
        /// Perform a batched GraphQL query
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.GraphQLResponse>> GraphqlBatchAsync(
            global::System.Collections.Generic.IList<global::Weaviate.GraphQLQuery> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}