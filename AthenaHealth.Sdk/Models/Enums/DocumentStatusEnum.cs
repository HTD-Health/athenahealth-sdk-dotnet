using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum DocumentStatusEnum
    {
        [EnumMember(Value = "ADMINISTER")] Administer,
        [EnumMember(Value = "CLOSED")] Closed,
        [EnumMember(Value = "DATAENTRY")] DataEntry,
        [EnumMember(Value = "DELETED")] Deleted,
        [EnumMember(Value = "DISPENSE")] Dispense,
        [EnumMember(Value = "FOLLOWUP")] FollowUp,
        [EnumMember(Value = "HOLD")] Hold,
        [EnumMember(Value = "NOTIFY")] Notify,
        [EnumMember(Value = "PEND")] Pend,
        [EnumMember(Value = "PENDING")] Pending,
        [EnumMember(Value = "PENDINGLABEL")] PendingLabel,
        [EnumMember(Value = "PERFORM")] Perform,
        [EnumMember(Value = "REVIEW")] Review,
        [EnumMember(Value = "SCHEDULE")] Schedule,
        [EnumMember(Value = "SCHEDULED")] Scheduled,
        [EnumMember(Value = "SUBMIT")] Submit,
        [EnumMember(Value = "SUBMITTED")] Submitted
    }
}
