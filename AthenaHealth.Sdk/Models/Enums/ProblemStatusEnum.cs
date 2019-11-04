using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum ProblemStatusEnum
    {
        [EnumMember(Value = "ACUTE")] Acute,
        [EnumMember(Value = "CHRONIC")] Chronic
    }
}