#nullable enable

namespace Weaviate
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Declaratively create or migrate a property's inverted index<br/>
        /// Upserts the inverted index of a property, identified by `indexName`. The body describes the desired index configuration; the server diffs it against the current state and either creates the index, migrates its configuration, or does nothing. Index-mutating work is asynchronous: a `202` with a task ID is returned when a reindex task is submitted, and `200` with `{"status":"NO_OP"}` is returned when the desired configuration is already in place. `indexName` accepts `rangeable` as an alias for `rangeFilters`.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="propertyName"></param>
        /// <param name="indexName"></param>
        /// <param name="tenants"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.IndexUpdateResponse> SchemaObjectsIndexUpsertAsync(
            string className,
            string propertyName,
            global::Weaviate.SchemaObjectsIndexUpsertIndexName indexName,

            global::Weaviate.IndexUpsertRequest request,
            global::System.Collections.Generic.IList<string>? tenants = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Declaratively create or migrate a property's inverted index<br/>
        /// Upserts the inverted index of a property, identified by `indexName`. The body describes the desired index configuration; the server diffs it against the current state and either creates the index, migrates its configuration, or does nothing. Index-mutating work is asynchronous: a `202` with a task ID is returned when a reindex task is submitted, and `200` with `{"status":"NO_OP"}` is returned when the desired configuration is already in place. `indexName` accepts `rangeable` as an alias for `rangeFilters`.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="propertyName"></param>
        /// <param name="indexName"></param>
        /// <param name="tenants"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weaviate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.AutoSDKHttpResponse<global::Weaviate.IndexUpdateResponse>> SchemaObjectsIndexUpsertAsResponseAsync(
            string className,
            string propertyName,
            global::Weaviate.SchemaObjectsIndexUpsertIndexName indexName,

            global::Weaviate.IndexUpsertRequest request,
            global::System.Collections.Generic.IList<string>? tenants = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Declaratively create or migrate a property's inverted index<br/>
        /// Upserts the inverted index of a property, identified by `indexName`. The body describes the desired index configuration; the server diffs it against the current state and either creates the index, migrates its configuration, or does nothing. Index-mutating work is asynchronous: a `202` with a task ID is returned when a reindex task is submitted, and `200` with `{"status":"NO_OP"}` is returned when the desired configuration is already in place. `indexName` accepts `rangeable` as an alias for `rangeFilters`.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="propertyName"></param>
        /// <param name="indexName"></param>
        /// <param name="tenants"></param>
        /// <param name="tokenization">
        /// Target tokenization for a `searchable` or `filterable` index. Required when creating a `searchable` index; optional otherwise (omitted = keep the current value). On `filterable` creation it must be omitted or equal the property's current tokenization.
        /// </param>
        /// <param name="algorithm">
        /// Target BM25 algorithm for a `searchable` index. Only `blockmax` is a valid target (input aliases `block-max`, `block_max`, `blockmaxwand`, `bmw` are accepted case-insensitively). From WAND this triggers the Map → BlockMax migration; on an already-`blockmax` index it is a NO_OP. `wand` is rejected (deprecated); downgrade is intentionally not supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weaviate.IndexUpdateResponse> SchemaObjectsIndexUpsertAsync(
            string className,
            string propertyName,
            global::Weaviate.SchemaObjectsIndexUpsertIndexName indexName,
            global::System.Collections.Generic.IList<string>? tenants = default,
            string? tokenization = default,
            string? algorithm = default,
            global::Weaviate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}