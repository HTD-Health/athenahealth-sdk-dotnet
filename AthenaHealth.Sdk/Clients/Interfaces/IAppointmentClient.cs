using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IAppointmentClient
    {
        Task<AppointmentTypeResponse> GetAppointmentTypes();
    }
}