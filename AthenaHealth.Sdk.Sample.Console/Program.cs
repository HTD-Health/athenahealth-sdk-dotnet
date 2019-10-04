using System;
using AthenaHealth.Sdk.Clients;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;

namespace AthenaHealth.Sdk.Sample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            GetPatientSample();
        }

        private static void GetPatientSample()
        {

            var connection = new Connection(new Credentials("login", "password"), 
                "https://https://developer.athenahealth.com/api/preview1");

            //case 1
            var client = new AthenaHealthClient(connection, 123);
            var patient1 = client.Patients.GetPatientById(32000);


            //case 2
            var filter = new GetPatientByIdFilter
            {
                DepartmentId = 1
            };

            var patient2 = client.Patients.GetPatientById(32000, filter);
        }
    }
}
