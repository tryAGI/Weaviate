
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Export classification. Only 'exported' carries a usable secureHash; the others report why the user was not carried.
    /// </summary>
    public enum DBUserCredentialStatus
    {
        /// <summary>
        ///
        /// </summary>
        Exported,
        /// <summary>
        ///
        /// </summary>
        ImportedKey,
        /// <summary>
        ///
        /// </summary>
        Revoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DBUserCredentialStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DBUserCredentialStatus value)
        {
            return value switch
            {
                DBUserCredentialStatus.Exported => "exported",
                DBUserCredentialStatus.ImportedKey => "imported_key",
                DBUserCredentialStatus.Revoked => "revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DBUserCredentialStatus? ToEnum(string value)
        {
            return value switch
            {
                "exported" => DBUserCredentialStatus.Exported,
                "imported_key" => DBUserCredentialStatus.ImportedKey,
                "revoked" => DBUserCredentialStatus.Revoked,
                _ => null,
            };
        }
    }
}