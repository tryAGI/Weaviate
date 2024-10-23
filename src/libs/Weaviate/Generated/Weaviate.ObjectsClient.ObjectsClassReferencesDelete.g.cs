
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
                client: HttpClient);
            PrepareObjectsClassReferencesDeleteArguments(
                httpClient: HttpClient,
                className: ref className,
                id: ref id,
                propertyName: ref propertyName,
                consistencyLevel: ref consistencyLevel,
                tenant: ref tenant,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/objects/{className}/{id}/references/{propertyName}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("consistency_level", consistencyLevel?.ToValueString()) 
                .AddOptionalParameter("tenant", tenant) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
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
            PrepareObjectsClassReferencesDeleteRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                className: className,
                id: id,
                propertyName: propertyName,
                consistencyLevel: consistencyLevel,
                tenant: tenant,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessObjectsClassReferencesDeleteResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessObjectsClassReferencesDeleteResponseContent(
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
                global::Weaviate.ErrorResponse.FromJson(__content, JsonSerializerContext) ??
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
            var __request = new global::Weaviate.SingleRef
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
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}