using System.Collections;
using System.Collections.Generic;

namespace AthenaHealth.Sdk.Tests.EndToEnd.Data.Appointments
{
    public class GetReminderByIdData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 15042 };
            yield return new object[] { 15043 };
            yield return new object[] { 15044 };
            yield return new object[] { 15099 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}