#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Create a new alias<br/>
        /// Create a new alias mapping between an alias name and a collection (class). The alias acts as an alternative name for accessing the collection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Alias> AliasesCreateAsync(

            global::Weaviate.Alias request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new alias<br/>
        /// Create a new alias mapping between an alias name and a collection (class). The alias acts as an alternative name for accessing the collection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.Alias>> AliasesCreateAsResponseAsync(

            global::Weaviate.Alias request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new alias<br/>
        /// Create a new alias mapping between an alias name and a collection (class). The alias acts as an alternative name for accessing the collection.
        /// </summary>
        /// <param name="alias1">
        /// The unique name of the alias that serves as an alternative identifier for the collection.
        /// </param>
        /// <param name="class">
        /// The name of the collection (class) to which this alias is mapped.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Alias> AliasesCreateAsync(
            string? alias1 = default,
            string? @class = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}