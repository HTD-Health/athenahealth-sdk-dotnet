using System.Threading.Tasks;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Sample.Console
{
    internal class Program
    {
        private static async Task GetPatientSample()
        {
            
            var client = new AthenaHealthClient("https://developer.athenahealth.com/api/preview1","login", "password", practiceId:123);
            Patient patient = await client.Patients.GetPatientById(32000);
            System.Console.WriteLine(patient.Fullname);

            //case 2


            var filter = new GetPatientByIdFilter
            {
                DepartmentId = 1
            };

            var patient2 = client.Patients.GetPatientById(32000, filter);
        }

        private static async Task Main(string[] args)
        {
            await GetPatientSample();
        }
    }
}