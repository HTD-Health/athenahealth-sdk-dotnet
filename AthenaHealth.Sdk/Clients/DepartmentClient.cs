using System;
using System.Linq;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients
{
    public class DepartmentClient : IDepartmentClient
    {
        private readonly IConnection _connection;

        public DepartmentClient(IConnection connection)
        {
            _connection = connection;
        }

        public async Task<DepartmentResponse> GetAll(GetDepartmentFilter filter = null)
        {
            return await _connection.Get<DepartmentResponse>($"{_connection.PracticeId}/departments", filter);
        }

        public async Task<Department> GetById(int departmentId, GetDepartmentFilter filter = null)
        {
            Department[] result = await _connection.Get<Department[]>($"{_connection.PracticeId}/departments/{departmentId}", filter);

            if (result.Length == 1)
            {
                return result.First();
            }

            throw new Exception("Number of Items not equals 1.");
        }
    }
}
