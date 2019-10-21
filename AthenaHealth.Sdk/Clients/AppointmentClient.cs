using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Extensions;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
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
        
        public async Task<AppointmentTypeResponse> GetAppointmentTypes(GetAppointmentTypeFilter filter = null)
        {
            // ReSharper disable once StringLiteralTypo
            return await _connection.Get<AppointmentTypeResponse>($"{_connection.PracticeId}/appointmenttypes", filter);
        }

        public async Task<AppointmentType> GetAppointmentType(int appointmentTypeId)
        {
            // ReSharper disable once StringLiteralTypo
            AppointmentType[] result = await _connection.Get<AppointmentType[]>($"{_connection.PracticeId}/appointmenttypes/{appointmentTypeId}");
            return result.FirstOrThrowException();
        }
    }
}
