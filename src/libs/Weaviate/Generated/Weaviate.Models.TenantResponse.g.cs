#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Weaviate
{
    /// <summary>
    /// attributes representing a single tenant response within weaviate
    /// </summary>
    public readonly partial struct TenantResponse : global::System.IEquatable<TenantResponse>
    {
        /// <summary>
        /// attributes representing a single tenant within weaviate
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Weaviate.Tenant? Tenant { get; init; }
#else
        public global::Weaviate.Tenant? Tenant { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tenant))]
#endif
        public bool IsTenant => Tenant != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Weaviate.TenantResponseVariant2? TenantResponseVariant2 { get; init; }
#else
        public global::Weaviate.TenantResponseVariant2? TenantResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TenantResponseVariant2))]
#endif
        public bool IsTenantResponseVariant2 => TenantResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TenantResponse(global::Weaviate.Tenant value) => new TenantResponse((global::Weaviate.Tenant?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Weaviate.Tenant?(TenantResponse @this) => @this.Tenant;

        /// <summary>
        /// 
        /// </summary>
        public TenantResponse(global::Weaviate.Tenant? value)
        {
            Tenant = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TenantResponse(global::Weaviate.TenantResponseVariant2 value) => new TenantResponse((global::Weaviate.TenantResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Weaviate.TenantResponseVariant2?(TenantResponse @this) => @this.TenantResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TenantResponse(global::Weaviate.TenantResponseVariant2? value)
        {
            TenantResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TenantResponse(
            global::Weaviate.Tenant? tenant,
            global::Weaviate.TenantResponseVariant2? tenantResponseVariant2
            )
        {
            Tenant = tenant;
            TenantResponseVariant2 = tenantResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TenantResponseVariant2 as object ??
            Tenant as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Tenant?.ToString() ??
            TenantResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTenant && IsTenantResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Weaviate.Tenant?, TResult>? tenant = null,
            global::System.Func<global::Weaviate.TenantResponseVariant2?, TResult>? tenantResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTenant && tenant != null)
            {
                return tenant(Tenant!);
            }
            else if (IsTenantResponseVariant2 && tenantResponseVariant2 != null)
            {
                return tenantResponseVariant2(TenantResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Weaviate.Tenant?>? tenant = null,
            global::System.Action<global::Weaviate.TenantResponseVariant2?>? tenantResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTenant)
            {
                tenant?.Invoke(Tenant!);
            }
            else if (IsTenantResponseVariant2)
            {
                tenantResponseVariant2?.Invoke(TenantResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Tenant,
                typeof(global::Weaviate.Tenant),
                TenantResponseVariant2,
                typeof(global::Weaviate.TenantResponseVariant2),
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
        public bool Equals(TenantResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Weaviate.Tenant?>.Default.Equals(Tenant, other.Tenant) &&
                global::System.Collections.Generic.EqualityComparer<global::Weaviate.TenantResponseVariant2?>.Default.Equals(TenantResponseVariant2, other.TenantResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TenantResponse obj1, TenantResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TenantResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TenantResponse obj1, TenantResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TenantResponse o && Equals(o);
        }
    }
}
