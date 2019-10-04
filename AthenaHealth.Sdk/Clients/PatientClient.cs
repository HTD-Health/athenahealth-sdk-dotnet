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
        
        public Patient GetPatientById(int patientId, GetPatientByIdFilter getPatientByIdFilter = null)
        {
            return Connection.Get<Patient>("");
        }
    }
}
