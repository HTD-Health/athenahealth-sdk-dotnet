using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IEncounterClient
    {
        Task<Encounter> GetById(int encounterId);

        /// <summary>
        /// The HTML Summary for an encounter.
        /// </summary>
        /// <param name="encounterId"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<EncounterSummary> GetSummary(int encounterId, GetEncounterSummaryFilter filter = null);

        /// <summary>
        /// The list of diagnoses for this encounter.
        /// </summary>
        /// <param name="encounterId"></param>
        /// <returns></returns>
        Task<Diagnose[]> GetDiagnoses(int encounterId);

        Task<Diagnose> CreateDiagnoses(int encounterId, CreateDiagnoses model);

        Task DeleteDiagnoses(int encounterId, int diagnosisId);
    }
}