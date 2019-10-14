using System;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Sample.Console
{
    internal class Program
    {
        private static async Task GetPatientSample()
        {
            var client = new AthenaHealthClient(ApiVersion.Preview, "login", "password", 123);

            //case 1
            Patient patient = await client.Patients.GetPatientById(32000);


            //case 2
            var filter = new GetPatientByIdFilter
            {
                DepartmentId = 1
            };

            var patient2 = client.Patients.GetPatientById(32000, filter);
        }

        private static async Task GetPracticeSample()
        {
            try
            {
                var client = new AthenaHealthClient(ApiVersion.Preview, "6yspwuq3wnx5n37jp9phqsmt", "Y9UxkbBge5EXutR", 123);

                Display("Practice.GetAll");
                PracticeResponse response = await client.Practices.GetAll();
                Display(response);

                Display("Practice.GetById=195900");
                response = await client.Practices.GetById(195900);
                Display(response);

                Display("Practice.GetById=666");
                response = await client.Practices.GetById(666);
                Display(response);
            }
            catch (ApiValidationException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        private static void Display(string methodName)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"{DateTime.Now:T} | {methodName}");
            System.Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Display(PracticeResponse response)
        {
            System.Console.WriteLine($"Total: {response.Total}");
            foreach (Practice practice in response.Practices)
            {
                System.Console.WriteLine($"Practice: {practice.Name}{Environment.NewLine}GoLive: {practice.GoLiveDate}{Environment.NewLine}Id: {practice.PracticeId}");
                System.Console.WriteLine();
            }

            System.Console.WriteLine("--------------------");
        }

        private static async Task Main(string[] args)
        {
            //await GetPatientSample();
            await GetPracticeSample();

            System.Console.ReadKey();
        }
    }
}