using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Request
{
    public class CreatePatient : CreateOrUpdatePatient
    {
        /// <summary>
        /// If set to true returns error message on patient match (Defaults to false).
        /// </summary>
        [JsonProperty("showerrormessage")]
        public bool? ShowErrorMessage { get; set; } = false;

        public CreatePatient(int departmentId, DateTime dateOfBirth, string firstName, string lastName)
        {
            DepartmentId = departmentId;
            DateOfBirth = dateOfBirth;
            FirstName = firstName;
            LastName = lastName;

            CountryCode3166 = "US";
        }
    }
}
