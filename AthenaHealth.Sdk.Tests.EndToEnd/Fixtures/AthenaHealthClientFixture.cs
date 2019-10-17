namespace AthenaHealth.Sdk.Tests.EndToEnd.Fixtures
{
    public class AthenaHealthClientFixture
    {
        public IAthenaHealthClient Client { get; private set; }

        public AthenaHealthClientFixture()
        {
            Client = new AthenaHealthClient(ApiVersion.Preview, "6yspwuq3wnx5n37jp9phqsmt", "Y9UxkbBge5EXutR", 195900);
        }
    }
}
