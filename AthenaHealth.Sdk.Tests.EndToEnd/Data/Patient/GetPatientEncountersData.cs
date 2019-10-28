using System.Collections;
using System.Collections.Generic;

namespace AthenaHealth.Sdk.Tests.EndToEnd.Data.Patient
{
    public class GetPatientEncountersData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1 };
            yield return new object[] { 10074 };
            //yield return new object[] { 1086 };
            //yield return new object[] { 128 };
            //yield return new object[] { 1754 };
            //yield return new object[] { 1848 };
            //yield return new object[] { 1916 };
            //yield return new object[] { 1992 };
            //yield return new object[] { 2204 };
            //yield return new object[] { 2303 };
            //yield return new object[] { 2413 };
            //yield return new object[] { 2786 };
            //yield return new object[] { 28416 };
            //yield return new object[] { 2944 };
            //yield return new object[] { 31043 };
            //yield return new object[] { 3307 };
            //yield return new object[] { 3896 };
            //yield return new object[] { 4020 };
            //yield return new object[] { 410 };
            //yield return new object[] { 4136 };
            //yield return new object[] { 467 };
            //yield return new object[] { 486 };
            //yield return new object[] { 850 };
            //yield return new object[] { 870 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}