using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum AgriculturalWorkerTypeEnum
    {
        [EnumMember(Value = "MIGRANT")] Migrant,
        [EnumMember(Value = "SEASONAL")] Seasonal,
        [EnumMember(Value = "UNSPECIFIED")] Unspecified
    }
}