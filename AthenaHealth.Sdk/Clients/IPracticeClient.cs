using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients
{
    public interface IPracticeClient
    {
        Task<PracticeResponse> GetById(int practiceId, GetPracticeFilter filter = null);
        Task<PracticeResponse> GetAll(GetPracticeFilter filter = null);
    }
}