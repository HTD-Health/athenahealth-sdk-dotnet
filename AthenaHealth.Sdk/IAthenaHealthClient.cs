using AthenaHealth.Sdk.Clients;

namespace AthenaHealth.Sdk
{
    public interface IAthenaHealthClient
    {
        IPatientClient Patients { get; }
        int PracticeId { get; set; }
    }
}