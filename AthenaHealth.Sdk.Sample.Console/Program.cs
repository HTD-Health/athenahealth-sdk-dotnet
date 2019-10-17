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
            await GetPatientSample(client);

            System.Console.ReadKey();
        }

        private static async Task GetPatientSample(IAthenaHealthClient client)
        {
            try
            {
                "Patient.GetPatientById=1".Display();
                Patient response = await client.Patients.GetPatientById(1);
                response.Display();
            }
            catch (ApiValidationException e)
            {
                System.Console.WriteLine(e.Message);
            }
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
                var response = await client.Departments.GetAll();
                response.Display();

                "Department.GetById=1".Display();
                var department = await client.Departments.GetById(1);
                department.Display();

                "Department.GetById=999".Display();
                department = await client.Departments.GetById(999);
                department.Display();
            }
            catch (ApiValidationException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

    }
}