#nullable enable

namespace Weaviate
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Create a new user<br/>
        /// Create a new database (`db` user type) user with the specified name. Returns an API key for the newly created user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.UserApiKey> CreateUserAsync(
            string userId,

            global::Weaviate.CreateUserRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new user<br/>
        /// Create a new database (`db` user type) user with the specified name. Returns an API key for the newly created user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.UserApiKey>> CreateUserAsResponseAsync(
            string userId,

            global::Weaviate.CreateUserRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new user<br/>
        /// Create a new database (`db` user type) user with the specified name. Returns an API key for the newly created user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="import">
        /// EXPERIMENTAL, DONT USE. THIS WILL BE REMOVED AGAIN. - import api key from static user<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createTime">
        /// EXPERIMENTAL, DONT USE. THIS WILL BE REMOVED AGAIN. - set the given time as creation time
        /// </param>
        /// <param name="expiresAt">
        /// Date and time in ISO 8601 format at which the user's API key stops authenticating, stored in UTC with millisecond precision. It must be in the future. Setting it needs a Weaviate license key on the node, else the request answers 403. On a node with a license key, a request that also sets `import` to true answers 422. Absent means the key never expires.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.UserApiKey> CreateUserAsync(
            string userId,
            bool? import = default,
            global::System.DateTime? createTime = default,
            global::System.DateTime? expiresAt = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}