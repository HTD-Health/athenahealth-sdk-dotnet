using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum SexEnum
    {
        [EnumMember(Value = "M")] Male,
        [EnumMember(Value = "F")] Female,
        [EnumMember(Value = "N")] ChooseNotToDisclose,
        [EnumMember(Value = "U")] Unknown
    }
}