namespace AthenaHealth.Sdk
{
    public class ApiVersion
    {
        public static readonly ApiVersion V1 = new ApiVersion("oauth/token", "v1");

        public static readonly ApiVersion Preview = new ApiVersion("oauthpreview/token", "preview1");

        public static readonly ApiVersion OpenPreview = new ApiVersion("oauthopenpreview/token", "openpreview1");

        public string OAuthPath { get; }

        public string ApiPath { get; }

        internal ApiVersion(string oauthPath, string apiPath)
        {
            OAuthPath = oauthPath;
            ApiPath = apiPath;
        }
    }
}
