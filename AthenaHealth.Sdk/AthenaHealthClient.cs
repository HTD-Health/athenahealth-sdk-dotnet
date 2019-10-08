using AthenaHealth.Sdk.Clients;
using AthenaHealth.Sdk.Http;

namespace AthenaHealth.Sdk
{
    public class AthenaHealthClient
    {
        public AthenaHealthClient(string baseAddress, string login, string password, int practiceId)
        {
            var httpClient = new AthenaHttpClient();
            var athenaHttpAdapter = new AthenaHttpAdapter(httpClient);
            var credentials = new Credentials(login, password);
            Connection = new Connection(athenaHttpAdapter, credentials, baseAddress);

            PracticeId = practiceId;

            Patients = new PatientClient(Connection);
        }

        public IConnection Connection { get; private set; }
        public IPatientClient Patients { get; private set; }
        public int PracticeId { get; set; }
    }
}