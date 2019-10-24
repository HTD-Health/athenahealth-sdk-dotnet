// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo

using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum ProductTypeEnum
    {
        [EnumMember(Value = "1")] PPO,
        [EnumMember(Value = "2")] HMO,
        [EnumMember(Value = "3")] MedicareSupplement,
        [EnumMember(Value = "4")] POS,
        [EnumMember(Value = "5")] Indemnity,
        [EnumMember(Value = "6")] EPO,
        [EnumMember(Value = "7")] PFFS,
        [EnumMember(Value = "8")] POSII,
        [EnumMember(Value = "9")] TRICARESupplement,
        [EnumMember(Value = "10")] FFS,
        [EnumMember(Value = "11")] QPOS,
        [EnumMember(Value = "12")] Other,
        [EnumMember(Value = "21")] BehavioralHealth,
        [EnumMember(Value = "22")] Contracts,
        [EnumMember(Value = "23")] Legal,
        [EnumMember(Value = "24")] MVA,
        [EnumMember(Value = "25")] Radiology,
        [EnumMember(Value = "26")] Vision,
        [EnumMember(Value = "27")] WorkersComp
    }
}
