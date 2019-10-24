﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

namespace AthenaHealth.Sdk.Models.Request
{
    public class CreateDiagnoses
    {
        /// <summary>
        /// SNOMED code for this diagnosis.
        /// </summary>
        [Required]
        [JsonProperty("snomedcode")]
        public int SnomedCode { get; set; }

        /// <summary>
        /// ICD-10 code(s) for this diagnosis.
        /// </summary>
        [JsonProperty("icd10codes")]
        public string Icd10Codes { get; set; }

        /// <summary>
        /// ICD-9 code(s) for this diagnosis.
        /// </summary>
        [JsonProperty("icd9codes")]
        public string Icd9Codes { get; set; }

        /// <summary>
        /// The note to be entered for this diagnosis.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// Laterality of the SNOMED code.
        /// </summary>
        [JsonProperty("laterality")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public LateralityEnum? Laterality { get; set; }
    }

    public enum LateralityEnum
    {
        [EnumMember(Value = "LEFT")]
        Left,
        [EnumMember(Value = "RIGHT")]
        Right,
        [EnumMember(Value = "BILATERAL")]
        Bilateral
    }
}