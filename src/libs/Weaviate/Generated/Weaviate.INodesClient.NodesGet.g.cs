#nullable enable

namespace Weaviate
{
    public partial interface INodesClient
    {
        /// <summary>
        /// Node information for the database.<br/>
        /// Returns node information for the entire database.
        /// </summary>
        /// <param name="output">
        /// Default Value: minimal
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.NodesStatusResponse> NodesGetAsync(
            global::Weaviate.NodesGetOutput? output = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}