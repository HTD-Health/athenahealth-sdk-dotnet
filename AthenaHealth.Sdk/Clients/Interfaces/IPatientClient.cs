using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Enums;

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

        Task<UpdateMedicalHistoryResponse> UpdateMedicalHistory(int patientId, UpdateMedicalHistory request);

        Task<PrescriptionResponse> GetPrescriptions(int patientId, GetPrescriptionsFilter queryParameters);

        Task<AnalyteResponse> GetAnalytes(int patientId, GetAnalytesFilter queryParameters);

        Task<PatientMedication> GetMedications(int patientId, GetMedicationsFilter queryParameters);

        Task<PatientAllergy> GetAllergies(int patientId, int departmentId, bool? showInactive = null);

        Task<PatientSocialHistory> GetSocialHistory(int patientId, GetSocialHistoryFilter queryParameters);

        Task<PatienSocialHistoryTemplate[]> GetSocialHistoryTemplates(int patientId, int departmentId);

        Task<UpdateSocialHistoryTemplatesResponse> UpdateSocialHistoryTemplates(int patientId, UpdateSocialHistoryTemplates request);

        Task<DocumentResponse> GetDocuments(int patientId, GetDocumentsFilter queryParameters);

        Task<Laboratory> GetDefaultLaboratory(int patientId, int departmentId);

        Task<InsuranceResponse> GetPatientInsurances(int patientId, GetPatientInsurancesFilter queryParameters);

        /// <summary>
        /// Creates patient insurances for a specified patient.
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="insurance"></param>
        /// <returns></returns>
        Task<Insurance> CreateInsurance(int patientId, CreateInsurance insurance);

        Task UpdateInsurance(int patientId, CreateInsurance insurance);

        /// <summary>
        /// Deletes patient's insurance.
        /// </summary>
        /// <param name="patientId">The athenaNet patient ID.</param>
        /// <param name="sequenceNumber"></param>
        /// <param name="departmentId">If set, we will use the department id in an attempt to cancel insurance for the local patient.</param>
        /// <param name="cancellationNote">Optional note as to why this is being cancelled.</param>
        /// <returns></returns>
        Task DeleteInsurance(int patientId, SequenceEnum sequenceNumber, int? departmentId = null, string cancellationNote = null);

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

        Task<CreatePatientResponse> CreatePatient(CreatePatient request);

        Task<UpdatePatientResponse> UpdatePatient(int patientId, UpdatePatient request);

        Task<UpdatePatientResponse> DeletePatient(int patientId);

        Task<AddProblemResponse> AddProblem(int patientId, AddProblem request);

        Task<AddDocumentResponse> AddDocument(int patientId, AddDocument request);

        /// <summary>
        /// In athenaNet, a practice has the flexibility to configure their patient registration page to display the Privacy Notice,
        /// Release of Billing Information, and Assignment of Benefits consent forms as 1, 2, or 3
        /// confirmation check boxes. This API returns a count of how many consent check boxes,
        /// and the associated labels, that a practice has configured in athenaNet.
        /// </summary>
        /// <param name="patientId">The athena ID of the patient whose privacy information was verified.</param>
        /// <param name="departmentId">The ID of the department where the privacy information was verified.</param>
        /// <returns></returns>
        Task<PrivacyInformationResponse> GetPrivacyInformation(int patientId, int departmentId);


        /// <summary>
        /// Please read the Privacy Information Verification documentation before using this API.
        /// This API flags the patient privacy information (Privacy Notice, Release of Billing Information, and Assignment of Benefits) as having been verified.
        /// If none of the three flags:
        /// (<see cref="SetPrivacyInformation.PrivacyNotice"/>,
        /// <see cref="SetPrivacyInformation.PatientSignature"/>, and
        /// <see cref="SetPrivacyInformation.InsuredSignature"/>)
        /// are set to true, then this call will mark all three by default.
        /// The three flags can be used in any combination. Note: This call can only be used to set the checkboxes.
        /// There is currently no API to unset them.
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<SetPrivacyInformationResponse> SetPrivacyInformation(int patientId, SetPrivacyInformation request);
    }
}
