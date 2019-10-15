using System;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Sample.Console.Extensions;

namespace AthenaHealth.Sdk.Sample.Console
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var client = new AthenaHealthClient(ApiVersion.Preview, "6yspwuq3wnx5n37jp9phqsmt", "Y9UxkbBge5EXutR", 195900);

            await GetPracticeSample(client);
            await GetDepartmentSample(client);

            System.Console.ReadKey();
        }

        private static async Task GetPatientSample(IAthenaHealthClient client)
        {
            //case 1
            Patient patient = await client.Patients.GetPatientById(32000);


            //case 2
            var filter = new GetPatientByIdFilter
            {
                DepartmentId = 1
            };

            var patient2 = client.Patients.GetPatientById(32000, filter);
        }

        private static async Task GetPracticeSample(IAthenaHealthClient client)
        {
            try
            {
                "Practice.GetAll".Display();
                PracticeResponse response = await client.Practices.GetAll();
                response.Display();

                "Practice.GetById=195900".Display();
                Practice practice = await client.Practices.GetById(195900);
                practice.Display();

                "Practice.GetById=666".Display();
                practice = await client.Practices.GetById(666);
                practice.Display();
            }
            catch (ApiValidationException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }


        private static async Task GetDepartmentSample(AthenaHealthClient client)
        {
            try
            {
                "Department.GetAll".Display();
                var response = await client.Departments.GetAll(client.PracticeId);
                response.Display();

                "Department.GetById=1".Display();
                var department = await client.Departments.GetById(client.PracticeId, 1);
                department.Display();

                "Department.GetById=999".Display();
                department = await client.Departments.GetById(client.PracticeId, 999);
                department.Display();
            }
            catch (ApiValidationException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

    }
}