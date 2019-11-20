using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum VitalAttributeDataTypeEnum
    {
        [EnumMember(Value = "CHECKBOX")] CheckBox,
        [EnumMember(Value = "FREETEXT")] FreeText,
        [EnumMember(Value = "NUMERIC")] Numeric,
        [EnumMember(Value = "SET")] Set
    }
}
