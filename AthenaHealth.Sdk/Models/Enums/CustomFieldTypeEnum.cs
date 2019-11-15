using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum CustomFieldTypeEnum
    {
        [EnumMember(Value = "TEXT")] Text,
        [EnumMember(Value = "DATE")] Date,
        [EnumMember(Value = "NUMBER")] Number,
        [EnumMember(Value = "REFERRINGPROVIDER")] ReferringProvider
    }
}
