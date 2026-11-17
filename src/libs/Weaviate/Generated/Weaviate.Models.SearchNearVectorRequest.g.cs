#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Request body for the near-vector search endpoint. The caller supplies the query vector and the closest objects are returned. No query is vectorized — collections without a vectorizer module are fully searchable. Extends the shared search fields (`SearchCommon`) with the near-vector-specific `vector`, `certainty`, `distance` and `targetVector`.
    /// </summary>
    public readonly partial struct SearchNearVectorRequest : global::System.IEquatable<SearchNearVectorRequest>
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
        public global::Weaviate.SearchNearVectorRequestVariant2? SearchNearVectorRequestVariant2 { get; init; }
#else
        public global::Weaviate.SearchNearVectorRequestVariant2? SearchNearVectorRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchNearVectorRequestVariant2))]
#endif
        public bool IsSearchNearVectorRequestVariant2 => SearchNearVectorRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSearchNearVectorRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Weaviate.SearchNearVectorRequestVariant2? value)
        {
            value = SearchNearVectorRequestVariant2;
            return IsSearchNearVectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchNearVectorRequestVariant2 PickSearchNearVectorRequestVariant2() => SearchNearVectorRequestVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchNearVectorRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchNearVectorRequest(global::Weaviate.SearchCommon value) => new SearchNearVectorRequest((global::Weaviate.SearchCommon?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Weaviate.SearchCommon?(SearchNearVectorRequest @this) => @this.Common;

        /// <summary>
        ///
        /// </summary>
        public SearchNearVectorRequest(global::Weaviate.SearchCommon? value)
        {
            Common = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchNearVectorRequest FromCommon(global::Weaviate.SearchCommon? value) => new SearchNearVectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchNearVectorRequest(global::Weaviate.SearchNearVectorRequestVariant2 value) => new SearchNearVectorRequest((global::Weaviate.SearchNearVectorRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Weaviate.SearchNearVectorRequestVariant2?(SearchNearVectorRequest @this) => @this.SearchNearVectorRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public SearchNearVectorRequest(global::Weaviate.SearchNearVectorRequestVariant2? value)
        {
            SearchNearVectorRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchNearVectorRequest FromSearchNearVectorRequestVariant2(global::Weaviate.SearchNearVectorRequestVariant2? value) => new SearchNearVectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public SearchNearVectorRequest(
            global::Weaviate.SearchCommon? common,
            global::Weaviate.SearchNearVectorRequestVariant2? searchNearVectorRequestVariant2
            )
        {
            Common = common;
            SearchNearVectorRequestVariant2 = searchNearVectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SearchNearVectorRequestVariant2 as object ??
            Common as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Common?.ToString() ??
            SearchNearVectorRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCommon && IsSearchNearVectorRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Weaviate.SearchCommon, TResult>? common = null,
            global::System.Func<global::Weaviate.SearchNearVectorRequestVariant2, TResult>? searchNearVectorRequestVariant2 = null,
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
            else if (SearchNearVectorRequestVariant2 is { } __value1 && searchNearVectorRequestVariant2 != null)
            {
                return searchNearVectorRequestVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Weaviate.SearchCommon>? common = null,

            global::System.Action<global::Weaviate.SearchNearVectorRequestVariant2>? searchNearVectorRequestVariant2 = null,
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
            else if (SearchNearVectorRequestVariant2 is { } __value1)
            {
                searchNearVectorRequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Weaviate.SearchCommon>? common = null,
            global::System.Action<global::Weaviate.SearchNearVectorRequestVariant2>? searchNearVectorRequestVariant2 = null,
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
            else if (SearchNearVectorRequestVariant2 is { } __value1)
            {
                searchNearVectorRequestVariant2?.Invoke(__value1);
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
                SearchNearVectorRequestVariant2,
                typeof(global::Weaviate.SearchNearVectorRequestVariant2),
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
        public bool Equals(SearchNearVectorRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Weaviate.SearchCommon?>.Default.Equals(Common, other.Common) &&
                global::System.Collections.Generic.EqualityComparer<global::Weaviate.SearchNearVectorRequestVariant2?>.Default.Equals(SearchNearVectorRequestVariant2, other.SearchNearVectorRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SearchNearVectorRequest obj1, SearchNearVectorRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchNearVectorRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SearchNearVectorRequest obj1, SearchNearVectorRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchNearVectorRequest o && Equals(o);
        }
    }
}
