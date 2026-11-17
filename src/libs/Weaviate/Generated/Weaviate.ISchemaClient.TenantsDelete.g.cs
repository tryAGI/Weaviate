#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Delete tenants<br/>
        /// Deletes one or more specified tenants from a collection (`className`). WARNING: This action permanently deletes all data associated with the specified tenants.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task TenantsDeleteAsync(
            string className,

            global::System.Collections.Generic.IList<string> request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete tenants<br/>
        /// Deletes one or more specified tenants from a collection (`className`). WARNING: This action permanently deletes all data associated with the specified tenants.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> TenantsDeleteAsResponseAsync(
            string className,

            global::System.Collections.Generic.IList<string> request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}