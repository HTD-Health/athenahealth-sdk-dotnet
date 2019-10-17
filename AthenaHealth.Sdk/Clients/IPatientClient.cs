using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients
{
    public interface IPatientClient
    {
        Task<Patient> GetPatientById(int patientId, GetPatientByIdFilter getPatientByIdFilter = null);

        Task<IEnumerable<EnhancedBestmatchResponse>> EnhancedBestmatch(EnhancedBestmatchFilter queryParameters);

        Task<Pharmacy> GetDefaultPharmacy(int patientId, int departmentId);

        Task<PharmacyResponse> GetPreferredPharmacies(int patientId, GetPreferredPharmacyFilter getPreferredPharmacyFilter);
    }
}
