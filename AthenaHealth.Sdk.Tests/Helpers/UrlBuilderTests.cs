using System;
using System.Collections.Generic;
using AthenaHealth.Sdk.Http.Helpers;
using AthenaHealth.Sdk.Models.Request;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Helpers
{
    public class UrlBuilderTests
    {
        [Fact]
        public void Url_CorrectUrlIsBuilt()
        {
            var baseUrl = new Uri("https://htdevelopers.com/patients");
            var queryParameters = new Dictionary<string, string>();
            queryParameters.Add("DepartmentId", "1");
            queryParameters.Add("ShowFullSsn", "true");

            Uri uri = UrlBuilder.BuildUri(baseUrl, queryParameters);
            uri.ToString().ShouldBe("https://htdevelopers.com/patients?DepartmentId=1&ShowFullSsn=true");
        }
    }
}