#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Get the list of tenants.<br/>
        /// get all tenants from a specific class
        /// </summary>
        /// <param name="className"></param>
        /// <param name="consistency">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.Tenant>> TenantsGetAsync(
            string className,
            bool? consistency = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}