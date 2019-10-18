using System.Threading.Tasks;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients
{
    public class AppointmentClient : IAppointmentClient
    {
        private readonly IConnection _connection;

        public AppointmentClient(IConnection connection)
        {
            _connection = connection;
        }
        
        public async Task<AppointmentTypeResponse> GetAppointmentTypes()
        {
            // ReSharper disable once StringLiteralTypo
            return await _connection.Get<AppointmentTypeResponse>($"{_connection.PracticeId}/appointmenttypes");
        }
    }
}
