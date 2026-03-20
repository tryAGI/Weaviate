#nullable enable

namespace Weaviate
{
    public partial interface IClassificationsClient
    {
        /// <summary>
        /// View previously created classification<br/>
        /// Get status, results and metadata of a previously created classification
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.Classification> ClassificationsGetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}