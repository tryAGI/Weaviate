
#nullable enable

namespace Weaviate
{
    public partial class AuthzClient
    {
        partial void PrepareAssignRoleToUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            global::Weaviate.AssignRoleToUserRequest request);
        partial void PrepareAssignRoleToUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            global::Weaviate.AssignRoleToUserRequest request);
        partial void ProcessAssignRoleToUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Assign a role to a user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AssignRoleToUserAsync(
            string id,
            global::Weaviate.AssignRoleToUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAssignRoleToUserArguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/authz/users/{id}/assign",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareAssignRoleToUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAssignRoleToUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
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
        }

        /// <summary>
        /// Assign a role to a user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roles">
        /// the roles that assigned to user
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task AssignRoleToUserAsync(
            string id,
            global::System.Collections.Generic.IList<string>? roles = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Weaviate.AssignRoleToUserRequest
            {
                Roles = roles,
            };

            await AssignRoleToUserAsync(
                id: id,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}