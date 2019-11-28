using System.Collections;
using System.Collections.Generic;

namespace AthenaHealth.Sdk.Tests.EndToEnd.Data.Patient
{
    public class GetPatientCustomFieldsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1 };
            yield return new object[] { 141 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}