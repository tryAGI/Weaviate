#nullable enable

namespace Weaviate
{
    public partial interface IWellKnownClient
    {
        /// <summary>
        /// OIDC discovery information (if OIDC auth is enabled)<br/>
        /// OIDC Discovery page, redirects to the token issuer if one is configured
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Response> GetWellKnownOpenidConfigurationAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}