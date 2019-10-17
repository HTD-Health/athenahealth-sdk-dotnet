using System.Collections.Generic;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients
{
    public class PatientClient : IPatientClient
    {
        public IConnection Connection { get; private set; }

        public PatientClient(IConnection connection)
        {
            Connection = connection;
        }
        
        public async Task<Patient> GetPatientById(int patientId, GetPatientByIdFilter getPatientByIdFilter = null)
        {
            return await Connection.Get<Patient>($"patients/{patientId}", getPatientByIdFilter);
            
        }

        public async Task<Pharmacy> GetDefaultPharmacy(int practiceId, int patientId, int departmentId)
        {
            return await Connection.Get<Pharmacy>($"{practiceId}/chart/{patientId}/pharmacies/default", new{DepartmentId = departmentId});
            
        }

        public async Task<PharmacyResponse> GetPreferredPharmacies(int practiceId, int patientId, GetPreferredPharmacyFilter getPreferredPharmacyFilter)
        {
            return await Connection.Get<PharmacyResponse>($"{practiceId}/chart/{patientId}/pharmacies/preferred", getPreferredPharmacyFilter);
            
        }

        public async Task<IEnumerable<EnhancedBestmatchResponse>> EnhancedBestmatch(int practiceId, EnhancedBestmatchFilter queryParameters)
        {
            return await Connection.Get< IEnumerable<EnhancedBestmatchResponse>>($"{practiceId}/patients/enhancedbestmatch", queryParameters);
        }
    }
}
