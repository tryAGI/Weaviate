
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// filter within a distance of a georange
    /// </summary>
    public sealed partial class WhereFilterGeoRange
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geoCoordinates")]
        public global::Weaviate.GeoCoordinates? GeoCoordinates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public global::Weaviate.WhereFilterGeoRangeDistance? Distance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhereFilterGeoRange" /> class.
        /// </summary>
        /// <param name="geoCoordinates"></param>
        /// <param name="distance"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WhereFilterGeoRange(
            global::Weaviate.GeoCoordinates? geoCoordinates,
            global::Weaviate.WhereFilterGeoRangeDistance? distance)
        {
            this.GeoCoordinates = geoCoordinates;
            this.Distance = distance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhereFilterGeoRange" /> class.
        /// </summary>
        public WhereFilterGeoRange()
        {
        }
    }
}