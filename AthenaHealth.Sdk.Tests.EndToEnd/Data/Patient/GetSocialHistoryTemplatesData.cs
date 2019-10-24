using System.Collections;
using System.Collections.Generic;

namespace AthenaHealth.Sdk.Tests.EndToEnd.Data.Patient
{
    public class GetSocialHistoryTemplatesData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 4020 };
            yield return new object[] { 850 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}