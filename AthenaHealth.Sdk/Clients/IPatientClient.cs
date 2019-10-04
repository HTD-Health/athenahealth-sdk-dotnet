using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients
{
    public interface IPatientClient
    {
        Patient GetPatientById(int patientId, GetPatientByIdFilter getPatientByIdFilter = null);

    }
}