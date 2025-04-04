#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Get a single class from the schema
        /// </summary>
        /// <param name="className"></param>
        /// <param name="consistency">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Class> SchemaObjectsGetAsync(
            string className,
            bool? consistency = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}