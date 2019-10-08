using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;

namespace AthenaHealth.Sdk.Sample.Console
{
    internal class Program
    {
        private static void GetPatientSample()
        {
            var httpClient = new HttpClientExtended();
            var credentials = new Credentials("login", "password");
            var connection = new Connection(httpClient, credentials, ApiVersion.Preview);
            var client = new AthenaHealthClient(connection, 123);

            //case 1
            var patient1 = client.Patients.GetPatientById(32000).Result;

            //case 2
            var filter = new GetPatientByIdFilter
            {
                DepartmentId = 1
            };

            var patient2 = client.Patients.GetPatientById(32000, filter).Result;
        }

        private static void Main(string[] args)
        {
            GetPatientSample();
        }
    }
}
