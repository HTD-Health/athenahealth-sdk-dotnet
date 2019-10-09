## Usage examples

Get patient by Id
```c#
var client = new AthenaHealthClient("https://https://developer.athenahealth.com/api/preview1","login", "password", practiceId: 195900);
Patient patient = await client.Patients.GetPatientById(32000);
Console.WriteLine(patient.Fullname);
```

## Supported Platforms

* .NET Standard 2.0+
* .NET Core 2.0+
* .NET Framework 4.6.1+