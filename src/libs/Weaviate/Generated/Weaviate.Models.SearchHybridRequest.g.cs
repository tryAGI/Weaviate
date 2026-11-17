#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Request body for the hybrid search endpoint. Combines a keyword (BM25F) search and a vector search over the same query string, fusing both rankings into one result list. Extends the shared search fields (`SearchCommon`) with the hybrid-specific `query`, `alpha`, `fusionType`, `maxVectorDistance`, `queryProperties`, `targetVector` and `vector`.
    /// </summary>
    public readonly partial struct SearchHybridRequest : global::System.IEquatable<SearchHybridRequest>
    {
        /// <summary>
        /// Fields shared by every REST search request (near-text, bm25, hybrid, near-object). Unknown fields are ignored (platform parity with the other endpoints). Reserved fields are accepted by the schema but rejected by the server with 422 until the corresponding feature ships.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Weaviate.SearchCommon? Common { get; init; }
#else
        public global::Weaviate.SearchCommon? Common { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Common))]
#endif
        public bool IsCommon => Common != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCommon(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Weaviate.SearchCommon? value)
        {
            value = Common;
            return IsCommon;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchCommon PickCommon() => Common is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Common' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Weaviate.SearchHybridRequestVariant2? SearchHybridRequestVariant2 { get; init; }
#else
        public global::Weaviate.SearchHybridRequestVariant2? SearchHybridRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchHybridRequestVariant2))]
#endif
        public bool IsSearchHybridRequestVariant2 => SearchHybridRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSearchHybridRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Weaviate.SearchHybridRequestVariant2? value)
        {
            value = SearchHybridRequestVariant2;
            return IsSearchHybridRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchHybridRequestVariant2 PickSearchHybridRequestVariant2() => SearchHybridRequestVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchHybridRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchHybridRequest(global::Weaviate.SearchCommon value) => new SearchHybridRequest((global::Weaviate.SearchCommon?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Weaviate.SearchCommon?(SearchHybridRequest @this) => @this.Common;

        /// <summary>
        ///
        /// </summary>
        public SearchHybridRequest(global::Weaviate.SearchCommon? value)
        {
            Common = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchHybridRequest FromCommon(global::Weaviate.SearchCommon? value) => new SearchHybridRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchHybridRequest(global::Weaviate.SearchHybridRequestVariant2 value) => new SearchHybridRequest((global::Weaviate.SearchHybridRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Weaviate.SearchHybridRequestVariant2?(SearchHybridRequest @this) => @this.SearchHybridRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public SearchHybridRequest(global::Weaviate.SearchHybridRequestVariant2? value)
        {
            SearchHybridRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchHybridRequest FromSearchHybridRequestVariant2(global::Weaviate.SearchHybridRequestVariant2? value) => new SearchHybridRequest(value);

        /// <summary>
        ///
        /// </summary>
        public SearchHybridRequest(
            global::Weaviate.SearchCommon? common,
            global::Weaviate.SearchHybridRequestVariant2? searchHybridRequestVariant2
            )
        {
            Common = common;
            SearchHybridRequestVariant2 = searchHybridRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SearchHybridRequestVariant2 as object ??
            Common as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Common?.ToString() ??
            SearchHybridRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCommon && IsSearchHybridRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Weaviate.SearchCommon, TResult>? common = null,
            global::System.Func<global::Weaviate.SearchHybridRequestVariant2, TResult>? searchHybridRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Common is { } __value0 && common != null)
            {
                return common(__value0);
            }
            else if (SearchHybridRequestVariant2 is { } __value1 && searchHybridRequestVariant2 != null)
            {
                return searchHybridRequestVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Weaviate.SearchCommon>? common = null,

            global::System.Action<global::Weaviate.SearchHybridRequestVariant2>? searchHybridRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Common is { } __value0)
            {
                common?.Invoke(__value0);
            }
            else if (SearchHybridRequestVariant2 is { } __value1)
            {
                searchHybridRequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Weaviate.SearchCommon>? common = null,
            global::System.Action<global::Weaviate.SearchHybridRequestVariant2>? searchHybridRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Common is { } __value0)
            {
                common?.Invoke(__value0);
            }
            else if (SearchHybridRequestVariant2 is { } __value1)
            {
                searchHybridRequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Common,
                typeof(global::Weaviate.SearchCommon),
                SearchHybridRequestVariant2,
                typeof(global::Weaviate.SearchHybridRequestVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(SearchHybridRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Weaviate.SearchCommon?>.Default.Equals(Common, other.Common) &&
                global::System.Collections.Generic.EqualityComparer<global::Weaviate.SearchHybridRequestVariant2?>.Default.Equals(SearchHybridRequestVariant2, other.SearchHybridRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SearchHybridRequest obj1, SearchHybridRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchHybridRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SearchHybridRequest obj1, SearchHybridRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchHybridRequest o && Equals(o);
        }
    }
}
