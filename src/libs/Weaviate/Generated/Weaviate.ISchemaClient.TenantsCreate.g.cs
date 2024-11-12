#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Create a new tenant<br/>
        /// Create a new tenant for a collection. Multi-tenancy must be enabled in the collection definition.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.Tenant>> TenantsCreateAsync(
            string className,
            global::System.Collections.Generic.IList<global::Weaviate.Tenant> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}