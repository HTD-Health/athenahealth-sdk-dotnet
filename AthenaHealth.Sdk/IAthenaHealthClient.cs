using AthenaHealth.Sdk.Clients;

namespace AthenaHealth.Sdk
{
    public interface IAthenaHealthClient
    {
        IPatientClient Patients { get; }
        IPracticeClient Practices { get; }
        IDepartmentClient Departments { get; }
        IProviderClient Providers { get; }
        int PracticeId { get; set; }
    }
}