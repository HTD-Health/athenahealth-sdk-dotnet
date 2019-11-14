using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AthenaHealth.Sdk.Models.Request
{
    public class SearchFacilitiesFilter
    {
        /// <summary>
        /// Used to help determine both whether to include which practice-configured facilities
        /// as well as help sort the results.
        /// </summary>
        [Required]
        public int DepartmentId { get; set; }

        /// <summary>
        /// The facility to search for.
        /// This can include the name or address of the facility, in space delimited form.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The type of facility to search for.
        /// </summary>
        [Required]
        [JsonConverter(typeof(CustomEnumConverter))]
        public OrderTypeEnum OrderType { get; set; }

        /// <summary>
        /// Used to help determine which matches to return based on distance to patient and practice.
        /// </summary>
        public int? PatientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="departmentId">Used to help determine both whether to include which practice-configured facilities as well as help sort the results.</param>
        /// <param name="name">The facility to search for. This can include the name or address of the facility, in space delimited form.</param>
        /// <param name="orderType">The type of facility to search for.</param>
        /// <param name="patientId">Used to help determine which matches to return based on distance to patient and practice.</param>
        public SearchFacilitiesFilter(int departmentId, string name, OrderTypeEnum orderType, int? patientId = null)
        {
            DepartmentId = departmentId;
            Name = name;
            OrderType = orderType;
            PatientId = patientId;
        }
    }
}
