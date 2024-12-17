
#nullable enable

namespace Weaviate
{
    public partial class SchemaClient
    {
        partial void PrepareSchemaObjectsUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string className,
            global::Weaviate.Class request);
        partial void PrepareSchemaObjectsUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string className,
            global::Weaviate.Class request);
        partial void ProcessSchemaObjectsUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSchemaObjectsUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update settings of an existing schema class<br/>
        /// Add a property to an existing collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Weaviate.Class> SchemaObjectsUpdateAsync(
            string className,
            global::Weaviate.Class request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSchemaObjectsUpdateArguments(
                httpClient: HttpClient,
                className: ref className,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/schema/{className}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
            PrepareSchemaObjectsUpdateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                className: className,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSchemaObjectsUpdateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid update attempt
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::Weaviate.ErrorResponse? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::Weaviate.ErrorResponse.FromJson(__content_422, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::Weaviate.ErrorResponse.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Weaviate.ApiException<global::Weaviate.ErrorResponse>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unauthorized or invalid credentials.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::Weaviate.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Forbidden
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::Weaviate.ErrorResponse? __value_403 = null;
                if (ReadResponseAsString)
                {
                    __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = global::Weaviate.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = await global::Weaviate.ErrorResponse.FromJsonStreamAsync(__contentStream_403, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Weaviate.ApiException<global::Weaviate.ErrorResponse>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Class to be updated does not exist
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::Weaviate.ErrorResponse? __value_404 = null;
                if (ReadResponseAsString)
                {
                    __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = global::Weaviate.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = await global::Weaviate.ErrorResponse.FromJsonStreamAsync(__contentStream_404, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Weaviate.ApiException<global::Weaviate.ErrorResponse>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // An error has occurred while trying to fulfill the request. Most likely the ErrorResponse will contain more information about the error.
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::Weaviate.ErrorResponse? __value_500 = null;
                if (ReadResponseAsString)
                {
                    __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = global::Weaviate.ErrorResponse.FromJson(__content_500, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_500 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = await global::Weaviate.ErrorResponse.FromJsonStreamAsync(__contentStream_500, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Weaviate.ApiException<global::Weaviate.ErrorResponse>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessSchemaObjectsUpdateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Weaviate.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::Weaviate.Class.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Weaviate.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::Weaviate.Class.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Update settings of an existing schema class<br/>
        /// Add a property to an existing collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="class1">
        /// Name of the class (a.k.a. 'collection') (required). Multiple words should be concatenated in CamelCase, e.g. `ArticleAuthor`.
        /// </param>
        /// <param name="vectorConfig">
        /// Configure named vectors. Either use this field or `vectorizer`, `vectorIndexType`, and `vectorIndexConfig` fields. Available from `v1.24.0`.
        /// </param>
        /// <param name="vectorIndexType">
        /// Name of the vector index to use, eg. (HNSW)
        /// </param>
        /// <param name="vectorIndexConfig">
        /// Vector-index config, that is specific to the type of index selected in vectorIndexType
        /// </param>
        /// <param name="shardingConfig">
        /// Manage how the index should be sharded and distributed in the cluster
        /// </param>
        /// <param name="replicationConfig">
        /// Configure how replication is executed in a cluster
        /// </param>
        /// <param name="invertedIndexConfig">
        /// Configure the inverted index built into Weaviate (default: 60).
        /// </param>
        /// <param name="multiTenancyConfig">
        /// Configuration related to multi-tenancy within a class
        /// </param>
        /// <param name="vectorizer">
        /// Specify how the vectors for this class should be determined. The options are either 'none' - this means you have to import a vector with each object yourself - or the name of a module that provides vectorization capabilities, such as 'text2vec-contextionary'. If left empty, it will use the globally configured default which can itself either be 'none' or a specific module.
        /// </param>
        /// <param name="moduleConfig">
        /// Configuration specific to modules in a collection context.
        /// </param>
        /// <param name="description">
        /// Description of the collection for metadata purposes.
        /// </param>
        /// <param name="properties">
        /// Define properties of the collection.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Weaviate.Class> SchemaObjectsUpdateAsync(
            string className,
            string? class1 = default,
            global::System.Collections.Generic.Dictionary<string, global::Weaviate.VectorConfig>? vectorConfig = default,
            string? vectorIndexType = default,
            object? vectorIndexConfig = default,
            object? shardingConfig = default,
            global::Weaviate.ReplicationConfig? replicationConfig = default,
            global::Weaviate.InvertedIndexConfig? invertedIndexConfig = default,
            global::Weaviate.MultiTenancyConfig? multiTenancyConfig = default,
            string? vectorizer = default,
            object? moduleConfig = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Weaviate.Property>? properties = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Weaviate.Class
            {
                Class1 = class1,
                VectorConfig = vectorConfig,
                VectorIndexType = vectorIndexType,
                VectorIndexConfig = vectorIndexConfig,
                ShardingConfig = shardingConfig,
                ReplicationConfig = replicationConfig,
                InvertedIndexConfig = invertedIndexConfig,
                MultiTenancyConfig = multiTenancyConfig,
                Vectorizer = vectorizer,
                ModuleConfig = moduleConfig,
                Description = description,
                Properties = properties,
            };

            return await SchemaObjectsUpdateAsync(
                className: className,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}