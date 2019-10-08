using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients
{
    public interface IPatientClient
    {
        Task<Patient> GetPatientById(int patientId, GetPatientByIdFilter getPatientByIdFilter = null);

    }
}