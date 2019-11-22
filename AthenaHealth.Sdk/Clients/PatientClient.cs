using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Extensions;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients
{
    public class PatientClient : IPatientClient
    {
        private readonly IConnection _connection;

        public PatientClient(IConnection connection)
        {
            _connection = connection;
        }

        [Endpoint("GET /patients/{patientid}")]
        public async Task<Patient> GetPatientById(int patientId, GetPatientByIdFilter queryParameters = null)
        {
            var result = await _connection.Get<Patient[]>($"{_connection.PracticeId}/patients/{patientId}", queryParameters);

            return result.FirstOrThrowException();
        }

        [Endpoint("GET /patients/enhancedbestmatch")]
        public async Task<PatientWithScore[]> EnhancedBestmatch(EnhancedBestmatchFilter queryParameters)
        {
            return await _connection.Get<PatientWithScore[]>($"{_connection.PracticeId}/patients/enhancedbestmatch", queryParameters);
        }

        [Endpoint("GET /chart/{patientid}/pharmacies/default")]
        public async Task<Pharmacy> GetDefaultPharmacy(int patientId, int departmentId)
        {
            var queryParameters = new
            {
                departmentid = departmentId
            };

            return await _connection.Get<Pharmacy>($"{_connection.PracticeId}/chart/{patientId}/pharmacies/default", queryParameters);
        }

        [Endpoint("PUT /chart/{patientid}/pharmacies/default")]
        public async Task SetDefaultPharmacy(int patientId, SetPharmacyRequest request)
        {
            await _connection.Put<StatusResponse>($"{_connection.PracticeId}/chart/{patientId}/pharmacies/default", request);
        }

        [Endpoint("GET /chart/{patientid}/pharmacies/preferred")]
        public async Task<PharmacyResponse> GetPreferredPharmacies(int patientId, GetPreferredPharmacyFilter queryParameters)
        {
            return await _connection.Get<PharmacyResponse>($"{_connection.PracticeId}/chart/{patientId}/pharmacies/preferred", queryParameters);
        }

        [Endpoint("PUT /chart/{patientid}/pharmacies/preferred")]
        public async Task AddPreferredPharmacy(int patientId, SetPharmacyRequest request)
        {
            await _connection.Put<StatusResponse>($"{_connection.PracticeId}/chart/{patientId}/pharmacies/preferred", request);
        }

        [Endpoint("GET /patients")]
        public async Task<PatientResponse> GetPatients(GetPatientsFilter queryParameters)
        {
            return await _connection.Get<PatientResponse>($"{_connection.PracticeId}/patients", queryParameters);
        }

        [Endpoint("GET /chart/{patientid}/problems")]
        public async Task<ProblemResponse> GetPatientProblems(int patientId, GetPatientProblemsFilter queryParameters)
        {
            return await _connection.Get<ProblemResponse>($"{_connection.PracticeId}/chart/{patientId}/problems", queryParameters);
        }

        [Endpoint("GET /chart/{patientid}/labresults")]
        public async Task<LabResultResponse> GetLabResults(int patientId, GetLabResultsFilter queryParameters)
        {
            return await _connection.Get<LabResultResponse>($"{_connection.PracticeId}/chart/{patientId}/labresults", queryParameters);
        }

        [Endpoint("GET /chart/{patientid}/medicalhistory")]
        public async Task<MedicalHistory> GetMedicalHistory(int patientId, int departmentId)
        {
            var queryParameters = new
            {
                departmentid = departmentId
            };

            return await _connection.Get<MedicalHistory>($"{_connection.PracticeId}/chart/{patientId}/medicalhistory", queryParameters);
        }

        [Endpoint("PUT /chart/{patientid}/medicalhistory")]
        public async Task<UpdateMedicalHistoryResponse> UpdateMedicalHistory(int patientId, UpdateMedicalHistory request)
        {
            return await _connection.Put<UpdateMedicalHistoryResponse>($"{_connection.PracticeId}/chart/{patientId}/medicalhistory", body: request);
        }

        [Endpoint("GET /patients/{patientid}/documents/prescription")]
        public async Task<PrescriptionResponse> GetPrescriptions(int patientId, GetPrescriptionsFilter queryParameters)
        {
            return await _connection.Get<PrescriptionResponse>($"{_connection.PracticeId}/patients/{patientId}/documents/prescription", queryParameters);
        }

        [Endpoint("GET /chart/{patientid}/analytes")]
        public async Task<AnalyteResponse> GetAnalytes(int patientId, GetAnalytesFilter queryParameters)
        {
            return await _connection.Get<AnalyteResponse>($"{_connection.PracticeId}/chart/{patientId}/analytes", queryParameters);
        }

        [Endpoint("GET /chart/{patientid}/medications")]
        public async Task<PatientMedication> GetMedications(int patientId, GetMedicationsFilter queryParameters)
        {
            return await _connection.Get<PatientMedication>($"{_connection.PracticeId}/chart/{patientId}/medications", queryParameters);
        }

        [Endpoint("GET /chart/{patientid}/allergies")]
        public async Task<PatientAllergy> GetAllergies(int patientId, int departmentId, bool? showInactive = null)
        {
            var queryParameters = new
            {
                departmentid = departmentId,
                showinactive = showInactive
            };

            return await _connection.Get<PatientAllergy>($"{_connection.PracticeId}/chart/{patientId}/allergies", queryParameters);
        }

        [Endpoint("GET /chart/{patientid}/socialhistory")]
        public async Task<PatientSocialHistory> GetSocialHistory(int patientId, GetSocialHistoryFilter queryParameters)
        {
            return await _connection.Get<PatientSocialHistory>($"{_connection.PracticeId}/chart/{patientId}/socialhistory", queryParameters);
        }

        [Endpoint("PUT /chart/{patientid}/socialhistory")]
        public async Task<UpdateSocialHistoryResponse> UpdateSocialHistory(int patientId, UpdateSocialHistory request)
        {
            return await _connection.Put<UpdateSocialHistoryResponse>($"{_connection.PracticeId}/chart/{patientId}/socialhistory", body: request);
        }

        [Endpoint("GET /chart/{patientid}/socialhistory/templates")]
        public async Task<PatienSocialHistoryTemplate[]> GetSocialHistoryTemplates(int patientId, int departmentId)
        {
            var queryParameters = new
            {
                departmentid = departmentId
            };

            return await _connection.Get<PatienSocialHistoryTemplate[]>($"{_connection.PracticeId}/chart/{patientId}/socialhistory/templates", queryParameters);
        }

        [Endpoint("PUT /chart/{patientid}/socialhistory/templates")]
        public async Task<UpdateSocialHistoryTemplatesResponse> UpdateSocialHistoryTemplates(int patientId, UpdateSocialHistoryTemplates request)
        {
            return await _connection.Put<UpdateSocialHistoryTemplatesResponse>($"{_connection.PracticeId}/chart/{patientId}/socialhistory/templates", body: request);
        }

        [Endpoint("GET /patients/{patientid}/documents")]
        public async Task<DocumentResponse> GetDocuments(int patientId, GetDocumentsFilter queryParameters)
        {
            return await _connection.Get<DocumentResponse>($"{_connection.PracticeId}/patients/{patientId}/documents", queryParameters);
        }

        [Endpoint("POST /patients/{patientid}/documents")]
        public async Task<AddDocumentResponse> AddDocument(int patientId, AddDocument request)
        {
            return await _connection.Post<AddDocumentResponse>($"{_connection.PracticeId}/patients/{patientId}/documents", body: request, asMultipart: true);
        }

        [Endpoint("GET /patients/{patientid}/privacyinformationverified")]
        public async Task<PrivacyInformationResponse> GetPrivacyInformation(int patientId, int departmentId)
        {
            var queryParameters = new
            {
                departmentid = departmentId
            };

            return await _connection.Get<PrivacyInformationResponse>($"{_connection.PracticeId}/patients/{patientId}/privacyinformationverified", queryParameters);
        }

        [Endpoint("POST /patients/{patientid}/privacyinformationverified")]
        public async Task<SetPrivacyInformationResponse> SetPrivacyInformation(int patientId, SetPrivacyInformation request)
        {
            var response = await _connection.Post<SetPrivacyInformationResponse[]>($"{_connection.PracticeId}/patients/{patientId}/privacyinformationverified", null, request);

            return response.FirstOrThrowException();
        }

        [Endpoint("GET /chart/{patientid}/labs/default")]
        public async Task<Laboratory> GetDefaultLaboratory(int patientId, int departmentId)
        {
            var queryParameters = new
            {
                departmentid = departmentId
            };

            return await _connection.Get<Laboratory>($"{_connection.PracticeId}/chart/{patientId}/labs/default", queryParameters);
        }

        [Endpoint("GET /patients/{patientid}/insurances")]
        public async Task<InsuranceResponse> GetPatientInsurances(int patientId, GetPatientInsurancesFilter queryParameters)
        {
            return await _connection.Get<InsuranceResponse>($"{_connection.PracticeId}/patients/{patientId}/insurances", queryParameters);
        }

        [Endpoint("POST /patients/{patientid}/insurances")]
        public async Task<Insurance> CreateInsurance(int patientId, CreateInsurance insurance)
        {
            Insurance[] response = await _connection.Post<Insurance[]>($"{_connection.PracticeId}/patients/{patientId}/insurances", null, insurance);
            return response.FirstOrThrowException();
        }

        [Endpoint("PUT /patients/{patientid}/insurances")]
        public async Task UpdateInsurance(int patientId, CreateInsurance insurance)
        {
            await _connection.Put<StatusResponse>($"{_connection.PracticeId}/patients/{patientId}/insurances", null, insurance);
        }

        [Endpoint("DELETE /patients/{patientid}/insurances")]
        public async Task DeleteInsurance(int patientId, SequenceEnum sequenceNumber, int? departmentId = null, string cancellationNote = null)
        {
            var queryParameters = new
            {
                sequenceNumber = (int)sequenceNumber,
                departmentId,
                cancellationNote
            };

            await _connection.Delete<StatusResponse>($"{_connection.PracticeId}/patients/{patientId}/insurances", queryParameters);
        }

        [Endpoint("GET /chart/{patientid}/encounters")]
        public async Task<PatientEncounterResponse> GetPatientEncounters(int patientId, GetPatientEncountersFilter queryParameters)
        {
            return await _connection.Get<PatientEncounterResponse>($"{_connection.PracticeId}/chart/{patientId}/encounters", queryParameters);
        }

        [Endpoint("POST /chart/{patientid}/medications")]
        public async Task<MedicationAddedResponse> AddMedication(int patientId, AddMedication medication)
        {
            return await _connection.Post<MedicationAddedResponse>($"{_connection.PracticeId}/chart/{patientId}/medications", null, medication);
        }

        [Endpoint("PUT /chart/{patientid}/medications")]
        public async Task SetMedicationSettings(int patientId, MedicationSetting setting)
        {
            await _connection.Put<BaseResponse>($"{_connection.PracticeId}/chart/{patientId}/medications", setting);
        }

        [Endpoint("GET /patients/{patientid}/appointments")]
        public async Task<AppointmentResponse> GetPatientAppointments(int patientId, GetPatientAppointmentFilter filter = null)
        {
            return await _connection.Get<AppointmentResponse>($"{_connection.PracticeId}/patients/{patientId}/appointments", filter);
        }

        [Endpoint("GET /patients/{patientid}/documents/labresult/{labresultid}")]
        public async Task<LabResultDetail> GetLabResultDetails(int patientId, int labResultId, bool? showTemplate = null)
        {
            var queryParameters = new
            {
                showtemplate = showTemplate
            };

            var result = await _connection.Get<LabResultDetail[]>($"{_connection.PracticeId}/patients/{patientId}/documents/labresult/{labResultId}", queryParameters);

            return result.FirstOrThrowException();
        }

        [Endpoint("PUT /chart/{patientid}/labs/default")]
        public async Task SetPatientDefaultLaboratory(int patientId, int departmentId, int clinicalProviderId)
        {
            var queryParameters = new
            {
                patientid = patientId,
                departmentid = departmentId,
                clinicalproviderid = clinicalProviderId
            };

            await _connection.Put<StatusResponse>($"{_connection.PracticeId}/chart/{patientId}/labs/default", queryParameters);
        }

        [Endpoint("PUT /chart/{patientid}/allergies")]
        public async Task SetAllergies(int patientId, SetPatientAllergies request)
        {
            await _connection.Put<StatusResponse>($"{_connection.PracticeId}/chart/{patientId}/allergies", request);
        }

        [Endpoint("POST /patients")]
        public async Task<CreatePatientResponse> CreatePatient(CreatePatient request)
        {
            var result = await _connection.Post<CreatePatientResponse[]>($"{_connection.PracticeId}/patients", body: request);

            return result.FirstOrThrowException();
        }

        [Endpoint("PUT /patients/{patientid}")]
        public async Task<UpdatePatientResponse> UpdatePatient(int patientId, UpdatePatient request)
        {
            var result = await _connection.Put<UpdatePatientResponse[]>($"{_connection.PracticeId}/patients/{patientId}", body: request);

            return result.FirstOrThrowException();
        }

        [Endpoint("POST /chart/{patientid}/problems")]
        public async Task<AddProblemResponse> AddProblem(int patientId, AddProblem request)
        {
            return await _connection.Post<AddProblemResponse>($"{_connection.PracticeId}/chart/{patientId}/problems", body: request);
        }

        /// <summary>
        /// TODO: Not ready for usage. EndToEnd & Integration tests are needed.
        /// In order to test that Claim is required.
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [Endpoint("POST /patients/{patientid}/recordpayment")]
        public async Task RecordPayment(int patientId, RecordPayment request)
        {
            await _connection.Post<StatusResponse>($"{_connection.PracticeId}/patients/{patientId}/recordpayment", body: request);
        }

        /// <summary>
        /// Gets patient photo
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="jpegOutput">
        /// If set to true, or if Accept header is image/jpeg, returns the image directly. (The
        /// image may be scaled.)
        /// </param>
        /// <returns>Image bytes</returns>
        [Endpoint("GET /patients/{patientid}/photo")]
        public async Task<byte[]> GetPhoto(int patientId, bool? jpegOutput = null)
        {
            var queryParameters = new
            {
                //jpegoutput = jpegOutput // Information: This flag is not used, as it implies returning byte[] instead of JSON
            };

            var response = await _connection.Get<GetPhotoResponse>($"{_connection.PracticeId}/patients/{patientId}/photo", queryParameters);

            return Convert.FromBase64String(response.Image);
        }

        /// <summary>
        /// Updates patient photo
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [Endpoint("POST /patients/{patientid}/photo")]
        public async Task<BaseResponse> UpdatePhoto(int patientId, UpdatePhoto request)
        {
            return await _connection.Post<BaseResponse>($"{_connection.PracticeId}/patients/{patientId}/photo", body: request, asMultipart: true);
        }

        /// <summary>
        /// Deletes patient photo
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        [Endpoint("DELETE /patients/{patientid}/photo")]
        public async Task<BaseResponse> DeletePhoto(int patientId)
        {
            return await _connection.Delete<BaseResponse>($"{_connection.PracticeId}/patients/{patientId}/photo");
        }

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
        public async Task<byte[]> GetInsuranceCardPhoto(int patientId, int insuranceId, bool? jpegOutput = null)
        {
            var queryParameters = new
            {
                //jpegoutput = jpegOutput // Information: This flag is not used, as it implies returning byte[] instead of JSON
            };

            var response = await _connection.Get<GetPhotoResponse>($"{_connection.PracticeId}/patients/{patientId}/insurances/{insuranceId}/image", queryParameters);

            return Convert.FromBase64String(response.Image);
        }

        /// <summary>
        /// Updates patient insurance card photo
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="insuranceId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [Endpoint("POST /patients/{patientid}/insurances/{insuranceid}/image")]
        public async Task<BaseResponse> UpdateInsuranceCardPhoto(int patientId, int insuranceId, UpdateInsuranceCardPhoto request)
        {
            return await _connection.Post<BaseResponse>($"{_connection.PracticeId}/patients/{patientId}/insurances/{insuranceId}/image", body: request, asMultipart: true);
        }

        /// <summary>
        /// Deletes patient insurance card photo
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="insuranceId"></param>
        /// <returns></returns>
        [Endpoint("DELETE /patients/{patientid}/insurances/{insuranceid}/image")]
        public async Task<BaseResponse> DeleteInsuranceCardPhoto(int patientId, int insuranceId)
        {
            return await _connection.Delete<BaseResponse>($"{_connection.PracticeId}/patients/{patientId}/insurances/{insuranceId}/image");
        }

        /// <summary>
        /// Sets patient status to inactive
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        [Endpoint]
        public async Task<UpdatePatientResponse> DeletePatient(int patientId)
        {
            UpdatePatient request = new UpdatePatient()
            {
                Status = Models.Enums.StatusEnum.Inactive
            };

            return await UpdatePatient(patientId, request);
        }

        /// <summary>
        /// Adds an order group, and if successful returns its ID.
        /// </summary>
        /// <param name="patientId">The patient for this order group.</param>
        /// <param name="request"></param>
        /// <returns></returns>
        [Endpoint("POST /chart/{patientid}/ordergroups")]
        public async Task<CreateOrderResponse> CreateOrderGroup(int patientId, CreateOrderGroup request)
        {
            return await _connection.Post<CreateOrderResponse>($"{_connection.PracticeId}/chart/{patientId}/ordergroups", body: request);
        }

        [Endpoint("GET /chart/{patientid}/patientchartlist")]
        public async Task<ChartGroupResponse> GetPatientChartList(int patientId, GetPatientChartListFilter queryParameters = null)
        {
            return await _connection.Get<ChartGroupResponse>($"{_connection.PracticeId}/chart/{patientId}/patientchartlist", queryParameters);
        }
    }
}
