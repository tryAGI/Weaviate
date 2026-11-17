#nullable enable

namespace Weaviate
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// MCP Streamable HTTP endpoint. Handles JSON-RPC requests for tool discovery and invocation. Every request is authenticated on its own; no Mcp-Session-Id is issued or required.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> McpPostAsStreamAsync(
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}