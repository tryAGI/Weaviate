#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Request body for the bm25 search endpoint. Performs a keyword (BM25F) search over the collection's searchable text properties and returns the best-scoring objects. Extends the shared search fields (`SearchCommon`) with the bm25-specific `query` and `queryProperties`.
    /// </summary>
    public readonly partial struct SearchBm25Request : global::System.IEquatable<SearchBm25Request>
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
        public global::Weaviate.SearchBm25RequestVariant2? SearchBm25RequestVariant2 { get; init; }
#else
        public global::Weaviate.SearchBm25RequestVariant2? SearchBm25RequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchBm25RequestVariant2))]
#endif
        public bool IsSearchBm25RequestVariant2 => SearchBm25RequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSearchBm25RequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Weaviate.SearchBm25RequestVariant2? value)
        {
            value = SearchBm25RequestVariant2;
            return IsSearchBm25RequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchBm25RequestVariant2 PickSearchBm25RequestVariant2() => SearchBm25RequestVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchBm25RequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchBm25Request(global::Weaviate.SearchCommon value) => new SearchBm25Request((global::Weaviate.SearchCommon?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Weaviate.SearchCommon?(SearchBm25Request @this) => @this.Common;

        /// <summary>
        ///
        /// </summary>
        public SearchBm25Request(global::Weaviate.SearchCommon? value)
        {
            Common = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchBm25Request FromCommon(global::Weaviate.SearchCommon? value) => new SearchBm25Request(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchBm25Request(global::Weaviate.SearchBm25RequestVariant2 value) => new SearchBm25Request((global::Weaviate.SearchBm25RequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Weaviate.SearchBm25RequestVariant2?(SearchBm25Request @this) => @this.SearchBm25RequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public SearchBm25Request(global::Weaviate.SearchBm25RequestVariant2? value)
        {
            SearchBm25RequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchBm25Request FromSearchBm25RequestVariant2(global::Weaviate.SearchBm25RequestVariant2? value) => new SearchBm25Request(value);

        /// <summary>
        ///
        /// </summary>
        public SearchBm25Request(
            global::Weaviate.SearchCommon? common,
            global::Weaviate.SearchBm25RequestVariant2? searchBm25RequestVariant2
            )
        {
            Common = common;
            SearchBm25RequestVariant2 = searchBm25RequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SearchBm25RequestVariant2 as object ??
            Common as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Common?.ToString() ??
            SearchBm25RequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCommon && IsSearchBm25RequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Weaviate.SearchCommon, TResult>? common = null,
            global::System.Func<global::Weaviate.SearchBm25RequestVariant2, TResult>? searchBm25RequestVariant2 = null,
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
            else if (SearchBm25RequestVariant2 is { } __value1 && searchBm25RequestVariant2 != null)
            {
                return searchBm25RequestVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Weaviate.SearchCommon>? common = null,

            global::System.Action<global::Weaviate.SearchBm25RequestVariant2>? searchBm25RequestVariant2 = null,
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
            else if (SearchBm25RequestVariant2 is { } __value1)
            {
                searchBm25RequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Weaviate.SearchCommon>? common = null,
            global::System.Action<global::Weaviate.SearchBm25RequestVariant2>? searchBm25RequestVariant2 = null,
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
            else if (SearchBm25RequestVariant2 is { } __value1)
            {
                searchBm25RequestVariant2?.Invoke(__value1);
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
                SearchBm25RequestVariant2,
                typeof(global::Weaviate.SearchBm25RequestVariant2),
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
        public bool Equals(SearchBm25Request other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Weaviate.SearchCommon?>.Default.Equals(Common, other.Common) &&
                global::System.Collections.Generic.EqualityComparer<global::Weaviate.SearchBm25RequestVariant2?>.Default.Equals(SearchBm25RequestVariant2, other.SearchBm25RequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SearchBm25Request obj1, SearchBm25Request obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchBm25Request>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SearchBm25Request obj1, SearchBm25Request obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchBm25Request o && Equals(o);
        }
    }
}
