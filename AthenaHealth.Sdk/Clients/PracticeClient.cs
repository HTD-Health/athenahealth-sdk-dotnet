using System.Threading.Tasks;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients
{
    public class PracticeClient : IPracticeClient
    {
        private readonly IConnection _connection;

        public PracticeClient(IConnection connection)
        {
            _connection = connection;
        }

        public async Task<PracticeResponse> GetById(int practiceId, GetPracticeFilter filter = null)
        {
            return await _connection.Get<PracticeResponse>($"{practiceId}/practiceinfo", filter);
        }

        public async Task<PracticeResponse> GetAll(GetPracticeFilter filter = null)
        {
            return await _connection.Get<PracticeResponse>($"1/practiceinfo", filter);
        }
    }
}
