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

        private readonly IConnection _connection;

        public int PracticeId
        {
            get => _connection.Credentials.PracticeId;
            set => _connection.Credentials.PracticeId = value;
        }

        public AthenaHealthClient(ApiVersion version, string clientId, string clientSecret, int practiceId)
        {
            var httpClient = new AthenaHttpClient();
            var athenaHttpAdapter = new AthenaHttpAdapter(httpClient);
            var credentials = new Credentials(clientId, clientSecret);
            _connection = new Connection(athenaHttpAdapter, credentials, version);

            PracticeId = practiceId;

            Patients = new PatientClient(_connection);
            Practices = new PracticeClient(_connection);
            Departments = new DepartmentClient(_connection);
            Providers = new ProviderClient(_connection);
        }
    }
}
