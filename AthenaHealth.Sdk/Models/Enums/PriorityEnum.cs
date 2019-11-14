using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum PriorityEnum
    {
        [EnumMember(Value = "LOW")] Low,
        [EnumMember(Value = "NORMAL")] Normal,
        [EnumMember(Value = "HIGH")] High
    }
}
