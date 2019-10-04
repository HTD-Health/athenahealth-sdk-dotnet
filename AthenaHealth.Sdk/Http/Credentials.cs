namespace AthenaHealth.Sdk.Http
{
    public class Credentials
    {
        private Credentials()
        {
            
        }

        public Credentials(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public string Login
        {
            get;
            private set;
        }

        public string Password
        {
            get;
            private set;
        }
    }
}