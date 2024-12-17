#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// delete tenants from a specific class
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task TenantsDeleteAsync(
            string className,
            global::System.Collections.Generic.IList<string> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}