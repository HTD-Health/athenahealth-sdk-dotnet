using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum AnalyteResultStatusEnum
    {
        [EnumMember(Value = "authorized")] Authorized,
        [EnumMember(Value = "cancelled")] Cancelled,
        [EnumMember(Value = "complete")] Complete,
        [EnumMember(Value = "corrected")] Corrected,
        [EnumMember(Value = "deleted")] Deleted,
        [EnumMember(Value = "final")] Final,
        [EnumMember(Value = "incomplete")] Incomplete,
        [EnumMember(Value = "intermediate")] Intermediate,
        [EnumMember(Value = "notreported")] NotReported,
        [EnumMember(Value = "partial")] Partial,
        [EnumMember(Value = "pending")] Pending,
        [EnumMember(Value = "preliminary")] Preliminary,
        [EnumMember(Value = "unverified")] Unverified,
        [EnumMember(Value = "verified")] Verified
    }
}
