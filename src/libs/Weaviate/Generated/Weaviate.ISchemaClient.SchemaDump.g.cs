#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Dump the current the database schema.<br/>
        /// Fetch an array of all collection definitions from the schema.
        /// </summary>
        /// <param name="consistency">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Schema> SchemaDumpAsync(
            bool? consistency = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}