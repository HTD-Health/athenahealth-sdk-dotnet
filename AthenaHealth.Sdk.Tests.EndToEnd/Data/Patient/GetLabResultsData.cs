using System.Collections;
using System.Collections.Generic;
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Tests.EndToEnd.Data.Patient
{
    public class GetLabResultsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1 };
            yield return new object[] { 1086 };
            //yield return new object[] { 128 };
            //yield return new object[] { 1609 };
            //yield return new object[] { 1658 };
            //yield return new object[] { 1916 };
            //yield return new object[] { 2204 };
            //yield return new object[] { 3307 };
            //yield return new object[] { 400 };
            //yield return new object[] { 407 };
            //yield return new object[] { 409 };
            //yield return new object[] { 410 };
            //yield return new object[] { 445 };
            //yield return new object[] { 446 };
            //yield return new object[] { 467 };
            //yield return new object[] { 490 };
            //yield return new object[] { 543 };
            //yield return new object[] { 78 };
            //yield return new object[] { 870 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
