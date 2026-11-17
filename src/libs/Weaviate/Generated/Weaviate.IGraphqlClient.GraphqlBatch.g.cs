#nullable enable

namespace Weaviate
{
    public partial interface IGraphqlClient
    {
        /// <summary>
        /// Perform batched GraphQL queries<br/>
        /// Executes multiple GraphQL queries provided in the request body as an array. Allows performing several queries in a single network request for efficiency.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.GraphQLResponse>> GraphqlBatchAsync(

            global::System.Collections.Generic.IList<global::Weaviate.GraphQLQuery> request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Perform batched GraphQL queries<br/>
        /// Executes multiple GraphQL queries provided in the request body as an array. Allows performing several queries in a single network request for efficiency.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Weaviate.GraphQLResponse>>> GraphqlBatchAsResponseAsync(

            global::System.Collections.Generic.IList<global::Weaviate.GraphQLQuery> request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}