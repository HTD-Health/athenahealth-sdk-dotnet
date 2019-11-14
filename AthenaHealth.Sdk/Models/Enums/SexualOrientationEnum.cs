using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum SexualOrientationEnum
    {
        [EnumMember(Value = "Bisexual")] Bisexual,
        [EnumMember(Value = "Choose not to disclose")] ChooseNotToDisclose,
        [EnumMember(Value = "Don't know")] DontKnow,
        [EnumMember(Value = "Lesbian, gay or homosexual")] LesbianGayOrHomosexual,
        [EnumMember(Value = "Something else")] SomethingElse,
        [EnumMember(Value = "Something else, please describe")] SomethingElsePleaseDescribe,
        [EnumMember(Value = "Straight or heterosexual")] StraightOrHeterosexual
    }
}
