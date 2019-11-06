"AthenaHealth SDK .NET" is a .NET client library for AthenaHealth API (https://athenahealth.com).
## Usage example

Get patient by Id
```c#
var client = new AthenaHealthClient(ApiVersion.Preview, "clientId", "clientSecret", practiceId: 195900);
Patient patient = await client.Patients.GetPatientById(32000);
Console.WriteLine(patient.Fullname);
```

## Supported Platforms

* .NET Standard 2.0+
* .NET Core 2.0+
* .NET Framework 4.6.1+

## Getting Started

### Install ###
The library is available on NuGet:
```
Install-Package AthenaHealth.Sdk
```
### Create AthenaHealth client ###
```c#
var client = new AthenaHealthClient(ApiVersion.Preview, "clientId", "clientSecret", practiceId: 195900);
```
Parameters:
* apiVersion - version of AthenaHealth API
* 'clientId' and 'clientSecret' - to get credentials you need to create an account on https://developer.athenahealth.com
* practiceId - id of AthenaHealth practiceID (context). Most endpoints works in context of PracticeId, so all returned data is for specific PracticeId.

You can change current client's practiceId any time:
```c#
var client = new AthenaHealthClient(ApiVersion.Preview, "clientId", "clientSecret", practiceId: 195900);

// Changing PracticeId for the client.
client.PracticeId = 123;
```
### Request AthenaHealth API ###
```c#
// Get Payment methods.
PaymentMethodResponse paymentMethodResponse = await client.Dictionaries.GetPaymentMethods();

// Most of Get endpoints implements IPagingResponse<T> interface and their name ends with "Response" for ex.: "PaymentMethodResponse", "PharmacyResponse" etc.
public interface IPagingResponse<T>
{
    [JsonProperty("totalcount")]
    int Total { get; set; }

    [JsonProperty("next")]
    string Next { get; set; }

    [JsonProperty("previous")]
    string Previous { get; set; }

    T[] Items { get; set; }
}

// Get patient's preferred pharmacies
int departmentId = 2;

// Please note that all required properties must be provided into constructor.
// Other non required properties can be setup same as Limit property below.
// In case of no constructor nothing is required. 
var filter = new GetPreferredPharmacyFilter(departmentId) { Limit = 50 };
PharmacyResponse pharmacyResponse = await client.Patients.GetPreferredPharmacies(300, filter);

// Set patient's preferred pharmacy
departmentId = 164;
// Here we can see that the departamentId is only required property. ClinicalProviderId is not required, but can be provided. 
var pharmacyRequest = new SetPharmacyRequest(departmentId) { ClinicalProviderId = 11242674 };


int patientId = 100;

// Set, Add, Create, Update requests usually do not return any response.
// The wise thing to do in that situation is to catch any ApiValidationException, it will be thrown in case of any errors. 
await client.Patients.SetPreferredPharmacy(patientId, pharmacyRequest);

// Get all departments.
DepartmentResponse departmentsResponse = await client.Departments.GetAll();

// Add Patient.
CreatePatientResponse patientResponse
```
### Handling AthenaHealth API errors ###
When AthenaHealth API responds with an error, one of the following exceptions is thrown:
* ApiValidationException - validation errors (HttpStatus from 400 to 409)
* ApiException - other errors

```c#
try
{
    Patient response = await client.Patients.GetPatientById(1);
}
catch (ApiValidationException e)
{
    Console.WriteLine($"Message: {e.Message}. Status code: {e.StatusCode}. Error: {e.ResponseError}");
}
catch (ApiException e)
{
    Console.WriteLine($"Message: {e.Message}. Status code: {e.StatusCode}. Error: {e.ResponseError}");
}
```

## Related Projects ##
* AthenaHealth.Sdk - SDK library
* AthenaHealth.Sdk.Sample.Console		- sample application showing usage of the library
* AthenaHealth.Sdk.Tests				- unit tests
* AthenaHealth.Sdk.Tests.Integration	- integration tests with mocked responses from AthenaHealth
* AthenaHealth.Sdk.Tests.EndToEnd		- end to end tests with AthenaHealth API sandbox: https://developer.athenahealth.com/io-docs (require credentials). Please notice that AthenaHealth API responds with errors in an undetermined manner so failed tests need to be retried.

## AthenaHealth.Sdk.Sample.Console ##
### What is the purpose? ###
Purpose of this application is to trigger some endpoints (on Athena sandbox) 
from particular client and display received data to give user the basic knowledge of values returned.

It only contains Get endpoints as a sample.

### How to use it? ###
Open Program.cs file and assign specific value from enum that you would like to receive data from.

```c#
// By default we will get data from Dictionary client.
var currentClient = AthenaHealthClientsEnum.Dictionary;

// Changing client for which data will be displayed inside console. 
var currentClient = AthenaHealthClientsEnum.Patient;
```

Main method:
```c#
        private static async Task Main(string[] args)
        {
            // Replace the CLIENT_ID and CLIENT_SECRET with yours received after registration on AthenaHealth site.
            var client = new AthenaHealthClient(ApiVersion.Preview, "CLIENT_ID", "CLIENT_SECRET", practiceId: 195900);

            var currentClient = AthenaHealthClientsEnum.Dictionary;

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
```