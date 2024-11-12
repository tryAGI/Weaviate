#nullable enable

namespace Weaviate
{
    public partial interface IWellKnownClient
    {
        /// <summary>
        /// Get application liveness.<br/>
        /// Determines whether the application is alive. Can be used for kubernetes liveness probe
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task WeaviateWellknownLivenessAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}