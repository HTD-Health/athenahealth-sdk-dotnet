using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum AnswerEnum
    {
        [EnumMember(Value = "Y")] Yes,
        [EnumMember(Value = "N")] No,
        [EnumMember(Value = "")] Unspecified
    }
}