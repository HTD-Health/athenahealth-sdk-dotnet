using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum PovertyLevelCalculatedEnum
    {
        [EnumMember(Value = "100")] LowerOrEqual100,
        [EnumMember(Value = "125")] Between101And150,
        [EnumMember(Value = "175")] Between151And200,
        [EnumMember(Value = "250")] Over200
    }
}