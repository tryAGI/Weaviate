
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Default Value: QUORUM
    /// </summary>
    public enum ObjectsClassPatchConsistencyLevel
    {
        /// <summary>
        /// 
        /// </summary>
        ONE,
        /// <summary>
        /// 
        /// </summary>
        QUORUM,
        /// <summary>
        /// 
        /// </summary>
        ALL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObjectsClassPatchConsistencyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsClassPatchConsistencyLevel value)
        {
            return value switch
            {
                ObjectsClassPatchConsistencyLevel.ONE => "ONE",
                ObjectsClassPatchConsistencyLevel.QUORUM => "QUORUM",
                ObjectsClassPatchConsistencyLevel.ALL => "ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsClassPatchConsistencyLevel? ToEnum(string value)
        {
            return value switch
            {
                "ONE" => ObjectsClassPatchConsistencyLevel.ONE,
                "QUORUM" => ObjectsClassPatchConsistencyLevel.QUORUM,
                "ALL" => ObjectsClassPatchConsistencyLevel.ALL,
                _ => null,
            };
        }
    }
}