using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients
{
    public interface IDepartmentClient
    {
        Task<DepartmentResponse> GetAll(int practiceId, GetDepartmentFilter filter = null);
        Task<Department> GetById(int practiceId, int departmentId, GetDepartmentFilter filter = null);
    }
}
