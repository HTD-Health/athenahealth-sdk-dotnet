using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum ContactPreferenceEnum
    {
        [EnumMember(Value = "HOMEPHONE")] HomePhone,
        [EnumMember(Value = "MAIL")] Email,
        [EnumMember(Value = "MOBILEPHONE")] MobilePhone,
        [EnumMember(Value = "PORTAL")] Portal,
        [EnumMember(Value = "WORKPHONE")] WorkPhone
    }
}