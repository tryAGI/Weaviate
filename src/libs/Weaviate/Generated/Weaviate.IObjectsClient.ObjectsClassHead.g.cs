#nullable enable

namespace Weaviate
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Check if an object exists.<br/>
        /// Checks if a data object exists based on its collection and uuid without retrieving it. &lt;br/&gt;&lt;br/&gt;Internally it skips reading the object from disk other than checking if it is present. Thus it does not use resources on marshalling, parsing, etc., and is faster. Note the resulting HTTP request has no body; the existence of an object is indicated solely by the status code.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="tenant"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ErrorResponse> ObjectsClassHeadAsync(
            string className,
            global::System.Guid id,
            global::Weaviate.ObjectsClassHeadConsistencyLevel? consistencyLevel = global::Weaviate.ObjectsClassHeadConsistencyLevel.QUORUM,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}