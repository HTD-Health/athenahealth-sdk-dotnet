using AthenaHealth.Sdk.Clients;
using AthenaHealth.Sdk.Clients.Interfaces;

namespace AthenaHealth.Sdk
{
    public interface IAthenaHealthClient
    {
        IPatientClient Patients { get; }
        IPracticeClient Practices { get; }
        IDepartmentClient Departments { get; }
        IProviderClient Providers { get; }
        IAppointmentClient Appointments { get; }
        IInsurancePackageClient InsurancePackage { get; }

        int PracticeId { get; set; }
    }
}