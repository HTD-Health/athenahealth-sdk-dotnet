using AthenaHealth.Sdk.Clients;
using AthenaHealth.Sdk.Http;

namespace AthenaHealth.Sdk
{
    public class AthenaHealthClient
    {
        public AthenaHealthClient(IConnection connection, int practiceId)
        {
            Connection = connection;
            PracticeId = practiceId;

            Patients = new PatientClient(connection);
        }

        public IConnection Connection { get; private set; }
        public IPatientClient Patients { get; private set; }
        public int PracticeId { get; set; }
    }
}