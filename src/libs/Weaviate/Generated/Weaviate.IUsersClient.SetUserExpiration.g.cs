#nullable enable

namespace Weaviate
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Set a user's expiration<br/>
        /// Set or clear the time at which a database user's (`db` user type) API key stops authenticating. The body sets exactly one of `expiresAt`, which must be in the future, and `neverExpires`, which must be true and clears the expiry. Any other body answers 422, and so do the caller's own user, root users and static users. A node without a Weaviate license key answers 403, so an expired user can then only be deleted and re-created.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task SetUserExpirationAsync(
            string userId,

            global::Weaviate.SetUserExpirationRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a user's expiration<br/>
        /// Set or clear the time at which a database user's (`db` user type) API key stops authenticating. The body sets exactly one of `expiresAt`, which must be in the future, and `neverExpires`, which must be true and clears the expiry. Any other body answers 422, and so do the caller's own user, root users and static users. A node without a Weaviate license key answers 403, so an expired user can then only be deleted and re-created.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> SetUserExpirationAsResponseAsync(
            string userId,

            global::Weaviate.SetUserExpirationRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a user's expiration<br/>
        /// Set or clear the time at which a database user's (`db` user type) API key stops authenticating. The body sets exactly one of `expiresAt`, which must be in the future, and `neverExpires`, which must be true and clears the expiry. Any other body answers 422, and so do the caller's own user, root users and static users. A node without a Weaviate license key answers 403, so an expired user can then only be deleted and re-created.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="expiresAt">
        /// Date and time in ISO 8601 format, stored in UTC with millisecond precision, at which the user's API key stops authenticating. It must be in the future.
        /// </param>
        /// <param name="neverExpires">
        /// True clears the user's expiry, so the API key never expires. False answers 422.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SetUserExpirationAsync(
            string userId,
            global::System.DateTime? expiresAt = default,
            bool? neverExpires = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}