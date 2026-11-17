#nullable enable

namespace Weaviate
{
    public partial interface IAuthzClient
    {
        /// <summary>
        /// Get roles assigned to a specific group<br/>
        /// Retrieves a list of all roles assigned to a specific group. The group must be identified by both its name (`id`) and its type (`db` or `oidc`).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="groupType"></param>
        /// <param name="includeFullRoles">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.Role>> GetRolesForGroupAsync(
            string id,
            global::Weaviate.GetRolesForGroupGroupType groupType,
            bool? includeFullRoles = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get roles assigned to a specific group<br/>
        /// Retrieves a list of all roles assigned to a specific group. The group must be identified by both its name (`id`) and its type (`db` or `oidc`).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="groupType"></param>
        /// <param name="includeFullRoles">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Weaviate.Role>>> GetRolesForGroupAsResponseAsync(
            string id,
            global::Weaviate.GetRolesForGroupGroupType groupType,
            bool? includeFullRoles = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}