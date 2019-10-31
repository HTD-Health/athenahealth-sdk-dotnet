using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IPatientClient
    {
        Task<Patient> GetPatientById(int patientId, GetPatientByIdFilter queryParameters = null);

        Task<PatientWithScore[]> EnhancedBestmatch(EnhancedBestmatchFilter queryParameters);

        Task<Pharmacy> GetDefaultPharmacy(int patientId, int departmentId);

        Task<PharmacyResponse> GetPreferredPharmacies(int patientId, GetPreferredPharmacyFilter queryParameters);

        Task SetDefaultPharmacy(int patientId, SetPharmacyRequest request);

        Task AddPreferredPharmacy(int patientId, SetPharmacyRequest request);

        Task<PatientResponse> GetPatients(GetPatientsFilter queryParameters);

        Task<ProblemResponse> GetPatientProblems(int patientId, GetPatientProblemsFilter queryParameters);

        Task<LabResultResponse> GetLabResults(int patientId, GetLabResultsFilter queryParameters);

        Task<MedicalHistory> GetMedicalHistory(int patientId, int departmentId);

        Task<PrescriptionResponse> GetPrescriptions(int patientId, GetPrescriptionsFilter queryParameters);

        Task<AnalyteResponse> GetAnalytes(int patientId, GetAnalytesFilter queryParameters);

        Task<PatientMedication> GetMedications(int patientId, GetMedicationsFilter queryParameters);

        Task<PatientAllergy> GetAllergies(int patientId, int departmentId, bool? showInactive = null);

        Task<PatientSocialHistory> GetSocialHistory(int patientId, GetSocialHistoryFilter queryParameters);

        Task<PatienSocialHistoryTemplate[]> GetSocialHistoryTemplates(int patientId, int departmentId);

        Task<DocumentResponse> GetDocuments(int patientId, GetDocumentsFilter queryParameters);

        Task<Laboratory> GetDefaultLaboratory(int patientId, int departmentId);

        Task<InsuranceResponse> GetPatientInsurances(int patientId, GetPatientInsurancesFilter queryParameters);

        Task<LabResultDetail> GetLabResultDetails(int patientId, int labResultId, bool? showTemplate = null);

        Task<PatientEncounterResponse> GetPatientEncounters(int patientId, GetPatientEncountersFilter queryParameters);

        /// <summary>
        /// Output of adding a historical medication to patient chart.
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="medication"></param>
        /// <returns></returns>
        Task<MedicationAddedResponse> AddMedication(int patientId, AddMedication medication);

        /// <summary>
        /// Update the section wide note and no medications reported flag.
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="setting"></param>
        /// <returns></returns>
        Task SetMedicationSettings(int patientId, MedicationSetting setting);

        Task<AppointmentResponse> GetPatientAppointments(int patientId, GetPatientAppointmentFilter filter = null);

        /// <summary>
        /// Sets patient default laboratory
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="departmentId"></param>
        /// <param name="clinicalProviderId"></param>
        /// <returns></returns>
        Task SetPatientDefaultLaboratory(int patientId, int departmentId, int clinicalProviderId);

        /// <summary>
        /// Updates patient allergy information
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task SetAllergies(SetPatientAllergies request);
    }
}
