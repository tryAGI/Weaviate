namespace Weaviate.IntegrationTests;

/// <summary>
/// Calls against the operations the 1.41 spec added, which the 1.29 one did not have.
/// </summary>
/// <remarks>
/// Switching the spec source took this SDK from 68 operations to 131, and
/// <see cref="Tests"/>'s other response-shape probes all predate that: they prove the switch caused
/// no regression, not that any of the 63 new operations works. These are the other half.
///
/// Everything here runs against the Testcontainers instance, so it costs nothing and needs no key.
/// That bounds what can be covered: the replication, rebalance, namespace-lifecycle, backup, export
/// and user-management writes all need a cluster, a configured backend or an authenticated admin
/// identity that a single bare node does not have, so they stay uncovered. What is reachable is
/// every new read that a fresh node answers, the new tokenizer endpoint, and - because
/// <c>SearchResponse</c> is by far the largest model the switch introduced - one real BM25 search
/// over a collection this test creates and removes.
/// </remarks>
public partial class Tests
{
    [TestMethod]
    public async Task Tokenize_Responds()
    {
        // A pure function of its input: no collection, no state, nothing to clean up.
        var response = await Client.Tokenize.TokenizeAsync(new TokenizeRequest
        {
            Text = "Weaviate tokenizes this sentence",
            Tokenization = TokenizeRequestTokenization.Word,
        });

        response.Should().NotBeNull();
        // The response splits the same text two ways: the tokens that would be written to the
        // inverted index, and the tokens a query would be matched with.
        response.Indexed.Should().NotBeNullOrEmpty();
        response.Query.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task Aliases_List_Deserializes()
    {
        var aliases = await Client.Schema.AliasesGetAsync();

        aliases.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Namespaces_List_IsRefusedByACommunityNode()
    {
        // Namespaces are gated twice upstream - once on `NAMESPACES_ENABLED` and again on a
        // licence (`setupNamespacesUnlicensedHandlers` in `handlers_namespaces_gate.go`) - so the
        // community image cannot answer this endpoint however it is configured. The refusal is
        // still worth asserting: it is the generated request path and `ErrorResponse` being
        // exercised end to end, and it pins the reason this surface has no happy-path test.
        var call = async () => await Client.Namespaces.ListNamespacesAsync();

        var exception = await call.Should().ThrowAsync<ApiException<ErrorResponse>>();
        exception.Which.ResponseObject?.Error?.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task DbUsers_List_Deserializes()
    {
        // `DBUserInfo` is the model whose `"type": ["string", "null"]` properties made the whole
        // generation throw, so reading one back is the regression test for that patch.
        var users = await Client.Users.ListAllUsersAsync();

        users.Should().NotBeNull();
    }

    [TestMethod]
    public async Task ReplicationList_AnswersNotImplementedWithAnEmptyBody()
    {
        // Two facts, and the second is the interesting one.
        //
        // The endpoint is in the 1.41 spec but `semitechnologies/weaviate:latest` answers **501**:
        // the spec is a release candidate and replication is not implemented in the image, so this
        // surface cannot have a happy-path test here however the container is configured.
        //
        // Its body is **empty**, and that is what makes the typed call read like something else
        // entirely. The generated error path runs `ErrorResponse.FromJson("")`, which throws
        // `JsonException: The input does not contain any JSON tokens`. The status is not lost - the
        // generator catches that and still throws `ApiException<ErrorResponse>` carrying 501 - but
        // the message is the empty body rather than the reason phrase, so what surfaces is a JSON
        // error where the server said 501 plainly. A generator that skipped `FromJson` on an empty
        // body, and fell back to `ReasonPhrase` for the message, would read correctly; that change
        // touches every error path in every spec, so it is not made here.
        using var request = new HttpRequestMessage(
            HttpMethod.Get,
            // `BaseUri` has no trailing slash, so `new Uri(base, relative)` would drop its `/v1`
            // segment and probe a path the server never serves - it answers a JSON 404 there,
            // which looks like a different finding entirely.
            new Uri($"{Client.BaseUri!.AbsoluteUri.TrimEnd('/')}/replication/replicate/list"));
        request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(
            "Bearer", ApiKey);

        using var response = await Client.HttpClient.SendAsync(request);
        var body = await response.Content.ReadAsStringAsync();

        Assert.AreEqual(
            System.Net.HttpStatusCode.NotImplemented,
            response.StatusCode,
            "replication is answering something new - if it is a 2XX, this image now implements it "
            + "and the endpoint deserves a real test instead of this one.");
        Assert.AreEqual(0, body.Length, $"the error body is no longer empty: [{body}]");
    }

    [TestMethod]
    public async Task DistributedTasks_Deserialize()
    {
        var tasks = await Client.DistributedTasks.DistributedTasksGetAsync();

        tasks.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Bm25Search_Deserializes()
    {
        // BM25 is the one new search that a bare node can actually run: it scores on the inverted
        // index alone, where near-text and hybrid would need a vectorizer module this container has
        // no configuration for.
        var collection = $"Bm25Probe{Guid.NewGuid():N}";

        await Client.Schema.SchemaObjectsCreateAsync(new Class
        {
            Class1 = collection,
            Vectorizer = "none",
            Properties =
            [
                new Property { Name = "body", DataType = ["text"] },
            ],
        });

        try
        {
            await Client.Objects.ObjectsCreateAsync(new Object
            {
                Class = collection,
                Properties = new PropertySchema
                {
                    AdditionalProperties = { ["body"] = "a sentence about tokenizers and ranking" },
                },
            });

            var response = await Client.Search.SearchBm25Async(
                collection,
                new SearchBm25Request(
                    common: new SearchCommon { Limit = 10, ReturnProperties = ["body"] },
                    searchBm25RequestVariant2: new SearchBm25RequestVariant2 { Query = "tokenizers" }));

            response.Should().NotBeNull();
        }
        finally
        {
            await Client.Schema.SchemaObjectsDeleteAsync(collection);
        }
    }
}
