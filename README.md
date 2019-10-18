AhtenaHealth Sdk .net is a .NET client library for AhtenaHealth API (https://athenahealth.com).
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
AhtenaHealth Sdk is available on NuGet:
```
Install-Package AthenaHealth.Sdk
```
### Create AthenaHealth client ###
```c#
var client = new AthenaHealthClient(ApiVersion.Preview, "clientId", "clientSecret", practiceId: 195900);
```
Parameters:
* apiVersion - version of AthenaHealth API
* 'clientId' and 'clientSecret' - to get createntials create account on https://developer.athenahealth.com
* practiceId - id of AthenaHealth practiceID (context). Because in most cases all requests are send in the context of one practiceId, it is set on the AthenaHealthClient

You can change current client's practiceId any time:
```c#
var client = new AthenaHealthClient(ApiVersion.Preview, "clientId", "clientSecret", practiceId: 195900);
//some code
client.PracticeId = 123;
```
### Request AthenaHealth API ###
```c#
//Get patient's preferred pharmacies
var filter = new GetPreferredPharmacyFilter {DepartmentId = 2};
PharmacyResponse parmacyResponse = await client.Patients.GetPreferredPharmacies(300, filter);

//Add patient's preferred pharmacy
var pharmacyRequest = new SetPharmacyRequest{DepartmentId = 164, ClinicalProviderId = 11242674};
await client.Patients.AddPreferredPharmacy(100, pharmacyRequest);

//Get all departments
DepartmentResponse departmentsResponse = await client.Departments.GetAll();
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