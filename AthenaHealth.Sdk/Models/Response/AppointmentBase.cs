using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public abstract class AppointmentBase
    {
        /// <summary>
        /// Appointment ID of the booked appointment
        /// </summary>
        [JsonProperty(PropertyName = "appointmentid")]
        public int Id { get; set; }

        /// <summary>
        /// A list of reason IDs that could be used for this slot.  Only present if multiple reason IDs are requested.
        /// </summary>
        [JsonProperty(PropertyName = "reasonid")]
        public int[] ReasonId { get; set; }

        /// <summary>
        /// In minutes
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// If true, this appointment slot is frozen
        /// </summary>
        [JsonProperty(PropertyName = "frozen")]
        public bool Frozen { get; set; }
        
        /// <summary>
        /// The practice-friendly (not patient friendly) name for this appointment type.  Note that this may not be the same as the booked appointment because of "generic" slots.
        /// </summary>
        [JsonProperty(PropertyName = "appointmenttype")]
        public string AppointmentType { get; set; }

        /// <summary>
        /// This is the ID for the appointment type.   Note that this may not be the same as the booked appointment because of "generic" slots.
        /// </summary>
        [JsonProperty(PropertyName = "appointmenttypeid")]
        public int? AppointmentTypeId { get; set; }

        /// <summary>
        /// The appointment date.
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }
        
        /// <summary>
        /// The patient-friendly name for this appointment type.  Note that this may not be the same as the booked appointment because of "generic" slots.
        /// </summary>
        [JsonProperty(PropertyName = "patientappointmenttypename")]
        public string PatientAppointmentTypeName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "providerid")]
        public int? ProviderId { get; set; }
        
        /// <summary>
        /// As HH:MM (where HH is the 0-23 hour and MM is the minute).  This time is local to the department.
        /// </summary>
        [JsonProperty(PropertyName = "starttime")]
        public string StartTime { get; set; } 
        
        /// <summary>
        /// The rendering provider ID.
        /// </summary>
        [JsonProperty(PropertyName = "renderingproviderid")]
        public int? RenderingProviderId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int? DepartmentId { get; set; }
    }
}
