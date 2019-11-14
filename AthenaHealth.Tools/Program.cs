using AthenaHealth.Tools.WebDocComparer;
using AthenaHealth.Tools.WebDocParser;

namespace AthenaHealth.Tools
{
    /// <summary>
    /// This project is just for development purposes and may be removed in the future
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Parser.ParseAndSave();
            Comparer.Compare();
        }
    }
}
