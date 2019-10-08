using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;

namespace AthenaHealth.Sdk.Sample.Console
{
    internal class Program
    {
        private static void GetPatientSample()
        {
            
            var client = new AthenaHealthClient("https://https://developer.athenahealth.com/api/preview1","login", "password", 123);

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