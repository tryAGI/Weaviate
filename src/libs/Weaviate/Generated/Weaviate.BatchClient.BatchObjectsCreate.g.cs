
#nullable enable

namespace Weaviate
{
    public partial class BatchClient
    {
        partial void PrepareBatchObjectsCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Weaviate.BatchObjectsCreateConsistencyLevel? consistencyLevel,
            global::Weaviate.BatchObjectsCreateRequest request);
        partial void PrepareBatchObjectsCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Weaviate.BatchObjectsCreateConsistencyLevel? consistencyLevel,
            global::Weaviate.BatchObjectsCreateRequest request);
        partial void ProcessBatchObjectsCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBatchObjectsCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Batch create new objects.<br/>
        /// Create new objects in bulk. &lt;br/&gt;&lt;br/&gt;Meta-data and schema values are validated. &lt;br/&gt;&lt;br/&gt;**Note: idempotence of `/batch/objects`**: &lt;br/&gt;`POST /batch/objects` is idempotent, and will overwrite any existing object given the same id.
        /// </summary>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.ObjectsGetResponse>> BatchObjectsCreateAsync(
            global::Weaviate.BatchObjectsCreateRequest request,
            global::Weaviate.BatchObjectsCreateConsistencyLevel? consistencyLevel = global::Weaviate.BatchObjectsCreateConsistencyLevel.QUORUM,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareBatchObjectsCreateArguments(
                httpClient: _httpClient,
                consistencyLevel: ref consistencyLevel,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/batch/objects",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("consistency_level", consistencyLevel?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareBatchObjectsCreateRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                consistencyLevel: consistencyLevel,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessBatchObjectsCreateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessBatchObjectsCreateResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::Weaviate.ObjectsGetResponse>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::Weaviate.ObjectsGetResponse> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Batch create new objects.<br/>
        /// Create new objects in bulk. &lt;br/&gt;&lt;br/&gt;Meta-data and schema values are validated. &lt;br/&gt;&lt;br/&gt;**Note: idempotence of `/batch/objects`**: &lt;br/&gt;`POST /batch/objects` is idempotent, and will overwrite any existing object given the same id.
        /// </summary>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="fields">
        /// Define which fields need to be returned. Default value is ALL
        /// </param>
        /// <param name="objects"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Weaviate.ObjectsGetResponse>> BatchObjectsCreateAsync(
            global::Weaviate.BatchObjectsCreateConsistencyLevel? consistencyLevel = global::Weaviate.BatchObjectsCreateConsistencyLevel.QUORUM,
            global::System.Collections.Generic.IList<global::Weaviate.BatchObjectsCreateRequestField>? fields = default,
            global::System.Collections.Generic.IList<global::Weaviate.Object>? objects = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Weaviate.BatchObjectsCreateRequest
            {
                Fields = fields,
                Objects = objects,
            };

            return await BatchObjectsCreateAsync(
                consistencyLevel: consistencyLevel,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}