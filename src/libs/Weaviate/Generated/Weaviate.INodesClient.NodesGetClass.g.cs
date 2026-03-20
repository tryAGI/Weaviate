#nullable enable

namespace Weaviate
{
    public partial interface INodesClient
    {
        /// <summary>
        /// Node information for a collection.<br/>
        /// Returns node information for the nodes relevant to the collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="output">
        /// Default Value: minimal
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.NodesStatusResponse> NodesGetClassAsync(
            string className,
            string? output = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}