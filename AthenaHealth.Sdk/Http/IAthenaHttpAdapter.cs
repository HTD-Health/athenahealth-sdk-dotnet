using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Http
{
    public interface IAthenaHttpAdapter
    {
        Task<Response> Send(Request request);
    }
}