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
            return await Connection.GetAsync<Patient>($"patients/{patientId}", getPatientByIdFilter);
            
        }
    }
}
