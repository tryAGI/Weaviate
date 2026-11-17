#nullable enable

namespace Weaviate
{
    public partial interface IAuthzClient
    {
        /// <summary>
        /// Revoke a role from a group<br/>
        /// Revoke roles from the specified group.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task RevokeRoleFromGroupAsync(
            string id,

            global::Weaviate.RevokeRoleFromGroupRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke a role from a group<br/>
        /// Revoke roles from the specified group.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse> RevokeRoleFromGroupAsResponseAsync(
            string id,

            global::Weaviate.RevokeRoleFromGroupRequest request,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke a role from a group<br/>
        /// Revoke roles from the specified group.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roles">
        /// The roles to revoke from the specified group.
        /// </param>
        /// <param name="groupType">
        /// If the group contains OIDC or database users.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RevokeRoleFromGroupAsync(
            string id,
            global::System.Collections.Generic.IList<string>? roles = default,
            global::Weaviate.GroupType? groupType = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}