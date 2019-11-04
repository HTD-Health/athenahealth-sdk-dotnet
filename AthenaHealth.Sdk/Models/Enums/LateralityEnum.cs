using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum LateralityEnum
    {
        [EnumMember(Value = "LEFT")] Left,
        [EnumMember(Value = "RIGHT")] Right,
        [EnumMember(Value = "BILATERAL")] Bilateral
    }
}