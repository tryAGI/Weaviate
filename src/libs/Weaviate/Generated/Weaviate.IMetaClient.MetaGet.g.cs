#nullable enable

namespace Weaviate
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// Get instance metadata.<br/>
        /// Returns meta information about the server. Can be used to provide information to another Weaviate instance that wants to interact with the current instance.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Meta> MetaGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}