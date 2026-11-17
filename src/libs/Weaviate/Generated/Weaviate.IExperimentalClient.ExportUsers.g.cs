#nullable enable

namespace Weaviate
{
    public partial interface IExperimentalClient
    {
        /// <summary>
        /// Export all database-user credentials<br/>
        /// Experimental: this endpoint may change or be removed without notice. Export every database (`db` user type) user's API-key credential for migration to another cluster. Strong-key users carry their argon2id key hash; imported/weak and revoked users are reported with a null hash and a status naming why they cannot be migrated. Root users only.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.UserExportResponse> ExportUsersAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export all database-user credentials<br/>
        /// Experimental: this endpoint may change or be removed without notice. Export every database (`db` user type) user's API-key credential for migration to another cluster. Strong-key users carry their argon2id key hash; imported/weak and revoked users are reported with a null hash and a status naming why they cannot be migrated. Root users only.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.UserExportResponse>> ExportUsersAsResponseAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}