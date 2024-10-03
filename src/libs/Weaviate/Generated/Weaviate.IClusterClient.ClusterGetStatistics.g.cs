#nullable enable

namespace Weaviate
{
    public partial interface IClusterClient
    {
        /// <summary>
        /// See Raft cluster statistics<br/>
        /// Returns Raft cluster statistics of Weaviate DB.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.ClusterStatisticsResponse> ClusterGetStatisticsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}