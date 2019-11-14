using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Http.Adapter
{
    public interface IAthenaHttpAdapter
    {
        Task<Response> Send(Request request);
    }
}
