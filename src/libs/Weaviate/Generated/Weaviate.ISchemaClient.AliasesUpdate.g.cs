#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Update an alias<br/>
        /// Update an existing alias to point to a different collection (class). This allows you to redirect an alias from one collection to another without changing the alias name.
        /// </summary>
        /// <param name="aliasName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Alias> AliasesUpdateAsync(
            string aliasName,

            global::Weaviate.AliasesUpdateRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an alias<br/>
        /// Update an existing alias to point to a different collection (class). This allows you to redirect an alias from one collection to another without changing the alias name.
        /// </summary>
        /// <param name="aliasName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.Alias>> AliasesUpdateAsResponseAsync(
            string aliasName,

            global::Weaviate.AliasesUpdateRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an alias<br/>
        /// Update an existing alias to point to a different collection (class). This allows you to redirect an alias from one collection to another without changing the alias name.
        /// </summary>
        /// <param name="aliasName"></param>
        /// <param name="class">
        /// The new collection (class) that the alias should point to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Alias> AliasesUpdateAsync(
            string aliasName,
            string? @class = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}