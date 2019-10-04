using System;
using System.Collections.Generic;
using System.Text;
using AthenaHealth.Sdk.Clients;
using AthenaHealth.Sdk.Http;

namespace AthenaHealth.Sdk
{
    public class AthenaHealthClient
    {
        public int PracticeId { get; set; }
        public IConnection Connection { get; private set; }
        public IPatientClient Patients { get; private set; }

        public AthenaHealthClient(IConnection connection, int practiceId)
        {
            Connection = connection;
            PracticeId = practiceId;

            Patients = new PatientClient(connection);
        }



    }
}
