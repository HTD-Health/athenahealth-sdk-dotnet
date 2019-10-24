using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum OrderTypeEnum
    {
        [EnumMember(Value = "DME")] DurableMedicalEquipment,
        [EnumMember(Value = "IMAGING")] ImagingCenter,
        [EnumMember(Value = "LAB")] Laboratory,
        [EnumMember(Value = "OTHER")] Other,
        [EnumMember(Value = "PRESCRIPTION")] Pharmacy,
        [EnumMember(Value = "PROCEDURE")] FacilityForProcedures,
        [EnumMember(Value = "SURGERY")] SurgicalFacility,
        [EnumMember(Value = "VACCINE")] PharmacyForPrescribedVaccines
    }
}
