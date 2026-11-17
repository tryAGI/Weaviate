#nullable enable

namespace Weaviate
{
    public partial interface IWeaviateClient
    {
        /// <summary>
        /// Check application readiness<br/>
        /// Indicates if the Weaviate instance has completed its startup routines and is prepared to accept user traffic (data import, queries, etc.). Used for readiness checks, such as Kubernetes readiness probes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task WeaviateWellknownReadinessAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check application readiness<br/>
        /// Indicates if the Weaviate instance has completed its startup routines and is prepared to accept user traffic (data import, queries, etc.). Used for readiness checks, such as Kubernetes readiness probes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> WeaviateWellknownReadinessAsResponseAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}