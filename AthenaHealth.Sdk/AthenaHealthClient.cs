using AthenaHealth.Sdk.Clients;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Http.Adapter;

namespace AthenaHealth.Sdk
{
    public class AthenaHealthClient : IAthenaHealthClient
    {
        public IPatientClient Patients { get; }
        public IPracticeClient Practices { get; }
        public IDepartmentClient Departments { get; }
        public IProviderClient Providers { get; }

        public int PracticeId { get; set; }

        public AthenaHealthClient(ApiVersion version, string clientId, string clientSecret, int practiceId)
        {
            var httpClient = new AthenaHttpClient();
            var athenaHttpAdapter = new AthenaHttpAdapter(httpClient);
            var credentials = new Credentials(clientId, clientSecret);
            var connection = new Connection(athenaHttpAdapter, credentials, version);

            PracticeId = practiceId;

            Patients = new PatientClient(connection);
            Practices = new PracticeClient(connection);
            Departments = new DepartmentClient(connection);
            Providers = new ProviderClient(connection);
        }
    }
}
