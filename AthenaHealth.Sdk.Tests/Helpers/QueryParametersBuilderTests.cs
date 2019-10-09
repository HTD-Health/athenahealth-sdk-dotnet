using System.Collections.Generic;
using AthenaHealth.Sdk.Http.Helpers;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Helpers
{
    public class QueryParametersBuilderTests
    {
        [Fact]
        public void QueryParameters_CommonData_CorrectQueryParametersDictionaryIsBuilt()
        {
            GetPatientByIdFilter filter = new GetPatientByIdFilter()
            {
                DepartmentId = 100,
                ShowFullSsn = "true"
            };

            Dictionary<string, string> dict = QueryParametersBuilder.Build(filter);
            dict.Count.ShouldBe(2);
            dict["DepartmentId"].ShouldBe("100");
            dict["ShowFullSsn"].ShouldBe("true");
        }
    }
}