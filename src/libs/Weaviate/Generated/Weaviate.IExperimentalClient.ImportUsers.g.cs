#nullable enable

namespace Weaviate
{
    public partial interface IExperimentalClient
    {
        /// <summary>
        /// Import database-user credentials<br/>
        /// Experimental: this endpoint may change or be removed without notice. Recreate exported database (`db` user type) user credentials on this cluster under a target namespace. Each user is created with its original key hash so the source key keeps working. Returns a per-user result. Only strong-key records are importable. Root users only.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.UserImportResponse> ImportUsersAsync(

            global::Weaviate.UserImportRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import database-user credentials<br/>
        /// Experimental: this endpoint may change or be removed without notice. Recreate exported database (`db` user type) user credentials on this cluster under a target namespace. Each user is created with its original key hash so the source key keeps working. Returns a per-user result. Only strong-key records are importable. Root users only.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.UserImportResponse>> ImportUsersAsResponseAsync(

            global::Weaviate.UserImportRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import database-user credentials<br/>
        /// Experimental: this endpoint may change or be removed without notice. Recreate exported database (`db` user type) user credentials on this cluster under a target namespace. Each user is created with its original key hash so the source key keeps working. Returns a per-user result. Only strong-key records are importable. Root users only.
        /// </summary>
        /// <param name="namespace">
        /// The target namespace every user in this request is created under. Required on namespace-enabled clusters.
        /// </param>
        /// <param name="users">
        /// The credential records to import. Only records with a strong (argon2id) secureHash are importable.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.UserImportResponse> ImportUsersAsync(
            global::System.Collections.Generic.IList<global::Weaviate.DBUserCredential> users,
            string? @namespace = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}