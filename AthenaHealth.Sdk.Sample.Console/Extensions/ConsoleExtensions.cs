using AthenaHealth.Sdk.Models.Response;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Sample.Console.Extensions
{
    public static class ConsoleExtensions
    {
        public static void Display(this string methodName, ConsoleColor color = ConsoleColor.Green, bool includeTime = true)
        {
            System.Console.ForegroundColor = color;

            string time = includeTime ? DateTime.Now.ToString("T") + " | " : "";
            System.Console.WriteLine($"{time}{methodName}");

            System.Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Display(this PracticeResponse response)
        {
            System.Console.WriteLine($"Total: {response.Total}");
            foreach (Practice practice in response.Items)
            {
                Display(practice);
            }

            System.Console.WriteLine("--------------------");
        }

        public static void Display(this Practice practice)
        {
            System.Console.WriteLine($"Id: {practice.Id}{Environment.NewLine}Practice: {practice.Name}{Environment.NewLine}GoLive: {practice.GoLiveDate}");
            System.Console.WriteLine();
        }

        public static void Display(this DepartmentResponse response)
        {
            System.Console.WriteLine($"Total: {response.Total}");
            foreach (Department department in response.Items)
            {
                Display(department);
            }

            System.Console.WriteLine("--------------------");
        }

        public static void Display(this Department department)
        {
            System.Console.WriteLine($"Id: {department.Id}{Environment.NewLine}Department: {department.Name}{Environment.NewLine}Address: {department.Address}");
            System.Console.WriteLine();
        }

        public static void Display(this Patient patient)
        {
            System.Console.WriteLine($"Id: {patient.Id}{Environment.NewLine}First name: {patient.FirstName}{Environment.NewLine}Last name: {patient.LastName}{Environment.NewLine}");
            System.Console.WriteLine();
        }

        public static void Display(this PaymentMethodResponse response)
        {
            System.Console.WriteLine($"Total: {response.Total}");
            foreach (PaymentMethod pm in response.Items)
            {
                System.Console.WriteLine($"Name: {pm.Name}{Environment.NewLine}Identifier name: {pm.IdentifierName}");
                System.Console.WriteLine();
            }

            System.Console.WriteLine("--------------------");
        }

        public static void Display(this ProviderTypeResponse response)
        {
            System.Console.WriteLine($"Total: {response.Total}");
            foreach (ProviderType pt in response.Items)
            {
                System.Console.WriteLine($"Name: {pt.Name}{Environment.NewLine}Id: {pt.Id}");
                System.Console.WriteLine();
            }

            System.Console.WriteLine("--------------------");
        }

        public static void Display<T>(this InsurancePackageResponse<T> response) where T : InsurancePackage
        {
            System.Console.WriteLine($"Total: {response.Total}");
            foreach (T insurancePackage in response.Items)
            {
                if (insurancePackage is TopInsurancePackage topInsurancePackage)
                {
                    System.Console.WriteLine($"Id: {topInsurancePackage.Id}");
                }
                System.Console.WriteLine($"Name: {insurancePackage.Name}{Environment.NewLine}Address: {insurancePackage.Address} City: {insurancePackage.City} Zip: {insurancePackage.Zip}");
                System.Console.WriteLine();
            }

            System.Console.WriteLine("--------------------");
        }

        public static void Display(this InsurancePackageResponse response)
        {
            System.Console.WriteLine($"Total: {response.Total}");
            foreach (InsurancePackageExtended insurancePackage in response.Items)
            {
                System.Console.WriteLine($"Id: {insurancePackage.Id}{Environment.NewLine}Name: {insurancePackage.InsurancePlanName}");
                System.Console.WriteLine($"Affiliations: {String.Join(", ", insurancePackage.Affiliations)}");
                System.Console.WriteLine($"AddressList: {String.Join(", ", insurancePackage.AddressList)}");
                System.Console.WriteLine();
            }

            System.Console.WriteLine("--------------------");
        }

        public static void Display(this ProviderExtended provider)
        {
            System.Console.WriteLine($"Id: {provider.Id}{Environment.NewLine}Name: {provider.DisplayName}");
            System.Console.WriteLine($"Full Name: {provider.FirstName} {provider.LastName}");
            System.Console.WriteLine($"Federal Id number: {provider.FederalIdNumber}");
            System.Console.WriteLine($"Entity Type: {provider.EntityType}");
            System.Console.WriteLine();

            System.Console.WriteLine("--------------------");
        }

        public static void Display(this ProviderResponse response)
        {
            System.Console.WriteLine($"Total: {response.Total}");
            foreach (Provider item in response.Items)
            {
                System.Console.WriteLine($"Id: {item.Id}{Environment.NewLine}Name: {item.DisplayName}");
                System.Console.WriteLine($"Full Name: {item.FirstName} {item.LastName}");
                System.Console.WriteLine($"Entity Type: {item.EntityType}");
                System.Console.WriteLine();
            }

            System.Console.WriteLine("--------------------");
        }

        public static void Display(this Encounter response)
        {
            System.Console.WriteLine($"Id: {response.Id}");
            System.Console.WriteLine($"Encounter Type: {response.EncounterType}");
            System.Console.WriteLine($"Encounter Date: {response.EncounterDate:d}");
            System.Console.WriteLine($"Visit Name: {response.EncounterVisitName}");
            System.Console.WriteLine($"Status: {response.Status}");
            System.Console.WriteLine();

            System.Console.WriteLine("--------------------");
        }

        public static void Display(this Diagnose[] response)
        {
            System.Console.WriteLine($"Total: {response.Length}");
            foreach (Diagnose item in response)
            {
                System.Console.WriteLine($"Id: {item.Id}");
                System.Console.WriteLine($"Snomed Code: {item.SnomedCode}");
                System.Console.WriteLine($"Description: {item.Description}");
                System.Console.WriteLine($"Note: {item.Note}");
                System.Console.WriteLine();
            }

            System.Console.WriteLine("--------------------");
        }

        public static void Display(this Appointment appointment)
        {
            System.Console.WriteLine($"Id: {appointment.Id}");
            System.Console.WriteLine($"Copay: {appointment.Copay}");
            System.Console.WriteLine($"Last Modified: {appointment.LastModified:d}");
            System.Console.WriteLine($"Status: {appointment.AppointmentStatus}");

            string appointmentNotes = appointment.AppointmentNotes != null
                ? string.Join(", ", appointment.AppointmentNotes.Select(x => x.Text).ToList())
                : "";
            System.Console.WriteLine($"Notes: {appointmentNotes}");
            System.Console.WriteLine();

            System.Console.WriteLine("--------------------");
        }

        public static T RunTaskSynchronously<T>(this Task<T> task)
        {
            return task.GetAwaiter().GetResult();
        }
    }
}
