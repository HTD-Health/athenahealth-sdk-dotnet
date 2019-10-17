using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients
{
    public interface IProviderClient
    {
        Task<ProviderTypeResponse> GetProviderTypes(int practiceId, BaseLimitFilter filter = null);
        Task<ProviderResponse> GetAll(int practiceId, GetProviderFilter filter = null);
        Task<ProviderExtended> GetById(int practiceId, int providerId, GetByIdProviderFilter filter = null);
    }
}
