namespace AthenaHealth.Sdk.Http
{
    public class Credentials
    {
        public Credentials(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
        }

        private Credentials()
        {
        }

        public string ClientId { get; }
        public string ClientSecret { get; }
        public int PracticeId { get; set; }
    }
}