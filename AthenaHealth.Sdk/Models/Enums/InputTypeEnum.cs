using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Enums
{
    public enum InputTypeEnum
    {
        /// <summary>
        /// A true/false field. A null/blank is equivalent to false.
        /// </summary>
        [EnumMember(Value = "CHECKBOX")] CheckBox,

        /// <summary>
        /// A Y/N/null field. N and null will show up as different in reconciliation.
        /// </summary>
        [EnumMember(Value = "YESNO")] YesNo,

        /// <summary>
        /// A selection from a list of valid values (given as a value/name pair).
        /// </summary>
        [EnumMember(Value = "DROPDOWN")] DropDown,

        /// <summary>
        /// A real number.
        /// </summary>
        [EnumMember(Value = "NUMERIC")] Numeric,

        /// <summary>
        /// A date in MM/DD/YYYY format.
        /// </summary>
        [EnumMember(Value = "DATE")] Date,

        /// <summary>
        /// A date in either YYYY, MM/YYYY, or MM/DD/YYYY format.
        /// </summary>
        [EnumMember(Value = "APPROXDATE")] ApproxDate,

        /// <summary>
        /// A free text field (the length is not well defined). Not currently used. (Used for
        /// RxNormName, but that shouldn't be an input field and will be deprecated from the
        /// fielddata list.)
        /// </summary>
        [EnumMember(Value = "FREETEXT")] FreeText,

        /// <summary>
        /// A read-only free text field. Currently only used for externalnote for medications with a
        /// particular practice setting.
        /// </summary>
        [EnumMember(Value = "HIDDEN")] Hidden,

        /// <summary>
        /// A free text field. While athena uses a drop down for it, users can enter any value in
        /// the UI.
        /// </summary>
        [EnumMember(Value = "AUTOCOMPLETE")] AutoComplete,
    }
}