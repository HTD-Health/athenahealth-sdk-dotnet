using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum LabResultStatusEnum
    {
        [EnumMember(Value = "abnormal")] Abnormal,
        [EnumMember(Value = "cancelled")] Cancelled,
        [EnumMember(Value = "complete")] Complete,
        [EnumMember(Value = "corrected")] Corrected,
        [EnumMember(Value = "duplicate")] Duplicate,
        [EnumMember(Value = "final")] Final,
        [EnumMember(Value = "incomplete")] Incomplete,
        [EnumMember(Value = "intermediate")] Intermediate,
        [EnumMember(Value = "partial")] Partial,
        [EnumMember(Value = "pending")] Pending,
        [EnumMember(Value = "preliminary")] Preliminary,
        [EnumMember(Value = "signed")] Signed,
        [EnumMember(Value = "signedoff")] SignedOff
    }
}
