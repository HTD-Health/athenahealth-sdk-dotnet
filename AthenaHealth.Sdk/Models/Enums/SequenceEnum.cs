// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo

using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum SequenceEnum
    {
        [EnumMember(Value = "1")] Primary,
        [EnumMember(Value = "2")] Secondary
    }
}
