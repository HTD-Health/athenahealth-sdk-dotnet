using System.Collections.Generic;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
using System.Linq;
using AthenaHealth.Sdk.Models.Response;
using System;

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
            var result = await _connection.Get<IEnumerable<Patient>>($"{_connection.PracticeId}/patients/{patientId}", getPatientByIdFilter);

            if (result.Count() == 1)
            {
                return result.First();
            }

            throw new Exception("Number of Patients not equals 1.");
        }

        public async Task<Pharmacy> GetDefaultPharmacy(int patientId, int departmentId)
        {
            return await _connection.Get<Pharmacy>($"{_connection.PracticeId}/chart/{patientId}/pharmacies/default", new{DepartmentId = departmentId});
        }

        public async Task<PharmacyResponse> GetPreferredPharmacies(int patientId, GetPreferredPharmacyFilter getPreferredPharmacyFilter)
        {
            return await _connection.Get<PharmacyResponse>($"{_connection.PracticeId}/chart/{patientId}/pharmacies/preferred", getPreferredPharmacyFilter);
        }

        public async Task<IEnumerable<PatientWithScore>> EnhancedBestmatch(EnhancedBestmatchFilter queryParameters)
        public async Task SetDefaultPharmacy(int practiceId, int patientId, SetPharmacyRequest setPharmacyRequest)
        {
            return await _connection.Get< IEnumerable<PatientWithScore>>($"{_connection.PracticeId}/patients/enhancedbestmatch", queryParameters);
            await Connection.Put($"{practiceId}/chart/{patientId}/pharmacies/default", setPharmacyRequest);
            
        }

        public async Task AddPreferredPharmacy(int practiceId, int patientId, SetPharmacyRequest setPharmacyRequest)
        {
            await Connection.Put($"{practiceId}/chart/{patientId}/pharmacies/preferred", setPharmacyRequest);
            
        }
    }
}
