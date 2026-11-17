#nullable enable

namespace Weaviate
{
    public partial interface IAuthzClient
    {
        /// <summary>
        /// Revoke a role from a user<br/>
        /// Remove one or more roles from a user.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task RevokeRoleFromUserAsync(
            string id,

            global::Weaviate.RevokeRoleFromUserRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke a role from a user<br/>
        /// Remove one or more roles from a user.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> RevokeRoleFromUserAsResponseAsync(
            string id,

            global::Weaviate.RevokeRoleFromUserRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke a role from a user<br/>
        /// Remove one or more roles from a user.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roles">
        /// The roles to revoke from the specified user.
        /// </param>
        /// <param name="userType">
        /// The type of the user. `db` users are managed by Weaviate, `oidc` users are managed by an external OIDC provider.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RevokeRoleFromUserAsync(
            string id,
            global::System.Collections.Generic.IList<string>? roles = default,
            global::Weaviate.UserTypeInput? userType = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}