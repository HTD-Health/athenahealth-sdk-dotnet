using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class PatientGoals
    {
        /// <summary>
        /// List of goals for the patient resulting from this encounter.
        /// </summary>
        [JsonProperty("goals")]
        public Goal[] Goals { get; set; }

        /// <summary>
        /// Unstructured goal. More of a note field.
        /// </summary>
        [JsonProperty("freetextgoal")]
        public string FreeTextGoal { get; set; }

        /// <summary>
        /// Instructions to the patient about achieving these goals.
        /// </summary>
        [JsonProperty("patientinstructions")]
        public string PatientInstructions { get; set; }

        /// <summary>
        /// Further discussion notes about these patient goals.
        /// </summary>
        [JsonProperty("discussionnotes")]
        public string DiscussionNotes { get; set; }

        /// <summary>
        /// Tokens specifying a unique version of data in the database.
        /// </summary>
        [JsonProperty("versiontokens")]
        public VersionToken VersionTokens { get; set; }

        /// <summary>
        /// Lastmodified timestamps and usernames of data in the database
        /// </summary>
        [JsonProperty("auditinformation")]
        public AuditInfo AuditInformation { get; set; }

        public class Goal
        {
            /// <summary>
            /// Some goals have target values that include multiple parts. This output provides
            /// additional data that adds to or replaces the target value.
            /// </summary>
            [JsonProperty("compoundvalues")]
            public CompoundValue[] CompoundValues { get; set; }

            /// <summary>
            /// Clinical goal type. Usually a VITALS or a LABANALYTE.
            /// </summary>
            [JsonProperty("goaltype")]
            public string GoalType { get; set; }

            /// <summary>
            /// Display name of goal.
            /// </summary>
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// Goal target value.
            /// </summary>
            [JsonProperty("targetvalue")]
            public string TargetValue { get; set; }

            /// <summary>
            /// Expected time frame for reaching goal. This will not be returned if the goal has
            /// been met.
            /// </summary>
            [JsonProperty("duration")]
            public string Duration { get; set; }

            /// <summary>
            /// Status of goal. Null means not yet met. If met will have a value of MET.
            /// </summary>
            [JsonProperty("status")]
            public string Status { get; set; }

            /// <summary>
            /// Indicates primary goal. Value would be true if the goal is primary else false.
            /// </summary>
            [JsonProperty("isprimarygoal")]
            public bool IsPrimaryGoal { get; set; }

            public class CompoundValue
            {
                /// <summary>
                /// A key indentifying what information this compound value stores.
                /// </summary>
                [JsonProperty("compoundkey")]
                public string Key { get; set; }

                /// <summary>
                /// The target value for the compound value.
                /// </summary>
                [JsonProperty("compoundvalue")]
                public string Value { get; set; }
            }
        }

        public class VersionToken
        {
            /// <summary>
            /// The version token for free text goals.
            /// </summary>
            [JsonProperty("freetextgoal")]
            public string FreeTextGoal { get; set; }

            /// <summary>
            /// The version token for patient instructions.
            /// </summary>
            [JsonProperty("patientinstructions")]
            public string PatientInstructions { get; set; }

            /// <summary>
            /// The version token for discussion notes.
            /// </summary>
            [JsonProperty("discussionnotes")]
            public string DiscussionNotes { get; set; }
        }

        public class AuditInfo
        {
            /// <summary>
            /// Lastmodified timestamps and usernames of the freetext goal
            /// </summary>
            [JsonProperty("freetextgoal")]
            public AuditInfoElement FreeTextGoal { get; set; }

            /// <summary>
            /// Lastmodified timestamps and usernames of the patient instructions
            /// </summary>
            [JsonProperty("patientinstructions")]
            public AuditInfoElement PatientInstructions { get; set; }

            /// <summary>
            /// Lastmodified timestamps and usernames of the discussion notes
            /// </summary>
            [JsonProperty("discussionnotes")]
            public AuditInfoElement DiscussionNotes { get; set; }

            public class AuditInfoElement
            {
                /// <summary>
                /// The username of the user who last updated the discussion notes.
                /// </summary>
                [JsonProperty("lastmodifiedby")]
                public string LastModifiedBy { get; set; }

                /// <summary>
                /// The date and time the discussion notes were last modified.
                /// </summary>
                [JsonProperty("lastmodifieddatetime")]
                public string LastModifiedDateTime { get; set; }
            }
        }
    }
}
