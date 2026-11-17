#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Request body for the near-text search endpoint. The query is vectorized server-side by the collection's vectorizer module and the closest objects are returned. Extends the shared search fields (`SearchCommon`) with the near-text-specific `query`, `certainty`, `distance` and `targetVector`.
    /// </summary>
    public readonly partial struct SearchNearTextRequest : global::System.IEquatable<SearchNearTextRequest>
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
        public global::Weaviate.SearchNearTextRequestVariant2? SearchNearTextRequestVariant2 { get; init; }
#else
        public global::Weaviate.SearchNearTextRequestVariant2? SearchNearTextRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchNearTextRequestVariant2))]
#endif
        public bool IsSearchNearTextRequestVariant2 => SearchNearTextRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSearchNearTextRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Weaviate.SearchNearTextRequestVariant2? value)
        {
            value = SearchNearTextRequestVariant2;
            return IsSearchNearTextRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchNearTextRequestVariant2 PickSearchNearTextRequestVariant2() => SearchNearTextRequestVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchNearTextRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchNearTextRequest(global::Weaviate.SearchCommon value) => new SearchNearTextRequest((global::Weaviate.SearchCommon?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Weaviate.SearchCommon?(SearchNearTextRequest @this) => @this.Common;

        /// <summary>
        ///
        /// </summary>
        public SearchNearTextRequest(global::Weaviate.SearchCommon? value)
        {
            Common = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchNearTextRequest FromCommon(global::Weaviate.SearchCommon? value) => new SearchNearTextRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchNearTextRequest(global::Weaviate.SearchNearTextRequestVariant2 value) => new SearchNearTextRequest((global::Weaviate.SearchNearTextRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Weaviate.SearchNearTextRequestVariant2?(SearchNearTextRequest @this) => @this.SearchNearTextRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public SearchNearTextRequest(global::Weaviate.SearchNearTextRequestVariant2? value)
        {
            SearchNearTextRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchNearTextRequest FromSearchNearTextRequestVariant2(global::Weaviate.SearchNearTextRequestVariant2? value) => new SearchNearTextRequest(value);

        /// <summary>
        ///
        /// </summary>
        public SearchNearTextRequest(
            global::Weaviate.SearchCommon? common,
            global::Weaviate.SearchNearTextRequestVariant2? searchNearTextRequestVariant2
            )
        {
            Common = common;
            SearchNearTextRequestVariant2 = searchNearTextRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SearchNearTextRequestVariant2 as object ??
            Common as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Common?.ToString() ??
            SearchNearTextRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCommon && IsSearchNearTextRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Weaviate.SearchCommon, TResult>? common = null,
            global::System.Func<global::Weaviate.SearchNearTextRequestVariant2, TResult>? searchNearTextRequestVariant2 = null,
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
            else if (SearchNearTextRequestVariant2 is { } __value1 && searchNearTextRequestVariant2 != null)
            {
                return searchNearTextRequestVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Weaviate.SearchCommon>? common = null,

            global::System.Action<global::Weaviate.SearchNearTextRequestVariant2>? searchNearTextRequestVariant2 = null,
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
            else if (SearchNearTextRequestVariant2 is { } __value1)
            {
                searchNearTextRequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Weaviate.SearchCommon>? common = null,
            global::System.Action<global::Weaviate.SearchNearTextRequestVariant2>? searchNearTextRequestVariant2 = null,
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
            else if (SearchNearTextRequestVariant2 is { } __value1)
            {
                searchNearTextRequestVariant2?.Invoke(__value1);
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
                SearchNearTextRequestVariant2,
                typeof(global::Weaviate.SearchNearTextRequestVariant2),
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
        public bool Equals(SearchNearTextRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Weaviate.SearchCommon?>.Default.Equals(Common, other.Common) &&
                global::System.Collections.Generic.EqualityComparer<global::Weaviate.SearchNearTextRequestVariant2?>.Default.Equals(SearchNearTextRequestVariant2, other.SearchNearTextRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SearchNearTextRequest obj1, SearchNearTextRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchNearTextRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SearchNearTextRequest obj1, SearchNearTextRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchNearTextRequest o && Equals(o);
        }
    }
}
