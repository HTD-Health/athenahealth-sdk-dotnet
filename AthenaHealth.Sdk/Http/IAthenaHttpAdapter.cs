using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Http
{
    public interface IAthenaHttpAdapter
    {
        Task<IResponse> Send(IRequest request);
    }
}