
#nullable enable

namespace Weaviate
{
    public partial class SchemaClient
    {
        partial void PrepareSchemaObjectsPropertiesAddArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string className,
            global::Weaviate.Property request);
        partial void PrepareSchemaObjectsPropertiesAddRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string className,
            global::Weaviate.Property request);
        partial void ProcessSchemaObjectsPropertiesAddResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSchemaObjectsPropertiesAddResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add a property.<br/>
        /// Add a property to an existing collection. &lt;br/&gt;&lt;br/&gt;If possible, we encourage you to create all required properties at collection creation time. Adding a property after collection creation can lead to [some indexing limitations](https://weaviate.io/developers/weaviate/config-refs/schema).
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Weaviate.Property> SchemaObjectsPropertiesAddAsync(
            string className,
            global::Weaviate.Property request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSchemaObjectsPropertiesAddArguments(
                httpClient: HttpClient,
                className: ref className,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/schema/{className}/properties",
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
            PrepareSchemaObjectsPropertiesAddRequest(
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
            ProcessSchemaObjectsPropertiesAddResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
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
            // Invalid property.
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
                ProcessSchemaObjectsPropertiesAddResponseContent(
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
                    global::Weaviate.Property.FromJson(__content, JsonSerializerContext) ??
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

                using var __responseStream = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                var __responseValue = await global::Weaviate.Property.FromJsonStreamAsync(__responseStream, JsonSerializerContext).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Add a property.<br/>
        /// Add a property to an existing collection. &lt;br/&gt;&lt;br/&gt;If possible, we encourage you to create all required properties at collection creation time. Adding a property after collection creation can lead to [some indexing limitations](https://weaviate.io/developers/weaviate/config-refs/schema).
        /// </summary>
        /// <param name="className"></param>
        /// <param name="dataType">
        /// Data type of the property. If it starts with a capital (for example Person), may be a reference to another type.
        /// </param>
        /// <param name="description">
        /// Description of the property for documentation purposes.
        /// </param>
        /// <param name="moduleConfig">
        /// Configuration specific to modules in a property context.
        /// </param>
        /// <param name="name">
        /// The name of the property. Multiple words should be concatenated in camelCase, e.g. `nameOfAuthor`.
        /// </param>
        /// <param name="indexInverted">
        /// (Deprecated) Whether to include this property in the inverted index. If `false`, this property cannot be used in `where` filters, `bm25` or `hybrid` search. &lt;br/&gt;&lt;br/&gt;Unrelated to vectorization behavior (deprecated as of v1.19; use indexFilterable or/and indexSearchable instead)<br/>
        /// Default Value: true
        /// </param>
        /// <param name="indexFilterable">
        /// Whether to include this property in the filterable, Roaring Bitmap index. If `false`, this property cannot be used in `where` filters. &lt;br/&gt;&lt;br/&gt;Unrelated to vectorization behavior.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="indexSearchable">
        /// Whether to include this property in the searchable, inverted index. Applicable only to properties of data type text and text[]. If `false`, this property cannot be used in `bm25` or `hybrid` searches. &lt;br/&gt;&lt;br/&gt;Unrelated to vectorization behavior.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="indexRangeFilters">
        /// Whether to include this property in the filterable, range-based Roaring Bitmap inverted index. Defaults to false. Provides better performance for range queries compared to filterable index in large datasets. Applicable only to properties of data type int, number, date.
        /// </param>
        /// <param name="tokenization">
        /// Set tokenization of the property as separate words or whole field. Applies to text and text[] data types.<br/>
        /// Default Value: word
        /// </param>
        /// <param name="nestedProperties">
        /// The properties of the nested object(s). Applies to object and object[] data types.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Weaviate.Property> SchemaObjectsPropertiesAddAsync(
            string className,
            global::System.Collections.Generic.IList<global::Weaviate.DataTypeItem> dataType,
            string name,
            string? description = default,
            global::Weaviate.PropertyModuleConfig? moduleConfig = default,
            bool? indexInverted = default,
            bool? indexFilterable = default,
            bool? indexSearchable = default,
            bool? indexRangeFilters = default,
            global::Weaviate.Tokenization? tokenization = default,
            global::System.Collections.Generic.IList<global::Weaviate.NestedProperty>? nestedProperties = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Weaviate.Property
            {
                DataType = dataType,
                Description = description,
                ModuleConfig = moduleConfig,
                Name = name,
                IndexInverted = indexInverted,
                IndexFilterable = indexFilterable,
                IndexSearchable = indexSearchable,
                IndexRangeFilters = indexRangeFilters,
                Tokenization = tokenization,
                NestedProperties = nestedProperties,
            };

            return await SchemaObjectsPropertiesAddAsync(
                className: className,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}