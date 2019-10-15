using System;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Sample.Console.Extensions
{
    public static class ConsoleExtensions
    {
        public static void Display(this string methodName)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"{DateTime.Now:T} | {methodName}");
            System.Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Display(this PracticeResponse response)
        {
            System.Console.WriteLine($"Total: {response.Total}");
            foreach (Practice practice in response.Practices)
            {
                Display(practice);
            }

            System.Console.WriteLine("--------------------");
        }

        public static void Display(this Practice practice)
        {
            System.Console.WriteLine($"Practice: {practice.Name}{Environment.NewLine}GoLive: {practice.GoLiveDate}{Environment.NewLine}Id: {practice.Id}");
            System.Console.WriteLine();
        }

        public static void Display(this DepartmentResponse response)
        {
            System.Console.WriteLine($"Total: {response.Total}");
            foreach (Department department in response.Departments)
            {
                Display(department);
            }

            System.Console.WriteLine("--------------------");
        }

        public static void Display(this Department department)
        {
            System.Console.WriteLine($"Department: {department.Name}{Environment.NewLine}Address: {department.Address}{Environment.NewLine}Id: {department.Id}");
            System.Console.WriteLine();
        }
    }
}
