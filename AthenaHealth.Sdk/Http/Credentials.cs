namespace AthenaHealth.Sdk.Http
{
    public class Credentials
    {
        public Credentials(string login, string password)
        {
            Login = login;
            Password = password;
        }

        private Credentials()
        {
        }

        public string Login { get; }
        public string Password { get; }
    }
}