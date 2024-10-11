
#nullable enable

namespace Weaviate
{
    public partial class ObjectsClient
    {
        partial void PrepareObjectsClassReferencesDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string className,
            ref global::System.Guid id,
            ref string propertyName,
            ref global::Weaviate.ObjectsClassReferencesDeleteConsistencyLevel? consistencyLevel,
            ref string? tenant,
            global::Weaviate.SingleRef request);
        partial void PrepareObjectsClassReferencesDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string className,
            global::System.Guid id,
            string propertyName,
            global::Weaviate.ObjectsClassReferencesDeleteConsistencyLevel? consistencyLevel,
            string? tenant,
            global::Weaviate.SingleRef request);
        partial void ProcessObjectsClassReferencesDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessObjectsClassReferencesDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete a cross-reference.<br/>
        /// Delete the single reference that is given in the body from the list of references that this property has.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="propertyName"></param>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="tenant"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Weaviate.ErrorResponse> ObjectsClassReferencesDeleteAsync(
            string className,
            global::System.Guid id,
            string propertyName,
            global::Weaviate.SingleRef request,
            global::Weaviate.ObjectsClassReferencesDeleteConsistencyLevel? consistencyLevel = global::Weaviate.ObjectsClassReferencesDeleteConsistencyLevel.QUORUM,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareObjectsClassReferencesDeleteArguments(
                httpClient: _httpClient,
                className: ref className,
                id: ref id,
                propertyName: ref propertyName,
                consistencyLevel: ref consistencyLevel,
                tenant: ref tenant,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/objects/{className}/{id}/references/{propertyName}",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("consistency_level", consistencyLevel?.ToValueString()) 
                .AddOptionalParameter("tenant", tenant) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
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
            PrepareObjectsClassReferencesDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                className: className,
                id: id,
                propertyName: propertyName,
                consistencyLevel: consistencyLevel,
                tenant: tenant,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessObjectsClassReferencesDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessObjectsClassReferencesDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Weaviate.ErrorResponse), JsonSerializerContext) as global::Weaviate.ErrorResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Delete a cross-reference.<br/>
        /// Delete the single reference that is given in the body from the list of references that this property has.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="propertyName"></param>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="tenant"></param>
        /// <param name="class">
        /// If using a concept reference (rather than a direct reference), specify the desired class name here
        /// </param>
        /// <param name="schema">
        /// Names and values of an individual property. A returned response may also contain additional metadata, such as from classification or feature projection.
        /// </param>
        /// <param name="beacon">
        /// If using a direct reference, specify the URI to point to the cross-ref here. Should be in the form of weaviate://localhost/&lt;uuid&gt; for the example of a local cross-ref to an object
        /// </param>
        /// <param name="href">
        /// If using a direct reference, this read-only fields provides a link to the referenced resource. If 'origin' is globally configured, an absolute URI is shown - a relative URI otherwise.
        /// </param>
        /// <param name="classification">
        /// This meta field contains additional info about the classified reference property
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Weaviate.ErrorResponse> ObjectsClassReferencesDeleteAsync(
            string className,
            global::System.Guid id,
            string propertyName,
            global::Weaviate.ObjectsClassReferencesDeleteConsistencyLevel? consistencyLevel = global::Weaviate.ObjectsClassReferencesDeleteConsistencyLevel.QUORUM,
            string? tenant = default,
            string? @class = default,
            object? schema = default,
            string? beacon = default,
            string? href = default,
            global::Weaviate.ReferenceMetaClassification? classification = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Weaviate.SingleRef
            {
                Class = @class,
                Schema = schema,
                Beacon = beacon,
                Href = href,
                Classification = classification,
            };

            return await ObjectsClassReferencesDeleteAsync(
                className: className,
                id: id,
                propertyName: propertyName,
                consistencyLevel: consistencyLevel,
                tenant: tenant,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}