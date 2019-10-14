using AthenaHealth.Sdk.Clients;

namespace AthenaHealth.Sdk
{
    public interface IAthenaHealthClient
    {
        IPatientClient Patients { get; }
        IPracticeClient Practices { get; }
        int PracticeId { get; set; }
    }
}