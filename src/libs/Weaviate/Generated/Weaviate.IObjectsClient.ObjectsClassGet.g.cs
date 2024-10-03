#nullable enable

namespace Weaviate
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Get an object.<br/>
        /// Get a data object based on its collection and UUID. Also available as Websocket bus.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="include"></param>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="nodeName"></param>
        /// <param name="tenant"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Object> ObjectsClassGetAsync(
            string className,
            global::System.Guid id,
            string? include = default,
            global::Weaviate.ObjectsClassGetConsistencyLevel? consistencyLevel = global::Weaviate.ObjectsClassGetConsistencyLevel.QUORUM,
            string? nodeName = default,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}