using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum PreferredPronounsEnum
    {
        [EnumMember(Value = "he/him")] HeOrHim,
        [EnumMember(Value = "she/her")] SheOrHer,
        [EnumMember(Value = "they/them")] TheyOrThem
    }
}