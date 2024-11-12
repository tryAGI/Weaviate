#nullable enable

namespace Weaviate
{
    public partial interface IRootClient
    {
        /// <summary>
        /// List available endpoints<br/>
        /// Get links to other endpoints to help discover the REST API
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.WeaviateRootResponse> WeaviateRootAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}