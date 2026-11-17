#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Request body for the near-object search endpoint. The stored vector of an existing object (the source object, referenced by `id`) anchors the search and the closest objects are returned. No query is vectorized — collections without a vectorizer module are fully searchable. Extends the shared search fields (`SearchCommon`) with the near-object-specific `id`, `certainty`, `distance` and `targetVector`.
    /// </summary>
    public readonly partial struct SearchNearObjectRequest : global::System.IEquatable<SearchNearObjectRequest>
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
        public global::Weaviate.SearchNearObjectRequestVariant2? SearchNearObjectRequestVariant2 { get; init; }
#else
        public global::Weaviate.SearchNearObjectRequestVariant2? SearchNearObjectRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchNearObjectRequestVariant2))]
#endif
        public bool IsSearchNearObjectRequestVariant2 => SearchNearObjectRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSearchNearObjectRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Weaviate.SearchNearObjectRequestVariant2? value)
        {
            value = SearchNearObjectRequestVariant2;
            return IsSearchNearObjectRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Weaviate.SearchNearObjectRequestVariant2 PickSearchNearObjectRequestVariant2() => SearchNearObjectRequestVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchNearObjectRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchNearObjectRequest(global::Weaviate.SearchCommon value) => new SearchNearObjectRequest((global::Weaviate.SearchCommon?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Weaviate.SearchCommon?(SearchNearObjectRequest @this) => @this.Common;

        /// <summary>
        ///
        /// </summary>
        public SearchNearObjectRequest(global::Weaviate.SearchCommon? value)
        {
            Common = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchNearObjectRequest FromCommon(global::Weaviate.SearchCommon? value) => new SearchNearObjectRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SearchNearObjectRequest(global::Weaviate.SearchNearObjectRequestVariant2 value) => new SearchNearObjectRequest((global::Weaviate.SearchNearObjectRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Weaviate.SearchNearObjectRequestVariant2?(SearchNearObjectRequest @this) => @this.SearchNearObjectRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public SearchNearObjectRequest(global::Weaviate.SearchNearObjectRequestVariant2? value)
        {
            SearchNearObjectRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SearchNearObjectRequest FromSearchNearObjectRequestVariant2(global::Weaviate.SearchNearObjectRequestVariant2? value) => new SearchNearObjectRequest(value);

        /// <summary>
        ///
        /// </summary>
        public SearchNearObjectRequest(
            global::Weaviate.SearchCommon? common,
            global::Weaviate.SearchNearObjectRequestVariant2? searchNearObjectRequestVariant2
            )
        {
            Common = common;
            SearchNearObjectRequestVariant2 = searchNearObjectRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SearchNearObjectRequestVariant2 as object ??
            Common as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Common?.ToString() ??
            SearchNearObjectRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCommon && IsSearchNearObjectRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Weaviate.SearchCommon, TResult>? common = null,
            global::System.Func<global::Weaviate.SearchNearObjectRequestVariant2, TResult>? searchNearObjectRequestVariant2 = null,
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
            else if (SearchNearObjectRequestVariant2 is { } __value1 && searchNearObjectRequestVariant2 != null)
            {
                return searchNearObjectRequestVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Weaviate.SearchCommon>? common = null,

            global::System.Action<global::Weaviate.SearchNearObjectRequestVariant2>? searchNearObjectRequestVariant2 = null,
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
            else if (SearchNearObjectRequestVariant2 is { } __value1)
            {
                searchNearObjectRequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Weaviate.SearchCommon>? common = null,
            global::System.Action<global::Weaviate.SearchNearObjectRequestVariant2>? searchNearObjectRequestVariant2 = null,
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
            else if (SearchNearObjectRequestVariant2 is { } __value1)
            {
                searchNearObjectRequestVariant2?.Invoke(__value1);
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
                SearchNearObjectRequestVariant2,
                typeof(global::Weaviate.SearchNearObjectRequestVariant2),
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
        public bool Equals(SearchNearObjectRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Weaviate.SearchCommon?>.Default.Equals(Common, other.Common) &&
                global::System.Collections.Generic.EqualityComparer<global::Weaviate.SearchNearObjectRequestVariant2?>.Default.Equals(SearchNearObjectRequestVariant2, other.SearchNearObjectRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SearchNearObjectRequest obj1, SearchNearObjectRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchNearObjectRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SearchNearObjectRequest obj1, SearchNearObjectRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchNearObjectRequest o && Equals(o);
        }
    }
}
