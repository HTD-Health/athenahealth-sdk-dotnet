using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum SexEnum
    {
        [EnumMember(Value = "M")] Male,
        [EnumMember(Value = "F")] Female
    }
}