using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IPatientClient
    {
        [Endpoint("GET /patients/{patientid}")]
        Task<Patient> GetPatientById(int patientId, GetPatientByIdFilter queryParameters = null);

        [Endpoint("GET /patients/enhancedbestmatch")]
        Task<PatientWithScore[]> EnhancedBestmatch(EnhancedBestmatchFilter queryParameters);

        [Endpoint("GET /chart/{patientid}/pharmacies/default")]
        Task<Pharmacy> GetDefaultPharmacy(int patientId, int departmentId);

        [Endpoint("PUT /chart/{patientid}/pharmacies/default")]
        Task SetDefaultPharmacy(int patientId, SetPharmacyRequest request);

        [Endpoint("GET /chart/{patientid}/pharmacies/preferred")]
        Task<PharmacyResponse> GetPreferredPharmacies(int patientId, GetPreferredPharmacyFilter queryParameters);

        [Endpoint("PUT /chart/{patientid}/pharmacies/preferred")]
        Task AddPreferredPharmacy(int patientId, SetPharmacyRequest request);

        [Endpoint("GET /patients")]
        Task<PatientResponse> GetPatients(GetPatientsFilter queryParameters);

        [Endpoint("GET /chart/{patientid}/problems")]
        Task<ProblemResponse> GetPatientProblems(int patientId, GetPatientProblemsFilter queryParameters);

        [Endpoint("GET /chart/{patientid}/labresults")]
        Task<LabResultResponse> GetLabResults(int patientId, GetLabResultsFilter queryParameters);

        [Endpoint("GET /chart/{patientid}/medicalhistory")]
        Task<MedicalHistory> GetMedicalHistory(int patientId, int departmentId);

        [Endpoint("PUT /chart/{patientid}/medicalhistory")]
        Task<UpdateMedicalHistoryResponse> UpdateMedicalHistory(int patientId, UpdateMedicalHistory request);

        [Endpoint("GET /patients/{patientid}/documents/prescription")]
        Task<PrescriptionResponse> GetPrescriptions(int patientId, GetPrescriptionsFilter queryParameters);

        [Endpoint("GET /chart/{patientid}/analytes")]
        Task<AnalyteResponse> GetAnalytes(int patientId, GetAnalytesFilter queryParameters);

        [Endpoint("GET /chart/{patientid}/medications")]
        Task<PatientMedication> GetMedications(int patientId, GetMedicationsFilter queryParameters);

        [Endpoint("GET /chart/{patientid}/allergies")]
        Task<PatientAllergy> GetAllergies(int patientId, int departmentId, bool? showInactive = null);

        [Endpoint("GET /chart/{patientid}/socialhistory")]
        Task<PatientSocialHistory> GetSocialHistory(int patientId, GetSocialHistoryFilter queryParameters);

        [Endpoint("PUT /chart/{patientid}/socialhistory")]
        Task<UpdateSocialHistoryResponse> UpdateSocialHistory(int patientId, UpdateSocialHistory request);

        [Endpoint("GET /chart/{patientid}/socialhistory/templates")]
        Task<PatienSocialHistoryTemplate[]> GetSocialHistoryTemplates(int patientId, int departmentId);

        [Endpoint("PUT /chart/{patientid}/socialhistory/templates")]
        Task<UpdateSocialHistoryTemplatesResponse> UpdateSocialHistoryTemplates(int patientId, UpdateSocialHistoryTemplates request);

        [Endpoint("GET /patients/{patientid}/documents")]
        Task<DocumentResponse> GetDocuments(int patientId, GetDocumentsFilter queryParameters);

        [Endpoint("POST /patients/{patientid}/documents")]
        Task<AddDocumentResponse> AddDocument(int patientId, AddDocument request);

        /// <summary>
        /// In athenaNet, a practice has the flexibility to configure their patient registration
        /// page to display the Privacy Notice, Release of Billing Information, and Assignment of
        /// Benefits consent forms as 1, 2, or 3 confirmation check boxes. This API returns a count
        /// of how many consent check boxes, and the associated labels, that a practice has
        /// configured in athenaNet.
        /// </summary>
        /// <param name="patientId">
        /// The athena ID of the patient whose privacy information was verified.
        /// </param>
        /// <param name="departmentId">
        /// The ID of the department where the privacy information was verified.
        /// </param>
        /// <returns></returns>
        [Endpoint("GET /patients/{patientid}/privacyinformationverified")]
        Task<PrivacyInformationResponse> GetPrivacyInformation(int patientId, int departmentId);

        /// <summary>
        /// Please read the Privacy Information Verification documentation before using this API.
        /// This API flags the patient privacy information (Privacy Notice, Release of Billing
        /// Information, and Assignment of Benefits) as having been verified. If none of the three
        /// flags: ( <see cref="SetPrivacyInformation.PrivacyNotice"/>, <see
        /// cref="SetPrivacyInformation.PatientSignature"/>, and <see
        /// cref="SetPrivacyInformation.InsuredSignature"/>) are set to true, then this call will
        /// mark all three by default. The three flags can be used in any combination. Note: This
        /// call can only be used to set the checkboxes. There is currently no API to unset them.
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [Endpoint("POST /patients/{patientid}/privacyinformationverified")]
        Task<SetPrivacyInformationResponse> SetPrivacyInformation(int patientId, SetPrivacyInformation request);

        [Endpoint("GET /chart/{patientid}/labs/default")]
        Task<Laboratory> GetDefaultLaboratory(int patientId, int departmentId);

        [Endpoint("GET /patients/{patientid}/insurances")]
        Task<InsuranceResponse> GetPatientInsurances(int patientId, GetPatientInsurancesFilter queryParameters);

        /// <summary>
        /// Creates patient insurances for a specified patient.
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="insurance"></param>
        /// <returns></returns>
        [Endpoint("POST /patients/{patientid}/insurances")]
        Task<Insurance> CreateInsurance(int patientId, CreateInsurance insurance);

        [Endpoint("PUT /patients/{patientid}/insurances")]
        Task UpdateInsurance(int patientId, CreateInsurance insurance);

        /// <summary>
        /// Deletes patient's insurance.
        /// </summary>
        /// <param name="patientId">The athenaNet patient ID.</param>
        /// <param name="sequenceNumber"></param>
        /// <param name="departmentId">
        /// If set, we will use the department id in an attempt to cancel insurance for the local patient.
        /// </param>
        /// <param name="cancellationNote">Optional note as to why this is being cancelled.</param>
        /// <returns></returns>
        [Endpoint("DELETE /patients/{patientid}/insurances")]
        Task DeleteInsurance(int patientId, SequenceEnum sequenceNumber, int? departmentId = null, string cancellationNote = null);

        [Endpoint("GET /chart/{patientid}/encounters")]
        Task<PatientEncounterResponse> GetPatientEncounters(int patientId, GetPatientEncountersFilter queryParameters);

        /// <summary>
        /// Output of adding a historical medication to patient chart.
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="medication"></param>
        /// <returns></returns>
        [Endpoint("POST /chart/{patientid}/medications")]
        Task<MedicationAddedResponse> AddMedication(int patientId, AddMedication medication);

        /// <summary>
        /// Update the section wide note and no medications reported flag.
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="setting"></param>
        /// <returns></returns>
        [Endpoint("PUT /chart/{patientid}/medications")]
        Task SetMedicationSettings(int patientId, MedicationSetting setting);

        [Endpoint("GET /patients/{patientid}/appointments")]
        Task<AppointmentResponse> GetPatientAppointments(int patientId, GetPatientAppointmentFilter filter = null);

        [Endpoint("GET /patients/{patientid}/documents/labresult/{labresultid}")]
        Task<LabResultDetail> GetLabResultDetails(int patientId, int labResultId, bool? showTemplate = null);

        /// <summary>
        /// Sets patient default laboratory
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="departmentId"></param>
        /// <param name="clinicalProviderId"></param>
        /// <returns></returns>
        [Endpoint("PUT /chart/{patientid}/labs/default")]
        Task SetPatientDefaultLaboratory(int patientId, int departmentId, int clinicalProviderId);

        /// <summary>
        /// Updates patient allergy information
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [Endpoint("PUT /chart/{patientid}/allergies")]
        Task SetAllergies(int patientId, SetPatientAllergies request);

        [Endpoint("POST /patients")]
        Task<CreatePatientResponse> CreatePatient(CreatePatient request);

        [Endpoint("PUT /patients/{patientid}")]
        Task<UpdatePatientResponse> UpdatePatient(int patientId, UpdatePatient request);

        [Endpoint("POST /chart/{patientid}/problems")]
        Task<AddProblemResponse> AddProblem(int patientId, AddProblem request);

        /// <summary>
        /// TODO: Not ready for usage. EndToEnd & Integration tests are needed. In order to test
        /// that Claim is required. </summary> <param name="patientId"></param> <param
        /// name="request"></param> <returns></returns>
        [Endpoint("POST /patients/{patientid}/recordpayment")]
        Task RecordPayment(int patientId, RecordPayment request);

        /// <summary>
        /// Gets patient photo
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="jpegOutput">
        /// If set to true, or if Accept header is image/jpeg, returns the image directly. (The
        /// image may be scaled.)
        /// </param>
        /// <returns></returns>
        [Endpoint("GET /patients/{patientid}/photo")]
        Task<byte[]> GetPhoto(int patientId, bool? jpegOutput = null);

        /// <summary>
        /// Updates patient photo
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [Endpoint("POST /patients/{patientid}/photo")]
        Task<BaseResponse> UpdatePhoto(int patientId, UpdatePhoto request);

        /// <summary>
        /// Deletes patient photo
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        [Endpoint("DELETE /patients/{patientid}/photo")]
        Task<BaseResponse> DeletePhoto(int patientId);

        /// <summary>
        /// Gets patient insurance card photo
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="insuranceId"></param>
        /// <param name="jpegOutput">
        /// If set to true, or if Accept header is image/jpeg, returns the image directly. (The
        /// image may be scaled.)
        /// </param>
        /// <returns>Image bytes</returns>
        [Endpoint("GET /patients/{patientid}/insurances/{insuranceid}/image")]
        Task<byte[]> GetInsuranceCardPhoto(int patientId, int insuranceId, bool? jpegOutput = null);

        /// <summary>
        /// Updates patient insurance card photo
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="insuranceId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [Endpoint("POST /patients/{patientid}/insurances/{insuranceid}/image")]
        Task<BaseResponse> UpdateInsuranceCardPhoto(int patientId, int insuranceId, UpdateInsuranceCardPhoto request);

        /// <summary>
        /// Deletes patient insurance card photo
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="insuranceId"></param>
        /// <returns></returns>
        [Endpoint("DELETE /patients/{patientid}/insurances/{insuranceid}/image")]
        Task<BaseResponse> DeleteInsuranceCardPhoto(int patientId, int insuranceId);

        /// <summary>
        /// Sets patient status to inactive
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        Task<UpdatePatientResponse> DeletePatient(int patientId);

        /// <summary>
        /// Adds an order group, and if successful returns its ID.
        /// </summary>
        /// <param name="patientId">The patient for this order group.</param>
        /// <param name="request"></param>
        /// <returns></returns>
        [Endpoint("POST /chart/{patientid}/ordergroups")]
        Task<CreateOrderResponse> CreateOrderGroup(int patientId, CreateOrderGroup request);
    }
}
