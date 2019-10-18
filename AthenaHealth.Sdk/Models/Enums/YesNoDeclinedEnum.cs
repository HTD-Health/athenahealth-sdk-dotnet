using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum YesNoDeclinedEnum
    {
        [EnumMember(Value = "N")] No,
        [EnumMember(Value = "P")] PatientDeclined,
        [EnumMember(Value = "Y")] Yes
    }
}