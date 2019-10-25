using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Extensions;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
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

        public async Task<Patient> GetPatientById(int patientId, GetPatientByIdFilter queryParameters = null)
        {
            var result = await _connection.Get<Patient[]>($"{_connection.PracticeId}/patients/{patientId}", queryParameters);

            return result.FirstOrThrowException();
        }

        public async Task<PatientWithScore[]> EnhancedBestmatch(EnhancedBestmatchFilter queryParameters)
        {
            return await _connection.Get<PatientWithScore[]>($"{_connection.PracticeId}/patients/enhancedbestmatch", queryParameters);
        }

        public async Task<Pharmacy> GetDefaultPharmacy(int patientId, int departmentId)
        {
            var queryParameters = new
            {
                departmentid = departmentId
            };

            return await _connection.Get<Pharmacy>($"{_connection.PracticeId}/chart/{patientId}/pharmacies/default", queryParameters);
        }

        public async Task<PharmacyResponse> GetPreferredPharmacies(int patientId, GetPreferredPharmacyFilter queryParameters)
        {
            return await _connection.Get<PharmacyResponse>($"{_connection.PracticeId}/chart/{patientId}/pharmacies/preferred", queryParameters);
        }

        public async Task SetDefaultPharmacy(int patientId, SetPharmacyRequest request)
        {
            await _connection.Put($"{_connection.PracticeId}/chart/{patientId}/pharmacies/default", request);
        }

        public async Task AddPreferredPharmacy(int patientId, SetPharmacyRequest request)
        {
            await _connection.Put($"{_connection.PracticeId}/chart/{patientId}/pharmacies/preferred", request);
        }

        public async Task<PatientResponse> GetPatients(GetPatientsFilter queryParameters)
        {
            return await _connection.Get<PatientResponse>($"{_connection.PracticeId}/patients", queryParameters);
        }

        public async Task<ProblemResponse> GetPatientProblems(int patientId, GetPatientProblemsFilter queryParameters)
        {
            return await _connection.Get<ProblemResponse>($"{_connection.PracticeId}/chart/{patientId}/problems", queryParameters);
        }

        public async Task<LabResultResponse> GetLabResults(int patientId, GetLabResultsFilter queryParameters)
        {
            return await _connection.Get<LabResultResponse>($"{_connection.PracticeId}/chart/{patientId}/labresults", queryParameters);
        }

        public async Task<MedicalHistory> GetMedicalHistory(int patientId, int departmentId)
        {
            var queryParameters = new
            {
                departmentid = departmentId
            };

            return await _connection.Get<MedicalHistory>($"{_connection.PracticeId}/chart/{patientId}/medicalhistory", queryParameters);
        }

        public async Task<PrescriptionResponse> GetPrescriptions(int patientId, GetPrescriptionsFilter queryParameters)
        {
            return await _connection.Get<PrescriptionResponse>($"{_connection.PracticeId}/patients/{patientId}/documents/prescription", queryParameters);
        }

        public async Task<AnalyteResponse> GetAnalytes(int patientId, GetAnalytesFilter queryParameters)
        {
            return await _connection.Get<AnalyteResponse>($"{_connection.PracticeId}/chart/{patientId}/analytes", queryParameters);
        }

        public async Task<PatientMedication> GetMedications(int patientId, GetMedicationsFilter queryParameters)
        {
            return await _connection.Get<PatientMedication>($"{_connection.PracticeId}/chart/{patientId}/medications", queryParameters);
        }

        public async Task<PatientAllergy> GetAllergies(int patientId, int departmentId, bool? showInactive = null)
        {
            var queryParameters = new
            {
                departmentid = departmentId,
                showinactive = showInactive
            };

            return await _connection.Get<PatientAllergy>($"{_connection.PracticeId}/chart/{patientId}/allergies", queryParameters);
        }

        public async Task<PatientSocialHistory> GetSocialHistory(int patientId, GetSocialHistoryFilter queryParameters)
        {
            return await _connection.Get<PatientSocialHistory>($"{_connection.PracticeId}/chart/{patientId}/socialhistory", queryParameters);
        }

        public async Task<PatienSocialHistoryTemplate[]> GetSocialHistoryTemplates(int patientId, int departmentId)
        {
            var queryParameters = new
            {
                departmentid = departmentId
            };

            return await _connection.Get<PatienSocialHistoryTemplate[]>($"{_connection.PracticeId}/chart/{patientId}/socialhistory/templates", queryParameters);
        }

        public async Task<DocumentResponse> GetDocuments(int patientId, GetDocumentsFilter queryParameters)
        {
            return await _connection.Get<DocumentResponse>($"{_connection.PracticeId}/patients/{patientId}/documents", queryParameters);
        }
    }
}
