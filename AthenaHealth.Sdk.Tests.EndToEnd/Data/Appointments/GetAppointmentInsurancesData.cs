using System.Collections;
using System.Collections.Generic;

// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Tests.EndToEnd.Data.Appointments
{
    public class GetAppointmentInsurancesData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {997681};
//            yield return new object[] {959979};
//            yield return new object[] {959985};
//            yield return new object[] {959989};
//            yield return new object[] {959993};
//            yield return new object[] {959206};
//            yield return new object[] {959027};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
