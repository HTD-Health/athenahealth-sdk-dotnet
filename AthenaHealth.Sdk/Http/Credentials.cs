namespace AthenaHealth.Sdk.Http
{
    public class Credentials
    {
        public string ClientId { get; }

        public string ClientSecret { get; }

        public Credentials(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
        }

        private Credentials()
        {
        }
    }
}
