
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Default Value: SUCCESS
    /// </summary>
    public enum BatchReferenceResponseVariant2ResultStatus
    {
        /// <summary>
        /// 
        /// </summary>
        SUCCESS,
        /// <summary>
        /// 
        /// </summary>
        FAILED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchReferenceResponseVariant2ResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchReferenceResponseVariant2ResultStatus value)
        {
            return value switch
            {
                BatchReferenceResponseVariant2ResultStatus.SUCCESS => "SUCCESS",
                BatchReferenceResponseVariant2ResultStatus.FAILED => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchReferenceResponseVariant2ResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "SUCCESS" => BatchReferenceResponseVariant2ResultStatus.SUCCESS,
                "FAILED" => BatchReferenceResponseVariant2ResultStatus.FAILED,
                _ => null,
            };
        }
    }
}