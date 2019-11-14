using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum AppointmentReasonTypeEnum
    {
        [EnumMember(Value = "all")] All,
        [EnumMember(Value = "new")] New,
        [EnumMember(Value = "existing")] Existing
    }
}
