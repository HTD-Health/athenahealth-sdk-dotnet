// ReSharper disable IdentifierTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class GetPatientByIdFilter
    {
        public int DepartmentId { get; set; }

        public string IgnoreRestrictions { get; set; }

        public string LimitLocalPatientId { get; set; }

        public string Show2015EdCehrtValues { get; set; }

        public string ShowAllClaims { get; set; }

        public string ShowAllPatientDepartmentStatus { get; set; }

        public string ShowBalanceDetails { get; set; }

        public string ShowCustomFields { get; set; }

        public string ShowFullSsn { get; set; }

        public string ShowInsurance { get; set; }

        public string ShowLocalPatientId { get; set; }

        public string ShowPortalStatus { get; set; }

    }

}
