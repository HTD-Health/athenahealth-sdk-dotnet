using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum PovertyLevelIncomePayPeriodEnum
    {
        [EnumMember(Value = "BIWEEK")] TwoWeeks,
        [EnumMember(Value = "MONTH")] Month,
        [EnumMember(Value = "WEEK")] Week,
        [EnumMember(Value = "YEAR")] Year
    }
}