#nullable enable

namespace Weaviate
{
    public partial interface IAuthzClient
    {
        /// <summary>
        /// Get roles assigned to a user<br/>
        /// Get all the roles for a specific user (`db` or `oidc`).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userType"></param>
        /// <param name="includeFullRoles">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.Role>> GetRolesForUserAsync(
            string id,
            global::Weaviate.GetRolesForUserUserType userType,
            bool? includeFullRoles = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get roles assigned to a user<br/>
        /// Get all the roles for a specific user (`db` or `oidc`).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userType"></param>
        /// <param name="includeFullRoles">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Weaviate.Role>>> GetRolesForUserAsResponseAsync(
            string id,
            global::Weaviate.GetRolesForUserUserType userType,
            bool? includeFullRoles = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}