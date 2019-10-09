using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Http.Adapter
{
    public interface IAthenaHttpAdapter
    {
        Task<IResponse> Send(IRequest request);
    }
}