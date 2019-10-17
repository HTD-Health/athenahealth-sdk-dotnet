using System.Collections.Generic;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients
{
    public class PatientClient : IPatientClient
    {
        private readonly IConnection _connection;

        public PatientClient(IConnection connection)
        {
            _connection = connection;
        }
        
        public async Task<Patient> GetPatientById(int patientId, GetPatientByIdFilter getPatientByIdFilter = null)
        {
            return await _connection.Get<Patient>($"patients/{patientId}", getPatientByIdFilter);
        }

        public async Task<Pharmacy> GetDefaultPharmacy(int patientId, int departmentId)
        {
            return await _connection.Get<Pharmacy>($"{_connection.PracticeId}/chart/{patientId}/pharmacies/default", new{DepartmentId = departmentId});
        }

        public async Task<PharmacyResponse> GetPreferredPharmacies(int patientId, GetPreferredPharmacyFilter getPreferredPharmacyFilter)
        {
            return await _connection.Get<PharmacyResponse>($"{_connection.PracticeId}/chart/{patientId}/pharmacies/preferred", getPreferredPharmacyFilter);
        }

        public async Task<IEnumerable<EnhancedBestmatchResponse>> EnhancedBestmatch(EnhancedBestmatchFilter queryParameters)
        {
            return await _connection.Get< IEnumerable<EnhancedBestmatchResponse>>($"{_connection.PracticeId}/patients/enhancedbestmatch", queryParameters);
        }
    }
}
