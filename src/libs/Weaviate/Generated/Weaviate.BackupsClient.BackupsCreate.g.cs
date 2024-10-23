
#nullable enable

namespace Weaviate
{
    public partial class BackupsClient
    {
        partial void PrepareBackupsCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string backend,
            global::Weaviate.BackupCreateRequest request);
        partial void PrepareBackupsCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string backend,
            global::Weaviate.BackupCreateRequest request);
        partial void ProcessBackupsCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBackupsCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Start a backup process<br/>
        /// Start creating a backup for a set of collections. &lt;br/&gt;&lt;br/&gt;Notes: &lt;br/&gt;- Weaviate uses gzip compression by default. &lt;br/&gt;- Weaviate stays usable while a backup process is ongoing.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Weaviate.BackupCreateResponse> BackupsCreateAsync(
            string backend,
            global::Weaviate.BackupCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareBackupsCreateArguments(
                httpClient: HttpClient,
                backend: ref backend,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/backups/{backend}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareBackupsCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                backend: backend,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessBackupsCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessBackupsCreateResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Weaviate.BackupCreateResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Start a backup process<br/>
        /// Start creating a backup for a set of collections. &lt;br/&gt;&lt;br/&gt;Notes: &lt;br/&gt;- Weaviate uses gzip compression by default. &lt;br/&gt;- Weaviate stays usable while a backup process is ongoing.
        /// </summary>
        /// <param name="backend"></param>
        /// <param name="id">
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </param>
        /// <param name="config">
        /// Backup custom configuration
        /// </param>
        /// <param name="include">
        /// List of collections to include in the backup creation process. If not set, all collections are included. Cannot be used together with `exclude`.
        /// </param>
        /// <param name="exclude">
        /// List of collections to exclude from the backup creation process. If not set, all collections are included. Cannot be used together with `include`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Weaviate.BackupCreateResponse> BackupsCreateAsync(
            string backend,
            string id,
            global::Weaviate.BackupConfig? config = default,
            global::System.Collections.Generic.IList<string>? include = default,
            global::System.Collections.Generic.IList<string>? exclude = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Weaviate.BackupCreateRequest
            {
                Id = id,
                Config = config,
                Include = include,
                Exclude = exclude,
            };

            return await BackupsCreateAsync(
                backend: backend,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}