#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Update a tenant.<br/>
        /// Update tenant of a specific class
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.Tenant>> TenantsUpdateAsync(
            string className,

            global::System.Collections.Generic.IList<global::Weaviate.Tenant> request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}