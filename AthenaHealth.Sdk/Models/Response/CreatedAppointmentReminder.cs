using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class CreatedAppointmentReminder : BaseResponse
    {
        /// <summary>
        /// An athenaNet appointment reminder ID.
        /// </summary>
        [JsonProperty("appointmentreminderid")]
        public int Id { get; set; }

        /// <summary>
        /// If <see cref="BaseResponse.IsSuccess"/> is false will contain error message.
        /// </summary>
        [JsonProperty("errormessage")]
        public string ErrorMessage { get; set; }
    }
}
