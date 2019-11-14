using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum CareSummaryDeliveryPreferenceEnum
    {
        [EnumMember(Value = "PAPER")] Paper,
        [EnumMember(Value = "PORTAL")] Portal
    }
}
