using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum StatusEnum
    {
        [EnumMember(Value = "a")] Active,
        [EnumMember(Value = "d")] Deleted,
        [EnumMember(Value = "i")] Inactive,
        [EnumMember(Value = "p")] Prospective
    }
}