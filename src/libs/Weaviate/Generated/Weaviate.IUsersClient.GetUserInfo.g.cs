#nullable enable

namespace Weaviate
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get user info<br/>
        /// Retrieve detailed information about a specific database user (`db` user type), including their roles, status, and type.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="includeLastUsedTime">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.DBUserInfo> GetUserInfoAsync(
            string userId,
            bool? includeLastUsedTime = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user info<br/>
        /// Retrieve detailed information about a specific database user (`db` user type), including their roles, status, and type.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="includeLastUsedTime">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.DBUserInfo>> GetUserInfoAsResponseAsync(
            string userId,
            bool? includeLastUsedTime = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}