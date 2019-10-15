using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Http.Adapter;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Http.Adapter
{
    public class AthenaResponsePipelineTests
    {
        [Fact]
        public void Response_Contains400_ChangesToError()
        {
            Response resp = new Response(HttpStatusCode.OK, "{\"status\": {\"code\": \"400\"}}", new Dictionary<string, string>(), null, true);
            var pipeline = new AthenaResponsePipeline();
            pipeline.Execute(resp);

            resp.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            resp.IsSuccessStatusCode.ShouldBe(false);
        }

        [Fact]
        public void Response_Contains200_ChangesToError()
        {
            Response resp = new Response(HttpStatusCode.OK, "{\"status\": {\"code\": \"200\"}}", new Dictionary<string, string>(), null, true);
            var pipeline = new AthenaResponsePipeline();
            pipeline.Execute(resp);

            resp.StatusCode.ShouldBe(HttpStatusCode.OK);
            resp.IsSuccessStatusCode.ShouldBe(false);
        }

        [Fact]
        public void Response_ContainsString_ThrowsException()
        {
            Response resp = new Response(HttpStatusCode.OK, "{\"status\": {\"code\": \"a\"}}", new Dictionary<string, string>(), null, true);
            var pipeline = new AthenaResponsePipeline();

            Should.Throw<InvalidCastException>(() => pipeline.Execute(resp));
        }
    }
}