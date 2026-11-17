#nullable enable

namespace Weaviate
{
    public partial interface IGraphqlClient
    {
        /// <summary>
        /// Perform a GraphQL query<br/>
        /// Executes a single GraphQL query provided in the request body. Use this endpoint for all Weaviate data queries and exploration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.GraphQLResponse> GraphqlPostAsync(

            global::Weaviate.GraphQLQuery request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Perform a GraphQL query<br/>
        /// Executes a single GraphQL query provided in the request body. Use this endpoint for all Weaviate data queries and exploration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.GraphQLResponse>> GraphqlPostAsResponseAsync(

            global::Weaviate.GraphQLQuery request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Perform a GraphQL query<br/>
        /// Executes a single GraphQL query provided in the request body. Use this endpoint for all Weaviate data queries and exploration.
        /// </summary>
        /// <param name="operationName">
        /// The name of the operation if multiple exist in the query.
        /// </param>
        /// <param name="query">
        /// Query based on GraphQL syntax.
        /// </param>
        /// <param name="variables">
        /// Additional variables for the query.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.GraphQLResponse> GraphqlPostAsync(
            string? operationName = default,
            string? query = default,
            object? variables = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}