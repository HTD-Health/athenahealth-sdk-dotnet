using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum MaritalStatusEnum
    {
        [EnumMember(Value = "D")] Divorced,
        [EnumMember(Value = "M")] Married,
        [EnumMember(Value = "P")] Partner,
        [EnumMember(Value = "S")] Single,
        [EnumMember(Value = "U")] Unknown,
        [EnumMember(Value = "W")] Widowed,
        [EnumMember(Value = "X")] Separated
    }
}
