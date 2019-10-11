using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients
{
    public interface IPatientClient
    {
        Task<Patient> GetPatientById(int patientId, GetPatientByIdFilter getPatientByIdFilter = null);

        Task<IEnumerable<EnhancedBestmatchResponse>> EnhancedBestmatch(int practiceId, EnhancedBestmatchFilter queryParameters);

        Task<Pharmacy> GetDefaultPharmacy(int practiceId, int patientId, int departmentId);

        Task<Pharmacies> GetPreferredPharmacies(int practiceId, int patientId, GetPreferredPharmacyFilter getPreferredPharmacyFilter);
    }
}
