
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Configuration of objects' time-to-live
    /// </summary>
    public sealed partial class ObjectTtlConfig
    {
        /// <summary>
        /// Whether or not object ttl is enabled for this collection (default: `false`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Interval (in seconds) to be added to `deleteOn` value, denoting object's expiration time. Has to be positive for `deleteOn` set to `_creationTimeUnix` or `_lastUpdateTimeUnix`, any for custom property (default: `0`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultTtl")]
        public int? DefaultTtl { get; set; }

        /// <summary>
        /// Name of the property holding base time to compute object's expiration time (ttl = value of deleteOn property + defaultTtl). Can be set to `_creationTimeUnix`, `_lastUpdateTimeUnix` or custom property of `date` datatype.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteOn")]
        public string? DeleteOn { get; set; }

        /// <summary>
        /// Whether remove from resultset expired, but not yet deleted by background process objects (default: `false`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterExpiredObjects")]
        public bool? FilterExpiredObjects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTtlConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether or not object ttl is enabled for this collection (default: `false`).
        /// </param>
        /// <param name="defaultTtl">
        /// Interval (in seconds) to be added to `deleteOn` value, denoting object's expiration time. Has to be positive for `deleteOn` set to `_creationTimeUnix` or `_lastUpdateTimeUnix`, any for custom property (default: `0`).
        /// </param>
        /// <param name="deleteOn">
        /// Name of the property holding base time to compute object's expiration time (ttl = value of deleteOn property + defaultTtl). Can be set to `_creationTimeUnix`, `_lastUpdateTimeUnix` or custom property of `date` datatype.
        /// </param>
        /// <param name="filterExpiredObjects">
        /// Whether remove from resultset expired, but not yet deleted by background process objects (default: `false`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObjectTtlConfig(
            bool? enabled,
            int? defaultTtl,
            string? deleteOn,
            bool? filterExpiredObjects)
        {
            this.Enabled = enabled;
            this.DefaultTtl = defaultTtl;
            this.DeleteOn = deleteOn;
            this.FilterExpiredObjects = filterExpiredObjects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectTtlConfig" /> class.
        /// </summary>
        public ObjectTtlConfig()
        {
        }

    }
}