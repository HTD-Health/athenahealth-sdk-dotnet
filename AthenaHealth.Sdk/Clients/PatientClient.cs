using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var result = await _connection.Get<IEnumerable<Patient>>($"{_connection.PracticeId}/patients/{patientId}", queryParameters);

            if (result.Count() == 1)
            {
                return result.First();
            }

            throw new Exception("Number of Patients not equals 1.");
        }

        public async Task<IEnumerable<PatientWithScore>> EnhancedBestmatch(EnhancedBestmatchFilter queryParameters)
        {
            return await _connection.Get< IEnumerable<PatientWithScore>>($"{_connection.PracticeId}/patients/enhancedbestmatch", queryParameters);
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
    }
}
