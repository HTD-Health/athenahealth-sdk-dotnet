using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum HomelessTypeEnum
    {
        [EnumMember(Value = "DOUBLINGUP")] DoublingUp,
        [EnumMember(Value = "OTHER")] Other,
        [EnumMember(Value = "PERMANENT")] PermanentSupportiveHousing,
        [EnumMember(Value = "SHELTER")] HomelessShelter,
        [EnumMember(Value = "STREET")] Street,
        [EnumMember(Value = "TRANSITIONAL")] Transitional,
        [EnumMember(Value = "UNKNOWN")] Unknown,
        [EnumMember(Value = "UNSPECIFIED")] Unspecified
    }
}