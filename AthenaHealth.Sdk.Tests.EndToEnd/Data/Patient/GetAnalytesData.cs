using System.Collections;
using System.Collections.Generic;
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Tests.EndToEnd.Data.Patient
{
    public class GetAnalytesData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1 };
            yield return new object[] { 2204 };
            //yield return new object[] { 410 };
            //yield return new object[] { 870 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
