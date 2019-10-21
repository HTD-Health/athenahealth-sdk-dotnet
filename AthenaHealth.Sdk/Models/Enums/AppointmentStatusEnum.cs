using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum AppointmentStatusEnum
    {
        [EnumMember(Value = "f")] Future,
        [EnumMember(Value = "x")] Cancelled,
        [EnumMember(Value = "o")] Open,
        [EnumMember(Value = "2")] CheckedIn,
        [EnumMember(Value = "3")] CheckedOut,
        [EnumMember(Value = "4")] ChargeEntered
    }
}