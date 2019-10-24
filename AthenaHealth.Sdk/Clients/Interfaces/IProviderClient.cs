using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IProviderClient
    {
        Task<ProviderResponse> GetAll(GetProviderFilter filter = null);
        Task<ProviderExtended> GetById(int providerId, GetByIdProviderFilter filter = null);
    }
}
