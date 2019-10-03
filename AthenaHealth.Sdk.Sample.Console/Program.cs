using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;

namespace AthenaHealth.Sdk.Sample.Console
{
    internal class Program
    {
        private static void GetPatientSample()
        {
            IAthenaHttpClient httpClient = new AthenaHttpClient();
            Credentials credentials = new Credentials("login", "password");
            Connection connection = new Connection(httpClient, credentials, "https://https://developer.athenahealth.com/api/preview1");
            var client = new AthenaHealthClient(connection, 123);

            //case 1
            var patient1 = client.Patients.GetPatientById(32000);

            //case 2
            var filter = new GetPatientByIdFilter
            {
                DepartmentId = 1
            };

            var patient2 = client.Patients.GetPatientById(32000, filter);
        }

        private static void Main(string[] args)
        {
            GetPatientSample();
        }
    }
}