// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo

using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum RecipientCategoryEnum
    {
        [EnumMember(Value = "EXTERNALPROVIDER")] ExternalProvider,
        [EnumMember(Value = "PATIENT")] Patient
    }
}
