using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum GuarantorRelationshipToPatientEnum
    {
        [EnumMember(Value = "1")] Self,
        [EnumMember(Value = "2")] Spouse,
        [EnumMember(Value = "3")] Child,
        [EnumMember(Value = "4")] Other,
        [EnumMember(Value = "5")] Grandparent,
        [EnumMember(Value = "6")] Grandchild,
        [EnumMember(Value = "7")] NephewOrNiece,
        [EnumMember(Value = "9")] FosterChild,
        [EnumMember(Value = "10")] Ward,
        [EnumMember(Value = "11")] StepsonOrStepdaughter,
        [EnumMember(Value = "12")] Employee,
        [EnumMember(Value = "13")] Unknown,
        [EnumMember(Value = "14")] HandicappedDependent,
        [EnumMember(Value = "15")] SponsoredDependent,
        [EnumMember(Value = "16")] DependentOfMinorDependent,
        [EnumMember(Value = "17")] SignificantOther,
        [EnumMember(Value = "18")] Mother,
        [EnumMember(Value = "19")] Father,
        [EnumMember(Value = "21")] EmancipatedMinor,
        [EnumMember(Value = "22")] OrganDonor,
        [EnumMember(Value = "23")] CadaverDonor,
        [EnumMember(Value = "24")] InjuredPlaintiff,
        [EnumMember(Value = "25")] ChildInsNotFinanciallyRespons,
        [EnumMember(Value = "26")] LifePartner,
        [EnumMember(Value = "27")] ChildMotherInsurance,
        [EnumMember(Value = "28")] ChildFatherInsurance,
        [EnumMember(Value = "29")] ChildMotherInsuranceInsNotFinanciallyRespons,
        [EnumMember(Value = "30")] ChildFatherInsuranceInsNotFinanciallyRespons,
        [EnumMember(Value = "31")] StepsonOrStepdaughterStepmotherInsurance,
        [EnumMember(Value = "32")] StepsonOrStepdaughterStepfatherInsurance
    }
}
