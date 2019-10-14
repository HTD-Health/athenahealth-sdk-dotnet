using AthenaHealth.Sdk.Clients;
using AthenaHealth.Sdk.Http;

namespace AthenaHealth.Sdk
{
    public class AthenaHealthClient : IAthenaHealthClient
    {
        public IPatientClient Patients { get; }
        public IPracticeClient Practices { get; }
        public int PracticeId { get; set; }

        public AthenaHealthClient(ApiVersion version, string login, string password, int practiceId)
        {
            var httpClient = new AthenaHttpClient();
            var athenaHttpAdapter = new AthenaHttpAdapter(httpClient);
            var credentials = new Credentials(login, password);
            var connection = new Connection(athenaHttpAdapter, credentials, version);

            PracticeId = practiceId;

            Patients = new PatientClient(connection);
            Practices = new PracticeClient(connection);
        }
    }
}
