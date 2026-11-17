#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Get a specific tenant<br/>
        /// Retrieves details about a specific tenant within the given collection (`className`), such as its current activity status.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="tenantName"></param>
        /// <param name="consistency">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Tenant> TenantsGetOneAsync(
            string className,
            string tenantName,
            bool? consistency = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a specific tenant<br/>
        /// Retrieves details about a specific tenant within the given collection (`className`), such as its current activity status.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="tenantName"></param>
        /// <param name="consistency">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.Tenant>> TenantsGetOneAsResponseAsync(
            string className,
            string tenantName,
            bool? consistency = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}