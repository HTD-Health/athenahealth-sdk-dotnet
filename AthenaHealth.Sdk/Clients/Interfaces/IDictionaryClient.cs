using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IDictionaryClient
    {
        /// <summary>
        /// Get the list of valid provider types.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint("GET /reference/providertypes")]
        Task<ProviderTypeResponse> GetProviderTypes(GetProviderTypesFilter filter = null);

        /// <summary>
        /// Retrieves a list of valid credit card methods for practices not using CCP for use with
        /// <see cref="IPatientClient.RecordPayment"/>
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint("GET /configuration/validnonccpcreditcardmethods")]
        Task<PaymentMethodResponse> GetPaymentMethods(GetPaymentMethodsFilter filter = null);

        /// <summary>
        /// The list of matching orders alias autocomplete.
        /// </summary>
        /// <param name="name">A term to search for. Must be at least 2 characters.</param>
        /// <returns></returns>
        [Endpoint("GET /reference/order/lab")]
        Task<OrderType[]> SearchOrderTypesByName(string name);

        /// <summary>
        /// Return a list of matching medications alias autocomplete.
        /// </summary>
        /// <param name="name">A term to search for. Must be at least 2 characters.</param>
        /// <returns></returns>
        [Endpoint("GET /reference/medications")]
        Task<Medication[]> SearchMedicationsByName(string name);

        /// <summary>
        /// Return a short list of matching allergies alias autocomplete.
        /// </summary>
        /// <param name="name">A term to search for. Must be at least 2 characters.</param>
        /// <returns></returns>
        [Endpoint("GET /reference/allergies")]
        Task<Allergy[]> SearchAllergiesByName(string name);

        /// <summary>
        /// Return a list of medical history questions.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint("GET /chart/configuration/medicalhistory")]
        Task<MedicalHistoryQuestionResponse> GetMedicalHistoryQuestions(GetMedicalHistoryQuestionsFilter filter = null);

        [Endpoint("GET /chart/configuration/socialhistory")]
        Task<SocialHistoryTemplate[]> GetSocialHistoryTemplates();
    }
}
