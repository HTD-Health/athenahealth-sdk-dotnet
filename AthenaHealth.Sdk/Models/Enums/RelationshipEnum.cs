using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum RelationshipEnum
    {
        [EnumMember(Value = "CHILD")] Child,
        [EnumMember(Value = "COUSIN")] Cousin,
        [EnumMember(Value = "FRIEND")] Friend,
        [EnumMember(Value = "GUARDIAN")] Guardian,
        [EnumMember(Value = "OTHER")] Other,
        [EnumMember(Value = "PARENT")] Parent,
        [EnumMember(Value = "SIBLING")] Sibling,
        [EnumMember(Value = "SPOUSE")] Spouse,
    }
}
