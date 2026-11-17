#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// List aliases<br/>
        /// Retrieve a list of all aliases in the system. Results can be filtered by specifying a collection (class) name to get aliases for a specific collection only.
        /// </summary>
        /// <param name="class"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AliasResponse> AliasesGetAsync(
            string? @class = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List aliases<br/>
        /// Retrieve a list of all aliases in the system. Results can be filtered by specifying a collection (class) name to get aliases for a specific collection only.
        /// </summary>
        /// <param name="class"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.AliasResponse>> AliasesGetAsResponseAsync(
            string? @class = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}