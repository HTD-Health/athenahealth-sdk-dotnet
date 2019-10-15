using System;
using System.Linq;
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

        public async Task<Practice> GetById(int practiceId, BaseLimitFilter filter = null)
        {
            PracticeResponse result = await _connection.Get<PracticeResponse>($"{practiceId}/practiceinfo", filter);
            
            if (result.Total == 1)
            {
                return result.Practices.First();
            }

            throw new Exception("Number of Practices not equals 1.");
        }

        public async Task<PracticeResponse> GetAll(BaseLimitFilter filter = null)
        {
            return await _connection.Get<PracticeResponse>($"1/practiceinfo", filter);
        }
    }
}
