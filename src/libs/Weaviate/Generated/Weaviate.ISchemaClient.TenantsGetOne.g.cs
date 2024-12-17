#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Get a specific tenant<br/>
        /// get a specific tenant for the given class
        /// </summary>
        /// <param name="className"></param>
        /// <param name="tenantName"></param>
        /// <param name="consistency">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.TenantResponse> TenantsGetOneAsync(
            string className,
            string tenantName,
            bool? consistency = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}