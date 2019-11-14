using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Sample.Console.Enums;
using AthenaHealth.Sdk.Sample.Console.Extensions;
using System;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Sample.Console
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var client = new AthenaHealthClient(ApiVersion.Preview, "6yspwuq3wnx5n37jp9phqsmt", "Y9UxkbBge5EXutR", 195900);

            var currentClient = AthenaHealthClientsEnum.Appointment;

            switch (currentClient)
            {
                case AthenaHealthClientsEnum.Patient:
                    DisplayPatientSample(client);
                    break;
                case AthenaHealthClientsEnum.Practice:
                    DisplayPracticeSample(client);
                    break;
                case AthenaHealthClientsEnum.Department:
                    DisplayDepartmentSample(client);
                    break;
                case AthenaHealthClientsEnum.Provider:
                    DisplayProviderSample(client);
                    break;
                case AthenaHealthClientsEnum.Appointment:
                    DisplayAppointmentSample(client);
                    break;
                case AthenaHealthClientsEnum.InsurancePackage:
                    DisplayInsurancePackageSample(client);
                    break;
                case AthenaHealthClientsEnum.Encounter:
                    DisplayEncounterSample(client);
                    break;
                case AthenaHealthClientsEnum.Dictionary:
                    DisplayDictionarySample(client);
                    break;
            }

            System.Console.ReadKey();
        }

        private static void DisplayEncounterSample(AthenaHealthClient client)
        {
            HandleException(() =>
            {
                "Encounters.GetById=1".Display();
                Encounter response = client.Encounters.GetById(1).RunTaskSynchronously();
                response.Display();
            });

            HandleException(() =>
            {
                "Encounters.GetDiagnoses=1".Display();
                Diagnose[] response = client.Encounters.GetDiagnoses(1).RunTaskSynchronously();
                response.Display();
            });
        }

        private static void DisplayInsurancePackageSample(AthenaHealthClient client)
        {
            HandleException(() =>
            {
                "InsurancePackage.GetCommon".Display();
                InsurancePackageResponse<CommonInsurancePackage> response = client.InsurancePackage.GetCommon(new GetCommonInsurancePackageFilter(1)).RunTaskSynchronously();
                response.Display();
            });

            HandleException(() =>
            {
                "InsurancePackage.GetTop".Display();
                InsurancePackageResponse<TopInsurancePackage> response = client.InsurancePackage.GetTop().RunTaskSynchronously();
                response.Display();
            });

            HandleException(() =>
            {
                "InsurancePackage.Search=planName:PAYMENT PLAN, memberId=1, productType = PPO".Display();
                InsurancePackageResponse response = client.InsurancePackage.Search(new SearchInsuranceFilter("PAYMENT PLAN", "1")
                {
                    ProductType = ProductTypeEnum.PPO
                }).RunTaskSynchronously();
                response.Display();
            });

            HandleException(() =>
            {
                "InsurancePackage.Search=null".Display();
                InsurancePackageResponse response = client.InsurancePackage.Search(null).RunTaskSynchronously();
                response.Display();
            });
        }

        private static void DisplayAppointmentSample(AthenaHealthClient client)
        {
            HandleException(() =>
            {
                "Appointments.GetById=997681".Display();
                Appointment response = client.Appointments.GetById(997681).RunTaskSynchronously();
                response.Display();
            });
        }

        private static void DisplayProviderSample(AthenaHealthClient client)
        {
            HandleException(() =>
            {
                "Providers.GetById=86".Display();
                ProviderExtended response = client.Providers.GetById(86, new GetByIdProviderFilter() { ShowFederalIdNumber = 1 }).RunTaskSynchronously();
                response.Display();
            });

            HandleException(() =>
            {
                "Providers.GetById=999".Display();
                ProviderExtended response = client.Providers.GetById(999).RunTaskSynchronously();
                response.Display();
            });

            HandleException(() =>
            {
                "Providers.GetAll".Display();
                ProviderResponse response = client.Providers.GetAll().RunTaskSynchronously();
                response.Display();
            });
        }

        private static void DisplayDictionarySample(AthenaHealthClient client)
        {
            HandleException(() =>
            {
                "Dictionaries.GetPaymentMethods".Display();
                PaymentMethodResponse response = client.Dictionaries.GetPaymentMethods().RunTaskSynchronously();
                response.Display();
            });

            HandleException(() =>
            {
                "Dictionaries.GetProviderTypes".Display();
                ProviderTypeResponse response = client.Dictionaries.GetProviderTypes().RunTaskSynchronously();
                response.Display();
            });
        }

        private static void DisplayPatientSample(IAthenaHealthClient client)
        {
            HandleException(() =>
            {
                "Patient.GetPatientById=1".Display();
                Patient response = client.Patients.GetPatientById(1).RunTaskSynchronously();
                response.Display();
            });
        }

        private static void DisplayPracticeSample(IAthenaHealthClient client)
        {
            HandleException(() =>
            {
                "Practice.GetAll".Display();
                PracticeResponse response = client.Practices.GetAll().RunTaskSynchronously();
                response.Display();
            });


            HandleException(() =>
            {
                "Practice.GetCurrentPractice".Display();
                Practice response = client.Practices.GetCurrentPractice().RunTaskSynchronously();
                response.Display();
            });

            HandleException(() =>
            {
                "Practice.GetById=195900".Display();
                Practice response = client.Practices.GetById(195900).RunTaskSynchronously();
                response.Display();
            });

            HandleException(() =>
            {
                "Practice.GetById=666".Display();
                Practice response = client.Practices.GetById(666).RunTaskSynchronously();
                response.Display();
            });
        }

        private static void DisplayDepartmentSample(AthenaHealthClient client)
        {
            HandleException(() =>
            {
                "Department.GetAll".Display();
                var response = client.Departments.GetAll().RunTaskSynchronously();
                response.Display();
            });

            HandleException(() =>
            {
                "Department.GetById=1".Display();
                var response = client.Departments.GetById(1).RunTaskSynchronously();
                response.Display();
            });

            HandleException(() =>
            {
                "Department.GetById=999".Display();
                var response = client.Departments.GetById(999).RunTaskSynchronously();
                response.Display();
            });
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (ApiValidationException e)
            {
                e.Message.Display(ConsoleColor.Red, false);
                System.Console.WriteLine();
            }
        }
    }
}
