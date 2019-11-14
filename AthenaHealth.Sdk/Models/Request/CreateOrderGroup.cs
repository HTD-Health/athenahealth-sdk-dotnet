using System.ComponentModel.DataAnnotations;

namespace AthenaHealth.Sdk.Models.Request
{
    public class CreateOrderGroup
    {
        /// <summary>
        /// The department to use for the order group.
        /// </summary>
        [Required]
        public int DepartmentId { get; set; }

        /// <summary>
        /// The ordering provider ID, if not given a random provider from that department will be used.
        /// </summary>
        public int? OrderingProviderId { get; set; }

        /// <summary>
        /// The ID of the patient case generating this new order group.
        /// </summary>
        public int? PatientCaseId { get; set; }

        public CreateOrderGroup(int departmentId)
        {
            DepartmentId = departmentId;
        }
    }
}
