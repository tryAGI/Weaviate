#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Remove an Object class (and all data in the instances) from the schema.<br/>
        /// Remove a collection from the schema. This will also delete all the objects in the collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task SchemaObjectsDeleteAsync(
            string className,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}