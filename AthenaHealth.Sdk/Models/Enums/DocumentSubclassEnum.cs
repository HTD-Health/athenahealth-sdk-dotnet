using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum DocumentSubclassEnum
    {
        [EnumMember(Value = "ADMIN_BILLING")] BillingDocument,
        [EnumMember(Value = "ADMIN_CONSENT")] Consent,
        [EnumMember(Value = "ADMIN_HIPAA")] HIPAA,
        [EnumMember(Value = "ADMIN_INSURANCEAPPROVAL")] InsuranceApprovalNotification,
        [EnumMember(Value = "ADMIN_INSURANCECARD")] InsuranceCard,
        [EnumMember(Value = "ADMIN_INSURANCEDENIAL")] InsuranceDenialNotification,
        [EnumMember(Value = "ADMIN_LEGAL")] Legal,
        [EnumMember(Value = "ADMIN_MEDICALRECORDREQ")] MedicalRecordsRequest,
        [EnumMember(Value = "ADMIN_REFERRAL")] Referral,
        [EnumMember(Value = "ADMIN_SIGNEDFORMSLETTERS")] SignedFormsAndLetters,
        [EnumMember(Value = "ADMIN_VACCINATIONRECORD")] VaccinationRecord,
        [EnumMember(Value = "CLINICALDOCUMENT")] ClinicalDocument,
        [EnumMember(Value = "CLINICALDOCUMENT_ADMISSIONDISCHARGE")] AdmissionSummary,
        [EnumMember(Value = "CLINICALDOCUMENT_CONSULTNOTE")] ConsultNote,
        [EnumMember(Value = "CLINICALDOCUMENT_MENTALHEALTH")] MentalHealthConsult,
        [EnumMember(Value = "CLINICALDOCUMENT_OPERATIVENOTE")] OperativeNote,
        [EnumMember(Value = "CLINICALDOCUMENT_URGENTCARE")] EmergencyCare,
        [EnumMember(Value = "ENCOUNTERDOCUMENT_IMAGEDOC")] ImageDocumentation,
        [EnumMember(Value = "ENCOUNTERDOCUMENT_PATIENTHISTORY")] HealthHistoryQuestionnaire,
        [EnumMember(Value = "ENCOUNTERDOCUMENT_PROCEDUREDOC")] ProcedureDocumentation,
        [EnumMember(Value = "ENCOUNTERDOCUMENT_PROGRESSNOTE")] ProgressNote,
        [EnumMember(Value = "MEDICALRECORD_CHARTTOABSTRACT")] ChartForAbstraction,
        [EnumMember(Value = "MEDICALRECORD_COUMADIN")] Flowsheet,
        [EnumMember(Value = "MEDICALRECORD_GROWTHCHART")] GrowthChart,
        [EnumMember(Value = "MEDICALRECORD_HISTORICAL")] HistoricalMedicalRecord,
        [EnumMember(Value = "MEDICALRECORD_PATIENTDIARY")] PatientDiary,
        [EnumMember(Value = "MEDICALRECORD_VACCINATION")] Vaccination,
        [EnumMember(Value = "PHONEMESSAGE")] PhoneMessage
    }
}
