<a name='assembly'></a>
# AthenaHealth.Sdk

## Contents

- [AddDocument](#T-AthenaHealth-Sdk-Models-Request-AddDocument 'AthenaHealth.Sdk.Models.Request.AddDocument')
  - [ActionNote](#P-AthenaHealth-Sdk-Models-Request-AddDocument-ActionNote 'AthenaHealth.Sdk.Models.Request.AddDocument.ActionNote')
  - [AppointmentId](#P-AthenaHealth-Sdk-Models-Request-AddDocument-AppointmentId 'AthenaHealth.Sdk.Models.Request.AddDocument.AppointmentId')
  - [Attachment](#P-AthenaHealth-Sdk-Models-Request-AddDocument-Attachment 'AthenaHealth.Sdk.Models.Request.AddDocument.Attachment')
  - [AutoClose](#P-AthenaHealth-Sdk-Models-Request-AddDocument-AutoClose 'AthenaHealth.Sdk.Models.Request.AddDocument.AutoClose')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-AddDocument-DepartmentId 'AthenaHealth.Sdk.Models.Request.AddDocument.DepartmentId')
  - [DocumentSubclass](#P-AthenaHealth-Sdk-Models-Request-AddDocument-DocumentSubclass 'AthenaHealth.Sdk.Models.Request.AddDocument.DocumentSubclass')
  - [InternalNote](#P-AthenaHealth-Sdk-Models-Request-AddDocument-InternalNote 'AthenaHealth.Sdk.Models.Request.AddDocument.InternalNote')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Request-AddDocument-ProviderId 'AthenaHealth.Sdk.Models.Request.AddDocument.ProviderId')
- [AddMedication](#T-AthenaHealth-Sdk-Models-Response-AddMedication 'AthenaHealth.Sdk.Models.Response.AddMedication')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Response-AddMedication-DepartmentId 'AthenaHealth.Sdk.Models.Response.AddMedication.DepartmentId')
  - [IsHidden](#P-AthenaHealth-Sdk-Models-Response-AddMedication-IsHidden 'AthenaHealth.Sdk.Models.Response.AddMedication.IsHidden')
  - [MedicationId](#P-AthenaHealth-Sdk-Models-Response-AddMedication-MedicationId 'AthenaHealth.Sdk.Models.Response.AddMedication.MedicationId')
  - [PatientNote](#P-AthenaHealth-Sdk-Models-Response-AddMedication-PatientNote 'AthenaHealth.Sdk.Models.Response.AddMedication.PatientNote')
  - [ProviderNote](#P-AthenaHealth-Sdk-Models-Response-AddMedication-ProviderNote 'AthenaHealth.Sdk.Models.Response.AddMedication.ProviderNote')
  - [StartDate](#P-AthenaHealth-Sdk-Models-Response-AddMedication-StartDate 'AthenaHealth.Sdk.Models.Response.AddMedication.StartDate')
  - [StopDate](#P-AthenaHealth-Sdk-Models-Response-AddMedication-StopDate 'AthenaHealth.Sdk.Models.Response.AddMedication.StopDate')
  - [StopReason](#P-AthenaHealth-Sdk-Models-Response-AddMedication-StopReason 'AthenaHealth.Sdk.Models.Response.AddMedication.StopReason')
  - [UnstructuredSig](#P-AthenaHealth-Sdk-Models-Response-AddMedication-UnstructuredSig 'AthenaHealth.Sdk.Models.Response.AddMedication.UnstructuredSig')
- [AddProblem](#T-AthenaHealth-Sdk-Models-Request-AddProblem 'AthenaHealth.Sdk.Models.Request.AddProblem')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-AddProblem-DepartmentId 'AthenaHealth.Sdk.Models.Request.AddProblem.DepartmentId')
  - [Laterality](#P-AthenaHealth-Sdk-Models-Request-AddProblem-Laterality 'AthenaHealth.Sdk.Models.Request.AddProblem.Laterality')
  - [Note](#P-AthenaHealth-Sdk-Models-Request-AddProblem-Note 'AthenaHealth.Sdk.Models.Request.AddProblem.Note')
  - [SnomedCode](#P-AthenaHealth-Sdk-Models-Request-AddProblem-SnomedCode 'AthenaHealth.Sdk.Models.Request.AddProblem.SnomedCode')
  - [StartDate](#P-AthenaHealth-Sdk-Models-Request-AddProblem-StartDate 'AthenaHealth.Sdk.Models.Request.AddProblem.StartDate')
  - [Status](#P-AthenaHealth-Sdk-Models-Request-AddProblem-Status 'AthenaHealth.Sdk.Models.Request.AddProblem.Status')
- [AddProblemResponse](#T-AthenaHealth-Sdk-Models-Response-AddProblemResponse 'AthenaHealth.Sdk.Models.Response.AddProblemResponse')
  - [ErrorMessage](#P-AthenaHealth-Sdk-Models-Response-AddProblemResponse-ErrorMessage 'AthenaHealth.Sdk.Models.Response.AddProblemResponse.ErrorMessage')
  - [ProblemId](#P-AthenaHealth-Sdk-Models-Response-AddProblemResponse-ProblemId 'AthenaHealth.Sdk.Models.Response.AddProblemResponse.ProblemId')
  - [Success](#P-AthenaHealth-Sdk-Models-Response-AddProblemResponse-Success 'AthenaHealth.Sdk.Models.Response.AddProblemResponse.Success')
- [AddToWaitListRequest](#T-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest')
  - [#ctor(patientId)](#M-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-#ctor-System-Int32- 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest.#ctor(System.Int32)')
  - [AllowAnyDepartment](#P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-AllowAnyDepartment 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest.AllowAnyDepartment')
  - [AppointmentId](#P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-AppointmentId 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest.AppointmentId')
  - [AppointmentTypeId](#P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-AppointmentTypeId 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest.AppointmentTypeId')
  - [DayOfWeekIds](#P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-DayOfWeekIds 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest.DayOfWeekIds')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-DepartmentId 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest.DepartmentId')
  - [HourFrom](#P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-HourFrom 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest.HourFrom')
  - [HourTo](#P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-HourTo 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest.HourTo')
  - [Note](#P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-Note 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest.Note')
  - [PatientId](#P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-PatientId 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest.PatientId')
  - [Priority](#P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-Priority 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest.Priority')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-ProviderId 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest.ProviderId')
- [AddToWaitListResponse](#T-AthenaHealth-Sdk-Models-Response-AddToWaitListResponse 'AthenaHealth.Sdk.Models.Response.AddToWaitListResponse')
  - [WaitListId](#P-AthenaHealth-Sdk-Models-Response-AddToWaitListResponse-WaitListId 'AthenaHealth.Sdk.Models.Response.AddToWaitListResponse.WaitListId')
- [Allergy](#T-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.Allergy')
- [Allergy](#T-AthenaHealth-Sdk-Models-Response-Allergy 'AthenaHealth.Sdk.Models.Response.Allergy')
- [Allergy](#T-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy')
  - [AllergenName](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-AllergenName 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.Allergy.AllergenName')
  - [DeactivateDate](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-DeactivateDate 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.Allergy.DeactivateDate')
  - [Id](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Id 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.Allergy.Id')
  - [Note](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Note 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.Allergy.Note')
  - [OnsetDate](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-OnsetDate 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.Allergy.OnsetDate')
  - [Reactions](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Reactions 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.Allergy.Reactions')
  - [ReactivateDate](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-ReactivateDate 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.Allergy.ReactivateDate')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-Allergy-Id 'AthenaHealth.Sdk.Models.Response.Allergy.Id')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-Allergy-Name 'AthenaHealth.Sdk.Models.Response.Allergy.Name')
  - [AllergenId](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-AllergenId 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy.AllergenId')
  - [AllergenName](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-AllergenName 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy.AllergenName')
  - [DeactivateDate](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-DeactivateDate 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy.DeactivateDate')
  - [DeactivatedUser](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-DeactivatedUser 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy.DeactivatedUser')
  - [LastModifiedBy](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-LastModifiedBy 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy.LastModifiedBy')
  - [LastModifiedDateTime](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-LastModifiedDateTime 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy.LastModifiedDateTime')
  - [Note](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-Note 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy.Note')
  - [OnsetDate](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-OnsetDate 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy.OnsetDate')
  - [Reactions](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-Reactions 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy.Reactions')
- [Analyte](#T-AthenaHealth-Sdk-Models-Response-Analyte 'AthenaHealth.Sdk.Models.Response.Analyte')
- [Analyte](#T-AthenaHealth-Sdk-Models-Response-LabResult-Analyte 'AthenaHealth.Sdk.Models.Response.LabResult.Analyte')
  - [AbnormalFlag](#P-AthenaHealth-Sdk-Models-Response-Analyte-AbnormalFlag 'AthenaHealth.Sdk.Models.Response.Analyte.AbnormalFlag')
  - [AbnormalHL7Code](#P-AthenaHealth-Sdk-Models-Response-Analyte-AbnormalHL7Code 'AthenaHealth.Sdk.Models.Response.Analyte.AbnormalHL7Code')
  - [AbnormalHL7Name](#P-AthenaHealth-Sdk-Models-Response-Analyte-AbnormalHL7Name 'AthenaHealth.Sdk.Models.Response.Analyte.AbnormalHL7Name')
  - [AnalyteDate](#P-AthenaHealth-Sdk-Models-Response-Analyte-AnalyteDate 'AthenaHealth.Sdk.Models.Response.Analyte.AnalyteDate')
  - [AnalyteId](#P-AthenaHealth-Sdk-Models-Response-Analyte-AnalyteId 'AthenaHealth.Sdk.Models.Response.Analyte.AnalyteId')
  - [AnalyteName](#P-AthenaHealth-Sdk-Models-Response-Analyte-AnalyteName 'AthenaHealth.Sdk.Models.Response.Analyte.AnalyteName')
  - [Description](#P-AthenaHealth-Sdk-Models-Response-Analyte-Description 'AthenaHealth.Sdk.Models.Response.Analyte.Description')
  - [LOINC](#P-AthenaHealth-Sdk-Models-Response-Analyte-LOINC 'AthenaHealth.Sdk.Models.Response.Analyte.LOINC')
  - [LabResultStatus](#P-AthenaHealth-Sdk-Models-Response-Analyte-LabResultStatus 'AthenaHealth.Sdk.Models.Response.Analyte.LabResultStatus')
  - [Note](#P-AthenaHealth-Sdk-Models-Response-Analyte-Note 'AthenaHealth.Sdk.Models.Response.Analyte.Note')
  - [ReferenceRange](#P-AthenaHealth-Sdk-Models-Response-Analyte-ReferenceRange 'AthenaHealth.Sdk.Models.Response.Analyte.ReferenceRange')
  - [ResultStatus](#P-AthenaHealth-Sdk-Models-Response-Analyte-ResultStatus 'AthenaHealth.Sdk.Models.Response.Analyte.ResultStatus')
  - [Units](#P-AthenaHealth-Sdk-Models-Response-Analyte-Units 'AthenaHealth.Sdk.Models.Response.Analyte.Units')
  - [Value](#P-AthenaHealth-Sdk-Models-Response-Analyte-Value 'AthenaHealth.Sdk.Models.Response.Analyte.Value')
  - [AbnormalFlag](#P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-AbnormalFlag 'AthenaHealth.Sdk.Models.Response.LabResult.Analyte.AbnormalFlag')
  - [AbnormalHL7Code](#P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-AbnormalHL7Code 'AthenaHealth.Sdk.Models.Response.LabResult.Analyte.AbnormalHL7Code')
  - [AbnormalHL7Name](#P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-AbnormalHL7Name 'AthenaHealth.Sdk.Models.Response.LabResult.Analyte.AbnormalHL7Name')
  - [AnalyteDate](#P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-AnalyteDate 'AthenaHealth.Sdk.Models.Response.LabResult.Analyte.AnalyteDate')
  - [AnalyteDateTime](#P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-AnalyteDateTime 'AthenaHealth.Sdk.Models.Response.LabResult.Analyte.AnalyteDateTime')
  - [AnalyteId](#P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-AnalyteId 'AthenaHealth.Sdk.Models.Response.LabResult.Analyte.AnalyteId')
  - [AnalyteName](#P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-AnalyteName 'AthenaHealth.Sdk.Models.Response.LabResult.Analyte.AnalyteName')
  - [Description](#P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-Description 'AthenaHealth.Sdk.Models.Response.LabResult.Analyte.Description')
  - [LOINC](#P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-LOINC 'AthenaHealth.Sdk.Models.Response.LabResult.Analyte.LOINC')
  - [Note](#P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-Note 'AthenaHealth.Sdk.Models.Response.LabResult.Analyte.Note')
  - [ReferenceRange](#P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-ReferenceRange 'AthenaHealth.Sdk.Models.Response.LabResult.Analyte.ReferenceRange')
  - [ResultStatus](#P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-ResultStatus 'AthenaHealth.Sdk.Models.Response.LabResult.Analyte.ResultStatus')
  - [Units](#P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-Units 'AthenaHealth.Sdk.Models.Response.LabResult.Analyte.Units')
  - [Value](#P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-Value 'AthenaHealth.Sdk.Models.Response.LabResult.Analyte.Value')
- [Appointment](#T-AthenaHealth-Sdk-Models-Response-Appointment 'AthenaHealth.Sdk.Models.Response.Appointment')
  - [AppointmentConfirmationId](#P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentConfirmationId 'AthenaHealth.Sdk.Models.Response.Appointment.AppointmentConfirmationId')
  - [AppointmentConfirmationName](#P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentConfirmationName 'AthenaHealth.Sdk.Models.Response.Appointment.AppointmentConfirmationName')
  - [AppointmentCopay](#P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentCopay 'AthenaHealth.Sdk.Models.Response.Appointment.AppointmentCopay')
  - [AppointmentNotes](#P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentNotes 'AthenaHealth.Sdk.Models.Response.Appointment.AppointmentNotes')
  - [AppointmentStatus](#P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentStatus 'AthenaHealth.Sdk.Models.Response.Appointment.AppointmentStatus')
  - [CancelReasonId](#P-AthenaHealth-Sdk-Models-Response-Appointment-CancelReasonId 'AthenaHealth.Sdk.Models.Response.Appointment.CancelReasonId')
  - [CancelReasonName](#P-AthenaHealth-Sdk-Models-Response-Appointment-CancelReasonName 'AthenaHealth.Sdk.Models.Response.Appointment.CancelReasonName')
  - [CancelReasonNoShow](#P-AthenaHealth-Sdk-Models-Response-Appointment-CancelReasonNoShow 'AthenaHealth.Sdk.Models.Response.Appointment.CancelReasonNoShow')
  - [CancelReasonSlotAvailable](#P-AthenaHealth-Sdk-Models-Response-Appointment-CancelReasonSlotAvailable 'AthenaHealth.Sdk.Models.Response.Appointment.CancelReasonSlotAvailable')
  - [CancelledBy](#P-AthenaHealth-Sdk-Models-Response-Appointment-CancelledBy 'AthenaHealth.Sdk.Models.Response.Appointment.CancelledBy')
  - [CancelledDateTime](#P-AthenaHealth-Sdk-Models-Response-Appointment-CancelledDateTime 'AthenaHealth.Sdk.Models.Response.Appointment.CancelledDateTime')
  - [ChargeEntryNotRequired](#P-AthenaHealth-Sdk-Models-Response-Appointment-ChargeEntryNotRequired 'AthenaHealth.Sdk.Models.Response.Appointment.ChargeEntryNotRequired')
  - [ChargeEntryNotRequiredReason](#P-AthenaHealth-Sdk-Models-Response-Appointment-ChargeEntryNotRequiredReason 'AthenaHealth.Sdk.Models.Response.Appointment.ChargeEntryNotRequiredReason')
  - [CheckInDateTime](#P-AthenaHealth-Sdk-Models-Response-Appointment-CheckInDateTime 'AthenaHealth.Sdk.Models.Response.Appointment.CheckInDateTime')
  - [CheckoutDateTime](#P-AthenaHealth-Sdk-Models-Response-Appointment-CheckoutDateTime 'AthenaHealth.Sdk.Models.Response.Appointment.CheckoutDateTime')
  - [Claims](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claims 'AthenaHealth.Sdk.Models.Response.Appointment.Claims')
  - [CoordinatorEnterprise](#P-AthenaHealth-Sdk-Models-Response-Appointment-CoordinatorEnterprise 'AthenaHealth.Sdk.Models.Response.Appointment.CoordinatorEnterprise')
  - [Copay](#P-AthenaHealth-Sdk-Models-Response-Appointment-Copay 'AthenaHealth.Sdk.Models.Response.Appointment.Copay')
  - [EncounterId](#P-AthenaHealth-Sdk-Models-Response-Appointment-EncounterId 'AthenaHealth.Sdk.Models.Response.Appointment.EncounterId')
  - [EncounterPrep](#P-AthenaHealth-Sdk-Models-Response-Appointment-EncounterPrep 'AthenaHealth.Sdk.Models.Response.Appointment.EncounterPrep')
  - [EncounterState](#P-AthenaHealth-Sdk-Models-Response-Appointment-EncounterState 'AthenaHealth.Sdk.Models.Response.Appointment.EncounterState')
  - [EncounterStatus](#P-AthenaHealth-Sdk-Models-Response-Appointment-EncounterStatus 'AthenaHealth.Sdk.Models.Response.Appointment.EncounterStatus')
  - [Hl7ProviderId](#P-AthenaHealth-Sdk-Models-Response-Appointment-Hl7ProviderId 'AthenaHealth.Sdk.Models.Response.Appointment.Hl7ProviderId')
  - [Insurances](#P-AthenaHealth-Sdk-Models-Response-Appointment-Insurances 'AthenaHealth.Sdk.Models.Response.Appointment.Insurances')
  - [LastModified](#P-AthenaHealth-Sdk-Models-Response-Appointment-LastModified 'AthenaHealth.Sdk.Models.Response.Appointment.LastModified')
  - [LastModifiedBy](#P-AthenaHealth-Sdk-Models-Response-Appointment-LastModifiedBy 'AthenaHealth.Sdk.Models.Response.Appointment.LastModifiedBy')
  - [Patient](#P-AthenaHealth-Sdk-Models-Response-Appointment-Patient 'AthenaHealth.Sdk.Models.Response.Appointment.Patient')
  - [PatientId](#P-AthenaHealth-Sdk-Models-Response-Appointment-PatientId 'AthenaHealth.Sdk.Models.Response.Appointment.PatientId')
  - [PatientLocationId](#P-AthenaHealth-Sdk-Models-Response-Appointment-PatientLocationId 'AthenaHealth.Sdk.Models.Response.Appointment.PatientLocationId')
  - [ReferringProviderId](#P-AthenaHealth-Sdk-Models-Response-Appointment-ReferringProviderId 'AthenaHealth.Sdk.Models.Response.Appointment.ReferringProviderId')
  - [ReminderDetails](#P-AthenaHealth-Sdk-Models-Response-Appointment-ReminderDetails 'AthenaHealth.Sdk.Models.Response.Appointment.ReminderDetails')
  - [RescheduledAppointmentId](#P-AthenaHealth-Sdk-Models-Response-Appointment-RescheduledAppointmentId 'AthenaHealth.Sdk.Models.Response.Appointment.RescheduledAppointmentId')
  - [ScheduledBy](#P-AthenaHealth-Sdk-Models-Response-Appointment-ScheduledBy 'AthenaHealth.Sdk.Models.Response.Appointment.ScheduledBy')
  - [ScheduledDateTime](#P-AthenaHealth-Sdk-Models-Response-Appointment-ScheduledDateTime 'AthenaHealth.Sdk.Models.Response.Appointment.ScheduledDateTime')
  - [StartCheckIn](#P-AthenaHealth-Sdk-Models-Response-Appointment-StartCheckIn 'AthenaHealth.Sdk.Models.Response.Appointment.StartCheckIn')
  - [StartCheckOutDateTime](#P-AthenaHealth-Sdk-Models-Response-Appointment-StartCheckOutDateTime 'AthenaHealth.Sdk.Models.Response.Appointment.StartCheckOutDateTime')
  - [StopCheckIn](#P-AthenaHealth-Sdk-Models-Response-Appointment-StopCheckIn 'AthenaHealth.Sdk.Models.Response.Appointment.StopCheckIn')
  - [StopExamDateTime](#P-AthenaHealth-Sdk-Models-Response-Appointment-StopExamDateTime 'AthenaHealth.Sdk.Models.Response.Appointment.StopExamDateTime')
  - [StopIntakeDateTime](#P-AthenaHealth-Sdk-Models-Response-Appointment-StopIntakeDateTime 'AthenaHealth.Sdk.Models.Response.Appointment.StopIntakeDateTime')
  - [SuggestedOverBooking](#P-AthenaHealth-Sdk-Models-Response-Appointment-SuggestedOverBooking 'AthenaHealth.Sdk.Models.Response.Appointment.SuggestedOverBooking')
  - [SupervisingProviderId](#P-AthenaHealth-Sdk-Models-Response-Appointment-SupervisingProviderId 'AthenaHealth.Sdk.Models.Response.Appointment.SupervisingProviderId')
  - [TemplateAppointmentId](#P-AthenaHealth-Sdk-Models-Response-Appointment-TemplateAppointmentId 'AthenaHealth.Sdk.Models.Response.Appointment.TemplateAppointmentId')
  - [TemplateAppointmentTypeId](#P-AthenaHealth-Sdk-Models-Response-Appointment-TemplateAppointmentTypeId 'AthenaHealth.Sdk.Models.Response.Appointment.TemplateAppointmentTypeId')
  - [Urgent](#P-AthenaHealth-Sdk-Models-Response-Appointment-Urgent 'AthenaHealth.Sdk.Models.Response.Appointment.Urgent')
  - [UseExpectedProcedureCodes](#P-AthenaHealth-Sdk-Models-Response-Appointment-UseExpectedProcedureCodes 'AthenaHealth.Sdk.Models.Response.Appointment.UseExpectedProcedureCodes')
- [AppointmentBase](#T-AthenaHealth-Sdk-Models-Response-AppointmentBase 'AthenaHealth.Sdk.Models.Response.AppointmentBase')
  - [AppointmentType](#P-AthenaHealth-Sdk-Models-Response-AppointmentBase-AppointmentType 'AthenaHealth.Sdk.Models.Response.AppointmentBase.AppointmentType')
  - [AppointmentTypeId](#P-AthenaHealth-Sdk-Models-Response-AppointmentBase-AppointmentTypeId 'AthenaHealth.Sdk.Models.Response.AppointmentBase.AppointmentTypeId')
  - [Date](#P-AthenaHealth-Sdk-Models-Response-AppointmentBase-Date 'AthenaHealth.Sdk.Models.Response.AppointmentBase.Date')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Response-AppointmentBase-DepartmentId 'AthenaHealth.Sdk.Models.Response.AppointmentBase.DepartmentId')
  - [Duration](#P-AthenaHealth-Sdk-Models-Response-AppointmentBase-Duration 'AthenaHealth.Sdk.Models.Response.AppointmentBase.Duration')
  - [Frozen](#P-AthenaHealth-Sdk-Models-Response-AppointmentBase-Frozen 'AthenaHealth.Sdk.Models.Response.AppointmentBase.Frozen')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-AppointmentBase-Id 'AthenaHealth.Sdk.Models.Response.AppointmentBase.Id')
  - [PatientAppointmentTypeName](#P-AthenaHealth-Sdk-Models-Response-AppointmentBase-PatientAppointmentTypeName 'AthenaHealth.Sdk.Models.Response.AppointmentBase.PatientAppointmentTypeName')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Response-AppointmentBase-ProviderId 'AthenaHealth.Sdk.Models.Response.AppointmentBase.ProviderId')
  - [ReasonId](#P-AthenaHealth-Sdk-Models-Response-AppointmentBase-ReasonId 'AthenaHealth.Sdk.Models.Response.AppointmentBase.ReasonId')
  - [RenderingProviderId](#P-AthenaHealth-Sdk-Models-Response-AppointmentBase-RenderingProviderId 'AthenaHealth.Sdk.Models.Response.AppointmentBase.RenderingProviderId')
  - [StartTime](#P-AthenaHealth-Sdk-Models-Response-AppointmentBase-StartTime 'AthenaHealth.Sdk.Models.Response.AppointmentBase.StartTime')
- [AppointmentCopayModel](#T-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentCopayModel 'AthenaHealth.Sdk.Models.Response.Appointment.AppointmentCopayModel')
  - [CollectedForAppointment](#P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentCopayModel-CollectedForAppointment 'AthenaHealth.Sdk.Models.Response.Appointment.AppointmentCopayModel.CollectedForAppointment')
  - [CollectedForOther](#P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentCopayModel-CollectedForOther 'AthenaHealth.Sdk.Models.Response.Appointment.AppointmentCopayModel.CollectedForOther')
  - [InsuranceCopay](#P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentCopayModel-InsuranceCopay 'AthenaHealth.Sdk.Models.Response.Appointment.AppointmentCopayModel.InsuranceCopay')
- [AppointmentNote](#T-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentNote 'AthenaHealth.Sdk.Models.Response.Appointment.AppointmentNote')
- [AppointmentNote](#T-AthenaHealth-Sdk-Models-Response-AppointmentNote 'AthenaHealth.Sdk.Models.Response.AppointmentNote')
  - [DisplayOnSchedule](#P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentNote-DisplayOnSchedule 'AthenaHealth.Sdk.Models.Response.Appointment.AppointmentNote.DisplayOnSchedule')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentNote-Id 'AthenaHealth.Sdk.Models.Response.Appointment.AppointmentNote.Id')
  - [Text](#P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentNote-Text 'AthenaHealth.Sdk.Models.Response.Appointment.AppointmentNote.Text')
  - [CreatedAt](#P-AthenaHealth-Sdk-Models-Response-AppointmentNote-CreatedAt 'AthenaHealth.Sdk.Models.Response.AppointmentNote.CreatedAt')
  - [CreatedBy](#P-AthenaHealth-Sdk-Models-Response-AppointmentNote-CreatedBy 'AthenaHealth.Sdk.Models.Response.AppointmentNote.CreatedBy')
  - [DeletedAt](#P-AthenaHealth-Sdk-Models-Response-AppointmentNote-DeletedAt 'AthenaHealth.Sdk.Models.Response.AppointmentNote.DeletedAt')
  - [DeletedBy](#P-AthenaHealth-Sdk-Models-Response-AppointmentNote-DeletedBy 'AthenaHealth.Sdk.Models.Response.AppointmentNote.DeletedBy')
  - [DisplayOnSchedule](#P-AthenaHealth-Sdk-Models-Response-AppointmentNote-DisplayOnSchedule 'AthenaHealth.Sdk.Models.Response.AppointmentNote.DisplayOnSchedule')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-AppointmentNote-Id 'AthenaHealth.Sdk.Models.Response.AppointmentNote.Id')
  - [Text](#P-AthenaHealth-Sdk-Models-Response-AppointmentNote-Text 'AthenaHealth.Sdk.Models.Response.AppointmentNote.Text')
  - [UpdatedAt](#P-AthenaHealth-Sdk-Models-Response-AppointmentNote-UpdatedAt 'AthenaHealth.Sdk.Models.Response.AppointmentNote.UpdatedAt')
  - [UpdatedBy](#P-AthenaHealth-Sdk-Models-Response-AppointmentNote-UpdatedBy 'AthenaHealth.Sdk.Models.Response.AppointmentNote.UpdatedBy')
- [AppointmentReason](#T-AthenaHealth-Sdk-Models-Response-AppointmentReason 'AthenaHealth.Sdk.Models.Response.AppointmentReason')
  - [Description](#P-AthenaHealth-Sdk-Models-Response-AppointmentReason-Description 'AthenaHealth.Sdk.Models.Response.AppointmentReason.Description')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-AppointmentReason-Id 'AthenaHealth.Sdk.Models.Response.AppointmentReason.Id')
  - [Reason](#P-AthenaHealth-Sdk-Models-Response-AppointmentReason-Reason 'AthenaHealth.Sdk.Models.Response.AppointmentReason.Reason')
  - [ReasonType](#P-AthenaHealth-Sdk-Models-Response-AppointmentReason-ReasonType 'AthenaHealth.Sdk.Models.Response.AppointmentReason.ReasonType')
  - [SchedulingMaxDays](#P-AthenaHealth-Sdk-Models-Response-AppointmentReason-SchedulingMaxDays 'AthenaHealth.Sdk.Models.Response.AppointmentReason.SchedulingMaxDays')
  - [SchedulingMinHours](#P-AthenaHealth-Sdk-Models-Response-AppointmentReason-SchedulingMinHours 'AthenaHealth.Sdk.Models.Response.AppointmentReason.SchedulingMinHours')
- [AppointmentReminder](#T-AthenaHealth-Sdk-Models-Response-AppointmentReminder 'AthenaHealth.Sdk.Models.Response.AppointmentReminder')
  - [AppointmentTypeId](#P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-AppointmentTypeId 'AthenaHealth.Sdk.Models.Response.AppointmentReminder.AppointmentTypeId')
  - [ApproximateDate](#P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-ApproximateDate 'AthenaHealth.Sdk.Models.Response.AppointmentReminder.ApproximateDate')
  - [DeletedAt](#P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-DeletedAt 'AthenaHealth.Sdk.Models.Response.AppointmentReminder.DeletedAt')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-DepartmentId 'AthenaHealth.Sdk.Models.Response.AppointmentReminder.DepartmentId')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-Id 'AthenaHealth.Sdk.Models.Response.AppointmentReminder.Id')
  - [Note](#P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-Note 'AthenaHealth.Sdk.Models.Response.AppointmentReminder.Note')
  - [PatientId](#P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-PatientId 'AthenaHealth.Sdk.Models.Response.AppointmentReminder.PatientId')
  - [PatientInstructions](#P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-PatientInstructions 'AthenaHealth.Sdk.Models.Response.AppointmentReminder.PatientInstructions')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-ProviderId 'AthenaHealth.Sdk.Models.Response.AppointmentReminder.ProviderId')
  - [Status](#P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-Status 'AthenaHealth.Sdk.Models.Response.AppointmentReminder.Status')
- [AppointmentSlot](#T-AthenaHealth-Sdk-Models-Response-AppointmentSlot 'AthenaHealth.Sdk.Models.Response.AppointmentSlot')
  - [LocalProviderId](#P-AthenaHealth-Sdk-Models-Response-AppointmentSlot-LocalProviderId 'AthenaHealth.Sdk.Models.Response.AppointmentSlot.LocalProviderId')
  - [ValidAppointmentTypeIds](#P-AthenaHealth-Sdk-Models-Response-AppointmentSlot-ValidAppointmentTypeIds 'AthenaHealth.Sdk.Models.Response.AppointmentSlot.ValidAppointmentTypeIds')
- [AppointmentSlotCreationResponse](#T-AthenaHealth-Sdk-Models-Response-AppointmentSlotCreationResponse 'AthenaHealth.Sdk.Models.Response.AppointmentSlotCreationResponse')
  - [AppointmentIds](#P-AthenaHealth-Sdk-Models-Response-AppointmentSlotCreationResponse-AppointmentIds 'AthenaHealth.Sdk.Models.Response.AppointmentSlotCreationResponse.AppointmentIds')
- [AppointmentSubscriptionEvent](#T-AthenaHealth-Sdk-Models-Response-AppointmentSubscriptionEvent 'AthenaHealth.Sdk.Models.Response.AppointmentSubscriptionEvent')
  - [Status](#P-AthenaHealth-Sdk-Models-Response-AppointmentSubscriptionEvent-Status 'AthenaHealth.Sdk.Models.Response.AppointmentSubscriptionEvent.Status')
  - [Subscriptions](#P-AthenaHealth-Sdk-Models-Response-AppointmentSubscriptionEvent-Subscriptions 'AthenaHealth.Sdk.Models.Response.AppointmentSubscriptionEvent.Subscriptions')
- [AppointmentType](#T-AthenaHealth-Sdk-Models-Response-AppointmentType 'AthenaHealth.Sdk.Models.Response.AppointmentType')
  - [BlockSchedule](#P-AthenaHealth-Sdk-Models-Response-AppointmentType-BlockSchedule 'AthenaHealth.Sdk.Models.Response.AppointmentType.BlockSchedule')
  - [CreateEncounterOnCheckIn](#P-AthenaHealth-Sdk-Models-Response-AppointmentType-CreateEncounterOnCheckIn 'AthenaHealth.Sdk.Models.Response.AppointmentType.CreateEncounterOnCheckIn')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Response-AppointmentType-DepartmentId 'AthenaHealth.Sdk.Models.Response.AppointmentType.DepartmentId')
  - [Duration](#P-AthenaHealth-Sdk-Models-Response-AppointmentType-Duration 'AthenaHealth.Sdk.Models.Response.AppointmentType.Duration')
  - [Generic](#P-AthenaHealth-Sdk-Models-Response-AppointmentType-Generic 'AthenaHealth.Sdk.Models.Response.AppointmentType.Generic')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-AppointmentType-Id 'AthenaHealth.Sdk.Models.Response.AppointmentType.Id')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-AppointmentType-Name 'AthenaHealth.Sdk.Models.Response.AppointmentType.Name')
  - [Patient](#P-AthenaHealth-Sdk-Models-Response-AppointmentType-Patient 'AthenaHealth.Sdk.Models.Response.AppointmentType.Patient')
  - [PatientDisplayName](#P-AthenaHealth-Sdk-Models-Response-AppointmentType-PatientDisplayName 'AthenaHealth.Sdk.Models.Response.AppointmentType.PatientDisplayName')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Response-AppointmentType-ProviderId 'AthenaHealth.Sdk.Models.Response.AppointmentType.ProviderId')
  - [ShortName](#P-AthenaHealth-Sdk-Models-Response-AppointmentType-ShortName 'AthenaHealth.Sdk.Models.Response.AppointmentType.ShortName')
  - [TemplateTypeOnly](#P-AthenaHealth-Sdk-Models-Response-AppointmentType-TemplateTypeOnly 'AthenaHealth.Sdk.Models.Response.AppointmentType.TemplateTypeOnly')
- [AthenaHttpClient](#T-AthenaHealth-Sdk-Http-AthenaHttpClient 'AthenaHealth.Sdk.Http.AthenaHttpClient')
  - [#ctor()](#M-AthenaHealth-Sdk-Http-AthenaHttpClient-#ctor 'AthenaHealth.Sdk.Http.AthenaHttpClient.#ctor')
  - [#ctor(handler)](#M-AthenaHealth-Sdk-Http-AthenaHttpClient-#ctor-System-Net-Http-HttpMessageHandler- 'AthenaHealth.Sdk.Http.AthenaHttpClient.#ctor(System.Net.Http.HttpMessageHandler)')
- [Balance](#T-AthenaHealth-Sdk-Models-Response-Patient-Balance 'AthenaHealth.Sdk.Models.Response.Patient.Balance')
  - [CleanBalance](#P-AthenaHealth-Sdk-Models-Response-Patient-Balance-CleanBalance 'AthenaHealth.Sdk.Models.Response.Patient.Balance.CleanBalance')
  - [CollectionsBalance](#P-AthenaHealth-Sdk-Models-Response-Patient-Balance-CollectionsBalance 'AthenaHealth.Sdk.Models.Response.Patient.Balance.CollectionsBalance')
  - [Contracts](#P-AthenaHealth-Sdk-Models-Response-Patient-Balance-Contracts 'AthenaHealth.Sdk.Models.Response.Patient.Balance.Contracts')
  - [DepartmentList](#P-AthenaHealth-Sdk-Models-Response-Patient-Balance-DepartmentList 'AthenaHealth.Sdk.Models.Response.Patient.Balance.DepartmentList')
  - [PaymentPlanBalance](#P-AthenaHealth-Sdk-Models-Response-Patient-Balance-PaymentPlanBalance 'AthenaHealth.Sdk.Models.Response.Patient.Balance.PaymentPlanBalance')
  - [ProviderGroupId](#P-AthenaHealth-Sdk-Models-Response-Patient-Balance-ProviderGroupId 'AthenaHealth.Sdk.Models.Response.Patient.Balance.ProviderGroupId')
  - [Value](#P-AthenaHealth-Sdk-Models-Response-Patient-Balance-Value 'AthenaHealth.Sdk.Models.Response.Patient.Balance.Value')
- [BaseLimitFilter](#T-AthenaHealth-Sdk-Models-Request-BaseLimitFilter 'AthenaHealth.Sdk.Models.Request.BaseLimitFilter')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-BaseLimitFilter-Limit 'AthenaHealth.Sdk.Models.Request.BaseLimitFilter.Limit')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-BaseLimitFilter-Offset 'AthenaHealth.Sdk.Models.Request.BaseLimitFilter.Offset')
- [BookAppointment](#T-AthenaHealth-Sdk-Models-Request-BookAppointment 'AthenaHealth.Sdk.Models.Request.BookAppointment')
  - [AppointmentId](#P-AthenaHealth-Sdk-Models-Request-BookAppointment-AppointmentId 'AthenaHealth.Sdk.Models.Request.BookAppointment.AppointmentId')
  - [AppointmentTypeId](#P-AthenaHealth-Sdk-Models-Request-BookAppointment-AppointmentTypeId 'AthenaHealth.Sdk.Models.Request.BookAppointment.AppointmentTypeId')
  - [BookingNote](#P-AthenaHealth-Sdk-Models-Request-BookAppointment-BookingNote 'AthenaHealth.Sdk.Models.Request.BookAppointment.BookingNote')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-BookAppointment-DepartmentId 'AthenaHealth.Sdk.Models.Request.BookAppointment.DepartmentId')
  - [DoNotSendConfirmationEmail](#P-AthenaHealth-Sdk-Models-Request-BookAppointment-DoNotSendConfirmationEmail 'AthenaHealth.Sdk.Models.Request.BookAppointment.DoNotSendConfirmationEmail')
  - [IgnoreSchedulablePermission](#P-AthenaHealth-Sdk-Models-Request-BookAppointment-IgnoreSchedulablePermission 'AthenaHealth.Sdk.Models.Request.BookAppointment.IgnoreSchedulablePermission')
  - [InsuranceInfo](#P-AthenaHealth-Sdk-Models-Request-BookAppointment-InsuranceInfo 'AthenaHealth.Sdk.Models.Request.BookAppointment.InsuranceInfo')
  - [NoPatientCase](#P-AthenaHealth-Sdk-Models-Request-BookAppointment-NoPatientCase 'AthenaHealth.Sdk.Models.Request.BookAppointment.NoPatientCase')
  - [PatientId](#P-AthenaHealth-Sdk-Models-Request-BookAppointment-PatientId 'AthenaHealth.Sdk.Models.Request.BookAppointment.PatientId')
  - [ReasonId](#P-AthenaHealth-Sdk-Models-Request-BookAppointment-ReasonId 'AthenaHealth.Sdk.Models.Request.BookAppointment.ReasonId')
  - [Urgent](#P-AthenaHealth-Sdk-Models-Request-BookAppointment-Urgent 'AthenaHealth.Sdk.Models.Request.BookAppointment.Urgent')
- [CancelAppointment](#T-AthenaHealth-Sdk-Models-Request-CancelAppointment 'AthenaHealth.Sdk.Models.Request.CancelAppointment')
  - [AppointmentCancelReasonId](#P-AthenaHealth-Sdk-Models-Request-CancelAppointment-AppointmentCancelReasonId 'AthenaHealth.Sdk.Models.Request.CancelAppointment.AppointmentCancelReasonId')
  - [AppointmentId](#P-AthenaHealth-Sdk-Models-Request-CancelAppointment-AppointmentId 'AthenaHealth.Sdk.Models.Request.CancelAppointment.AppointmentId')
  - [CancellationReason](#P-AthenaHealth-Sdk-Models-Request-CancelAppointment-CancellationReason 'AthenaHealth.Sdk.Models.Request.CancelAppointment.CancellationReason')
  - [IgnoreSchedulablePermission](#P-AthenaHealth-Sdk-Models-Request-CancelAppointment-IgnoreSchedulablePermission 'AthenaHealth.Sdk.Models.Request.CancelAppointment.IgnoreSchedulablePermission')
  - [NoPatientCase](#P-AthenaHealth-Sdk-Models-Request-CancelAppointment-NoPatientCase 'AthenaHealth.Sdk.Models.Request.CancelAppointment.NoPatientCase')
  - [PatientId](#P-AthenaHealth-Sdk-Models-Request-CancelAppointment-PatientId 'AthenaHealth.Sdk.Models.Request.CancelAppointment.PatientId')
- [ChargeLevelDetail](#T-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail')
  - [Amount](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Amount 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.Amount')
  - [Description](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Description 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.Description')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Id 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.Id')
  - [ProcedureCode](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-ProcedureCode 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.ProcedureCode')
  - [ProcedureCodeOtherModifier](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-ProcedureCodeOtherModifier 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.ProcedureCodeOtherModifier')
  - [ProcedureCodeSubmitted](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-ProcedureCodeSubmitted 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.ProcedureCodeSubmitted')
  - [ServiceDate](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-ServiceDate 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.ServiceDate')
  - [Transactions](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transactions 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.Transactions')
- [CheckInField](#T-AthenaHealth-Sdk-Models-Response-CheckInField 'AthenaHealth.Sdk.Models.Response.CheckInField')
  - [Error](#P-AthenaHealth-Sdk-Models-Response-CheckInField-Error 'AthenaHealth.Sdk.Models.Response.CheckInField.Error')
  - [Field](#P-AthenaHealth-Sdk-Models-Response-CheckInField-Field 'AthenaHealth.Sdk.Models.Response.CheckInField.Field')
  - [FormName](#P-AthenaHealth-Sdk-Models-Response-CheckInField-FormName 'AthenaHealth.Sdk.Models.Response.CheckInField.FormName')
  - [IsValid](#P-AthenaHealth-Sdk-Models-Response-CheckInField-IsValid 'AthenaHealth.Sdk.Models.Response.CheckInField.IsValid')
  - [Status](#P-AthenaHealth-Sdk-Models-Response-CheckInField-Status 'AthenaHealth.Sdk.Models.Response.CheckInField.Status')
- [CheckInRequirement](#T-AthenaHealth-Sdk-Models-Response-CheckInRequirement 'AthenaHealth.Sdk.Models.Response.CheckInRequirement')
  - [Fields](#P-AthenaHealth-Sdk-Models-Response-CheckInRequirement-Fields 'AthenaHealth.Sdk.Models.Response.CheckInRequirement.Fields')
  - [IsCompleted](#P-AthenaHealth-Sdk-Models-Response-CheckInRequirement-IsCompleted 'AthenaHealth.Sdk.Models.Response.CheckInRequirement.IsCompleted')
  - [IsRequired](#P-AthenaHealth-Sdk-Models-Response-CheckInRequirement-IsRequired 'AthenaHealth.Sdk.Models.Response.CheckInRequirement.IsRequired')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-CheckInRequirement-Name 'AthenaHealth.Sdk.Models.Response.CheckInRequirement.Name')
- [Claim](#T-AthenaHealth-Sdk-Models-Response-Appointment-Claim 'AthenaHealth.Sdk.Models.Response.Appointment.Claim')
  - [AppointmentId](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-AppointmentId 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.AppointmentId')
  - [BilledProviderId](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-BilledProviderId 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.BilledProviderId')
  - [BilledServiceDate](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-BilledServiceDate 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.BilledServiceDate')
  - [ChargeAmount](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-ChargeAmount 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.ChargeAmount')
  - [ClaimCreatedDate](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-ClaimCreatedDate 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.ClaimCreatedDate')
  - [Diagnoses](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-Diagnoses 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.Diagnoses')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-Id 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.Id')
  - [PatientPayer](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-PatientPayer 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.PatientPayer')
  - [PrimaryInsurancePayer](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-PrimaryInsurancePayer 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.PrimaryInsurancePayer')
  - [Procedures](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-Procedures 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.Procedures')
  - [ReferringProviderId](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-ReferringProviderId 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.ReferringProviderId')
  - [SecondaryInsurancePayer](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-SecondaryInsurancePayer 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.SecondaryInsurancePayer')
  - [TransactionDetails](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-TransactionDetails 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.TransactionDetails')
  - [TransactionId](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-TransactionId 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.TransactionId')
- [ClaimBalanceDetail](#T-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail')
  - [ClaimDetails](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetails 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetails')
  - [DepartmentIds](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-DepartmentIds 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.DepartmentIds')
  - [ProviderGroupId](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ProviderGroupId 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ProviderGroupId')
- [ClaimDetail](#T-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail')
  - [Amount](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-Amount 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.Amount')
  - [ChargeLevelDetails](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetails 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetails')
  - [ClaimId](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ClaimId 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ClaimId')
  - [CleanBalance](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-CleanBalance 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.CleanBalance')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-DepartmentId 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.DepartmentId')
  - [PatientBalance](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-PatientBalance 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.PatientBalance')
  - [ServiceDate](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ServiceDate 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ServiceDate')
  - [SupervisingProviderId](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-SupervisingProviderId 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.SupervisingProviderId')
- [ClinicalProvider](#T-AthenaHealth-Sdk-Models-Response-ClinicalProvider 'AthenaHealth.Sdk.Models.Response.ClinicalProvider')
  - [Address1](#P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-Address1 'AthenaHealth.Sdk.Models.Response.ClinicalProvider.Address1')
  - [Address2](#P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-Address2 'AthenaHealth.Sdk.Models.Response.ClinicalProvider.Address2')
  - [City](#P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-City 'AthenaHealth.Sdk.Models.Response.ClinicalProvider.City')
  - [CliaNumber](#P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-CliaNumber 'AthenaHealth.Sdk.Models.Response.ClinicalProvider.CliaNumber')
  - [FaxNumber](#P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-FaxNumber 'AthenaHealth.Sdk.Models.Response.ClinicalProvider.FaxNumber')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-Id 'AthenaHealth.Sdk.Models.Response.ClinicalProvider.Id')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-Name 'AthenaHealth.Sdk.Models.Response.ClinicalProvider.Name')
  - [PhoneNumber](#P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-PhoneNumber 'AthenaHealth.Sdk.Models.Response.ClinicalProvider.PhoneNumber')
  - [State](#P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-State 'AthenaHealth.Sdk.Models.Response.ClinicalProvider.State')
  - [Zip](#P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-Zip 'AthenaHealth.Sdk.Models.Response.ClinicalProvider.Zip')
- [ClockTime](#T-AthenaHealth-Sdk-Models-ClockTime 'AthenaHealth.Sdk.Models.ClockTime')
- [CommonInsurancePackage](#T-AthenaHealth-Sdk-Models-Response-CommonInsurancePackage 'AthenaHealth.Sdk.Models.Response.CommonInsurancePackage')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-CommonInsurancePackage-Id 'AthenaHealth.Sdk.Models.Response.CommonInsurancePackage.Id')
- [Connection](#T-AthenaHealth-Sdk-Http-Connection 'AthenaHealth.Sdk.Http.Connection')
  - [BaseAddress](#P-AthenaHealth-Sdk-Http-Connection-BaseAddress 'AthenaHealth.Sdk.Http.Connection.BaseAddress')
  - [Credentials](#P-AthenaHealth-Sdk-Http-Connection-Credentials 'AthenaHealth.Sdk.Http.Connection.Credentials')
  - [IsAccessTokenValid](#P-AthenaHealth-Sdk-Http-Connection-IsAccessTokenValid 'AthenaHealth.Sdk.Http.Connection.IsAccessTokenValid')
  - [Version](#P-AthenaHealth-Sdk-Http-Connection-Version 'AthenaHealth.Sdk.Http.Connection.Version')
  - [AddVersion(relativeUrl)](#M-AthenaHealth-Sdk-Http-Connection-AddVersion-System-String- 'AthenaHealth.Sdk.Http.Connection.AddVersion(System.String)')
  - [Delete\`\`1(relativeUrl,queryParameters)](#M-AthenaHealth-Sdk-Http-Connection-Delete``1-System-String,System-Object- 'AthenaHealth.Sdk.Http.Connection.Delete``1(System.String,System.Object)')
  - [Get\`\`1(relativeUrl,queryParameters,shouldThrowErrors)](#M-AthenaHealth-Sdk-Http-Connection-Get``1-System-String,System-Object,System-Boolean- 'AthenaHealth.Sdk.Http.Connection.Get``1(System.String,System.Object,System.Boolean)')
  - [Post\`\`1(relativeUrl,queryParameters,body)](#M-AthenaHealth-Sdk-Http-Connection-Post``1-System-String,System-Object,System-Object,System-Boolean- 'AthenaHealth.Sdk.Http.Connection.Post``1(System.String,System.Object,System.Object,System.Boolean)')
  - [Put\`\`1(relativeUrl,queryParameters,body)](#M-AthenaHealth-Sdk-Http-Connection-Put``1-System-String,System-Object,System-Object- 'AthenaHealth.Sdk.Http.Connection.Put``1(System.String,System.Object,System.Object)')
  - [RefreshAccessToken()](#M-AthenaHealth-Sdk-Http-Connection-RefreshAccessToken 'AthenaHealth.Sdk.Http.Connection.RefreshAccessToken')
- [ContentConverter](#T-AthenaHealth-Sdk-Http-Helpers-ContentConverter 'AthenaHealth.Sdk.Http.Helpers.ContentConverter')
  - [ConvertObjectToDictionary(obj)](#M-AthenaHealth-Sdk-Http-Helpers-ContentConverter-ConvertObjectToDictionary-System-Object- 'AthenaHealth.Sdk.Http.Helpers.ContentConverter.ConvertObjectToDictionary(System.Object)')
  - [GetAttribute\`\`1(property)](#M-AthenaHealth-Sdk-Http-Helpers-ContentConverter-GetAttribute``1-System-Reflection-PropertyInfo- 'AthenaHealth.Sdk.Http.Helpers.ContentConverter.GetAttribute``1(System.Reflection.PropertyInfo)')
  - [GetKey(item)](#M-AthenaHealth-Sdk-Http-Helpers-ContentConverter-GetKey-System-Reflection-PropertyInfo- 'AthenaHealth.Sdk.Http.Helpers.ContentConverter.GetKey(System.Reflection.PropertyInfo)')
  - [GetValue(obj,item)](#M-AthenaHealth-Sdk-Http-Helpers-ContentConverter-GetValue-System-Object,System-Reflection-PropertyInfo- 'AthenaHealth.Sdk.Http.Helpers.ContentConverter.GetValue(System.Object,System.Reflection.PropertyInfo)')
  - [GetValueWithJsonConverter(jsonConverterAttribute,value)](#M-AthenaHealth-Sdk-Http-Helpers-ContentConverter-GetValueWithJsonConverter-Newtonsoft-Json-JsonConverterAttribute,System-Object- 'AthenaHealth.Sdk.Http.Helpers.ContentConverter.GetValueWithJsonConverter(Newtonsoft.Json.JsonConverterAttribute,System.Object)')
- [Contract](#T-AthenaHealth-Sdk-Models-Response-Patient-Balance-Contract 'AthenaHealth.Sdk.Models.Response.Patient.Balance.Contract')
  - [AvailableBalance](#P-AthenaHealth-Sdk-Models-Response-Patient-Balance-Contract-AvailableBalance 'AthenaHealth.Sdk.Models.Response.Patient.Balance.Contract.AvailableBalance')
  - [ContractClass](#P-AthenaHealth-Sdk-Models-Response-Patient-Balance-Contract-ContractClass 'AthenaHealth.Sdk.Models.Response.Patient.Balance.Contract.ContractClass')
  - [MaxAmount](#P-AthenaHealth-Sdk-Models-Response-Patient-Balance-Contract-MaxAmount 'AthenaHealth.Sdk.Models.Response.Patient.Balance.Contract.MaxAmount')
- [Copay](#T-AthenaHealth-Sdk-Models-Response-Insurance-Copay 'AthenaHealth.Sdk.Models.Response.Insurance.Copay')
  - [CopayAmount](#P-AthenaHealth-Sdk-Models-Response-Insurance-Copay-CopayAmount 'AthenaHealth.Sdk.Models.Response.Insurance.Copay.CopayAmount')
  - [CopayType](#P-AthenaHealth-Sdk-Models-Response-Insurance-Copay-CopayType 'AthenaHealth.Sdk.Models.Response.Insurance.Copay.CopayType')
- [CreateAppointmentReminder](#T-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder 'AthenaHealth.Sdk.Models.Request.CreateAppointmentReminder')
  - [AppointmentTypeId](#P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-AppointmentTypeId 'AthenaHealth.Sdk.Models.Request.CreateAppointmentReminder.AppointmentTypeId')
  - [ApproximateDate](#P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-ApproximateDate 'AthenaHealth.Sdk.Models.Request.CreateAppointmentReminder.ApproximateDate')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-DepartmentId 'AthenaHealth.Sdk.Models.Request.CreateAppointmentReminder.DepartmentId')
  - [Note](#P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-Note 'AthenaHealth.Sdk.Models.Request.CreateAppointmentReminder.Note')
  - [PatientId](#P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-PatientId 'AthenaHealth.Sdk.Models.Request.CreateAppointmentReminder.PatientId')
  - [PatientInstructions](#P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-PatientInstructions 'AthenaHealth.Sdk.Models.Request.CreateAppointmentReminder.PatientInstructions')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-ProviderId 'AthenaHealth.Sdk.Models.Request.CreateAppointmentReminder.ProviderId')
  - [Status](#P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-Status 'AthenaHealth.Sdk.Models.Request.CreateAppointmentReminder.Status')
- [CreateAppointmentSlot](#T-AthenaHealth-Sdk-Models-Request-CreateAppointmentSlot 'AthenaHealth.Sdk.Models.Request.CreateAppointmentSlot')
  - [AppointmentDate](#P-AthenaHealth-Sdk-Models-Request-CreateAppointmentSlot-AppointmentDate 'AthenaHealth.Sdk.Models.Request.CreateAppointmentSlot.AppointmentDate')
  - [AppointmentTime](#P-AthenaHealth-Sdk-Models-Request-CreateAppointmentSlot-AppointmentTime 'AthenaHealth.Sdk.Models.Request.CreateAppointmentSlot.AppointmentTime')
  - [AppointmentTypeId](#P-AthenaHealth-Sdk-Models-Request-CreateAppointmentSlot-AppointmentTypeId 'AthenaHealth.Sdk.Models.Request.CreateAppointmentSlot.AppointmentTypeId')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-CreateAppointmentSlot-DepartmentId 'AthenaHealth.Sdk.Models.Request.CreateAppointmentSlot.DepartmentId')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Request-CreateAppointmentSlot-ProviderId 'AthenaHealth.Sdk.Models.Request.CreateAppointmentSlot.ProviderId')
  - [ReasonId](#P-AthenaHealth-Sdk-Models-Request-CreateAppointmentSlot-ReasonId 'AthenaHealth.Sdk.Models.Request.CreateAppointmentSlot.ReasonId')
- [CreateDiagnoses](#T-AthenaHealth-Sdk-Models-Request-CreateDiagnoses 'AthenaHealth.Sdk.Models.Request.CreateDiagnoses')
  - [Icd10Codes](#P-AthenaHealth-Sdk-Models-Request-CreateDiagnoses-Icd10Codes 'AthenaHealth.Sdk.Models.Request.CreateDiagnoses.Icd10Codes')
  - [Icd9Codes](#P-AthenaHealth-Sdk-Models-Request-CreateDiagnoses-Icd9Codes 'AthenaHealth.Sdk.Models.Request.CreateDiagnoses.Icd9Codes')
  - [Laterality](#P-AthenaHealth-Sdk-Models-Request-CreateDiagnoses-Laterality 'AthenaHealth.Sdk.Models.Request.CreateDiagnoses.Laterality')
  - [Note](#P-AthenaHealth-Sdk-Models-Request-CreateDiagnoses-Note 'AthenaHealth.Sdk.Models.Request.CreateDiagnoses.Note')
  - [SnomedCode](#P-AthenaHealth-Sdk-Models-Request-CreateDiagnoses-SnomedCode 'AthenaHealth.Sdk.Models.Request.CreateDiagnoses.SnomedCode')
- [CreateInsurance](#T-AthenaHealth-Sdk-Models-Request-CreateInsurance 'AthenaHealth.Sdk.Models.Request.CreateInsurance')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-DepartmentId 'AthenaHealth.Sdk.Models.Request.CreateInsurance.DepartmentId')
  - [ExpirationDate](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-ExpirationDate 'AthenaHealth.Sdk.Models.Request.CreateInsurance.ExpirationDate')
  - [InsuranceIdNumber](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsuranceIdNumber 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsuranceIdNumber')
  - [InsurancePackageId](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePackageId 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePackageId')
  - [InsurancePhone](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePhone 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePhone')
  - [InsurancePolicyHolder](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolder 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePolicyHolder')
  - [InsurancePolicyHolderAddress1](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderAddress1 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePolicyHolderAddress1')
  - [InsurancePolicyHolderAddress2](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderAddress2 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePolicyHolderAddress2')
  - [InsurancePolicyHolderCity](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderCity 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePolicyHolderCity')
  - [InsurancePolicyHolderCountryCode](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderCountryCode 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePolicyHolderCountryCode')
  - [InsurancePolicyHolderCountryIso3166](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderCountryIso3166 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePolicyHolderCountryIso3166')
  - [InsurancePolicyHolderDob](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderDob 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePolicyHolderDob')
  - [InsurancePolicyHolderFirstName](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderFirstName 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePolicyHolderFirstName')
  - [InsurancePolicyHolderLastName](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderLastName 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePolicyHolderLastName')
  - [InsurancePolicyHolderMiddleName](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderMiddleName 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePolicyHolderMiddleName')
  - [InsurancePolicyHolderSex](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderSex 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePolicyHolderSex')
  - [InsurancePolicyHolderSsn](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderSsn 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePolicyHolderSsn')
  - [InsurancePolicyHolderState](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderState 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePolicyHolderState')
  - [InsurancePolicyHolderSuffix](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderSuffix 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePolicyHolderSuffix')
  - [InsurancePolicyHolderZip](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderZip 'AthenaHealth.Sdk.Models.Request.CreateInsurance.InsurancePolicyHolderZip')
  - [IssueDate](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-IssueDate 'AthenaHealth.Sdk.Models.Request.CreateInsurance.IssueDate')
  - [PolicyNumber](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-PolicyNumber 'AthenaHealth.Sdk.Models.Request.CreateInsurance.PolicyNumber')
  - [RelationshipToInsuredId](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-RelationshipToInsuredId 'AthenaHealth.Sdk.Models.Request.CreateInsurance.RelationshipToInsuredId')
  - [SequenceNumber](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-SequenceNumber 'AthenaHealth.Sdk.Models.Request.CreateInsurance.SequenceNumber')
  - [UpdateAppointments](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-UpdateAppointments 'AthenaHealth.Sdk.Models.Request.CreateInsurance.UpdateAppointments')
  - [ValidateInsuranceIdNumber](#P-AthenaHealth-Sdk-Models-Request-CreateInsurance-ValidateInsuranceIdNumber 'AthenaHealth.Sdk.Models.Request.CreateInsurance.ValidateInsuranceIdNumber')
- [CreateOrUpdatePatient](#T-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient')
  - [Address1](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Address1 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.Address1')
  - [Address2](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Address2 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.Address2')
  - [AgriculturalWorker](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-AgriculturalWorker 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.AgriculturalWorker')
  - [AgriculturalWorkerType](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-AgriculturalWorkerType 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.AgriculturalWorkerType')
  - [AltFirstName](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-AltFirstName 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.AltFirstName')
  - [AssignedSexAtBirth](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-AssignedSexAtBirth 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.AssignedSexAtBirth')
  - [CareSummaryDeliveryPreference](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-CareSummaryDeliveryPreference 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.CareSummaryDeliveryPreference')
  - [City](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-City 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.City')
  - [ClinicalOrderTypeGroupId](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ClinicalOrderTypeGroupId 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ClinicalOrderTypeGroupId')
  - [ConsentToCall](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ConsentToCall 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ConsentToCall')
  - [ConsentToText](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ConsentToText 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ConsentToText')
  - [ContactHomePhone](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactHomePhone 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactHomePhone')
  - [ContactMobilePhone](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactMobilePhone 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactMobilePhone')
  - [ContactName](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactName 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactName')
  - [ContactPreference](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreference 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactPreference')
  - [ContactPreferenceAnnouncementEmail](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceAnnouncementEmail 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactPreferenceAnnouncementEmail')
  - [ContactPreferenceAnnouncementPhone](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceAnnouncementPhone 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactPreferenceAnnouncementPhone')
  - [ContactPreferenceAnnouncementSms](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceAnnouncementSms 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactPreferenceAnnouncementSms')
  - [ContactPreferenceAppointmentEemail](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceAppointmentEemail 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactPreferenceAppointmentEemail')
  - [ContactPreferenceAppointmentPhone](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceAppointmentPhone 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactPreferenceAppointmentPhone')
  - [ContactPreferenceAppointmentSms](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceAppointmentSms 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactPreferenceAppointmentSms')
  - [ContactPreferenceBillingEmail](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceBillingEmail 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactPreferenceBillingEmail')
  - [ContactPreferenceBillingPhone](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceBillingPhone 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactPreferenceBillingPhone')
  - [ContactPreferenceBillingSms](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceBillingSms 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactPreferenceBillingSms')
  - [ContactPreferenceLabEmail](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceLabEmail 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactPreferenceLabEmail')
  - [ContactPreferenceLabPhone](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceLabPhone 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactPreferenceLabPhone')
  - [ContactPreferenceLabSms](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceLabSms 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactPreferenceLabSms')
  - [ContactRelationship](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactRelationship 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ContactRelationship')
  - [CountryCode3166](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-CountryCode3166 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.CountryCode3166')
  - [DateOfBirth](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DateOfBirth 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.DateOfBirth')
  - [DeceasedDate](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DeceasedDate 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.DeceasedDate')
  - [DefaultPharmacyNcpdpId](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DefaultPharmacyNcpdpId 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.DefaultPharmacyNcpdpId')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DepartmentId 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.DepartmentId')
  - [DoNotCall](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DoNotCall 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.DoNotCall')
  - [DriversLicenseExpirationDate](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DriversLicenseExpirationDate 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.DriversLicenseExpirationDate')
  - [DriversLicenseNumber](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DriversLicenseNumber 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.DriversLicenseNumber')
  - [DriversLicenseStateId](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DriversLicenseStateId 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.DriversLicenseStateId')
  - [Email](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Email 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.Email')
  - [EmployerId](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-EmployerId 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.EmployerId')
  - [EmployerPhone](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-EmployerPhone 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.EmployerPhone')
  - [EthnicityCode](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-EthnicityCode 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.EthnicityCode')
  - [FirstName](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-FirstName 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.FirstName')
  - [GenderIdentity](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GenderIdentity 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GenderIdentity')
  - [GenderIdentityOther](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GenderIdentityOther 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GenderIdentityOther')
  - [GuarantorAddress1](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorAddress1 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorAddress1')
  - [GuarantorAddress2](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorAddress2 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorAddress2')
  - [GuarantorAddressSameAsPatient](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorAddressSameAsPatient 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorAddressSameAsPatient')
  - [GuarantorCity](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorCity 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorCity')
  - [GuarantorCountryCode3166](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorCountryCode3166 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorCountryCode3166')
  - [GuarantorDateOfBirth](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorDateOfBirth 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorDateOfBirth')
  - [GuarantorEmail](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorEmail 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorEmail')
  - [GuarantorEmployerId](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorEmployerId 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorEmployerId')
  - [GuarantorFirstName](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorFirstName 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorFirstName')
  - [GuarantorLastName](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorLastName 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorLastName')
  - [GuarantorMiddleName](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorMiddleName 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorMiddleName')
  - [GuarantorPhone](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorPhone 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorPhone')
  - [GuarantorRelationshipToPatient](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorRelationshipToPatient 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorRelationshipToPatient')
  - [GuarantorSsn](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorSsn 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorSsn')
  - [GuarantorState](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorState 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorState')
  - [GuarantorSuffix](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorSuffix 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorSuffix')
  - [GuarantorZip](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorZip 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuarantorZip')
  - [GuardianFirstName](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuardianFirstName 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuardianFirstName')
  - [GuardianLastName](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuardianLastName 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuardianLastName')
  - [GuardianMiddleName](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuardianMiddleName 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuardianMiddleName')
  - [GuardianSuffix](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuardianSuffix 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.GuardianSuffix')
  - [HasMobile](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-HasMobile 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.HasMobile')
  - [HomePhone](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-HomePhone 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.HomePhone')
  - [Homebound](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Homebound 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.Homebound')
  - [Homeless](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Homeless 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.Homeless')
  - [HomelessType](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-HomelessType 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.HomelessType')
  - [IgnoreRestrictions](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-IgnoreRestrictions 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.IgnoreRestrictions')
  - [IndustryCode](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-IndustryCode 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.IndustryCode')
  - [Language6392Code](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Language6392Code 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.Language6392Code')
  - [LastName](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-LastName 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.LastName')
  - [MaritalStatus](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-MaritalStatus 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.MaritalStatus')
  - [MiddleName](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-MiddleName 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.MiddleName')
  - [MobileCarrierId](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-MobileCarrierId 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.MobileCarrierId')
  - [MobilePhone](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-MobilePhone 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.MobilePhone')
  - [NextKinName](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-NextKinName 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.NextKinName')
  - [NextKinPhone](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-NextKinPhone 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.NextKinPhone')
  - [NextKinRelationship](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-NextKinRelationship 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.NextKinRelationship')
  - [Notes](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Notes 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.Notes')
  - [OccupationCode](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-OccupationCode 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.OccupationCode')
  - [OnlineStatementOnly](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-OnlineStatementOnly 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.OnlineStatementOnly')
  - [PortalAccessGiven](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PortalAccessGiven 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.PortalAccessGiven')
  - [PovertyLevelCalculated](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PovertyLevelCalculated 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.PovertyLevelCalculated')
  - [PovertyLevelFamilySizeDeclined](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PovertyLevelFamilySizeDeclined 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.PovertyLevelFamilySizeDeclined')
  - [PovertyLevelFamilysize](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PovertyLevelFamilysize 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.PovertyLevelFamilysize')
  - [PovertyLevelIncomeDeclined](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PovertyLevelIncomeDeclined 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.PovertyLevelIncomeDeclined')
  - [PovertyLevelIncomePayPeriod](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PovertyLevelIncomePayPeriod 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.PovertyLevelIncomePayPeriod')
  - [PovertyLevelIncomePerPayPeriod](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PovertyLevelIncomePerPayPeriod 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.PovertyLevelIncomePerPayPeriod')
  - [PovertyLevelIncomeRangeDeclined](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PovertyLevelIncomeRangeDeclined 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.PovertyLevelIncomeRangeDeclined')
  - [PreferredName](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PreferredName 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.PreferredName')
  - [PreferredPronouns](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PreferredPronouns 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.PreferredPronouns')
  - [PrimaryDepartmentId](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PrimaryDepartmentId 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.PrimaryDepartmentId')
  - [PrimaryProviderId](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PrimaryProviderId 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.PrimaryProviderId')
  - [PublicHousing](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PublicHousing 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.PublicHousing')
  - [Race](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Race 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.Race')
  - [ReferralSourceId](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ReferralSourceId 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ReferralSourceId')
  - [ReferralSourceOther](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ReferralSourceOther 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.ReferralSourceOther')
  - [SchoolBasedHealthCenter](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-SchoolBasedHealthCenter 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.SchoolBasedHealthCenter')
  - [Sex](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Sex 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.Sex')
  - [SexualOrientation](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-SexualOrientation 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.SexualOrientation')
  - [SexualOrientationOther](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-SexualOrientationOther 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.SexualOrientationOther')
  - [Ssn](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Ssn 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.Ssn')
  - [State](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-State 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.State')
  - [Status](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Status 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.Status')
  - [Suffix](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Suffix 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.Suffix')
  - [Veteran](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Veteran 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.Veteran')
  - [WorkPhone](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-WorkPhone 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.WorkPhone')
  - [Zip](#P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Zip 'AthenaHealth.Sdk.Models.Request.CreateOrUpdatePatient.Zip')
- [CreateOrderLab](#T-AthenaHealth-Sdk-Models-Request-CreateOrderLab 'AthenaHealth.Sdk.Models.Request.CreateOrderLab')
  - [DiagnosisSnomedCode](#P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-DiagnosisSnomedCode 'AthenaHealth.Sdk.Models.Request.CreateOrderLab.DiagnosisSnomedCode')
  - [FacilityId](#P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-FacilityId 'AthenaHealth.Sdk.Models.Request.CreateOrderLab.FacilityId')
  - [FacilityNote](#P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-FacilityNote 'AthenaHealth.Sdk.Models.Request.CreateOrderLab.FacilityNote')
  - [FutureSubmitDate](#P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-FutureSubmitDate 'AthenaHealth.Sdk.Models.Request.CreateOrderLab.FutureSubmitDate')
  - [HighPriority](#P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-HighPriority 'AthenaHealth.Sdk.Models.Request.CreateOrderLab.HighPriority')
  - [Loinc](#P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-Loinc 'AthenaHealth.Sdk.Models.Request.CreateOrderLab.Loinc')
  - [OrderTypeId](#P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-OrderTypeId 'AthenaHealth.Sdk.Models.Request.CreateOrderLab.OrderTypeId')
  - [ProviderNote](#P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-ProviderNote 'AthenaHealth.Sdk.Models.Request.CreateOrderLab.ProviderNote')
- [CreatePatient](#T-AthenaHealth-Sdk-Models-Request-CreatePatient 'AthenaHealth.Sdk.Models.Request.CreatePatient')
  - [ShowErrorMessage](#P-AthenaHealth-Sdk-Models-Request-CreatePatient-ShowErrorMessage 'AthenaHealth.Sdk.Models.Request.CreatePatient.ShowErrorMessage')
- [CreatePatientResponse](#T-AthenaHealth-Sdk-Models-Response-CreatePatientResponse 'AthenaHealth.Sdk.Models.Response.CreatePatientResponse')
  - [ErrorMessage](#P-AthenaHealth-Sdk-Models-Response-CreatePatientResponse-ErrorMessage 'AthenaHealth.Sdk.Models.Response.CreatePatientResponse.ErrorMessage')
  - [PatientId](#P-AthenaHealth-Sdk-Models-Response-CreatePatientResponse-PatientId 'AthenaHealth.Sdk.Models.Response.CreatePatientResponse.PatientId')
- [CreatedAppointmentReminder](#T-AthenaHealth-Sdk-Models-Response-CreatedAppointmentReminder 'AthenaHealth.Sdk.Models.Response.CreatedAppointmentReminder')
  - [ErrorMessage](#P-AthenaHealth-Sdk-Models-Response-CreatedAppointmentReminder-ErrorMessage 'AthenaHealth.Sdk.Models.Response.CreatedAppointmentReminder.ErrorMessage')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-CreatedAppointmentReminder-Id 'AthenaHealth.Sdk.Models.Response.CreatedAppointmentReminder.Id')
- [CustomArrayToStringConverter](#T-AthenaHealth-Sdk-Models-Converters-CustomArrayToStringConverter 'AthenaHealth.Sdk.Models.Converters.CustomArrayToStringConverter')
- [CustomField](#T-AthenaHealth-Sdk-Models-Response-Patient-CustomField 'AthenaHealth.Sdk.Models.Response.Patient.CustomField')
  - [CustomFieldValue](#P-AthenaHealth-Sdk-Models-Response-Patient-CustomField-CustomFieldValue 'AthenaHealth.Sdk.Models.Response.Patient.CustomField.CustomFieldValue')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-Patient-CustomField-Id 'AthenaHealth.Sdk.Models.Response.Patient.CustomField.Id')
  - [OptionId](#P-AthenaHealth-Sdk-Models-Response-Patient-CustomField-OptionId 'AthenaHealth.Sdk.Models.Response.Patient.CustomField.OptionId')
- [DeclinedReason](#T-AthenaHealth-Sdk-Models-Response-Document-DeclinedReason 'AthenaHealth.Sdk.Models.Response.Document.DeclinedReason')
  - [Code](#P-AthenaHealth-Sdk-Models-Response-Document-DeclinedReason-Code 'AthenaHealth.Sdk.Models.Response.Document.DeclinedReason.Code')
  - [Codeset](#P-AthenaHealth-Sdk-Models-Response-Document-DeclinedReason-Codeset 'AthenaHealth.Sdk.Models.Response.Document.DeclinedReason.Codeset')
  - [Description](#P-AthenaHealth-Sdk-Models-Response-Document-DeclinedReason-Description 'AthenaHealth.Sdk.Models.Response.Document.DeclinedReason.Description')
- [Department](#T-AthenaHealth-Sdk-Models-Response-Department 'AthenaHealth.Sdk.Models.Response.Department')
  - [ProviderList](#P-AthenaHealth-Sdk-Models-Response-Department-ProviderList 'AthenaHealth.Sdk.Models.Response.Department.ProviderList')
- [Diagnose](#T-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Diagnose 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.Diagnose')
  - [Code](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Diagnose-Code 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.Diagnose.Code')
  - [Codeset](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Diagnose-Codeset 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.Diagnose.Codeset')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Diagnose-Name 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.Diagnose.Name')
- [DiagnoseForEncounter](#T-AthenaHealth-Sdk-Models-Response-DiagnoseForEncounter 'AthenaHealth.Sdk.Models.Response.DiagnoseForEncounter')
  - [Description](#P-AthenaHealth-Sdk-Models-Response-DiagnoseForEncounter-Description 'AthenaHealth.Sdk.Models.Response.DiagnoseForEncounter.Description')
  - [IcdCodes](#P-AthenaHealth-Sdk-Models-Response-DiagnoseForEncounter-IcdCodes 'AthenaHealth.Sdk.Models.Response.DiagnoseForEncounter.IcdCodes')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-DiagnoseForEncounter-Id 'AthenaHealth.Sdk.Models.Response.DiagnoseForEncounter.Id')
  - [Note](#P-AthenaHealth-Sdk-Models-Response-DiagnoseForEncounter-Note 'AthenaHealth.Sdk.Models.Response.DiagnoseForEncounter.Note')
  - [SnomedCode](#P-AthenaHealth-Sdk-Models-Response-DiagnoseForEncounter-SnomedCode 'AthenaHealth.Sdk.Models.Response.DiagnoseForEncounter.SnomedCode')
- [Diagnosis](#T-AthenaHealth-Sdk-Models-Response-Appointment-Diagnosis 'AthenaHealth.Sdk.Models.Response.Appointment.Diagnosis')
  - [DeletedDiagnosis](#P-AthenaHealth-Sdk-Models-Response-Appointment-Diagnosis-DeletedDiagnosis 'AthenaHealth.Sdk.Models.Response.Appointment.Diagnosis.DeletedDiagnosis')
  - [DiagnosisCategory](#P-AthenaHealth-Sdk-Models-Response-Appointment-Diagnosis-DiagnosisCategory 'AthenaHealth.Sdk.Models.Response.Appointment.Diagnosis.DiagnosisCategory')
  - [DiagnosisCodeSet](#P-AthenaHealth-Sdk-Models-Response-Appointment-Diagnosis-DiagnosisCodeSet 'AthenaHealth.Sdk.Models.Response.Appointment.Diagnosis.DiagnosisCodeSet')
  - [DiagnosisDescription](#P-AthenaHealth-Sdk-Models-Response-Appointment-Diagnosis-DiagnosisDescription 'AthenaHealth.Sdk.Models.Response.Appointment.Diagnosis.DiagnosisDescription')
  - [DiagnosisRawCode](#P-AthenaHealth-Sdk-Models-Response-Appointment-Diagnosis-DiagnosisRawCode 'AthenaHealth.Sdk.Models.Response.Appointment.Diagnosis.DiagnosisRawCode')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-Appointment-Diagnosis-Id 'AthenaHealth.Sdk.Models.Response.Appointment.Diagnosis.Id')
- [Document](#T-AthenaHealth-Sdk-Models-Response-Document 'AthenaHealth.Sdk.Models.Response.Document')
  - [AcogId](#P-AthenaHealth-Sdk-Models-Response-Document-AcogId 'AthenaHealth.Sdk.Models.Response.Document.AcogId')
  - [AdminId](#P-AthenaHealth-Sdk-Models-Response-Document-AdminId 'AthenaHealth.Sdk.Models.Response.Document.AdminId')
  - [AdvertisementId](#P-AthenaHealth-Sdk-Models-Response-Document-AdvertisementId 'AthenaHealth.Sdk.Models.Response.Document.AdvertisementId')
  - [AppointmentId](#P-AthenaHealth-Sdk-Models-Response-Document-AppointmentId 'AthenaHealth.Sdk.Models.Response.Document.AppointmentId')
  - [AppointmentRequestId](#P-AthenaHealth-Sdk-Models-Response-Document-AppointmentRequestId 'AthenaHealth.Sdk.Models.Response.Document.AppointmentRequestId')
  - [AssignedTo](#P-AthenaHealth-Sdk-Models-Response-Document-AssignedTo 'AthenaHealth.Sdk.Models.Response.Document.AssignedTo')
  - [ChartAbstractionId](#P-AthenaHealth-Sdk-Models-Response-Document-ChartAbstractionId 'AthenaHealth.Sdk.Models.Response.Document.ChartAbstractionId')
  - [ClinicalDocumentId](#P-AthenaHealth-Sdk-Models-Response-Document-ClinicalDocumentId 'AthenaHealth.Sdk.Models.Response.Document.ClinicalDocumentId')
  - [ClinicalProviderId](#P-AthenaHealth-Sdk-Models-Response-Document-ClinicalProviderId 'AthenaHealth.Sdk.Models.Response.Document.ClinicalProviderId')
  - [CoordinatorTaskId](#P-AthenaHealth-Sdk-Models-Response-Document-CoordinatorTaskId 'AthenaHealth.Sdk.Models.Response.Document.CoordinatorTaskId')
  - [CorrectiveLensId](#P-AthenaHealth-Sdk-Models-Response-Document-CorrectiveLensId 'AthenaHealth.Sdk.Models.Response.Document.CorrectiveLensId')
  - [CoverSheetId](#P-AthenaHealth-Sdk-Models-Response-Document-CoverSheetId 'AthenaHealth.Sdk.Models.Response.Document.CoverSheetId')
  - [CreatedDate](#P-AthenaHealth-Sdk-Models-Response-Document-CreatedDate 'AthenaHealth.Sdk.Models.Response.Document.CreatedDate')
  - [CreatedDateTime](#P-AthenaHealth-Sdk-Models-Response-Document-CreatedDateTime 'AthenaHealth.Sdk.Models.Response.Document.CreatedDateTime')
  - [DeclinedReasonText](#P-AthenaHealth-Sdk-Models-Response-Document-DeclinedReasonText 'AthenaHealth.Sdk.Models.Response.Document.DeclinedReasonText')
  - [DeclinedReasons](#P-AthenaHealth-Sdk-Models-Response-Document-DeclinedReasons 'AthenaHealth.Sdk.Models.Response.Document.DeclinedReasons')
  - [DeletedDateTime](#P-AthenaHealth-Sdk-Models-Response-Document-DeletedDateTime 'AthenaHealth.Sdk.Models.Response.Document.DeletedDateTime')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Response-Document-DepartmentId 'AthenaHealth.Sdk.Models.Response.Document.DepartmentId')
  - [DmeId](#P-AthenaHealth-Sdk-Models-Response-Document-DmeId 'AthenaHealth.Sdk.Models.Response.Document.DmeId')
  - [DocumentClass](#P-AthenaHealth-Sdk-Models-Response-Document-DocumentClass 'AthenaHealth.Sdk.Models.Response.Document.DocumentClass')
  - [DocumentDescription](#P-AthenaHealth-Sdk-Models-Response-Document-DocumentDescription 'AthenaHealth.Sdk.Models.Response.Document.DocumentDescription')
  - [DocumentId](#P-AthenaHealth-Sdk-Models-Response-Document-DocumentId 'AthenaHealth.Sdk.Models.Response.Document.DocumentId')
  - [DocumentRoute](#P-AthenaHealth-Sdk-Models-Response-Document-DocumentRoute 'AthenaHealth.Sdk.Models.Response.Document.DocumentRoute')
  - [DocumentSource](#P-AthenaHealth-Sdk-Models-Response-Document-DocumentSource 'AthenaHealth.Sdk.Models.Response.Document.DocumentSource')
  - [DocumentSubclass](#P-AthenaHealth-Sdk-Models-Response-Document-DocumentSubclass 'AthenaHealth.Sdk.Models.Response.Document.DocumentSubclass')
  - [DocumentType](#P-AthenaHealth-Sdk-Models-Response-Document-DocumentType 'AthenaHealth.Sdk.Models.Response.Document.DocumentType')
  - [DocumentTypeId](#P-AthenaHealth-Sdk-Models-Response-Document-DocumentTypeId 'AthenaHealth.Sdk.Models.Response.Document.DocumentTypeId')
  - [ElectronicReferralId](#P-AthenaHealth-Sdk-Models-Response-Document-ElectronicReferralId 'AthenaHealth.Sdk.Models.Response.Document.ElectronicReferralId')
  - [EncounterDocumentId](#P-AthenaHealth-Sdk-Models-Response-Document-EncounterDocumentId 'AthenaHealth.Sdk.Models.Response.Document.EncounterDocumentId')
  - [EncounterId](#P-AthenaHealth-Sdk-Models-Response-Document-EncounterId 'AthenaHealth.Sdk.Models.Response.Document.EncounterId')
  - [ExternalAccessionId](#P-AthenaHealth-Sdk-Models-Response-Document-ExternalAccessionId 'AthenaHealth.Sdk.Models.Response.Document.ExternalAccessionId')
  - [ExternalNote](#P-AthenaHealth-Sdk-Models-Response-Document-ExternalNote 'AthenaHealth.Sdk.Models.Response.Document.ExternalNote')
  - [HospitalId](#P-AthenaHealth-Sdk-Models-Response-Document-HospitalId 'AthenaHealth.Sdk.Models.Response.Document.HospitalId')
  - [HtmlId](#P-AthenaHealth-Sdk-Models-Response-Document-HtmlId 'AthenaHealth.Sdk.Models.Response.Document.HtmlId')
  - [ImagingResultId](#P-AthenaHealth-Sdk-Models-Response-Document-ImagingResultId 'AthenaHealth.Sdk.Models.Response.Document.ImagingResultId')
  - [InternalAccessionId](#P-AthenaHealth-Sdk-Models-Response-Document-InternalAccessionId 'AthenaHealth.Sdk.Models.Response.Document.InternalAccessionId')
  - [InternalNote](#P-AthenaHealth-Sdk-Models-Response-Document-InternalNote 'AthenaHealth.Sdk.Models.Response.Document.InternalNote')
  - [InterpretationId](#P-AthenaHealth-Sdk-Models-Response-Document-InterpretationId 'AthenaHealth.Sdk.Models.Response.Document.InterpretationId')
  - [LabResultId](#P-AthenaHealth-Sdk-Models-Response-Document-LabResultId 'AthenaHealth.Sdk.Models.Response.Document.LabResultId')
  - [LastModifiedDateTime](#P-AthenaHealth-Sdk-Models-Response-Document-LastModifiedDateTime 'AthenaHealth.Sdk.Models.Response.Document.LastModifiedDateTime')
  - [LetterId](#P-AthenaHealth-Sdk-Models-Response-Document-LetterId 'AthenaHealth.Sdk.Models.Response.Document.LetterId')
  - [MedNotificationId](#P-AthenaHealth-Sdk-Models-Response-Document-MedNotificationId 'AthenaHealth.Sdk.Models.Response.Document.MedNotificationId')
  - [MedicalRecordId](#P-AthenaHealth-Sdk-Models-Response-Document-MedicalRecordId 'AthenaHealth.Sdk.Models.Response.Document.MedicalRecordId')
  - [ObservationDateTime](#P-AthenaHealth-Sdk-Models-Response-Document-ObservationDateTime 'AthenaHealth.Sdk.Models.Response.Document.ObservationDateTime')
  - [OfficeNoteId](#P-AthenaHealth-Sdk-Models-Response-Document-OfficeNoteId 'AthenaHealth.Sdk.Models.Response.Document.OfficeNoteId')
  - [OrderId](#P-AthenaHealth-Sdk-Models-Response-Document-OrderId 'AthenaHealth.Sdk.Models.Response.Document.OrderId')
  - [PatientCaseId](#P-AthenaHealth-Sdk-Models-Response-Document-PatientCaseId 'AthenaHealth.Sdk.Models.Response.Document.PatientCaseId')
  - [PatientInfoId](#P-AthenaHealth-Sdk-Models-Response-Document-PatientInfoId 'AthenaHealth.Sdk.Models.Response.Document.PatientInfoId')
  - [PatientRecordId](#P-AthenaHealth-Sdk-Models-Response-Document-PatientRecordId 'AthenaHealth.Sdk.Models.Response.Document.PatientRecordId')
  - [PhoneMessageId](#P-AthenaHealth-Sdk-Models-Response-Document-PhoneMessageId 'AthenaHealth.Sdk.Models.Response.Document.PhoneMessageId')
  - [PhysicianAuthId](#P-AthenaHealth-Sdk-Models-Response-Document-PhysicianAuthId 'AthenaHealth.Sdk.Models.Response.Document.PhysicianAuthId')
  - [PrescriptionId](#P-AthenaHealth-Sdk-Models-Response-Document-PrescriptionId 'AthenaHealth.Sdk.Models.Response.Document.PrescriptionId')
  - [Priority](#P-AthenaHealth-Sdk-Models-Response-Document-Priority 'AthenaHealth.Sdk.Models.Response.Document.Priority')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Response-Document-ProviderId 'AthenaHealth.Sdk.Models.Response.Document.ProviderId')
  - [ReceiverNote](#P-AthenaHealth-Sdk-Models-Response-Document-ReceiverNote 'AthenaHealth.Sdk.Models.Response.Document.ReceiverNote')
  - [RequisitionId](#P-AthenaHealth-Sdk-Models-Response-Document-RequisitionId 'AthenaHealth.Sdk.Models.Response.Document.RequisitionId')
  - [RtoId](#P-AthenaHealth-Sdk-Models-Response-Document-RtoId 'AthenaHealth.Sdk.Models.Response.Document.RtoId')
  - [ShareableId](#P-AthenaHealth-Sdk-Models-Response-Document-ShareableId 'AthenaHealth.Sdk.Models.Response.Document.ShareableId')
  - [Status](#P-AthenaHealth-Sdk-Models-Response-Document-Status 'AthenaHealth.Sdk.Models.Response.Document.Status')
  - [Subject](#P-AthenaHealth-Sdk-Models-Response-Document-Subject 'AthenaHealth.Sdk.Models.Response.Document.Subject')
  - [SurgeryId](#P-AthenaHealth-Sdk-Models-Response-Document-SurgeryId 'AthenaHealth.Sdk.Models.Response.Document.SurgeryId')
  - [SurgicalResultId](#P-AthenaHealth-Sdk-Models-Response-Document-SurgicalResultId 'AthenaHealth.Sdk.Models.Response.Document.SurgicalResultId')
  - [TieToOrderId](#P-AthenaHealth-Sdk-Models-Response-Document-TieToOrderId 'AthenaHealth.Sdk.Models.Response.Document.TieToOrderId')
  - [UnknownId](#P-AthenaHealth-Sdk-Models-Response-Document-UnknownId 'AthenaHealth.Sdk.Models.Response.Document.UnknownId')
  - [VaccineId](#P-AthenaHealth-Sdk-Models-Response-Document-VaccineId 'AthenaHealth.Sdk.Models.Response.Document.VaccineId')
- [Encounter](#T-AthenaHealth-Sdk-Models-Response-Encounter 'AthenaHealth.Sdk.Models.Response.Encounter')
  - [AppointmentId](#P-AthenaHealth-Sdk-Models-Response-Encounter-AppointmentId 'AthenaHealth.Sdk.Models.Response.Encounter.AppointmentId')
  - [ClosedDate](#P-AthenaHealth-Sdk-Models-Response-Encounter-ClosedDate 'AthenaHealth.Sdk.Models.Response.Encounter.ClosedDate')
  - [ClosedUser](#P-AthenaHealth-Sdk-Models-Response-Encounter-ClosedUser 'AthenaHealth.Sdk.Models.Response.Encounter.ClosedUser')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Response-Encounter-DepartmentId 'AthenaHealth.Sdk.Models.Response.Encounter.DepartmentId')
  - [Diagnoses](#P-AthenaHealth-Sdk-Models-Response-Encounter-Diagnoses 'AthenaHealth.Sdk.Models.Response.Encounter.Diagnoses')
  - [EncounterDate](#P-AthenaHealth-Sdk-Models-Response-Encounter-EncounterDate 'AthenaHealth.Sdk.Models.Response.Encounter.EncounterDate')
  - [EncounterType](#P-AthenaHealth-Sdk-Models-Response-Encounter-EncounterType 'AthenaHealth.Sdk.Models.Response.Encounter.EncounterType')
  - [EncounterVisitName](#P-AthenaHealth-Sdk-Models-Response-Encounter-EncounterVisitName 'AthenaHealth.Sdk.Models.Response.Encounter.EncounterVisitName')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-Encounter-Id 'AthenaHealth.Sdk.Models.Response.Encounter.Id')
  - [LastReopened](#P-AthenaHealth-Sdk-Models-Response-Encounter-LastReopened 'AthenaHealth.Sdk.Models.Response.Encounter.LastReopened')
  - [LastUpdated](#P-AthenaHealth-Sdk-Models-Response-Encounter-LastUpdated 'AthenaHealth.Sdk.Models.Response.Encounter.LastUpdated')
  - [PatientLocation](#P-AthenaHealth-Sdk-Models-Response-Encounter-PatientLocation 'AthenaHealth.Sdk.Models.Response.Encounter.PatientLocation')
  - [PatientStatus](#P-AthenaHealth-Sdk-Models-Response-Encounter-PatientStatus 'AthenaHealth.Sdk.Models.Response.Encounter.PatientStatus')
  - [PatientStatusId](#P-AthenaHealth-Sdk-Models-Response-Encounter-PatientStatusId 'AthenaHealth.Sdk.Models.Response.Encounter.PatientStatusId')
  - [PatientlocationId](#P-AthenaHealth-Sdk-Models-Response-Encounter-PatientlocationId 'AthenaHealth.Sdk.Models.Response.Encounter.PatientlocationId')
  - [ProviderFirstName](#P-AthenaHealth-Sdk-Models-Response-Encounter-ProviderFirstName 'AthenaHealth.Sdk.Models.Response.Encounter.ProviderFirstName')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Response-Encounter-ProviderId 'AthenaHealth.Sdk.Models.Response.Encounter.ProviderId')
  - [ProviderLastName](#P-AthenaHealth-Sdk-Models-Response-Encounter-ProviderLastName 'AthenaHealth.Sdk.Models.Response.Encounter.ProviderLastName')
  - [ProviderPhone](#P-AthenaHealth-Sdk-Models-Response-Encounter-ProviderPhone 'AthenaHealth.Sdk.Models.Response.Encounter.ProviderPhone')
  - [Stage](#P-AthenaHealth-Sdk-Models-Response-Encounter-Stage 'AthenaHealth.Sdk.Models.Response.Encounter.Stage')
  - [Status](#P-AthenaHealth-Sdk-Models-Response-Encounter-Status 'AthenaHealth.Sdk.Models.Response.Encounter.Status')
- [EncounterClient](#T-AthenaHealth-Sdk-Clients-EncounterClient 'AthenaHealth.Sdk.Clients.EncounterClient')
  - [GetDiagnoses(encounterId)](#M-AthenaHealth-Sdk-Clients-EncounterClient-GetDiagnoses-System-Int32- 'AthenaHealth.Sdk.Clients.EncounterClient.GetDiagnoses(System.Int32)')
  - [GetSummary(encounterId,filter)](#M-AthenaHealth-Sdk-Clients-EncounterClient-GetSummary-System-Int32,AthenaHealth-Sdk-Models-Request-GetEncounterSummaryFilter- 'AthenaHealth.Sdk.Clients.EncounterClient.GetSummary(System.Int32,AthenaHealth.Sdk.Models.Request.GetEncounterSummaryFilter)')
- [EncounterGetOrderByIdFilter](#T-AthenaHealth-Sdk-Models-Request-EncounterGetOrderByIdFilter 'AthenaHealth.Sdk.Models.Request.EncounterGetOrderByIdFilter')
  - [ShowExternalCodes](#P-AthenaHealth-Sdk-Models-Request-EncounterGetOrderByIdFilter-ShowExternalCodes 'AthenaHealth.Sdk.Models.Request.EncounterGetOrderByIdFilter.ShowExternalCodes')
  - [ShowQuestions](#P-AthenaHealth-Sdk-Models-Request-EncounterGetOrderByIdFilter-ShowQuestions 'AthenaHealth.Sdk.Models.Request.EncounterGetOrderByIdFilter.ShowQuestions')
- [EncounterGetOrdersFilter](#T-AthenaHealth-Sdk-Models-Request-EncounterGetOrdersFilter 'AthenaHealth.Sdk.Models.Request.EncounterGetOrdersFilter')
  - [AllowDischargeType](#P-AthenaHealth-Sdk-Models-Request-EncounterGetOrdersFilter-AllowDischargeType 'AthenaHealth.Sdk.Models.Request.EncounterGetOrdersFilter.AllowDischargeType')
  - [ShowClinicalProvider](#P-AthenaHealth-Sdk-Models-Request-EncounterGetOrdersFilter-ShowClinicalProvider 'AthenaHealth.Sdk.Models.Request.EncounterGetOrdersFilter.ShowClinicalProvider')
  - [ShowDeclinedOrders](#P-AthenaHealth-Sdk-Models-Request-EncounterGetOrdersFilter-ShowDeclinedOrders 'AthenaHealth.Sdk.Models.Request.EncounterGetOrdersFilter.ShowDeclinedOrders')
  - [ShowExternalCodes](#P-AthenaHealth-Sdk-Models-Request-EncounterGetOrdersFilter-ShowExternalCodes 'AthenaHealth.Sdk.Models.Request.EncounterGetOrdersFilter.ShowExternalCodes')
- [EncounterOrder](#T-AthenaHealth-Sdk-Models-Response-EncounterOrder 'AthenaHealth.Sdk.Models.Response.EncounterOrder')
  - [Class](#P-AthenaHealth-Sdk-Models-Response-EncounterOrder-Class 'AthenaHealth.Sdk.Models.Response.EncounterOrder.Class')
  - [ClassDescription](#P-AthenaHealth-Sdk-Models-Response-EncounterOrder-ClassDescription 'AthenaHealth.Sdk.Models.Response.EncounterOrder.ClassDescription')
  - [ClinicalProvider](#P-AthenaHealth-Sdk-Models-Response-EncounterOrder-ClinicalProvider 'AthenaHealth.Sdk.Models.Response.EncounterOrder.ClinicalProvider')
  - [ClinicalProviderId](#P-AthenaHealth-Sdk-Models-Response-EncounterOrder-ClinicalProviderId 'AthenaHealth.Sdk.Models.Response.EncounterOrder.ClinicalProviderId')
  - [DateOrdered](#P-AthenaHealth-Sdk-Models-Response-EncounterOrder-DateOrdered 'AthenaHealth.Sdk.Models.Response.EncounterOrder.DateOrdered')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Response-EncounterOrder-DepartmentId 'AthenaHealth.Sdk.Models.Response.EncounterOrder.DepartmentId')
  - [Description](#P-AthenaHealth-Sdk-Models-Response-EncounterOrder-Description 'AthenaHealth.Sdk.Models.Response.EncounterOrder.Description')
  - [DiagnosisList](#P-AthenaHealth-Sdk-Models-Response-EncounterOrder-DiagnosisList 'AthenaHealth.Sdk.Models.Response.EncounterOrder.DiagnosisList')
  - [DocumentationOnly](#P-AthenaHealth-Sdk-Models-Response-EncounterOrder-DocumentationOnly 'AthenaHealth.Sdk.Models.Response.EncounterOrder.DocumentationOnly')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-EncounterOrder-Id 'AthenaHealth.Sdk.Models.Response.EncounterOrder.Id')
  - [OrderType](#P-AthenaHealth-Sdk-Models-Response-EncounterOrder-OrderType 'AthenaHealth.Sdk.Models.Response.EncounterOrder.OrderType')
  - [OrderTypeId](#P-AthenaHealth-Sdk-Models-Response-EncounterOrder-OrderTypeId 'AthenaHealth.Sdk.Models.Response.EncounterOrder.OrderTypeId')
  - [OrderingProvider](#P-AthenaHealth-Sdk-Models-Response-EncounterOrder-OrderingProvider 'AthenaHealth.Sdk.Models.Response.EncounterOrder.OrderingProvider')
  - [SpecimenCollectionSite](#P-AthenaHealth-Sdk-Models-Response-EncounterOrder-SpecimenCollectionSite 'AthenaHealth.Sdk.Models.Response.EncounterOrder.SpecimenCollectionSite')
  - [Status](#P-AthenaHealth-Sdk-Models-Response-EncounterOrder-Status 'AthenaHealth.Sdk.Models.Response.EncounterOrder.Status')
- [EncounterOrdersResponse](#T-AthenaHealth-Sdk-Models-Response-EncounterOrdersResponse 'AthenaHealth.Sdk.Models.Response.EncounterOrdersResponse')
  - [Diagnosis](#P-AthenaHealth-Sdk-Models-Response-EncounterOrdersResponse-Diagnosis 'AthenaHealth.Sdk.Models.Response.EncounterOrdersResponse.Diagnosis')
  - [DiagnosisIcd](#P-AthenaHealth-Sdk-Models-Response-EncounterOrdersResponse-DiagnosisIcd 'AthenaHealth.Sdk.Models.Response.EncounterOrdersResponse.DiagnosisIcd')
  - [DiagnosisSnomed](#P-AthenaHealth-Sdk-Models-Response-EncounterOrdersResponse-DiagnosisSnomed 'AthenaHealth.Sdk.Models.Response.EncounterOrdersResponse.DiagnosisSnomed')
  - [Orders](#P-AthenaHealth-Sdk-Models-Response-EncounterOrdersResponse-Orders 'AthenaHealth.Sdk.Models.Response.EncounterOrdersResponse.Orders')
- [EnhancedBestmatchFilter](#T-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter')
  - [DateOfBirth](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-DateOfBirth 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.DateOfBirth')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.DepartmentId')
  - [Email](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-Email 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.Email')
  - [FirstName](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-FirstName 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.FirstName')
  - [GuarantorEmail](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-GuarantorEmail 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.GuarantorEmail')
  - [GuarantorPhone](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-GuarantorPhone 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.GuarantorPhone')
  - [HomePhone](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-HomePhone 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.HomePhone')
  - [IgnoreRestrictions](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-IgnoreRestrictions 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.IgnoreRestrictions')
  - [LastName](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-LastName 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.LastName')
  - [LimitLocalPatientId](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-LimitLocalPatientId 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.LimitLocalPatientId')
  - [MinScore](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-MinScore 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.MinScore')
  - [MobilePhone](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-MobilePhone 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.MobilePhone')
  - [PreferredName](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-PreferredName 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.PreferredName')
  - [ReturnBestMatches](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ReturnBestMatches 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.ReturnBestMatches')
  - [Show2015EdCehrtValues](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-Show2015EdCehrtValues 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.Show2015EdCehrtValues')
  - [ShowAllClaims](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowAllClaims 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.ShowAllClaims')
  - [ShowAllPatientDepartmentStatus](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowAllPatientDepartmentStatus 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.ShowAllPatientDepartmentStatus')
  - [ShowBalanceDetails](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowBalanceDetails 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.ShowBalanceDetails')
  - [ShowCustomFields](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowCustomFields 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.ShowCustomFields')
  - [ShowFullSsn](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowFullSsn 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.ShowFullSsn')
  - [ShowInsurance](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowInsurance 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.ShowInsurance')
  - [ShowLocalPatientId](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowLocalPatientId 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.ShowLocalPatientId')
  - [ShowPortalStatus](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowPortalStatus 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.ShowPortalStatus')
  - [Ssn](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-Ssn 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.Ssn')
  - [Suffix](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-Suffix 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.Suffix')
  - [UseSoundexSearch](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-UseSoundexSearch 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.UseSoundexSearch')
  - [WorkPhone](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-WorkPhone 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.WorkPhone')
  - [Zip](#P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-Zip 'AthenaHealth.Sdk.Models.Request.EnhancedBestmatchFilter.Zip')
- [Event](#T-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Event 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.Event')
- [Event](#T-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event')
  - [EventDate](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Event-EventDate 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.Event.EventDate')
  - [Type](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Event-Type 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.Event.Type')
  - [UserDisplayName](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Event-UserDisplayName 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.Event.UserDisplayName')
  - [CreatedBy](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-CreatedBy 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.CreatedBy')
  - [CreatedDate](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-CreatedDate 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.CreatedDate')
  - [Diagnoses](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Diagnoses 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.Diagnoses')
  - [EncounterDate](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-EncounterDate 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.EncounterDate')
  - [EndDate](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-EndDate 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.EndDate')
  - [EventType](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-EventType 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.EventType')
  - [Laterality](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Laterality 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.Laterality')
  - [Note](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Note 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.Note')
  - [OnsetDate](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-OnsetDate 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.OnsetDate')
  - [Source](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Source 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.Source')
  - [StartDate](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-StartDate 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.StartDate')
  - [Status](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Status 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event.Status')
- [ExpectedProcedureCode](#T-AthenaHealth-Sdk-Models-Response-Appointment-ExpectedProcedureCode 'AthenaHealth.Sdk.Models.Response.Appointment.ExpectedProcedureCode')
  - [ProcedureCode](#P-AthenaHealth-Sdk-Models-Response-Appointment-ExpectedProcedureCode-ProcedureCode 'AthenaHealth.Sdk.Models.Response.Appointment.ExpectedProcedureCode.ProcedureCode')
  - [ProcedureCodeDescription](#P-AthenaHealth-Sdk-Models-Response-Appointment-ExpectedProcedureCode-ProcedureCodeDescription 'AthenaHealth.Sdk.Models.Response.Appointment.ExpectedProcedureCode.ProcedureCodeDescription')
- [Facility](#T-AthenaHealth-Sdk-Models-Response-Facility 'AthenaHealth.Sdk.Models.Response.Facility')
  - [Address](#P-AthenaHealth-Sdk-Models-Response-Facility-Address 'AthenaHealth.Sdk.Models.Response.Facility.Address')
  - [City](#P-AthenaHealth-Sdk-Models-Response-Facility-City 'AthenaHealth.Sdk.Models.Response.Facility.City')
  - [Distance](#P-AthenaHealth-Sdk-Models-Response-Facility-Distance 'AthenaHealth.Sdk.Models.Response.Facility.Distance')
  - [FaxNumber](#P-AthenaHealth-Sdk-Models-Response-Facility-FaxNumber 'AthenaHealth.Sdk.Models.Response.Facility.FaxNumber')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-Facility-Id 'AthenaHealth.Sdk.Models.Response.Facility.Id')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-Facility-Name 'AthenaHealth.Sdk.Models.Response.Facility.Name')
  - [NcpdpId](#P-AthenaHealth-Sdk-Models-Response-Facility-NcpdpId 'AthenaHealth.Sdk.Models.Response.Facility.NcpdpId')
  - [PharmacyType](#P-AthenaHealth-Sdk-Models-Response-Facility-PharmacyType 'AthenaHealth.Sdk.Models.Response.Facility.PharmacyType')
  - [PhoneNumber](#P-AthenaHealth-Sdk-Models-Response-Facility-PhoneNumber 'AthenaHealth.Sdk.Models.Response.Facility.PhoneNumber')
  - [State](#P-AthenaHealth-Sdk-Models-Response-Facility-State 'AthenaHealth.Sdk.Models.Response.Facility.State')
  - [ZipCode](#P-AthenaHealth-Sdk-Models-Response-Facility-ZipCode 'AthenaHealth.Sdk.Models.Response.Facility.ZipCode')
- [Finding](#T-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Finding 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraph.Sentence.Finding')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Finding-Name 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraph.Sentence.Finding.Name')
  - [Note](#P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Finding-Note 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraph.Sentence.Finding.Note')
  - [SelectedOptions](#P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Finding-SelectedOptions 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraph.Sentence.Finding.SelectedOptions')
  - [Text](#P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Finding-Text 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraph.Sentence.Finding.Text')
  - [Type](#P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Finding-Type 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraph.Sentence.Finding.Type')
- [GetAnalytesFilter](#T-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter 'AthenaHealth.Sdk.Models.Request.GetAnalytesFilter')
  - [AllResultsByEncounterId](#P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-AllResultsByEncounterId 'AthenaHealth.Sdk.Models.Request.GetAnalytesFilter.AllResultsByEncounterId')
  - [AnalyteResultStatus](#P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-AnalyteResultStatus 'AthenaHealth.Sdk.Models.Request.GetAnalytesFilter.AnalyteResultStatus')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetAnalytesFilter.DepartmentId')
  - [EndDate](#P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-EndDate 'AthenaHealth.Sdk.Models.Request.GetAnalytesFilter.EndDate')
  - [ExactDuplicateDocumentId](#P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-ExactDuplicateDocumentId 'AthenaHealth.Sdk.Models.Request.GetAnalytesFilter.ExactDuplicateDocumentId')
  - [LabResultStatus](#P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-LabResultStatus 'AthenaHealth.Sdk.Models.Request.GetAnalytesFilter.LabResultStatus')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-Limit 'AthenaHealth.Sdk.Models.Request.GetAnalytesFilter.Limit')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-Offset 'AthenaHealth.Sdk.Models.Request.GetAnalytesFilter.Offset')
  - [ShowAbnormalDetails](#P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-ShowAbnormalDetails 'AthenaHealth.Sdk.Models.Request.GetAnalytesFilter.ShowAbnormalDetails')
  - [ShowHidden](#P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-ShowHidden 'AthenaHealth.Sdk.Models.Request.GetAnalytesFilter.ShowHidden')
  - [ShowTemplate](#P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-ShowTemplate 'AthenaHealth.Sdk.Models.Request.GetAnalytesFilter.ShowTemplate')
  - [StartDate](#P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-StartDate 'AthenaHealth.Sdk.Models.Request.GetAnalytesFilter.StartDate')
  - [SupersedEdDocumentId](#P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-SupersedEdDocumentId 'AthenaHealth.Sdk.Models.Request.GetAnalytesFilter.SupersedEdDocumentId')
- [GetAppointmentFilter](#T-AthenaHealth-Sdk-Models-Request-GetAppointmentFilter 'AthenaHealth.Sdk.Models.Request.GetAppointmentFilter')
  - [IgnoreRestrictions](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentFilter-IgnoreRestrictions 'AthenaHealth.Sdk.Models.Request.GetAppointmentFilter.IgnoreRestrictions')
  - [ShowClaimDetail](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentFilter-ShowClaimDetail 'AthenaHealth.Sdk.Models.Request.GetAppointmentFilter.ShowClaimDetail')
  - [ShowCopay](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentFilter-ShowCopay 'AthenaHealth.Sdk.Models.Request.GetAppointmentFilter.ShowCopay')
  - [ShowExpectedProcedureCodes](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentFilter-ShowExpectedProcedureCodes 'AthenaHealth.Sdk.Models.Request.GetAppointmentFilter.ShowExpectedProcedureCodes')
  - [ShowInsurance](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentFilter-ShowInsurance 'AthenaHealth.Sdk.Models.Request.GetAppointmentFilter.ShowInsurance')
  - [ShowPatientDetail](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentFilter-ShowPatientDetail 'AthenaHealth.Sdk.Models.Request.GetAppointmentFilter.ShowPatientDetail')
- [GetAppointmentInsurancesFilter](#T-AthenaHealth-Sdk-Models-Request-GetAppointmentInsurancesFilter 'AthenaHealth.Sdk.Models.Request.GetAppointmentInsurancesFilter')
  - [AppointmentId](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentInsurancesFilter-AppointmentId 'AthenaHealth.Sdk.Models.Request.GetAppointmentInsurancesFilter.AppointmentId')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentInsurancesFilter-Limit 'AthenaHealth.Sdk.Models.Request.GetAppointmentInsurancesFilter.Limit')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentInsurancesFilter-Offset 'AthenaHealth.Sdk.Models.Request.GetAppointmentInsurancesFilter.Offset')
  - [ShowCancelled](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentInsurancesFilter-ShowCancelled 'AthenaHealth.Sdk.Models.Request.GetAppointmentInsurancesFilter.ShowCancelled')
  - [ShowFullSsn](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentInsurancesFilter-ShowFullSsn 'AthenaHealth.Sdk.Models.Request.GetAppointmentInsurancesFilter.ShowFullSsn')
- [GetAppointmentReasonsFilter](#T-AthenaHealth-Sdk-Models-Request-GetAppointmentReasonsFilter 'AthenaHealth.Sdk.Models.Request.GetAppointmentReasonsFilter')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentReasonsFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetAppointmentReasonsFilter.DepartmentId')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentReasonsFilter-Limit 'AthenaHealth.Sdk.Models.Request.GetAppointmentReasonsFilter.Limit')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentReasonsFilter-Offset 'AthenaHealth.Sdk.Models.Request.GetAppointmentReasonsFilter.Offset')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentReasonsFilter-ProviderId 'AthenaHealth.Sdk.Models.Request.GetAppointmentReasonsFilter.ProviderId')
- [GetAppointmentSlotsFilter](#T-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter 'AthenaHealth.Sdk.Models.Request.GetAppointmentSlotsFilter')
  - [AppointmentTypeId](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-AppointmentTypeId 'AthenaHealth.Sdk.Models.Request.GetAppointmentSlotsFilter.AppointmentTypeId')
  - [BypassScheduleTimeChecks](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-BypassScheduleTimeChecks 'AthenaHealth.Sdk.Models.Request.GetAppointmentSlotsFilter.BypassScheduleTimeChecks')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetAppointmentSlotsFilter.DepartmentId')
  - [EndDate](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-EndDate 'AthenaHealth.Sdk.Models.Request.GetAppointmentSlotsFilter.EndDate')
  - [IgnoreSchedulablePermission](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-IgnoreSchedulablePermission 'AthenaHealth.Sdk.Models.Request.GetAppointmentSlotsFilter.IgnoreSchedulablePermission')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-Limit 'AthenaHealth.Sdk.Models.Request.GetAppointmentSlotsFilter.Limit')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-Offset 'AthenaHealth.Sdk.Models.Request.GetAppointmentSlotsFilter.Offset')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-ProviderId 'AthenaHealth.Sdk.Models.Request.GetAppointmentSlotsFilter.ProviderId')
  - [ReasonId](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-ReasonId 'AthenaHealth.Sdk.Models.Request.GetAppointmentSlotsFilter.ReasonId')
  - [ShowFrozenSlots](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-ShowFrozenSlots 'AthenaHealth.Sdk.Models.Request.GetAppointmentSlotsFilter.ShowFrozenSlots')
  - [StartDate](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-StartDate 'AthenaHealth.Sdk.Models.Request.GetAppointmentSlotsFilter.StartDate')
- [GetAppointmentSubscriptionsFilter](#T-AthenaHealth-Sdk-Models-Request-GetAppointmentSubscriptionsFilter 'AthenaHealth.Sdk.Models.Request.GetAppointmentSubscriptionsFilter')
  - [IncludeReminderCall](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentSubscriptionsFilter-IncludeReminderCall 'AthenaHealth.Sdk.Models.Request.GetAppointmentSubscriptionsFilter.IncludeReminderCall')
  - [IncludeSuggestedOverbooking](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentSubscriptionsFilter-IncludeSuggestedOverbooking 'AthenaHealth.Sdk.Models.Request.GetAppointmentSubscriptionsFilter.IncludeSuggestedOverbooking')
- [GetAppointmentTypeFilter](#T-AthenaHealth-Sdk-Models-Request-GetAppointmentTypeFilter 'AthenaHealth.Sdk.Models.Request.GetAppointmentTypeFilter')
  - [DepartmentIds](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentTypeFilter-DepartmentIds 'AthenaHealth.Sdk.Models.Request.GetAppointmentTypeFilter.DepartmentIds')
  - [HideGeneric](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentTypeFilter-HideGeneric 'AthenaHealth.Sdk.Models.Request.GetAppointmentTypeFilter.HideGeneric')
  - [HideNonGeneric](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentTypeFilter-HideNonGeneric 'AthenaHealth.Sdk.Models.Request.GetAppointmentTypeFilter.HideNonGeneric')
  - [HideNonPatient](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentTypeFilter-HideNonPatient 'AthenaHealth.Sdk.Models.Request.GetAppointmentTypeFilter.HideNonPatient')
  - [HideTemplateTypeOnly](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentTypeFilter-HideTemplateTypeOnly 'AthenaHealth.Sdk.Models.Request.GetAppointmentTypeFilter.HideTemplateTypeOnly')
  - [ProviderIds](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentTypeFilter-ProviderIds 'AthenaHealth.Sdk.Models.Request.GetAppointmentTypeFilter.ProviderIds')
- [GetAppointmentsBookedFilter](#T-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter')
  - [AppointmentStatus](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-AppointmentStatus 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter.AppointmentStatus')
  - [AppointmentTypeId](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-AppointmentTypeId 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter.AppointmentTypeId')
  - [DepartmentIds](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-DepartmentIds 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter.DepartmentIds')
  - [EndDate](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-EndDate 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter.EndDate')
  - [EndLastModified](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-EndLastModified 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter.EndLastModified')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-Limit 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter.Limit')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-Offset 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter.Offset')
  - [PatientId](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-PatientId 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter.PatientId')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-ProviderId 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter.ProviderId')
  - [ScheduledEndDate](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-ScheduledEndDate 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter.ScheduledEndDate')
  - [ScheduledStartDate](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-ScheduledStartDate 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter.ScheduledStartDate')
  - [ShowCancelled](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-ShowCancelled 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter.ShowCancelled')
  - [ShowReminderCallDetail](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-ShowReminderCallDetail 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter.ShowReminderCallDetail')
  - [StartDate](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-StartDate 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter.StartDate')
  - [StartLastModified](#P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-StartLastModified 'AthenaHealth.Sdk.Models.Request.GetAppointmentsBookedFilter.StartLastModified')
- [GetByIdProviderFilter](#T-AthenaHealth-Sdk-Models-Request-GetByIdProviderFilter 'AthenaHealth.Sdk.Models.Request.GetByIdProviderFilter')
  - [ShowFederalIdNumber](#P-AthenaHealth-Sdk-Models-Request-GetByIdProviderFilter-ShowFederalIdNumber 'AthenaHealth.Sdk.Models.Request.GetByIdProviderFilter.ShowFederalIdNumber')
- [GetCommonInsurancePackageFilter](#T-AthenaHealth-Sdk-Models-Request-GetCommonInsurancePackageFilter 'AthenaHealth.Sdk.Models.Request.GetCommonInsurancePackageFilter')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetCommonInsurancePackageFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetCommonInsurancePackageFilter.DepartmentId')
  - [ShowOnlyCasePolicies](#P-AthenaHealth-Sdk-Models-Request-GetCommonInsurancePackageFilter-ShowOnlyCasePolicies 'AthenaHealth.Sdk.Models.Request.GetCommonInsurancePackageFilter.ShowOnlyCasePolicies')
- [GetDepartmentFilter](#T-AthenaHealth-Sdk-Models-Request-GetDepartmentFilter 'AthenaHealth.Sdk.Models.Request.GetDepartmentFilter')
  - [HospitalOnly](#P-AthenaHealth-Sdk-Models-Request-GetDepartmentFilter-HospitalOnly 'AthenaHealth.Sdk.Models.Request.GetDepartmentFilter.HospitalOnly')
  - [ProviderList](#P-AthenaHealth-Sdk-Models-Request-GetDepartmentFilter-ProviderList 'AthenaHealth.Sdk.Models.Request.GetDepartmentFilter.ProviderList')
  - [ShowAllDepartments](#P-AthenaHealth-Sdk-Models-Request-GetDepartmentFilter-ShowAllDepartments 'AthenaHealth.Sdk.Models.Request.GetDepartmentFilter.ShowAllDepartments')
- [GetDocumentsFilter](#T-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter 'AthenaHealth.Sdk.Models.Request.GetDocumentsFilter')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetDocumentsFilter.DepartmentId')
  - [DocumentClass](#P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-DocumentClass 'AthenaHealth.Sdk.Models.Request.GetDocumentsFilter.DocumentClass')
  - [DocumentSubclass](#P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-DocumentSubclass 'AthenaHealth.Sdk.Models.Request.GetDocumentsFilter.DocumentSubclass')
  - [EncounterId](#P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-EncounterId 'AthenaHealth.Sdk.Models.Request.GetDocumentsFilter.EncounterId')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-Limit 'AthenaHealth.Sdk.Models.Request.GetDocumentsFilter.Limit')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-Offset 'AthenaHealth.Sdk.Models.Request.GetDocumentsFilter.Offset')
  - [ShowDeclinedOrders](#P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-ShowDeclinedOrders 'AthenaHealth.Sdk.Models.Request.GetDocumentsFilter.ShowDeclinedOrders')
  - [ShowDeleted](#P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-ShowDeleted 'AthenaHealth.Sdk.Models.Request.GetDocumentsFilter.ShowDeleted')
  - [Status](#P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-Status 'AthenaHealth.Sdk.Models.Request.GetDocumentsFilter.Status')
- [GetEncounterSummaryFilter](#T-AthenaHealth-Sdk-Models-Request-GetEncounterSummaryFilter 'AthenaHealth.Sdk.Models.Request.GetEncounterSummaryFilter')
  - [Mobile](#P-AthenaHealth-Sdk-Models-Request-GetEncounterSummaryFilter-Mobile 'AthenaHealth.Sdk.Models.Request.GetEncounterSummaryFilter.Mobile')
  - [SkipAmendments](#P-AthenaHealth-Sdk-Models-Request-GetEncounterSummaryFilter-SkipAmendments 'AthenaHealth.Sdk.Models.Request.GetEncounterSummaryFilter.SkipAmendments')
- [GetLabResultsFilter](#T-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter 'AthenaHealth.Sdk.Models.Request.GetLabResultsFilter')
  - [AllResultsByEncounterId](#P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-AllResultsByEncounterId 'AthenaHealth.Sdk.Models.Request.GetLabResultsFilter.AllResultsByEncounterId')
  - [AnalyteResultStatus](#P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-AnalyteResultStatus 'AthenaHealth.Sdk.Models.Request.GetLabResultsFilter.AnalyteResultStatus')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetLabResultsFilter.DepartmentId')
  - [EndDate](#P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-EndDate 'AthenaHealth.Sdk.Models.Request.GetLabResultsFilter.EndDate')
  - [ExactDuplicateDocumentId](#P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-ExactDuplicateDocumentId 'AthenaHealth.Sdk.Models.Request.GetLabResultsFilter.ExactDuplicateDocumentId')
  - [LabResultStatus](#P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-LabResultStatus 'AthenaHealth.Sdk.Models.Request.GetLabResultsFilter.LabResultStatus')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-Limit 'AthenaHealth.Sdk.Models.Request.GetLabResultsFilter.Limit')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-Offset 'AthenaHealth.Sdk.Models.Request.GetLabResultsFilter.Offset')
  - [ShowAbnormalDetails](#P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-ShowAbnormalDetails 'AthenaHealth.Sdk.Models.Request.GetLabResultsFilter.ShowAbnormalDetails')
  - [ShowHidden](#P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-ShowHidden 'AthenaHealth.Sdk.Models.Request.GetLabResultsFilter.ShowHidden')
  - [ShowTemplate](#P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-ShowTemplate 'AthenaHealth.Sdk.Models.Request.GetLabResultsFilter.ShowTemplate')
  - [StartDate](#P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-StartDate 'AthenaHealth.Sdk.Models.Request.GetLabResultsFilter.StartDate')
  - [SupersedEdDocumentId](#P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-SupersedEdDocumentId 'AthenaHealth.Sdk.Models.Request.GetLabResultsFilter.SupersedEdDocumentId')
- [GetMedicalHistoryQuestionsFilter](#T-AthenaHealth-Sdk-Models-Request-GetMedicalHistoryQuestionsFilter 'AthenaHealth.Sdk.Models.Request.GetMedicalHistoryQuestionsFilter')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-GetMedicalHistoryQuestionsFilter-Limit 'AthenaHealth.Sdk.Models.Request.GetMedicalHistoryQuestionsFilter.Limit')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-GetMedicalHistoryQuestionsFilter-Offset 'AthenaHealth.Sdk.Models.Request.GetMedicalHistoryQuestionsFilter.Offset')
  - [ShowDeleted](#P-AthenaHealth-Sdk-Models-Request-GetMedicalHistoryQuestionsFilter-ShowDeleted 'AthenaHealth.Sdk.Models.Request.GetMedicalHistoryQuestionsFilter.ShowDeleted')
- [GetMedicationsFilter](#T-AthenaHealth-Sdk-Models-Request-GetMedicationsFilter 'AthenaHealth.Sdk.Models.Request.GetMedicationsFilter')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetMedicationsFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetMedicationsFilter.DepartmentId')
  - [MedicationType](#P-AthenaHealth-Sdk-Models-Request-GetMedicationsFilter-MedicationType 'AthenaHealth.Sdk.Models.Request.GetMedicationsFilter.MedicationType')
  - [ShowNDC](#P-AthenaHealth-Sdk-Models-Request-GetMedicationsFilter-ShowNDC 'AthenaHealth.Sdk.Models.Request.GetMedicationsFilter.ShowNDC')
  - [ShowPending](#P-AthenaHealth-Sdk-Models-Request-GetMedicationsFilter-ShowPending 'AthenaHealth.Sdk.Models.Request.GetMedicationsFilter.ShowPending')
  - [ShowRxNorm](#P-AthenaHealth-Sdk-Models-Request-GetMedicationsFilter-ShowRxNorm 'AthenaHealth.Sdk.Models.Request.GetMedicationsFilter.ShowRxNorm')
- [GetPatientAppointmentFilter](#T-AthenaHealth-Sdk-Models-Request-GetPatientAppointmentFilter 'AthenaHealth.Sdk.Models.Request.GetPatientAppointmentFilter')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-GetPatientAppointmentFilter-Limit 'AthenaHealth.Sdk.Models.Request.GetPatientAppointmentFilter.Limit')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-GetPatientAppointmentFilter-Offset 'AthenaHealth.Sdk.Models.Request.GetPatientAppointmentFilter.Offset')
  - [ShowCancelled](#P-AthenaHealth-Sdk-Models-Request-GetPatientAppointmentFilter-ShowCancelled 'AthenaHealth.Sdk.Models.Request.GetPatientAppointmentFilter.ShowCancelled')
  - [ShowExpectedProcedureCodes](#P-AthenaHealth-Sdk-Models-Request-GetPatientAppointmentFilter-ShowExpectedProcedureCodes 'AthenaHealth.Sdk.Models.Request.GetPatientAppointmentFilter.ShowExpectedProcedureCodes')
  - [ShowPast](#P-AthenaHealth-Sdk-Models-Request-GetPatientAppointmentFilter-ShowPast 'AthenaHealth.Sdk.Models.Request.GetPatientAppointmentFilter.ShowPast')
- [GetPatientByIdFilter](#T-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter 'AthenaHealth.Sdk.Models.Request.GetPatientByIdFilter')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetPatientByIdFilter.DepartmentId')
  - [IgnoreRestrictions](#P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-IgnoreRestrictions 'AthenaHealth.Sdk.Models.Request.GetPatientByIdFilter.IgnoreRestrictions')
  - [LimitLocalPatientId](#P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-LimitLocalPatientId 'AthenaHealth.Sdk.Models.Request.GetPatientByIdFilter.LimitLocalPatientId')
  - [Show2015EdCehrtValues](#P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-Show2015EdCehrtValues 'AthenaHealth.Sdk.Models.Request.GetPatientByIdFilter.Show2015EdCehrtValues')
  - [ShowAllClaims](#P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowAllClaims 'AthenaHealth.Sdk.Models.Request.GetPatientByIdFilter.ShowAllClaims')
  - [ShowAllPatientDepartmentStatus](#P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowAllPatientDepartmentStatus 'AthenaHealth.Sdk.Models.Request.GetPatientByIdFilter.ShowAllPatientDepartmentStatus')
  - [ShowBalanceDetails](#P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowBalanceDetails 'AthenaHealth.Sdk.Models.Request.GetPatientByIdFilter.ShowBalanceDetails')
  - [ShowCustomFields](#P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowCustomFields 'AthenaHealth.Sdk.Models.Request.GetPatientByIdFilter.ShowCustomFields')
  - [ShowFullSsn](#P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowFullSsn 'AthenaHealth.Sdk.Models.Request.GetPatientByIdFilter.ShowFullSsn')
  - [ShowInsurance](#P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowInsurance 'AthenaHealth.Sdk.Models.Request.GetPatientByIdFilter.ShowInsurance')
  - [ShowLocalPatientId](#P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowLocalPatientId 'AthenaHealth.Sdk.Models.Request.GetPatientByIdFilter.ShowLocalPatientId')
  - [ShowPortalStatus](#P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowPortalStatus 'AthenaHealth.Sdk.Models.Request.GetPatientByIdFilter.ShowPortalStatus')
- [GetPatientEncountersFilter](#T-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter 'AthenaHealth.Sdk.Models.Request.GetPatientEncountersFilter')
  - [AppointmentId](#P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-AppointmentId 'AthenaHealth.Sdk.Models.Request.GetPatientEncountersFilter.AppointmentId')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetPatientEncountersFilter.DepartmentId')
  - [EndDate](#P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-EndDate 'AthenaHealth.Sdk.Models.Request.GetPatientEncountersFilter.EndDate')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-Limit 'AthenaHealth.Sdk.Models.Request.GetPatientEncountersFilter.Limit')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-Offset 'AthenaHealth.Sdk.Models.Request.GetPatientEncountersFilter.Offset')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-ProviderId 'AthenaHealth.Sdk.Models.Request.GetPatientEncountersFilter.ProviderId')
  - [ShowAllStatuses](#P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-ShowAllStatuses 'AthenaHealth.Sdk.Models.Request.GetPatientEncountersFilter.ShowAllStatuses')
  - [ShowAllTypes](#P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-ShowAllTypes 'AthenaHealth.Sdk.Models.Request.GetPatientEncountersFilter.ShowAllTypes')
  - [ShowDiagnoses](#P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-ShowDiagnoses 'AthenaHealth.Sdk.Models.Request.GetPatientEncountersFilter.ShowDiagnoses')
  - [StartDate](#P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-StartDate 'AthenaHealth.Sdk.Models.Request.GetPatientEncountersFilter.StartDate')
- [GetPatientInsurancesFilter](#T-AthenaHealth-Sdk-Models-Request-GetPatientInsurancesFilter 'AthenaHealth.Sdk.Models.Request.GetPatientInsurancesFilter')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetPatientInsurancesFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetPatientInsurancesFilter.DepartmentId')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-GetPatientInsurancesFilter-Limit 'AthenaHealth.Sdk.Models.Request.GetPatientInsurancesFilter.Limit')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-GetPatientInsurancesFilter-Offset 'AthenaHealth.Sdk.Models.Request.GetPatientInsurancesFilter.Offset')
  - [ShowCancelled](#P-AthenaHealth-Sdk-Models-Request-GetPatientInsurancesFilter-ShowCancelled 'AthenaHealth.Sdk.Models.Request.GetPatientInsurancesFilter.ShowCancelled')
  - [ShowFullSSN](#P-AthenaHealth-Sdk-Models-Request-GetPatientInsurancesFilter-ShowFullSSN 'AthenaHealth.Sdk.Models.Request.GetPatientInsurancesFilter.ShowFullSSN')
- [GetPatientProblemsFilter](#T-AthenaHealth-Sdk-Models-Request-GetPatientProblemsFilter 'AthenaHealth.Sdk.Models.Request.GetPatientProblemsFilter')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetPatientProblemsFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetPatientProblemsFilter.DepartmentId')
  - [ShowDiagnosisInfo](#P-AthenaHealth-Sdk-Models-Request-GetPatientProblemsFilter-ShowDiagnosisInfo 'AthenaHealth.Sdk.Models.Request.GetPatientProblemsFilter.ShowDiagnosisInfo')
  - [ShowInactive](#P-AthenaHealth-Sdk-Models-Request-GetPatientProblemsFilter-ShowInactive 'AthenaHealth.Sdk.Models.Request.GetPatientProblemsFilter.ShowInactive')
- [GetPatientsFilter](#T-AthenaHealth-Sdk-Models-Request-GetPatientsFilter 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter')
  - [Address1](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Address1 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Address1')
  - [Address2](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Address2 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Address2')
  - [AgriculturalWorker](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-AgriculturalWorker 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.AgriculturalWorker')
  - [AgriculturalWorkerType](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-AgriculturalWorkerType 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.AgriculturalWorkerType')
  - [AnyPhone](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-AnyPhone 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.AnyPhone')
  - [AppointmentDepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-AppointmentDepartmentId 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.AppointmentDepartmentId')
  - [AppointmentProviderId](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-AppointmentProviderId 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.AppointmentProviderId')
  - [CareSummaryDeliveryPreference](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-CareSummaryDeliveryPreference 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.CareSummaryDeliveryPreference')
  - [City](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-City 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.City')
  - [ClinicalOrderTypeGroupId](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ClinicalOrderTypeGroupId 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ClinicalOrderTypeGroupId')
  - [ConsentToCall](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ConsentToCall 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ConsentToCall')
  - [ConsentToText](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ConsentToText 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ConsentToText')
  - [ContactHomePhone](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactHomePhone 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactHomePhone')
  - [ContactMobilePhone](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactMobilePhone 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactMobilePhone')
  - [ContactName](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactName 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactName')
  - [ContactPreference](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreference 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactPreference')
  - [ContactPreferenceAnnouncementEmail](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceAnnouncementEmail 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactPreferenceAnnouncementEmail')
  - [ContactPreferenceAnnouncementPhone](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceAnnouncementPhone 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactPreferenceAnnouncementPhone')
  - [ContactPreferenceAnnouncementSms](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceAnnouncementSms 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactPreferenceAnnouncementSms')
  - [ContactPreferenceAppointmentEmail](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceAppointmentEmail 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactPreferenceAppointmentEmail')
  - [ContactPreferenceAppointmentPhone](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceAppointmentPhone 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactPreferenceAppointmentPhone')
  - [ContactPreferenceAppointmentSms](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceAppointmentSms 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactPreferenceAppointmentSms')
  - [ContactPreferenceBillingEmail](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceBillingEmail 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactPreferenceBillingEmail')
  - [ContactPreferenceBillingPhone](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceBillingPhone 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactPreferenceBillingPhone')
  - [ContactPreferenceBillingSms](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceBillingSms 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactPreferenceBillingSms')
  - [ContactPreferenceLabEmail](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceLabEmail 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactPreferenceLabEmail')
  - [ContactPreferenceLabPhone](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceLabPhone 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactPreferenceLabPhone')
  - [ContactPreferenceLabSms](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceLabSms 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactPreferenceLabSms')
  - [ContactRelationship](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactRelationship 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ContactRelationship')
  - [CountryCode3166](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-CountryCode3166 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.CountryCode3166')
  - [DateOfBirth](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-DateOfBirth 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.DateOfBirth')
  - [DeceasedDate](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-DeceasedDate 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.DeceasedDate')
  - [DefaultPharmacyNcpdpId](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-DefaultPharmacyNcpdpId 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.DefaultPharmacyNcpdpId')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.DepartmentId')
  - [DriversLicenseExpirationDate](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-DriversLicenseExpirationDate 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.DriversLicenseExpirationDate')
  - [DriversLicenseNumber](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-DriversLicenseNumber 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.DriversLicenseNumber')
  - [DriversLicenseStateId](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-DriversLicenseStateId 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.DriversLicenseStateId')
  - [Email](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Email 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Email')
  - [EmployerId](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-EmployerId 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.EmployerId')
  - [EmployerPhone](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-EmployerPhone 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.EmployerPhone')
  - [EthnicityCode](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-EthnicityCode 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.EthnicityCode')
  - [FirstName](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-FirstName 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.FirstName')
  - [GuarantorAddress1](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorAddress1 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorAddress1')
  - [GuarantorAddress2](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorAddress2 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorAddress2')
  - [GuarantorCity](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorCity 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorCity')
  - [GuarantorCountryCode3166](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorCountryCode3166 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorCountryCode3166')
  - [GuarantorDateOfBirth](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorDateOfBirth 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorDateOfBirth')
  - [GuarantorEmail](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorEmail 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorEmail')
  - [GuarantorEmployerId](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorEmployerId 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorEmployerId')
  - [GuarantorFirstName](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorFirstName 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorFirstName')
  - [GuarantorLastName](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorLastName 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorLastName')
  - [GuarantorMiddleName](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorMiddleName 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorMiddleName')
  - [GuarantorPhone](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorPhone 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorPhone')
  - [GuarantorRelationshipToPatient](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorRelationshipToPatient 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorRelationshipToPatient')
  - [GuarantorSSN](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorSSN 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorSSN')
  - [GuarantorState](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorState 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorState')
  - [GuarantorSuffix](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorSuffix 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorSuffix')
  - [GuarantorZip](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorZip 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuarantorZip')
  - [GuardianGirstName](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuardianGirstName 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuardianGirstName')
  - [GuardianLastName](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuardianLastName 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuardianLastName')
  - [GuardianMiddleName](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuardianMiddleName 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuardianMiddleName')
  - [GuardianSuffix](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuardianSuffix 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.GuardianSuffix')
  - [HasMobile](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-HasMobile 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.HasMobile')
  - [HierarchicalCode](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-HierarchicalCode 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.HierarchicalCode')
  - [HomePhone](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-HomePhone 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.HomePhone')
  - [Homebound](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Homebound 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Homebound')
  - [Homeless](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Homeless 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Homeless')
  - [HomelessType](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-HomelessType 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.HomelessType')
  - [IgnoreRestrictions](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-IgnoreRestrictions 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.IgnoreRestrictions')
  - [IndustryCode](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-IndustryCode 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.IndustryCode')
  - [Language6392Code](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Language6392Code 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Language6392Code')
  - [LastName](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-LastName 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.LastName')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Limit 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Limit')
  - [MaritalStatus](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-MaritalStatus 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.MaritalStatus')
  - [MiddleName](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-MiddleName 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.MiddleName')
  - [MobileCarrierId](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-MobileCarrierId 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.MobileCarrierId')
  - [MobilePhone](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-MobilePhone 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.MobilePhone')
  - [NextKinName](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-NextKinName 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.NextKinName')
  - [NextKinPhone](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-NextKinPhone 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.NextKinPhone')
  - [NextKinRelationship](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-NextKinRelationship 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.NextKinRelationship')
  - [Notes](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Notes 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Notes')
  - [OccupationCode](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-OccupationCode 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.OccupationCode')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Offset 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Offset')
  - [OmitBalances](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-OmitBalances 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.OmitBalances')
  - [OmitDefaultPharmacy](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-OmitDefaultPharmacy 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.OmitDefaultPharmacy')
  - [OmitPhotoInformation](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-OmitPhotoInformation 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.OmitPhotoInformation')
  - [OnlineStatementOnly](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-OnlineStatementOnly 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.OnlineStatementOnly')
  - [PortalAccessGiven](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PortalAccessGiven 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.PortalAccessGiven')
  - [PovertyLevelCalculated](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PovertyLevelCalculated 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.PovertyLevelCalculated')
  - [PovertyLevelFamilySize](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PovertyLevelFamilySize 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.PovertyLevelFamilySize')
  - [PovertyLevelFamilySizeDeclined](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PovertyLevelFamilySizeDeclined 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.PovertyLevelFamilySizeDeclined')
  - [PovertyLevelIncomeDeclined](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PovertyLevelIncomeDeclined 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.PovertyLevelIncomeDeclined')
  - [PovertyLevelIncomePayPeriod](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PovertyLevelIncomePayPeriod 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.PovertyLevelIncomePayPeriod')
  - [PovertyLevelIncomePerPayPeriod](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PovertyLevelIncomePerPayPeriod 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.PovertyLevelIncomePerPayPeriod')
  - [PovertyLevelIncomeRangeDeclined](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PovertyLevelIncomeRangeDeclined 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.PovertyLevelIncomeRangeDeclined')
  - [PreferredName](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PreferredName 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.PreferredName')
  - [PrimaryDepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PrimaryDepartmentId 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.PrimaryDepartmentId')
  - [PrimaryProviderId](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PrimaryProviderId 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.PrimaryProviderId')
  - [PublicHousing](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PublicHousing 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.PublicHousing')
  - [Race](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Race 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Race')
  - [ReferralSourceId](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ReferralSourceId 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.ReferralSourceId')
  - [RegistrationDate](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-RegistrationDate 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.RegistrationDate')
  - [SSN](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-SSN 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.SSN')
  - [SchoolBasedHealthCenter](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-SchoolBasedHealthCenter 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.SchoolBasedHealthCenter')
  - [Sex](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Sex 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Sex')
  - [Show2015EdCehrtValues](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Show2015EdCehrtValues 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Show2015EdCehrtValues')
  - [State](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-State 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.State')
  - [Status](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Status 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Status')
  - [Suffix](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Suffix 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Suffix')
  - [UpcomingAppointmentHours](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-UpcomingAppointmentHours 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.UpcomingAppointmentHours')
  - [Veteran](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Veteran 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Veteran')
  - [WorkPhone](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-WorkPhone 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.WorkPhone')
  - [Zip](#P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Zip 'AthenaHealth.Sdk.Models.Request.GetPatientsFilter.Zip')
- [GetPreferredPharmacyFilter](#T-AthenaHealth-Sdk-Models-Request-GetPreferredPharmacyFilter 'AthenaHealth.Sdk.Models.Request.GetPreferredPharmacyFilter')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetPreferredPharmacyFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetPreferredPharmacyFilter.DepartmentId')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-GetPreferredPharmacyFilter-Limit 'AthenaHealth.Sdk.Models.Request.GetPreferredPharmacyFilter.Limit')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-GetPreferredPharmacyFilter-Offset 'AthenaHealth.Sdk.Models.Request.GetPreferredPharmacyFilter.Offset')
- [GetPrescriptionsFilter](#T-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter 'AthenaHealth.Sdk.Models.Request.GetPrescriptionsFilter')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetPrescriptionsFilter.DepartmentId')
  - [DocumentClass](#P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-DocumentClass 'AthenaHealth.Sdk.Models.Request.GetPrescriptionsFilter.DocumentClass')
  - [DocumentSubclass](#P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-DocumentSubclass 'AthenaHealth.Sdk.Models.Request.GetPrescriptionsFilter.DocumentSubclass')
  - [EncounterId](#P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-EncounterId 'AthenaHealth.Sdk.Models.Request.GetPrescriptionsFilter.EncounterId')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-Limit 'AthenaHealth.Sdk.Models.Request.GetPrescriptionsFilter.Limit')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-Offset 'AthenaHealth.Sdk.Models.Request.GetPrescriptionsFilter.Offset')
  - [ShowDeclinedOrders](#P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-ShowDeclinedOrders 'AthenaHealth.Sdk.Models.Request.GetPrescriptionsFilter.ShowDeclinedOrders')
  - [ShowDeleted](#P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-ShowDeleted 'AthenaHealth.Sdk.Models.Request.GetPrescriptionsFilter.ShowDeleted')
  - [Status](#P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-Status 'AthenaHealth.Sdk.Models.Request.GetPrescriptionsFilter.Status')
- [GetProviderFilter](#T-AthenaHealth-Sdk-Models-Request-GetProviderFilter 'AthenaHealth.Sdk.Models.Request.GetProviderFilter')
  - [ProviderType](#P-AthenaHealth-Sdk-Models-Request-GetProviderFilter-ProviderType 'AthenaHealth.Sdk.Models.Request.GetProviderFilter.ProviderType')
  - [ShowAllProviderIds](#P-AthenaHealth-Sdk-Models-Request-GetProviderFilter-ShowAllProviderIds 'AthenaHealth.Sdk.Models.Request.GetProviderFilter.ShowAllProviderIds')
  - [ShowUsualDepartmentGuessThreshold](#P-AthenaHealth-Sdk-Models-Request-GetProviderFilter-ShowUsualDepartmentGuessThreshold 'AthenaHealth.Sdk.Models.Request.GetProviderFilter.ShowUsualDepartmentGuessThreshold')
- [GetSocialHistoryFilter](#T-AthenaHealth-Sdk-Models-Request-GetSocialHistoryFilter 'AthenaHealth.Sdk.Models.Request.GetSocialHistoryFilter')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetSocialHistoryFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetSocialHistoryFilter.DepartmentId')
  - [RecipientCategory](#P-AthenaHealth-Sdk-Models-Request-GetSocialHistoryFilter-RecipientCategory 'AthenaHealth.Sdk.Models.Request.GetSocialHistoryFilter.RecipientCategory')
  - [ShowNotPerformedQuestions](#P-AthenaHealth-Sdk-Models-Request-GetSocialHistoryFilter-ShowNotPerformedQuestions 'AthenaHealth.Sdk.Models.Request.GetSocialHistoryFilter.ShowNotPerformedQuestions')
  - [ShowUnansweredQuestions](#P-AthenaHealth-Sdk-Models-Request-GetSocialHistoryFilter-ShowUnansweredQuestions 'AthenaHealth.Sdk.Models.Request.GetSocialHistoryFilter.ShowUnansweredQuestions')
- [GetTopInsurancePackageFilter](#T-AthenaHealth-Sdk-Models-Request-GetTopInsurancePackageFilter 'AthenaHealth.Sdk.Models.Request.GetTopInsurancePackageFilter')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetTopInsurancePackageFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetTopInsurancePackageFilter.DepartmentId')
- [GetWaitlistFilter](#T-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter 'AthenaHealth.Sdk.Models.Request.GetWaitlistFilter')
  - [AppointmentId](#P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-AppointmentId 'AthenaHealth.Sdk.Models.Request.GetWaitlistFilter.AppointmentId')
  - [AppointmentTypeId](#P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-AppointmentTypeId 'AthenaHealth.Sdk.Models.Request.GetWaitlistFilter.AppointmentTypeId')
  - [DayOfWeekIds](#P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-DayOfWeekIds 'AthenaHealth.Sdk.Models.Request.GetWaitlistFilter.DayOfWeekIds')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.GetWaitlistFilter.DepartmentId')
  - [HourFrom](#P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-HourFrom 'AthenaHealth.Sdk.Models.Request.GetWaitlistFilter.HourFrom')
  - [HourTo](#P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-HourTo 'AthenaHealth.Sdk.Models.Request.GetWaitlistFilter.HourTo')
  - [PatientId](#P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-PatientId 'AthenaHealth.Sdk.Models.Request.GetWaitlistFilter.PatientId')
  - [Priority](#P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-Priority 'AthenaHealth.Sdk.Models.Request.GetWaitlistFilter.Priority')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-ProviderId 'AthenaHealth.Sdk.Models.Request.GetWaitlistFilter.ProviderId')
- [IAppointmentClient](#T-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient')
  - [AddToWaitList(request)](#M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-AddToWaitList-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest- 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient.AddToWaitList(AthenaHealth.Sdk.Models.Request.AddToWaitListRequest)')
  - [CancelCheckIn(appointmentId)](#M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-CancelCheckIn-System-Int32- 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient.CancelCheckIn(System.Int32)')
  - [CompleteCheckIn(appointmentId)](#M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-CompleteCheckIn-System-Int32- 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient.CompleteCheckIn(System.Int32)')
  - [CreateNote(appointmentId,text,displayOnSchedule)](#M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-CreateNote-System-Int32,System-String,System-Boolean- 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient.CreateNote(System.Int32,System.String,System.Boolean)')
  - [CreateReminder(reminder)](#M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-CreateReminder-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder- 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient.CreateReminder(AthenaHealth.Sdk.Models.Request.CreateAppointmentReminder)')
  - [DeleteReminderById(appointmentReminderId)](#M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-DeleteReminderById-System-Int32- 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient.DeleteReminderById(System.Int32)')
  - [GetCheckInRequirements(appointmentId)](#M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-GetCheckInRequirements-System-Int32- 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient.GetCheckInRequirements(System.Int32)')
  - [GetNotes(appointmentId,showDeleted)](#M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-GetNotes-System-Int32,System-Boolean- 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient.GetNotes(System.Int32,System.Boolean)')
  - [GetReminderById(appointmentReminderId)](#M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-GetReminderById-System-Int32- 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient.GetReminderById(System.Int32)')
  - [GetWaitList(filter)](#M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-GetWaitList-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter- 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient.GetWaitList(AthenaHealth.Sdk.Models.Request.GetWaitlistFilter)')
  - [SearchReminders(filter)](#M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-SearchReminders-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter- 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient.SearchReminders(AthenaHealth.Sdk.Models.Request.SearchAppointmentRemindersFilter)')
  - [StartCheckIn(appointmentId)](#M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-StartCheckIn-System-Int32- 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient.StartCheckIn(System.Int32)')
- [IConnection](#T-AthenaHealth-Sdk-Http-IConnection 'AthenaHealth.Sdk.Http.IConnection')
  - [BaseAddress](#P-AthenaHealth-Sdk-Http-IConnection-BaseAddress 'AthenaHealth.Sdk.Http.IConnection.BaseAddress')
  - [Credentials](#P-AthenaHealth-Sdk-Http-IConnection-Credentials 'AthenaHealth.Sdk.Http.IConnection.Credentials')
  - [Delete\`\`1(relativeUrl,queryParameters)](#M-AthenaHealth-Sdk-Http-IConnection-Delete``1-System-String,System-Object- 'AthenaHealth.Sdk.Http.IConnection.Delete``1(System.String,System.Object)')
  - [Get\`\`1(relativeUrl,queryParameters)](#M-AthenaHealth-Sdk-Http-IConnection-Get``1-System-String,System-Object,System-Boolean- 'AthenaHealth.Sdk.Http.IConnection.Get``1(System.String,System.Object,System.Boolean)')
  - [Post\`\`1(relativeUrl,queryParameters,body,asMultipart)](#M-AthenaHealth-Sdk-Http-IConnection-Post``1-System-String,System-Object,System-Object,System-Boolean- 'AthenaHealth.Sdk.Http.IConnection.Post``1(System.String,System.Object,System.Object,System.Boolean)')
  - [Put\`\`1(relativeUrl,queryParameters,body)](#M-AthenaHealth-Sdk-Http-IConnection-Put``1-System-String,System-Object,System-Object- 'AthenaHealth.Sdk.Http.IConnection.Put``1(System.String,System.Object,System.Object)')
- [IDepartmentClient](#T-AthenaHealth-Sdk-Clients-Interfaces-IDepartmentClient 'AthenaHealth.Sdk.Clients.Interfaces.IDepartmentClient')
  - [SearchFacilities(filter)](#M-AthenaHealth-Sdk-Clients-Interfaces-IDepartmentClient-SearchFacilities-AthenaHealth-Sdk-Models-Request-SearchFacilitiesFilter- 'AthenaHealth.Sdk.Clients.Interfaces.IDepartmentClient.SearchFacilities(AthenaHealth.Sdk.Models.Request.SearchFacilitiesFilter)')
- [IDictionaryClient](#T-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient 'AthenaHealth.Sdk.Clients.Interfaces.IDictionaryClient')
  - [GetMedicalHistoryQuestions(filter)](#M-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient-GetMedicalHistoryQuestions-AthenaHealth-Sdk-Models-Request-GetMedicalHistoryQuestionsFilter- 'AthenaHealth.Sdk.Clients.Interfaces.IDictionaryClient.GetMedicalHistoryQuestions(AthenaHealth.Sdk.Models.Request.GetMedicalHistoryQuestionsFilter)')
  - [GetPaymentMethods(filter)](#M-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient-GetPaymentMethods-AthenaHealth-Sdk-Models-Request-BaseLimitFilter- 'AthenaHealth.Sdk.Clients.Interfaces.IDictionaryClient.GetPaymentMethods(AthenaHealth.Sdk.Models.Request.BaseLimitFilter)')
  - [GetProviderTypes(filter)](#M-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient-GetProviderTypes-AthenaHealth-Sdk-Models-Request-BaseLimitFilter- 'AthenaHealth.Sdk.Clients.Interfaces.IDictionaryClient.GetProviderTypes(AthenaHealth.Sdk.Models.Request.BaseLimitFilter)')
  - [SearchAllergiesByName(name)](#M-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient-SearchAllergiesByName-System-String- 'AthenaHealth.Sdk.Clients.Interfaces.IDictionaryClient.SearchAllergiesByName(System.String)')
  - [SearchMedicationsByName(name)](#M-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient-SearchMedicationsByName-System-String- 'AthenaHealth.Sdk.Clients.Interfaces.IDictionaryClient.SearchMedicationsByName(System.String)')
  - [SearchOrderTypesByName(name)](#M-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient-SearchOrderTypesByName-System-String- 'AthenaHealth.Sdk.Clients.Interfaces.IDictionaryClient.SearchOrderTypesByName(System.String)')
- [IEncounterClient](#T-AthenaHealth-Sdk-Clients-Interfaces-IEncounterClient 'AthenaHealth.Sdk.Clients.Interfaces.IEncounterClient')
  - [CreateOrderLab(encounterId,model)](#M-AthenaHealth-Sdk-Clients-Interfaces-IEncounterClient-CreateOrderLab-System-Int32,AthenaHealth-Sdk-Models-Request-CreateOrderLab- 'AthenaHealth.Sdk.Clients.Interfaces.IEncounterClient.CreateOrderLab(System.Int32,AthenaHealth.Sdk.Models.Request.CreateOrderLab)')
  - [GetDiagnoses(encounterId)](#M-AthenaHealth-Sdk-Clients-Interfaces-IEncounterClient-GetDiagnoses-System-Int32- 'AthenaHealth.Sdk.Clients.Interfaces.IEncounterClient.GetDiagnoses(System.Int32)')
  - [GetOrderById(encounterId,orderId,filter)](#M-AthenaHealth-Sdk-Clients-Interfaces-IEncounterClient-GetOrderById-System-Int32,System-Int32,AthenaHealth-Sdk-Models-Request-EncounterGetOrderByIdFilter- 'AthenaHealth.Sdk.Clients.Interfaces.IEncounterClient.GetOrderById(System.Int32,System.Int32,AthenaHealth.Sdk.Models.Request.EncounterGetOrderByIdFilter)')
  - [GetOrders(encounterId,filter)](#M-AthenaHealth-Sdk-Clients-Interfaces-IEncounterClient-GetOrders-System-Int32,AthenaHealth-Sdk-Models-Request-EncounterGetOrdersFilter- 'AthenaHealth.Sdk.Clients.Interfaces.IEncounterClient.GetOrders(System.Int32,AthenaHealth.Sdk.Models.Request.EncounterGetOrdersFilter)')
  - [GetSummary(encounterId,filter)](#M-AthenaHealth-Sdk-Clients-Interfaces-IEncounterClient-GetSummary-System-Int32,AthenaHealth-Sdk-Models-Request-GetEncounterSummaryFilter- 'AthenaHealth.Sdk.Clients.Interfaces.IEncounterClient.GetSummary(System.Int32,AthenaHealth.Sdk.Models.Request.GetEncounterSummaryFilter)')
- [IInsurancePackageClient](#T-AthenaHealth-Sdk-Clients-Interfaces-IInsurancePackageClient 'AthenaHealth.Sdk.Clients.Interfaces.IInsurancePackageClient')
  - [GetCommon(filter)](#M-AthenaHealth-Sdk-Clients-Interfaces-IInsurancePackageClient-GetCommon-AthenaHealth-Sdk-Models-Request-GetCommonInsurancePackageFilter- 'AthenaHealth.Sdk.Clients.Interfaces.IInsurancePackageClient.GetCommon(AthenaHealth.Sdk.Models.Request.GetCommonInsurancePackageFilter)')
  - [GetTop(filter)](#M-AthenaHealth-Sdk-Clients-Interfaces-IInsurancePackageClient-GetTop-AthenaHealth-Sdk-Models-Request-GetTopInsurancePackageFilter- 'AthenaHealth.Sdk.Clients.Interfaces.IInsurancePackageClient.GetTop(AthenaHealth.Sdk.Models.Request.GetTopInsurancePackageFilter)')
  - [Search(filter)](#M-AthenaHealth-Sdk-Clients-Interfaces-IInsurancePackageClient-Search-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter- 'AthenaHealth.Sdk.Clients.Interfaces.IInsurancePackageClient.Search(AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter)')
- [IPatientClient](#T-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient 'AthenaHealth.Sdk.Clients.Interfaces.IPatientClient')
  - [AddMedication(patientId,medication)](#M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-AddMedication-System-Int32,AthenaHealth-Sdk-Models-Response-AddMedication- 'AthenaHealth.Sdk.Clients.Interfaces.IPatientClient.AddMedication(System.Int32,AthenaHealth.Sdk.Models.Response.AddMedication)')
  - [CreateInsurance(patientId,insurance)](#M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-CreateInsurance-System-Int32,AthenaHealth-Sdk-Models-Request-CreateInsurance- 'AthenaHealth.Sdk.Clients.Interfaces.IPatientClient.CreateInsurance(System.Int32,AthenaHealth.Sdk.Models.Request.CreateInsurance)')
  - [DeleteInsurance(patientId,sequenceNumber,departmentId,cancellationNote)](#M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-DeleteInsurance-System-Int32,AthenaHealth-Sdk-Models-Enums-SequenceEnum,System-Nullable{System-Int32},System-String- 'AthenaHealth.Sdk.Clients.Interfaces.IPatientClient.DeleteInsurance(System.Int32,AthenaHealth.Sdk.Models.Enums.SequenceEnum,System.Nullable{System.Int32},System.String)')
  - [DeleteInsuranceCardPhoto(patientId,insuranceId)](#M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-DeleteInsuranceCardPhoto-System-Int32,System-Int32- 'AthenaHealth.Sdk.Clients.Interfaces.IPatientClient.DeleteInsuranceCardPhoto(System.Int32,System.Int32)')
  - [DeletePhoto(patientId)](#M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-DeletePhoto-System-Int32- 'AthenaHealth.Sdk.Clients.Interfaces.IPatientClient.DeletePhoto(System.Int32)')
  - [GetInsuranceCardPhoto(patientId,insuranceId,jpegOutput)](#M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-GetInsuranceCardPhoto-System-Int32,System-Int32,System-Nullable{System-Boolean}- 'AthenaHealth.Sdk.Clients.Interfaces.IPatientClient.GetInsuranceCardPhoto(System.Int32,System.Int32,System.Nullable{System.Boolean})')
  - [GetPhoto(patientId,jpegOutput)](#M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-GetPhoto-System-Int32,System-Nullable{System-Boolean}- 'AthenaHealth.Sdk.Clients.Interfaces.IPatientClient.GetPhoto(System.Int32,System.Nullable{System.Boolean})')
  - [GetPrivacyInformation(patientId,departmentId)](#M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-GetPrivacyInformation-System-Int32,System-Int32- 'AthenaHealth.Sdk.Clients.Interfaces.IPatientClient.GetPrivacyInformation(System.Int32,System.Int32)')
  - [SetAllergies(request)](#M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-SetAllergies-AthenaHealth-Sdk-Models-Request-SetPatientAllergies- 'AthenaHealth.Sdk.Clients.Interfaces.IPatientClient.SetAllergies(AthenaHealth.Sdk.Models.Request.SetPatientAllergies)')
  - [SetMedicationSettings(patientId,setting)](#M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-SetMedicationSettings-System-Int32,AthenaHealth-Sdk-Models-Request-MedicationSetting- 'AthenaHealth.Sdk.Clients.Interfaces.IPatientClient.SetMedicationSettings(System.Int32,AthenaHealth.Sdk.Models.Request.MedicationSetting)')
  - [SetPatientDefaultLaboratory(patientId,departmentId,clinicalProviderId)](#M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-SetPatientDefaultLaboratory-System-Int32,System-Int32,System-Int32- 'AthenaHealth.Sdk.Clients.Interfaces.IPatientClient.SetPatientDefaultLaboratory(System.Int32,System.Int32,System.Int32)')
  - [SetPrivacyInformation(patientId,request)](#M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-SetPrivacyInformation-System-Int32,AthenaHealth-Sdk-Models-Request-SetPrivacyInformation- 'AthenaHealth.Sdk.Clients.Interfaces.IPatientClient.SetPrivacyInformation(System.Int32,AthenaHealth.Sdk.Models.Request.SetPrivacyInformation)')
  - [UpdateInsuranceCardPhoto(patientId,insuranceId,request)](#M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-UpdateInsuranceCardPhoto-System-Int32,System-Int32,AthenaHealth-Sdk-Models-Request-UpdateInsuranceCardPhoto- 'AthenaHealth.Sdk.Clients.Interfaces.IPatientClient.UpdateInsuranceCardPhoto(System.Int32,System.Int32,AthenaHealth.Sdk.Models.Request.UpdateInsuranceCardPhoto)')
  - [UpdatePhoto(patientId,request)](#M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-UpdatePhoto-System-Int32,AthenaHealth-Sdk-Models-Request-UpdatePhoto- 'AthenaHealth.Sdk.Clients.Interfaces.IPatientClient.UpdatePhoto(System.Int32,AthenaHealth.Sdk.Models.Request.UpdatePhoto)')
- [IPracticeClient](#T-AthenaHealth-Sdk-Clients-Interfaces-IPracticeClient 'AthenaHealth.Sdk.Clients.Interfaces.IPracticeClient')
  - [GetCurrentPractice(filter)](#M-AthenaHealth-Sdk-Clients-Interfaces-IPracticeClient-GetCurrentPractice-AthenaHealth-Sdk-Models-Request-BaseLimitFilter- 'AthenaHealth.Sdk.Clients.Interfaces.IPracticeClient.GetCurrentPractice(AthenaHealth.Sdk.Models.Request.BaseLimitFilter)')
- [IcdCode](#T-AthenaHealth-Sdk-Models-Response-IcdCode 'AthenaHealth.Sdk.Models.Response.IcdCode')
  - [Code](#P-AthenaHealth-Sdk-Models-Response-IcdCode-Code 'AthenaHealth.Sdk.Models.Response.IcdCode.Code')
  - [Codeset](#P-AthenaHealth-Sdk-Models-Response-IcdCode-Codeset 'AthenaHealth.Sdk.Models.Response.IcdCode.Codeset')
  - [Description](#P-AthenaHealth-Sdk-Models-Response-IcdCode-Description 'AthenaHealth.Sdk.Models.Response.IcdCode.Description')
  - [DiagnosisCode](#P-AthenaHealth-Sdk-Models-Response-IcdCode-DiagnosisCode 'AthenaHealth.Sdk.Models.Response.IcdCode.DiagnosisCode')
- [InputTypeEnum](#T-AthenaHealth-Sdk-Models-Enums-InputTypeEnum 'AthenaHealth.Sdk.Models.Enums.InputTypeEnum')
  - [ApproxDate](#F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-ApproxDate 'AthenaHealth.Sdk.Models.Enums.InputTypeEnum.ApproxDate')
  - [AutoComplete](#F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-AutoComplete 'AthenaHealth.Sdk.Models.Enums.InputTypeEnum.AutoComplete')
  - [CheckBox](#F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-CheckBox 'AthenaHealth.Sdk.Models.Enums.InputTypeEnum.CheckBox')
  - [Date](#F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-Date 'AthenaHealth.Sdk.Models.Enums.InputTypeEnum.Date')
  - [DropDown](#F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-DropDown 'AthenaHealth.Sdk.Models.Enums.InputTypeEnum.DropDown')
  - [FreeText](#F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-FreeText 'AthenaHealth.Sdk.Models.Enums.InputTypeEnum.FreeText')
  - [Hidden](#F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-Hidden 'AthenaHealth.Sdk.Models.Enums.InputTypeEnum.Hidden')
  - [Numeric](#F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-Numeric 'AthenaHealth.Sdk.Models.Enums.InputTypeEnum.Numeric')
  - [YesNo](#F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-YesNo 'AthenaHealth.Sdk.Models.Enums.InputTypeEnum.YesNo')
- [Insurance](#T-AthenaHealth-Sdk-Models-Response-Insurance 'AthenaHealth.Sdk.Models.Response.Insurance')
  - [AdjusterFax](#P-AthenaHealth-Sdk-Models-Response-Insurance-AdjusterFax 'AthenaHealth.Sdk.Models.Response.Insurance.AdjusterFax')
  - [AdjusterFirstName](#P-AthenaHealth-Sdk-Models-Response-Insurance-AdjusterFirstName 'AthenaHealth.Sdk.Models.Response.Insurance.AdjusterFirstName')
  - [AdjusterLastName](#P-AthenaHealth-Sdk-Models-Response-Insurance-AdjusterLastName 'AthenaHealth.Sdk.Models.Response.Insurance.AdjusterLastName')
  - [AdjusterPhone](#P-AthenaHealth-Sdk-Models-Response-Insurance-AdjusterPhone 'AthenaHealth.Sdk.Models.Response.Insurance.AdjusterPhone')
  - [AnotherPartyResponsible](#P-AthenaHealth-Sdk-Models-Response-Insurance-AnotherPartyResponsible 'AthenaHealth.Sdk.Models.Response.Insurance.AnotherPartyResponsible')
  - [AutoAccidentState](#P-AthenaHealth-Sdk-Models-Response-Insurance-AutoAccidentState 'AthenaHealth.Sdk.Models.Response.Insurance.AutoAccidentState')
  - [Cancelled](#P-AthenaHealth-Sdk-Models-Response-Insurance-Cancelled 'AthenaHealth.Sdk.Models.Response.Insurance.Cancelled')
  - [CaseInjuryDate](#P-AthenaHealth-Sdk-Models-Response-Insurance-CaseInjuryDate 'AthenaHealth.Sdk.Models.Response.Insurance.CaseInjuryDate')
  - [CasePolicyTypeName](#P-AthenaHealth-Sdk-Models-Response-Insurance-CasePolicyTypeName 'AthenaHealth.Sdk.Models.Response.Insurance.CasePolicyTypeName')
  - [CcmStatusId](#P-AthenaHealth-Sdk-Models-Response-Insurance-CcmStatusId 'AthenaHealth.Sdk.Models.Response.Insurance.CcmStatusId')
  - [CcmStatusName](#P-AthenaHealth-Sdk-Models-Response-Insurance-CcmStatusName 'AthenaHealth.Sdk.Models.Response.Insurance.CcmStatusName')
  - [CoinsurancePercent](#P-AthenaHealth-Sdk-Models-Response-Insurance-CoinsurancePercent 'AthenaHealth.Sdk.Models.Response.Insurance.CoinsurancePercent')
  - [Copays](#P-AthenaHealth-Sdk-Models-Response-Insurance-Copays 'AthenaHealth.Sdk.Models.Response.Insurance.Copays')
  - [DescriptionOfInjury](#P-AthenaHealth-Sdk-Models-Response-Insurance-DescriptionOfInjury 'AthenaHealth.Sdk.Models.Response.Insurance.DescriptionOfInjury')
  - [EligibilityLastChecked](#P-AthenaHealth-Sdk-Models-Response-Insurance-EligibilityLastChecked 'AthenaHealth.Sdk.Models.Response.Insurance.EligibilityLastChecked')
  - [EligibilityMessage](#P-AthenaHealth-Sdk-Models-Response-Insurance-EligibilityMessage 'AthenaHealth.Sdk.Models.Response.Insurance.EligibilityMessage')
  - [EligibilityReason](#P-AthenaHealth-Sdk-Models-Response-Insurance-EligibilityReason 'AthenaHealth.Sdk.Models.Response.Insurance.EligibilityReason')
  - [EligibilityStatus](#P-AthenaHealth-Sdk-Models-Response-Insurance-EligibilityStatus 'AthenaHealth.Sdk.Models.Response.Insurance.EligibilityStatus')
  - [EmployerId](#P-AthenaHealth-Sdk-Models-Response-Insurance-EmployerId 'AthenaHealth.Sdk.Models.Response.Insurance.EmployerId')
  - [ExpirationDate](#P-AthenaHealth-Sdk-Models-Response-Insurance-ExpirationDate 'AthenaHealth.Sdk.Models.Response.Insurance.ExpirationDate')
  - [ICD10Codes](#P-AthenaHealth-Sdk-Models-Response-Insurance-ICD10Codes 'AthenaHealth.Sdk.Models.Response.Insurance.ICD10Codes')
  - [ICD9Codes](#P-AthenaHealth-Sdk-Models-Response-Insurance-ICD9Codes 'AthenaHealth.Sdk.Models.Response.Insurance.ICD9Codes')
  - [InjuredBodyPart](#P-AthenaHealth-Sdk-Models-Response-Insurance-InjuredBodyPart 'AthenaHealth.Sdk.Models.Response.Insurance.InjuredBodyPart')
  - [InsuranceClaimNumber](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsuranceClaimNumber 'AthenaHealth.Sdk.Models.Response.Insurance.InsuranceClaimNumber')
  - [InsuranceCompanyName](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsuranceCompanyName 'AthenaHealth.Sdk.Models.Response.Insurance.InsuranceCompanyName')
  - [InsuranceId](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsuranceId 'AthenaHealth.Sdk.Models.Response.Insurance.InsuranceId')
  - [InsuranceIdNumber](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsuranceIdNumber 'AthenaHealth.Sdk.Models.Response.Insurance.InsuranceIdNumber')
  - [InsurancePackageAddress1](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePackageAddress1 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePackageAddress1')
  - [InsurancePackageAddress2](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePackageAddress2 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePackageAddress2')
  - [InsurancePackageCity](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePackageCity 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePackageCity')
  - [InsurancePackageId](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePackageId 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePackageId')
  - [InsurancePackageState](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePackageState 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePackageState')
  - [InsurancePackageZip](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePackageZip 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePackageZip')
  - [InsurancePhone](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePhone 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePhone')
  - [InsurancePlanDisplayName](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePlanDisplayName 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePlanDisplayName')
  - [InsurancePlanName](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePlanName 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePlanName')
  - [InsurancePolicyHolder](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolder 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePolicyHolder')
  - [InsurancePolicyHolderAddress1](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderAddress1 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePolicyHolderAddress1')
  - [InsurancePolicyHolderAddress2](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderAddress2 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePolicyHolderAddress2')
  - [InsurancePolicyHolderCity](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderCity 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePolicyHolderCity')
  - [InsurancePolicyHolderCountryCode](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderCountryCode 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePolicyHolderCountryCode')
  - [InsurancePolicyHolderCountryISO3166](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderCountryISO3166 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePolicyHolderCountryISO3166')
  - [InsurancePolicyHolderDateOfBirth](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderDateOfBirth 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePolicyHolderDateOfBirth')
  - [InsurancePolicyHolderFirstName](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderFirstName 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePolicyHolderFirstName')
  - [InsurancePolicyHolderLastName](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderLastName 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePolicyHolderLastName')
  - [InsurancePolicyHolderMiddleName](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderMiddleName 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePolicyHolderMiddleName')
  - [InsurancePolicyHolderSSN](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderSSN 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePolicyHolderSSN')
  - [InsurancePolicyHolderSex](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderSex 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePolicyHolderSex')
  - [InsurancePolicyHolderState](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderState 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePolicyHolderState')
  - [InsurancePolicyHolderSuffix](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderSuffix 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePolicyHolderSuffix')
  - [InsurancePolicyHolderZip](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderZip 'AthenaHealth.Sdk.Models.Response.Insurance.InsurancePolicyHolderZip')
  - [InsuranceType](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsuranceType 'AthenaHealth.Sdk.Models.Response.Insurance.InsuranceType')
  - [InsuredEntityTypeId](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsuredEntityTypeId 'AthenaHealth.Sdk.Models.Response.Insurance.InsuredEntityTypeId')
  - [InsuredPrimaryCarePhysicianNationalProviderId](#P-AthenaHealth-Sdk-Models-Response-Insurance-InsuredPrimaryCarePhysicianNationalProviderId 'AthenaHealth.Sdk.Models.Response.Insurance.InsuredPrimaryCarePhysicianNationalProviderId')
  - [IssueDate](#P-AthenaHealth-Sdk-Models-Response-Insurance-IssueDate 'AthenaHealth.Sdk.Models.Response.Insurance.IssueDate')
  - [PolicyNumber](#P-AthenaHealth-Sdk-Models-Response-Insurance-PolicyNumber 'AthenaHealth.Sdk.Models.Response.Insurance.PolicyNumber')
  - [RelatedToAutoAccident](#P-AthenaHealth-Sdk-Models-Response-Insurance-RelatedToAutoAccident 'AthenaHealth.Sdk.Models.Response.Insurance.RelatedToAutoAccident')
  - [RelatedToEmployment](#P-AthenaHealth-Sdk-Models-Response-Insurance-RelatedToEmployment 'AthenaHealth.Sdk.Models.Response.Insurance.RelatedToEmployment')
  - [RelatedToOtherAccident](#P-AthenaHealth-Sdk-Models-Response-Insurance-RelatedToOtherAccident 'AthenaHealth.Sdk.Models.Response.Insurance.RelatedToOtherAccident')
  - [RelationshipToInsured](#P-AthenaHealth-Sdk-Models-Response-Insurance-RelationshipToInsured 'AthenaHealth.Sdk.Models.Response.Insurance.RelationshipToInsured')
  - [RelationshipToInsuredId](#P-AthenaHealth-Sdk-Models-Response-Insurance-RelationshipToInsuredId 'AthenaHealth.Sdk.Models.Response.Insurance.RelationshipToInsuredId')
  - [RepricerName](#P-AthenaHealth-Sdk-Models-Response-Insurance-RepricerName 'AthenaHealth.Sdk.Models.Response.Insurance.RepricerName')
  - [RepricerPhone](#P-AthenaHealth-Sdk-Models-Response-Insurance-RepricerPhone 'AthenaHealth.Sdk.Models.Response.Insurance.RepricerPhone')
  - [SequenceNumber](#P-AthenaHealth-Sdk-Models-Response-Insurance-SequenceNumber 'AthenaHealth.Sdk.Models.Response.Insurance.SequenceNumber')
  - [SlidingFeePlanId](#P-AthenaHealth-Sdk-Models-Response-Insurance-SlidingFeePlanId 'AthenaHealth.Sdk.Models.Response.Insurance.SlidingFeePlanId')
  - [StateOfReportedInjury](#P-AthenaHealth-Sdk-Models-Response-Insurance-StateOfReportedInjury 'AthenaHealth.Sdk.Models.Response.Insurance.StateOfReportedInjury')
- [InsurancePackage](#T-AthenaHealth-Sdk-Models-Response-InsurancePackage 'AthenaHealth.Sdk.Models.Response.InsurancePackage')
  - [Address](#P-AthenaHealth-Sdk-Models-Response-InsurancePackage-Address 'AthenaHealth.Sdk.Models.Response.InsurancePackage.Address')
  - [Address2](#P-AthenaHealth-Sdk-Models-Response-InsurancePackage-Address2 'AthenaHealth.Sdk.Models.Response.InsurancePackage.Address2')
  - [City](#P-AthenaHealth-Sdk-Models-Response-InsurancePackage-City 'AthenaHealth.Sdk.Models.Response.InsurancePackage.City')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-InsurancePackage-Name 'AthenaHealth.Sdk.Models.Response.InsurancePackage.Name')
  - [Phone](#P-AthenaHealth-Sdk-Models-Response-InsurancePackage-Phone 'AthenaHealth.Sdk.Models.Response.InsurancePackage.Phone')
  - [State](#P-AthenaHealth-Sdk-Models-Response-InsurancePackage-State 'AthenaHealth.Sdk.Models.Response.InsurancePackage.State')
  - [Zip](#P-AthenaHealth-Sdk-Models-Response-InsurancePackage-Zip 'AthenaHealth.Sdk.Models.Response.InsurancePackage.Zip')
- [InsurancePackageClient](#T-AthenaHealth-Sdk-Clients-InsurancePackageClient 'AthenaHealth.Sdk.Clients.InsurancePackageClient')
  - [GetCommon(filter)](#M-AthenaHealth-Sdk-Clients-InsurancePackageClient-GetCommon-AthenaHealth-Sdk-Models-Request-GetCommonInsurancePackageFilter- 'AthenaHealth.Sdk.Clients.InsurancePackageClient.GetCommon(AthenaHealth.Sdk.Models.Request.GetCommonInsurancePackageFilter)')
  - [GetTop(filter)](#M-AthenaHealth-Sdk-Clients-InsurancePackageClient-GetTop-AthenaHealth-Sdk-Models-Request-GetTopInsurancePackageFilter- 'AthenaHealth.Sdk.Clients.InsurancePackageClient.GetTop(AthenaHealth.Sdk.Models.Request.GetTopInsurancePackageFilter)')
  - [Search(filter)](#M-AthenaHealth-Sdk-Clients-InsurancePackageClient-Search-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter- 'AthenaHealth.Sdk.Clients.InsurancePackageClient.Search(AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter)')
- [InsurancePackageExtended](#T-AthenaHealth-Sdk-Models-Response-InsurancePackageExtended 'AthenaHealth.Sdk.Models.Response.InsurancePackageExtended')
  - [AddressList](#P-AthenaHealth-Sdk-Models-Response-InsurancePackageExtended-AddressList 'AthenaHealth.Sdk.Models.Response.InsurancePackageExtended.AddressList')
  - [Affiliations](#P-AthenaHealth-Sdk-Models-Response-InsurancePackageExtended-Affiliations 'AthenaHealth.Sdk.Models.Response.InsurancePackageExtended.Affiliations')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-InsurancePackageExtended-Id 'AthenaHealth.Sdk.Models.Response.InsurancePackageExtended.Id')
  - [InsurancePlanName](#P-AthenaHealth-Sdk-Models-Response-InsurancePackageExtended-InsurancePlanName 'AthenaHealth.Sdk.Models.Response.InsurancePackageExtended.InsurancePlanName')
- [InsuredSignature](#T-AthenaHealth-Sdk-Models-Response-InsuredSignature 'AthenaHealth.Sdk.Models.Response.InsuredSignature')
  - [EffectiveDate](#P-AthenaHealth-Sdk-Models-Response-InsuredSignature-EffectiveDate 'AthenaHealth.Sdk.Models.Response.InsuredSignature.EffectiveDate')
  - [ExpirationDate](#P-AthenaHealth-Sdk-Models-Response-InsuredSignature-ExpirationDate 'AthenaHealth.Sdk.Models.Response.InsuredSignature.ExpirationDate')
  - [IsOnFile](#P-AthenaHealth-Sdk-Models-Response-InsuredSignature-IsOnFile 'AthenaHealth.Sdk.Models.Response.InsuredSignature.IsOnFile')
- [LabResult](#T-AthenaHealth-Sdk-Models-Response-LabResult 'AthenaHealth.Sdk.Models.Response.LabResult')
  - [Analytes](#P-AthenaHealth-Sdk-Models-Response-LabResult-Analytes 'AthenaHealth.Sdk.Models.Response.LabResult.Analytes')
  - [AttachmentExists](#P-AthenaHealth-Sdk-Models-Response-LabResult-AttachmentExists 'AthenaHealth.Sdk.Models.Response.LabResult.AttachmentExists')
  - [Description](#P-AthenaHealth-Sdk-Models-Response-LabResult-Description 'AthenaHealth.Sdk.Models.Response.LabResult.Description')
  - [ExactDuplicateDocumentId](#P-AthenaHealth-Sdk-Models-Response-LabResult-ExactDuplicateDocumentId 'AthenaHealth.Sdk.Models.Response.LabResult.ExactDuplicateDocumentId')
  - [FacilityId](#P-AthenaHealth-Sdk-Models-Response-LabResult-FacilityId 'AthenaHealth.Sdk.Models.Response.LabResult.FacilityId')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-LabResult-Id 'AthenaHealth.Sdk.Models.Response.LabResult.Id')
  - [InternalNote](#P-AthenaHealth-Sdk-Models-Response-LabResult-InternalNote 'AthenaHealth.Sdk.Models.Response.LabResult.InternalNote')
  - [InterpretationTemplate](#P-AthenaHealth-Sdk-Models-Response-LabResult-InterpretationTemplate 'AthenaHealth.Sdk.Models.Response.LabResult.InterpretationTemplate')
  - [LabResultDate](#P-AthenaHealth-Sdk-Models-Response-LabResult-LabResultDate 'AthenaHealth.Sdk.Models.Response.LabResult.LabResultDate')
  - [LabResultDateTime](#P-AthenaHealth-Sdk-Models-Response-LabResult-LabResultDateTime 'AthenaHealth.Sdk.Models.Response.LabResult.LabResultDateTime')
  - [LabResultLOINC](#P-AthenaHealth-Sdk-Models-Response-LabResult-LabResultLOINC 'AthenaHealth.Sdk.Models.Response.LabResult.LabResultLOINC')
  - [LabresultNote](#P-AthenaHealth-Sdk-Models-Response-LabResult-LabresultNote 'AthenaHealth.Sdk.Models.Response.LabResult.LabresultNote')
  - [OrderId](#P-AthenaHealth-Sdk-Models-Response-LabResult-OrderId 'AthenaHealth.Sdk.Models.Response.LabResult.OrderId')
  - [PatientNote](#P-AthenaHealth-Sdk-Models-Response-LabResult-PatientNote 'AthenaHealth.Sdk.Models.Response.LabResult.PatientNote')
  - [Priority](#P-AthenaHealth-Sdk-Models-Response-LabResult-Priority 'AthenaHealth.Sdk.Models.Response.LabResult.Priority')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Response-LabResult-ProviderId 'AthenaHealth.Sdk.Models.Response.LabResult.ProviderId')
  - [ResultStatus](#P-AthenaHealth-Sdk-Models-Response-LabResult-ResultStatus 'AthenaHealth.Sdk.Models.Response.LabResult.ResultStatus')
  - [SupersedEdDocumentId](#P-AthenaHealth-Sdk-Models-Response-LabResult-SupersedEdDocumentId 'AthenaHealth.Sdk.Models.Response.LabResult.SupersedEdDocumentId')
- [LabResultDetail](#T-AthenaHealth-Sdk-Models-Response-LabResultDetail 'AthenaHealth.Sdk.Models.Response.LabResultDetail')
  - [ActionNote](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ActionNote 'AthenaHealth.Sdk.Models.Response.LabResultDetail.ActionNote')
  - [AlarmDays](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-AlarmDays 'AthenaHealth.Sdk.Models.Response.LabResultDetail.AlarmDays')
  - [AppointmentId](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-AppointmentId 'AthenaHealth.Sdk.Models.Response.LabResultDetail.AppointmentId')
  - [AssignedTo](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-AssignedTo 'AthenaHealth.Sdk.Models.Response.LabResultDetail.AssignedTo')
  - [CreatedDate](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-CreatedDate 'AthenaHealth.Sdk.Models.Response.LabResultDetail.CreatedDate')
  - [CreatedDateTime](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-CreatedDateTime 'AthenaHealth.Sdk.Models.Response.LabResultDetail.CreatedDateTime')
  - [CreatedUser](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-CreatedUser 'AthenaHealth.Sdk.Models.Response.LabResultDetail.CreatedUser')
  - [DeletedDateTime](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-DeletedDateTime 'AthenaHealth.Sdk.Models.Response.LabResultDetail.DeletedDateTime')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-DepartmentId 'AthenaHealth.Sdk.Models.Response.LabResultDetail.DepartmentId')
  - [Description](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Description 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Description')
  - [DocumentClass](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-DocumentClass 'AthenaHealth.Sdk.Models.Response.LabResultDetail.DocumentClass')
  - [DocumentRoute](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-DocumentRoute 'AthenaHealth.Sdk.Models.Response.LabResultDetail.DocumentRoute')
  - [DocumentSource](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-DocumentSource 'AthenaHealth.Sdk.Models.Response.LabResultDetail.DocumentSource')
  - [DocumentSubclass](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-DocumentSubclass 'AthenaHealth.Sdk.Models.Response.LabResultDetail.DocumentSubclass')
  - [DocumentTypeId](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-DocumentTypeId 'AthenaHealth.Sdk.Models.Response.LabResultDetail.DocumentTypeId')
  - [EncounterDate](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-EncounterDate 'AthenaHealth.Sdk.Models.Response.LabResultDetail.EncounterDate')
  - [EncounterId](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-EncounterId 'AthenaHealth.Sdk.Models.Response.LabResultDetail.EncounterId')
  - [ExternalAccessionId](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ExternalAccessionId 'AthenaHealth.Sdk.Models.Response.LabResultDetail.ExternalAccessionId')
  - [ExternalNoteOnly](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ExternalNoteOnly 'AthenaHealth.Sdk.Models.Response.LabResultDetail.ExternalNoteOnly')
  - [FacilityId](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-FacilityId 'AthenaHealth.Sdk.Models.Response.LabResultDetail.FacilityId')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Id 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Id')
  - [InternalAccessionId](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-InternalAccessionId 'AthenaHealth.Sdk.Models.Response.LabResultDetail.InternalAccessionId')
  - [InternalNote](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-InternalNote 'AthenaHealth.Sdk.Models.Response.LabResultDetail.InternalNote')
  - [Interpretation](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Interpretation 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Interpretation')
  - [InterpretationTemplate](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-InterpretationTemplate 'AthenaHealth.Sdk.Models.Response.LabResultDetail.InterpretationTemplate')
  - [IsConfidential](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-IsConfidential 'AthenaHealth.Sdk.Models.Response.LabResultDetail.IsConfidential')
  - [LabresultLoinc](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-LabresultLoinc 'AthenaHealth.Sdk.Models.Response.LabResultDetail.LabresultLoinc')
  - [LastModifiedDate](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-LastModifiedDate 'AthenaHealth.Sdk.Models.Response.LabResultDetail.LastModifiedDate')
  - [LastModifiedDateTime](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-LastModifiedDateTime 'AthenaHealth.Sdk.Models.Response.LabResultDetail.LastModifiedDateTime')
  - [LastModifiedUser](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-LastModifiedUser 'AthenaHealth.Sdk.Models.Response.LabResultDetail.LastModifiedUser')
  - [NoteFromLab](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-NoteFromLab 'AthenaHealth.Sdk.Models.Response.LabResultDetail.NoteFromLab')
  - [ObservationDate](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ObservationDate 'AthenaHealth.Sdk.Models.Response.LabResultDetail.ObservationDate')
  - [ObservationDateTime](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ObservationDateTime 'AthenaHealth.Sdk.Models.Response.LabResultDetail.ObservationDateTime')
  - [Observations](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observations 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Observations')
  - [OrderType](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-OrderType 'AthenaHealth.Sdk.Models.Response.LabResultDetail.OrderType')
  - [Pages](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Pages 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Pages')
  - [PatientNote](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-PatientNote 'AthenaHealth.Sdk.Models.Response.LabResultDetail.PatientNote')
  - [Priority](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Priority 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Priority')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ProviderId 'AthenaHealth.Sdk.Models.Response.LabResultDetail.ProviderId')
  - [ProviderUserName](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ProviderUserName 'AthenaHealth.Sdk.Models.Response.LabResultDetail.ProviderUserName')
  - [ReportStatus](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ReportStatus 'AthenaHealth.Sdk.Models.Response.LabResultDetail.ReportStatus')
  - [ResultNotes](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ResultNotes 'AthenaHealth.Sdk.Models.Response.LabResultDetail.ResultNotes')
  - [ResultStatus](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ResultStatus 'AthenaHealth.Sdk.Models.Response.LabResultDetail.ResultStatus')
  - [Status](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Status 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Status')
  - [Subject](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Subject 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Subject')
  - [TieToOrderId](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-TieToOrderId 'AthenaHealth.Sdk.Models.Response.LabResultDetail.TieToOrderId')
- [LabResultInterpretationTemplate](#T-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Name 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Name')
  - [Note](#P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Note 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Note')
  - [Paragraphs](#P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraphs 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraphs')
- [Laboratory](#T-AthenaHealth-Sdk-Models-Response-Laboratory 'AthenaHealth.Sdk.Models.Response.Laboratory')
  - [AcceptFax](#P-AthenaHealth-Sdk-Models-Response-Laboratory-AcceptFax 'AthenaHealth.Sdk.Models.Response.Laboratory.AcceptFax')
  - [Address1](#P-AthenaHealth-Sdk-Models-Response-Laboratory-Address1 'AthenaHealth.Sdk.Models.Response.Laboratory.Address1')
  - [Address2](#P-AthenaHealth-Sdk-Models-Response-Laboratory-Address2 'AthenaHealth.Sdk.Models.Response.Laboratory.Address2')
  - [City](#P-AthenaHealth-Sdk-Models-Response-Laboratory-City 'AthenaHealth.Sdk.Models.Response.Laboratory.City')
  - [ClinicalProviderId](#P-AthenaHealth-Sdk-Models-Response-Laboratory-ClinicalProviderId 'AthenaHealth.Sdk.Models.Response.Laboratory.ClinicalProviderId')
  - [ClinicalProviderName](#P-AthenaHealth-Sdk-Models-Response-Laboratory-ClinicalProviderName 'AthenaHealth.Sdk.Models.Response.Laboratory.ClinicalProviderName')
  - [FaxNumber](#P-AthenaHealth-Sdk-Models-Response-Laboratory-FaxNumber 'AthenaHealth.Sdk.Models.Response.Laboratory.FaxNumber')
  - [PhoneNumber](#P-AthenaHealth-Sdk-Models-Response-Laboratory-PhoneNumber 'AthenaHealth.Sdk.Models.Response.Laboratory.PhoneNumber')
  - [State](#P-AthenaHealth-Sdk-Models-Response-Laboratory-State 'AthenaHealth.Sdk.Models.Response.Laboratory.State')
  - [Zip](#P-AthenaHealth-Sdk-Models-Response-Laboratory-Zip 'AthenaHealth.Sdk.Models.Response.Laboratory.Zip')
- [MedicalHistory](#T-AthenaHealth-Sdk-Models-Response-MedicalHistory 'AthenaHealth.Sdk.Models.Response.MedicalHistory')
  - [Questions](#P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Questions 'AthenaHealth.Sdk.Models.Response.MedicalHistory.Questions')
  - [SectionNote](#P-AthenaHealth-Sdk-Models-Response-MedicalHistory-SectionNote 'AthenaHealth.Sdk.Models.Response.MedicalHistory.SectionNote')
- [MedicalHistoryQuestion](#T-AthenaHealth-Sdk-Models-Response-MedicalHistoryQuestion 'AthenaHealth.Sdk.Models.Response.MedicalHistoryQuestion')
  - [Deleted](#P-AthenaHealth-Sdk-Models-Response-MedicalHistoryQuestion-Deleted 'AthenaHealth.Sdk.Models.Response.MedicalHistoryQuestion.Deleted')
  - [DiagnosisCode](#P-AthenaHealth-Sdk-Models-Response-MedicalHistoryQuestion-DiagnosisCode 'AthenaHealth.Sdk.Models.Response.MedicalHistoryQuestion.DiagnosisCode')
  - [Ordering](#P-AthenaHealth-Sdk-Models-Response-MedicalHistoryQuestion-Ordering 'AthenaHealth.Sdk.Models.Response.MedicalHistoryQuestion.Ordering')
  - [Question](#P-AthenaHealth-Sdk-Models-Response-MedicalHistoryQuestion-Question 'AthenaHealth.Sdk.Models.Response.MedicalHistoryQuestion.Question')
  - [QuestionId](#P-AthenaHealth-Sdk-Models-Response-MedicalHistoryQuestion-QuestionId 'AthenaHealth.Sdk.Models.Response.MedicalHistoryQuestion.QuestionId')
- [Medication](#T-AthenaHealth-Sdk-Models-Response-Medication 'AthenaHealth.Sdk.Models.Response.Medication')
- [Medication](#T-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-Medication-Id 'AthenaHealth.Sdk.Models.Response.Medication.Id')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-Medication-Name 'AthenaHealth.Sdk.Models.Response.Medication.Name')
  - [ApprovedBy](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-ApprovedBy 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.ApprovedBy')
  - [BillingNDC](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-BillingNDC 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.BillingNDC')
  - [CreatedBy](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-CreatedBy 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.CreatedBy')
  - [EncounterId](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-EncounterId 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.EncounterId')
  - [Events](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Events 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.Events')
  - [FutureSubmitDate](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-FutureSubmitDate 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.FutureSubmitDate')
  - [IsSafeToRenew](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-IsSafeToRenew 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.IsSafeToRenew')
  - [IsStructuredSig](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-IsStructuredSig 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.IsStructuredSig')
  - [MedicationEntryId](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-MedicationEntryId 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.MedicationEntryId')
  - [MedicationId](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-MedicationId 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.MedicationId')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Name 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.Name')
  - [NdcOptions](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-NdcOptions 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.NdcOptions')
  - [OrderingMode](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-OrderingMode 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.OrderingMode')
  - [OrganClass](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-OrganClass 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.OrganClass')
  - [PatientNote](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-PatientNote 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.PatientNote')
  - [Pharmacy](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Pharmacy 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.Pharmacy')
  - [PharmacyNcpdpId](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-PharmacyNcpdpId 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.PharmacyNcpdpId')
  - [PrescribedBy](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-PrescribedBy 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.PrescribedBy')
  - [ProviderNote](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-ProviderNote 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.ProviderNote')
  - [Quantity](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Quantity 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.Quantity')
  - [QuantityUnit](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-QuantityUnit 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.QuantityUnit')
  - [RefillsAllowed](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-RefillsAllowed 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.RefillsAllowed')
  - [Route](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Route 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.Route')
  - [RxNorm](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-RxNorm 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.RxNorm')
  - [Source](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Source 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.Source')
  - [Status](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Status 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.Status')
  - [StopReason](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StopReason 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.StopReason')
  - [StructuredSig](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSig 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.StructuredSig')
  - [TherapeuticClass](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-TherapeuticClass 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.TherapeuticClass')
  - [UnstructuredSig](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-UnstructuredSig 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.UnstructuredSig')
- [MedicationAddedResponse](#T-AthenaHealth-Sdk-Models-Response-MedicationAddedResponse 'AthenaHealth.Sdk.Models.Response.MedicationAddedResponse')
  - [MedicationEntryId](#P-AthenaHealth-Sdk-Models-Response-MedicationAddedResponse-MedicationEntryId 'AthenaHealth.Sdk.Models.Response.MedicationAddedResponse.MedicationEntryId')
- [MedicationSetting](#T-AthenaHealth-Sdk-Models-Request-MedicationSetting 'AthenaHealth.Sdk.Models.Request.MedicationSetting')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-MedicationSetting-DepartmentId 'AthenaHealth.Sdk.Models.Request.MedicationSetting.DepartmentId')
  - [NoMedicationReported](#P-AthenaHealth-Sdk-Models-Request-MedicationSetting-NoMedicationReported 'AthenaHealth.Sdk.Models.Request.MedicationSetting.NoMedicationReported')
  - [SectionNote](#P-AthenaHealth-Sdk-Models-Request-MedicationSetting-SectionNote 'AthenaHealth.Sdk.Models.Request.MedicationSetting.SectionNote')
- [ObjectToStringOrDelimitedStringConverter](#T-AthenaHealth-Sdk-Models-Converters-ObjectToStringOrDelimitedStringConverter 'AthenaHealth.Sdk.Models.Converters.ObjectToStringOrDelimitedStringConverter')
  - [Convert(value,delimiter,encloseArrayInSquareBrackets)](#M-AthenaHealth-Sdk-Models-Converters-ObjectToStringOrDelimitedStringConverter-Convert-System-Object,System-String,System-Boolean- 'AthenaHealth.Sdk.Models.Converters.ObjectToStringOrDelimitedStringConverter.Convert(System.Object,System.String,System.Boolean)')
- [Observation](#T-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Observation')
  - [AbnormalFlag](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-AbnormalFlag 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Observation.AbnormalFlag')
  - [AnalyteId](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-AnalyteId 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Observation.AnalyteId')
  - [AnalyteName](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-AnalyteName 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Observation.AnalyteName')
  - [Loinc](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-Loinc 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Observation.Loinc')
  - [Note](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-Note 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Observation.Note')
  - [ReferenceRange](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-ReferenceRange 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Observation.ReferenceRange')
  - [ResultStatus](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-ResultStatus 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Observation.ResultStatus')
  - [Units](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-Units 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Observation.Units')
  - [Value](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-Value 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Observation.Value')
- [Order](#T-AthenaHealth-Sdk-Models-Response-Order 'AthenaHealth.Sdk.Models.Response.Order')
  - [AssignedUser](#P-AthenaHealth-Sdk-Models-Response-Order-AssignedUser 'AthenaHealth.Sdk.Models.Response.Order.AssignedUser')
  - [Class](#P-AthenaHealth-Sdk-Models-Response-Order-Class 'AthenaHealth.Sdk.Models.Response.Order.Class')
  - [ClassDescription](#P-AthenaHealth-Sdk-Models-Response-Order-ClassDescription 'AthenaHealth.Sdk.Models.Response.Order.ClassDescription')
  - [ClinicalProvider](#P-AthenaHealth-Sdk-Models-Response-Order-ClinicalProvider 'AthenaHealth.Sdk.Models.Response.Order.ClinicalProvider')
  - [ClinicalProviderId](#P-AthenaHealth-Sdk-Models-Response-Order-ClinicalProviderId 'AthenaHealth.Sdk.Models.Response.Order.ClinicalProviderId')
  - [ClinicalProviderName](#P-AthenaHealth-Sdk-Models-Response-Order-ClinicalProviderName 'AthenaHealth.Sdk.Models.Response.Order.ClinicalProviderName')
  - [ContraIndicationReason](#P-AthenaHealth-Sdk-Models-Response-Order-ContraIndicationReason 'AthenaHealth.Sdk.Models.Response.Order.ContraIndicationReason')
  - [CreatedUser](#P-AthenaHealth-Sdk-Models-Response-Order-CreatedUser 'AthenaHealth.Sdk.Models.Response.Order.CreatedUser')
  - [DateOrdered](#P-AthenaHealth-Sdk-Models-Response-Order-DateOrdered 'AthenaHealth.Sdk.Models.Response.Order.DateOrdered')
  - [DeclinedReason](#P-AthenaHealth-Sdk-Models-Response-Order-DeclinedReason 'AthenaHealth.Sdk.Models.Response.Order.DeclinedReason')
  - [DeclinedReasonText](#P-AthenaHealth-Sdk-Models-Response-Order-DeclinedReasonText 'AthenaHealth.Sdk.Models.Response.Order.DeclinedReasonText')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Response-Order-DepartmentId 'AthenaHealth.Sdk.Models.Response.Order.DepartmentId')
  - [Description](#P-AthenaHealth-Sdk-Models-Response-Order-Description 'AthenaHealth.Sdk.Models.Response.Order.Description')
  - [DiagnosisList](#P-AthenaHealth-Sdk-Models-Response-Order-DiagnosisList 'AthenaHealth.Sdk.Models.Response.Order.DiagnosisList')
  - [DocumentationOnly](#P-AthenaHealth-Sdk-Models-Response-Order-DocumentationOnly 'AthenaHealth.Sdk.Models.Response.Order.DocumentationOnly')
  - [ExternalCodes](#P-AthenaHealth-Sdk-Models-Response-Order-ExternalCodes 'AthenaHealth.Sdk.Models.Response.Order.ExternalCodes')
  - [FutureSubmitDate](#P-AthenaHealth-Sdk-Models-Response-Order-FutureSubmitDate 'AthenaHealth.Sdk.Models.Response.Order.FutureSubmitDate')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-Order-Id 'AthenaHealth.Sdk.Models.Response.Order.Id')
  - [LastModifiedBy](#P-AthenaHealth-Sdk-Models-Response-Order-LastModifiedBy 'AthenaHealth.Sdk.Models.Response.Order.LastModifiedBy')
  - [LastModifiedDateTime](#P-AthenaHealth-Sdk-Models-Response-Order-LastModifiedDateTime 'AthenaHealth.Sdk.Models.Response.Order.LastModifiedDateTime')
  - [Ndc](#P-AthenaHealth-Sdk-Models-Response-Order-Ndc 'AthenaHealth.Sdk.Models.Response.Order.Ndc')
  - [OrderType](#P-AthenaHealth-Sdk-Models-Response-Order-OrderType 'AthenaHealth.Sdk.Models.Response.Order.OrderType')
  - [OrderTypeId](#P-AthenaHealth-Sdk-Models-Response-Order-OrderTypeId 'AthenaHealth.Sdk.Models.Response.Order.OrderTypeId')
  - [OrderingProvider](#P-AthenaHealth-Sdk-Models-Response-Order-OrderingProvider 'AthenaHealth.Sdk.Models.Response.Order.OrderingProvider')
  - [Priority](#P-AthenaHealth-Sdk-Models-Response-Order-Priority 'AthenaHealth.Sdk.Models.Response.Order.Priority')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Response-Order-ProviderId 'AthenaHealth.Sdk.Models.Response.Order.ProviderId')
  - [QuantityValue](#P-AthenaHealth-Sdk-Models-Response-Order-QuantityValue 'AthenaHealth.Sdk.Models.Response.Order.QuantityValue')
  - [Refills](#P-AthenaHealth-Sdk-Models-Response-Order-Refills 'AthenaHealth.Sdk.Models.Response.Order.Refills')
  - [SpecimenCollectionSite](#P-AthenaHealth-Sdk-Models-Response-Order-SpecimenCollectionSite 'AthenaHealth.Sdk.Models.Response.Order.SpecimenCollectionSite')
  - [Status](#P-AthenaHealth-Sdk-Models-Response-Order-Status 'AthenaHealth.Sdk.Models.Response.Order.Status')
- [OrderLab](#T-AthenaHealth-Sdk-Models-Response-OrderLab 'AthenaHealth.Sdk.Models.Response.OrderLab')
  - [DocumentId](#P-AthenaHealth-Sdk-Models-Response-OrderLab-DocumentId 'AthenaHealth.Sdk.Models.Response.OrderLab.DocumentId')
- [OrderRelatedDiagnosis](#T-AthenaHealth-Sdk-Models-Response-OrderRelatedDiagnosis 'AthenaHealth.Sdk.Models.Response.OrderRelatedDiagnosis')
  - [SnomedIcdCodes](#P-AthenaHealth-Sdk-Models-Response-OrderRelatedDiagnosis-SnomedIcdCodes 'AthenaHealth.Sdk.Models.Response.OrderRelatedDiagnosis.SnomedIcdCodes')
- [OrderType](#T-AthenaHealth-Sdk-Models-Response-OrderType 'AthenaHealth.Sdk.Models.Response.OrderType')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-OrderType-Id 'AthenaHealth.Sdk.Models.Response.OrderType.Id')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-OrderType-Name 'AthenaHealth.Sdk.Models.Response.OrderType.Name')
- [Page](#T-AthenaHealth-Sdk-Models-Response-LabResultDetail-Page 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Page')
  - [PageId](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Page-PageId 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Page.PageId')
  - [PageOrdering](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Page-PageOrdering 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Page.PageOrdering')
  - [Type](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Page-Type 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Page.Type')
  - [Url](#P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Page-Url 'AthenaHealth.Sdk.Models.Response.LabResultDetail.Page.Url')
- [Paragraph](#T-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraph')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Name 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraph.Name')
  - [Sentences](#P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentences 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraph.Sentences')
- [PatienSocialHistoryTemplate](#T-AthenaHealth-Sdk-Models-Response-PatienSocialHistoryTemplate 'AthenaHealth.Sdk.Models.Response.PatienSocialHistoryTemplate')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-PatienSocialHistoryTemplate-Id 'AthenaHealth.Sdk.Models.Response.PatienSocialHistoryTemplate.Id')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-PatienSocialHistoryTemplate-Name 'AthenaHealth.Sdk.Models.Response.PatienSocialHistoryTemplate.Name')
- [Patient](#T-AthenaHealth-Sdk-Models-Response-Patient 'AthenaHealth.Sdk.Models.Response.Patient')
  - [Address1](#P-AthenaHealth-Sdk-Models-Response-Patient-Address1 'AthenaHealth.Sdk.Models.Response.Patient.Address1')
  - [Address2](#P-AthenaHealth-Sdk-Models-Response-Patient-Address2 'AthenaHealth.Sdk.Models.Response.Patient.Address2')
  - [AgriculturalWorker](#P-AthenaHealth-Sdk-Models-Response-Patient-AgriculturalWorker 'AthenaHealth.Sdk.Models.Response.Patient.AgriculturalWorker')
  - [AgriculturalWorkerType](#P-AthenaHealth-Sdk-Models-Response-Patient-AgriculturalWorkerType 'AthenaHealth.Sdk.Models.Response.Patient.AgriculturalWorkerType')
  - [AllPatientStatuses](#P-AthenaHealth-Sdk-Models-Response-Patient-AllPatientStatuses 'AthenaHealth.Sdk.Models.Response.Patient.AllPatientStatuses')
  - [AltFirstName](#P-AthenaHealth-Sdk-Models-Response-Patient-AltFirstName 'AthenaHealth.Sdk.Models.Response.Patient.AltFirstName')
  - [AssignedSexAtBirth](#P-AthenaHealth-Sdk-Models-Response-Patient-AssignedSexAtBirth 'AthenaHealth.Sdk.Models.Response.Patient.AssignedSexAtBirth')
  - [Balances](#P-AthenaHealth-Sdk-Models-Response-Patient-Balances 'AthenaHealth.Sdk.Models.Response.Patient.Balances')
  - [CareSummaryDeliveryPreference](#P-AthenaHealth-Sdk-Models-Response-Patient-CareSummaryDeliveryPreference 'AthenaHealth.Sdk.Models.Response.Patient.CareSummaryDeliveryPreference')
  - [City](#P-AthenaHealth-Sdk-Models-Response-Patient-City 'AthenaHealth.Sdk.Models.Response.Patient.City')
  - [ClaimBalanceDetails](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetails 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetails')
  - [ConfidentialityCode](#P-AthenaHealth-Sdk-Models-Response-Patient-ConfidentialityCode 'AthenaHealth.Sdk.Models.Response.Patient.ConfidentialityCode')
  - [ConsentToCall](#P-AthenaHealth-Sdk-Models-Response-Patient-ConsentToCall 'AthenaHealth.Sdk.Models.Response.Patient.ConsentToCall')
  - [ConsentToText](#P-AthenaHealth-Sdk-Models-Response-Patient-ConsentToText 'AthenaHealth.Sdk.Models.Response.Patient.ConsentToText')
  - [ContactHomePhone](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactHomePhone 'AthenaHealth.Sdk.Models.Response.Patient.ContactHomePhone')
  - [ContactMobilePhone](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactMobilePhone 'AthenaHealth.Sdk.Models.Response.Patient.ContactMobilePhone')
  - [ContactName](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactName 'AthenaHealth.Sdk.Models.Response.Patient.ContactName')
  - [ContactPreference](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreference 'AthenaHealth.Sdk.Models.Response.Patient.ContactPreference')
  - [ContactPreferenceAnnouncementEmail](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceAnnouncementEmail 'AthenaHealth.Sdk.Models.Response.Patient.ContactPreferenceAnnouncementEmail')
  - [ContactPreferenceAnnouncementPhone](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceAnnouncementPhone 'AthenaHealth.Sdk.Models.Response.Patient.ContactPreferenceAnnouncementPhone')
  - [ContactPreferenceAnnouncementSms](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceAnnouncementSms 'AthenaHealth.Sdk.Models.Response.Patient.ContactPreferenceAnnouncementSms')
  - [ContactPreferenceAppointmentEmail](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceAppointmentEmail 'AthenaHealth.Sdk.Models.Response.Patient.ContactPreferenceAppointmentEmail')
  - [ContactPreferenceAppointmentPhone](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceAppointmentPhone 'AthenaHealth.Sdk.Models.Response.Patient.ContactPreferenceAppointmentPhone')
  - [ContactPreferenceAppointmentSms](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceAppointmentSms 'AthenaHealth.Sdk.Models.Response.Patient.ContactPreferenceAppointmentSms')
  - [ContactPreferenceBillingEmail](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceBillingEmail 'AthenaHealth.Sdk.Models.Response.Patient.ContactPreferenceBillingEmail')
  - [ContactPreferenceBillingPhone](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceBillingPhone 'AthenaHealth.Sdk.Models.Response.Patient.ContactPreferenceBillingPhone')
  - [ContactPreferenceBillingSms](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceBillingSms 'AthenaHealth.Sdk.Models.Response.Patient.ContactPreferenceBillingSms')
  - [ContactPreferenceLabEmail](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceLabEmail 'AthenaHealth.Sdk.Models.Response.Patient.ContactPreferenceLabEmail')
  - [ContactPreferenceLabPhone](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceLabPhone 'AthenaHealth.Sdk.Models.Response.Patient.ContactPreferenceLabPhone')
  - [ContactPreferenceLabSms](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceLabSms 'AthenaHealth.Sdk.Models.Response.Patient.ContactPreferenceLabSms')
  - [ContactRelationship](#P-AthenaHealth-Sdk-Models-Response-Patient-ContactRelationship 'AthenaHealth.Sdk.Models.Response.Patient.ContactRelationship')
  - [CountryCode](#P-AthenaHealth-Sdk-Models-Response-Patient-CountryCode 'AthenaHealth.Sdk.Models.Response.Patient.CountryCode')
  - [CountryCode3166](#P-AthenaHealth-Sdk-Models-Response-Patient-CountryCode3166 'AthenaHealth.Sdk.Models.Response.Patient.CountryCode3166')
  - [CustomFields](#P-AthenaHealth-Sdk-Models-Response-Patient-CustomFields 'AthenaHealth.Sdk.Models.Response.Patient.CustomFields')
  - [DateOfBirth](#P-AthenaHealth-Sdk-Models-Response-Patient-DateOfBirth 'AthenaHealth.Sdk.Models.Response.Patient.DateOfBirth')
  - [DeceasedDate](#P-AthenaHealth-Sdk-Models-Response-Patient-DeceasedDate 'AthenaHealth.Sdk.Models.Response.Patient.DeceasedDate')
  - [DefaultPharmacyNcpdId](#P-AthenaHealth-Sdk-Models-Response-Patient-DefaultPharmacyNcpdId 'AthenaHealth.Sdk.Models.Response.Patient.DefaultPharmacyNcpdId')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Response-Patient-DepartmentId 'AthenaHealth.Sdk.Models.Response.Patient.DepartmentId')
  - [DoNotCall](#P-AthenaHealth-Sdk-Models-Response-Patient-DoNotCall 'AthenaHealth.Sdk.Models.Response.Patient.DoNotCall')
  - [DriversLicense](#P-AthenaHealth-Sdk-Models-Response-Patient-DriversLicense 'AthenaHealth.Sdk.Models.Response.Patient.DriversLicense')
  - [DriversLicenseExpirationDate](#P-AthenaHealth-Sdk-Models-Response-Patient-DriversLicenseExpirationDate 'AthenaHealth.Sdk.Models.Response.Patient.DriversLicenseExpirationDate')
  - [DriversLicenseNumber](#P-AthenaHealth-Sdk-Models-Response-Patient-DriversLicenseNumber 'AthenaHealth.Sdk.Models.Response.Patient.DriversLicenseNumber')
  - [DriversLicenseStateId](#P-AthenaHealth-Sdk-Models-Response-Patient-DriversLicenseStateId 'AthenaHealth.Sdk.Models.Response.Patient.DriversLicenseStateId')
  - [DriversLicenseUrl](#P-AthenaHealth-Sdk-Models-Response-Patient-DriversLicenseUrl 'AthenaHealth.Sdk.Models.Response.Patient.DriversLicenseUrl')
  - [Email](#P-AthenaHealth-Sdk-Models-Response-Patient-Email 'AthenaHealth.Sdk.Models.Response.Patient.Email')
  - [EmailExists](#P-AthenaHealth-Sdk-Models-Response-Patient-EmailExists 'AthenaHealth.Sdk.Models.Response.Patient.EmailExists')
  - [EmployerAddress](#P-AthenaHealth-Sdk-Models-Response-Patient-EmployerAddress 'AthenaHealth.Sdk.Models.Response.Patient.EmployerAddress')
  - [EmployerCity](#P-AthenaHealth-Sdk-Models-Response-Patient-EmployerCity 'AthenaHealth.Sdk.Models.Response.Patient.EmployerCity')
  - [EmployerFax](#P-AthenaHealth-Sdk-Models-Response-Patient-EmployerFax 'AthenaHealth.Sdk.Models.Response.Patient.EmployerFax')
  - [EmployerId](#P-AthenaHealth-Sdk-Models-Response-Patient-EmployerId 'AthenaHealth.Sdk.Models.Response.Patient.EmployerId')
  - [EmployerName](#P-AthenaHealth-Sdk-Models-Response-Patient-EmployerName 'AthenaHealth.Sdk.Models.Response.Patient.EmployerName')
  - [EmployerPhone](#P-AthenaHealth-Sdk-Models-Response-Patient-EmployerPhone 'AthenaHealth.Sdk.Models.Response.Patient.EmployerPhone')
  - [EmployerState](#P-AthenaHealth-Sdk-Models-Response-Patient-EmployerState 'AthenaHealth.Sdk.Models.Response.Patient.EmployerState')
  - [EmployerZip](#P-AthenaHealth-Sdk-Models-Response-Patient-EmployerZip 'AthenaHealth.Sdk.Models.Response.Patient.EmployerZip')
  - [EthnicityCode](#P-AthenaHealth-Sdk-Models-Response-Patient-EthnicityCode 'AthenaHealth.Sdk.Models.Response.Patient.EthnicityCode')
  - [FirstAppointment](#P-AthenaHealth-Sdk-Models-Response-Patient-FirstAppointment 'AthenaHealth.Sdk.Models.Response.Patient.FirstAppointment')
  - [FirstName](#P-AthenaHealth-Sdk-Models-Response-Patient-FirstName 'AthenaHealth.Sdk.Models.Response.Patient.FirstName')
  - [GenderIdentity](#P-AthenaHealth-Sdk-Models-Response-Patient-GenderIdentity 'AthenaHealth.Sdk.Models.Response.Patient.GenderIdentity')
  - [GenderIdentityOther](#P-AthenaHealth-Sdk-Models-Response-Patient-GenderIdentityOther 'AthenaHealth.Sdk.Models.Response.Patient.GenderIdentityOther')
  - [GuarantorAddress1](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorAddress1 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorAddress1')
  - [GuarantorAddress2](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorAddress2 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorAddress2')
  - [GuarantorAddressSameAsPatient](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorAddressSameAsPatient 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorAddressSameAsPatient')
  - [GuarantorCity](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorCity 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorCity')
  - [GuarantorCountryCode](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorCountryCode 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorCountryCode')
  - [GuarantorCountryCode3166](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorCountryCode3166 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorCountryCode3166')
  - [GuarantorDateOfBirth](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorDateOfBirth 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorDateOfBirth')
  - [GuarantorEmail](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorEmail 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorEmail')
  - [GuarantorEmployerId](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorEmployerId 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorEmployerId')
  - [GuarantorFirstName](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorFirstName 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorFirstName')
  - [GuarantorLastName](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorLastName 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorLastName')
  - [GuarantorMiddleName](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorMiddleName 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorMiddleName')
  - [GuarantorPhone](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorPhone 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorPhone')
  - [GuarantorRelationshipToPatient](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorRelationshipToPatient 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorRelationshipToPatient')
  - [GuarantorSSN](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorSSN 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorSSN')
  - [GuarantorState](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorState 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorState')
  - [GuarantorSuffix](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorSuffix 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorSuffix')
  - [GuarantorZip](#P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorZip 'AthenaHealth.Sdk.Models.Response.Patient.GuarantorZip')
  - [GuardianFirstName](#P-AthenaHealth-Sdk-Models-Response-Patient-GuardianFirstName 'AthenaHealth.Sdk.Models.Response.Patient.GuardianFirstName')
  - [GuardianLastName](#P-AthenaHealth-Sdk-Models-Response-Patient-GuardianLastName 'AthenaHealth.Sdk.Models.Response.Patient.GuardianLastName')
  - [GuardianMiddleName](#P-AthenaHealth-Sdk-Models-Response-Patient-GuardianMiddleName 'AthenaHealth.Sdk.Models.Response.Patient.GuardianMiddleName')
  - [GuardianSuffix](#P-AthenaHealth-Sdk-Models-Response-Patient-GuardianSuffix 'AthenaHealth.Sdk.Models.Response.Patient.GuardianSuffix')
  - [HasMobile](#P-AthenaHealth-Sdk-Models-Response-Patient-HasMobile 'AthenaHealth.Sdk.Models.Response.Patient.HasMobile')
  - [HierarchicalCode](#P-AthenaHealth-Sdk-Models-Response-Patient-HierarchicalCode 'AthenaHealth.Sdk.Models.Response.Patient.HierarchicalCode')
  - [HomePhone](#P-AthenaHealth-Sdk-Models-Response-Patient-HomePhone 'AthenaHealth.Sdk.Models.Response.Patient.HomePhone')
  - [Homebound](#P-AthenaHealth-Sdk-Models-Response-Patient-Homebound 'AthenaHealth.Sdk.Models.Response.Patient.Homebound')
  - [Homeless](#P-AthenaHealth-Sdk-Models-Response-Patient-Homeless 'AthenaHealth.Sdk.Models.Response.Patient.Homeless')
  - [HomelessType](#P-AthenaHealth-Sdk-Models-Response-Patient-HomelessType 'AthenaHealth.Sdk.Models.Response.Patient.HomelessType')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-Patient-Id 'AthenaHealth.Sdk.Models.Response.Patient.Id')
  - [IndustryCode](#P-AthenaHealth-Sdk-Models-Response-Patient-IndustryCode 'AthenaHealth.Sdk.Models.Response.Patient.IndustryCode')
  - [Insurances](#P-AthenaHealth-Sdk-Models-Response-Patient-Insurances 'AthenaHealth.Sdk.Models.Response.Patient.Insurances')
  - [Language6392Code](#P-AthenaHealth-Sdk-Models-Response-Patient-Language6392Code 'AthenaHealth.Sdk.Models.Response.Patient.Language6392Code')
  - [LastAppointment](#P-AthenaHealth-Sdk-Models-Response-Patient-LastAppointment 'AthenaHealth.Sdk.Models.Response.Patient.LastAppointment')
  - [LastEmail](#P-AthenaHealth-Sdk-Models-Response-Patient-LastEmail 'AthenaHealth.Sdk.Models.Response.Patient.LastEmail')
  - [LastName](#P-AthenaHealth-Sdk-Models-Response-Patient-LastName 'AthenaHealth.Sdk.Models.Response.Patient.LastName')
  - [LocalPatientId](#P-AthenaHealth-Sdk-Models-Response-Patient-LocalPatientId 'AthenaHealth.Sdk.Models.Response.Patient.LocalPatientId')
  - [MaritalStatus](#P-AthenaHealth-Sdk-Models-Response-Patient-MaritalStatus 'AthenaHealth.Sdk.Models.Response.Patient.MaritalStatus')
  - [MaritalStatusName](#P-AthenaHealth-Sdk-Models-Response-Patient-MaritalStatusName 'AthenaHealth.Sdk.Models.Response.Patient.MaritalStatusName')
  - [MedicationHistoryConsentVerified](#P-AthenaHealth-Sdk-Models-Response-Patient-MedicationHistoryConsentVerified 'AthenaHealth.Sdk.Models.Response.Patient.MedicationHistoryConsentVerified')
  - [MiddleName](#P-AthenaHealth-Sdk-Models-Response-Patient-MiddleName 'AthenaHealth.Sdk.Models.Response.Patient.MiddleName')
  - [MobileCarrierId](#P-AthenaHealth-Sdk-Models-Response-Patient-MobileCarrierId 'AthenaHealth.Sdk.Models.Response.Patient.MobileCarrierId')
  - [MobilePhone](#P-AthenaHealth-Sdk-Models-Response-Patient-MobilePhone 'AthenaHealth.Sdk.Models.Response.Patient.MobilePhone')
  - [NextKinName](#P-AthenaHealth-Sdk-Models-Response-Patient-NextKinName 'AthenaHealth.Sdk.Models.Response.Patient.NextKinName')
  - [NextKinPhone](#P-AthenaHealth-Sdk-Models-Response-Patient-NextKinPhone 'AthenaHealth.Sdk.Models.Response.Patient.NextKinPhone')
  - [NextKinRelationship](#P-AthenaHealth-Sdk-Models-Response-Patient-NextKinRelationship 'AthenaHealth.Sdk.Models.Response.Patient.NextKinRelationship')
  - [Notes](#P-AthenaHealth-Sdk-Models-Response-Patient-Notes 'AthenaHealth.Sdk.Models.Response.Patient.Notes')
  - [OccupationCode](#P-AthenaHealth-Sdk-Models-Response-Patient-OccupationCode 'AthenaHealth.Sdk.Models.Response.Patient.OccupationCode')
  - [OnlineStateMentOnly](#P-AthenaHealth-Sdk-Models-Response-Patient-OnlineStateMentOnly 'AthenaHealth.Sdk.Models.Response.Patient.OnlineStateMentOnly')
  - [PatientPhoto](#P-AthenaHealth-Sdk-Models-Response-Patient-PatientPhoto 'AthenaHealth.Sdk.Models.Response.Patient.PatientPhoto')
  - [PatientPhotoUrl](#P-AthenaHealth-Sdk-Models-Response-Patient-PatientPhotoUrl 'AthenaHealth.Sdk.Models.Response.Patient.PatientPhotoUrl')
  - [PortalAccessGiven](#P-AthenaHealth-Sdk-Models-Response-Patient-PortalAccessGiven 'AthenaHealth.Sdk.Models.Response.Patient.PortalAccessGiven')
  - [PortalSignatureOnFile](#P-AthenaHealth-Sdk-Models-Response-Patient-PortalSignatureOnFile 'AthenaHealth.Sdk.Models.Response.Patient.PortalSignatureOnFile')
  - [PortalStatus](#P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatus 'AthenaHealth.Sdk.Models.Response.Patient.PortalStatus')
  - [PortalTermsOnFile](#P-AthenaHealth-Sdk-Models-Response-Patient-PortalTermsOnFile 'AthenaHealth.Sdk.Models.Response.Patient.PortalTermsOnFile')
  - [PovertyLevelCalculated](#P-AthenaHealth-Sdk-Models-Response-Patient-PovertyLevelCalculated 'AthenaHealth.Sdk.Models.Response.Patient.PovertyLevelCalculated')
  - [PovertyLevelFamilySize](#P-AthenaHealth-Sdk-Models-Response-Patient-PovertyLevelFamilySize 'AthenaHealth.Sdk.Models.Response.Patient.PovertyLevelFamilySize')
  - [PovertyLevelFamilySizeDeclined](#P-AthenaHealth-Sdk-Models-Response-Patient-PovertyLevelFamilySizeDeclined 'AthenaHealth.Sdk.Models.Response.Patient.PovertyLevelFamilySizeDeclined')
  - [PovertyLevelIncomeDeclined](#P-AthenaHealth-Sdk-Models-Response-Patient-PovertyLevelIncomeDeclined 'AthenaHealth.Sdk.Models.Response.Patient.PovertyLevelIncomeDeclined')
  - [PovertyLevelIncomePayPeriod](#P-AthenaHealth-Sdk-Models-Response-Patient-PovertyLevelIncomePayPeriod 'AthenaHealth.Sdk.Models.Response.Patient.PovertyLevelIncomePayPeriod')
  - [PovertyLevelIncomePerPayPeriod](#P-AthenaHealth-Sdk-Models-Response-Patient-PovertyLevelIncomePerPayPeriod 'AthenaHealth.Sdk.Models.Response.Patient.PovertyLevelIncomePerPayPeriod')
  - [PovertyLevelIncomeRangeDeclined](#P-AthenaHealth-Sdk-Models-Response-Patient-PovertyLevelIncomeRangeDeclined 'AthenaHealth.Sdk.Models.Response.Patient.PovertyLevelIncomeRangeDeclined')
  - [PreferredName](#P-AthenaHealth-Sdk-Models-Response-Patient-PreferredName 'AthenaHealth.Sdk.Models.Response.Patient.PreferredName')
  - [PreferredPronouns](#P-AthenaHealth-Sdk-Models-Response-Patient-PreferredPronouns 'AthenaHealth.Sdk.Models.Response.Patient.PreferredPronouns')
  - [PrimaryDepartmentId](#P-AthenaHealth-Sdk-Models-Response-Patient-PrimaryDepartmentId 'AthenaHealth.Sdk.Models.Response.Patient.PrimaryDepartmentId')
  - [PrimaryProviderId](#P-AthenaHealth-Sdk-Models-Response-Patient-PrimaryProviderId 'AthenaHealth.Sdk.Models.Response.Patient.PrimaryProviderId')
  - [PrivacyInformationVerified](#P-AthenaHealth-Sdk-Models-Response-Patient-PrivacyInformationVerified 'AthenaHealth.Sdk.Models.Response.Patient.PrivacyInformationVerified')
  - [PublicHousing](#P-AthenaHealth-Sdk-Models-Response-Patient-PublicHousing 'AthenaHealth.Sdk.Models.Response.Patient.PublicHousing')
  - [Race](#P-AthenaHealth-Sdk-Models-Response-Patient-Race 'AthenaHealth.Sdk.Models.Response.Patient.Race')
  - [RaceName](#P-AthenaHealth-Sdk-Models-Response-Patient-RaceName 'AthenaHealth.Sdk.Models.Response.Patient.RaceName')
  - [ReferralSourceId](#P-AthenaHealth-Sdk-Models-Response-Patient-ReferralSourceId 'AthenaHealth.Sdk.Models.Response.Patient.ReferralSourceId')
  - [ReferralSourceOther](#P-AthenaHealth-Sdk-Models-Response-Patient-ReferralSourceOther 'AthenaHealth.Sdk.Models.Response.Patient.ReferralSourceOther')
  - [RegistrationDate](#P-AthenaHealth-Sdk-Models-Response-Patient-RegistrationDate 'AthenaHealth.Sdk.Models.Response.Patient.RegistrationDate')
  - [SSN](#P-AthenaHealth-Sdk-Models-Response-Patient-SSN 'AthenaHealth.Sdk.Models.Response.Patient.SSN')
  - [SchoolBasedHealthCenter](#P-AthenaHealth-Sdk-Models-Response-Patient-SchoolBasedHealthCenter 'AthenaHealth.Sdk.Models.Response.Patient.SchoolBasedHealthCenter')
  - [Sex](#P-AthenaHealth-Sdk-Models-Response-Patient-Sex 'AthenaHealth.Sdk.Models.Response.Patient.Sex')
  - [SexualOrientation](#P-AthenaHealth-Sdk-Models-Response-Patient-SexualOrientation 'AthenaHealth.Sdk.Models.Response.Patient.SexualOrientation')
  - [SexualOrientationOther](#P-AthenaHealth-Sdk-Models-Response-Patient-SexualOrientationOther 'AthenaHealth.Sdk.Models.Response.Patient.SexualOrientationOther')
  - [State](#P-AthenaHealth-Sdk-Models-Response-Patient-State 'AthenaHealth.Sdk.Models.Response.Patient.State')
  - [Status](#P-AthenaHealth-Sdk-Models-Response-Patient-Status 'AthenaHealth.Sdk.Models.Response.Patient.Status')
  - [Suffix](#P-AthenaHealth-Sdk-Models-Response-Patient-Suffix 'AthenaHealth.Sdk.Models.Response.Patient.Suffix')
  - [Veteran](#P-AthenaHealth-Sdk-Models-Response-Patient-Veteran 'AthenaHealth.Sdk.Models.Response.Patient.Veteran')
  - [WorkPhone](#P-AthenaHealth-Sdk-Models-Response-Patient-WorkPhone 'AthenaHealth.Sdk.Models.Response.Patient.WorkPhone')
  - [Zip](#P-AthenaHealth-Sdk-Models-Response-Patient-Zip 'AthenaHealth.Sdk.Models.Response.Patient.Zip')
- [PatientAllergy](#T-AthenaHealth-Sdk-Models-Response-PatientAllergy 'AthenaHealth.Sdk.Models.Response.PatientAllergy')
  - [Allergies](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergies 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergies')
  - [LastModifiedBy](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-LastModifiedBy 'AthenaHealth.Sdk.Models.Response.PatientAllergy.LastModifiedBy')
  - [LastModifiedDateTime](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-LastModifiedDateTime 'AthenaHealth.Sdk.Models.Response.PatientAllergy.LastModifiedDateTime')
  - [NoKnownDrugAllergies](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-NoKnownDrugAllergies 'AthenaHealth.Sdk.Models.Response.PatientAllergy.NoKnownDrugAllergies')
  - [NoteLastModifiedBy](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-NoteLastModifiedBy 'AthenaHealth.Sdk.Models.Response.PatientAllergy.NoteLastModifiedBy')
  - [NoteLastModifiedDateTime](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-NoteLastModifiedDateTime 'AthenaHealth.Sdk.Models.Response.PatientAllergy.NoteLastModifiedDateTime')
  - [SectionNote](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-SectionNote 'AthenaHealth.Sdk.Models.Response.PatientAllergy.SectionNote')
- [PatientClient](#T-AthenaHealth-Sdk-Clients-PatientClient 'AthenaHealth.Sdk.Clients.PatientClient')
  - [DeleteInsuranceCardPhoto(patientId,insuranceId)](#M-AthenaHealth-Sdk-Clients-PatientClient-DeleteInsuranceCardPhoto-System-Int32,System-Int32- 'AthenaHealth.Sdk.Clients.PatientClient.DeleteInsuranceCardPhoto(System.Int32,System.Int32)')
  - [DeletePatient(patientId)](#M-AthenaHealth-Sdk-Clients-PatientClient-DeletePatient-System-Int32- 'AthenaHealth.Sdk.Clients.PatientClient.DeletePatient(System.Int32)')
  - [DeletePhoto(patientId)](#M-AthenaHealth-Sdk-Clients-PatientClient-DeletePhoto-System-Int32- 'AthenaHealth.Sdk.Clients.PatientClient.DeletePhoto(System.Int32)')
  - [GetInsuranceCardPhoto(patientId,insuranceId,jpegOutput)](#M-AthenaHealth-Sdk-Clients-PatientClient-GetInsuranceCardPhoto-System-Int32,System-Int32,System-Nullable{System-Boolean}- 'AthenaHealth.Sdk.Clients.PatientClient.GetInsuranceCardPhoto(System.Int32,System.Int32,System.Nullable{System.Boolean})')
  - [GetPhoto(patientId,jpegOutput)](#M-AthenaHealth-Sdk-Clients-PatientClient-GetPhoto-System-Int32,System-Nullable{System-Boolean}- 'AthenaHealth.Sdk.Clients.PatientClient.GetPhoto(System.Int32,System.Nullable{System.Boolean})')
  - [UpdateInsuranceCardPhoto(patientId,insuranceId,request)](#M-AthenaHealth-Sdk-Clients-PatientClient-UpdateInsuranceCardPhoto-System-Int32,System-Int32,AthenaHealth-Sdk-Models-Request-UpdateInsuranceCardPhoto- 'AthenaHealth.Sdk.Clients.PatientClient.UpdateInsuranceCardPhoto(System.Int32,System.Int32,AthenaHealth.Sdk.Models.Request.UpdateInsuranceCardPhoto)')
  - [UpdatePhoto(patientId,request)](#M-AthenaHealth-Sdk-Clients-PatientClient-UpdatePhoto-System-Int32,AthenaHealth-Sdk-Models-Request-UpdatePhoto- 'AthenaHealth.Sdk.Clients.PatientClient.UpdatePhoto(System.Int32,AthenaHealth.Sdk.Models.Request.UpdatePhoto)')
- [PatientMedication](#T-AthenaHealth-Sdk-Models-Response-PatientMedication 'AthenaHealth.Sdk.Models.Response.PatientMedication')
  - [LastDownloadDenialReason](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-LastDownloadDenialReason 'AthenaHealth.Sdk.Models.Response.PatientMedication.LastDownloadDenialReason')
  - [LastDownloadDenied](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-LastDownloadDenied 'AthenaHealth.Sdk.Models.Response.PatientMedication.LastDownloadDenied')
  - [LastDownloadedDate](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-LastDownloadedDate 'AthenaHealth.Sdk.Models.Response.PatientMedication.LastDownloadedDate')
  - [LastUpdated](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-LastUpdated 'AthenaHealth.Sdk.Models.Response.PatientMedication.LastUpdated')
  - [Medications](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medications 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medications')
  - [NoMedicationsReported](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-NoMedicationsReported 'AthenaHealth.Sdk.Models.Response.PatientMedication.NoMedicationsReported')
  - [PatientDownloadConsent](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-PatientDownloadConsent 'AthenaHealth.Sdk.Models.Response.PatientMedication.PatientDownloadConsent')
  - [PatientNeedsDownloadConsent](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-PatientNeedsDownloadConsent 'AthenaHealth.Sdk.Models.Response.PatientMedication.PatientNeedsDownloadConsent')
  - [SectionNote](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-SectionNote 'AthenaHealth.Sdk.Models.Response.PatientMedication.SectionNote')
- [PatientSignature](#T-AthenaHealth-Sdk-Models-Response-PatientSignature 'AthenaHealth.Sdk.Models.Response.PatientSignature')
  - [EffectiveDate](#P-AthenaHealth-Sdk-Models-Response-PatientSignature-EffectiveDate 'AthenaHealth.Sdk.Models.Response.PatientSignature.EffectiveDate')
  - [ExpirationDate](#P-AthenaHealth-Sdk-Models-Response-PatientSignature-ExpirationDate 'AthenaHealth.Sdk.Models.Response.PatientSignature.ExpirationDate')
  - [IsOnFile](#P-AthenaHealth-Sdk-Models-Response-PatientSignature-IsOnFile 'AthenaHealth.Sdk.Models.Response.PatientSignature.IsOnFile')
- [PatientSocialHistory](#T-AthenaHealth-Sdk-Models-Response-PatientSocialHistory 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory')
  - [Questions](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Questions 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Questions')
  - [SectionNote](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-SectionNote 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.SectionNote')
  - [Templates](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Templates 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Templates')
- [PatientStatus](#T-AthenaHealth-Sdk-Models-Response-Patient-PatientStatus 'AthenaHealth.Sdk.Models.Response.Patient.PatientStatus')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Response-Patient-PatientStatus-DepartmentId 'AthenaHealth.Sdk.Models.Response.Patient.PatientStatus.DepartmentId')
  - [PrimaryProviderId](#P-AthenaHealth-Sdk-Models-Response-Patient-PatientStatus-PrimaryProviderId 'AthenaHealth.Sdk.Models.Response.Patient.PatientStatus.PrimaryProviderId')
  - [Status](#P-AthenaHealth-Sdk-Models-Response-Patient-PatientStatus-Status 'AthenaHealth.Sdk.Models.Response.Patient.PatientStatus.Status')
- [PatientWithScore](#T-AthenaHealth-Sdk-Models-Response-PatientWithScore 'AthenaHealth.Sdk.Models.Response.PatientWithScore')
  - [Score](#P-AthenaHealth-Sdk-Models-Response-PatientWithScore-Score 'AthenaHealth.Sdk.Models.Response.PatientWithScore.Score')
- [PaymentMethod](#T-AthenaHealth-Sdk-Models-Response-PaymentMethod 'AthenaHealth.Sdk.Models.Response.PaymentMethod')
  - [IdentifierName](#P-AthenaHealth-Sdk-Models-Response-PaymentMethod-IdentifierName 'AthenaHealth.Sdk.Models.Response.PaymentMethod.IdentifierName')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-PaymentMethod-Name 'AthenaHealth.Sdk.Models.Response.PaymentMethod.Name')
- [Pharmacy](#T-AthenaHealth-Sdk-Models-Response-Pharmacy 'AthenaHealth.Sdk.Models.Response.Pharmacy')
  - [AcceptFax](#P-AthenaHealth-Sdk-Models-Response-Pharmacy-AcceptFax 'AthenaHealth.Sdk.Models.Response.Pharmacy.AcceptFax')
  - [Address1](#P-AthenaHealth-Sdk-Models-Response-Pharmacy-Address1 'AthenaHealth.Sdk.Models.Response.Pharmacy.Address1')
  - [Address2](#P-AthenaHealth-Sdk-Models-Response-Pharmacy-Address2 'AthenaHealth.Sdk.Models.Response.Pharmacy.Address2')
  - [City](#P-AthenaHealth-Sdk-Models-Response-Pharmacy-City 'AthenaHealth.Sdk.Models.Response.Pharmacy.City')
  - [ClinicalProviderId](#P-AthenaHealth-Sdk-Models-Response-Pharmacy-ClinicalProviderId 'AthenaHealth.Sdk.Models.Response.Pharmacy.ClinicalProviderId')
  - [ClinicalProviderName](#P-AthenaHealth-Sdk-Models-Response-Pharmacy-ClinicalProviderName 'AthenaHealth.Sdk.Models.Response.Pharmacy.ClinicalProviderName')
  - [DefaultPharmacy](#P-AthenaHealth-Sdk-Models-Response-Pharmacy-DefaultPharmacy 'AthenaHealth.Sdk.Models.Response.Pharmacy.DefaultPharmacy')
  - [FaxNumber](#P-AthenaHealth-Sdk-Models-Response-Pharmacy-FaxNumber 'AthenaHealth.Sdk.Models.Response.Pharmacy.FaxNumber')
  - [PharmacyType](#P-AthenaHealth-Sdk-Models-Response-Pharmacy-PharmacyType 'AthenaHealth.Sdk.Models.Response.Pharmacy.PharmacyType')
  - [PhoneNumber](#P-AthenaHealth-Sdk-Models-Response-Pharmacy-PhoneNumber 'AthenaHealth.Sdk.Models.Response.Pharmacy.PhoneNumber')
  - [ReceiverType](#P-AthenaHealth-Sdk-Models-Response-Pharmacy-ReceiverType 'AthenaHealth.Sdk.Models.Response.Pharmacy.ReceiverType')
  - [State](#P-AthenaHealth-Sdk-Models-Response-Pharmacy-State 'AthenaHealth.Sdk.Models.Response.Pharmacy.State')
  - [Zip](#P-AthenaHealth-Sdk-Models-Response-Pharmacy-Zip 'AthenaHealth.Sdk.Models.Response.Pharmacy.Zip')
- [PortalStatusModel](#T-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel 'AthenaHealth.Sdk.Models.Response.Patient.PortalStatusModel')
  - [BlockedFailedLogins](#P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-BlockedFailedLogins 'AthenaHealth.Sdk.Models.Response.Patient.PortalStatusModel.BlockedFailedLogins')
  - [EntityToDisplay](#P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-EntityToDisplay 'AthenaHealth.Sdk.Models.Response.Patient.PortalStatusModel.EntityToDisplay')
  - [FamilyBlockedFailedLogins](#P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-FamilyBlockedFailedLogins 'AthenaHealth.Sdk.Models.Response.Patient.PortalStatusModel.FamilyBlockedFailedLogins')
  - [FamilyRegistered](#P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-FamilyRegistered 'AthenaHealth.Sdk.Models.Response.Patient.PortalStatusModel.FamilyRegistered')
  - [LastLoginDate](#P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-LastLoginDate 'AthenaHealth.Sdk.Models.Response.Patient.PortalStatusModel.LastLoginDate')
  - [LastLoginEntity](#P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-LastLoginEntity 'AthenaHealth.Sdk.Models.Response.Patient.PortalStatusModel.LastLoginEntity')
  - [NoPortal](#P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-NoPortal 'AthenaHealth.Sdk.Models.Response.Patient.PortalStatusModel.NoPortal')
  - [PortalRegistrationDate](#P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-PortalRegistrationDate 'AthenaHealth.Sdk.Models.Response.Patient.PortalStatusModel.PortalRegistrationDate')
  - [Registered](#P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-Registered 'AthenaHealth.Sdk.Models.Response.Patient.PortalStatusModel.Registered')
  - [Status](#P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-Status 'AthenaHealth.Sdk.Models.Response.Patient.PortalStatusModel.Status')
  - [TermsAccepted](#P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-TermsAccepted 'AthenaHealth.Sdk.Models.Response.Patient.PortalStatusModel.TermsAccepted')
- [PracticeClient](#T-AthenaHealth-Sdk-Clients-PracticeClient 'AthenaHealth.Sdk.Clients.PracticeClient')
  - [GetCurrentPractice(filter)](#M-AthenaHealth-Sdk-Clients-PracticeClient-GetCurrentPractice-AthenaHealth-Sdk-Models-Request-BaseLimitFilter- 'AthenaHealth.Sdk.Clients.PracticeClient.GetCurrentPractice(AthenaHealth.Sdk.Models.Request.BaseLimitFilter)')
- [Prescription](#T-AthenaHealth-Sdk-Models-Response-Prescription 'AthenaHealth.Sdk.Models.Response.Prescription')
  - [AppointmentId](#P-AthenaHealth-Sdk-Models-Response-Prescription-AppointmentId 'AthenaHealth.Sdk.Models.Response.Prescription.AppointmentId')
  - [AssignedTo](#P-AthenaHealth-Sdk-Models-Response-Prescription-AssignedTo 'AthenaHealth.Sdk.Models.Response.Prescription.AssignedTo')
  - [CreatedDate](#P-AthenaHealth-Sdk-Models-Response-Prescription-CreatedDate 'AthenaHealth.Sdk.Models.Response.Prescription.CreatedDate')
  - [CreatedDateTime](#P-AthenaHealth-Sdk-Models-Response-Prescription-CreatedDateTime 'AthenaHealth.Sdk.Models.Response.Prescription.CreatedDateTime')
  - [DeaSchedule](#P-AthenaHealth-Sdk-Models-Response-Prescription-DeaSchedule 'AthenaHealth.Sdk.Models.Response.Prescription.DeaSchedule')
  - [DeclinedReason](#P-AthenaHealth-Sdk-Models-Response-Prescription-DeclinedReason 'AthenaHealth.Sdk.Models.Response.Prescription.DeclinedReason')
  - [DeclinedReasonText](#P-AthenaHealth-Sdk-Models-Response-Prescription-DeclinedReasonText 'AthenaHealth.Sdk.Models.Response.Prescription.DeclinedReasonText')
  - [DeletedDateTime](#P-AthenaHealth-Sdk-Models-Response-Prescription-DeletedDateTime 'AthenaHealth.Sdk.Models.Response.Prescription.DeletedDateTime')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Response-Prescription-DepartmentId 'AthenaHealth.Sdk.Models.Response.Prescription.DepartmentId')
  - [DocumentClass](#P-AthenaHealth-Sdk-Models-Response-Prescription-DocumentClass 'AthenaHealth.Sdk.Models.Response.Prescription.DocumentClass')
  - [DocumentDescription](#P-AthenaHealth-Sdk-Models-Response-Prescription-DocumentDescription 'AthenaHealth.Sdk.Models.Response.Prescription.DocumentDescription')
  - [DocumentRoute](#P-AthenaHealth-Sdk-Models-Response-Prescription-DocumentRoute 'AthenaHealth.Sdk.Models.Response.Prescription.DocumentRoute')
  - [DocumentSource](#P-AthenaHealth-Sdk-Models-Response-Prescription-DocumentSource 'AthenaHealth.Sdk.Models.Response.Prescription.DocumentSource')
  - [DocumentSubclass](#P-AthenaHealth-Sdk-Models-Response-Prescription-DocumentSubclass 'AthenaHealth.Sdk.Models.Response.Prescription.DocumentSubclass')
  - [DocumentTypeId](#P-AthenaHealth-Sdk-Models-Response-Prescription-DocumentTypeId 'AthenaHealth.Sdk.Models.Response.Prescription.DocumentTypeId')
  - [EncounterId](#P-AthenaHealth-Sdk-Models-Response-Prescription-EncounterId 'AthenaHealth.Sdk.Models.Response.Prescription.EncounterId')
  - [ExternalAccessionId](#P-AthenaHealth-Sdk-Models-Response-Prescription-ExternalAccessionId 'AthenaHealth.Sdk.Models.Response.Prescription.ExternalAccessionId')
  - [ExternalNote](#P-AthenaHealth-Sdk-Models-Response-Prescription-ExternalNote 'AthenaHealth.Sdk.Models.Response.Prescription.ExternalNote')
  - [FacilityId](#P-AthenaHealth-Sdk-Models-Response-Prescription-FacilityId 'AthenaHealth.Sdk.Models.Response.Prescription.FacilityId')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-Prescription-Id 'AthenaHealth.Sdk.Models.Response.Prescription.Id')
  - [InternalAccessionId](#P-AthenaHealth-Sdk-Models-Response-Prescription-InternalAccessionId 'AthenaHealth.Sdk.Models.Response.Prescription.InternalAccessionId')
  - [InternalNote](#P-AthenaHealth-Sdk-Models-Response-Prescription-InternalNote 'AthenaHealth.Sdk.Models.Response.Prescription.InternalNote')
  - [LastModifiedDateTime](#P-AthenaHealth-Sdk-Models-Response-Prescription-LastModifiedDateTime 'AthenaHealth.Sdk.Models.Response.Prescription.LastModifiedDateTime')
  - [ObservationDate](#P-AthenaHealth-Sdk-Models-Response-Prescription-ObservationDate 'AthenaHealth.Sdk.Models.Response.Prescription.ObservationDate')
  - [ObservationDateTime](#P-AthenaHealth-Sdk-Models-Response-Prescription-ObservationDateTime 'AthenaHealth.Sdk.Models.Response.Prescription.ObservationDateTime')
  - [OrderType](#P-AthenaHealth-Sdk-Models-Response-Prescription-OrderType 'AthenaHealth.Sdk.Models.Response.Prescription.OrderType')
  - [OrderingMode](#P-AthenaHealth-Sdk-Models-Response-Prescription-OrderingMode 'AthenaHealth.Sdk.Models.Response.Prescription.OrderingMode')
  - [PatientCaseId](#P-AthenaHealth-Sdk-Models-Response-Prescription-PatientCaseId 'AthenaHealth.Sdk.Models.Response.Prescription.PatientCaseId')
  - [Priority](#P-AthenaHealth-Sdk-Models-Response-Prescription-Priority 'AthenaHealth.Sdk.Models.Response.Prescription.Priority')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Response-Prescription-ProviderId 'AthenaHealth.Sdk.Models.Response.Prescription.ProviderId')
  - [ProviderNPI](#P-AthenaHealth-Sdk-Models-Response-Prescription-ProviderNPI 'AthenaHealth.Sdk.Models.Response.Prescription.ProviderNPI')
  - [Status](#P-AthenaHealth-Sdk-Models-Response-Prescription-Status 'AthenaHealth.Sdk.Models.Response.Prescription.Status')
  - [Subject](#P-AthenaHealth-Sdk-Models-Response-Prescription-Subject 'AthenaHealth.Sdk.Models.Response.Prescription.Subject')
  - [TieToOrderId](#P-AthenaHealth-Sdk-Models-Response-Prescription-TieToOrderId 'AthenaHealth.Sdk.Models.Response.Prescription.TieToOrderId')
- [PrivacyInformationResponse](#T-AthenaHealth-Sdk-Models-Response-PrivacyInformationResponse 'AthenaHealth.Sdk.Models.Response.PrivacyInformationResponse')
  - [NumberOfCheckboxesConfigured](#P-AthenaHealth-Sdk-Models-Response-PrivacyInformationResponse-NumberOfCheckboxesConfigured 'AthenaHealth.Sdk.Models.Response.PrivacyInformationResponse.NumberOfCheckboxesConfigured')
- [PrivacyNote](#T-AthenaHealth-Sdk-Models-Response-PrivacyNote 'AthenaHealth.Sdk.Models.Response.PrivacyNote')
  - [GivenDate](#P-AthenaHealth-Sdk-Models-Response-PrivacyNote-GivenDate 'AthenaHealth.Sdk.Models.Response.PrivacyNote.GivenDate')
  - [GivenNote](#P-AthenaHealth-Sdk-Models-Response-PrivacyNote-GivenNote 'AthenaHealth.Sdk.Models.Response.PrivacyNote.GivenNote')
  - [GivenReason](#P-AthenaHealth-Sdk-Models-Response-PrivacyNote-GivenReason 'AthenaHealth.Sdk.Models.Response.PrivacyNote.GivenReason')
  - [IsOnFile](#P-AthenaHealth-Sdk-Models-Response-PrivacyNote-IsOnFile 'AthenaHealth.Sdk.Models.Response.PrivacyNote.IsOnFile')
- [Problem](#T-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem')
  - [BestmatchICD10Code](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-BestmatchICD10Code 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.BestmatchICD10Code')
  - [Code](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Code 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Code')
  - [Codeset](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Codeset 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Codeset')
  - [DeactivatedDate](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-DeactivatedDate 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.DeactivatedDate')
  - [DeactivatedUser](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-DeactivatedUser 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.DeactivatedUser')
  - [Events](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Events 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Events')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Id 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Id')
  - [LastModifiedBy](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-LastModifiedBy 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.LastModifiedBy')
  - [LastModifiedDateTime](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-LastModifiedDateTime 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.LastModifiedDateTime')
  - [MostRecentDiagnosisNote](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-MostRecentDiagnosisNote 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.MostRecentDiagnosisNote')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Name 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Name')
- [ProblemResponse](#T-AthenaHealth-Sdk-Models-Response-ProblemResponse 'AthenaHealth.Sdk.Models.Response.ProblemResponse')
  - [LastModifiedBy](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-LastModifiedBy 'AthenaHealth.Sdk.Models.Response.ProblemResponse.LastModifiedBy')
  - [LastModifiedDateTime](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-LastModifiedDateTime 'AthenaHealth.Sdk.Models.Response.ProblemResponse.LastModifiedDateTime')
  - [LastUpdated](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-LastUpdated 'AthenaHealth.Sdk.Models.Response.ProblemResponse.LastUpdated')
  - [NoKnownProblems](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-NoKnownProblems 'AthenaHealth.Sdk.Models.Response.ProblemResponse.NoKnownProblems')
  - [NoteLastModifiedBy](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-NoteLastModifiedBy 'AthenaHealth.Sdk.Models.Response.ProblemResponse.NoteLastModifiedBy')
  - [NoteLastModifiedDateTime](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-NoteLastModifiedDateTime 'AthenaHealth.Sdk.Models.Response.ProblemResponse.NoteLastModifiedDateTime')
  - [Problems](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problems 'AthenaHealth.Sdk.Models.Response.ProblemResponse.Problems')
  - [SectionNote](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-SectionNote 'AthenaHealth.Sdk.Models.Response.ProblemResponse.SectionNote')
  - [TotalCount](#P-AthenaHealth-Sdk-Models-Response-ProblemResponse-TotalCount 'AthenaHealth.Sdk.Models.Response.ProblemResponse.TotalCount')
- [Procedure](#T-AthenaHealth-Sdk-Models-Response-Appointment-Procedure 'AthenaHealth.Sdk.Models.Response.Appointment.Procedure')
  - [AllowableAmount](#P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-AllowableAmount 'AthenaHealth.Sdk.Models.Response.Appointment.Procedure.AllowableAmount')
  - [AllowableMax](#P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-AllowableMax 'AthenaHealth.Sdk.Models.Response.Appointment.Procedure.AllowableMax')
  - [AllowableMin](#P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-AllowableMin 'AthenaHealth.Sdk.Models.Response.Appointment.Procedure.AllowableMin')
  - [ChargeAmount](#P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-ChargeAmount 'AthenaHealth.Sdk.Models.Response.Appointment.Procedure.ChargeAmount')
  - [ProcedureCategory](#P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-ProcedureCategory 'AthenaHealth.Sdk.Models.Response.Appointment.Procedure.ProcedureCategory')
  - [ProcedureCode](#P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-ProcedureCode 'AthenaHealth.Sdk.Models.Response.Appointment.Procedure.ProcedureCode')
  - [ProcedureDescription](#P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-ProcedureDescription 'AthenaHealth.Sdk.Models.Response.Appointment.Procedure.ProcedureDescription')
  - [TransactionId](#P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-TransactionId 'AthenaHealth.Sdk.Models.Response.Appointment.Procedure.TransactionId')
- [Provider](#T-AthenaHealth-Sdk-Models-Response-Provider 'AthenaHealth.Sdk.Models.Response.Provider')
  - [AcceptingNewPatients](#P-AthenaHealth-Sdk-Models-Response-Provider-AcceptingNewPatients 'AthenaHealth.Sdk.Models.Response.Provider.AcceptingNewPatients')
  - [AnsiNameCode](#P-AthenaHealth-Sdk-Models-Response-Provider-AnsiNameCode 'AthenaHealth.Sdk.Models.Response.Provider.AnsiNameCode')
  - [AnsiSpecialtyCode](#P-AthenaHealth-Sdk-Models-Response-Provider-AnsiSpecialtyCode 'AthenaHealth.Sdk.Models.Response.Provider.AnsiSpecialtyCode')
  - [Billable](#P-AthenaHealth-Sdk-Models-Response-Provider-Billable 'AthenaHealth.Sdk.Models.Response.Provider.Billable')
  - [CreateEncounterOnCheckIn](#P-AthenaHealth-Sdk-Models-Response-Provider-CreateEncounterOnCheckIn 'AthenaHealth.Sdk.Models.Response.Provider.CreateEncounterOnCheckIn')
  - [CreateEncounterProviderIdList](#P-AthenaHealth-Sdk-Models-Response-Provider-CreateEncounterProviderIdList 'AthenaHealth.Sdk.Models.Response.Provider.CreateEncounterProviderIdList')
  - [DisplayName](#P-AthenaHealth-Sdk-Models-Response-Provider-DisplayName 'AthenaHealth.Sdk.Models.Response.Provider.DisplayName')
  - [EntityType](#P-AthenaHealth-Sdk-Models-Response-Provider-EntityType 'AthenaHealth.Sdk.Models.Response.Provider.EntityType')
  - [FirstName](#P-AthenaHealth-Sdk-Models-Response-Provider-FirstName 'AthenaHealth.Sdk.Models.Response.Provider.FirstName')
  - [HideInPortal](#P-AthenaHealth-Sdk-Models-Response-Provider-HideInPortal 'AthenaHealth.Sdk.Models.Response.Provider.HideInPortal')
  - [HomeDepartment](#P-AthenaHealth-Sdk-Models-Response-Provider-HomeDepartment 'AthenaHealth.Sdk.Models.Response.Provider.HomeDepartment')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-Provider-Id 'AthenaHealth.Sdk.Models.Response.Provider.Id')
  - [LastName](#P-AthenaHealth-Sdk-Models-Response-Provider-LastName 'AthenaHealth.Sdk.Models.Response.Provider.LastName')
  - [Npi](#P-AthenaHealth-Sdk-Models-Response-Provider-Npi 'AthenaHealth.Sdk.Models.Response.Provider.Npi')
  - [OtherProviderIdList](#P-AthenaHealth-Sdk-Models-Response-Provider-OtherProviderIdList 'AthenaHealth.Sdk.Models.Response.Provider.OtherProviderIdList')
  - [ProviderGroupList](#P-AthenaHealth-Sdk-Models-Response-Provider-ProviderGroupList 'AthenaHealth.Sdk.Models.Response.Provider.ProviderGroupList')
  - [ProviderType](#P-AthenaHealth-Sdk-Models-Response-Provider-ProviderType 'AthenaHealth.Sdk.Models.Response.Provider.ProviderType')
  - [ProviderTypeId](#P-AthenaHealth-Sdk-Models-Response-Provider-ProviderTypeId 'AthenaHealth.Sdk.Models.Response.Provider.ProviderTypeId')
  - [ProviderUsername](#P-AthenaHealth-Sdk-Models-Response-Provider-ProviderUsername 'AthenaHealth.Sdk.Models.Response.Provider.ProviderUsername')
  - [ScheduleResourceType](#P-AthenaHealth-Sdk-Models-Response-Provider-ScheduleResourceType 'AthenaHealth.Sdk.Models.Response.Provider.ScheduleResourceType')
  - [SchedulingName](#P-AthenaHealth-Sdk-Models-Response-Provider-SchedulingName 'AthenaHealth.Sdk.Models.Response.Provider.SchedulingName')
  - [Specialty](#P-AthenaHealth-Sdk-Models-Response-Provider-Specialty 'AthenaHealth.Sdk.Models.Response.Provider.Specialty')
  - [SupervisingProviderId](#P-AthenaHealth-Sdk-Models-Response-Provider-SupervisingProviderId 'AthenaHealth.Sdk.Models.Response.Provider.SupervisingProviderId')
  - [UsualDepartmentId](#P-AthenaHealth-Sdk-Models-Response-Provider-UsualDepartmentId 'AthenaHealth.Sdk.Models.Response.Provider.UsualDepartmentId')
- [ProviderExtended](#T-AthenaHealth-Sdk-Models-Response-ProviderExtended 'AthenaHealth.Sdk.Models.Response.ProviderExtended')
  - [FederalIdNumber](#P-AthenaHealth-Sdk-Models-Response-ProviderExtended-FederalIdNumber 'AthenaHealth.Sdk.Models.Response.ProviderExtended.FederalIdNumber')
- [ProviderType](#T-AthenaHealth-Sdk-Models-Response-ProviderType 'AthenaHealth.Sdk.Models.Response.ProviderType')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-ProviderType-Id 'AthenaHealth.Sdk.Models.Response.ProviderType.Id')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-ProviderType-Name 'AthenaHealth.Sdk.Models.Response.ProviderType.Name')
- [Question](#T-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-Question 'AthenaHealth.Sdk.Models.Request.UpdateMedicalHistory.Question')
- [Question](#T-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-Question 'AthenaHealth.Sdk.Models.Request.UpdateSocialHistory.Question')
- [Question](#T-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question 'AthenaHealth.Sdk.Models.Response.MedicalHistory.Question')
- [Question](#T-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Question')
- [Question](#T-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question 'AthenaHealth.Sdk.Models.Response.SocialHistoryTemplate.Question')
  - [Answer](#P-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-Question-Answer 'AthenaHealth.Sdk.Models.Request.UpdateMedicalHistory.Question.Answer')
  - [Delete](#P-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-Question-Delete 'AthenaHealth.Sdk.Models.Request.UpdateMedicalHistory.Question.Delete')
  - [Id](#P-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-Question-Id 'AthenaHealth.Sdk.Models.Request.UpdateMedicalHistory.Question.Id')
  - [Note](#P-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-Question-Note 'AthenaHealth.Sdk.Models.Request.UpdateMedicalHistory.Question.Note')
  - [Answer](#P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-Question-Answer 'AthenaHealth.Sdk.Models.Request.UpdateSocialHistory.Question.Answer')
  - [Delete](#P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-Question-Delete 'AthenaHealth.Sdk.Models.Request.UpdateSocialHistory.Question.Delete')
  - [Key](#P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-Question-Key 'AthenaHealth.Sdk.Models.Request.UpdateSocialHistory.Question.Key')
  - [NotPerformedReason](#P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-Question-NotPerformedReason 'AthenaHealth.Sdk.Models.Request.UpdateSocialHistory.Question.NotPerformedReason')
  - [Note](#P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-Question-Note 'AthenaHealth.Sdk.Models.Request.UpdateSocialHistory.Question.Note')
  - [Answer](#P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question-Answer 'AthenaHealth.Sdk.Models.Response.MedicalHistory.Question.Answer')
  - [Codeset](#P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question-Codeset 'AthenaHealth.Sdk.Models.Response.MedicalHistory.Question.Codeset')
  - [Description](#P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question-Description 'AthenaHealth.Sdk.Models.Response.MedicalHistory.Question.Description')
  - [DiagnosisCode](#P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question-DiagnosisCode 'AthenaHealth.Sdk.Models.Response.MedicalHistory.Question.DiagnosisCode')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question-Id 'AthenaHealth.Sdk.Models.Response.MedicalHistory.Question.Id')
  - [Note](#P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question-Note 'AthenaHealth.Sdk.Models.Response.MedicalHistory.Question.Note')
  - [Value](#P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question-Value 'AthenaHealth.Sdk.Models.Response.MedicalHistory.Question.Value')
  - [Answer](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Answer 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Question.Answer')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Id 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Question.Id')
  - [Key](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Key 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Question.Key')
  - [LastUpdated](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-LastUpdated 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Question.LastUpdated')
  - [NotPerformedReason](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-NotPerformedReason 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Question.NotPerformedReason')
  - [Note](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Note 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Question.Note')
  - [NoteLastUpdatedDate](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-NoteLastUpdatedDate 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Question.NoteLastUpdatedDate')
  - [Ordering](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Ordering 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Question.Ordering')
  - [QuestionText](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-QuestionText 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Question.QuestionText')
  - [TemplateId](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-TemplateId 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Question.TemplateId')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question-Id 'AthenaHealth.Sdk.Models.Response.SocialHistoryTemplate.Question.Id')
  - [InputType](#P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question-InputType 'AthenaHealth.Sdk.Models.Response.SocialHistoryTemplate.Question.InputType')
  - [Key](#P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question-Key 'AthenaHealth.Sdk.Models.Response.SocialHistoryTemplate.Question.Key')
  - [Options](#P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question-Options 'AthenaHealth.Sdk.Models.Response.SocialHistoryTemplate.Question.Options')
  - [Ordering](#P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question-Ordering 'AthenaHealth.Sdk.Models.Response.SocialHistoryTemplate.Question.Ordering')
  - [QuestionText](#P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question-QuestionText 'AthenaHealth.Sdk.Models.Response.SocialHistoryTemplate.Question.QuestionText')
  - [SocialHistoryStatus](#P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question-SocialHistoryStatus 'AthenaHealth.Sdk.Models.Response.SocialHistoryTemplate.Question.SocialHistoryStatus')
- [Reaction](#T-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Reaction 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.Allergy.Reaction')
- [Reaction](#T-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-Reaction 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy.Reaction')
  - [ReactionName](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Reaction-ReactionName 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.Allergy.Reaction.ReactionName')
  - [Severity](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Reaction-Severity 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.Allergy.Reaction.Severity')
  - [SeveritySnomedCode](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Reaction-SeveritySnomedCode 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.Allergy.Reaction.SeveritySnomedCode')
  - [SnomedCode](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Reaction-SnomedCode 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.Allergy.Reaction.SnomedCode')
  - [ReactionName](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-Reaction-ReactionName 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy.Reaction.ReactionName')
  - [Severity](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-Reaction-Severity 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy.Reaction.Severity')
  - [SeveritySnomedCode](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-Reaction-SeveritySnomedCode 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy.Reaction.SeveritySnomedCode')
  - [SnomedCode](#P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-Reaction-SnomedCode 'AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy.Reaction.SnomedCode')
- [Reason](#T-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Reason 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Question.Reason')
- [Reason](#T-AthenaHealth-Sdk-Models-Response-Prescription-Reason 'AthenaHealth.Sdk.Models.Response.Prescription.Reason')
  - [Code](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Reason-Code 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Question.Reason.Code')
  - [Text](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Reason-Text 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Question.Reason.Text')
  - [Code](#P-AthenaHealth-Sdk-Models-Response-Prescription-Reason-Code 'AthenaHealth.Sdk.Models.Response.Prescription.Reason.Code')
  - [Codeset](#P-AthenaHealth-Sdk-Models-Response-Prescription-Reason-Codeset 'AthenaHealth.Sdk.Models.Response.Prescription.Reason.Codeset')
  - [Description](#P-AthenaHealth-Sdk-Models-Response-Prescription-Reason-Description 'AthenaHealth.Sdk.Models.Response.Prescription.Reason.Description')
- [RecordPayment](#T-AthenaHealth-Sdk-Models-Request-RecordPayment 'AthenaHealth.Sdk.Models.Request.RecordPayment')
  - [AppointmentId](#P-AthenaHealth-Sdk-Models-Request-RecordPayment-AppointmentId 'AthenaHealth.Sdk.Models.Request.RecordPayment.AppointmentId')
  - [CardNumberLast4](#P-AthenaHealth-Sdk-Models-Request-RecordPayment-CardNumberLast4 'AthenaHealth.Sdk.Models.Request.RecordPayment.CardNumberLast4')
  - [CheckNumber](#P-AthenaHealth-Sdk-Models-Request-RecordPayment-CheckNumber 'AthenaHealth.Sdk.Models.Request.RecordPayment.CheckNumber')
  - [ClaimPayment](#P-AthenaHealth-Sdk-Models-Request-RecordPayment-ClaimPayment 'AthenaHealth.Sdk.Models.Request.RecordPayment.ClaimPayment')
  - [CopayAmount](#P-AthenaHealth-Sdk-Models-Request-RecordPayment-CopayAmount 'AthenaHealth.Sdk.Models.Request.RecordPayment.CopayAmount')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-RecordPayment-DepartmentId 'AthenaHealth.Sdk.Models.Request.RecordPayment.DepartmentId')
  - [IsTodayService](#P-AthenaHealth-Sdk-Models-Request-RecordPayment-IsTodayService 'AthenaHealth.Sdk.Models.Request.RecordPayment.IsTodayService')
  - [OtherAmount](#P-AthenaHealth-Sdk-Models-Request-RecordPayment-OtherAmount 'AthenaHealth.Sdk.Models.Request.RecordPayment.OtherAmount')
  - [PaymentMethod](#P-AthenaHealth-Sdk-Models-Request-RecordPayment-PaymentMethod 'AthenaHealth.Sdk.Models.Request.RecordPayment.PaymentMethod')
  - [PostDate](#P-AthenaHealth-Sdk-Models-Request-RecordPayment-PostDate 'AthenaHealth.Sdk.Models.Request.RecordPayment.PostDate')
- [ReminderDetail](#T-AthenaHealth-Sdk-Models-Response-Appointment-ReminderDetail 'AthenaHealth.Sdk.Models.Response.Appointment.ReminderDetail')
  - [CallTime](#P-AthenaHealth-Sdk-Models-Response-Appointment-ReminderDetail-CallTime 'AthenaHealth.Sdk.Models.Response.Appointment.ReminderDetail.CallTime')
  - [MessageResultId](#P-AthenaHealth-Sdk-Models-Response-Appointment-ReminderDetail-MessageResultId 'AthenaHealth.Sdk.Models.Response.Appointment.ReminderDetail.MessageResultId')
  - [MessageType](#P-AthenaHealth-Sdk-Models-Response-Appointment-ReminderDetail-MessageType 'AthenaHealth.Sdk.Models.Response.Appointment.ReminderDetail.MessageType')
  - [Result](#P-AthenaHealth-Sdk-Models-Response-Appointment-ReminderDetail-Result 'AthenaHealth.Sdk.Models.Response.Appointment.ReminderDetail.Result')
- [RescheduleAppointment](#T-AthenaHealth-Sdk-Models-Request-RescheduleAppointment 'AthenaHealth.Sdk.Models.Request.RescheduleAppointment')
  - [AppointmentId](#P-AthenaHealth-Sdk-Models-Request-RescheduleAppointment-AppointmentId 'AthenaHealth.Sdk.Models.Request.RescheduleAppointment.AppointmentId')
  - [IgnoreSchedulablePermission](#P-AthenaHealth-Sdk-Models-Request-RescheduleAppointment-IgnoreSchedulablePermission 'AthenaHealth.Sdk.Models.Request.RescheduleAppointment.IgnoreSchedulablePermission')
  - [NewAppointmentId](#P-AthenaHealth-Sdk-Models-Request-RescheduleAppointment-NewAppointmentId 'AthenaHealth.Sdk.Models.Request.RescheduleAppointment.NewAppointmentId')
  - [NoPatientCase](#P-AthenaHealth-Sdk-Models-Request-RescheduleAppointment-NoPatientCase 'AthenaHealth.Sdk.Models.Request.RescheduleAppointment.NoPatientCase')
  - [PatientId](#P-AthenaHealth-Sdk-Models-Request-RescheduleAppointment-PatientId 'AthenaHealth.Sdk.Models.Request.RescheduleAppointment.PatientId')
  - [ReasonId](#P-AthenaHealth-Sdk-Models-Request-RescheduleAppointment-ReasonId 'AthenaHealth.Sdk.Models.Request.RescheduleAppointment.ReasonId')
  - [RescheduleReason](#P-AthenaHealth-Sdk-Models-Request-RescheduleAppointment-RescheduleReason 'AthenaHealth.Sdk.Models.Request.RescheduleAppointment.RescheduleReason')
- [Response](#T-AthenaHealth-Sdk-Http-Response 'AthenaHealth.Sdk.Http.Response')
  - [Body](#P-AthenaHealth-Sdk-Http-Response-Body 'AthenaHealth.Sdk.Http.Response.Body')
  - [ContentType](#P-AthenaHealth-Sdk-Http-Response-ContentType 'AthenaHealth.Sdk.Http.Response.ContentType')
  - [Headers](#P-AthenaHealth-Sdk-Http-Response-Headers 'AthenaHealth.Sdk.Http.Response.Headers')
  - [StatusCode](#P-AthenaHealth-Sdk-Http-Response-StatusCode 'AthenaHealth.Sdk.Http.Response.StatusCode')
  - [GetObjectContent\`\`1(shouldThrowErrors)](#M-AthenaHealth-Sdk-Http-Response-GetObjectContent``1-System-Boolean- 'AthenaHealth.Sdk.Http.Response.GetObjectContent``1(System.Boolean)')
- [SearchAppointmentRemindersFilter](#T-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter 'AthenaHealth.Sdk.Models.Request.SearchAppointmentRemindersFilter')
  - [#ctor(departmentId,startDate,endDate)](#M-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter-#ctor-System-Int32,System-DateTime,System-DateTime- 'AthenaHealth.Sdk.Models.Request.SearchAppointmentRemindersFilter.#ctor(System.Int32,System.DateTime,System.DateTime)')
  - [EndDate](#P-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter-EndDate 'AthenaHealth.Sdk.Models.Request.SearchAppointmentRemindersFilter.EndDate')
  - [Limit](#P-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter-Limit 'AthenaHealth.Sdk.Models.Request.SearchAppointmentRemindersFilter.Limit')
  - [Offset](#P-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter-Offset 'AthenaHealth.Sdk.Models.Request.SearchAppointmentRemindersFilter.Offset')
  - [ShowDeleted](#P-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter-ShowDeleted 'AthenaHealth.Sdk.Models.Request.SearchAppointmentRemindersFilter.ShowDeleted')
  - [StartDate](#P-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter-StartDate 'AthenaHealth.Sdk.Models.Request.SearchAppointmentRemindersFilter.StartDate')
- [SearchFacilitiesFilter](#T-AthenaHealth-Sdk-Models-Request-SearchFacilitiesFilter 'AthenaHealth.Sdk.Models.Request.SearchFacilitiesFilter')
  - [#ctor(departmentId,name,orderType,patientId)](#M-AthenaHealth-Sdk-Models-Request-SearchFacilitiesFilter-#ctor-System-Int32,System-String,AthenaHealth-Sdk-Models-Enums-OrderTypeEnum,System-Nullable{System-Int32}- 'AthenaHealth.Sdk.Models.Request.SearchFacilitiesFilter.#ctor(System.Int32,System.String,AthenaHealth.Sdk.Models.Enums.OrderTypeEnum,System.Nullable{System.Int32})')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-SearchFacilitiesFilter-DepartmentId 'AthenaHealth.Sdk.Models.Request.SearchFacilitiesFilter.DepartmentId')
  - [Name](#P-AthenaHealth-Sdk-Models-Request-SearchFacilitiesFilter-Name 'AthenaHealth.Sdk.Models.Request.SearchFacilitiesFilter.Name')
  - [OrderType](#P-AthenaHealth-Sdk-Models-Request-SearchFacilitiesFilter-OrderType 'AthenaHealth.Sdk.Models.Request.SearchFacilitiesFilter.OrderType')
  - [PatientId](#P-AthenaHealth-Sdk-Models-Request-SearchFacilitiesFilter-PatientId 'AthenaHealth.Sdk.Models.Request.SearchFacilitiesFilter.PatientId')
- [SearchInsuranceFilter](#T-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter 'AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter')
  - [InsuranceAddress](#P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-InsuranceAddress 'AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter.InsuranceAddress')
  - [InsuranceCity](#P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-InsuranceCity 'AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter.InsuranceCity')
  - [InsurancePhone](#P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-InsurancePhone 'AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter.InsurancePhone')
  - [InsurancePlanName](#P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-InsurancePlanName 'AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter.InsurancePlanName')
  - [InsuranceState](#P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-InsuranceState 'AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter.InsuranceState')
  - [InsuranceZip](#P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-InsuranceZip 'AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter.InsuranceZip')
  - [MemberId](#P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-MemberId 'AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter.MemberId')
  - [ProductType](#P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-ProductType 'AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter.ProductType')
  - [StateOfCoverage](#P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-StateOfCoverage 'AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter.StateOfCoverage')
- [Sentence](#T-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraph.Sentence')
  - [Findings](#P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Findings 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraph.Sentence.Findings')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Name 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraph.Sentence.Name')
  - [Note](#P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Note 'AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraph.Sentence.Note')
- [SetPatientAllergies](#T-AthenaHealth-Sdk-Models-Request-SetPatientAllergies 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies')
  - [Allergies](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergies 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.Allergies')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-DepartmentId 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.DepartmentId')
  - [NoKnownDrugAllergies](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-NoKnownDrugAllergies 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.NoKnownDrugAllergies')
  - [PatientId](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-PatientId 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.PatientId')
  - [SectionNote](#P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-SectionNote 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies.SectionNote')
- [SetPharmacyRequest](#T-AthenaHealth-Sdk-Models-Request-SetPharmacyRequest 'AthenaHealth.Sdk.Models.Request.SetPharmacyRequest')
  - [ClinicalProviderId](#P-AthenaHealth-Sdk-Models-Request-SetPharmacyRequest-ClinicalProviderId 'AthenaHealth.Sdk.Models.Request.SetPharmacyRequest.ClinicalProviderId')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-SetPharmacyRequest-DepartmentId 'AthenaHealth.Sdk.Models.Request.SetPharmacyRequest.DepartmentId')
  - [NcpdpId](#P-AthenaHealth-Sdk-Models-Request-SetPharmacyRequest-NcpdpId 'AthenaHealth.Sdk.Models.Request.SetPharmacyRequest.NcpdpId')
- [SetPrivacyInformation](#T-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation 'AthenaHealth.Sdk.Models.Request.SetPrivacyInformation')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-DepartmentId 'AthenaHealth.Sdk.Models.Request.SetPrivacyInformation.DepartmentId')
  - [ExpirationDate](#P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-ExpirationDate 'AthenaHealth.Sdk.Models.Request.SetPrivacyInformation.ExpirationDate')
  - [InsuredSignature](#P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-InsuredSignature 'AthenaHealth.Sdk.Models.Request.SetPrivacyInformation.InsuredSignature')
  - [PatientSignature](#P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-PatientSignature 'AthenaHealth.Sdk.Models.Request.SetPrivacyInformation.PatientSignature')
  - [PrivacyNotice](#P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-PrivacyNotice 'AthenaHealth.Sdk.Models.Request.SetPrivacyInformation.PrivacyNotice')
  - [ReasonPatientUnableToSign](#P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-ReasonPatientUnableToSign 'AthenaHealth.Sdk.Models.Request.SetPrivacyInformation.ReasonPatientUnableToSign')
  - [SignatureDateTime](#P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-SignatureDateTime 'AthenaHealth.Sdk.Models.Request.SetPrivacyInformation.SignatureDateTime')
  - [SignatureName](#P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-SignatureName 'AthenaHealth.Sdk.Models.Request.SetPrivacyInformation.SignatureName')
  - [SignerRelationshipToPatient](#P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-SignerRelationshipToPatient 'AthenaHealth.Sdk.Models.Request.SetPrivacyInformation.SignerRelationshipToPatient')
- [SnomedIcdCode](#T-AthenaHealth-Sdk-Models-Response-SnomedIcdCode 'AthenaHealth.Sdk.Models.Response.SnomedIcdCode')
  - [Code](#P-AthenaHealth-Sdk-Models-Response-SnomedIcdCode-Code 'AthenaHealth.Sdk.Models.Response.SnomedIcdCode.Code')
  - [CodeSet](#P-AthenaHealth-Sdk-Models-Response-SnomedIcdCode-CodeSet 'AthenaHealth.Sdk.Models.Response.SnomedIcdCode.CodeSet')
  - [Description](#P-AthenaHealth-Sdk-Models-Response-SnomedIcdCode-Description 'AthenaHealth.Sdk.Models.Response.SnomedIcdCode.Description')
  - [Ndc](#P-AthenaHealth-Sdk-Models-Response-SnomedIcdCode-Ndc 'AthenaHealth.Sdk.Models.Response.SnomedIcdCode.Ndc')
- [SocialHistoryTemplate](#T-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate 'AthenaHealth.Sdk.Models.Response.SocialHistoryTemplate')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Id 'AthenaHealth.Sdk.Models.Response.SocialHistoryTemplate.Id')
  - [Questions](#P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Questions 'AthenaHealth.Sdk.Models.Response.SocialHistoryTemplate.Questions')
  - [TemplateName](#P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-TemplateName 'AthenaHealth.Sdk.Models.Response.SocialHistoryTemplate.TemplateName')
- [StatusNote](#T-AthenaHealth-Sdk-Models-Response-Appointment-Claim-StatusNote 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.StatusNote')
  - [Note](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-StatusNote-Note 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.StatusNote.Note')
  - [Status](#P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-StatusNote-Status 'AthenaHealth.Sdk.Models.Response.Appointment.Claim.StatusNote.Status')
- [StatusResponse](#T-AthenaHealth-Sdk-Models-Response-StatusResponse 'AthenaHealth.Sdk.Models.Response.StatusResponse')
  - [ErrorMessage](#P-AthenaHealth-Sdk-Models-Response-StatusResponse-ErrorMessage 'AthenaHealth.Sdk.Models.Response.StatusResponse.ErrorMessage')
- [StructuredSigModel](#T-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.StructuredSigModel')
  - [DosageAction](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageAction 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.StructuredSigModel.DosageAction')
  - [DosageAdditionalInstructions](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageAdditionalInstructions 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.StructuredSigModel.DosageAdditionalInstructions')
  - [DosageDurationUnit](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageDurationUnit 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.StructuredSigModel.DosageDurationUnit')
  - [DosageDurationValue](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageDurationValue 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.StructuredSigModel.DosageDurationValue')
  - [DosageFrequencyBalue](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageFrequencyBalue 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.StructuredSigModel.DosageFrequencyBalue')
  - [DosageFrequencyDescription](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageFrequencyDescription 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.StructuredSigModel.DosageFrequencyDescription')
  - [DosageFrequencyUnit](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageFrequencyUnit 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.StructuredSigModel.DosageFrequencyUnit')
  - [DosageQuantityUnit](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageQuantityUnit 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.StructuredSigModel.DosageQuantityUnit')
  - [DosageQuantityValue](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageQuantityValue 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.StructuredSigModel.DosageQuantityValue')
  - [DosageRoute](#P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageRoute 'AthenaHealth.Sdk.Models.Response.PatientMedication.Medication.StructuredSigModel.DosageRoute')
- [SubscribeToEvent](#T-AthenaHealth-Sdk-Models-Request-SubscribeToEvent 'AthenaHealth.Sdk.Models.Request.SubscribeToEvent')
  - [EventName](#P-AthenaHealth-Sdk-Models-Request-SubscribeToEvent-EventName 'AthenaHealth.Sdk.Models.Request.SubscribeToEvent.EventName')
  - [IncludeReminderCall](#P-AthenaHealth-Sdk-Models-Request-SubscribeToEvent-IncludeReminderCall 'AthenaHealth.Sdk.Models.Request.SubscribeToEvent.IncludeReminderCall')
  - [IncludeSuggestedOverbooking](#P-AthenaHealth-Sdk-Models-Request-SubscribeToEvent-IncludeSuggestedOverbooking 'AthenaHealth.Sdk.Models.Request.SubscribeToEvent.IncludeSuggestedOverbooking')
- [Subscription](#T-AthenaHealth-Sdk-Models-Response-AppointmentSubscriptionEvent-Subscription 'AthenaHealth.Sdk.Models.Response.AppointmentSubscriptionEvent.Subscription')
  - [EventName](#P-AthenaHealth-Sdk-Models-Response-AppointmentSubscriptionEvent-Subscription-EventName 'AthenaHealth.Sdk.Models.Response.AppointmentSubscriptionEvent.Subscription.EventName')
- [Template](#T-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Template 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Template')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Template-Id 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Template.Id')
  - [Name](#P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Template-Name 'AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Template.Name')
- [TopInsurancePackage](#T-AthenaHealth-Sdk-Models-Response-TopInsurancePackage 'AthenaHealth.Sdk.Models.Response.TopInsurancePackage')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-TopInsurancePackage-Id 'AthenaHealth.Sdk.Models.Response.TopInsurancePackage.Id')
  - [InsuranceProductTypeName](#P-AthenaHealth-Sdk-Models-Response-TopInsurancePackage-InsuranceProductTypeName 'AthenaHealth.Sdk.Models.Response.TopInsurancePackage.InsuranceProductTypeName')
- [Transaction](#T-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.Transaction')
  - [Amount](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction-Amount 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.Transaction.Amount')
  - [Date](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction-Date 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.Transaction.Date')
  - [Description](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction-Description 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.Transaction.Description')
  - [EpaymentId](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction-EpaymentId 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.Transaction.EpaymentId')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction-Id 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.Transaction.Id')
  - [TransferType](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction-TransferType 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.Transaction.TransferType')
  - [Type](#P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction-Type 'AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail.Transaction.Type')
- [UnsubscribeFromEvent](#T-AthenaHealth-Sdk-Models-Request-UnsubscribeFromEvent 'AthenaHealth.Sdk.Models.Request.UnsubscribeFromEvent')
  - [EventName](#P-AthenaHealth-Sdk-Models-Request-UnsubscribeFromEvent-EventName 'AthenaHealth.Sdk.Models.Request.UnsubscribeFromEvent.EventName')
  - [IncludeReminderCall](#P-AthenaHealth-Sdk-Models-Request-UnsubscribeFromEvent-IncludeReminderCall 'AthenaHealth.Sdk.Models.Request.UnsubscribeFromEvent.IncludeReminderCall')
  - [IncludeSuggestedOverbooking](#P-AthenaHealth-Sdk-Models-Request-UnsubscribeFromEvent-IncludeSuggestedOverbooking 'AthenaHealth.Sdk.Models.Request.UnsubscribeFromEvent.IncludeSuggestedOverbooking')
- [UpdateInsuranceCardPhoto](#T-AthenaHealth-Sdk-Models-Request-UpdateInsuranceCardPhoto 'AthenaHealth.Sdk.Models.Request.UpdateInsuranceCardPhoto')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-UpdateInsuranceCardPhoto-DepartmentId 'AthenaHealth.Sdk.Models.Request.UpdateInsuranceCardPhoto.DepartmentId')
  - [Image](#P-AthenaHealth-Sdk-Models-Request-UpdateInsuranceCardPhoto-Image 'AthenaHealth.Sdk.Models.Request.UpdateInsuranceCardPhoto.Image')
- [UpdateMedicalHistory](#T-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory 'AthenaHealth.Sdk.Models.Request.UpdateMedicalHistory')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-DepartmentId 'AthenaHealth.Sdk.Models.Request.UpdateMedicalHistory.DepartmentId')
  - [Questions](#P-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-Questions 'AthenaHealth.Sdk.Models.Request.UpdateMedicalHistory.Questions')
  - [SectionNote](#P-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-SectionNote 'AthenaHealth.Sdk.Models.Request.UpdateMedicalHistory.SectionNote')
- [UpdateMedicalHistoryResponse](#T-AthenaHealth-Sdk-Models-Response-UpdateMedicalHistoryResponse 'AthenaHealth.Sdk.Models.Response.UpdateMedicalHistoryResponse')
  - [Error](#P-AthenaHealth-Sdk-Models-Response-UpdateMedicalHistoryResponse-Error 'AthenaHealth.Sdk.Models.Response.UpdateMedicalHistoryResponse.Error')
  - [Success](#P-AthenaHealth-Sdk-Models-Response-UpdateMedicalHistoryResponse-Success 'AthenaHealth.Sdk.Models.Response.UpdateMedicalHistoryResponse.Success')
- [UpdatePatient](#T-AthenaHealth-Sdk-Models-Request-UpdatePatient 'AthenaHealth.Sdk.Models.Request.UpdatePatient')
  - [LookupDepartmentId](#P-AthenaHealth-Sdk-Models-Request-UpdatePatient-LookupDepartmentId 'AthenaHealth.Sdk.Models.Request.UpdatePatient.LookupDepartmentId')
  - [RegisterPatientInDepartment](#P-AthenaHealth-Sdk-Models-Request-UpdatePatient-RegisterPatientInDepartment 'AthenaHealth.Sdk.Models.Request.UpdatePatient.RegisterPatientInDepartment')
- [UpdatePatientResponse](#T-AthenaHealth-Sdk-Models-Response-UpdatePatientResponse 'AthenaHealth.Sdk.Models.Response.UpdatePatientResponse')
  - [PatientId](#P-AthenaHealth-Sdk-Models-Response-UpdatePatientResponse-PatientId 'AthenaHealth.Sdk.Models.Response.UpdatePatientResponse.PatientId')
- [UpdatePhoto](#T-AthenaHealth-Sdk-Models-Request-UpdatePhoto 'AthenaHealth.Sdk.Models.Request.UpdatePhoto')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-UpdatePhoto-DepartmentId 'AthenaHealth.Sdk.Models.Request.UpdatePhoto.DepartmentId')
  - [Image](#P-AthenaHealth-Sdk-Models-Request-UpdatePhoto-Image 'AthenaHealth.Sdk.Models.Request.UpdatePhoto.Image')
- [UpdateSocialHistory](#T-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory 'AthenaHealth.Sdk.Models.Request.UpdateSocialHistory')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-DepartmentId 'AthenaHealth.Sdk.Models.Request.UpdateSocialHistory.DepartmentId')
  - [Questions](#P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-Questions 'AthenaHealth.Sdk.Models.Request.UpdateSocialHistory.Questions')
  - [SectionNote](#P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-SectionNote 'AthenaHealth.Sdk.Models.Request.UpdateSocialHistory.SectionNote')
- [UpdateSocialHistoryResponse](#T-AthenaHealth-Sdk-Models-Response-UpdateSocialHistoryResponse 'AthenaHealth.Sdk.Models.Response.UpdateSocialHistoryResponse')
  - [Error](#P-AthenaHealth-Sdk-Models-Response-UpdateSocialHistoryResponse-Error 'AthenaHealth.Sdk.Models.Response.UpdateSocialHistoryResponse.Error')
  - [Success](#P-AthenaHealth-Sdk-Models-Response-UpdateSocialHistoryResponse-Success 'AthenaHealth.Sdk.Models.Response.UpdateSocialHistoryResponse.Success')
- [UpdateSocialHistoryTemplates](#T-AthenaHealth-Sdk-Models-Request-UpdateSocialHistoryTemplates 'AthenaHealth.Sdk.Models.Request.UpdateSocialHistoryTemplates')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistoryTemplates-DepartmentId 'AthenaHealth.Sdk.Models.Request.UpdateSocialHistoryTemplates.DepartmentId')
  - [TemplateIds](#P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistoryTemplates-TemplateIds 'AthenaHealth.Sdk.Models.Request.UpdateSocialHistoryTemplates.TemplateIds')
- [UpdateSocialHistoryTemplatesResponse](#T-AthenaHealth-Sdk-Models-Response-UpdateSocialHistoryTemplatesResponse 'AthenaHealth.Sdk.Models.Response.UpdateSocialHistoryTemplatesResponse')
  - [Error](#P-AthenaHealth-Sdk-Models-Response-UpdateSocialHistoryTemplatesResponse-Error 'AthenaHealth.Sdk.Models.Response.UpdateSocialHistoryTemplatesResponse.Error')
  - [Success](#P-AthenaHealth-Sdk-Models-Response-UpdateSocialHistoryTemplatesResponse-Success 'AthenaHealth.Sdk.Models.Response.UpdateSocialHistoryTemplatesResponse.Success')
- [UrlBuilder](#T-AthenaHealth-Sdk-Http-Helpers-UrlBuilder 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder')
  - [BuildUri(url,queryParameters,port)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-String,System-Object,System-Int32- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUri(System.String,System.Object,System.Int32)')
  - [BuildUri(url,queryParameters)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-String,System-Object- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUri(System.String,System.Object)')
  - [BuildUri(uri,queryParameters,port)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-Uri,System-Object,System-Int32- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUri(System.Uri,System.Object,System.Int32)')
  - [BuildUri(uri,queryParameters)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-Uri,System-Object- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUri(System.Uri,System.Object)')
  - [BuildUri(url,queryParameters,port)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-String,System-Collections-Generic-IDictionary{System-String,System-String},System-Int32- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUri(System.String,System.Collections.Generic.IDictionary{System.String,System.String},System.Int32)')
  - [BuildUri(url,queryParameters)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-String,System-Collections-Generic-IDictionary{System-String,System-String}- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUri(System.String,System.Collections.Generic.IDictionary{System.String,System.String})')
  - [BuildUri(uri,queryParameters,port)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-Uri,System-Collections-Generic-IDictionary{System-String,System-String},System-Int32- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUri(System.Uri,System.Collections.Generic.IDictionary{System.String,System.String},System.Int32)')
  - [BuildUri(uri,queryParameters)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-Uri,System-Collections-Generic-IDictionary{System-String,System-String}- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUri(System.Uri,System.Collections.Generic.IDictionary{System.String,System.String})')
  - [BuildUrl(url,queryParameters,port)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-String,System-Object,System-Int32- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUrl(System.String,System.Object,System.Int32)')
  - [BuildUrl(url,queryParameters)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-String,System-Object- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUrl(System.String,System.Object)')
  - [BuildUrl(uri,queryParameters,port)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-Uri,System-Object,System-Int32- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUrl(System.Uri,System.Object,System.Int32)')
  - [BuildUrl(uri,queryParameters)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-Uri,System-Object- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUrl(System.Uri,System.Object)')
  - [BuildUrl(url,queryParameters,port)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-String,System-Collections-Generic-IDictionary{System-String,System-String},System-Int32- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUrl(System.String,System.Collections.Generic.IDictionary{System.String,System.String},System.Int32)')
  - [BuildUrl(url,queryParameters)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-String,System-Collections-Generic-IDictionary{System-String,System-String}- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUrl(System.String,System.Collections.Generic.IDictionary{System.String,System.String})')
  - [BuildUrl(uri,queryParameters,port)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-Uri,System-Collections-Generic-IDictionary{System-String,System-String},System-Int32- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUrl(System.Uri,System.Collections.Generic.IDictionary{System.String,System.String},System.Int32)')
  - [BuildUrl(uri,queryParameters)](#M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-Uri,System-Collections-Generic-IDictionary{System-String,System-String}- 'AthenaHealth.Sdk.Http.Helpers.UrlBuilder.BuildUrl(System.Uri,System.Collections.Generic.IDictionary{System.String,System.String})')
- [WaitListItem](#T-AthenaHealth-Sdk-Models-Response-WaitListItem 'AthenaHealth.Sdk.Models.Response.WaitListItem')
  - [AppointmentId](#P-AthenaHealth-Sdk-Models-Response-WaitListItem-AppointmentId 'AthenaHealth.Sdk.Models.Response.WaitListItem.AppointmentId')
  - [AppointmentTypeId](#P-AthenaHealth-Sdk-Models-Response-WaitListItem-AppointmentTypeId 'AthenaHealth.Sdk.Models.Response.WaitListItem.AppointmentTypeId')
  - [Created](#P-AthenaHealth-Sdk-Models-Response-WaitListItem-Created 'AthenaHealth.Sdk.Models.Response.WaitListItem.Created')
  - [DayOfWeekIds](#P-AthenaHealth-Sdk-Models-Response-WaitListItem-DayOfWeekIds 'AthenaHealth.Sdk.Models.Response.WaitListItem.DayOfWeekIds')
  - [DepartmentId](#P-AthenaHealth-Sdk-Models-Response-WaitListItem-DepartmentId 'AthenaHealth.Sdk.Models.Response.WaitListItem.DepartmentId')
  - [HourFrom](#P-AthenaHealth-Sdk-Models-Response-WaitListItem-HourFrom 'AthenaHealth.Sdk.Models.Response.WaitListItem.HourFrom')
  - [HourTo](#P-AthenaHealth-Sdk-Models-Response-WaitListItem-HourTo 'AthenaHealth.Sdk.Models.Response.WaitListItem.HourTo')
  - [Id](#P-AthenaHealth-Sdk-Models-Response-WaitListItem-Id 'AthenaHealth.Sdk.Models.Response.WaitListItem.Id')
  - [Note](#P-AthenaHealth-Sdk-Models-Response-WaitListItem-Note 'AthenaHealth.Sdk.Models.Response.WaitListItem.Note')
  - [PatientId](#P-AthenaHealth-Sdk-Models-Response-WaitListItem-PatientId 'AthenaHealth.Sdk.Models.Response.WaitListItem.PatientId')
  - [Priority](#P-AthenaHealth-Sdk-Models-Response-WaitListItem-Priority 'AthenaHealth.Sdk.Models.Response.WaitListItem.Priority')
  - [ProviderId](#P-AthenaHealth-Sdk-Models-Response-WaitListItem-ProviderId 'AthenaHealth.Sdk.Models.Response.WaitListItem.ProviderId')

<a name='T-AthenaHealth-Sdk-Models-Request-AddDocument'></a>
## AddDocument `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-AddDocument-ActionNote'></a>
### ActionNote `property`

##### Summary

Any note to accompany the creation of this document.

<a name='P-AthenaHealth-Sdk-Models-Request-AddDocument-AppointmentId'></a>
### AppointmentId `property`

##### Summary

The appointment ID associated with this document, for certain document classes. These can
only be uploaded AFTER check-in. The department ID is looked up from the appointment.
(Department ID takes precedence if both are supplied.)

<a name='P-AthenaHealth-Sdk-Models-Request-AddDocument-Attachment'></a>
### Attachment `property`

##### Summary

The file that will become the document. PDFs are recommended. Generally, this implies
that this is a multipart/form-data content-type submission. This does NOT work correctly
in I/O Docs. The filename itself is not used by athenaNet, but it is required to be sent.

<a name='P-AthenaHealth-Sdk-Models-Request-AddDocument-AutoClose'></a>
### AutoClose `property`

##### Summary

Documents will, normally, automatically appear in the clinical inbox for providers to
review. In some cases, you might want to force the document to skip the clinical inbox,
and go directly to the patient chart with a "closed" status. For that case, set this to true.

<a name='P-AthenaHealth-Sdk-Models-Request-AddDocument-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The department ID associated with the uploaded document. Except when appointmentid is
supplied, this is required.

<a name='P-AthenaHealth-Sdk-Models-Request-AddDocument-DocumentSubclass'></a>
### DocumentSubclass `property`

##### Summary

The document subclass.

<a name='P-AthenaHealth-Sdk-Models-Request-AddDocument-InternalNote'></a>
### InternalNote `property`

##### Summary

The 'Internal Note' attached to this document

<a name='P-AthenaHealth-Sdk-Models-Request-AddDocument-ProviderId'></a>
### ProviderId `property`

##### Summary

The provider ID attached to this document. This populates the provider name field.

<a name='T-AthenaHealth-Sdk-Models-Response-AddMedication'></a>
## AddMedication `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-AddMedication-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenanet department ID

<a name='P-AthenaHealth-Sdk-Models-Response-AddMedication-IsHidden'></a>
### IsHidden `property`

##### Summary

Set whether the medication is hidden in the UI.

<a name='P-AthenaHealth-Sdk-Models-Response-AddMedication-MedicationId'></a>
### MedicationId `property`

##### Summary

The athena medication ID

<a name='P-AthenaHealth-Sdk-Models-Response-AddMedication-PatientNote'></a>
### PatientNote `property`

##### Summary

A patient-facing note

<a name='P-AthenaHealth-Sdk-Models-Response-AddMedication-ProviderNote'></a>
### ProviderNote `property`

##### Summary

An internal note

<a name='P-AthenaHealth-Sdk-Models-Response-AddMedication-StartDate'></a>
### StartDate `property`

##### Summary

Start date for this medication

<a name='P-AthenaHealth-Sdk-Models-Response-AddMedication-StopDate'></a>
### StopDate `property`

##### Summary

Stop date for this medication

<a name='P-AthenaHealth-Sdk-Models-Response-AddMedication-StopReason'></a>
### StopReason `property`

##### Summary

The reason the medication was stopped. If set, it it recommended but not required that a stop date is also set.

<a name='P-AthenaHealth-Sdk-Models-Response-AddMedication-UnstructuredSig'></a>
### UnstructuredSig `property`

##### Summary

Can only be used to update historical (entered, downloaded, etc) medications. Will override a structured sig if there is one.

<a name='T-AthenaHealth-Sdk-Models-Request-AddProblem'></a>
## AddProblem `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-AddProblem-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department id.

<a name='P-AthenaHealth-Sdk-Models-Request-AddProblem-Laterality'></a>
### Laterality `property`

##### Summary

Update the laterality of this problem. Can be null, LEFT, RIGHT, or BILATERAL.

<a name='P-AthenaHealth-Sdk-Models-Request-AddProblem-Note'></a>
### Note `property`

##### Summary

The note to be attached to this problem.

<a name='P-AthenaHealth-Sdk-Models-Request-AddProblem-SnomedCode'></a>
### SnomedCode `property`

##### Summary

The SNOMED code of the problem you are adding.

<a name='P-AthenaHealth-Sdk-Models-Request-AddProblem-StartDate'></a>
### StartDate `property`

##### Summary

The onset date to be updated for this problem in MM/DD/YYYY format.

<a name='P-AthenaHealth-Sdk-Models-Request-AddProblem-Status'></a>
### Status `property`

##### Summary

Whether the problem is chronic or acute.

<a name='T-AthenaHealth-Sdk-Models-Response-AddProblemResponse'></a>
## AddProblemResponse `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-AddProblemResponse-ErrorMessage'></a>
### ErrorMessage `property`

##### Summary

If the operation failed, this will contain any error messages.

<a name='P-AthenaHealth-Sdk-Models-Response-AddProblemResponse-ProblemId'></a>
### ProblemId `property`

##### Summary

If successful, the athena ID of the newly created problem

<a name='P-AthenaHealth-Sdk-Models-Response-AddProblemResponse-Success'></a>
### Success `property`

##### Summary

Whether the operation was successful or not.

<a name='T-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest'></a>
## AddToWaitListRequest `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='M-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-#ctor-System-Int32-'></a>
### #ctor(patientId) `constructor`

##### Summary

[DepartmentId](#P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-DepartmentId 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest.DepartmentId') not required. Automatically sets [AllowAnyDepartment](#P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-AllowAnyDepartment 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest.AllowAnyDepartment') to true.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-AllowAnyDepartment'></a>
### AllowAnyDepartment `property`

##### Summary

While a department is required when creating a wait list entry, this flag indicates that any department is acceptable for an appointment.

<a name='P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-AppointmentId'></a>
### AppointmentId `property`

##### Summary

The booked appointment ID of the appointment that this wait list entry would replace.

<a name='P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-AppointmentTypeId'></a>
### AppointmentTypeId `property`

##### Summary

The appointment type ID of the desired appointment.

<a name='P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-DayOfWeekIds'></a>
### DayOfWeekIds `property`

##### Summary

A list of day of week IDs that are desired by the patient, with 1 being Sunday, and 7 being Saturday.

<a name='P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The department ID of the desired department.
This can be blank if any department is acceptable.

<a name='P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-HourFrom'></a>
### HourFrom `property`

##### Summary

The hour (24 hour clock) after which an appointment is desired by a patient.  Inclusive.

<a name='P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-HourTo'></a>
### HourTo `property`

##### Summary

The hour (24 hour clock) before which an appointment is desired by a patient.  Inclusive.

<a name='P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-Note'></a>
### Note `property`

##### Summary

Practice-facing note about why the wait list entry exists.

<a name='P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-PatientId'></a>
### PatientId `property`

##### Summary

The patient ID of the patient who is on the wait list.

<a name='P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-Priority'></a>
### Priority `property`

##### Summary

Indicating the priority of this wait list entry.

<a name='P-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-ProviderId'></a>
### ProviderId `property`

##### Summary

The provider ID of the desired provider.  This can be blank if any provider is acceptable.

<a name='T-AthenaHealth-Sdk-Models-Response-AddToWaitListResponse'></a>
## AddToWaitListResponse `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-AddToWaitListResponse-WaitListId'></a>
### WaitListId `property`

##### Summary

The ID of the wait list entry that was created.

<a name='T-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy'></a>
## Allergy `type`

##### Namespace

AthenaHealth.Sdk.Models.Request.SetPatientAllergies

<a name='T-AthenaHealth-Sdk-Models-Response-Allergy'></a>
## Allergy `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='T-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy'></a>
## Allergy `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.PatientAllergy

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-AllergenName'></a>
### AllergenName `property`

##### Summary

The name of the allergen.

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-DeactivateDate'></a>
### DeactivateDate `property`

##### Summary

Date of allergy deactivation. Set to deactivate the allergy

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Id'></a>
### Id `property`

##### Summary

Athena ID for this allergen.

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Note'></a>
### Note `property`

##### Summary

Note about this allergy

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-OnsetDate'></a>
### OnsetDate `property`

##### Summary

Date of allergy onset

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Reactions'></a>
### Reactions `property`

##### Summary

List of documented reactions

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-ReactivateDate'></a>
### ReactivateDate `property`

##### Summary

Date of allergy reactivation. Set to reactivate the allergy

<a name='P-AthenaHealth-Sdk-Models-Response-Allergy-Id'></a>
### Id `property`

##### Summary

The athena ID of the allergen.

<a name='P-AthenaHealth-Sdk-Models-Response-Allergy-Name'></a>
### Name `property`

##### Summary

The name of the allergen.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-AllergenId'></a>
### AllergenId `property`

##### Summary

Athena ID for this allergen.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-AllergenName'></a>
### AllergenName `property`

##### Summary

The name of the allergen.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-DeactivateDate'></a>
### DeactivateDate `property`

##### Summary

Date of allergy deactivation. Set to deactivate the allergy

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-DeactivatedUser'></a>
### DeactivatedUser `property`

##### Summary

The name of the user who deactivated the allergy.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-LastModifiedBy'></a>
### LastModifiedBy `property`

##### Summary

The username of the user who last modified this allergy.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-LastModifiedDateTime'></a>
### LastModifiedDateTime `property`

##### Summary

The date and time the allergy was last modified.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-Note'></a>
### Note `property`

##### Summary

Note about this allergy

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-OnsetDate'></a>
### OnsetDate `property`

##### Summary

Date of allergy onset

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-Reactions'></a>
### Reactions `property`

##### Summary

List of documented reactions

<a name='T-AthenaHealth-Sdk-Models-Response-Analyte'></a>
## Analyte `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='T-AthenaHealth-Sdk-Models-Response-LabResult-Analyte'></a>
## Analyte `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.LabResult

<a name='P-AthenaHealth-Sdk-Models-Response-Analyte-AbnormalFlag'></a>
### AbnormalFlag `property`

##### Summary

Status indicator of the measurement relative to normal (low, high, normal, abnormal)

<a name='P-AthenaHealth-Sdk-Models-Response-Analyte-AbnormalHL7Code'></a>
### AbnormalHL7Code `property`

##### Summary

The HL7 code related to the abnormal flag.

<a name='P-AthenaHealth-Sdk-Models-Response-Analyte-AbnormalHL7Name'></a>
### AbnormalHL7Name `property`

##### Summary

The HL7 description related to the abnormal flag.

<a name='P-AthenaHealth-Sdk-Models-Response-Analyte-AnalyteDate'></a>
### AnalyteDate `property`

##### Summary

Date when this observation was recorded

<a name='P-AthenaHealth-Sdk-Models-Response-Analyte-AnalyteId'></a>
### AnalyteId `property`

##### Summary

Athena ID for the given lab result observation/analyte

<a name='P-AthenaHealth-Sdk-Models-Response-Analyte-AnalyteName'></a>
### AnalyteName `property`

##### Summary

Name / description specific to this analyte

<a name='P-AthenaHealth-Sdk-Models-Response-Analyte-Description'></a>
### Description `property`

##### Summary

General description of the lab result test

<a name='P-AthenaHealth-Sdk-Models-Response-Analyte-LOINC'></a>
### LOINC `property`

##### Summary

Logical Observation Identifiers Names and Codes ID, if available

<a name='P-AthenaHealth-Sdk-Models-Response-Analyte-LabResultStatus'></a>
### LabResultStatus `property`

##### Summary

The status of the underlying lab result

<a name='P-AthenaHealth-Sdk-Models-Response-Analyte-Note'></a>
### Note `property`

##### Summary

Additional note for this analyte, if applicable

<a name='P-AthenaHealth-Sdk-Models-Response-Analyte-ReferenceRange'></a>
### ReferenceRange `property`

##### Summary

Reference range of values accepted as normal for this observation

<a name='P-AthenaHealth-Sdk-Models-Response-Analyte-ResultStatus'></a>
### ResultStatus `property`

##### Summary

The status of the result (e.g., "final", "preliminary", "corrected", etc.)

<a name='P-AthenaHealth-Sdk-Models-Response-Analyte-Units'></a>
### Units `property`

##### Summary

Units for this analyte entry, if provided by the lab

<a name='P-AthenaHealth-Sdk-Models-Response-Analyte-Value'></a>
### Value `property`

##### Summary

Value recorded for this observation

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-AbnormalFlag'></a>
### AbnormalFlag `property`

##### Summary

Status indicator of the measurement relative to normal (low, high, normal, abnormal)

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-AbnormalHL7Code'></a>
### AbnormalHL7Code `property`

##### Summary

The HL7 code related to the abnormal flag.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-AbnormalHL7Name'></a>
### AbnormalHL7Name `property`

##### Summary

The HL7 description related to the abnormal flag.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-AnalyteDate'></a>
### AnalyteDate `property`

##### Summary

Date when this observation was recorded

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-AnalyteDateTime'></a>
### AnalyteDateTime `property`

##### Summary

The date and time when this observation was recorded. Returned in mm/dd/yyyy
hh24:mi:ss format.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-AnalyteId'></a>
### AnalyteId `property`

##### Summary

Athena ID for the given lab result observation/analyte

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-AnalyteName'></a>
### AnalyteName `property`

##### Summary

Name / description specific to this analyte

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-Description'></a>
### Description `property`

##### Summary

General description of the lab result test

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-LOINC'></a>
### LOINC `property`

##### Summary

Logical Observation Identifiers Names and Codes ID, if available

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-Note'></a>
### Note `property`

##### Summary

Additional note for this analyte, if applicable

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-ReferenceRange'></a>
### ReferenceRange `property`

##### Summary

Reference range of values accepted as normal for this observation

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-ResultStatus'></a>
### ResultStatus `property`

##### Summary

The status of the result (e.g., "final", "preliminary", "corrected", etc.)

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-Units'></a>
### Units `property`

##### Summary

Units for this analyte entry, if provided by the lab

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Analyte-Value'></a>
### Value `property`

##### Summary

Value recorded for this observation

<a name='T-AthenaHealth-Sdk-Models-Response-Appointment'></a>
## Appointment `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentConfirmationId'></a>
### AppointmentConfirmationId `property`

##### Summary

If there is an appointment confirmation result for this appointment, the numeric ID (global to athenaNet).

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentConfirmationName'></a>
### AppointmentConfirmationName `property`

##### Summary

If there is an appointment confirmation result for this appointment, the name (global to athenaNet).

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentCopay'></a>
### AppointmentCopay `property`

##### Summary

Detailed information about the copay for this appointment.  Gives more detail than the COPAY field.  Note: this information is not yet available in all practices, we are rolling this out slowly.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentNotes'></a>
### AppointmentNotes `property`

##### Summary

An array of appointment notes for this appointment.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentStatus'></a>
### AppointmentStatus `property`

##### Summary

The athenaNet appointment status. There are several possible statuses.  x=cancelled. f=future. (It can include appointments where were never checked in, even if the appointment date is in the past. It is up to a practice to cancel appointments as a no show when appropriate to do so.)  o=open. 2=checked in. 3=checked out. 4=charge entered (i.e. a past appointment).

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-CancelReasonId'></a>
### CancelReasonId `property`

##### Summary

If the appointment was cancelled, the numeric ID (local to the practice) for the cancel reason.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-CancelReasonName'></a>
### CancelReasonName `property`

##### Summary

If the appointment was cancelled, the name (local to the practice) for the cancel reason.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-CancelReasonNoShow'></a>
### CancelReasonNoShow `property`

##### Summary

If the appointment was cancelled, if the cancel reason is marked as a no show reason.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-CancelReasonSlotAvailable'></a>
### CancelReasonSlotAvailable `property`

##### Summary

If the appointment was cancelled, if the cancel reason is marked as a slot available reason.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-CancelledBy'></a>
### CancelledBy `property`

##### Summary

If the appointment has been cancelled, the username who cancelled the appointment.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-CancelledDateTime'></a>
### CancelledDateTime `property`

##### Summary

The time (mm/dd/yyyy hh24:mi:ss; Eastern time) that this appointment was cancelled (if cancelled)

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-ChargeEntryNotRequired'></a>
### ChargeEntryNotRequired `property`

##### Summary

This field will tell if an appointment has been marked as not requiring change entry.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-ChargeEntryNotRequiredReason'></a>
### ChargeEntryNotRequiredReason `property`

##### Summary

This field will give the reason that an appointment has been marked as not requiring charge entry.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-CheckInDateTime'></a>
### CheckInDateTime `property`

##### Summary

The time (mm/dd/yyyy hh24:mi:ss) that the appointment was checked in.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-CheckoutDateTime'></a>
### CheckoutDateTime `property`

##### Summary

The time (mm/dd/yyyy hh24:mi:ss) that the appointment was checked out.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claims'></a>
### Claims `property`

##### Summary

As detailed in /claims, if requested.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-CoordinatorEnterprise'></a>
### CoordinatorEnterprise `property`

##### Summary

If true, the appointment was booked through athenaCoordinator Enterprise.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Copay'></a>
### Copay `property`

##### Summary

Expected copay for this appointment. Based on the appointment type, the patient's primary insurance, and any copays collected.  To see the amounts used in this calculated value, see the APPOINTMENTCOPAY fields.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-EncounterId'></a>
### EncounterId `property`

##### Summary

The encounter id associated with this appointment, useful for certain other calls. Only present for appointments with Clinicals that have been checked in.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-EncounterPrep'></a>
### EncounterPrep `property`

##### Summary

If true, encounter prep has been started for the encounter associated with this appointment.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-EncounterState'></a>
### EncounterState `property`

##### Summary

The status of the clinical encounter associated with this appointment (OPEN, CLOSED, DELETED, PEND, etc.). This differs from encounterstatus, which refers to the status of the patient in the encounter.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-EncounterStatus'></a>
### EncounterStatus `property`

##### Summary

The status of this patient in the encounter (READYFORSTAFF, WITHSTAFF, READFORPROVIDER, CHECKEDOUT). Only present for appointments with Clinicals that have been checked in.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Hl7ProviderId'></a>
### Hl7ProviderId `property`

##### Summary

This is the raw provider ID that should be used ONLY if using this appointment in conjunction with an HL7 message and with athenahealth's prior guidance. It is only available in some situations.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Insurances'></a>
### Insurances `property`

##### Summary

List of active patient insurance packages. Only shown for single or multiple booked appointments if SHOWINSURANCE is set.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-LastModified'></a>
### LastModified `property`

##### Summary

The date/time when the appointment was last modified. Note: It may be possible for the lastmodified field to be updated without any other field in the API call being changed. This occurs when appointment fields not included in the API output are updated.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-LastModifiedBy'></a>
### LastModifiedBy `property`

##### Summary

The user who last modified the appointment.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Patient'></a>
### Patient `property`

##### Summary

See /patients for details

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-PatientId'></a>
### PatientId `property`

##### Summary

The athenaNet patient ID for this appointment

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-PatientLocationId'></a>
### PatientLocationId `property`

##### Summary

The location of the patient. See /patientlocation for practice list. Only present for appointments with Clinicals that have been checked in.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-ReferringProviderId'></a>
### ReferringProviderId `property`

##### Summary

The referring provider ID.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-ReminderDetails'></a>
### ReminderDetails `property`

##### Summary

Detailed ReminderCall information made for this appointment.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-RescheduledAppointmentId'></a>
### RescheduledAppointmentId `property`

##### Summary

When an appointment is rescheduled, this is the ID of the replacement appointment.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-ScheduledBy'></a>
### ScheduledBy `property`

##### Summary

The username who scheduled the appointment.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-ScheduledDateTime'></a>
### ScheduledDateTime `property`

##### Summary

The time (mm/dd/yyyy hh24:mi:ss; Eastern time) that this appointment was scheduled.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-StartCheckIn'></a>
### StartCheckIn `property`

##### Summary

The timestamp when the appointment started the check in process. If this is set while an appointment is still in status 'f', it means that the check-in process has begun but is not yet completed.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-StartCheckOutDateTime'></a>
### StartCheckOutDateTime `property`

##### Summary

The time (mm/dd/yyyy hh24:mi:ss) that the appointment check-out was started.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-StopCheckIn'></a>
### StopCheckIn `property`

##### Summary

The timestamp when the check-in process was finished for this appointment.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-StopExamDateTime'></a>
### StopExamDateTime `property`

##### Summary

The time (mm/dd/yyyy hh24:mi:ss) that the exam was completed.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-StopIntakeDateTime'></a>
### StopIntakeDateTime `property`

##### Summary

The time (mm/dd/yyyy hh24:mi:ss) that the intake process was completed.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-SuggestedOverBooking'></a>
### SuggestedOverBooking `property`

##### Summary

High risk score for Smart Scheduling

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-SupervisingProviderId'></a>
### SupervisingProviderId `property`

##### Summary

The supervising provider ID.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-TemplateAppointmentId'></a>
### TemplateAppointmentId `property`

##### Summary

The original appointment ID. This is useful if an appointment has been cancelled and you want to find the original ID.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-TemplateAppointmentTypeId'></a>
### TemplateAppointmentTypeId `property`

##### Summary

The original appointment type for this slot. This can change for generic appointments.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Urgent'></a>
### Urgent `property`

##### Summary

Urgent flag for the appointment.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-UseExpectedProcedureCodes'></a>
### UseExpectedProcedureCodes `property`

##### Summary

An array of expected procedure codes attached to this appointment.

<a name='T-AthenaHealth-Sdk-Models-Response-AppointmentBase'></a>
## AppointmentBase `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentBase-AppointmentType'></a>
### AppointmentType `property`

##### Summary

The practice-friendly (not patient friendly) name for this appointment type.  Note that this may not be the same as the booked appointment because of "generic" slots.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentBase-AppointmentTypeId'></a>
### AppointmentTypeId `property`

##### Summary

This is the ID for the appointment type.   Note that this may not be the same as the booked appointment because of "generic" slots.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentBase-Date'></a>
### Date `property`

##### Summary

The appointment date.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentBase-DepartmentId'></a>
### DepartmentId `property`

##### Summary



<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentBase-Duration'></a>
### Duration `property`

##### Summary

In minutes

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentBase-Frozen'></a>
### Frozen `property`

##### Summary

If true, this appointment slot is frozen

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentBase-Id'></a>
### Id `property`

##### Summary

Appointment ID of the booked appointment

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentBase-PatientAppointmentTypeName'></a>
### PatientAppointmentTypeName `property`

##### Summary

The patient-friendly name for this appointment type.  Note that this may not be the same as the booked appointment because of "generic" slots.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentBase-ProviderId'></a>
### ProviderId `property`

##### Summary



<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentBase-ReasonId'></a>
### ReasonId `property`

##### Summary

A list of reason IDs that could be used for this slot.  Only present if multiple reason IDs are requested.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentBase-RenderingProviderId'></a>
### RenderingProviderId `property`

##### Summary

The rendering provider ID.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentBase-StartTime'></a>
### StartTime `property`

##### Summary

As HH:MM (where HH is the 0-23 hour and MM is the minute).  This time is local to the department.

<a name='T-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentCopayModel'></a>
## AppointmentCopayModel `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Appointment

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentCopayModel-CollectedForAppointment'></a>
### CollectedForAppointment `property`

##### Summary

Copay payments that have already been collected for this specific appointment.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentCopayModel-CollectedForOther'></a>
### CollectedForOther `property`

##### Summary

Copay payments that have already been collected for this patient, but that have not yet been applied to any specific appointment.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentCopayModel-InsuranceCopay'></a>
### InsuranceCopay `property`

##### Summary

The expected copay based on the patient's primary insurancefinsur and appointment type.

<a name='T-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentNote'></a>
## AppointmentNote `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Appointment

<a name='T-AthenaHealth-Sdk-Models-Response-AppointmentNote'></a>
## AppointmentNote `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentNote-DisplayOnSchedule'></a>
### DisplayOnSchedule `property`

##### Summary

Whether the note should be displayed on the schedule.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentNote-Id'></a>
### Id `property`

##### Summary

The id of the appointment note.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-AppointmentNote-Text'></a>
### Text `property`

##### Summary

The note associated with the appointment.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentNote-CreatedAt'></a>
### CreatedAt `property`

##### Summary

The time this note was created (mm/dd/yyyy hh24:mi:ss).

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentNote-CreatedBy'></a>
### CreatedBy `property`

##### Summary

The user that created this note.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentNote-DeletedAt'></a>
### DeletedAt `property`

##### Summary

The time this note was deleted (mm/dd/yyyy hh24:mi:ss). Not present if not deleted.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentNote-DeletedBy'></a>
### DeletedBy `property`

##### Summary

If deleted, the username who deleted this note.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentNote-DisplayOnSchedule'></a>
### DisplayOnSchedule `property`

##### Summary

Determines if an appointment note displays on the homepage schedule view.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentNote-Id'></a>
### Id `property`

##### Summary

The ID for this note, for use with DELETE and PUT calls.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentNote-Text'></a>
### Text `property`

##### Summary

The text of the note itself.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentNote-UpdatedAt'></a>
### UpdatedAt `property`

##### Summary

The time this note was updated (mm/dd/yyyy hh24:mi:ss), if the note has been updated.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentNote-UpdatedBy'></a>
### UpdatedBy `property`

##### Summary

If the note has been modified, the username who last modified this note.

<a name='T-AthenaHealth-Sdk-Models-Response-AppointmentReason'></a>
## AppointmentReason `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReason-Description'></a>
### Description `property`

##### Summary

The patient-friendly name to accompany the reason.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReason-Id'></a>
### Id `property`

##### Summary

The ID for this reason.  Used to request open appointment slots.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReason-Reason'></a>
### Reason `property`

##### Summary

The patient-friendly reason used to select an appointment type. This is meant to assist the patient in narrowing down what type of appointment should be selected and, in athenaNet, maps to the appropriate appointment type for a particular department/provider combination.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReason-ReasonType'></a>
### ReasonType `property`

##### Summary

Appointment reasons can be for new patients, existing patients, or all. Values are "new", "existing", or "all".

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReason-SchedulingMaxDays'></a>
### SchedulingMaxDays `property`

##### Summary

The maximum number of days before an appointment that a patient can schedule for a specific practice.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReason-SchedulingMinHours'></a>
### SchedulingMinHours `property`

##### Summary

The minimum number of hours before an appointment that a patient can schedule or cancel for a specific practice.

<a name='T-AthenaHealth-Sdk-Models-Response-AppointmentReminder'></a>
## AppointmentReminder `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-AppointmentTypeId'></a>
### AppointmentTypeId `property`

##### Summary

The athenaNet appointment type ID.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-ApproximateDate'></a>
### ApproximateDate `property`

##### Summary

The approximate date on which an appointment for this reminder should be scheduled.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-DeletedAt'></a>
### DeletedAt `property`

##### Summary

If set, the date on which this reminder was deleted.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department ID.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-Id'></a>
### Id `property`

##### Summary

The athenaNet appointment reminder ID.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-Note'></a>
### Note `property`

##### Summary

Free-text notes entered by the practice about this reminder.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-PatientId'></a>
### PatientId `property`

##### Summary

The athenaNet patient ID.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-PatientInstructions'></a>
### PatientInstructions `property`

##### Summary

Free-text instructions for the patient entered by the practice for this reminder.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-ProviderId'></a>
### ProviderId `property`

##### Summary

The athenaNet provider ID.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentReminder-Status'></a>
### Status `property`

##### Summary

Status of the reminder.

<a name='T-AthenaHealth-Sdk-Models-Response-AppointmentSlot'></a>
## AppointmentSlot `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentSlot-LocalProviderId'></a>
### LocalProviderId `property`

##### Summary

The local athenaNet ID for the provider of the appointment.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentSlot-ValidAppointmentTypeIds'></a>
### ValidAppointmentTypeIds `property`

##### Summary

A list of Appointment Type IDs that are valid to be booked in this slot. This will only be included if "New Schedule Admin" is enabled for the practice.

<a name='T-AthenaHealth-Sdk-Models-Response-AppointmentSlotCreationResponse'></a>
## AppointmentSlotCreationResponse `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentSlotCreationResponse-AppointmentIds'></a>
### AppointmentIds `property`

##### Summary

An hash of appointment IDs to the time requested.
Key - contains Id of created slot
Value - contains time of created slot

<a name='T-AthenaHealth-Sdk-Models-Response-AppointmentSubscriptionEvent'></a>
## AppointmentSubscriptionEvent `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentSubscriptionEvent-Status'></a>
### Status `property`

##### Summary

Will return one of following statuses: ACTIVE, INACTIVE, or PARTIAL. The PARTIAL status
means that not all events are subscribed to. In the event of a problem, UNKNOWN may be returned.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentSubscriptionEvent-Subscriptions'></a>
### Subscriptions `property`

##### Summary

List of events you are subscribed to.

<a name='T-AthenaHealth-Sdk-Models-Response-AppointmentType'></a>
## AppointmentType `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentType-BlockSchedule'></a>
### BlockSchedule `property`

##### Summary

The minimum number of hours before an appointment that a patient can schedule or cancel for a specific practice. Note that this data is valued in hours.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentType-CreateEncounterOnCheckIn'></a>
### CreateEncounterOnCheckIn `property`

##### Summary

If true, then this appointments of this type will generated an encounter when checked in, with certain conditions. It's rather complex, but the rendering provider on the appointment must also have the create encounter feature set, the department must have athena Clinicals enabled, and other rarer and less visible settings.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentType-DepartmentId'></a>
### DepartmentId `property`

##### Summary

ID of the department.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentType-Duration'></a>
### Duration `property`

##### Summary

Expected duration of the appointment in minutes.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentType-Generic'></a>
### Generic `property`

##### Summary

If true, this type is a "generic" type able to be filled with other types of appointments.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentType-Id'></a>
### Id `property`

##### Summary

The appointment type ID.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentType-Name'></a>
### Name `property`

##### Summary

The name of the appointment type.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentType-Patient'></a>
### Patient `property`

##### Summary

If true, this type is a patient-facing type.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentType-PatientDisplayName'></a>
### PatientDisplayName `property`

##### Summary

Patient friendly appointment type name. Defaults to regular name.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentType-ProviderId'></a>
### ProviderId `property`

##### Summary

ID of the provider.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentType-ShortName'></a>
### ShortName `property`

##### Summary

The short name code of the appointment type.

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentType-TemplateTypeOnly'></a>
### TemplateTypeOnly `property`

##### Summary

If true, this type is a "template-only" type, and must be filled with a different appointment type upon booking.

<a name='T-AthenaHealth-Sdk-Http-AthenaHttpClient'></a>
## AthenaHttpClient `type`

##### Namespace

AthenaHealth.Sdk.Http

##### Summary

Generic Http client. Useful if you want to swap out System.Net.HttpClient with something else.

<a name='M-AthenaHealth-Sdk-Http-AthenaHttpClient-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [AthenaHttpClient](#T-AthenaHealth-Sdk-Http-AthenaHttpClient 'AthenaHealth.Sdk.Http.AthenaHttpClient') class.

##### Parameters

This constructor has no parameters.

<a name='M-AthenaHealth-Sdk-Http-AthenaHttpClient-#ctor-System-Net-Http-HttpMessageHandler-'></a>
### #ctor(handler) `constructor`

##### Summary

Initializes a new instance of the [AthenaHttpClient](#T-AthenaHealth-Sdk-Http-AthenaHttpClient 'AthenaHealth.Sdk.Http.AthenaHttpClient') class with a specific handler.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| handler | [System.Net.Http.HttpMessageHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMessageHandler 'System.Net.Http.HttpMessageHandler') | The HTTP handler stack to use for sending requests. |

<a name='T-AthenaHealth-Sdk-Models-Response-Patient-Balance'></a>
## Balance `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Patient

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Balance-CleanBalance'></a>
### CleanBalance `property`

##### Summary

Indicates whether the balance is associated with a contract, payment plan, or
collections agency.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Balance-CollectionsBalance'></a>
### CollectionsBalance `property`

##### Summary

The outstanding amount associated with a collections agency.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Balance-Contracts'></a>
### Contracts `property`

##### Summary

Information related to existing credit card contracts.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Balance-DepartmentList'></a>
### DepartmentList `property`

##### Summary

Comma separated list of department IDs that belong to this group

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Balance-PaymentPlanBalance'></a>
### PaymentPlanBalance `property`

##### Summary

The outstanding amount associated with a payment plan.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Balance-ProviderGroupId'></a>
### ProviderGroupId `property`

##### Summary

Athena ID for this financial group.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Balance-Value'></a>
### Value `property`

##### Summary

Balance for this provider group.

<a name='T-AthenaHealth-Sdk-Models-Request-BaseLimitFilter'></a>
## BaseLimitFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-BaseLimitFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 1500, max 5000)

<a name='P-AthenaHealth-Sdk-Models-Request-BaseLimitFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='T-AthenaHealth-Sdk-Models-Request-BookAppointment'></a>
## BookAppointment `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-BookAppointment-AppointmentId'></a>
### AppointmentId `property`

##### Summary

The appointment slot to schedule into.

<a name='P-AthenaHealth-Sdk-Models-Request-BookAppointment-AppointmentTypeId'></a>
### AppointmentTypeId `property`

##### Summary

The appointment type to be booked.  This field should never be used for booking appointments for web-based scheduling. The use of this field is reserved for digital check-in (aka "kiosk") or an application used by practice staff.  One of this or reasonid is required.

<a name='P-AthenaHealth-Sdk-Models-Request-BookAppointment-BookingNote'></a>
### BookingNote `property`

##### Summary

A note from the patient about why this appointment is being booked

<a name='P-AthenaHealth-Sdk-Models-Request-BookAppointment-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department ID.

<a name='P-AthenaHealth-Sdk-Models-Request-BookAppointment-DoNotSendConfirmationEmail'></a>
### DoNotSendConfirmationEmail `property`

##### Summary

For clients with athenaCommunicator, certain appointment types can be configured to have an appointment confirmation email sent to the patient at time of appointment booking. If this parameter is set to true, that email will not be sent.  This should only be used if you plan on sending a confirmation email via another method.

<a name='P-AthenaHealth-Sdk-Models-Request-BookAppointment-IgnoreSchedulablePermission'></a>
### IgnoreSchedulablePermission `property`

##### Summary

By default, we allow booking of appointments marked as schedulable via the web.  This flag allows you to bypass that restriction for booking.

<a name='P-AthenaHealth-Sdk-Models-Request-BookAppointment-InsuranceInfo'></a>
### InsuranceInfo `property`

##### Summary

Patient insurance information, which will be added to the note on the appointment.

<a name='P-AthenaHealth-Sdk-Models-Request-BookAppointment-NoPatientCase'></a>
### NoPatientCase `property`

##### Summary

By default, we create a patient case upon booking an appointment for new patients.  Setting this to true bypasses that patient case.

<a name='P-AthenaHealth-Sdk-Models-Request-BookAppointment-PatientId'></a>
### PatientId `property`

##### Summary

The athenaNet patient ID.

<a name='P-AthenaHealth-Sdk-Models-Request-BookAppointment-ReasonId'></a>
### ReasonId `property`

##### Summary

The appointment reason ID to be booked.  This field is required for booking appointments for web-based scheduling and is a reason that is retrieved from the /patientappointmentreasons call.

<a name='P-AthenaHealth-Sdk-Models-Request-BookAppointment-Urgent'></a>
### Urgent `property`

##### Summary

Set this field in order to set the urgent flag in athena (if the practice settings allow for this).

<a name='T-AthenaHealth-Sdk-Models-Request-CancelAppointment'></a>
## CancelAppointment `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-CancelAppointment-AppointmentCancelReasonId'></a>
### AppointmentCancelReasonId `property`

##### Summary

Passing in this parameter will override the default cancel reason. Valid reasons can be retrieved via a call to the GET /appointmentcancelreasons endpoint.

<a name='P-AthenaHealth-Sdk-Models-Request-CancelAppointment-AppointmentId'></a>
### AppointmentId `property`

##### Summary

The appointment slot to schedule into.

<a name='P-AthenaHealth-Sdk-Models-Request-CancelAppointment-CancellationReason'></a>
### CancellationReason `property`

##### Summary

A text explanation why the appointment is being cancelled

<a name='P-AthenaHealth-Sdk-Models-Request-CancelAppointment-IgnoreSchedulablePermission'></a>
### IgnoreSchedulablePermission `property`

##### Summary

By default, we allow booking of appointments marked as schedulable via the web.  This flag allows you to bypass that restriction for booking.

<a name='P-AthenaHealth-Sdk-Models-Request-CancelAppointment-NoPatientCase'></a>
### NoPatientCase `property`

##### Summary

By default, we create a patient case upon booking an appointment for new patients.  Setting this to true bypasses that patient case.

<a name='P-AthenaHealth-Sdk-Models-Request-CancelAppointment-PatientId'></a>
### PatientId `property`

##### Summary

The athenaNet patient ID.

<a name='T-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail'></a>
## ChargeLevelDetail `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Amount'></a>
### Amount `property`

##### Summary

The billed amount for the charge.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Description'></a>
### Description `property`

##### Summary

Description of the service.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Id'></a>
### Id `property`

##### Summary

The athenaNet ID of the charge.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-ProcedureCode'></a>
### ProcedureCode `property`

##### Summary

The CPT code associated with this charge.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-ProcedureCodeOtherModifier'></a>
### ProcedureCodeOtherModifier `property`

##### Summary

The modifiers for the procedure code.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-ProcedureCodeSubmitted'></a>
### ProcedureCodeSubmitted `property`

##### Summary

The procedure code that would be submitted as part of the claim.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-ServiceDate'></a>
### ServiceDate `property`

##### Summary

Date of service for the charge.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transactions'></a>
### Transactions `property`

##### Summary

Detailed information on transactions associated with the charge.

<a name='T-AthenaHealth-Sdk-Models-Response-CheckInField'></a>
## CheckInField `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-CheckInField-Error'></a>
### Error `property`

##### Summary

If the demographic field failed validate, this contains the error why (empty or failed validation).

<a name='P-AthenaHealth-Sdk-Models-Response-CheckInField-Field'></a>
### Field `property`

##### Summary

Name of the required or validated demographic field

<a name='P-AthenaHealth-Sdk-Models-Response-CheckInField-FormName'></a>
### FormName `property`

##### Summary

Name of the health history or privacy form.

<a name='P-AthenaHealth-Sdk-Models-Response-CheckInField-IsValid'></a>
### IsValid `property`

##### Summary

Name of the required or validated demographic field.

<a name='P-AthenaHealth-Sdk-Models-Response-CheckInField-Status'></a>
### Status `property`

##### Summary

Check in status (Before or During Check In), the Privacy Form status (Complete or Incomplete), or the percent complete of the health history form.

<a name='T-AthenaHealth-Sdk-Models-Response-CheckInRequirement'></a>
## CheckInRequirement `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-CheckInRequirement-Fields'></a>
### Fields `property`

##### Summary

Detailed information about the requirements for each section and their status.

<a name='P-AthenaHealth-Sdk-Models-Response-CheckInRequirement-IsCompleted'></a>
### IsCompleted `property`

##### Summary

Whether the requirements for this section have been successfully completed.

<a name='P-AthenaHealth-Sdk-Models-Response-CheckInRequirement-IsRequired'></a>
### IsRequired `property`

##### Summary

Whether this section is required to be completed before check in will be allowed.

<a name='P-AthenaHealth-Sdk-Models-Response-CheckInRequirement-Name'></a>
### Name `property`

##### Summary

Name of the group of requirements.
Can be Demographics, Insurance, Privacy Forms, Check In, and Health History Forms.
The Check In section just gives you the current status.

<a name='T-AthenaHealth-Sdk-Models-Response-Appointment-Claim'></a>
## Claim `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Appointment

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-AppointmentId'></a>
### AppointmentId `property`

##### Summary

The appointment ID associated with this claim.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-BilledProviderId'></a>
### BilledProviderId `property`

##### Summary

The provider ID of the billing provider for this claim.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-BilledServiceDate'></a>
### BilledServiceDate `property`

##### Summary

The billed date of service.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-ChargeAmount'></a>
### ChargeAmount `property`

##### Summary

The total amount billed for all services from this claim.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-ClaimCreatedDate'></a>
### ClaimCreatedDate `property`

##### Summary

The date the claim was created.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-Diagnoses'></a>
### Diagnoses `property`

##### Summary

Diagnoses is an array of all diagnoses.Each entry in the array is a hash with several fields.  /ccda is a better clinical representation.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-Id'></a>
### Id `property`

##### Summary

athenaNet's internal ID for this claim, specific to the practice.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-PatientPayer'></a>
### PatientPayer `property`

##### Summary

The status and notes of a responsible payer.  This payer is the patient.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-PrimaryInsurancePayer'></a>
### PrimaryInsurancePayer `property`

##### Summary

The status and notes of a responsible payer.  This payer is the primary insurace.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-Procedures'></a>
### Procedures `property`

##### Summary

Procedures is an array of all procedures.  /ccda is a better clinical representation.These fields are:

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-ReferringProviderId'></a>
### ReferringProviderId `property`

##### Summary

The referring provider ID for this claim.  See /referringproviders.  This is not the same as the ID from the /providers call.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-SecondaryInsurancePayer'></a>
### SecondaryInsurancePayer `property`

##### Summary

The status and notes of a responsible payer.  This payer is the secondary insurace.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-TransactionDetails'></a>
### TransactionDetails `property`

##### Summary

A hash of ids ("transactionid") to amounts; these should sum to the chargeamount. Please note that this has been deprecated in lieu of the data being available in the procedures section.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-TransactionId'></a>
### TransactionId `property`

##### Summary

A unique ID for the primary transaction this claim represents.  May be useful for debugging.

<a name='T-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail'></a>
## ClaimBalanceDetail `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Patient

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetails'></a>
### ClaimDetails `property`

##### Summary

Information related to claims for the patient.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-DepartmentIds'></a>
### DepartmentIds `property`

##### Summary

Comma separated list of department IDs that belong to this provider group

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ProviderGroupId'></a>
### ProviderGroupId `property`

##### Summary

The ID of the provider group for the claim.

<a name='T-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail'></a>
## ClaimDetail `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-Amount'></a>
### Amount `property`

##### Summary

The amount billed for the claim.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetails'></a>
### ChargeLevelDetails `property`

##### Summary

Detailed information on charges associated with the claim.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ClaimId'></a>
### ClaimId `property`

##### Summary

The ID of the claim.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-CleanBalance'></a>
### CleanBalance `property`

##### Summary

Indicates whether the balance is associated with a contract or payment plan.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The ID of the department where the service was rendered.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-PatientBalance'></a>
### PatientBalance `property`

##### Summary

The outstanding amount owed by the patient.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ServiceDate'></a>
### ServiceDate `property`

##### Summary

The date the service was rendered.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-SupervisingProviderId'></a>
### SupervisingProviderId `property`

##### Summary

The ID of the supervising provider who rendered the service.

<a name='T-AthenaHealth-Sdk-Models-Response-ClinicalProvider'></a>
## ClinicalProvider `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-Address1'></a>
### Address1 `property`

##### Summary

First part of provider address

<a name='P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-Address2'></a>
### Address2 `property`

##### Summary

Second part of provider address

<a name='P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-City'></a>
### City `property`

##### Summary

City of the provider

<a name='P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-CliaNumber'></a>
### CliaNumber `property`

##### Summary

The CLIA number of the clinical provider on file.

<a name='P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-FaxNumber'></a>
### FaxNumber `property`

##### Summary

Fax number for the provider

<a name='P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-Id'></a>
### Id `property`

##### Summary

ID for the provider

<a name='P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-Name'></a>
### Name `property`

##### Summary

Name of the provider

<a name='P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-PhoneNumber'></a>
### PhoneNumber `property`

##### Summary

Phone number for the provider

<a name='P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-State'></a>
### State `property`

##### Summary

State the provider resides

<a name='P-AthenaHealth-Sdk-Models-Response-ClinicalProvider-Zip'></a>
### Zip `property`

##### Summary

Zip code for the provider

<a name='T-AthenaHealth-Sdk-Models-ClockTime'></a>
## ClockTime `type`

##### Namespace

AthenaHealth.Sdk.Models

##### Summary

Class representing time with minutes and hours (without seconds).

<a name='T-AthenaHealth-Sdk-Models-Response-CommonInsurancePackage'></a>
## CommonInsurancePackage `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-CommonInsurancePackage-Id'></a>
### Id `property`

##### Summary

The athenaNet-wide insurance package (also know in the industry as an "insurance product") id.

<a name='T-AthenaHealth-Sdk-Http-Connection'></a>
## Connection `type`

##### Namespace

AthenaHealth.Sdk.Http

<a name='P-AthenaHealth-Sdk-Http-Connection-BaseAddress'></a>
### BaseAddress `property`

##### Summary

Base url address

<a name='P-AthenaHealth-Sdk-Http-Connection-Credentials'></a>
### Credentials `property`

##### Summary

Connection credentials

<a name='P-AthenaHealth-Sdk-Http-Connection-IsAccessTokenValid'></a>
### IsAccessTokenValid `property`

##### Summary

Indicates if access token exists and is still valid.

<a name='P-AthenaHealth-Sdk-Http-Connection-Version'></a>
### Version `property`

##### Summary

Current API version

<a name='M-AthenaHealth-Sdk-Http-Connection-AddVersion-System-String-'></a>
### AddVersion(relativeUrl) `method`

##### Summary

Builds relative url by prepending version name.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| relativeUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-AthenaHealth-Sdk-Http-Connection-Delete``1-System-String,System-Object-'></a>
### Delete\`\`1(relativeUrl,queryParameters) `method`

##### Summary

Sends DELETE request to url constructed from [BaseAddress](#P-AthenaHealth-Sdk-Http-Connection-BaseAddress 'AthenaHealth.Sdk.Http.Connection.BaseAddress') and `relativeUrl`.

##### Returns

Deserialized model

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| relativeUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Url relative to [BaseAddress](#P-AthenaHealth-Sdk-Http-Connection-BaseAddress 'AthenaHealth.Sdk.Http.Connection.BaseAddress'). |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameters to be added to constructed url. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Model type |

<a name='M-AthenaHealth-Sdk-Http-Connection-Get``1-System-String,System-Object,System-Boolean-'></a>
### Get\`\`1(relativeUrl,queryParameters,shouldThrowErrors) `method`

##### Summary

Sends GET request to url constructed from [BaseAddress](#P-AthenaHealth-Sdk-Http-Connection-BaseAddress 'AthenaHealth.Sdk.Http.Connection.BaseAddress') and `relativeUrl`.

##### Returns

Deserialized model

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| relativeUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Url relative to [BaseAddress](#P-AthenaHealth-Sdk-Http-Connection-BaseAddress 'AthenaHealth.Sdk.Http.Connection.BaseAddress'). |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameters to be added to constructed url. |
| shouldThrowErrors | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | >True: Throws exception if invalid response object. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Model type |

<a name='M-AthenaHealth-Sdk-Http-Connection-Post``1-System-String,System-Object,System-Object,System-Boolean-'></a>
### Post\`\`1(relativeUrl,queryParameters,body) `method`

##### Summary

Sends POST request to url constructed from [BaseAddress](#P-AthenaHealth-Sdk-Http-Connection-BaseAddress 'AthenaHealth.Sdk.Http.Connection.BaseAddress') and `relativeUrl`.

##### Returns

Deserialized model

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| relativeUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Url relative to [BaseAddress](#P-AthenaHealth-Sdk-Http-Connection-BaseAddress 'AthenaHealth.Sdk.Http.Connection.BaseAddress'). |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameters to be added to constructed url. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Request content |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Model type |

<a name='M-AthenaHealth-Sdk-Http-Connection-Put``1-System-String,System-Object,System-Object-'></a>
### Put\`\`1(relativeUrl,queryParameters,body) `method`

##### Summary

Sends PUT request to url constructed from [BaseAddress](#P-AthenaHealth-Sdk-Http-Connection-BaseAddress 'AthenaHealth.Sdk.Http.Connection.BaseAddress') and `relativeUrl`.

##### Returns

Deserialized model

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| relativeUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Url relative to [BaseAddress](#P-AthenaHealth-Sdk-Http-Connection-BaseAddress 'AthenaHealth.Sdk.Http.Connection.BaseAddress'). |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameters to be added to constructed url. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Request content |

<a name='M-AthenaHealth-Sdk-Http-Connection-RefreshAccessToken'></a>
### RefreshAccessToken() `method`

##### Summary

Performs authorization based on provided credentials.

##### Returns

Boolean value indicating success

##### Parameters

This method has no parameters.

<a name='T-AthenaHealth-Sdk-Http-Helpers-ContentConverter'></a>
## ContentConverter `type`

##### Namespace

AthenaHealth.Sdk.Http.Helpers

<a name='M-AthenaHealth-Sdk-Http-Helpers-ContentConverter-ConvertObjectToDictionary-System-Object-'></a>
### ConvertObjectToDictionary(obj) `method`

##### Summary

Performs conversion from object to dictionary.
Name of the property becomes a dictionary key. Value of the property becomes dictionary value.
If JsonConvert attribute is set up, converter is used.
If value is an array, it is converted to delimited string
If value is neither an array nor simple type, it is serialized to JSON

##### Returns

Converted object as dictionary

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Object to be converted |

<a name='M-AthenaHealth-Sdk-Http-Helpers-ContentConverter-GetAttribute``1-System-Reflection-PropertyInfo-'></a>
### GetAttribute\`\`1(property) `method`

##### Summary

Gets custom attribute directly from property or from implemented interface property attribute.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| property | [System.Reflection.PropertyInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AthenaHealth-Sdk-Http-Helpers-ContentConverter-GetKey-System-Reflection-PropertyInfo-'></a>
### GetKey(item) `method`

##### Summary

Get item's key for dictionary. If item has JsonPropertyAttribute, name is get from the attribute.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [System.Reflection.PropertyInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo') |  |

<a name='M-AthenaHealth-Sdk-Http-Helpers-ContentConverter-GetValue-System-Object,System-Reflection-PropertyInfo-'></a>
### GetValue(obj,item) `method`

##### Summary

Get value of an object in different cases

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| item | [System.Reflection.PropertyInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo') |  |

<a name='M-AthenaHealth-Sdk-Http-Helpers-ContentConverter-GetValueWithJsonConverter-Newtonsoft-Json-JsonConverterAttribute,System-Object-'></a>
### GetValueWithJsonConverter(jsonConverterAttribute,value) `method`

##### Summary

Gets value of an object using JsonConverter

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| jsonConverterAttribute | [Newtonsoft.Json.JsonConverterAttribute](#T-Newtonsoft-Json-JsonConverterAttribute 'Newtonsoft.Json.JsonConverterAttribute') |  |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='T-AthenaHealth-Sdk-Models-Response-Patient-Balance-Contract'></a>
## Contract `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Patient.Balance

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Balance-Contract-AvailableBalance'></a>
### AvailableBalance `property`

##### Summary

The available balance on this contract.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Balance-Contract-ContractClass'></a>
### ContractClass `property`

##### Summary

The type of contract. For example, "ONEYEAR,"

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Balance-Contract-MaxAmount'></a>
### MaxAmount `property`

##### Summary

The maximum allowed amount for this contract.

<a name='T-AthenaHealth-Sdk-Models-Response-Insurance-Copay'></a>
## Copay `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Insurance

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-Copay-CopayAmount'></a>
### CopayAmount `property`

##### Summary

The amount of the copay.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-Copay-CopayType'></a>
### CopayType `property`

##### Summary

What the copay amount applies to.

<a name='T-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder'></a>
## CreateAppointmentReminder `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-AppointmentTypeId'></a>
### AppointmentTypeId `property`

##### Summary

The athenaNet appointment type ID.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-ApproximateDate'></a>
### ApproximateDate `property`

##### Summary

The approximate date on which an appointment for this reminder should be scheduled.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department ID.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-Note'></a>
### Note `property`

##### Summary

Free-text notes entered by the practice about this reminder.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-PatientId'></a>
### PatientId `property`

##### Summary

The athenaNet patient ID.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-PatientInstructions'></a>
### PatientInstructions `property`

##### Summary

Free-text instructions for the patient entered by the practice for this reminder.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-ProviderId'></a>
### ProviderId `property`

##### Summary

The athenaNet provider ID.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-Status'></a>
### Status `property`

##### Summary

Status of the reminder.

<a name='T-AthenaHealth-Sdk-Models-Request-CreateAppointmentSlot'></a>
## CreateAppointmentSlot `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-CreateAppointmentSlot-AppointmentDate'></a>
### AppointmentDate `property`

##### Summary

The appointment date for the new open appointment slot (mm/dd/yyyy).

<a name='P-AthenaHealth-Sdk-Models-Request-CreateAppointmentSlot-AppointmentTime'></a>
### AppointmentTime `property`

##### Summary

The time (hh24:mi) for the new appointment slot.  Multiple times (either as a comma delimited list or multiple POSTed values) are allowed.  24 hour time.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateAppointmentSlot-AppointmentTypeId'></a>
### AppointmentTypeId `property`

##### Summary

The appointment type ID to be created.  Either this or a reason must be provided.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateAppointmentSlot-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department ID.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateAppointmentSlot-ProviderId'></a>
### ProviderId `property`

##### Summary

The athenaNet provider ID.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateAppointmentSlot-ReasonId'></a>
### ReasonId `property`

##### Summary

The appointment reason (/patientappointmentreasons) to be created. Either this or a raw appointment type ID must be provided.

<a name='T-AthenaHealth-Sdk-Models-Request-CreateDiagnoses'></a>
## CreateDiagnoses `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-CreateDiagnoses-Icd10Codes'></a>
### Icd10Codes `property`

##### Summary

ICD-10 code(s) for this diagnosis.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateDiagnoses-Icd9Codes'></a>
### Icd9Codes `property`

##### Summary

ICD-9 code(s) for this diagnosis.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateDiagnoses-Laterality'></a>
### Laterality `property`

##### Summary

Laterality of the SNOMED code.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateDiagnoses-Note'></a>
### Note `property`

##### Summary

The note to be entered for this diagnosis.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateDiagnoses-SnomedCode'></a>
### SnomedCode `property`

##### Summary

SNOMED code for this diagnosis.

<a name='T-AthenaHealth-Sdk-Models-Request-CreateInsurance'></a>
## CreateInsurance `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-DepartmentId'></a>
### DepartmentId `property`

##### Summary

If set, we will use the department id in an attempt to add to the local patient.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-ExpirationDate'></a>
### ExpirationDate `property`

##### Summary

Set the date that the insurance will expire. This is usually a date within the next year and not in the past.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsuranceIdNumber'></a>
### InsuranceIdNumber `property`

##### Summary

The insurance policy ID number (as presented on the insurance card itself).

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePackageId'></a>
### InsurancePackageId `property`

##### Summary

The athenaNet insurance package ID.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePhone'></a>
### InsurancePhone `property`

##### Summary

The phone number for the insurance company. Note: This defaults to the insurance package phone number. If this is set, it will override it. Likewise if blanked out, it will go back to default.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolder'></a>
### InsurancePolicyHolder `property`

##### Summary

Name of the entity who holds this insurance policy. Required if entity type is set to non-person.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderAddress1'></a>
### InsurancePolicyHolderAddress1 `property`

##### Summary

The first address line of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderAddress2'></a>
### InsurancePolicyHolderAddress2 `property`

##### Summary

The second address line of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderCity'></a>
### InsurancePolicyHolderCity `property`

##### Summary

The city of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderCountryCode'></a>
### InsurancePolicyHolderCountryCode `property`

##### Summary

The country code (3 letter) of the insurance policy holder.  Either this or insurancepolicyholdercountryiso3166 are acceptable.  Defaults to USA.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderCountryIso3166'></a>
### InsurancePolicyHolderCountryIso3166 `property`

##### Summary

The ISO 3166 country code of the insurance policy holder.  Either this or insurancepolicyholdercountrycode are acceptable.  Defaults to US.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderDob'></a>
### InsurancePolicyHolderDob `property`

##### Summary

The DOB of the insurance policy holder (mm/dd/yyyy).

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderFirstName'></a>
### InsurancePolicyHolderFirstName `property`

##### Summary

The first name of the insurance policy holder.  Except for self-pay, required for new policies.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderLastName'></a>
### InsurancePolicyHolderLastName `property`

##### Summary

The last name of the insurance policy holder.  Except for self-pay, required for new policies.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderMiddleName'></a>
### InsurancePolicyHolderMiddleName `property`

##### Summary

The middle name of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderSex'></a>
### InsurancePolicyHolderSex `property`

##### Summary

The sex of the insurance policy holder.  Except for self-pay, required for new policies.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderSsn'></a>
### InsurancePolicyHolderSsn `property`

##### Summary

The SSN of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderState'></a>
### InsurancePolicyHolderState `property`

##### Summary

The state of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderSuffix'></a>
### InsurancePolicyHolderSuffix `property`

##### Summary

The suffix of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-InsurancePolicyHolderZip'></a>
### InsurancePolicyHolderZip `property`

##### Summary

The zip of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-IssueDate'></a>
### IssueDate `property`

##### Summary

Set the date that the insurance was issued. This is usually a date in the past year and not in the future.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-PolicyNumber'></a>
### PolicyNumber `property`

##### Summary

The insurance group number.  This is sometimes present on an insurance card.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-RelationshipToInsuredId'></a>
### RelationshipToInsuredId `property`

##### Summary

This patient's relationship to the policy holder (as an ID).  See  the mapping. Please note that if this is set to 12, Entity Type must be set to 2.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-SequenceNumber'></a>
### SequenceNumber `property`

##### Summary

1 = primary, 2 = secondary.  Must have a primary before a secondary. This field is required if the insurance package is not a case policy.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-UpdateAppointments'></a>
### UpdateAppointments `property`

##### Summary

If set to true, automatically updates all future appointments to use this insurance as primary or secondary, respective to the sequence number.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateInsurance-ValidateInsuranceIdNumber'></a>
### ValidateInsuranceIdNumber `property`

##### Summary

BETA FIELD: If true, this makes sure that you have entered a valid INSURANCEIDNUMBER.  If you didn't it will error.  Setting this is probably a good thing and means you shouldn't have to do a ton of validation on the ID number.

<a name='T-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient'></a>
## CreateOrUpdatePatient `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Address1'></a>
### Address1 `property`

##### Summary

(Max length: 100)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Address2'></a>
### Address2 `property`

##### Summary

(Max length: 100)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-AgriculturalWorker'></a>
### AgriculturalWorker `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-AgriculturalWorkerType'></a>
### AgriculturalWorkerType `property`

##### Summary

(Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-AltFirstName'></a>
### AltFirstName `property`

##### Summary

Alternate first name that differs from legal name.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-AssignedSexAtBirth'></a>
### AssignedSexAtBirth `property`

##### Summary

Sex that this patient was assigned at birth.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-CareSummaryDeliveryPreference'></a>
### CareSummaryDeliveryPreference `property`

##### Summary

(Max length: 50)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-City'></a>
### City `property`

##### Summary

(Max length: 30)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ClinicalOrderTypeGroupId'></a>
### ClinicalOrderTypeGroupId `property`

##### Summary

The clinical order type group of the clinical provider (Prescription: 10, Lab: 11,
Vaccinations: 16).

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ConsentToCall'></a>
### ConsentToCall `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ConsentToText'></a>
### ConsentToText `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactHomePhone'></a>
### ContactHomePhone `property`

##### Summary

(Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactMobilePhone'></a>
### ContactMobilePhone `property`

##### Summary

(Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactName'></a>
### ContactName `property`

##### Summary

(Max length: 50)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreference'></a>
### ContactPreference `property`

##### Summary

(Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceAnnouncementEmail'></a>
### ContactPreferenceAnnouncementEmail `property`

##### Summary

If set, the patient has indicated a preference to get or not get "announcement"
communications delivered via email. Note that this will not be present if the practice or
patient has not set it.For completeness, turning email off is supported via the API, but
it is discouraged. When email is off, patients may not not get messages from the patient portal.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceAnnouncementPhone'></a>
### ContactPreferenceAnnouncementPhone `property`

##### Summary

If set, the patient has indicated a preference to get or not get "announcement"
communications delivered via phone. Note that this will not be present if the practice or
patient has not set it.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceAnnouncementSms'></a>
### ContactPreferenceAnnouncementSms `property`

##### Summary

If set, the patient has indicated a preference to get or not get "announcement"
communications delivered via SMS. Note that this will not be present if the practice or
patient has not set it.For SMS, there is specific terms of service language that must be
used when displaying this as an option to be turned on. Turning on must be an action by
the patient, not a practice user.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceAppointmentEemail'></a>
### ContactPreferenceAppointmentEemail `property`

##### Summary

If set, the patient has indicated a preference to get or not get "appointment"
communications delivered via email. Note that this will not be present if the practice or
patient has not set it.For completeness, turning email off is supported via the API, but
it is discouraged. When email is off, patients may not not get messages from the patient portal.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceAppointmentPhone'></a>
### ContactPreferenceAppointmentPhone `property`

##### Summary

If set, the patient has indicated a preference to get or not get "appointment"
communications delivered via phone. Note that this will not be present if the practice or
patient has not set it.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceAppointmentSms'></a>
### ContactPreferenceAppointmentSms `property`

##### Summary

If set, the patient has indicated a preference to get or not get "appointment"
communications delivered via SMS. Note that this will not be present if the practice or
patient has not set it.For SMS, there is specific terms of service language that must be
used when displaying this as an option to be turned on. Turning on must be an action by
the patient, not a practice user.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceBillingEmail'></a>
### ContactPreferenceBillingEmail `property`

##### Summary

If set, the patient has indicated a preference to get or not get "billing" communications
delivered via email. Note that this will not be present if the practice or patient has
not set it.For completeness, turning email off is supported via the API, but it is
discouraged. When email is off, patients may not not get messages from the patient portal.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceBillingPhone'></a>
### ContactPreferenceBillingPhone `property`

##### Summary

If set, the patient has indicated a preference to get or not get "billing" communications
delivered via phone. Note that this will not be present if the practice or patient has
not set it.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceBillingSms'></a>
### ContactPreferenceBillingSms `property`

##### Summary

If set, the patient has indicated a preference to get or not get "billing" communications
delivered via SMS. Note that this will not be present if the practice or patient has not
set it.For SMS, there is specific terms of service language that must be used when
displaying this as an option to be turned on. Turning on must be an action by the
patient, not a practice user.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceLabEmail'></a>
### ContactPreferenceLabEmail `property`

##### Summary

If set, the patient has indicated a preference to get or not get "lab" communications
delivered via email. Note that this will not be present if the practice or patient has
not set it.For completeness, turning email off is supported via the API, but it is
discouraged. When email is off, patients may not not get messages from the patient portal.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceLabPhone'></a>
### ContactPreferenceLabPhone `property`

##### Summary

If set, the patient has indicated a preference to get or not get "lab" communications
delivered via phone. Note that this will not be present if the practice or patient has
not set it.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactPreferenceLabSms'></a>
### ContactPreferenceLabSms `property`

##### Summary

If set, the patient has indicated a preference to get or not get "lab" communications
delivered via SMS. Note that this will not be present if the practice or patient has not
set it.For SMS, there is specific terms of service language that must be used when
displaying this as an option to be turned on. Turning on must be an action by the
patient, not a practice user.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ContactRelationship'></a>
### ContactRelationship `property`

##### Summary

(Max length: 10)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-CountryCode3166'></a>
### CountryCode3166 `property`

##### Summary

Patient's country code (ISO 3166-1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DateOfBirth'></a>
### DateOfBirth `property`

##### Summary

Patient's DOB (mm/dd/yyyy)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DeceasedDate'></a>
### DeceasedDate `property`

##### Summary

If present, the date on which a patient died.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DefaultPharmacyNcpdpId'></a>
### DefaultPharmacyNcpdpId `property`

##### Summary

The NCPDP ID of the patient's preferred pharmacy. See http://www.ncpdp.org/ for details.
Note: if updating this field, please make sure to have a CLINICALORDERTYPEGROUPID field
as well.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DepartmentId'></a>
### DepartmentId `property`

##### Summary

Primary (registration) department ID.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DoNotCall'></a>
### DoNotCall `property`

##### Summary

Warning! This patient will not receive any communication from the practice if this field
is set to true. This field should only be used if you are absolutely certain that's what
you want to do.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DriversLicenseExpirationDate'></a>
### DriversLicenseExpirationDate `property`

##### Summary

The expiration date of the patient's driver's license.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DriversLicenseNumber'></a>
### DriversLicenseNumber `property`

##### Summary

The number of the patient's driver's license

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-DriversLicenseStateId'></a>
### DriversLicenseStateId `property`

##### Summary

The state of the patient's driver's license. This is in the form of a 2 letter state code.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Email'></a>
### Email `property`

##### Summary

(Max length: 50)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-EmployerId'></a>
### EmployerId `property`

##### Summary

The patient's employer's ID (from /employers call)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-EmployerPhone'></a>
### EmployerPhone `property`

##### Summary

(Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-EthnicityCode'></a>
### EthnicityCode `property`

##### Summary

Ethnicity of the patient, using the 2.16.840.1.113883.5.50 codeset. See
http://www.hl7.org/implement/standards/fhir/terminologies-v3.html Special case: use
"declined" to indicate that the patient declined to answer.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-FirstName'></a>
### FirstName `property`

##### Summary

(Max length: 35)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GenderIdentity'></a>
### GenderIdentity `property`

##### Summary

Gender with which this patient identifies. To see the available options for this input,
please see GET /configuration/patients/genderidentity

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GenderIdentityOther'></a>
### GenderIdentityOther `property`

##### Summary

Only valid when used in conjunction with a gender identity choice that allows the patient
to describe their identity (if it doesn't conform to any other choice).

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorAddress1'></a>
### GuarantorAddress1 `property`

##### Summary

(Max length: 100)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorAddress2'></a>
### GuarantorAddress2 `property`

##### Summary

(Max length: 100)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorAddressSameAsPatient'></a>
### GuarantorAddressSameAsPatient `property`

##### Summary

If set, the address of the guarantor is the same as the patient.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorCity'></a>
### GuarantorCity `property`

##### Summary

(Max length: 30)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorCountryCode3166'></a>
### GuarantorCountryCode3166 `property`

##### Summary

Guarantor's country code (ISO 3166-1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorDateOfBirth'></a>
### GuarantorDateOfBirth `property`

##### Summary

Guarantor's DOB (mm/dd/yyyy)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorEmail'></a>
### GuarantorEmail `property`

##### Summary

(Max length: 50)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorEmployerId'></a>
### GuarantorEmployerId `property`

##### Summary

The guaranror's employer's ID (from /employers call)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorFirstName'></a>
### GuarantorFirstName `property`

##### Summary

(Max length: 35)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorLastName'></a>
### GuarantorLastName `property`

##### Summary

(Max length: 60)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorMiddleName'></a>
### GuarantorMiddleName `property`

##### Summary

(Max length: 25)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorPhone'></a>
### GuarantorPhone `property`

##### Summary

(Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorRelationshipToPatient'></a>
### GuarantorRelationshipToPatient `property`

##### Summary

The guarantor's relationship to the patient

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorSsn'></a>
### GuarantorSsn `property`

##### Summary

(Max length: 13)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorState'></a>
### GuarantorState `property`

##### Summary

(Max length: 10)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorSuffix'></a>
### GuarantorSuffix `property`

##### Summary

(Max length: 10)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuarantorZip'></a>
### GuarantorZip `property`

##### Summary

(Max length: 10)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuardianFirstName'></a>
### GuardianFirstName `property`

##### Summary

(Max length: 35)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuardianLastName'></a>
### GuardianLastName `property`

##### Summary

(Max length: 60)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuardianMiddleName'></a>
### GuardianMiddleName `property`

##### Summary

(Max length: 25)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-GuardianSuffix'></a>
### GuardianSuffix `property`

##### Summary

(Max length: 10)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-HasMobile'></a>
### HasMobile `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-HomePhone'></a>
### HomePhone `property`

##### Summary

(Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Homebound'></a>
### Homebound `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Homeless'></a>
### Homeless `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-HomelessType'></a>
### HomelessType `property`

##### Summary

(Max length: 30)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-IgnoreRestrictions'></a>
### IgnoreRestrictions `property`

##### Summary

Set to true to allow ability to find patients with record restrictions and blocked
patients. This should only be used when there is no reflection to the patient at all that
a match was found or not found.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-IndustryCode'></a>
### IndustryCode `property`

##### Summary

Industry of the patient, using the US Census industry code (code system
2.16.840.1.113883.6.310). "other" can be used as well.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Language6392Code'></a>
### Language6392Code `property`

##### Summary

Language of the patient, using the ISO 639.2 code.
(http://www.loc.gov/standards/iso639-2/php/code_list.php; "T" or terminology code)
Special case: use "declined" to indicate that the patient declined to answer.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-LastName'></a>
### LastName `property`

##### Summary

(Max length: 60)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-MaritalStatus'></a>
### MaritalStatus `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-MiddleName'></a>
### MiddleName `property`

##### Summary

(Max length: 25)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-MobileCarrierId'></a>
### MobileCarrierId `property`

##### Summary

The ID of the mobile carrier, from /mobilecarriers or the list below.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-MobilePhone'></a>
### MobilePhone `property`

##### Summary

(Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-NextKinName'></a>
### NextKinName `property`

##### Summary

(Max length: 50)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-NextKinPhone'></a>
### NextKinPhone `property`

##### Summary

(Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-NextKinRelationship'></a>
### NextKinRelationship `property`

##### Summary

(Max length: 10)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Notes'></a>
### Notes `property`

##### Summary

(Max length: 4000)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-OccupationCode'></a>
### OccupationCode `property`

##### Summary

Occupation of the patient, using the US Census occupation code (code system
2.16.840.1.113883.6.240). "other" can be used as well.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-OnlineStatementOnly'></a>
### OnlineStatementOnly `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PortalAccessGiven'></a>
### PortalAccessGiven `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PovertyLevelCalculated'></a>
### PovertyLevelCalculated `property`

##### Summary

Patient's poverty level (% of the Federal Poverty Level), as calculated from family size,
income per pay period, pay period, and state. Typically only valued if client has Federal
Poverty Level fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PovertyLevelFamilySizeDeclined'></a>
### PovertyLevelFamilySizeDeclined `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PovertyLevelFamilysize'></a>
### PovertyLevelFamilysize `property`

##### Summary

Patient's family size (used for determining poverty level). Only settable if client has
Federal Poverty Level fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PovertyLevelIncomeDeclined'></a>
### PovertyLevelIncomeDeclined `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PovertyLevelIncomePayPeriod'></a>
### PovertyLevelIncomePayPeriod `property`

##### Summary

(Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PovertyLevelIncomePerPayPeriod'></a>
### PovertyLevelIncomePerPayPeriod `property`

##### Summary

Patient's income per specified pay period (used for determining poverty level). Only
settable if client has Federal Poverty Level fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PovertyLevelIncomeRangeDeclined'></a>
### PovertyLevelIncomeRangeDeclined `property`

##### Summary

Indicates whether or not the patient declines to provide an income level (povertylevelcalculated).

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PreferredName'></a>
### PreferredName `property`

##### Summary

(Max length: 35)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PreferredPronouns'></a>
### PreferredPronouns `property`

##### Summary

Pronoun this patient uses.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PrimaryDepartmentId'></a>
### PrimaryDepartmentId `property`

##### Summary

The patient's "current" department. This field is not always set by the practice.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PrimaryProviderId'></a>
### PrimaryProviderId `property`

##### Summary

The "primary" provider for this patient, if set.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-PublicHousing'></a>
### PublicHousing `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Race'></a>
### Race `property`

##### Summary

The patient race, using the 2.16.840.1.113883.5.104 codeset. See
http://www.hl7.org/implement/standards/fhir/terminologies-v3.html Special case: use
"declined" to indicate that the patient declined to answer. Multiple values or a
tab-seperated list of codes is acceptable for multiple races for input. The first race
will be considered "primary". Note: you must update all values at once if you update any.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ReferralSourceId'></a>
### ReferralSourceId `property`

##### Summary

The referral / "how did you hear about us" ID.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-ReferralSourceOther'></a>
### ReferralSourceOther `property`

##### Summary

(Max length: 100)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-SchoolBasedHealthCenter'></a>
### SchoolBasedHealthCenter `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Sex'></a>
### Sex `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-SexualOrientation'></a>
### SexualOrientation `property`

##### Summary

Sexual orientation of this patient.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-SexualOrientationOther'></a>
### SexualOrientationOther `property`

##### Summary

Only valid when used in conjunction with a sexual orientation choice that allows the
patient to describe their orientation (if it doesn't conform to any other choice).

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Ssn'></a>
### Ssn `property`

##### Summary

(Max length: 13)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-State'></a>
### State `property`

##### Summary

(Max length: 10)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Status'></a>
### Status `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Suffix'></a>
### Suffix `property`

##### Summary

(Max length: 10)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Veteran'></a>
### Veteran `property`

##### Summary

(Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-WorkPhone'></a>
### WorkPhone `property`

##### Summary

(Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrUpdatePatient-Zip'></a>
### Zip `property`

##### Summary

(Max length: 10)

<a name='T-AthenaHealth-Sdk-Models-Request-CreateOrderLab'></a>
## CreateOrderLab `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-DiagnosisSnomedCode'></a>
### DiagnosisSnomedCode `property`

##### Summary

The SNOMED code for diagnosis this order is for.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-FacilityId'></a>
### FacilityId `property`

##### Summary

The athena ID of the lab you want to send the order to. Get a localized list using /chart/configuration/facilities.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-FacilityNote'></a>
### FacilityNote `property`

##### Summary

A note to send to the lab.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-FutureSubmitDate'></a>
### FutureSubmitDate `property`

##### Summary

The date the order should be sent. Defaults to today.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-HighPriority'></a>
### HighPriority `property`

##### Summary

If true, then the order should be sent STAT.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-Loinc'></a>
### Loinc `property`

##### Summary

The LOINC of the lab you wish to order.
Either this or [OrderTypeId](#P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-OrderTypeId 'AthenaHealth.Sdk.Models.Request.CreateOrderLab.OrderTypeId') can be used, but not both.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-OrderTypeId'></a>
### OrderTypeId `property`

##### Summary

The athena ID of the lab to order. Get the IDs using [SearchOrderTypesByName](#M-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient-SearchOrderTypesByName-System-String- 'AthenaHealth.Sdk.Clients.Interfaces.IDictionaryClient.SearchOrderTypesByName(System.String)')
Either this or [Loinc](#P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-Loinc 'AthenaHealth.Sdk.Models.Request.CreateOrderLab.Loinc') can be used, but not both.

<a name='P-AthenaHealth-Sdk-Models-Request-CreateOrderLab-ProviderNote'></a>
### ProviderNote `property`

##### Summary

An internal note for the provider or staff.

<a name='T-AthenaHealth-Sdk-Models-Request-CreatePatient'></a>
## CreatePatient `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-CreatePatient-ShowErrorMessage'></a>
### ShowErrorMessage `property`

##### Summary

If set to true returns error message on patient match (Defaults to false).

<a name='T-AthenaHealth-Sdk-Models-Response-CreatePatientResponse'></a>
## CreatePatientResponse `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-CreatePatientResponse-ErrorMessage'></a>
### ErrorMessage `property`

##### Summary

Error message will be returned if show error message flag is set to true and patient
match found.

<a name='P-AthenaHealth-Sdk-Models-Response-CreatePatientResponse-PatientId'></a>
### PatientId `property`

##### Summary

Please remember to never disclose this ID to patients since it may result in inadvertant
disclosure that a patient exists in a practice already.

<a name='T-AthenaHealth-Sdk-Models-Response-CreatedAppointmentReminder'></a>
## CreatedAppointmentReminder `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-CreatedAppointmentReminder-ErrorMessage'></a>
### ErrorMessage `property`

##### Summary

If [IsSuccess](#P-AthenaHealth-Sdk-Models-Response-BaseResponse-IsSuccess 'AthenaHealth.Sdk.Models.Response.BaseResponse.IsSuccess') is false will contain error message.

<a name='P-AthenaHealth-Sdk-Models-Response-CreatedAppointmentReminder-Id'></a>
### Id `property`

##### Summary

An athenaNet appointment reminder ID.

<a name='T-AthenaHealth-Sdk-Models-Converters-CustomArrayToStringConverter'></a>
## CustomArrayToStringConverter `type`

##### Namespace

AthenaHealth.Sdk.Models.Converters

##### Summary

Converts arrays to delimited string.
May be used for serialization.
May not be used for deserialization.

<a name='T-AthenaHealth-Sdk-Models-Response-Patient-CustomField'></a>
## CustomField `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Patient

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-CustomField-CustomFieldValue'></a>
### CustomFieldValue `property`

##### Summary

For a non-select custom field, the value.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-CustomField-Id'></a>
### Id `property`

##### Summary

Corresponds to the /customfields customfieldid.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-CustomField-OptionId'></a>
### OptionId `property`

##### Summary

For a select custom field, the selectid value (from /customfield's selectlist).

<a name='T-AthenaHealth-Sdk-Models-Response-Document-DeclinedReason'></a>
## DeclinedReason `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Document

<a name='P-AthenaHealth-Sdk-Models-Response-Document-DeclinedReason-Code'></a>
### Code `property`

##### Summary



<a name='P-AthenaHealth-Sdk-Models-Response-Document-DeclinedReason-Codeset'></a>
### Codeset `property`

##### Summary



<a name='P-AthenaHealth-Sdk-Models-Response-Document-DeclinedReason-Description'></a>
### Description `property`

##### Summary



<a name='T-AthenaHealth-Sdk-Models-Response-Department'></a>
## Department `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-Department-ProviderList'></a>
### ProviderList `property`

##### Summary

Items who see patients in this department.

<a name='T-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Diagnose'></a>
## Diagnose `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem.Event

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Diagnose-Code'></a>
### Code `property`

##### Summary

Diagnosis code

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Diagnose-Codeset'></a>
### Codeset `property`

##### Summary

Diagnosis codeset (SNOMED, ICD9, ICD10, etc)

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Diagnose-Name'></a>
### Name `property`

##### Summary

Diagnosis name. Might be different than problem name.

<a name='T-AthenaHealth-Sdk-Models-Response-DiagnoseForEncounter'></a>
## DiagnoseForEncounter `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-DiagnoseForEncounter-Description'></a>
### Description `property`

##### Summary

Brief description for this SNOMED Code

<a name='P-AthenaHealth-Sdk-Models-Response-DiagnoseForEncounter-IcdCodes'></a>
### IcdCodes `property`

##### Summary

List of relevant ICD codes for this diagnosis

<a name='P-AthenaHealth-Sdk-Models-Response-DiagnoseForEncounter-Id'></a>
### Id `property`

##### Summary

Athena ID for this diagnosis

<a name='P-AthenaHealth-Sdk-Models-Response-DiagnoseForEncounter-Note'></a>
### Note `property`

##### Summary

The note entered for this diagnosis.

<a name='P-AthenaHealth-Sdk-Models-Response-DiagnoseForEncounter-SnomedCode'></a>
### SnomedCode `property`

##### Summary

SNOMED Code for this diagnosis

<a name='T-AthenaHealth-Sdk-Models-Response-Appointment-Diagnosis'></a>
## Diagnosis `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Appointment

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Diagnosis-DeletedDiagnosis'></a>
### DeletedDiagnosis `property`

##### Summary

In certain cases, diagnoses may be added and then removed from a particular claim.  In normal circumstances, this will be false.  However, if a diagnosis was removed, this will be true.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Diagnosis-DiagnosisCategory'></a>
### DiagnosisCategory `property`

##### Summary

The category for this diagnosis.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Diagnosis-DiagnosisCodeSet'></a>
### DiagnosisCodeSet `property`

##### Summary

Either ICD9 or ICD10.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Diagnosis-DiagnosisDescription'></a>
### DiagnosisDescription `property`

##### Summary

A description of this diagnosis.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Diagnosis-DiagnosisRawCode'></a>
### DiagnosisRawCode `property`

##### Summary

The raw ICD-9 code.  This will migrate to ICD-10 in the future.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Diagnosis-Id'></a>
### Id `property`

##### Summary

A unique ID related to this diagnosis.

<a name='T-AthenaHealth-Sdk-Models-Response-Document'></a>
## Document `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-Document-AcogId'></a>
### AcogId `property`

##### Summary

The primary key for acog class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-AdminId'></a>
### AdminId `property`

##### Summary

The primary key for admin class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-AdvertisementId'></a>
### AdvertisementId `property`

##### Summary

The primary key for advertisement class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-AppointmentId'></a>
### AppointmentId `property`

##### Summary

The appointment ID for this document,

<a name='P-AthenaHealth-Sdk-Models-Response-Document-AppointmentRequestId'></a>
### AppointmentRequestId `property`

##### Summary

The primary key for appointmentrequest class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-AssignedTo'></a>
### AssignedTo `property`

##### Summary

Person the document is assigned to

<a name='P-AthenaHealth-Sdk-Models-Response-Document-ChartAbstractionId'></a>
### ChartAbstractionId `property`

##### Summary

The primary key for chartabstraction class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-ClinicalDocumentId'></a>
### ClinicalDocumentId `property`

##### Summary

The primary key for clinicaldocument class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-ClinicalProviderId'></a>
### ClinicalProviderId `property`

##### Summary

The clinical provider ID of the performing provider

<a name='P-AthenaHealth-Sdk-Models-Response-Document-CoordinatorTaskId'></a>
### CoordinatorTaskId `property`

##### Summary

The primary key for coordinatortask class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-CorrectiveLensId'></a>
### CorrectiveLensId `property`

##### Summary

The primary key for correctivelens class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-CoverSheetId'></a>
### CoverSheetId `property`

##### Summary

The primary key for coversheet class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-CreatedDate'></a>
### CreatedDate `property`

##### Summary

Date the document was created. Please use createddatetime instead.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-CreatedDateTime'></a>
### CreatedDateTime `property`

##### Summary

Date/Time (ISO 8601) the document was created

<a name='P-AthenaHealth-Sdk-Models-Response-Document-DeclinedReasonText'></a>
### DeclinedReasonText `property`

##### Summary



<a name='P-AthenaHealth-Sdk-Models-Response-Document-DeclinedReasons'></a>
### DeclinedReasons `property`

##### Summary



<a name='P-AthenaHealth-Sdk-Models-Response-Document-DeletedDateTime'></a>
### DeletedDateTime `property`

##### Summary

Date/time (ISO 8601) the document was deleted

<a name='P-AthenaHealth-Sdk-Models-Response-Document-DepartmentId'></a>
### DepartmentId `property`

##### Summary

Department for the document

<a name='P-AthenaHealth-Sdk-Models-Response-Document-DmeId'></a>
### DmeId `property`

##### Summary

The primary key for dme class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-DocumentClass'></a>
### DocumentClass `property`

##### Summary

Class of document

<a name='P-AthenaHealth-Sdk-Models-Response-Document-DocumentDescription'></a>
### DocumentDescription `property`

##### Summary

Description of the document type

<a name='P-AthenaHealth-Sdk-Models-Response-Document-DocumentId'></a>
### DocumentId `property`

##### Summary

ID for the document. Note that in documents/{documentclass} calls, this will become an ID
named after the document class (e.g. rtoid or letterid).

<a name='P-AthenaHealth-Sdk-Models-Response-Document-DocumentRoute'></a>
### DocumentRoute `property`

##### Summary

Explains method by which the document was entered into the AthenaNet (INTERFACE
(digital), FAX, etc.)

<a name='P-AthenaHealth-Sdk-Models-Response-Document-DocumentSource'></a>
### DocumentSource `property`

##### Summary

Explains where this document originated (e.g. ENCOUNTER, PORTAL, etc.)

<a name='P-AthenaHealth-Sdk-Models-Response-Document-DocumentSubclass'></a>
### DocumentSubclass `property`

##### Summary

Specific type of document

<a name='P-AthenaHealth-Sdk-Models-Response-Document-DocumentType'></a>
### DocumentType `property`

##### Summary

The description for this document

<a name='P-AthenaHealth-Sdk-Models-Response-Document-DocumentTypeId'></a>
### DocumentTypeId `property`

##### Summary

The ID of the description for this document

<a name='P-AthenaHealth-Sdk-Models-Response-Document-ElectronicReferralId'></a>
### ElectronicReferralId `property`

##### Summary

The primary key for electronicreferral class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-EncounterDocumentId'></a>
### EncounterDocumentId `property`

##### Summary

The primary key for encounterdocument class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-EncounterId'></a>
### EncounterId `property`

##### Summary

Encounter ID

<a name='P-AthenaHealth-Sdk-Models-Response-Document-ExternalAccessionId'></a>
### ExternalAccessionId `property`

##### Summary

The external accession ID for this document. Format depends on the system the ID belongs to.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-ExternalNote'></a>
### ExternalNote `property`

##### Summary

External note for the patient

<a name='P-AthenaHealth-Sdk-Models-Response-Document-HospitalId'></a>
### HospitalId `property`

##### Summary

The primary key for hospital class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-HtmlId'></a>
### HtmlId `property`

##### Summary

The primary key for html class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-ImagingResultId'></a>
### ImagingResultId `property`

##### Summary

The primary key for imagingresult class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-InternalAccessionId'></a>
### InternalAccessionId `property`

##### Summary

The internal accession ID for this document. Format depends on the system the ID belongs to.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-InternalNote'></a>
### InternalNote `property`

##### Summary

The 'Internal Note' attached to this document

<a name='P-AthenaHealth-Sdk-Models-Response-Document-InterpretationId'></a>
### InterpretationId `property`

##### Summary

The primary key for interpretation class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-LabResultId'></a>
### LabResultId `property`

##### Summary

The primary key for labresult class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-LastModifiedDateTime'></a>
### LastModifiedDateTime `property`

##### Summary

Date/time (ISO 8601) the document was last modified

<a name='P-AthenaHealth-Sdk-Models-Response-Document-LetterId'></a>
### LetterId `property`

##### Summary

The primary key for letter class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-MedNotificationId'></a>
### MedNotificationId `property`

##### Summary

The primary key for mednotification class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-MedicalRecordId'></a>
### MedicalRecordId `property`

##### Summary

The primary key for medicalrecord class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-ObservationDateTime'></a>
### ObservationDateTime `property`

##### Summary

Date/time (ISO 8601) the observation was taken

<a name='P-AthenaHealth-Sdk-Models-Response-Document-OfficeNoteId'></a>
### OfficeNoteId `property`

##### Summary

The primary key for officenote class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-OrderId'></a>
### OrderId `property`

##### Summary

The primary key for order class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-PatientCaseId'></a>
### PatientCaseId `property`

##### Summary

The primary key for patientcase class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-PatientInfoId'></a>
### PatientInfoId `property`

##### Summary

The primary key for patientinfo class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-PatientRecordId'></a>
### PatientRecordId `property`

##### Summary

The primary key for patientrecord class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-PhoneMessageId'></a>
### PhoneMessageId `property`

##### Summary

The primary key for phonemessage class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-PhysicianAuthId'></a>
### PhysicianAuthId `property`

##### Summary

The primary key for physicianauth class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-PrescriptionId'></a>
### PrescriptionId `property`

##### Summary

The primary key for prescription class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-Priority'></a>
### Priority `property`

##### Summary

Document priority, when available.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-ProviderId'></a>
### ProviderId `property`

##### Summary

Provider ID for this document

<a name='P-AthenaHealth-Sdk-Models-Response-Document-ReceiverNote'></a>
### ReceiverNote `property`

##### Summary

External note sent to the receiving facility

<a name='P-AthenaHealth-Sdk-Models-Response-Document-RequisitionId'></a>
### RequisitionId `property`

##### Summary

The primary key for requisition class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-RtoId'></a>
### RtoId `property`

##### Summary

The primary key for rto class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-ShareableId'></a>
### ShareableId `property`

##### Summary

The primary key for shareable class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-Status'></a>
### Status `property`

##### Summary

Status of the document

<a name='P-AthenaHealth-Sdk-Models-Response-Document-Subject'></a>
### Subject `property`

##### Summary

Subject of the document

<a name='P-AthenaHealth-Sdk-Models-Response-Document-SurgeryId'></a>
### SurgeryId `property`

##### Summary

The primary key for surgery class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-SurgicalResultId'></a>
### SurgicalResultId `property`

##### Summary

The primary key for surgicalresult class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-TieToOrderId'></a>
### TieToOrderId `property`

##### Summary

Order ID of the order this document is tied to, if any

<a name='P-AthenaHealth-Sdk-Models-Response-Document-UnknownId'></a>
### UnknownId `property`

##### Summary

The primary key for unknown class of documents. This is in place of a documentid.

<a name='P-AthenaHealth-Sdk-Models-Response-Document-VaccineId'></a>
### VaccineId `property`

##### Summary

The primary key for vaccine class of documents. This is in place of a documentid.

<a name='T-AthenaHealth-Sdk-Models-Response-Encounter'></a>
## Encounter `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-AppointmentId'></a>
### AppointmentId `property`

##### Summary

Athena appointment ID resulting in this encounter

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-ClosedDate'></a>
### ClosedDate `property`

##### Summary

date when this encounter was closed

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-ClosedUser'></a>
### ClosedUser `property`

##### Summary

Username of the provider who closed this encounter

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athena department ID of this encounter

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-Diagnoses'></a>
### Diagnoses `property`

##### Summary

List of diagnoses for this encounter

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-EncounterDate'></a>
### EncounterDate `property`

##### Summary

Date when this encounter occured

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-EncounterType'></a>
### EncounterType `property`

##### Summary

Type of encounter (FLOWSHEET, ORDERSONLY, VISIT, etc.). By default only VISIT and ORDERSONLY are shown, use INCLUDEALLtypeS flag to see others.

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-EncounterVisitName'></a>
### EncounterVisitName `property`

##### Summary

The visit name for this encounter

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-Id'></a>
### Id `property`

##### Summary

Athena ID for this encounter

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-LastReopened'></a>
### LastReopened `property`

##### Summary

The date the encounter was last reopened. The field will not be present if the encounter has not be closed.

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-LastUpdated'></a>
### LastUpdated `property`

##### Summary

The date the encounter was last updated

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-PatientLocation'></a>
### PatientLocation `property`

##### Summary

Patient location

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-PatientStatus'></a>
### PatientStatus `property`

##### Summary

Patient status

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-PatientStatusId'></a>
### PatientStatusId `property`

##### Summary

Athena ID for the patient status

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-PatientlocationId'></a>
### PatientlocationId `property`

##### Summary

Athena ID for the patient location

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-ProviderFirstName'></a>
### ProviderFirstName `property`

##### Summary

First name of the provider for this encounter

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-ProviderId'></a>
### ProviderId `property`

##### Summary

The ID of the provider for this encounter

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-ProviderLastName'></a>
### ProviderLastName `property`

##### Summary

Last name of the provider for this encounter

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-ProviderPhone'></a>
### ProviderPhone `property`

##### Summary

Phone number of the provider for this encounter

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-Stage'></a>
### Stage `property`

##### Summary

Last stage of the encounter

<a name='P-AthenaHealth-Sdk-Models-Response-Encounter-Status'></a>
### Status `property`

##### Summary

Status of this encounter (CLOSED, OPEN, PEND). By default only OPEN, CLOSED, and REVIEW statuses are shown, use INCLUDEALLSTATUSES flag to see others.

<a name='T-AthenaHealth-Sdk-Clients-EncounterClient'></a>
## EncounterClient `type`

##### Namespace

AthenaHealth.Sdk.Clients

<a name='M-AthenaHealth-Sdk-Clients-EncounterClient-GetDiagnoses-System-Int32-'></a>
### GetDiagnoses(encounterId) `method`

##### Summary

The list of diagnoses for this encounter.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| encounterId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-AthenaHealth-Sdk-Clients-EncounterClient-GetSummary-System-Int32,AthenaHealth-Sdk-Models-Request-GetEncounterSummaryFilter-'></a>
### GetSummary(encounterId,filter) `method`

##### Summary

The HTML Summary for an encounter.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| encounterId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| filter | [AthenaHealth.Sdk.Models.Request.GetEncounterSummaryFilter](#T-AthenaHealth-Sdk-Models-Request-GetEncounterSummaryFilter 'AthenaHealth.Sdk.Models.Request.GetEncounterSummaryFilter') |  |

<a name='T-AthenaHealth-Sdk-Models-Request-EncounterGetOrderByIdFilter'></a>
## EncounterGetOrderByIdFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-EncounterGetOrderByIdFilter-ShowExternalCodes'></a>
### ShowExternalCodes `property`

##### Summary

If set, translate the order information to relevant external vocabularies, where available.
Examples are medications to RxNorm and NDC, vaccines to CVX and MVX, labs to LOINC, etc. Mappings are not exhaustive.

<a name='P-AthenaHealth-Sdk-Models-Request-EncounterGetOrderByIdFilter-ShowQuestions'></a>
### ShowQuestions `property`

##### Summary

BETA FIELD: Some order types like labs and imaging orders have additional pertinant information in a question/answer format.
Setting this will return that data.

<a name='T-AthenaHealth-Sdk-Models-Request-EncounterGetOrdersFilter'></a>
## EncounterGetOrdersFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-EncounterGetOrdersFilter-AllowDischargeType'></a>
### AllowDischargeType `property`

##### Summary

If set, this will allow getting orders for a discharge encounter type.

<a name='P-AthenaHealth-Sdk-Models-Request-EncounterGetOrdersFilter-ShowClinicalProvider'></a>
### ShowClinicalProvider `property`

##### Summary

If set, this will show the information about the provider receiving the order.

<a name='P-AthenaHealth-Sdk-Models-Request-EncounterGetOrdersFilter-ShowDeclinedOrders'></a>
### ShowDeclinedOrders `property`

##### Summary

If set, include orders that were declined.

<a name='P-AthenaHealth-Sdk-Models-Request-EncounterGetOrdersFilter-ShowExternalCodes'></a>
### ShowExternalCodes `property`

##### Summary

If set, translate the order information to relevant external vocabularies, where available.
Examples are medications to RxNorm and NDC, vaccines to CVX and MVX, labs to LOINC, etc. Mappings are not exhaustive.

<a name='T-AthenaHealth-Sdk-Models-Response-EncounterOrder'></a>
## EncounterOrder `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrder-Class'></a>
### Class `property`

##### Summary

The primary class of this order -- PRESCRIPTION, VACCINE, LAB, IMAGING, PATIENTINFO, etc.

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrder-ClassDescription'></a>
### ClassDescription `property`

##### Summary

The human-readable description of this document class, including sub class (prescription - new vs. prescription - renewal).

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrder-ClinicalProvider'></a>
### ClinicalProvider `property`

##### Summary

Details about the provider the order is sent to.

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrder-ClinicalProviderId'></a>
### ClinicalProviderId `property`

##### Summary

ID of the clinical provider

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrder-DateOrdered'></a>
### DateOrdered `property`

##### Summary

The timestamp when the order was created.

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrder-DepartmentId'></a>
### DepartmentId `property`

##### Summary

Department ID of the provider.

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrder-Description'></a>
### Description `property`

##### Summary

A human readable description for this order.

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrder-DiagnosisList'></a>
### DiagnosisList `property`

##### Summary

List of Diagnosis related to this order.

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrder-DocumentationOnly'></a>
### DocumentationOnly `property`

##### Summary

If true, this order is here just as a record, and does not need to actually go out.

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrder-Id'></a>
### Id `property`

##### Summary

The order (aka document) ID for this order.

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrder-OrderType'></a>
### OrderType `property`

##### Summary

The type of this order (Lab, Vaccine, etc.)

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrder-OrderTypeId'></a>
### OrderTypeId `property`

##### Summary

The athena ID for this type of order. Can be used to create another order of this type.

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrder-OrderingProvider'></a>
### OrderingProvider `property`

##### Summary

The username of the ordering provider, which is different than the ordering user -- who may be an intake nurse for example.

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrder-SpecimenCollectionSite'></a>
### SpecimenCollectionSite `property`

##### Summary

Gives the location of the clinical specimen collected if any.

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrder-Status'></a>
### Status `property`

##### Summary

The status the document is in (PEND, CLOSED, SUBMIT, SUBMITTED, etc).

<a name='T-AthenaHealth-Sdk-Models-Response-EncounterOrdersResponse'></a>
## EncounterOrdersResponse `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrdersResponse-Diagnosis'></a>
### Diagnosis `property`

##### Summary

The name of the diagnosis

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrdersResponse-DiagnosisIcd'></a>
### DiagnosisIcd `property`

##### Summary

The matching ICD9 or ICD10 codes for this diagnosis, where available.

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrdersResponse-DiagnosisSnomed'></a>
### DiagnosisSnomed `property`

##### Summary

The SNOMED code for this diagnosis. 0 means No Diagnosis.

<a name='P-AthenaHealth-Sdk-Models-Response-EncounterOrdersResponse-Orders'></a>
### Orders `property`

##### Summary

List of orders for this diagnosis.

<a name='T-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter'></a>
## EnhancedBestmatchFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-DateOfBirth'></a>
### DateOfBirth `property`

##### Summary

Patient's DOB (mm/dd/yyyy).

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

This is the ID for the department of the patient you are retrieving. If you are calling
this on an enterprise practice with multiple financial groups (also called "provider
groups"), this will ensure you are retrieving the correct patient and not a copy that is
in a different department.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-Email'></a>
### Email `property`

##### Summary

Patient's email address.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-FirstName'></a>
### FirstName `property`

##### Summary

Patient's first name.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-GuarantorEmail'></a>
### GuarantorEmail `property`

##### Summary

Guarantor's email address.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-GuarantorPhone'></a>
### GuarantorPhone `property`

##### Summary

Guarantor's phone number.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-HomePhone'></a>
### HomePhone `property`

##### Summary

The patient's home phone number.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-IgnoreRestrictions'></a>
### IgnoreRestrictions `property`

##### Summary

Set to true to allow ability to find patients with record restrictions and blocked
patients. This should only be used when there is no reflection to the patient at all that
a match was found or not found.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-LastName'></a>
### LastName `property`

##### Summary

Patient's last name.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-LimitLocalPatientId'></a>
### LimitLocalPatientId `property`

##### Summary

If set, will return local patient id tied to the passed in DepartmentID.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-MinScore'></a>
### MinScore `property`

##### Summary

If you are only interested in matching a patient if they are above a specific confidence
level, you can use this to require any patient matched to have a score greater than or
equal to this value.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-MobilePhone'></a>
### MobilePhone `property`

##### Summary

The patient's mobile phone number.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-PreferredName'></a>
### PreferredName `property`

##### Summary

Patient's preferred name (or nickname).

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ReturnBestMatches'></a>
### ReturnBestMatches `property`

##### Summary

If this field is set to true, the top five patients with a score of 16 or above will be returned.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-Show2015EdCehrtValues'></a>
### Show2015EdCehrtValues `property`

##### Summary

Use 2015 Ed. CEHRT compliant strings for describing gender identity and sexual orientation.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowAllClaims'></a>
### ShowAllClaims `property`

##### Summary

Include information on claims where there is no outstanding patient balance. (Only to be
used when showbalancedetails is selected.)

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowAllPatientDepartmentStatus'></a>
### ShowAllPatientDepartmentStatus `property`

##### Summary

Include an array of all departments the patient is a part of along with all statuses for
those departments.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowBalanceDetails'></a>
### ShowBalanceDetails `property`

##### Summary

Show detailed information on patient balances.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowCustomFields'></a>
### ShowCustomFields `property`

##### Summary

Include custom fields for the patient.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowFullSsn'></a>
### ShowFullSsn `property`

##### Summary

If set, will show full SSN instead of a masked number.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowInsurance'></a>
### ShowInsurance `property`

##### Summary

Include patient insurance information.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowLocalPatientId'></a>
### ShowLocalPatientId `property`

##### Summary

If set, will show local patient id.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-ShowPortalStatus'></a>
### ShowPortalStatus `property`

##### Summary

If set, will include portal enrollment status in response.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-Ssn'></a>
### Ssn `property`

##### Summary

Patient's social security number.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-Suffix'></a>
### Suffix `property`

##### Summary

Patient's name suffix.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-UseSoundexSearch'></a>
### UseSoundexSearch `property`

##### Summary

If this field is set to true, search patients based on a soundex search. Soundex
searching is disabled by default.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-WorkPhone'></a>
### WorkPhone `property`

##### Summary

The patient's work phone number. Generally not used to contact a patient.

<a name='P-AthenaHealth-Sdk-Models-Request-EnhancedBestmatchFilter-Zip'></a>
### Zip `property`

##### Summary

Patient's zip.

<a name='T-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Event'></a>
## Event `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.PatientMedication.Medication

<a name='T-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event'></a>
## Event `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.ProblemResponse.Problem

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Event-EventDate'></a>
### EventDate `property`

##### Summary

The date this event occurred

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Event-Type'></a>
### Type `property`

##### Summary

The event type. Can be START, END, ORDER, ENTER, FILL, or HIDE.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Event-UserDisplayName'></a>
### UserDisplayName `property`

##### Summary

The display name for the user most relevant for this event. May be null.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-CreatedBy'></a>
### CreatedBy `property`

##### Summary

The name of the user who entered this problem.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-CreatedDate'></a>
### CreatedDate `property`

##### Summary

The date that the user entered this problem.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Diagnoses'></a>
### Diagnoses `property`

##### Summary

List of encounter diagnoses that triggered this problem.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-EncounterDate'></a>
### EncounterDate `property`

##### Summary

The date of the encounter where a diagnosis matching this problem was used.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-EndDate'></a>
### EndDate `property`

##### Summary

The date this problem event ended or was hidden

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-EventType'></a>
### EventType `property`

##### Summary

The type of this event: START, END, HIDDEN, REACTIVATED, or ENCOUNTER

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Laterality'></a>
### Laterality `property`

##### Summary

The laterality of this problem. Can be null, LEFT, RIGHT, or BILATERAL.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Note'></a>
### Note `property`

##### Summary

The note attached to this event.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-OnsetDate'></a>
### OnsetDate `property`

##### Summary

The specified onset date for this problem, as entered by the practice. If available this is more accurate than the start date.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Source'></a>
### Source `property`

##### Summary

The source of this event: ENCOUNTER or HISTORY

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-StartDate'></a>
### StartDate `property`

##### Summary

The date this problem event started or was restarted. Uses the onsetdate if available, otherwise uses the date the problem was entered into the system.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Event-Status'></a>
### Status `property`

##### Summary

The status of this problem event: CHRONIC or ACUTE

<a name='T-AthenaHealth-Sdk-Models-Response-Appointment-ExpectedProcedureCode'></a>
## ExpectedProcedureCode `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Appointment

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-ExpectedProcedureCode-ProcedureCode'></a>
### ProcedureCode `property`

##### Summary

The ID of the code.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-ExpectedProcedureCode-ProcedureCodeDescription'></a>
### ProcedureCodeDescription `property`

##### Summary

The description of the code.

<a name='T-AthenaHealth-Sdk-Models-Response-Facility'></a>
## Facility `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-Facility-Address'></a>
### Address `property`

##### Summary

The physical address of the facility

<a name='P-AthenaHealth-Sdk-Models-Response-Facility-City'></a>
### City `property`

##### Summary

The city of the facility

<a name='P-AthenaHealth-Sdk-Models-Response-Facility-Distance'></a>
### Distance `property`

##### Summary

How far the facility is from the department or patient (if patientid is given), in miles.

<a name='P-AthenaHealth-Sdk-Models-Response-Facility-FaxNumber'></a>
### FaxNumber `property`

##### Summary

The fax number of the facility

<a name='P-AthenaHealth-Sdk-Models-Response-Facility-Id'></a>
### Id `property`

##### Summary

The athena ID of this facility, to be used when adding orders

<a name='P-AthenaHealth-Sdk-Models-Response-Facility-Name'></a>
### Name `property`

##### Summary

The name of the facility

<a name='P-AthenaHealth-Sdk-Models-Response-Facility-NcpdpId'></a>
### NcpdpId `property`

##### Summary

The NCPDP ID of the given facility, if applicable.

<a name='P-AthenaHealth-Sdk-Models-Response-Facility-PharmacyType'></a>
### PharmacyType `property`

##### Summary

For pharmacies, whether this is a RETAIL or MAILORDER pharmacy.

<a name='P-AthenaHealth-Sdk-Models-Response-Facility-PhoneNumber'></a>
### PhoneNumber `property`

##### Summary

The phone number of the facility

<a name='P-AthenaHealth-Sdk-Models-Response-Facility-State'></a>
### State `property`

##### Summary

The state of the facility

<a name='P-AthenaHealth-Sdk-Models-Response-Facility-ZipCode'></a>
### ZipCode `property`

##### Summary

The zip code of the facility

<a name='T-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Finding'></a>
## Finding `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraph.Sentence

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Finding-Name'></a>
### Name `property`

##### Summary

The name of the finding.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Finding-Note'></a>
### Note `property`

##### Summary

The note for the finding selected.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Finding-SelectedOptions'></a>
### SelectedOptions `property`

##### Summary

The option in the finding that was selected by the user.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Finding-Text'></a>
### Text `property`

##### Summary

Freetext that could be associated with this finding.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Finding-Type'></a>
### Type `property`

##### Summary

Describes the finding - either NORMAL, ABNORMAL, or NEUTRAL.

<a name='T-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter'></a>
## GetAnalytesFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-AllResultsByEncounterId'></a>
### AllResultsByEncounterId `property`

##### Summary

ID used to return lab results for a specific encounter.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-AnalyteResultStatus'></a>
### AnalyteResultStatus `property`

##### Summary

Filter the results based on the analyte's result status. Since the result status is a
free text field, this list is not exhaustive, but does represent a majority of the used statuses.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department id.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-EndDate'></a>
### EndDate `property`

##### Summary

Filter lab orders not individual results that are on or before this date. Example:
enddate=1/21/2018. If no enddate is specified, all lab orders found since startdate will
be included if specified.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-ExactDuplicateDocumentId'></a>
### ExactDuplicateDocumentId `property`

##### Summary

ID used when the lab results sends the exact same result multiple times.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-LabResultStatus'></a>
### LabResultStatus `property`

##### Summary

Filter the results based on the lab result's result status. Since the result status is a
free text field, this list is not exhaustive, but does represent a majority of the used statuses.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 1000, max 10000). Please note that this endpoint has
a different default and max than normal.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-ShowAbnormalDetails'></a>
### ShowAbnormalDetails `property`

##### Summary

Include the translation of the abnormalflag into HL7 code standards.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-ShowHidden'></a>
### ShowHidden `property`

##### Summary

Includes the lab results and analytes marked as hidden. Hidden lab results and analytes
are created when they are manually entered, for example on the qm tab or in flowsheets.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-ShowTemplate'></a>
### ShowTemplate `property`

##### Summary

If true, interpretation template added to the document is also returned.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-StartDate'></a>
### StartDate `property`

##### Summary

Filter lab orders not individual results that are on or after this date. Example:
startdate=6/21/2015. If no startdate is specified, all prior lab orders will be included
until enddate if specified.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAnalytesFilter-SupersedEdDocumentId'></a>
### SupersedEdDocumentId `property`

##### Summary

ID used when the lab sends a result and later sends a more complete version of the result
with additional information.

<a name='T-AthenaHealth-Sdk-Models-Request-GetAppointmentFilter'></a>
## GetAppointmentFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentFilter-IgnoreRestrictions'></a>
### IgnoreRestrictions `property`

##### Summary

When showing patient detail for appointments, the patient information for patients with record restrictions and blocked patients will not be shown.  Setting this flag to true will show that information for those patients.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentFilter-ShowClaimDetail'></a>
### ShowClaimDetail `property`

##### Summary

Include claim information, if available, associated with an appointment.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentFilter-ShowCopay'></a>
### ShowCopay `property`

##### Summary

By default, the expected co-pay is returned. For performance purposes, you can set this to false and copay will not be populated.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentFilter-ShowExpectedProcedureCodes'></a>
### ShowExpectedProcedureCodes `property`

##### Summary

Show the expected procedure codes.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentFilter-ShowInsurance'></a>
### ShowInsurance `property`

##### Summary

Include patient insurance information. Shows insurance packages for the appointment if any are selected, and all patient packages otherwise.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentFilter-ShowPatientDetail'></a>
### ShowPatientDetail `property`

##### Summary

Include patient information for each patient associated with an appointment.

<a name='T-AthenaHealth-Sdk-Models-Request-GetAppointmentInsurancesFilter'></a>
## GetAppointmentInsurancesFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentInsurancesFilter-AppointmentId'></a>
### AppointmentId `property`

##### Summary

Appointment id

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentInsurancesFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 100, max 5000)Please note that this endpoint has a different default than normal.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentInsurancesFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentInsurancesFilter-ShowCancelled'></a>
### ShowCancelled `property`

##### Summary

If set, include cancelled and expired insurances.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentInsurancesFilter-ShowFullSsn'></a>
### ShowFullSsn `property`

##### Summary

If set, will show full SSN instead of a masked number.

<a name='T-AthenaHealth-Sdk-Models-Request-GetAppointmentReasonsFilter'></a>
## GetAppointmentReasonsFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentReasonsFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department ID.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentReasonsFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 1500, max 5000)

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentReasonsFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentReasonsFilter-ProviderId'></a>
### ProviderId `property`

##### Summary

The athenaNet provider ID.

<a name='T-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter'></a>
## GetAppointmentSlotsFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-AppointmentTypeId'></a>
### AppointmentTypeId `property`

##### Summary

Normally, an appointment reason ID should be used which will map to the correct underlying appointment type in athenaNet. This field will ignore the practice's existing setup for what should be scheduled. Please consult with athenahealth before using. Either an appointmenttypeid or a reasonid must be specified or no results will be returned.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-BypassScheduleTimeChecks'></a>
### BypassScheduleTimeChecks `property`

##### Summary

Bypass checks that usually require returned appointments to be some amount of hours in the future (as configured by the practice, defaulting to 24 hours), and also ignores the setting that only shows appointments for a certain number of days in the future (also configurable by the practice, defaulting to 90 days).

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department ID.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-EndDate'></a>
### EndDate `property`

##### Summary

End of the appointment search date range (mm/dd/yyyy).  Inclusive. Defaults to seven days from startdate.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-IgnoreSchedulablePermission'></a>
### IgnoreSchedulablePermission `property`

##### Summary

By default, we show only appointments that are are available to scheduled via the API.   This flag allows you to bypass that restriction for viewing available appointments (but you still may not be able to schedule based on this permission!).  This flag does not, however, show the full schedule (that is, appointments that are already booked).

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 1000, max 10000)Please note that this endpoint has a different default and max than normal.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-ProviderId'></a>
### ProviderId `property`

##### Summary

The athenaNet provider ID. Required if a reasonid other than -1 is specified.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-ReasonId'></a>
### ReasonId `property`

##### Summary

The athenaNet patient appointment reason ID, from GET /patientappointmentreasons. While this is not technically required due to some unusual use cases, it is highly recommended for most calls. We do allow a special value of -1 for the reasonid. This reasonid will return open, web-schedulable slots regardless of reason.  However, slots returned using a search of -1 may return slots that are not bookable by any reason ID (they may be bookable by specific appointment type IDs instead).  This argument allows multiple valid reason IDs to be specified (e.g. reasonid=1,2,3), so if you are looking for slots that match "any" reason, it is recommended that you enumerate the set of reasons you are looking for.  Either a reasonid or an appointmenttypeid must be specified or no results will be returned. If a reasonid other than -1 is specified then a providerid must also be specified.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-ShowFrozenSlots'></a>
### ShowFrozenSlots `property`

##### Summary

By default, we hide appointments that are frozen from being returned via the API.   This flag allows you to show frozen slots in the set of results returned.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentSlotsFilter-StartDate'></a>
### StartDate `property`

##### Summary

Start of the appointment search date range (mm/dd/yyyy).  Inclusive.  Defaults to today.

<a name='T-AthenaHealth-Sdk-Models-Request-GetAppointmentSubscriptionsFilter'></a>
## GetAppointmentSubscriptionsFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentSubscriptionsFilter-IncludeReminderCall'></a>
### IncludeReminderCall `property`

##### Summary

If this is set, we will include the UpdateRemiderCall event as if it is one of the
default events. Otherwise we will ignore that it exists.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentSubscriptionsFilter-IncludeSuggestedOverbooking'></a>
### IncludeSuggestedOverbooking `property`

##### Summary

If this is set, we will include the UpdateSuggestedOverbooking event as if it is one of
the default events. Otherwise we will ignore that it exists.

<a name='T-AthenaHealth-Sdk-Models-Request-GetAppointmentTypeFilter'></a>
## GetAppointmentTypeFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentTypeFilter-DepartmentIds'></a>
### DepartmentIds `property`

##### Summary

A list of departmentids which when passed will filter the appointmenttypes having said departments. This is used along with providerids to fetch department/provider specific appointmenttypes.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentTypeFilter-HideGeneric'></a>
### HideGeneric `property`

##### Summary

By default, we show both generic and non-generic types. Setting this to true will hide the generic types (and show only non-generic types).

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentTypeFilter-HideNonGeneric'></a>
### HideNonGeneric `property`

##### Summary

By default, we show both generic and non-generic types. Setting this to true will hide non-generic types (and show only generic types).

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentTypeFilter-HideNonPatient'></a>
### HideNonPatient `property`

##### Summary

This defaults to true if not specified, and thus will hide non-patient facing types.  Setting this to false would thus show non-patient facing types.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentTypeFilter-HideTemplateTypeOnly'></a>
### HideTemplateTypeOnly `property`

##### Summary

By default, we show both "template only" and not-template only types. Setting this to true, the results will omit template only types. ("Template only" is a setting that makes the type appear in schedules, but forces users to select a non-template type upon booking.)

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentTypeFilter-ProviderIds'></a>
### ProviderIds `property`

##### Summary

A list of providerids which when passed will filter the appointmenttypes having said providers. This is used along with departmentids to fetch department/provider specific appointmenttypes.

<a name='T-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter'></a>
## GetAppointmentsBookedFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-AppointmentStatus'></a>
### AppointmentStatus `property`

##### Summary

Filter appointments by status.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-AppointmentTypeId'></a>
### AppointmentTypeId `property`

##### Summary

Filter by appointment type ID.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-DepartmentIds'></a>
### DepartmentIds `property`

##### Summary

The athenaNet department ID. Multiple IDs (either as a comma delimited list or multiple POSTed values) are allowed.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-EndDate'></a>
### EndDate `property`

##### Summary

End of the appointment search date range (mm/dd/yyyy).  Inclusive.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-EndLastModified'></a>
### EndLastModified `property`

##### Summary

Identify appointments modified prior to this date/time (mm/dd/yyyy hh:mi:ss).  Inclusive. Note: This can only be used if a startlastmodified value is supplied as well.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 1000, max 10000)Please note that this endpoint has a different default and max than normal.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-PatientId'></a>
### PatientId `property`

##### Summary

The athenaNet patient ID.  If operating in a Provider Group Enterprise practice, this should be the enterprise patient ID.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-ProviderId'></a>
### ProviderId `property`

##### Summary

The athenaNet provider ID.  Multiple IDs (either as a comma delimited list or multiple POSTed values) are allowed.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-ScheduledEndDate'></a>
### ScheduledEndDate `property`

##### Summary

End of the appointment scheduled search date range (mm/dd/yyyy).  Inclusive.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-ScheduledStartDate'></a>
### ScheduledStartDate `property`

##### Summary

Start of the appointment scheduled search date range (mm/dd/yyyy).  Inclusive.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-ShowCancelled'></a>
### ShowCancelled `property`

##### Summary

Include appointments that have been cancelled.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-ShowReminderCallDetail'></a>
### ShowReminderCallDetail `property`

##### Summary

Include all reminder call related results, if available, associated with an appointment.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-StartDate'></a>
### StartDate `property`

##### Summary

Start of the appointment search date range (mm/dd/yyyy).  Inclusive.

<a name='P-AthenaHealth-Sdk-Models-Request-GetAppointmentsBookedFilter-StartLastModified'></a>
### StartLastModified `property`

##### Summary

Identify appointments modified after this date/time (mm/dd/yyyy hh:mi:ss).  Inclusive.

<a name='T-AthenaHealth-Sdk-Models-Request-GetByIdProviderFilter'></a>
## GetByIdProviderFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetByIdProviderFilter-ShowFederalIdNumber'></a>
### ShowFederalIdNumber `property`

##### Summary

Possible values: 0 or 1
Include the provider's federal ID number in results.

<a name='T-AthenaHealth-Sdk-Models-Request-GetCommonInsurancePackageFilter'></a>
## GetCommonInsurancePackageFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetCommonInsurancePackageFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

Only look at patients who are associated with this department's provider group in determining which insurance packages to list.
Note that insurance packages do not "belong" to a department and thus department ID is not returned in the output.
The same insurance packages will (and often do) appear across multiple departments.

<a name='P-AthenaHealth-Sdk-Models-Request-GetCommonInsurancePackageFilter-ShowOnlyCasePolicies'></a>
### ShowOnlyCasePolicies `property`

##### Summary

If true only show the case policies.

<a name='T-AthenaHealth-Sdk-Models-Request-GetDepartmentFilter'></a>
## GetDepartmentFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetDepartmentFilter-HospitalOnly'></a>
### HospitalOnly `property`

##### Summary

If set to true, return hospital only departments.

<a name='P-AthenaHealth-Sdk-Models-Request-GetDepartmentFilter-ProviderList'></a>
### ProviderList `property`

##### Summary

If set to true, list providers who see patients in this department.
Default is false.

<a name='P-AthenaHealth-Sdk-Models-Request-GetDepartmentFilter-ShowAllDepartments'></a>
### ShowAllDepartments `property`

##### Summary

By default, departments hidden in the portal do not appear.
When this is set to true, that restriction is not applied.
Default is false.

<a name='T-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter'></a>
## GetDocumentsFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department id.

<a name='P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-DocumentClass'></a>
### DocumentClass `property`

##### Summary

The class(es) of document(s) comma separated.

<a name='P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-DocumentSubclass'></a>
### DocumentSubclass `property`

##### Summary

The document subclass to filter document results.

<a name='P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-EncounterId'></a>
### EncounterId `property`

##### Summary

Show only documents attached to this encounter.

<a name='P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 1000, max 10000). Please note that this endpoint has
a different default and max than normal.

<a name='P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-ShowDeclinedOrders'></a>
### ShowDeclinedOrders `property`

##### Summary

If set, include orders that were declined

<a name='P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-ShowDeleted'></a>
### ShowDeleted `property`

##### Summary

By default, deleted documents are not listed. Set to list these.

<a name='P-AthenaHealth-Sdk-Models-Request-GetDocumentsFilter-Status'></a>
### Status `property`

##### Summary

The status of the task to filter document results.

<a name='T-AthenaHealth-Sdk-Models-Request-GetEncounterSummaryFilter'></a>
## GetEncounterSummaryFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetEncounterSummaryFilter-Mobile'></a>
### Mobile `property`

##### Summary

Flag to skip many details to make the html smaller.

<a name='P-AthenaHealth-Sdk-Models-Request-GetEncounterSummaryFilter-SkipAmendments'></a>
### SkipAmendments `property`

##### Summary

Flag to skip encounter amendments.

<a name='T-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter'></a>
## GetLabResultsFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-AllResultsByEncounterId'></a>
### AllResultsByEncounterId `property`

##### Summary

ID used to return lab results for a specific encounter.

<a name='P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-AnalyteResultStatus'></a>
### AnalyteResultStatus `property`

##### Summary

Filter the results based on the analyte's result status. Since the result status is a
free text field, this list is not exhaustive, but does represent a majority of the used statuses.

<a name='P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department id.

<a name='P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-EndDate'></a>
### EndDate `property`

##### Summary

Filter lab orders not individual results that are on or before this date. Example:
enddate=1/21/2018. If no enddate is specified, all lab orders found since startdate will
be included if specified.

<a name='P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-ExactDuplicateDocumentId'></a>
### ExactDuplicateDocumentId `property`

##### Summary

ID used when the lab results sends the exact same result multiple times.

<a name='P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-LabResultStatus'></a>
### LabResultStatus `property`

##### Summary

Filter the results based on the lab result's result status. Since the result status is a
free text field, this list is not exhaustive, but does represent a majority of the used statuses.

<a name='P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 1000, max 10000). Please note that this endpoint has
a different default and max than normal.

<a name='P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-ShowAbnormalDetails'></a>
### ShowAbnormalDetails `property`

##### Summary

Include the translation of the abnormalflag into HL7 code standards.

<a name='P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-ShowHidden'></a>
### ShowHidden `property`

##### Summary

Includes the lab results and analytes marked as hidden. Hidden lab results and analytes
are created when they are manually entered, for example on the qm tab or in flowsheets.

<a name='P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-ShowTemplate'></a>
### ShowTemplate `property`

##### Summary

If true, interpretation template added to the document is also returned.

<a name='P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-StartDate'></a>
### StartDate `property`

##### Summary

Filter lab orders not individual results that are on or after this date. Example:
startdate=6/21/2015. If no startdate is specified, all prior lab orders will be included
until enddate if specified.

<a name='P-AthenaHealth-Sdk-Models-Request-GetLabResultsFilter-SupersedEdDocumentId'></a>
### SupersedEdDocumentId `property`

##### Summary

ID used when the lab sends a result and later sends a more complete version of the result
with additional information.

<a name='T-AthenaHealth-Sdk-Models-Request-GetMedicalHistoryQuestionsFilter'></a>
## GetMedicalHistoryQuestionsFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetMedicalHistoryQuestionsFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 1000, max 10000). Please note that this endpoint
has a different default and max than normal.

<a name='P-AthenaHealth-Sdk-Models-Request-GetMedicalHistoryQuestionsFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='P-AthenaHealth-Sdk-Models-Request-GetMedicalHistoryQuestionsFilter-ShowDeleted'></a>
### ShowDeleted `property`

##### Summary

The appointment slot to schedule into.

<a name='T-AthenaHealth-Sdk-Models-Request-GetMedicationsFilter'></a>
## GetMedicationsFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetMedicationsFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenanet department ID

<a name='P-AthenaHealth-Sdk-Models-Request-GetMedicationsFilter-MedicationType'></a>
### MedicationType `property`

##### Summary

Historical or Active or Denied. Will return a list of a patient's active or historical or
denied medications.

<a name='P-AthenaHealth-Sdk-Models-Request-GetMedicationsFilter-ShowNDC'></a>
### ShowNDC `property`

##### Summary

Shows the list of NDC numbers related to the medication.

<a name='P-AthenaHealth-Sdk-Models-Request-GetMedicationsFilter-ShowPending'></a>
### ShowPending `property`

##### Summary

Include pending medications associated with approved future orders. These medications
have not yet been submitted.

<a name='P-AthenaHealth-Sdk-Models-Request-GetMedicationsFilter-ShowRxNorm'></a>
### ShowRxNorm `property`

##### Summary

Shows the list of RxNorm Identifiers related to the medication. The list may contain both
branded and generic identifiers.

<a name='T-AthenaHealth-Sdk-Models-Request-GetPatientAppointmentFilter'></a>
## GetPatientAppointmentFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientAppointmentFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 1500, max 5000)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientAppointmentFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientAppointmentFilter-ShowCancelled'></a>
### ShowCancelled `property`

##### Summary

Show cancelled appointments

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientAppointmentFilter-ShowExpectedProcedureCodes'></a>
### ShowExpectedProcedureCodes `property`

##### Summary

Show expected procedure codes.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientAppointmentFilter-ShowPast'></a>
### ShowPast `property`

##### Summary

Show appointments that were before today

<a name='T-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter'></a>
## GetPatientByIdFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

This is the ID for the department of the patient you are retrieving. If you are calling this on an enterprise practice with multiple financial groups (also called "provider groups"), this will ensure you are retrieving the correct patient and not a copy that is in a different department.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-IgnoreRestrictions'></a>
### IgnoreRestrictions `property`

##### Summary

Set to true to allow ability to find patients with record restrictions and blocked patients. This should only be used when there is no reflection to the patient at all that a match was found or not found.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-LimitLocalPatientId'></a>
### LimitLocalPatientId `property`

##### Summary

If set, will return local patient id tied to the passed in DepartmentID.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-Show2015EdCehrtValues'></a>
### Show2015EdCehrtValues `property`

##### Summary

Use 2015 Ed. CEHRT compliant strings for describing gender identity and sexual orientation.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowAllClaims'></a>
### ShowAllClaims `property`

##### Summary

Include information on claims where there is no outstanding patient balance. (Only to be used when showbalancedetails is selected.)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowAllPatientDepartmentStatus'></a>
### ShowAllPatientDepartmentStatus `property`

##### Summary

Include an array of all departments the patient is a part of along with all statuses for those departments.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowBalanceDetails'></a>
### ShowBalanceDetails `property`

##### Summary

Show detailed information on patient balances.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowCustomFields'></a>
### ShowCustomFields `property`

##### Summary

Include custom fields for the patient.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowFullSsn'></a>
### ShowFullSsn `property`

##### Summary

If set, will show full SSN instead of a masked number.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowInsurance'></a>
### ShowInsurance `property`

##### Summary

Include patient insurance information.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowLocalPatientId'></a>
### ShowLocalPatientId `property`

##### Summary

If set, will show local patient id.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientByIdFilter-ShowPortalStatus'></a>
### ShowPortalStatus `property`

##### Summary

If set, will include portal enrollment status in response.

<a name='T-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter'></a>
## GetPatientEncountersFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-AppointmentId'></a>
### AppointmentId `property`

##### Summary

Find the encounter for this appointment.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department id.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-EndDate'></a>
### EndDate `property`

##### Summary

Omit any encounters later than this date

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 1000, max 10000). Please note that this endpoint has
a different default and max than normal.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-ProviderId'></a>
### ProviderId `property`

##### Summary

The ID of the provider for this encounter

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-ShowAllStatuses'></a>
### ShowAllStatuses `property`

##### Summary

By default only encounters in OPEN, CLOSED, or REVIEW status are retrieved, with this
flag, encounters aren't filtered by status.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-ShowAllTypes'></a>
### ShowAllTypes `property`

##### Summary

Retrieve all encounter types, by default only VISIT and ORDERSONLY are retrieved.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-ShowDiagnoses'></a>
### ShowDiagnoses `property`

##### Summary

Query diagnosis information for every encounter

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientEncountersFilter-StartDate'></a>
### StartDate `property`

##### Summary

Omit any encounters earlier than this date

<a name='T-AthenaHealth-Sdk-Models-Request-GetPatientInsurancesFilter'></a>
## GetPatientInsurancesFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientInsurancesFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

If set, we will use the department id in an attempt to find the local patient.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientInsurancesFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 100, max 5000). Please note that this endpoint has a
different default than normal.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientInsurancesFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientInsurancesFilter-ShowCancelled'></a>
### ShowCancelled `property`

##### Summary

If set, include cancelled and expired insurances.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientInsurancesFilter-ShowFullSSN'></a>
### ShowFullSSN `property`

##### Summary

If set, will show full SSN instead of a masked number.

<a name='T-AthenaHealth-Sdk-Models-Request-GetPatientProblemsFilter'></a>
## GetPatientProblemsFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientProblemsFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department id.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientProblemsFilter-ShowDiagnosisInfo'></a>
### ShowDiagnosisInfo `property`

##### Summary

If true, will include every encounter and associated diagnosis with each problem. Also
fills the bestmatchicd10code field with the best conversion from the problem SNOMED code
to ICD10 code if there is no user-selected ICD10 code in an encounter diagnosis event.
Please note that the bestmatchicd10code may not always be accurate.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientProblemsFilter-ShowInactive'></a>
### ShowInactive `property`

##### Summary

Also show inactive (but not soft deleted) problems.

<a name='T-AthenaHealth-Sdk-Models-Request-GetPatientsFilter'></a>
## GetPatientsFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Address1'></a>
### Address1 `property`

##### Summary

Patient's address - 1st line (Max length: 100)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Address2'></a>
### Address2 `property`

##### Summary

Patient's address - 2nd line (Max length: 100)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-AgriculturalWorker'></a>
### AgriculturalWorker `property`

##### Summary

Used to identify this patient as an agricultural worker. Only settable if client has
Social Determinant fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-AgriculturalWorkerType'></a>
### AgriculturalWorkerType `property`

##### Summary

For patients that are agricultural workers, identifies the type of worker. Only settable
if client has Social Determinant fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-AnyPhone'></a>
### AnyPhone `property`

##### Summary

Any phone number for the patient. Patient phone numbers and other data may change, and
one phone number may be associated with multiple patients. You are responsible for taking
additional steps to verify patient identity and for using this data in accordance with
applicable law, including HIPAA.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-AppointmentDepartmentId'></a>
### AppointmentDepartmentId `property`

##### Summary

The ID of the department associated with the upcoming appointment.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-AppointmentProviderId'></a>
### AppointmentProviderId `property`

##### Summary

The ID of the provider associated with the upcoming appointment.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-CareSummaryDeliveryPreference'></a>
### CareSummaryDeliveryPreference `property`

##### Summary

The patient's preference for care summary delivery. (Max length: 50)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-City'></a>
### City `property`

##### Summary

Patient's city (Max length: 30)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ClinicalOrderTypeGroupId'></a>
### ClinicalOrderTypeGroupId `property`

##### Summary

The clinical order type group of the clinical provider (Prescription: 10, Lab: 11,
Vaccinations: 16).

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ConsentToCall'></a>
### ConsentToCall `property`

##### Summary

The flag is used to record the consent of a patient to receive automated calls per FCC
requirements. The requested legal language is 'Entry of any telephone contact number
constitutes written consent to receive any automated, prerecorded, and artificial voice
telephone calls initiated by the Practice. To alter or revoke this consent, visit the
Patient Portal "Contact Preferences" page.'

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ConsentToText'></a>
### ConsentToText `property`

##### Summary

The flag is used to record the consent of a patient to receive text messages per FCC
requirements. In order for this to be true, a valid mobile phone number must be set and
the practice setting "Hide SMS Opt-in option" must be set to Off.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactHomePhone'></a>
### ContactHomePhone `property`

##### Summary

Emergency contact home phone. Invalid numbers in a GET/PUT will be ignored. Patient phone
numbers and other data may change, and one phone number may be associated with multiple
patients. You are responsible for taking additional steps to verify patient identity and
for using this data in accordance with applicable law, including HIPAA. Invalid numbers
in a POST will be ignored, possibly resulting in an error. (Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactMobilePhone'></a>
### ContactMobilePhone `property`

##### Summary

Emergency contact mobile phone. Invalid numbers in a GET/PUT will be ignored. Patient
phone numbers and other data may change, and one phone number may be associated with
multiple patients. You are responsible for taking additional steps to verify patient
identity and for using this data in accordance with applicable law, including HIPAA.
Invalid numbers in a POST will be ignored, possibly resulting in an error. (Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactName'></a>
### ContactName `property`

##### Summary

The name of the (emergency) person to contact about the patient. The contactname,
contactrelationship, contacthomephone, and contactmobilephone fields are all related to
the emergency contact for the patient. They are NOT related to the contractpreference_*
fields. (Max length: 50)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreference'></a>
### ContactPreference `property`

##### Summary

The MU-required field for "preferred contact method". This is not used by any automated systems.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceAnnouncementEmail'></a>
### ContactPreferenceAnnouncementEmail `property`

##### Summary

If set, the patient has indicated a preference to get or not get "announcement"
communications delivered via email. Note that this will not be present if the practice or
patient has not set it.For completeness, turning email off is supported via the API, but
it is discouraged. When email is off, patients may not not get messages from the patient portal.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceAnnouncementPhone'></a>
### ContactPreferenceAnnouncementPhone `property`

##### Summary

If set, the patient has indicated a preference to get or not get "announcement"
communications delivered via phone. Note that this will not be present if the practice or
patient has not set it.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceAnnouncementSms'></a>
### ContactPreferenceAnnouncementSms `property`

##### Summary

If set, the patient has indicated a preference to get or not get "announcement"
communications delivered via SMS. Note that this will not be present if the practice or
patient has not set it.For SMS, there is specific terms of service language that must be
used when displaying this as an option to be turned on. Turning on must be an action by
the patient, not a practice user.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceAppointmentEmail'></a>
### ContactPreferenceAppointmentEmail `property`

##### Summary

If set, the patient has indicated a preference to get or not get "appointment"
communications delivered via email. Note that this will not be present if the practice or
patient has not set it.For completeness, turning email off is supported via the API, but
it is discouraged. When email is off, patients may not not get messages from the patient portal.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceAppointmentPhone'></a>
### ContactPreferenceAppointmentPhone `property`

##### Summary

If set, the patient has indicated a preference to get or not get "appointment"
communications delivered via phone. Note that this will not be present if the practice or
patient has not set it.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceAppointmentSms'></a>
### ContactPreferenceAppointmentSms `property`

##### Summary

If set, the patient has indicated a preference to get or not get "appointment"
communications delivered via SMS. Note that this will not be present if the practice or
patient has not set it.For SMS, there is specific terms of service language that must be
used when displaying this as an option to be turned on. Turning on must be an action by
the patient, not a practice user.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceBillingEmail'></a>
### ContactPreferenceBillingEmail `property`

##### Summary

If set, the patient has indicated a preference to get or not get "billing" communications
delivered via email. Note that this will not be present if the practice or patient has
not set it.For completeness, turning email off is supported via the API, but it is
discouraged. When email is off, patients may not not get messages from the patient portal.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceBillingPhone'></a>
### ContactPreferenceBillingPhone `property`

##### Summary

If set, the patient has indicated a preference to get or not get "billing" communications
delivered via phone. Note that this will not be present if the practice or patient has
not set it.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceBillingSms'></a>
### ContactPreferenceBillingSms `property`

##### Summary

If set, the patient has indicated a preference to get or not get "billing" communications
delivered via SMS. Note that this will not be present if the practice or patient has not
set it.For SMS, there is specific terms of service language that must be used when
displaying this as an option to be turned on. Turning on must be an action by the
patient, not a practice user.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceLabEmail'></a>
### ContactPreferenceLabEmail `property`

##### Summary

If set, the patient has indicated a preference to get or not get "lab" communications
delivered via email. Note that this will not be present if the practice or patient has
not set it.For completeness, turning email off is supported via the API, but it is
discouraged. When email is off, patients may not not get messages from the patient portal.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceLabPhone'></a>
### ContactPreferenceLabPhone `property`

##### Summary

If set, the patient has indicated a preference to get or not get "lab" communications
delivered via phone. Note that this will not be present if the practice or patient has
not set it.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactPreferenceLabSms'></a>
### ContactPreferenceLabSms `property`

##### Summary

If set, the patient has indicated a preference to get or not get "lab" communications
delivered via SMS. Note that this will not be present if the practice or patient has not
set it.For SMS, there is specific terms of service language that must be used when
displaying this as an option to be turned on. Turning on must be an action by the
patient, not a practice user.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ContactRelationship'></a>
### ContactRelationship `property`

##### Summary

Emergency contact relationship (one of SPOUSE, PARENT, CHILD, SIBLING, FRIEND, COUSIN,
GUARDIAN, OTHER)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-CountryCode3166'></a>
### CountryCode3166 `property`

##### Summary

Patient's country code (ISO 3166-1)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-DateOfBirth'></a>
### DateOfBirth `property`

##### Summary

Patient's DOB (mm/dd/yyyy)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-DeceasedDate'></a>
### DeceasedDate `property`

##### Summary

If present, the date on which a patient died.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-DefaultPharmacyNcpdpId'></a>
### DefaultPharmacyNcpdpId `property`

##### Summary

The NCPDP ID of the patient's preferred pharmacy. See http://www.ncpdp.org/ for details.
Note: if updating this field, please make sure to have a CLINICALORDERTYPEGROUPID field
as well.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

Primary (registration) department ID. A special value of -1 can be used to search for
cases where, due to an unusual import or other reasons, the registration department is
not set.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-DriversLicenseExpirationDate'></a>
### DriversLicenseExpirationDate `property`

##### Summary

The expiration date of the patient's driver's license.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-DriversLicenseNumber'></a>
### DriversLicenseNumber `property`

##### Summary

(Max length: 25)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-DriversLicenseStateId'></a>
### DriversLicenseStateId `property`

##### Summary

(Max length: 30)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Email'></a>
### Email `property`

##### Summary

Patient's email address. 'declined' can be used to indicate just that. (Max length: 50)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-EmployerId'></a>
### EmployerId `property`

##### Summary

The patient's employer's ID (from /employers call)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-EmployerPhone'></a>
### EmployerPhone `property`

##### Summary

The patient's employer's phone number. Normally, this is set by setting employerid.
However, setting this value can be used to override this on an individual patient.
Invalid numbers in a GET/PUT will be ignored. Patient phone numbers and other data may
change, and one phone number may be associated with multiple patients. You are
responsible for taking additional steps to verify patient identity and for using this
data in accordance with applicable law, including HIPAA. Invalid numbers in a POST will
be ignored, possibly resulting in an error. (Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-EthnicityCode'></a>
### EthnicityCode `property`

##### Summary

Ethnicity of the patient, using the 2.16.840.1.113883.5.50 codeset. See
http://www.hl7.org/implement/standards/fhir/terminologies-v3.html Special case: use
"declined" to indicate that the patient declined to answer.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-FirstName'></a>
### FirstName `property`

##### Summary

Patient's first name (Max length: 35)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorAddress1'></a>
### GuarantorAddress1 `property`

##### Summary

Guarantor's address (Max length: 100)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorAddress2'></a>
### GuarantorAddress2 `property`

##### Summary

Guarantor's address - line 2 (Max length: 100)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorCity'></a>
### GuarantorCity `property`

##### Summary

Guarantor's city (Max length: 30)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorCountryCode3166'></a>
### GuarantorCountryCode3166 `property`

##### Summary

Guarantor's country code (ISO 3166-1)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorDateOfBirth'></a>
### GuarantorDateOfBirth `property`

##### Summary

Guarantor's DOB (mm/dd/yyyy)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorEmail'></a>
### GuarantorEmail `property`

##### Summary

Guarantor's email address (Max length: 50)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorEmployerId'></a>
### GuarantorEmployerId `property`

##### Summary

The guaranror's employer's ID (from /employers call)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorFirstName'></a>
### GuarantorFirstName `property`

##### Summary

Guarantor's first name (Max length: 35)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorLastName'></a>
### GuarantorLastName `property`

##### Summary

Guarantor's last name (Max length: 60)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorMiddleName'></a>
### GuarantorMiddleName `property`

##### Summary

Guarantor's middle name (Max length: 25)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorPhone'></a>
### GuarantorPhone `property`

##### Summary

Guarantor's phone number. Invalid numbers in a GET/PUT will be ignored. Patient phone
numbers and other data may change, and one phone number may be associated with multiple
patients. You are responsible for taking additional steps to verify patient identity and
for using this data in accordance with applicable law, including HIPAA. Invalid numbers
in a POST will be ignored, possibly resulting in an error. (Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorRelationshipToPatient'></a>
### GuarantorRelationshipToPatient `property`

##### Summary

The guarantor's relationship to the patient

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorSSN'></a>
### GuarantorSSN `property`

##### Summary

Guarantor's SSN (Max length: 13)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorState'></a>
### GuarantorState `property`

##### Summary

Guarantor's state (2 letter abbreviation) (Max length: 10)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorSuffix'></a>
### GuarantorSuffix `property`

##### Summary

Guarantor's name suffix (Max length: 10)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuarantorZip'></a>
### GuarantorZip `property`

##### Summary

Guarantor's zip (Max length: 10)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuardianGirstName'></a>
### GuardianGirstName `property`

##### Summary

The first name of the patient's guardian. (Max length: 35)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuardianLastName'></a>
### GuardianLastName `property`

##### Summary

The last name of the patient's guardian. (Max length: 60)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuardianMiddleName'></a>
### GuardianMiddleName `property`

##### Summary

The middle name of the patient's guardian. (Max length: 25)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-GuardianSuffix'></a>
### GuardianSuffix `property`

##### Summary

The suffix of the patient's guardian. (Max length: 10)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-HasMobile'></a>
### HasMobile `property`

##### Summary

Set to false if a client has declined a phone number. (Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-HierarchicalCode'></a>
### HierarchicalCode `property`

##### Summary

The patient race hierarchical code

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-HomePhone'></a>
### HomePhone `property`

##### Summary

The patient's home phone number. Invalid numbers in a GET/PUT will be ignored. Patient
phone numbers and other data may change, and one phone number may be associated with
multiple patients. You are responsible for taking additional steps to verify patient
identity and for using this data in accordance with applicable law, including HIPAA.
Invalid numbers in a POST will be ignored, possibly resulting in an error. (Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Homebound'></a>
### Homebound `property`

##### Summary

If the patient is homebound, this is true.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Homeless'></a>
### Homeless `property`

##### Summary

Used to identify this patient as homeless. Only settable if client has Social Determinant
fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-HomelessType'></a>
### HomelessType `property`

##### Summary

For patients that are homeless, provides more detail regarding the patient's homeless
situation. Only settable if client has Social Determinant fields turned on. The
'Permanent Supportive Housing' option may only be used if the client has the
HCOGF_UDS_2019 rollout toggle turned on (it will be ignored otherwise).

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-IgnoreRestrictions'></a>
### IgnoreRestrictions `property`

##### Summary

Set to true to allow ability to find patients with record restrictions and blocked
patients. This should only be used when there is no reflection to the patient at all that
a match was found or not found. When COLCR_RETURN_CONFIDENTIALITY_CODE is ON, will also
add the confidentialitycode flag to the output for the patient.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-IndustryCode'></a>
### IndustryCode `property`

##### Summary

Industry of the patient, using the US Census industry code (code system
2.16.840.1.113883.6.310). "other" can be used as well.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Language6392Code'></a>
### Language6392Code `property`

##### Summary

Language of the patient, using the ISO 639.2 code.
(http://www.loc.gov/standards/iso639-2/php/code_list.php; "T" or terminology code)
Special case: use "declined" to indicate that the patient declined to answer.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-LastName'></a>
### LastName `property`

##### Summary

Patient's last name (Max length: 60)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 10, max 1000). Please note that this endpoint has a
different default and max than normal.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-MaritalStatus'></a>
### MaritalStatus `property`

##### Summary

Marital Status (D=Divorced, M=Married, S=Single, U=Unknown, W=Widowed, X=Separated, P=Partner)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-MiddleName'></a>
### MiddleName `property`

##### Summary

Patient's middle name (Max length: 25)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-MobileCarrierId'></a>
### MobileCarrierId `property`

##### Summary

The ID of the mobile carrier, from /mobilecarriers or the list below.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-MobilePhone'></a>
### MobilePhone `property`

##### Summary

The patient's mobile phone number. On input, 'declined' can be used to indicate no
number. (Alternatively, hasmobile can also be set to false. "declined" simply does this
for you.) Invalid numbers in a GET/PUT will be ignored. Patient phone numbers and other
data may change, and one phone number may be associated with multiple patients. You are
responsible for taking additional steps to verify patient identity and for using this
data in accordance with applicable law, including HIPAA. Invalid numbers in a POST will
be ignored, possibly resulting in an error. (Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-NextKinName'></a>
### NextKinName `property`

##### Summary

The full name of the next of kin. (Max length: 50)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-NextKinPhone'></a>
### NextKinPhone `property`

##### Summary

The next of kin phone number. Invalid numbers in a GET/PUT will be ignored. Patient phone
numbers and other data may change, and one phone number may be associated with multiple
patients. You are responsible for taking additional steps to verify patient identity and
for using this data in accordance with applicable law, including HIPAA. Invalid numbers
in a POST will be ignored, possibly resulting in an error. (Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-NextKinRelationship'></a>
### NextKinRelationship `property`

##### Summary

The next of kin relationship (one of SPOUSE, PARENT, CHILD, SIBLING, FRIEND, COUSIN,
GUARDIAN, OTHER)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Notes'></a>
### Notes `property`

##### Summary

Notes associated with this patient. (Max length: 4000)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-OccupationCode'></a>
### OccupationCode `property`

##### Summary

Occupation of the patient, using the US Census occupation code (code system
2.16.840.1.113883.6.240). "other" can be used as well.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-OmitBalances'></a>
### OmitBalances `property`

##### Summary

When true, current patient balances will not be calculated and the "balances" parameters
will be omitted, speeding up the /patients endpoint.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-OmitDefaultPharmacy'></a>
### OmitDefaultPharmacy `property`

##### Summary

When true, the default NCPDPID for patients will not be determined (and
"defaultpharmacyncpdpid' will be omitted), speeding up the /patients endpoint.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-OmitPhotoInformation'></a>
### OmitPhotoInformation `property`

##### Summary

When true, current patient photo information will not be determined (and "patientphoto"
and "patientphotourl" will be omitted), speeding up the /patients endpoint.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-OnlineStatementOnly'></a>
### OnlineStatementOnly `property`

##### Summary

Set to true if a patient wishes to get e-statements instead of paper statements. Should
only be set for patients with an email address and clients with athenaCommunicator. The
language we use in the portal is, "Future billing statements will be sent to you securely
via your Patient Portal account. You will receive an email notice when new statements are
available." This language is not required, but it is given as a suggestion. (Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PortalAccessGiven'></a>
### PortalAccessGiven `property`

##### Summary

This flag is set if the patient has been given access to the portal. This may be set by
the API user if a patient has been given access to the portal "by providing a preprinted
brochure or flyer showing the URL where patients can access their Patient Care
Summaries." The practiceinfo endpoint can provide the portal URL. While technically
allowed, it would be very unusual to set this to false via the API. (Max length: 1)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PovertyLevelCalculated'></a>
### PovertyLevelCalculated `property`

##### Summary

Patient's poverty level (% of the Federal Poverty Level), as calculated from family size,
income per pay period, pay period, and state. Typically only valued if client has Federal
Poverty Level fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PovertyLevelFamilySize'></a>
### PovertyLevelFamilySize `property`

##### Summary

Patient's family size (used for determining poverty level). Only settable if client has
Federal Poverty Level fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PovertyLevelFamilySizeDeclined'></a>
### PovertyLevelFamilySizeDeclined `property`

##### Summary

Indicates if the patient delcines to provide "povertylevelfamilysize". Should be set to
Yes if the patient declines.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PovertyLevelIncomeDeclined'></a>
### PovertyLevelIncomeDeclined `property`

##### Summary

Indicates if the patient delcines to provide "povertylevelincomeperpayperiod". Should be
set to Yes if the patient declines.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PovertyLevelIncomePayPeriod'></a>
### PovertyLevelIncomePayPeriod `property`

##### Summary

Patient's pay period (used for determining poverty level). Only settable if client has
Federal Poverty Level fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PovertyLevelIncomePerPayPeriod'></a>
### PovertyLevelIncomePerPayPeriod `property`

##### Summary

Patient's income per specified pay period (used for determining poverty level). Only
settable if client has Federal Poverty Level fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PovertyLevelIncomeRangeDeclined'></a>
### PovertyLevelIncomeRangeDeclined `property`

##### Summary

Indicates whether or not the patient declines to provide an income level.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PreferredName'></a>
### PreferredName `property`

##### Summary

The patient's preferred name (i.e. nickname). (Max length: 35)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PrimaryDepartmentId'></a>
### PrimaryDepartmentId `property`

##### Summary

The patient's "current" department. This field is not always set by the practice.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PrimaryProviderId'></a>
### PrimaryProviderId `property`

##### Summary

The "primary" provider for this patient, if set.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-PublicHousing'></a>
### PublicHousing `property`

##### Summary

Used to identify this patient as living in public housing. Only settable if client has
Social Determinant fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Race'></a>
### Race `property`

##### Summary

The patient race, using the 2.16.840.1.113883.5.104 codeset. See
http://www.hl7.org/implement/standards/fhir/terminologies-v3.html Special case: use
"declined" to indicate that the patient declined to answer. Multiple values or a
tab-seperated list of codes is acceptable for multiple races for input. The first race
will be considered "primary". Note: you must update all values at once if you update any.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-ReferralSourceId'></a>
### ReferralSourceId `property`

##### Summary

The referral / "how did you hear about us" ID.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-RegistrationDate'></a>
### RegistrationDate `property`

##### Summary

Date the patient was registered.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-SSN'></a>
### SSN `property`

##### Summary

(Max length: 13)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-SchoolBasedHealthCenter'></a>
### SchoolBasedHealthCenter `property`

##### Summary

Used to identify this patient as school-based health center patient. Only settable if
client has Social Determinant fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Sex'></a>
### Sex `property`

##### Summary

Patient's sex (M/F)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Show2015EdCehrtValues'></a>
### Show2015EdCehrtValues `property`

##### Summary

When true, 2015 Ed. CEHRT compliant strings will be returned for describing gender
identity and sexual orientation.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-State'></a>
### State `property`

##### Summary

Patient's state (2 letter abbreviation) (Max length: 10)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Status'></a>
### Status `property`

##### Summary

The "status" of the patient, one of active, inactive, prospective, or deleted.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Suffix'></a>
### Suffix `property`

##### Summary

Patient's name suffix (Max length: 10)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-UpcomingAppointmentHours'></a>
### UpcomingAppointmentHours `property`

##### Summary

Used to identify patients with appointments scheduled within the upcoming input hours
(maximum 24). Also includes results from the previous 2 hours.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Veteran'></a>
### Veteran `property`

##### Summary

Used to identify this patient as a veteran. Only settable if client has Social
Determinant fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-WorkPhone'></a>
### WorkPhone `property`

##### Summary

The patient's work phone number. Generally not used to contact a patient. Invalid numbers
in a GET/PUT will be ignored. Patient phone numbers and other data may change, and one
phone number may be associated with multiple patients. You are responsible for taking
additional steps to verify patient identity and for using this data in accordance with
applicable law, including HIPAA. Invalid numbers in a POST will be ignored, possibly
resulting in an error. (Max length: 20)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPatientsFilter-Zip'></a>
### Zip `property`

##### Summary

Patient's zip. Matching occurs on first 5 characters. (Max length: 10)

<a name='T-AthenaHealth-Sdk-Models-Request-GetPreferredPharmacyFilter'></a>
## GetPreferredPharmacyFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetPreferredPharmacyFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department id.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPreferredPharmacyFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 100, max 1000)Please note that this endpoint has a different default and max than normal.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPreferredPharmacyFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='T-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter'></a>
## GetPrescriptionsFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department id.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-DocumentClass'></a>
### DocumentClass `property`

##### Summary

The class(es) of document(s) comma separated.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-DocumentSubclass'></a>
### DocumentSubclass `property`

##### Summary

The document subclass to filter document results.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-EncounterId'></a>
### EncounterId `property`

##### Summary

Show only documents attached to this encounter.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 1500, max 5000)

<a name='P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-ShowDeclinedOrders'></a>
### ShowDeclinedOrders `property`

##### Summary

If set, include orders that were declined

<a name='P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-ShowDeleted'></a>
### ShowDeleted `property`

##### Summary

By default, deleted documents are not listed. Set to list these.

<a name='P-AthenaHealth-Sdk-Models-Request-GetPrescriptionsFilter-Status'></a>
### Status `property`

##### Summary

The status of the task to filter document results.

<a name='T-AthenaHealth-Sdk-Models-Request-GetProviderFilter'></a>
## GetProviderFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetProviderFilter-ProviderType'></a>
### ProviderType `property`

##### Summary

The provider type to filter the results on valid provider type
values can be found by using [GetProviderTypes](#M-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient-GetProviderTypes-AthenaHealth-Sdk-Models-Request-BaseLimitFilter- 'AthenaHealth.Sdk.Clients.Interfaces.IDictionaryClient.GetProviderTypes(AthenaHealth.Sdk.Models.Request.BaseLimitFilter)') GET /reference/providertypes.

<a name='P-AthenaHealth-Sdk-Models-Request-GetProviderFilter-ShowAllProviderIds'></a>
### ShowAllProviderIds `property`

##### Summary

In athenaNet's internal data structures,
a single provider can be represented by multiple IDs.
These IDs are used in certain external messages (e.g. HL7)
and thus these IDs may need to be known by the API user as well.
When set to true, a list of all of these ancillary IDs will be provided.
Default set to true.

<a name='P-AthenaHealth-Sdk-Models-Request-GetProviderFilter-ShowUsualDepartmentGuessThreshold'></a>
### ShowUsualDepartmentGuessThreshold `property`

##### Summary

Min: 0.0, Max: 1.0
There are situations where determining where a provider "normally" practices is desired.
Unfortunately, there is no such concept in athenaNet since providers often practice in multiple locations.
However, we can use some intelligence to determine this by looking back over the previous few months (90 days) to see actual practice.
To enable this, set this value between 0 and 1; it is highly recommended to be at least .5.
This is the ratio of appointments in a given department to the total number of appointments for that provider.
A value of .5 means "the provider's appointments are 50% in the department guessed."
Setting this to 1 would only return a department if ALL of the provider's appointments were in one department.

<a name='T-AthenaHealth-Sdk-Models-Request-GetSocialHistoryFilter'></a>
## GetSocialHistoryFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetSocialHistoryFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department id.

<a name='P-AthenaHealth-Sdk-Models-Request-GetSocialHistoryFilter-RecipientCategory'></a>
### RecipientCategory `property`

##### Summary

The intended audience for the data. If given, questions marked as confidential for this
audience will be withheld.

<a name='P-AthenaHealth-Sdk-Models-Request-GetSocialHistoryFilter-ShowNotPerformedQuestions'></a>
### ShowNotPerformedQuestions `property`

##### Summary

Include questions that the provider did not perform.

<a name='P-AthenaHealth-Sdk-Models-Request-GetSocialHistoryFilter-ShowUnansweredQuestions'></a>
### ShowUnansweredQuestions `property`

##### Summary

Include questions where there is no current answer.

<a name='T-AthenaHealth-Sdk-Models-Request-GetTopInsurancePackageFilter'></a>
## GetTopInsurancePackageFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetTopInsurancePackageFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

Only look at patients who are associated with this department's provider group in determining which insurance packages to list.
Note that insurance packages do not "belong" to a department and thus department ID is not returned in the output.
The same insurance packages will (and often do) appear across multiple departments.

<a name='T-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter'></a>
## GetWaitlistFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-AppointmentId'></a>
### AppointmentId `property`

##### Summary

The booked appointment ID of the appointment that this wait list entry would replace.

<a name='P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-AppointmentTypeId'></a>
### AppointmentTypeId `property`

##### Summary

The appointment type ID of the desired appointment.

<a name='P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-DayOfWeekIds'></a>
### DayOfWeekIds `property`

##### Summary

A list (JSON array) of day of week IDs that are desired by the patient, with 1 being Sunday, and 7 being Saturday.

<a name='P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The department ID of the desired department.  This can be blank if any department is acceptable.

<a name='P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-HourFrom'></a>
### HourFrom `property`

##### Summary

The hour (24 hour clock) after which an appointment is desired by a patient.  Inclusive.

<a name='P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-HourTo'></a>
### HourTo `property`

##### Summary

The hour (24 hour clock) before which an appointment is desired by a patient.  Inclusive.

<a name='P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-PatientId'></a>
### PatientId `property`

##### Summary

The patient ID of the patient who is on the wait list.

<a name='P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-Priority'></a>
### Priority `property`

##### Summary

Indicating the priority of this wait list entry.

<a name='P-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-ProviderId'></a>
### ProviderId `property`

##### Summary

The provider ID of the desired provider.  This can be blank if any provider is acceptable.

<a name='T-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient'></a>
## IAppointmentClient `type`

##### Namespace

AthenaHealth.Sdk.Clients.Interfaces

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-AddToWaitList-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest-'></a>
### AddToWaitList(request) `method`

##### Summary

Adds a wait list entry.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [AthenaHealth.Sdk.Models.Request.AddToWaitListRequest](#T-AthenaHealth-Sdk-Models-Request-AddToWaitListRequest 'AthenaHealth.Sdk.Models.Request.AddToWaitListRequest') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-CancelCheckIn-System-Int32-'></a>
### CancelCheckIn(appointmentId) `method`

##### Summary

Note that the check-in process was stopped and/or canceled. Likely called after [StartCheckIn](#M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-StartCheckIn-System-Int32- 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient.StartCheckIn(System.Int32)'). Can NOT be called after [CompleteCheckIn](#M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-CompleteCheckIn-System-Int32- 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient.CompleteCheckIn(System.Int32)').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-CompleteCheckIn-System-Int32-'></a>
### CompleteCheckIn(appointmentId) `method`

##### Summary

Completes the check in process for this appointment. Can NOT be called after [CancelCheckIn](#M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-CancelCheckIn-System-Int32- 'AthenaHealth.Sdk.Clients.Interfaces.IAppointmentClient.CancelCheckIn(System.Int32)').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-CreateNote-System-Int32,System-String,System-Boolean-'></a>
### CreateNote(appointmentId,text,displayOnSchedule) `method`

##### Summary

Add a note for an appointment.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The athenaNet Appointment ID. |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The note text. |
| displayOnSchedule | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Add appointment note to homepage display (defaults to false) |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-CreateReminder-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder-'></a>
### CreateReminder(reminder) `method`

##### Summary

Results for adding an appointment reminder for this practice.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reminder | [AthenaHealth.Sdk.Models.Request.CreateAppointmentReminder](#T-AthenaHealth-Sdk-Models-Request-CreateAppointmentReminder 'AthenaHealth.Sdk.Models.Request.CreateAppointmentReminder') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-DeleteReminderById-System-Int32-'></a>
### DeleteReminderById(appointmentReminderId) `method`

##### Summary

Results for deleting an appointment reminder for this practice.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentReminderId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-GetCheckInRequirements-System-Int32-'></a>
### GetCheckInRequirements(appointmentId) `method`

##### Summary

Returns the list of conditions required before check-in.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-GetNotes-System-Int32,System-Boolean-'></a>
### GetNotes(appointmentId,showDeleted) `method`

##### Summary

Retrieve notes for this appointment.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The athenaNet Appointment ID. |
| showDeleted | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | By default, we prevent deleted appointment notes from being returned via the API. This
flag allows you to show deleted notes in the set of results returned. |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-GetReminderById-System-Int32-'></a>
### GetReminderById(appointmentReminderId) `method`

##### Summary

Get a single appointment reminder for this practice.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentReminderId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-GetWaitList-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter-'></a>
### GetWaitList(filter) `method`

##### Summary

Returns entries on the wait list

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [AthenaHealth.Sdk.Models.Request.GetWaitlistFilter](#T-AthenaHealth-Sdk-Models-Request-GetWaitlistFilter 'AthenaHealth.Sdk.Models.Request.GetWaitlistFilter') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-SearchReminders-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter-'></a>
### SearchReminders(filter) `method`

##### Summary

Find appointment reminders for this practice.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [AthenaHealth.Sdk.Models.Request.SearchAppointmentRemindersFilter](#T-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter 'AthenaHealth.Sdk.Models.Request.SearchAppointmentRemindersFilter') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IAppointmentClient-StartCheckIn-System-Int32-'></a>
### StartCheckIn(appointmentId) `method`

##### Summary

The check-in process was started.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-AthenaHealth-Sdk-Http-IConnection'></a>
## IConnection `type`

##### Namespace

AthenaHealth.Sdk.Http

<a name='P-AthenaHealth-Sdk-Http-IConnection-BaseAddress'></a>
### BaseAddress `property`

##### Summary

Base url address

<a name='P-AthenaHealth-Sdk-Http-IConnection-Credentials'></a>
### Credentials `property`

##### Summary

Connection credentials

<a name='M-AthenaHealth-Sdk-Http-IConnection-Delete``1-System-String,System-Object-'></a>
### Delete\`\`1(relativeUrl,queryParameters) `method`

##### Summary

Sends DELETE request to url constructed from [BaseAddress](#P-AthenaHealth-Sdk-Http-IConnection-BaseAddress 'AthenaHealth.Sdk.Http.IConnection.BaseAddress') and `relativeUrl`.

##### Returns

Deserialized model

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| relativeUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Url relative to [BaseAddress](#P-AthenaHealth-Sdk-Http-IConnection-BaseAddress 'AthenaHealth.Sdk.Http.IConnection.BaseAddress'). |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameters to be added to constructed url. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Model type |

<a name='M-AthenaHealth-Sdk-Http-IConnection-Get``1-System-String,System-Object,System-Boolean-'></a>
### Get\`\`1(relativeUrl,queryParameters) `method`

##### Summary

Sends GET request to url constructed from [BaseAddress](#P-AthenaHealth-Sdk-Http-IConnection-BaseAddress 'AthenaHealth.Sdk.Http.IConnection.BaseAddress') and `relativeUrl`.

##### Returns

Deserialized model

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| relativeUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Url relative to [BaseAddress](#P-AthenaHealth-Sdk-Http-IConnection-BaseAddress 'AthenaHealth.Sdk.Http.IConnection.BaseAddress'). |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameters to be added to constructed url. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Model type |

<a name='M-AthenaHealth-Sdk-Http-IConnection-Post``1-System-String,System-Object,System-Object,System-Boolean-'></a>
### Post\`\`1(relativeUrl,queryParameters,body,asMultipart) `method`

##### Summary

Sends POST request to url constructed from [BaseAddress](#P-AthenaHealth-Sdk-Http-IConnection-BaseAddress 'AthenaHealth.Sdk.Http.IConnection.BaseAddress') and `relativeUrl`.

##### Returns

Deserialized model

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| relativeUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Url relative to [BaseAddress](#P-AthenaHealth-Sdk-Http-IConnection-BaseAddress 'AthenaHealth.Sdk.Http.IConnection.BaseAddress'). |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameters to be added to constructed url. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Request content |
| asMultipart | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Content should be sent as multipart |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Model type |

<a name='M-AthenaHealth-Sdk-Http-IConnection-Put``1-System-String,System-Object,System-Object-'></a>
### Put\`\`1(relativeUrl,queryParameters,body) `method`

##### Summary

Sends PUT request to url constructed from [BaseAddress](#P-AthenaHealth-Sdk-Http-IConnection-BaseAddress 'AthenaHealth.Sdk.Http.IConnection.BaseAddress') and `relativeUrl`.

##### Returns

Deserialized model

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| relativeUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Url relative to [BaseAddress](#P-AthenaHealth-Sdk-Http-IConnection-BaseAddress 'AthenaHealth.Sdk.Http.IConnection.BaseAddress'). |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameters to be added to constructed url. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Request content |

<a name='T-AthenaHealth-Sdk-Clients-Interfaces-IDepartmentClient'></a>
## IDepartmentClient `type`

##### Namespace

AthenaHealth.Sdk.Clients.Interfaces

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IDepartmentClient-SearchFacilities-AthenaHealth-Sdk-Models-Request-SearchFacilitiesFilter-'></a>
### SearchFacilities(filter) `method`

##### Summary

A text search for facilities of a particular type.
Examples include pharmacies, labs, imaging centers, and DME suppliers.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [AthenaHealth.Sdk.Models.Request.SearchFacilitiesFilter](#T-AthenaHealth-Sdk-Models-Request-SearchFacilitiesFilter 'AthenaHealth.Sdk.Models.Request.SearchFacilitiesFilter') |  |

<a name='T-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient'></a>
## IDictionaryClient `type`

##### Namespace

AthenaHealth.Sdk.Clients.Interfaces

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient-GetMedicalHistoryQuestions-AthenaHealth-Sdk-Models-Request-GetMedicalHistoryQuestionsFilter-'></a>
### GetMedicalHistoryQuestions(filter) `method`

##### Summary

Return a list of medical history questions.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [AthenaHealth.Sdk.Models.Request.GetMedicalHistoryQuestionsFilter](#T-AthenaHealth-Sdk-Models-Request-GetMedicalHistoryQuestionsFilter 'AthenaHealth.Sdk.Models.Request.GetMedicalHistoryQuestionsFilter') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient-GetPaymentMethods-AthenaHealth-Sdk-Models-Request-BaseLimitFilter-'></a>
### GetPaymentMethods(filter) `method`

##### Summary

Retrieves a list of valid credit card methods for practices not using CCP for use with [](#!-IPatientClient-RecordPayment 'IPatientClient.RecordPayment')

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [AthenaHealth.Sdk.Models.Request.BaseLimitFilter](#T-AthenaHealth-Sdk-Models-Request-BaseLimitFilter 'AthenaHealth.Sdk.Models.Request.BaseLimitFilter') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient-GetProviderTypes-AthenaHealth-Sdk-Models-Request-BaseLimitFilter-'></a>
### GetProviderTypes(filter) `method`

##### Summary

Get the list of valid provider types.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [AthenaHealth.Sdk.Models.Request.BaseLimitFilter](#T-AthenaHealth-Sdk-Models-Request-BaseLimitFilter 'AthenaHealth.Sdk.Models.Request.BaseLimitFilter') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient-SearchAllergiesByName-System-String-'></a>
### SearchAllergiesByName(name) `method`

##### Summary

Return a short list of matching allergies alias autocomplete.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A term to search for. Must be at least 2 characters. |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient-SearchMedicationsByName-System-String-'></a>
### SearchMedicationsByName(name) `method`

##### Summary

Return a list of matching medications alias autocomplete.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A term to search for. Must be at least 2 characters. |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient-SearchOrderTypesByName-System-String-'></a>
### SearchOrderTypesByName(name) `method`

##### Summary

The list of matching orders alias autocomplete.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A term to search for. Must be at least 2 characters. |

<a name='T-AthenaHealth-Sdk-Clients-Interfaces-IEncounterClient'></a>
## IEncounterClient `type`

##### Namespace

AthenaHealth.Sdk.Clients.Interfaces

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IEncounterClient-CreateOrderLab-System-Int32,AthenaHealth-Sdk-Models-Request-CreateOrderLab-'></a>
### CreateOrderLab(encounterId,model) `method`

##### Summary

Add a lab order.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| encounterId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The encounter ID to add this order to. |
| model | [AthenaHealth.Sdk.Models.Request.CreateOrderLab](#T-AthenaHealth-Sdk-Models-Request-CreateOrderLab 'AthenaHealth.Sdk.Models.Request.CreateOrderLab') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IEncounterClient-GetDiagnoses-System-Int32-'></a>
### GetDiagnoses(encounterId) `method`

##### Summary

The list of diagnoses for this encounter.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| encounterId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IEncounterClient-GetOrderById-System-Int32,System-Int32,AthenaHealth-Sdk-Models-Request-EncounterGetOrderByIdFilter-'></a>
### GetOrderById(encounterId,orderId,filter) `method`

##### Summary

Retrieve some data regarding an order, including the list of documents attached to the order.
Useful for finding attached letters, prescription renewal chains, and lab/imaging results.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| encounterId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| orderId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| filter | [AthenaHealth.Sdk.Models.Request.EncounterGetOrderByIdFilter](#T-AthenaHealth-Sdk-Models-Request-EncounterGetOrderByIdFilter 'AthenaHealth.Sdk.Models.Request.EncounterGetOrderByIdFilter') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IEncounterClient-GetOrders-System-Int32,AthenaHealth-Sdk-Models-Request-EncounterGetOrdersFilter-'></a>
### GetOrders(encounterId,filter) `method`

##### Summary

Given an encounter returns the list of orders broken down by diagnosis.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| encounterId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| filter | [AthenaHealth.Sdk.Models.Request.EncounterGetOrdersFilter](#T-AthenaHealth-Sdk-Models-Request-EncounterGetOrdersFilter 'AthenaHealth.Sdk.Models.Request.EncounterGetOrdersFilter') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IEncounterClient-GetSummary-System-Int32,AthenaHealth-Sdk-Models-Request-GetEncounterSummaryFilter-'></a>
### GetSummary(encounterId,filter) `method`

##### Summary

The HTML Summary for an encounter.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| encounterId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| filter | [AthenaHealth.Sdk.Models.Request.GetEncounterSummaryFilter](#T-AthenaHealth-Sdk-Models-Request-GetEncounterSummaryFilter 'AthenaHealth.Sdk.Models.Request.GetEncounterSummaryFilter') |  |

<a name='T-AthenaHealth-Sdk-Clients-Interfaces-IInsurancePackageClient'></a>
## IInsurancePackageClient `type`

##### Namespace

AthenaHealth.Sdk.Clients.Interfaces

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IInsurancePackageClient-GetCommon-AthenaHealth-Sdk-Models-Request-GetCommonInsurancePackageFilter-'></a>
### GetCommon(filter) `method`

##### Summary

Returns commonly used insurance packages used by a practice.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [AthenaHealth.Sdk.Models.Request.GetCommonInsurancePackageFilter](#T-AthenaHealth-Sdk-Models-Request-GetCommonInsurancePackageFilter 'AthenaHealth.Sdk.Models.Request.GetCommonInsurancePackageFilter') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IInsurancePackageClient-GetTop-AthenaHealth-Sdk-Models-Request-GetTopInsurancePackageFilter-'></a>
### GetTop(filter) `method`

##### Summary

The top athenaNet insurance packages (over .5% utilized, up to 100 packages total) used by the practice.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [AthenaHealth.Sdk.Models.Request.GetTopInsurancePackageFilter](#T-AthenaHealth-Sdk-Models-Request-GetTopInsurancePackageFilter 'AthenaHealth.Sdk.Models.Request.GetTopInsurancePackageFilter') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IInsurancePackageClient-Search-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-'></a>
### Search(filter) `method`

##### Summary

Search standard insurances based on input criteria.
Max results returned is 15. Please narrow the search criteria if result is not found.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter](#T-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter 'AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter') |  |

<a name='T-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient'></a>
## IPatientClient `type`

##### Namespace

AthenaHealth.Sdk.Clients.Interfaces

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-AddMedication-System-Int32,AthenaHealth-Sdk-Models-Response-AddMedication-'></a>
### AddMedication(patientId,medication) `method`

##### Summary

Output of adding a historical medication to patient chart.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| medication | [AthenaHealth.Sdk.Models.Response.AddMedication](#T-AthenaHealth-Sdk-Models-Response-AddMedication 'AthenaHealth.Sdk.Models.Response.AddMedication') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-CreateInsurance-System-Int32,AthenaHealth-Sdk-Models-Request-CreateInsurance-'></a>
### CreateInsurance(patientId,insurance) `method`

##### Summary

Creates patient insurances for a specified patient.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| insurance | [AthenaHealth.Sdk.Models.Request.CreateInsurance](#T-AthenaHealth-Sdk-Models-Request-CreateInsurance 'AthenaHealth.Sdk.Models.Request.CreateInsurance') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-DeleteInsurance-System-Int32,AthenaHealth-Sdk-Models-Enums-SequenceEnum,System-Nullable{System-Int32},System-String-'></a>
### DeleteInsurance(patientId,sequenceNumber,departmentId,cancellationNote) `method`

##### Summary

Deletes patient's insurance.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The athenaNet patient ID. |
| sequenceNumber | [AthenaHealth.Sdk.Models.Enums.SequenceEnum](#T-AthenaHealth-Sdk-Models-Enums-SequenceEnum 'AthenaHealth.Sdk.Models.Enums.SequenceEnum') |  |
| departmentId | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | If set, we will use the department id in an attempt to cancel insurance for the local patient. |
| cancellationNote | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional note as to why this is being cancelled. |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-DeleteInsuranceCardPhoto-System-Int32,System-Int32-'></a>
### DeleteInsuranceCardPhoto(patientId,insuranceId) `method`

##### Summary

Deletes patient insurance card photo

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| insuranceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-DeletePhoto-System-Int32-'></a>
### DeletePhoto(patientId) `method`

##### Summary

Deletes patient photo

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-GetInsuranceCardPhoto-System-Int32,System-Int32,System-Nullable{System-Boolean}-'></a>
### GetInsuranceCardPhoto(patientId,insuranceId,jpegOutput) `method`

##### Summary

Gets patient insurance card photo

##### Returns

Image bytes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| insuranceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| jpegOutput | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | If set to true, or if Accept header is image/jpeg, returns the image directly. (The
image may be scaled.) |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-GetPhoto-System-Int32,System-Nullable{System-Boolean}-'></a>
### GetPhoto(patientId,jpegOutput) `method`

##### Summary

Gets patient photo

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| jpegOutput | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | If set to true, or if Accept header is image/jpeg, returns the image directly. (The
image may be scaled.) |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-GetPrivacyInformation-System-Int32,System-Int32-'></a>
### GetPrivacyInformation(patientId,departmentId) `method`

##### Summary

In athenaNet, a practice has the flexibility to configure their patient registration page to display the Privacy Notice,
Release of Billing Information, and Assignment of Benefits consent forms as 1, 2, or 3
confirmation check boxes. This API returns a count of how many consent check boxes,
and the associated labels, that a practice has configured in athenaNet.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The athena ID of the patient whose privacy information was verified. |
| departmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The ID of the department where the privacy information was verified. |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-SetAllergies-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-'></a>
### SetAllergies(request) `method`

##### Summary

Updates patient allergy information

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [AthenaHealth.Sdk.Models.Request.SetPatientAllergies](#T-AthenaHealth-Sdk-Models-Request-SetPatientAllergies 'AthenaHealth.Sdk.Models.Request.SetPatientAllergies') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-SetMedicationSettings-System-Int32,AthenaHealth-Sdk-Models-Request-MedicationSetting-'></a>
### SetMedicationSettings(patientId,setting) `method`

##### Summary

Update the section wide note and no medications reported flag.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| setting | [AthenaHealth.Sdk.Models.Request.MedicationSetting](#T-AthenaHealth-Sdk-Models-Request-MedicationSetting 'AthenaHealth.Sdk.Models.Request.MedicationSetting') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-SetPatientDefaultLaboratory-System-Int32,System-Int32,System-Int32-'></a>
### SetPatientDefaultLaboratory(patientId,departmentId,clinicalProviderId) `method`

##### Summary

Sets patient default laboratory

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| departmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| clinicalProviderId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-SetPrivacyInformation-System-Int32,AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-'></a>
### SetPrivacyInformation(patientId,request) `method`

##### Summary

Please read the Privacy Information Verification documentation before using this API.
This API flags the patient privacy information (Privacy Notice, Release of Billing Information, and Assignment of Benefits) as having been verified.
If none of the three flags:
([PrivacyNotice](#P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-PrivacyNotice 'AthenaHealth.Sdk.Models.Request.SetPrivacyInformation.PrivacyNotice'),
[PatientSignature](#P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-PatientSignature 'AthenaHealth.Sdk.Models.Request.SetPrivacyInformation.PatientSignature'), and
[InsuredSignature](#P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-InsuredSignature 'AthenaHealth.Sdk.Models.Request.SetPrivacyInformation.InsuredSignature'))
are set to true, then this call will mark all three by default.
The three flags can be used in any combination. Note: This call can only be used to set the checkboxes.
There is currently no API to unset them.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| request | [AthenaHealth.Sdk.Models.Request.SetPrivacyInformation](#T-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation 'AthenaHealth.Sdk.Models.Request.SetPrivacyInformation') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-UpdateInsuranceCardPhoto-System-Int32,System-Int32,AthenaHealth-Sdk-Models-Request-UpdateInsuranceCardPhoto-'></a>
### UpdateInsuranceCardPhoto(patientId,insuranceId,request) `method`

##### Summary

Updates patient insurance card photo

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| insuranceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| request | [AthenaHealth.Sdk.Models.Request.UpdateInsuranceCardPhoto](#T-AthenaHealth-Sdk-Models-Request-UpdateInsuranceCardPhoto 'AthenaHealth.Sdk.Models.Request.UpdateInsuranceCardPhoto') |  |

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IPatientClient-UpdatePhoto-System-Int32,AthenaHealth-Sdk-Models-Request-UpdatePhoto-'></a>
### UpdatePhoto(patientId,request) `method`

##### Summary

Updates patient photo

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| request | [AthenaHealth.Sdk.Models.Request.UpdatePhoto](#T-AthenaHealth-Sdk-Models-Request-UpdatePhoto 'AthenaHealth.Sdk.Models.Request.UpdatePhoto') |  |

<a name='T-AthenaHealth-Sdk-Clients-Interfaces-IPracticeClient'></a>
## IPracticeClient `type`

##### Namespace

AthenaHealth.Sdk.Clients.Interfaces

<a name='M-AthenaHealth-Sdk-Clients-Interfaces-IPracticeClient-GetCurrentPractice-AthenaHealth-Sdk-Models-Request-BaseLimitFilter-'></a>
### GetCurrentPractice(filter) `method`

##### Summary

Returns [Practice](#T-AthenaHealth-Sdk-Models-Response-Practice 'AthenaHealth.Sdk.Models.Response.Practice') for [PracticeId](#P-AthenaHealth-Sdk-IAthenaHealthClient-PracticeId 'AthenaHealth.Sdk.IAthenaHealthClient.PracticeId').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [AthenaHealth.Sdk.Models.Request.BaseLimitFilter](#T-AthenaHealth-Sdk-Models-Request-BaseLimitFilter 'AthenaHealth.Sdk.Models.Request.BaseLimitFilter') |  |

<a name='T-AthenaHealth-Sdk-Models-Response-IcdCode'></a>
## IcdCode `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-IcdCode-Code'></a>
### Code `property`

##### Summary

Actual ICD code for this diagnosis

<a name='P-AthenaHealth-Sdk-Models-Response-IcdCode-Codeset'></a>
### Codeset `property`

##### Summary

Codeset for this code (ICD9 or ICD10)

<a name='P-AthenaHealth-Sdk-Models-Response-IcdCode-Description'></a>
### Description `property`

##### Summary

Brief description for this code

<a name='P-AthenaHealth-Sdk-Models-Response-IcdCode-DiagnosisCode'></a>
### DiagnosisCode `property`

##### Summary

Optional. Same as [Code](#P-AthenaHealth-Sdk-Models-Response-IcdCode-Code 'AthenaHealth.Sdk.Models.Response.IcdCode.Code'), but without ".", for ex. Code = "289.89", DiagnosisCode = "28989"

<a name='T-AthenaHealth-Sdk-Models-Enums-InputTypeEnum'></a>
## InputTypeEnum `type`

##### Namespace

AthenaHealth.Sdk.Models.Enums

<a name='F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-ApproxDate'></a>
### ApproxDate `constants`

##### Summary

A date in either YYYY, MM/YYYY, or MM/DD/YYYY format.

<a name='F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-AutoComplete'></a>
### AutoComplete `constants`

##### Summary

A free text field. While athena uses a drop down for it, users can enter any value in
the UI.

<a name='F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-CheckBox'></a>
### CheckBox `constants`

##### Summary

A true/false field. A null/blank is equivalent to false.

<a name='F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-Date'></a>
### Date `constants`

##### Summary

A date in MM/DD/YYYY format.

<a name='F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-DropDown'></a>
### DropDown `constants`

##### Summary

A selection from a list of valid values (given as a value/name pair).

<a name='F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-FreeText'></a>
### FreeText `constants`

##### Summary

A free text field (the length is not well defined). Not currently used. (Used for
RxNormName, but that shouldn't be an input field and will be deprecated from the
fielddata list.)

<a name='F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-Hidden'></a>
### Hidden `constants`

##### Summary

A read-only free text field. Currently only used for externalnote for medications with a
particular practice setting.

<a name='F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-Numeric'></a>
### Numeric `constants`

##### Summary

A real number.

<a name='F-AthenaHealth-Sdk-Models-Enums-InputTypeEnum-YesNo'></a>
### YesNo `constants`

##### Summary

A Y/N/null field. N and null will show up as different in reconciliation.

<a name='T-AthenaHealth-Sdk-Models-Response-Insurance'></a>
## Insurance `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-AdjusterFax'></a>
### AdjusterFax `property`

##### Summary

CASE POLICY FIELD - Fax for the adjuster on this case policy. Only available for auto
insurance or worker's comp case policies.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-AdjusterFirstName'></a>
### AdjusterFirstName `property`

##### Summary

CASE POLICY FIELD - First name of the adjuster on this case policy. Only available for
auto insurance or worker's comp case policies.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-AdjusterLastName'></a>
### AdjusterLastName `property`

##### Summary

CASE POLICY FIELD - Last name of the adjuster on this case policy. Only available for
auto insurance or worker's comp case policies.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-AdjusterPhone'></a>
### AdjusterPhone `property`

##### Summary

CASE POLICY FIELD - Phone number/other contact info for the adjuster on this case policy.
Only available for auto insurance or worker's comp case policies.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-AnotherPartyResponsible'></a>
### AnotherPartyResponsible `property`

##### Summary

CASE POLICY FIELD - Boolean field indicating if another party was responsible for this accident.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-AutoAccidentState'></a>
### AutoAccidentState `property`

##### Summary

CASE POLICY FIELD - Two-letter abbreviation for the state in which the auto accident took
place. Only meaningful for auto insurance case policies.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-Cancelled'></a>
### Cancelled `property`

##### Summary

The date in which the insurance was marked cancelled.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-CaseInjuryDate'></a>
### CaseInjuryDate `property`

##### Summary

CASE POLICY FIELD - Date of the injury. Required for auto insurance, legal, and worker's
comp case policies.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-CasePolicyTypeName'></a>
### CasePolicyTypeName `property`

##### Summary

CASE POLICY FIELD - The name of this type of case policy.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-CcmStatusId'></a>
### CcmStatusId `property`

##### Summary

Status ID of current CCM enrollment.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-CcmStatusName'></a>
### CcmStatusName `property`

##### Summary

The name of current CCM enrollment status.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-CoinsurancePercent'></a>
### CoinsurancePercent `property`

##### Summary

The coinsurance percentage for this insurance. If you've just POSTed a new insurance you
will have to wait for the auto eligbility check before this field populates.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-Copays'></a>
### Copays `property`

##### Summary

Details about the copays for this insurance package. If you've just POSTed a new
insurance you will have to wait for the auto eligibility check before these populate.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-DescriptionOfInjury'></a>
### DescriptionOfInjury `property`

##### Summary

CASE POLICY FIELD - A description of the injury. Only available for auto insurance and
worker's comp case policies.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-EligibilityLastChecked'></a>
### EligibilityLastChecked `property`

##### Summary

Date the eligibility was last checked.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-EligibilityMessage'></a>
### EligibilityMessage `property`

##### Summary

The message, usually from our engine, of the eligibility check.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-EligibilityReason'></a>
### EligibilityReason `property`

##### Summary

The source of the current status. Athena is our eligibility engine.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-EligibilityStatus'></a>
### EligibilityStatus `property`

##### Summary

Current eligibility status of this insurance package.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-EmployerId'></a>
### EmployerId `property`

##### Summary

The employer ID associated with the patient's insurance.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-ExpirationDate'></a>
### ExpirationDate `property`

##### Summary

Date the insurance expires.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-ICD10Codes'></a>
### ICD10Codes `property`

##### Summary

CASE POLICY FIELD - See documentation for ICD9CODES.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-ICD9Codes'></a>
### ICD9Codes `property`

##### Summary

CASE POLICY FIELD - A list of ICD9 accepted diagnosis codes. Only available for worker's
comp case policies.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InjuredBodyPart'></a>
### InjuredBodyPart `property`

##### Summary

CASE POLICY FIELD - Text field for describing the injured body part. Only available for
auto insurance and worker's comp case policies.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsuranceClaimNumber'></a>
### InsuranceClaimNumber `property`

##### Summary

CASE POLICY FIELD - The auto insurance claim number or the worker's comp claim number.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsuranceCompanyName'></a>
### InsuranceCompanyName `property`

##### Summary

Insurance category / company. E.g., United Healthcare, BCBS-MA, etc.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsuranceId'></a>
### InsuranceId `property`

##### Summary

The athena insurance policy ID.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsuranceIdNumber'></a>
### InsuranceIdNumber `property`

##### Summary

The insurance policy ID number (as presented on the insurance card itself).

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePackageAddress1'></a>
### InsurancePackageAddress1 `property`

##### Summary

Address 1 for the AthenaNet insurance Package.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePackageAddress2'></a>
### InsurancePackageAddress2 `property`

##### Summary

Address 2 for the AthenaNet insurance Package.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePackageCity'></a>
### InsurancePackageCity `property`

##### Summary

City for the AthenaNet insurance Package.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePackageId'></a>
### InsurancePackageId `property`

##### Summary

The athenaNet insurance package ID.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePackageState'></a>
### InsurancePackageState `property`

##### Summary

State of the AthenaNet insurance package.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePackageZip'></a>
### InsurancePackageZip `property`

##### Summary

Zip code of the AthenaNet insurance package

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePhone'></a>
### InsurancePhone `property`

##### Summary

The phone number for the insurance company. Note: This defaults to the insurance package
phone number. If this is set, it will override it. Likewise if blanked out, it will go
back to default.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePlanDisplayName'></a>
### InsurancePlanDisplayName `property`

##### Summary

Superpackagename of the specific insurance package.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePlanName'></a>
### InsurancePlanName `property`

##### Summary

Name of the specific insurance package.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolder'></a>
### InsurancePolicyHolder `property`

##### Summary

The full name of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderAddress1'></a>
### InsurancePolicyHolderAddress1 `property`

##### Summary

The first address line of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderAddress2'></a>
### InsurancePolicyHolderAddress2 `property`

##### Summary

The second address line of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderCity'></a>
### InsurancePolicyHolderCity `property`

##### Summary

The city of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderCountryCode'></a>
### InsurancePolicyHolderCountryCode `property`

##### Summary

The country code (3 letter) of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderCountryISO3166'></a>
### InsurancePolicyHolderCountryISO3166 `property`

##### Summary

The ISO 3166 country code of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderDateOfBirth'></a>
### InsurancePolicyHolderDateOfBirth `property`

##### Summary

The DOB of the insurance policy holder (mm/dd/yyyy).

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderFirstName'></a>
### InsurancePolicyHolderFirstName `property`

##### Summary

The first name of the insurance policy holder. Except for self-pay, required for new policies.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderLastName'></a>
### InsurancePolicyHolderLastName `property`

##### Summary

The last name of the insurance policy holder. Except for self-pay, required for new policies.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderMiddleName'></a>
### InsurancePolicyHolderMiddleName `property`

##### Summary

The middle name of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderSSN'></a>
### InsurancePolicyHolderSSN `property`

##### Summary

The SSN of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderSex'></a>
### InsurancePolicyHolderSex `property`

##### Summary

The sex of the insurance policy holder. Except for self-pay, required for new policies.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderState'></a>
### InsurancePolicyHolderState `property`

##### Summary

The state of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderSuffix'></a>
### InsurancePolicyHolderSuffix `property`

##### Summary

The suffix of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsurancePolicyHolderZip'></a>
### InsurancePolicyHolderZip `property`

##### Summary

The zip of the insurance policy holder.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsuranceType'></a>
### InsuranceType `property`

##### Summary

Type of insurance. E.g., Medicare Part B, Group Policy, HMO, etc.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsuredEntityTypeId'></a>
### InsuredEntityTypeId `property`

##### Summary

The ID of the entity type for this insurance.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-InsuredPrimaryCarePhysicianNationalProviderId'></a>
### InsuredPrimaryCarePhysicianNationalProviderId `property`

##### Summary

The national provider id of the primary care physician associated with the insurance.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-IssueDate'></a>
### IssueDate `property`

##### Summary

Date the insurance was issued.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-PolicyNumber'></a>
### PolicyNumber `property`

##### Summary

The insurance group number. This is sometimes present on an insurance card.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-RelatedToAutoAccident'></a>
### RelatedToAutoAccident `property`

##### Summary

CASE POLICY FIELD - Boolean field indicating whether this case policy is related to an
auto accident.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-RelatedToEmployment'></a>
### RelatedToEmployment `property`

##### Summary

CASE POLICY FIELD - Boolean field indicating whether this case policy is related to the
patient's employer.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-RelatedToOtherAccident'></a>
### RelatedToOtherAccident `property`

##### Summary

CASE POLICY FIELD - Boolean field indicating whether this case policy is related to
another accident. Only available for worker's comp case policies.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-RelationshipToInsured'></a>
### RelationshipToInsured `property`

##### Summary

This patient's relationship to the policy holder (text).

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-RelationshipToInsuredId'></a>
### RelationshipToInsuredId `property`

##### Summary

This patient's relationship to the policy holder (as an ID). See the mapping.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-RepricerName'></a>
### RepricerName `property`

##### Summary

CASE POLICY FIELD - Name for the repricer. Only available for worker's comp case policies.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-RepricerPhone'></a>
### RepricerPhone `property`

##### Summary

CASE POLICY FIELD - Phone number for the repricer. Only available for worker's comp case policies.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-SequenceNumber'></a>
### SequenceNumber `property`

##### Summary

1 = primary, 2 = secondary, 3 = tertiary, etc. Must have a primary before a secondary and
a secondary before a tertiary, etc.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-SlidingFeePlanId'></a>
### SlidingFeePlanId `property`

##### Summary

If the patient is on a sliding fee plan, this is the ID of that plan. See /slidingfeeplans.

<a name='P-AthenaHealth-Sdk-Models-Response-Insurance-StateOfReportedInjury'></a>
### StateOfReportedInjury `property`

##### Summary

CASE POLICY FIELD - Two-letter state abbreviation for the state this injury was reported
in. Only available for worker's comp case policies.

<a name='T-AthenaHealth-Sdk-Models-Response-InsurancePackage'></a>
## InsurancePackage `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-InsurancePackage-Address'></a>
### Address `property`

##### Summary

The first address line associated with this insurance package, often on the insurance card itself as a place to send claims.

<a name='P-AthenaHealth-Sdk-Models-Response-InsurancePackage-Address2'></a>
### Address2 `property`

##### Summary

The second address line associated with this insurance package.

<a name='P-AthenaHealth-Sdk-Models-Response-InsurancePackage-City'></a>
### City `property`

##### Summary

The city associated with this insurance package.

<a name='P-AthenaHealth-Sdk-Models-Response-InsurancePackage-Name'></a>
### Name `property`

##### Summary

The name of the insurance package.

<a name='P-AthenaHealth-Sdk-Models-Response-InsurancePackage-Phone'></a>
### Phone `property`

##### Summary

The phone number associated with this insurance package.

<a name='P-AthenaHealth-Sdk-Models-Response-InsurancePackage-State'></a>
### State `property`

##### Summary

The state associated with this insurance package.

<a name='P-AthenaHealth-Sdk-Models-Response-InsurancePackage-Zip'></a>
### Zip `property`

##### Summary

The zip code associated with this insurance package.

<a name='T-AthenaHealth-Sdk-Clients-InsurancePackageClient'></a>
## InsurancePackageClient `type`

##### Namespace

AthenaHealth.Sdk.Clients

<a name='M-AthenaHealth-Sdk-Clients-InsurancePackageClient-GetCommon-AthenaHealth-Sdk-Models-Request-GetCommonInsurancePackageFilter-'></a>
### GetCommon(filter) `method`

##### Summary

Returns commonly used insurance packages used by a practice.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [AthenaHealth.Sdk.Models.Request.GetCommonInsurancePackageFilter](#T-AthenaHealth-Sdk-Models-Request-GetCommonInsurancePackageFilter 'AthenaHealth.Sdk.Models.Request.GetCommonInsurancePackageFilter') |  |

<a name='M-AthenaHealth-Sdk-Clients-InsurancePackageClient-GetTop-AthenaHealth-Sdk-Models-Request-GetTopInsurancePackageFilter-'></a>
### GetTop(filter) `method`

##### Summary

The top athenaNet insurance packages (over .5% utilized, up to 100 packages total) used by the practice.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [AthenaHealth.Sdk.Models.Request.GetTopInsurancePackageFilter](#T-AthenaHealth-Sdk-Models-Request-GetTopInsurancePackageFilter 'AthenaHealth.Sdk.Models.Request.GetTopInsurancePackageFilter') |  |

<a name='M-AthenaHealth-Sdk-Clients-InsurancePackageClient-Search-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-'></a>
### Search(filter) `method`

##### Summary

Search standard insurances based on input criteria.
Max results returned is 15. Please narrow the search criteria if result is not found.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter](#T-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter 'AthenaHealth.Sdk.Models.Request.SearchInsuranceFilter') |  |

<a name='T-AthenaHealth-Sdk-Models-Response-InsurancePackageExtended'></a>
## InsurancePackageExtended `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-InsurancePackageExtended-AddressList'></a>
### AddressList `property`

##### Summary

The addresses associated with this insurance package. The default address is listed first.

<a name='P-AthenaHealth-Sdk-Models-Response-InsurancePackageExtended-Affiliations'></a>
### Affiliations `property`

##### Summary

The affiliations associated with this insurance package.

<a name='P-AthenaHealth-Sdk-Models-Response-InsurancePackageExtended-Id'></a>
### Id `property`

##### Summary

The athena insurance package ID.

<a name='P-AthenaHealth-Sdk-Models-Response-InsurancePackageExtended-InsurancePlanName'></a>
### InsurancePlanName `property`

##### Summary

Name of the specific insurance package.

<a name='T-AthenaHealth-Sdk-Models-Response-InsuredSignature'></a>
## InsuredSignature `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-InsuredSignature-EffectiveDate'></a>
### EffectiveDate `property`

##### Summary

Date the assignment of benefits check takes effect.

<a name='P-AthenaHealth-Sdk-Models-Response-InsuredSignature-ExpirationDate'></a>
### ExpirationDate `property`

##### Summary

Date the assignment of benefits check expires.

<a name='P-AthenaHealth-Sdk-Models-Response-InsuredSignature-IsOnFile'></a>
### IsOnFile `property`

##### Summary

Flag that indicates whether or not the assignment of benefits check is set.
This is set to false if it is expired.

<a name='T-AthenaHealth-Sdk-Models-Response-LabResult'></a>
## LabResult `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Analytes'></a>
### Analytes `property`

##### Summary

Individual lab result observations/analytes

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-AttachmentExists'></a>
### AttachmentExists `property`

##### Summary

This flag depicts if the lab result has a scanned document attachment or not.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Description'></a>
### Description `property`

##### Summary

Description for this lab result

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-ExactDuplicateDocumentId'></a>
### ExactDuplicateDocumentId `property`

##### Summary

The exactduplicatedocumentid of the document.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-FacilityId'></a>
### FacilityId `property`

##### Summary

The ID of the clinical provider associated with this clinical document. Clinical
providers are a master list of providers throughout the country. These include providers
as well as radiology centers, labs and pharmacies.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Id'></a>
### Id `property`

##### Summary

Athena ID for this lab result

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-InternalNote'></a>
### InternalNote `property`

##### Summary

The 'Internal Note' attached to this document.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-InterpretationTemplate'></a>
### InterpretationTemplate `property`

##### Summary

The interpretation template added to the lab result.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-LabResultDate'></a>
### LabResultDate `property`

##### Summary

Observation date associated with this lab result

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-LabResultDateTime'></a>
### LabResultDateTime `property`

##### Summary

The observation date and time associated with this lab result. Returned in mm/dd/yyyy
hh24:mi:ss format.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-LabResultLOINC'></a>
### LabResultLOINC `property`

##### Summary

The LOINC for the result document or associated order.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-LabresultNote'></a>
### LabresultNote `property`

##### Summary

Additional note associated with this lab result, if any

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-OrderId'></a>
### OrderId `property`

##### Summary

The athena ID of the associated order document

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-PatientNote'></a>
### PatientNote `property`

##### Summary

The external note for the patient.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-Priority'></a>
### Priority `property`

##### Summary

Document priority, when available. 1 is high, 2 is normal. Some labs use other numbers or
characters that are lab-specific.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-ProviderId'></a>
### ProviderId `property`

##### Summary

The provider ID for this document.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-ResultStatus'></a>
### ResultStatus `property`

##### Summary

The status of the result (e.g., "final", "preliminary", "corrected", etc.)

<a name='P-AthenaHealth-Sdk-Models-Response-LabResult-SupersedEdDocumentId'></a>
### SupersedEdDocumentId `property`

##### Summary

The supersededid of the Document.

<a name='T-AthenaHealth-Sdk-Models-Response-LabResultDetail'></a>
## LabResultDetail `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ActionNote'></a>
### ActionNote `property`

##### Summary

The most recent action note for a document

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-AlarmDays'></a>
### AlarmDays `property`

##### Summary

The number days, weeks, months, or year until a lab result document will go into followup
after being sent to the portal.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-AppointmentId'></a>
### AppointmentId `property`

##### Summary

The appointment ID for this document

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-AssignedTo'></a>
### AssignedTo `property`

##### Summary

Person the document is assigned to

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-CreatedDate'></a>
### CreatedDate `property`

##### Summary

Date the document was created. Please use createddatetime instead.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-CreatedDateTime'></a>
### CreatedDateTime `property`

##### Summary

Date/Time (ISO 8601) the document was created

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-CreatedUser'></a>
### CreatedUser `property`

##### Summary

The user who created this document.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-DeletedDateTime'></a>
### DeletedDateTime `property`

##### Summary

Date/time (ISO 8601) the document was deleted

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-DepartmentId'></a>
### DepartmentId `property`

##### Summary

Department for the document

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Description'></a>
### Description `property`

##### Summary

Description of the document type

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-DocumentClass'></a>
### DocumentClass `property`

##### Summary

Class of document

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-DocumentRoute'></a>
### DocumentRoute `property`

##### Summary

Explains method by which the document was entered into the AthenaNet (INTERFACE
(digital), FAX, etc.)

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-DocumentSource'></a>
### DocumentSource `property`

##### Summary

Explains where this document originated.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-DocumentSubclass'></a>
### DocumentSubclass `property`

##### Summary

Specific type of document

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-DocumentTypeId'></a>
### DocumentTypeId `property`

##### Summary

The ID of the description for this document

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-EncounterDate'></a>
### EncounterDate `property`

##### Summary

Date of the encounter associated with this document

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-EncounterId'></a>
### EncounterId `property`

##### Summary

Encounter ID

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ExternalAccessionId'></a>
### ExternalAccessionId `property`

##### Summary

The external accession ID for this document. Format depends on the system the ID belongs to.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ExternalNoteOnly'></a>
### ExternalNoteOnly `property`

##### Summary

External note for the patient.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-FacilityId'></a>
### FacilityId `property`

##### Summary

The ID of the clinical provider associated with this clinical document. Clinical
providers are a master list of providers throughout the country. These include providers
as well as radiology centers, labs and pharmacies.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Id'></a>
### Id `property`

##### Summary

The primary key for labresult class of documents

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-InternalAccessionId'></a>
### InternalAccessionId `property`

##### Summary

The internal accession ID for this document. Format depends on the system the ID belongs to.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-InternalNote'></a>
### InternalNote `property`

##### Summary

The 'Internal Note' attached to this document

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Interpretation'></a>
### Interpretation `property`

##### Summary

The practice entered interpretation of this result.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-InterpretationTemplate'></a>
### InterpretationTemplate `property`

##### Summary

The interpretation template added to the imaging result.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-IsConfidential'></a>
### IsConfidential `property`

##### Summary

If true, this result document should not be shown to the patient.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-LabresultLoinc'></a>
### LabresultLoinc `property`

##### Summary

Laboratory code that identifies the overall result.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-LastModifiedDate'></a>
### LastModifiedDate `property`

##### Summary

Date/time (ISO 8601) the document was last modified

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-LastModifiedDateTime'></a>
### LastModifiedDateTime `property`

##### Summary

Date/time (ISO 8601) the document was last modified

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-LastModifiedUser'></a>
### LastModifiedUser `property`

##### Summary

The user who last modified this document.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-NoteFromLab'></a>
### NoteFromLab `property`

##### Summary

A note from lab.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ObservationDate'></a>
### ObservationDate `property`

##### Summary

Date/time the observation was taken

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ObservationDateTime'></a>
### ObservationDateTime `property`

##### Summary

Date/time (ISO 8601) the observation was taken

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observations'></a>
### Observations `property`

##### Summary

Individual observation details

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-OrderType'></a>
### OrderType `property`

##### Summary

Order type group name

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Pages'></a>
### Pages `property`

##### Summary

An array of image pages associated with this document.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-PatientNote'></a>
### PatientNote `property`

##### Summary

A note about this lab result for the patient. This may or may not have been sent to the patient.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Priority'></a>
### Priority `property`

##### Summary

Document priority, when available. 1 is high, 2 is normal. Some labs use other numbers or
characters that are lab-specific.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ProviderId'></a>
### ProviderId `property`

##### Summary

Provider ID for this document

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ProviderUserName'></a>
### ProviderUserName `property`

##### Summary

The username of the provider associated with this lab result document.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ReportStatus'></a>
### ReportStatus `property`

##### Summary

The status of the report.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ResultNotes'></a>
### ResultNotes `property`

##### Summary

Result note on a document.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-ResultStatus'></a>
### ResultStatus `property`

##### Summary

The status of the result.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Status'></a>
### Status `property`

##### Summary

Status of the document

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Subject'></a>
### Subject `property`

##### Summary

Subject of the document

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-TieToOrderId'></a>
### TieToOrderId `property`

##### Summary

Order ID of the order this document is tied to, if any

<a name='T-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate'></a>
## LabResultInterpretationTemplate `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Name'></a>
### Name `property`

##### Summary

The name of the interpretation template.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Note'></a>
### Note `property`

##### Summary

The interpretation note.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraphs'></a>
### Paragraphs `property`

##### Summary

The paragraphs in the template.

<a name='T-AthenaHealth-Sdk-Models-Response-Laboratory'></a>
## Laboratory `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-Laboratory-AcceptFax'></a>
### AcceptFax `property`

##### Summary

Flag representing if the lab accepts fax

<a name='P-AthenaHealth-Sdk-Models-Response-Laboratory-Address1'></a>
### Address1 `property`

##### Summary

Address line 1 of the lab

<a name='P-AthenaHealth-Sdk-Models-Response-Laboratory-Address2'></a>
### Address2 `property`

##### Summary

Address line 2 of the lab

<a name='P-AthenaHealth-Sdk-Models-Response-Laboratory-City'></a>
### City `property`

##### Summary

City of the lab

<a name='P-AthenaHealth-Sdk-Models-Response-Laboratory-ClinicalProviderId'></a>
### ClinicalProviderId `property`

##### Summary

The athenaNet clinical provider ID.

<a name='P-AthenaHealth-Sdk-Models-Response-Laboratory-ClinicalProviderName'></a>
### ClinicalProviderName `property`

##### Summary

The lab name

<a name='P-AthenaHealth-Sdk-Models-Response-Laboratory-FaxNumber'></a>
### FaxNumber `property`

##### Summary

Fax number of the lab

<a name='P-AthenaHealth-Sdk-Models-Response-Laboratory-PhoneNumber'></a>
### PhoneNumber `property`

##### Summary

Phone number of the lab

<a name='P-AthenaHealth-Sdk-Models-Response-Laboratory-State'></a>
### State `property`

##### Summary

State of the lab

<a name='P-AthenaHealth-Sdk-Models-Response-Laboratory-Zip'></a>
### Zip `property`

##### Summary

Zip code of the lab

<a name='T-AthenaHealth-Sdk-Models-Response-MedicalHistory'></a>
## MedicalHistory `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Questions'></a>
### Questions `property`

##### Summary

List of questions corresponding to patient medical history

<a name='P-AthenaHealth-Sdk-Models-Response-MedicalHistory-SectionNote'></a>
### SectionNote `property`

##### Summary

Additional notes for the entire medical history section, if any

<a name='T-AthenaHealth-Sdk-Models-Response-MedicalHistoryQuestion'></a>
## MedicalHistoryQuestion `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-MedicalHistoryQuestion-Deleted'></a>
### Deleted `property`

##### Summary

True if this question has been deleted

<a name='P-AthenaHealth-Sdk-Models-Response-MedicalHistoryQuestion-DiagnosisCode'></a>
### DiagnosisCode `property`

##### Summary

Diagnosis code for the disease, if provided

<a name='P-AthenaHealth-Sdk-Models-Response-MedicalHistoryQuestion-Ordering'></a>
### Ordering `property`

##### Summary

Used for re-ordering questions

<a name='P-AthenaHealth-Sdk-Models-Response-MedicalHistoryQuestion-Question'></a>
### Question `property`

##### Summary

Disease being inquired about

<a name='P-AthenaHealth-Sdk-Models-Response-MedicalHistoryQuestion-QuestionId'></a>
### QuestionId `property`

##### Summary

Athena ID for the question

<a name='T-AthenaHealth-Sdk-Models-Response-Medication'></a>
## Medication `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='T-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication'></a>
## Medication `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.PatientMedication

<a name='P-AthenaHealth-Sdk-Models-Response-Medication-Id'></a>
### Id `property`

##### Summary

The athena ID of the medication.

<a name='P-AthenaHealth-Sdk-Models-Response-Medication-Name'></a>
### Name `property`

##### Summary

The name of the medication.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-ApprovedBy'></a>
### ApprovedBy `property`

##### Summary

For clinical prescriptions, the athenaNet username of the person who approved this prescription.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-BillingNDC'></a>
### BillingNDC `property`

##### Summary

The billing NDC code for this medication.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-CreatedBy'></a>
### CreatedBy `property`

##### Summary

The athenaNet username of the person who entered or ordered the medication.
Downloaded medications have INTERFACE for this field.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-EncounterId'></a>
### EncounterId `property`

##### Summary

If this was a prescription, this contains the ID of the encounter where it was
ordered or administered

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Events'></a>
### Events `property`

##### Summary

The list of events for this medication. Can be START, END, ORDER, ENTER, FILL, or HIDE.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-FutureSubmitDate'></a>
### FutureSubmitDate `property`

##### Summary

The date a medication will be submitted. Included if the medication is in PEND status
and attached to a approved future order.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-IsSafeToRenew'></a>
### IsSafeToRenew `property`

##### Summary



<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-IsStructuredSig'></a>
### IsStructuredSig `property`

##### Summary

Whether the sig for this entry is structured.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-MedicationEntryId'></a>
### MedicationEntryId `property`

##### Summary

Primary ID for this medication entry. Those starting with C are clinical
prescriptions, and those starting with H are historical (entered, downloaded, etc).

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-MedicationId'></a>
### MedicationId `property`

##### Summary

Athena ID for this medication.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Name'></a>
### Name `property`

##### Summary

The name of the medication.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-NdcOptions'></a>
### NdcOptions `property`

##### Summary

The list of NDC numbers that correspond to this medication.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-OrderingMode'></a>
### OrderingMode `property`

##### Summary

The ordering mode for prescriptions. Can be PRESCRIBE, DISPENSE, or ADMINISTER.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-OrganClass'></a>
### OrganClass `property`

##### Summary

The organ class for this medication. This is equivalent to a medication class.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-PatientNote'></a>
### PatientNote `property`

##### Summary

Patient-facing note for this prescription. Labeled "note" in the UI.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Pharmacy'></a>
### Pharmacy `property`

##### Summary

The name of the pharmacy where this medication was filled.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-PharmacyNcpdpId'></a>
### PharmacyNcpdpId `property`

##### Summary

The NCPDP ID of the pharmacy for this medication.. See http://www.ncpdp.org/ for details.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-PrescribedBy'></a>
### PrescribedBy `property`

##### Summary

The user who prescribed this medication.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-ProviderNote'></a>
### ProviderNote `property`

##### Summary

Non-patient facing note for ths prescription. Labeled "internal note" in the UI.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Quantity'></a>
### Quantity `property`

##### Summary

The total quantity prescribed, dispensed, administered. This is not currently
available for historical (downloaded) medications.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-QuantityUnit'></a>
### QuantityUnit `property`

##### Summary

The unit of the quantity. Example: tablets, sprays, etc.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-RefillsAllowed'></a>
### RefillsAllowed `property`

##### Summary

The number of refills allowed when this medication was ordered.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Route'></a>
### Route `property`

##### Summary

The route for the prescription.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-RxNorm'></a>
### RxNorm `property`

##### Summary

The list of RxNorm Identifiers that correspond to this medication. This list may
contain both branded and generic identifiers

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Source'></a>
### Source `property`

##### Summary

How this medication was entered. This can be the ordering provider, a medication
history download (express scripts, medco, etc), ATHENA (which means it was entered
manually), etc.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-Status'></a>
### Status `property`

##### Summary

The status of this medication. Medications in PEND status are associated with
approved future orders and have not yet been submitted.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StopReason'></a>
### StopReason `property`

##### Summary

The reason why this medication was stopped.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSig'></a>
### StructuredSig `property`

##### Summary

Components of the structured sig.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-TherapeuticClass'></a>
### TherapeuticClass `property`

##### Summary

The therapeutic class for this medication. This is equivalent to a medication subclass.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-UnstructuredSig'></a>
### UnstructuredSig `property`

##### Summary

The unstructured sig for this medication, if any. If there is a structured sig, this
will contain the formatted version of that sig.

<a name='T-AthenaHealth-Sdk-Models-Response-MedicationAddedResponse'></a>
## MedicationAddedResponse `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-MedicationAddedResponse-MedicationEntryId'></a>
### MedicationEntryId `property`

##### Summary

If successful, the athena ID of the newly created historical medication.

<a name='T-AthenaHealth-Sdk-Models-Request-MedicationSetting'></a>
## MedicationSetting `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-MedicationSetting-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenanet department ID.

<a name='P-AthenaHealth-Sdk-Models-Request-MedicationSetting-NoMedicationReported'></a>
### NoMedicationReported `property`

##### Summary

Set the "None Reported" checkbox indicating that no medications were reported for this patient.

<a name='P-AthenaHealth-Sdk-Models-Request-MedicationSetting-SectionNote'></a>
### SectionNote `property`

##### Summary

The section-wide note for medications.

<a name='T-AthenaHealth-Sdk-Models-Converters-ObjectToStringOrDelimitedStringConverter'></a>
## ObjectToStringOrDelimitedStringConverter `type`

##### Namespace

AthenaHealth.Sdk.Models.Converters

<a name='M-AthenaHealth-Sdk-Models-Converters-ObjectToStringOrDelimitedStringConverter-Convert-System-Object,System-String,System-Boolean-'></a>
### Convert(value,delimiter,encloseArrayInSquareBrackets) `method`

##### Summary

If array, converts object to string delimited with the given delimiter with or without enclosing square brackets.
E.g. new int[] {1, 2} converts to "1,2" or "[1,2]"
     new string[] {"a", "b"} converts to "a,b" or "[a,b]"
Otherwise, performs json serialization.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Object to be converted |
| delimiter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Delimiter |
| encloseArrayInSquareBrackets | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, result is enclosed in square brackets, e.g. "[1,2]". If false, result would be "1,2" |

<a name='T-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation'></a>
## Observation `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.LabResultDetail

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-AbnormalFlag'></a>
### AbnormalFlag `property`

##### Summary

The level of normality for this result.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-AnalyteId'></a>
### AnalyteId `property`

##### Summary

The athena ID for this analyte. Used to update the analyte.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-AnalyteName'></a>
### AnalyteName `property`

##### Summary

The name / identifier text for this analyte.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-Loinc'></a>
### Loinc `property`

##### Summary

The LOINC code for this analyte

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-Note'></a>
### Note `property`

##### Summary

Any additional notes about this analyte.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-ReferenceRange'></a>
### ReferenceRange `property`

##### Summary

The normal range for this lab analyte.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-ResultStatus'></a>
### ResultStatus `property`

##### Summary

Whether this observation is a prelimary, corrected, final, etc result.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-Units'></a>
### Units `property`

##### Summary

The units the value is in.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Observation-Value'></a>
### Value `property`

##### Summary

The observation value for this analyte.

<a name='T-AthenaHealth-Sdk-Models-Response-Order'></a>
## Order `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-Order-AssignedUser'></a>
### AssignedUser `property`

##### Summary

The username of the user who this order task is currently assigned to for further processing as needed.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-Class'></a>
### Class `property`

##### Summary

The primary class of this order -- PRESCRIPTION, VACCINE, LAB, IMAGING, PATIENTINFO, etc.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-ClassDescription'></a>
### ClassDescription `property`

##### Summary

The human-readable description of this document class, including sub class (prescription - new vs. prescription - renewal).

<a name='P-AthenaHealth-Sdk-Models-Response-Order-ClinicalProvider'></a>
### ClinicalProvider `property`

##### Summary

Details about the provider the order is sent to.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-ClinicalProviderId'></a>
### ClinicalProviderId `property`

##### Summary

ID of the clinical provider

<a name='P-AthenaHealth-Sdk-Models-Response-Order-ClinicalProviderName'></a>
### ClinicalProviderName `property`

##### Summary

Name of the clinical provider.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-ContraIndicationReason'></a>
### ContraIndicationReason `property`

##### Summary

List of codes indicating why the order was contraindicated (for vaccines only).
If this field is not present, the order does not contain a contraindication reason.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-CreatedUser'></a>
### CreatedUser `property`

##### Summary

The username of the person who created the order.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-DateOrdered'></a>
### DateOrdered `property`

##### Summary

The timestamp when the order was created.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-DeclinedReason'></a>
### DeclinedReason `property`

##### Summary

List of codes indicating why the order was not given. If this field is not present, the order was not declined.
If the array is empty, no reason has been chosen.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-DeclinedReasonText'></a>
### DeclinedReasonText `property`

##### Summary

The user-facing description of the reason the order was not given.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-DepartmentId'></a>
### DepartmentId `property`

##### Summary

Department ID of the provider.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-Description'></a>
### Description `property`

##### Summary

A human readable description for this order.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-DiagnosisList'></a>
### DiagnosisList `property`

##### Summary

List of Diagnosis related to this order.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-DocumentationOnly'></a>
### DocumentationOnly `property`

##### Summary

If true, this order is here just as a record, and does not need to actually go out.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-ExternalCodes'></a>
### ExternalCodes `property`

##### Summary

When available, contains how this order maps to external vocabularies like LOINC, CVX, SNOMED, RXNORM, etc.
CodeSet contains name of the external vocabulary.
Currently LOINC (for labs and some imaging orders), CVX (for vaccines), RXNORM and NDC (for prescriptions and some DMEs).

<a name='P-AthenaHealth-Sdk-Models-Response-Order-FutureSubmitDate'></a>
### FutureSubmitDate `property`

##### Summary

The date this order will be submitted.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-Id'></a>
### Id `property`

##### Summary

The order (aka document) ID for this order.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-LastModifiedBy'></a>
### LastModifiedBy `property`

##### Summary

The username of the person who last modified the order.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-LastModifiedDateTime'></a>
### LastModifiedDateTime `property`

##### Summary

The date this order was last modified.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-Ndc'></a>
### Ndc `property`

##### Summary

The National Drug Code for the order

<a name='P-AthenaHealth-Sdk-Models-Response-Order-OrderType'></a>
### OrderType `property`

##### Summary

The type of this order (Lab, Vaccine, etc.)

<a name='P-AthenaHealth-Sdk-Models-Response-Order-OrderTypeId'></a>
### OrderTypeId `property`

##### Summary

The athena ID for this type of order. Can be used to create another order of this type.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-OrderingProvider'></a>
### OrderingProvider `property`

##### Summary

The username of the ordering provider, which is different than the ordering user -- who may be an intake nurse for example.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-Priority'></a>
### Priority `property`

##### Summary

Priority of a order.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-ProviderId'></a>
### ProviderId `property`

##### Summary

ID of the ordering provider.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-QuantityValue'></a>
### QuantityValue `property`

##### Summary

The dosage quantity value.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-Refills'></a>
### Refills `property`

##### Summary

The number of refills allowed.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-SpecimenCollectionSite'></a>
### SpecimenCollectionSite `property`

##### Summary

Gives the location of the clinical specimen collected if any.

<a name='P-AthenaHealth-Sdk-Models-Response-Order-Status'></a>
### Status `property`

##### Summary

The status the document is in (PEND, CLOSED, SUBMIT, SUBMITTED, etc).

<a name='T-AthenaHealth-Sdk-Models-Response-OrderLab'></a>
## OrderLab `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-OrderLab-DocumentId'></a>
### DocumentId `property`

##### Summary

The ID of the document created.

<a name='T-AthenaHealth-Sdk-Models-Response-OrderRelatedDiagnosis'></a>
## OrderRelatedDiagnosis `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-OrderRelatedDiagnosis-SnomedIcdCodes'></a>
### SnomedIcdCodes `property`

##### Summary

ICD equivalent Codes for the SNOMED Code.

<a name='T-AthenaHealth-Sdk-Models-Response-OrderType'></a>
## OrderType `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-OrderType-Id'></a>
### Id `property`

##### Summary

The athena ID of the type of order.

<a name='P-AthenaHealth-Sdk-Models-Response-OrderType-Name'></a>
### Name `property`

##### Summary

The name of the order.

<a name='T-AthenaHealth-Sdk-Models-Response-LabResultDetail-Page'></a>
## Page `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.LabResultDetail

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Page-PageId'></a>
### PageId `property`

##### Summary

The ID to use in a call to get the page image.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Page-PageOrdering'></a>
### PageOrdering `property`

##### Summary

Within this list of pages, the ordering (starting with 1).

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Page-Type'></a>
### Type `property`

##### Summary

The content-type that will be returned by the page image call.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultDetail-Page-Url'></a>
### Url `property`

##### Summary

The URL to get the document image.

<a name='T-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph'></a>
## Paragraph `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Name'></a>
### Name `property`

##### Summary

The name of the interpretation paragraph.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentences'></a>
### Sentences `property`

##### Summary

The sentences in the paragraph.

<a name='T-AthenaHealth-Sdk-Models-Response-PatienSocialHistoryTemplate'></a>
## PatienSocialHistoryTemplate `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-PatienSocialHistoryTemplate-Id'></a>
### Id `property`

##### Summary

ID for this social history template

<a name='P-AthenaHealth-Sdk-Models-Response-PatienSocialHistoryTemplate-Name'></a>
### Name `property`

##### Summary

Name for this social history template

<a name='T-AthenaHealth-Sdk-Models-Response-Patient'></a>
## Patient `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Address1'></a>
### Address1 `property`

##### Summary

Patient's address - 1st line

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Address2'></a>
### Address2 `property`

##### Summary

Patient's address - 2nd line

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-AgriculturalWorker'></a>
### AgriculturalWorker `property`

##### Summary

Used to identify this patient as an agricultural worker. Only settable if client has
Social Determinant fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-AgriculturalWorkerType'></a>
### AgriculturalWorkerType `property`

##### Summary

For patients that are agricultural workers, identifies the type of worker. Only settable
if client has Social Determinant fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-AllPatientStatuses'></a>
### AllPatientStatuses `property`

##### Summary



<a name='P-AthenaHealth-Sdk-Models-Response-Patient-AltFirstName'></a>
### AltFirstName `property`

##### Summary

Alternate first name that differs from legal name.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-AssignedSexAtBirth'></a>
### AssignedSexAtBirth `property`

##### Summary

Sex that this patient was assigned at birth.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Balances'></a>
### Balances `property`

##### Summary

List of balances owed by the patient, broken down by provider (financial) group.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-CareSummaryDeliveryPreference'></a>
### CareSummaryDeliveryPreference `property`

##### Summary

The patient's preference for care summary delivery.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-City'></a>
### City `property`

##### Summary

Patient's city

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetails'></a>
### ClaimBalanceDetails `property`

##### Summary

Claim level details on patient balances. (This is only included when SHOWBALANCEDETAILS
is set.)

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ConfidentialityCode'></a>
### ConfidentialityCode `property`

##### Summary

Gives the confidentiality code for the patient. Only returned when IGNORERESTRICTIONS is
set to true and COLCR_RETURN_CONFIDENTIALITY_CODE is ON

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ConsentToCall'></a>
### ConsentToCall `property`

##### Summary

The flag is used to record the consent of a patient to receive automated calls per FCC
requirements. The requested legal language is 'Entry of any telephone contact number
constitutes written consent to receive any automated, prerecorded, and artificial voice
telephone calls initiated by the Practice. To alter or revoke this consent, visit the
Patient Portal "Contact Preferences" page.'

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ConsentToText'></a>
### ConsentToText `property`

##### Summary

The flag is used to record the consent of a patient to receive text messages per FCC
requirements. In order for this to be true, a valid mobile phone number must be set and
the practice setting "Hide SMS Opt-in option" must be set to Off.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactHomePhone'></a>
### ContactHomePhone `property`

##### Summary

Emergency contact home phone. Invalid numbers in a GET/PUT will be ignored. Patient phone
numbers and other data may change, and one phone number may be associated with multiple
patients. You are responsible for taking additional steps to verify patient identity and
for using this data in accordance with applicable law, including HIPAA. Invalid numbers
in a POST will be ignored, possibly resulting in an error.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactMobilePhone'></a>
### ContactMobilePhone `property`

##### Summary

Emergency contact mobile phone. Invalid numbers in a GET/PUT will be ignored. Patient
phone numbers and other data may change, and one phone number may be associated with
multiple patients. You are responsible for taking additional steps to verify patient
identity and for using this data in accordance with applicable law, including HIPAA.
Invalid numbers in a POST will be ignored, possibly resulting in an error.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactName'></a>
### ContactName `property`

##### Summary

The name of the (emergency) person to contact about the patient. The contactname,
contactrelationship, contacthomephone, and contactmobilephone fields are all related to
the emergency contact for the patient. They are NOT related to the contractpreference_* fields.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreference'></a>
### ContactPreference `property`

##### Summary

The MU-required field for "preferred contact method". This is not used by any automated systems.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceAnnouncementEmail'></a>
### ContactPreferenceAnnouncementEmail `property`

##### Summary

If set, the patient has indicated a preference to get or not get "announcement"
communications delivered via email. Note that this will not be present if the practice or
patient has not set it.For completeness, turning email off is supported via the API, but
it is discouraged. When email is off, patients may not not get messages from the patient portal.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceAnnouncementPhone'></a>
### ContactPreferenceAnnouncementPhone `property`

##### Summary

If set, the patient has indicated a preference to get or not get "announcement"
communications delivered via phone. Note that this will not be present if the practice or
patient has not set it.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceAnnouncementSms'></a>
### ContactPreferenceAnnouncementSms `property`

##### Summary

If set, the patient has indicated a preference to get or not get "announcement"
communications delivered via SMS. Note that this will not be present if the practice or
patient has not set it.For SMS, there is specific terms of service language that must be
used when displaying this as an option to be turned on. Turning on must be an action by
the patient, not a practice user.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceAppointmentEmail'></a>
### ContactPreferenceAppointmentEmail `property`

##### Summary

If set, the patient has indicated a preference to get or not get "appointment"
communications delivered via email. Note that this will not be present if the practice or
patient has not set it.For completeness, turning email off is supported via the API, but
it is discouraged. When email is off, patients may not not get messages from the patient portal.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceAppointmentPhone'></a>
### ContactPreferenceAppointmentPhone `property`

##### Summary

If set, the patient has indicated a preference to get or not get "appointment"
communications delivered via phone. Note that this will not be present if the practice or
patient has not set it.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceAppointmentSms'></a>
### ContactPreferenceAppointmentSms `property`

##### Summary

If set, the patient has indicated a preference to get or not get "appointment"
communications delivered via SMS. Note that this will not be present if the practice or
patient has not set it.For SMS, there is specific terms of service language that must be
used when displaying this as an option to be turned on. Turning on must be an action by
the patient, not a practice user.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceBillingEmail'></a>
### ContactPreferenceBillingEmail `property`

##### Summary

If set, the patient has indicated a preference to get or not get "billing" communications
delivered via email. Note that this will not be present if the practice or patient has
not set it.For completeness, turning email off is supported via the API, but it is
discouraged. When email is off, patients may not not get messages from the patient portal.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceBillingPhone'></a>
### ContactPreferenceBillingPhone `property`

##### Summary

If set, the patient has indicated a preference to get or not get "billing" communications
delivered via phone. Note that this will not be present if the practice or patient has
not set it.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceBillingSms'></a>
### ContactPreferenceBillingSms `property`

##### Summary

If set, the patient has indicated a preference to get or not get "billing" communications
delivered via SMS. Note that this will not be present if the practice or patient has not
set it.For SMS, there is specific terms of service language that must be used when
displaying this as an option to be turned on. Turning on must be an action by the
patient, not a practice user.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceLabEmail'></a>
### ContactPreferenceLabEmail `property`

##### Summary

If set, the patient has indicated a preference to get or not get "lab" communications
delivered via email. Note that this will not be present if the practice or patient has
not set it.For completeness, turning email off is supported via the API, but it is
discouraged. When email is off, patients may not not get messages from the patient portal.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceLabPhone'></a>
### ContactPreferenceLabPhone `property`

##### Summary

If set, the patient has indicated a preference to get or not get "lab" communications
delivered via phone. Note that this will not be present if the practice or patient has
not set it.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactPreferenceLabSms'></a>
### ContactPreferenceLabSms `property`

##### Summary

If set, the patient has indicated a preference to get or not get "lab" communications
delivered via SMS. Note that this will not be present if the practice or patient has not
set it.For SMS, there is specific terms of service language that must be used when
displaying this as an option to be turned on. Turning on must be an action by the
patient, not a practice user.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ContactRelationship'></a>
### ContactRelationship `property`

##### Summary

Emergency contact relationship (one of SPOUSE, PARENT, CHILD, SIBLING, FRIEND, COUSIN,
GUARDIAN, OTHER)

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-CountryCode'></a>
### CountryCode `property`

##### Summary

Patient's country code

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-CountryCode3166'></a>
### CountryCode3166 `property`

##### Summary

Patient's country code (ISO 3166-1)

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-CustomFields'></a>
### CustomFields `property`

##### Summary

Same as /patients/{patientid}/customfields call, but without the department ID. Depending
on setup, and only in large practices, the custom field values may or may not be the same
between departments. If this is a concern, using the /patients/{patientid}/customfields
call is preferred. Only for a single patient when showcustomfields is set to true.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-DateOfBirth'></a>
### DateOfBirth `property`

##### Summary

Patient's DOB (mm/dd/yyyy)

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-DeceasedDate'></a>
### DeceasedDate `property`

##### Summary

If present, the date on which a patient died.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-DefaultPharmacyNcpdId'></a>
### DefaultPharmacyNcpdId `property`

##### Summary

The NCPDP ID of the patient's preferred pharmacy. See http://www.ncpdp.org/ for details.
Note: if updating this field, please make sure to have a CLINICALORDERTYPEGROUPID field
as well.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-DepartmentId'></a>
### DepartmentId `property`

##### Summary

Primary (registration) department ID.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-DoNotCall'></a>
### DoNotCall `property`

##### Summary

Warning! This patient will not receive any communication from the practice if this field
is set to true.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-DriversLicense'></a>
### DriversLicense `property`

##### Summary

True if the patient has a driver's license uploaded

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-DriversLicenseExpirationDate'></a>
### DriversLicenseExpirationDate `property`

##### Summary

The expiration date of the patient's driver's license.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-DriversLicenseNumber'></a>
### DriversLicenseNumber `property`

##### Summary

The number of the patient's driver's license

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-DriversLicenseStateId'></a>
### DriversLicenseStateId `property`

##### Summary

The state of the patient's driver's license. This is in the form of a 2 letter state code.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-DriversLicenseUrl'></a>
### DriversLicenseUrl `property`

##### Summary

The URL to the patient's driver's license

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Email'></a>
### Email `property`

##### Summary

Patient's email address. 'declined' can be used to indicate just that.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-EmailExists'></a>
### EmailExists `property`

##### Summary

True if email exists. False if patient declined. Null if status is unknown.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-EmployerAddress'></a>
### EmployerAddress `property`

##### Summary

The patient's employer's address.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-EmployerCity'></a>
### EmployerCity `property`

##### Summary

The patient's employer's city.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-EmployerFax'></a>
### EmployerFax `property`

##### Summary

The patient's employer's fax.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-EmployerId'></a>
### EmployerId `property`

##### Summary

The patient's employer's ID (from /employers call)

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-EmployerName'></a>
### EmployerName `property`

##### Summary

The patient's employer's name.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-EmployerPhone'></a>
### EmployerPhone `property`

##### Summary

The patient's employer's phone number. Normally, this is set by setting employerid.
However, setting this value can be used to override this on an individual patient.
Invalid numbers in a GET/PUT will be ignored. Patient phone numbers and other data may
change, and one phone number may be associated with multiple patients. You are
responsible for taking additional steps to verify patient identity and for using this
data in accordance with applicable law, including HIPAA. Invalid numbers in a POST will
be ignored, possibly resulting in an error.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-EmployerState'></a>
### EmployerState `property`

##### Summary

The patient's employer's state.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-EmployerZip'></a>
### EmployerZip `property`

##### Summary

The patient's employer's zip.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-EthnicityCode'></a>
### EthnicityCode `property`

##### Summary

Ethnicity of the patient, using the 2.16.840.1.113883.5.50 codeset. See
http://www.hl7.org/implement/standards/fhir/terminologies-v3.html Special case: use
"declined" to indicate that the patient declined to answer.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-FirstAppointment'></a>
### FirstAppointment `property`

##### Summary

The first appointment for this patient, excluding cancelled or no-show appointments.
(mm/dd/yyyy h24:mi)

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-FirstName'></a>
### FirstName `property`

##### Summary

Patient's first name

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GenderIdentity'></a>
### GenderIdentity `property`

##### Summary

Gender with which this patient identifies.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GenderIdentityOther'></a>
### GenderIdentityOther `property`

##### Summary

If a patient does not identify with any prescribed gender identity choice, this field
stores the patient-provided description of gender identity.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorAddress1'></a>
### GuarantorAddress1 `property`

##### Summary

Guarantor's address

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorAddress2'></a>
### GuarantorAddress2 `property`

##### Summary

Guarantor's address - line 2

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorAddressSameAsPatient'></a>
### GuarantorAddressSameAsPatient `property`

##### Summary

The address of the guarantor is the same as the patient.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorCity'></a>
### GuarantorCity `property`

##### Summary

Guarantor's city

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorCountryCode'></a>
### GuarantorCountryCode `property`

##### Summary

Guarantor's country code

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorCountryCode3166'></a>
### GuarantorCountryCode3166 `property`

##### Summary

Guarantor's country code (ISO 3166-1)

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorDateOfBirth'></a>
### GuarantorDateOfBirth `property`

##### Summary

Guarantor's DOB (mm/dd/yyyy)

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorEmail'></a>
### GuarantorEmail `property`

##### Summary

Guarantor's email address

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorEmployerId'></a>
### GuarantorEmployerId `property`

##### Summary

The guaranror's employer's ID (from /employers call)

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorFirstName'></a>
### GuarantorFirstName `property`

##### Summary

Guarantor's first name

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorLastName'></a>
### GuarantorLastName `property`

##### Summary

Guarantor's last name

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorMiddleName'></a>
### GuarantorMiddleName `property`

##### Summary

Guarantor's middle name

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorPhone'></a>
### GuarantorPhone `property`

##### Summary

Guarantor's phone number. Invalid numbers in a GET/PUT will be ignored. Patient phone
numbers and other data may change, and one phone number may be associated with multiple
patients. You are responsible for taking additional steps to verify patient identity and
for using this data in accordance with applicable law, including HIPAA. Invalid numbers
in a POST will be ignored, possibly resulting in an error.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorRelationshipToPatient'></a>
### GuarantorRelationshipToPatient `property`

##### Summary

The guarantor's relationship to the patient

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorSSN'></a>
### GuarantorSSN `property`

##### Summary

Guarantor's SSN

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorState'></a>
### GuarantorState `property`

##### Summary

Guarantor's state (2 letter abbreviation)

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorSuffix'></a>
### GuarantorSuffix `property`

##### Summary

Guarantor's name suffix

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuarantorZip'></a>
### GuarantorZip `property`

##### Summary

Guarantor's zip

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuardianFirstName'></a>
### GuardianFirstName `property`

##### Summary

The first name of the patient's guardian.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuardianLastName'></a>
### GuardianLastName `property`

##### Summary

The last name of the patient's guardian.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuardianMiddleName'></a>
### GuardianMiddleName `property`

##### Summary

The middle name of the patient's guardian.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-GuardianSuffix'></a>
### GuardianSuffix `property`

##### Summary

The suffix of the patient's guardian.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-HasMobile'></a>
### HasMobile `property`

##### Summary

Set to false if a client has declined a phone number.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-HierarchicalCode'></a>
### HierarchicalCode `property`

##### Summary

The patient race hierarchical code

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-HomePhone'></a>
### HomePhone `property`

##### Summary

The patient's home phone number. Invalid numbers in a GET/PUT will be ignored. Patient
phone numbers and other data may change, and one phone number may be associated with
multiple patients. You are responsible for taking additional steps to verify patient
identity and for using this data in accordance with applicable law, including HIPAA.
Invalid numbers in a POST will be ignored, possibly resulting in an error.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Homebound'></a>
### Homebound `property`

##### Summary

If the patient is homebound, this is true.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Homeless'></a>
### Homeless `property`

##### Summary

Used to identify this patient as homeless. Only settable if client has Social Determinant
fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-HomelessType'></a>
### HomelessType `property`

##### Summary

For patients that are homeless, provides more detail regarding the patient's homeless
situation. Only settable if client has Social Determinant fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Id'></a>
### Id `property`

##### Summary

Please remember to never disclose this ID to patients since it may result in inadvertant
disclosure that a patient exists in a practice already.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-IndustryCode'></a>
### IndustryCode `property`

##### Summary

Industry of the patient, using the US Census industry code (code system
2.16.840.1.113883.6.310). "other" can be used as well.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Insurances'></a>
### Insurances `property`

##### Summary

List of active patient insurance packages. Only shown for a single patient and if
SHOWINSURANCE is set.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Language6392Code'></a>
### Language6392Code `property`

##### Summary

Language of the patient, using the ISO 639.2 code.
(http://www.loc.gov/standards/iso639-2/php/code_list.php; "T" or terminology code)
Special case: use "declined" to indicate that the patient declined to answer.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-LastAppointment'></a>
### LastAppointment `property`

##### Summary

The last appointment for this patient (before today), excluding cancelled or no-show
appointments. (mm/dd/yyyy h24:mi)

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-LastEmail'></a>
### LastEmail `property`

##### Summary

The last email for this patient on file.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-LastName'></a>
### LastName `property`

##### Summary

Patient's last name

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-LocalPatientId'></a>
### LocalPatientId `property`

##### Summary

Given showlocalpatientid is true, comma separated local patient id will be returned, if
patient id is enterprise id else given patient id will be displayed.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-MaritalStatus'></a>
### MaritalStatus `property`

##### Summary

Marital Status (D=Divorced, M=Married, S=Single, U=Unknown, W=Widowed, X=Separated, P=Partner)

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-MaritalStatusName'></a>
### MaritalStatusName `property`

##### Summary

The long version of the marital status.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-MedicationHistoryConsentVerified'></a>
### MedicationHistoryConsentVerified `property`

##### Summary

Medication history consent status. If a practice doesn't have RXHub or Surescripts
enabled, this will be null

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-MiddleName'></a>
### MiddleName `property`

##### Summary

Patient's middle name

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-MobileCarrierId'></a>
### MobileCarrierId `property`

##### Summary

The ID of the mobile carrier, from /mobilecarriers or the list below.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-MobilePhone'></a>
### MobilePhone `property`

##### Summary

The patient's mobile phone number. On input, 'declined' can be used to indicate no
number. (Alternatively, hasmobile can also be set to false. "declined" simply does this
for you.) Invalid numbers in a GET/PUT will be ignored. Patient phone numbers and other
data may change, and one phone number may be associated with multiple patients. You are
responsible for taking additional steps to verify patient identity and for using this
data in accordance with applicable law, including HIPAA. Invalid numbers in a POST will
be ignored, possibly resulting in an error.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-NextKinName'></a>
### NextKinName `property`

##### Summary

The full name of the next of kin.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-NextKinPhone'></a>
### NextKinPhone `property`

##### Summary

The next of kin phone number. Invalid numbers in a GET/PUT will be ignored. Patient phone
numbers and other data may change, and one phone number may be associated with multiple
patients. You are responsible for taking additional steps to verify patient identity and
for using this data in accordance with applicable law, including HIPAA. Invalid numbers
in a POST will be ignored, possibly resulting in an error.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-NextKinRelationship'></a>
### NextKinRelationship `property`

##### Summary

The next of kin relationship (one of SPOUSE, PARENT, CHILD, SIBLING, FRIEND, COUSIN,
GUARDIAN, OTHER)

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Notes'></a>
### Notes `property`

##### Summary

Notes associated with this patient.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-OccupationCode'></a>
### OccupationCode `property`

##### Summary

Occupation of the patient, using the US Census occupation code (code system
2.16.840.1.113883.6.240). "other" can be used as well.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-OnlineStateMentOnly'></a>
### OnlineStateMentOnly `property`

##### Summary

Set to true if a patient wishes to get e-statements instead of paper statements. Should
only be set for patients with an email address and clients with athenaCommunicator. The
language we use in the portal is, "Future billing statements will be sent to you securely
via your Patient Portal account. You will receive an email notice when new statements are
available." This language is not required, but it is given as a suggestion.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PatientPhoto'></a>
### PatientPhoto `property`

##### Summary

True if the patient has a photo uploaded

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PatientPhotoUrl'></a>
### PatientPhotoUrl `property`

##### Summary

The URL to the patient photo

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PortalAccessGiven'></a>
### PortalAccessGiven `property`

##### Summary

This flag is set if the patient has been given access to the portal. This may be set by
the API user if a patient has been given access to the portal "by providing a preprinted
brochure or flyer showing the URL where patients can access their Patient Care
Summaries." The practiceinfo endpoint can provide the portal URL. While technically
allowed, it would be very unusual to set this to false via the API.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PortalSignatureOnFile'></a>
### PortalSignatureOnFile `property`

##### Summary

This flag is set if the patient's signature is on file

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatus'></a>
### PortalStatus `property`

##### Summary

Portal status details. See /patients/{patientid}/portalstatus for details.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PortalTermsOnFile'></a>
### PortalTermsOnFile `property`

##### Summary

Flag determining whether or not the patient has accepted the Terms and Conditions for the
patient portal.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PovertyLevelCalculated'></a>
### PovertyLevelCalculated `property`

##### Summary

Patient's poverty level (% of the Federal Poverty Level), as calculated from family size,
income per pay period, pay period, and state. Typically only valued if client has Federal
Poverty Level fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PovertyLevelFamilySize'></a>
### PovertyLevelFamilySize `property`

##### Summary

Patient's family size (used for determining poverty level). Only settable if client has
Federal Poverty Level fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PovertyLevelFamilySizeDeclined'></a>
### PovertyLevelFamilySizeDeclined `property`

##### Summary

Indicates if the patient delcines to provide "povertylevelfamilysize". Should be set to
Yes if the patient declines.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PovertyLevelIncomeDeclined'></a>
### PovertyLevelIncomeDeclined `property`

##### Summary

Indicates if the patient delcines to provide "povertylevelincomeperpayperiod". Should be
set to Yes if the patient declines.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PovertyLevelIncomePayPeriod'></a>
### PovertyLevelIncomePayPeriod `property`

##### Summary

Patient's pay period (used for determining poverty level). Only settable if client has
Federal Poverty Level fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PovertyLevelIncomePerPayPeriod'></a>
### PovertyLevelIncomePerPayPeriod `property`

##### Summary

Patient's income per specified pay period (used for determining poverty level). Only
settable if client has Federal Poverty Level fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PovertyLevelIncomeRangeDeclined'></a>
### PovertyLevelIncomeRangeDeclined `property`

##### Summary

Indicates if the patient declines to provide an income range level. True if the patient declines.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PreferredName'></a>
### PreferredName `property`

##### Summary

The patient's preferred name (i.e. nickname).

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PreferredPronouns'></a>
### PreferredPronouns `property`

##### Summary

Pronoun this patient uses.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PrimaryDepartmentId'></a>
### PrimaryDepartmentId `property`

##### Summary

The patient's "current" department. This field is not always set by the practice.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PrimaryProviderId'></a>
### PrimaryProviderId `property`

##### Summary

The "primary" provider for this patient, if set.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PrivacyInformationVerified'></a>
### PrivacyInformationVerified `property`

##### Summary

This flag is set if the patient's privacy information has been verified. Privacy
information returns True if all of the items referenced in GET
/patients/{patientid}/privacyinformationverified are true. Privacy information returns
false if any of the items referenced in the GET
/patients/{patientid}/privacyinformationverified API are false or expired.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PublicHousing'></a>
### PublicHousing `property`

##### Summary

Used to identify this patient as living in public housing. Only settable if client has
Social Determinant fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Race'></a>
### Race `property`

##### Summary

The patient race, using the 2.16.840.1.113883.5.104 codeset. See
http://www.hl7.org/implement/standards/fhir/terminologies-v3.html Special case: use
"declined" to indicate that the patient declined to answer. Multiple values or a
tab-seperated list of codes is acceptable for multiple races for input. The first race
will be considered "primary". Note: you must update all values at once if you update any.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-RaceName'></a>
### RaceName `property`

##### Summary

The patient's primary race name. See race for more complete details.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ReferralSourceId'></a>
### ReferralSourceId `property`

##### Summary

The referral / "how did you hear about us" ID.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ReferralSourceOther'></a>
### ReferralSourceOther `property`

##### Summary

If choosing "other" for referral source, this is the text field that can be filled out.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-RegistrationDate'></a>
### RegistrationDate `property`

##### Summary

Date the patient was registered.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-SSN'></a>
### SSN `property`

##### Summary

The patient's SSN

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-SchoolBasedHealthCenter'></a>
### SchoolBasedHealthCenter `property`

##### Summary

Used to identify this patient as school-based health center patient. Only settable if
client has Social Determinant fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Sex'></a>
### Sex `property`

##### Summary

Patient's sex (M/F).

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-SexualOrientation'></a>
### SexualOrientation `property`

##### Summary

Sexual orientation of this patient.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-SexualOrientationOther'></a>
### SexualOrientationOther `property`

##### Summary

If a patient does not identify with any prescribed sexual orientation choice, this field
stores the patient-provided description of sexual orientation.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-State'></a>
### State `property`

##### Summary

Patient's state (2 letter abbreviation)

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Status'></a>
### Status `property`

##### Summary

The "status" of the patient, one of active, inactive, prospective, or deleted.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Suffix'></a>
### Suffix `property`

##### Summary

Patient's name suffix

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Veteran'></a>
### Veteran `property`

##### Summary

Used to identify this patient as a veteran. Only settable if client has Social
Determinant fields turned on.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-WorkPhone'></a>
### WorkPhone `property`

##### Summary

The patient's work phone number. Generally not used to contact a patient. Invalid numbers
in a GET/PUT will be ignored. Patient phone numbers and other data may change, and one
phone number may be associated with multiple patients. You are responsible for taking
additional steps to verify patient identity and for using this data in accordance with
applicable law, including HIPAA. Invalid numbers in a POST will be ignored, possibly
resulting in an error.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-Zip'></a>
### Zip `property`

##### Summary

Patient's zip. Matching occurs on first 5 characters.

<a name='T-AthenaHealth-Sdk-Models-Response-PatientAllergy'></a>
## PatientAllergy `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergies'></a>
### Allergies `property`

##### Summary

Allergies

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-LastModifiedBy'></a>
### LastModifiedBy `property`

##### Summary

The username of the user who last modified the note, nkda, or allergies.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-LastModifiedDateTime'></a>
### LastModifiedDateTime `property`

##### Summary

The date and time the note, nkda, or allergies were last updated.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-NoKnownDrugAllergies'></a>
### NoKnownDrugAllergies `property`

##### Summary

Whether the patient has no known drug allergies. This is an explicit statement separate
from a patient with no documented allergies so far.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-NoteLastModifiedBy'></a>
### NoteLastModifiedBy `property`

##### Summary

The username of the user who last modified the note.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-NoteLastModifiedDateTime'></a>
### NoteLastModifiedDateTime `property`

##### Summary

The date and time the note was last updated.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-SectionNote'></a>
### SectionNote `property`

##### Summary

A section-wide note

<a name='T-AthenaHealth-Sdk-Clients-PatientClient'></a>
## PatientClient `type`

##### Namespace

AthenaHealth.Sdk.Clients

<a name='M-AthenaHealth-Sdk-Clients-PatientClient-DeleteInsuranceCardPhoto-System-Int32,System-Int32-'></a>
### DeleteInsuranceCardPhoto(patientId,insuranceId) `method`

##### Summary

Deletes patient insurance card photo

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| insuranceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-AthenaHealth-Sdk-Clients-PatientClient-DeletePatient-System-Int32-'></a>
### DeletePatient(patientId) `method`

##### Summary

Sets patient status to inactive

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-AthenaHealth-Sdk-Clients-PatientClient-DeletePhoto-System-Int32-'></a>
### DeletePhoto(patientId) `method`

##### Summary

Deletes patient photo

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-AthenaHealth-Sdk-Clients-PatientClient-GetInsuranceCardPhoto-System-Int32,System-Int32,System-Nullable{System-Boolean}-'></a>
### GetInsuranceCardPhoto(patientId,insuranceId,jpegOutput) `method`

##### Summary

Gets patient insurance card photo

##### Returns

Image bytes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| insuranceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| jpegOutput | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | If set to true, or if Accept header is image/jpeg, returns the image directly. (The
image may be scaled.) |

<a name='M-AthenaHealth-Sdk-Clients-PatientClient-GetPhoto-System-Int32,System-Nullable{System-Boolean}-'></a>
### GetPhoto(patientId,jpegOutput) `method`

##### Summary

Gets patient photo

##### Returns

Image bytes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| jpegOutput | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | If set to true, or if Accept header is image/jpeg, returns the image directly. (The
image may be scaled.) |

<a name='M-AthenaHealth-Sdk-Clients-PatientClient-UpdateInsuranceCardPhoto-System-Int32,System-Int32,AthenaHealth-Sdk-Models-Request-UpdateInsuranceCardPhoto-'></a>
### UpdateInsuranceCardPhoto(patientId,insuranceId,request) `method`

##### Summary

Updates patient insurance card photo

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| insuranceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| request | [AthenaHealth.Sdk.Models.Request.UpdateInsuranceCardPhoto](#T-AthenaHealth-Sdk-Models-Request-UpdateInsuranceCardPhoto 'AthenaHealth.Sdk.Models.Request.UpdateInsuranceCardPhoto') |  |

<a name='M-AthenaHealth-Sdk-Clients-PatientClient-UpdatePhoto-System-Int32,AthenaHealth-Sdk-Models-Request-UpdatePhoto-'></a>
### UpdatePhoto(patientId,request) `method`

##### Summary

Updates patient photo

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| patientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| request | [AthenaHealth.Sdk.Models.Request.UpdatePhoto](#T-AthenaHealth-Sdk-Models-Request-UpdatePhoto 'AthenaHealth.Sdk.Models.Request.UpdatePhoto') |  |

<a name='T-AthenaHealth-Sdk-Models-Response-PatientMedication'></a>
## PatientMedication `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-LastDownloadDenialReason'></a>
### LastDownloadDenialReason `property`

##### Summary

BETA FIELD: The reason the last medication history download was denied.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-LastDownloadDenied'></a>
### LastDownloadDenied `property`

##### Summary

BETA FIELD: Whether or not the last medication history download was denied.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-LastDownloadedDate'></a>
### LastDownloadedDate `property`

##### Summary

The time of the last attempted medication history download from SureScripts.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-LastUpdated'></a>
### LastUpdated `property`

##### Summary

The last time any of the medications were updated

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medications'></a>
### Medications `property`

##### Summary

The list of medications

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-NoMedicationsReported'></a>
### NoMedicationsReported `property`

##### Summary

Whether the patient explicitly has no reported medications

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-PatientDownloadConsent'></a>
### PatientDownloadConsent `property`

##### Summary

Whether or not the patient has consented to have their medication history downloaded.
There are plans to deprecate this field.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-PatientNeedsDownloadConsent'></a>
### PatientNeedsDownloadConsent `property`

##### Summary

Whether or not the patient needs to consent to have medication history downloaded. This
will be true if either the patient has not currently consented, or the practice is not
enabled for these downloads. This field is typically used when determining whether to
message to the patient that they have not consented to these downloads. Note that
regardless of this setting, medication history that has already been downloaded will
remain available.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-SectionNote'></a>
### SectionNote `property`

##### Summary

A section-wide note

<a name='T-AthenaHealth-Sdk-Models-Response-PatientSignature'></a>
## PatientSignature `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSignature-EffectiveDate'></a>
### EffectiveDate `property`

##### Summary

Date the release of billing information check takes effect.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSignature-ExpirationDate'></a>
### ExpirationDate `property`

##### Summary

Date the release of billing information check expires.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSignature-IsOnFile'></a>
### IsOnFile `property`

##### Summary

Flag that indicates whether or not the release of billing information check is set.
This is set to false if it is expired.

<a name='T-AthenaHealth-Sdk-Models-Response-PatientSocialHistory'></a>
## PatientSocialHistory `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Questions'></a>
### Questions `property`

##### Summary

The social history questions and answers for this patient.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-SectionNote'></a>
### SectionNote `property`

##### Summary

A section-wide note.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Templates'></a>
### Templates `property`

##### Summary

The selected social history templates for this patient.

<a name='T-AthenaHealth-Sdk-Models-Response-Patient-PatientStatus'></a>
## PatientStatus `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Patient

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PatientStatus-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The ID of a department that this patient is registered in.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PatientStatus-PrimaryProviderId'></a>
### PrimaryProviderId `property`

##### Summary

The "primary" provider for this patient, if set.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PatientStatus-Status'></a>
### Status `property`

##### Summary

The "status" of the patient, one of active, inactive, prospective, or deleted.

<a name='T-AthenaHealth-Sdk-Models-Response-PatientWithScore'></a>
## PatientWithScore `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-PatientWithScore-Score'></a>
### Score `property`

##### Summary

This is the patient's matching score. This indicates how likely this patient is to be the
patient you are searching for given the demographics input. A score of 26 indicates the
patient is automatically assumed to be the same. A score under 16 indicates that this is
almost guaranteed to NOT be the patient you are looking for (we will never return any
patient with a score under 16). A score of around 23 is the maximum you can get if the
only parameters you pass in are the required parameters.

<a name='T-AthenaHealth-Sdk-Models-Response-PaymentMethod'></a>
## PaymentMethod `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-PaymentMethod-IdentifierName'></a>
### IdentifierName `property`

##### Summary

The payment method identifier for use in [](#!-IPatientClient-RecordPayment 'IPatientClient.RecordPayment')

<a name='P-AthenaHealth-Sdk-Models-Response-PaymentMethod-Name'></a>
### Name `property`

##### Summary

The name of this payment method (used in athenahealth's UI).

<a name='T-AthenaHealth-Sdk-Models-Response-Pharmacy'></a>
## Pharmacy `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-Pharmacy-AcceptFax'></a>
### AcceptFax `property`

##### Summary

Flag representing if the pharmacy accepts fax

<a name='P-AthenaHealth-Sdk-Models-Response-Pharmacy-Address1'></a>
### Address1 `property`

##### Summary

Address line 1 of the pharmacy

<a name='P-AthenaHealth-Sdk-Models-Response-Pharmacy-Address2'></a>
### Address2 `property`

##### Summary

Address line 2 of the pharmacy

<a name='P-AthenaHealth-Sdk-Models-Response-Pharmacy-City'></a>
### City `property`

##### Summary

City of the pharmacy

<a name='P-AthenaHealth-Sdk-Models-Response-Pharmacy-ClinicalProviderId'></a>
### ClinicalProviderId `property`

##### Summary

The athenaNet clinical provider ID.

<a name='P-AthenaHealth-Sdk-Models-Response-Pharmacy-ClinicalProviderName'></a>
### ClinicalProviderName `property`

##### Summary

The pharmacy name

<a name='P-AthenaHealth-Sdk-Models-Response-Pharmacy-DefaultPharmacy'></a>
### DefaultPharmacy `property`

##### Summary

If flagged true, this is the default pharmacy for the patient

<a name='P-AthenaHealth-Sdk-Models-Response-Pharmacy-FaxNumber'></a>
### FaxNumber `property`

##### Summary

Fax number of the pharmacy

<a name='P-AthenaHealth-Sdk-Models-Response-Pharmacy-PharmacyType'></a>
### PharmacyType `property`

##### Summary

Type of pharmacy (retail, mailorder)

<a name='P-AthenaHealth-Sdk-Models-Response-Pharmacy-PhoneNumber'></a>
### PhoneNumber `property`

##### Summary

Phone number of the pharmacy

<a name='P-AthenaHealth-Sdk-Models-Response-Pharmacy-ReceiverType'></a>
### ReceiverType `property`

##### Summary

Receiver type

<a name='P-AthenaHealth-Sdk-Models-Response-Pharmacy-State'></a>
### State `property`

##### Summary

State of the pharmacy

<a name='P-AthenaHealth-Sdk-Models-Response-Pharmacy-Zip'></a>
### Zip `property`

##### Summary

Zip code of the pharmacy

<a name='T-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel'></a>
## PortalStatusModel `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Patient

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-BlockedFailedLogins'></a>
### BlockedFailedLogins `property`

##### Summary

Is this patient blocked from the portal due to failed login attempts.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-EntityToDisplay'></a>
### EntityToDisplay `property`

##### Summary

Either "FAMILY" or "PATIENT".

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-FamilyBlockedFailedLogins'></a>
### FamilyBlockedFailedLogins `property`

##### Summary

Is this patient's family blocked from the portal due to failed login attempts.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-FamilyRegistered'></a>
### FamilyRegistered `property`

##### Summary

Is there a family member registered with access to this patient.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-LastLoginDate'></a>
### LastLoginDate `property`

##### Summary

The last login date.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-LastLoginEntity'></a>
### LastLoginEntity `property`

##### Summary

Either "PATIENT" or "FAMILY", the last entity who accessed this patient.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-NoPortal'></a>
### NoPortal `property`

##### Summary

The privacy setting for blocking the patient from the portal is set.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-PortalRegistrationDate'></a>
### PortalRegistrationDate `property`

##### Summary

The date the patient registered for the portal.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-Registered'></a>
### Registered `property`

##### Summary

If this patient is registered or not for the portal.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-Status'></a>
### Status `property`

##### Summary

The status of the patient. Possible statuses:

REGISTERED: The patient is registered for the portal.

NOTREGISTERED: The patient is not registered for the portal.

FAMILYLOGIN: This patient is set up for a family member to login.

NOPORTAL: The privacy setting for blocking the patient from the portal is set.

BLOCKEDFAILEDLOGINS: The patient is blocked because of failed login attempts.

FAMILYBLOCKEDFAILEDLOGINS: The family member is blocked because of failed login attempts.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-PortalStatusModel-TermsAccepted'></a>
### TermsAccepted `property`

##### Summary

Has this patient accepted the portal's Terms and Conditions. This is a good indicator
if the patient has actually logged in to the portal or simply is registered without
ever having logged in.

<a name='T-AthenaHealth-Sdk-Clients-PracticeClient'></a>
## PracticeClient `type`

##### Namespace

AthenaHealth.Sdk.Clients

<a name='M-AthenaHealth-Sdk-Clients-PracticeClient-GetCurrentPractice-AthenaHealth-Sdk-Models-Request-BaseLimitFilter-'></a>
### GetCurrentPractice(filter) `method`

##### Summary

Returns [Practice](#T-AthenaHealth-Sdk-Models-Response-Practice 'AthenaHealth.Sdk.Models.Response.Practice') for [PracticeId](#P-AthenaHealth-Sdk-IAthenaHealthClient-PracticeId 'AthenaHealth.Sdk.IAthenaHealthClient.PracticeId').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [AthenaHealth.Sdk.Models.Request.BaseLimitFilter](#T-AthenaHealth-Sdk-Models-Request-BaseLimitFilter 'AthenaHealth.Sdk.Models.Request.BaseLimitFilter') |  |

<a name='T-AthenaHealth-Sdk-Models-Response-Prescription'></a>
## Prescription `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-AppointmentId'></a>
### AppointmentId `property`

##### Summary

The appointment ID for this document

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-AssignedTo'></a>
### AssignedTo `property`

##### Summary

Person the document is assigned to

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-CreatedDate'></a>
### CreatedDate `property`

##### Summary

Date the document was created. Please use createddatetime instead.

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-CreatedDateTime'></a>
### CreatedDateTime `property`

##### Summary

Date/Time (ISO 8601) the document was created

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-DeaSchedule'></a>
### DeaSchedule `property`

##### Summary

A number corresponding to the level of restriction the drug is placed under by the DEA.

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-DeclinedReason'></a>
### DeclinedReason `property`

##### Summary

List of codes indicating why the order was not given. If this field is not present, the
order was not declined. If the array is empty, no reason has been chosen.

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-DeclinedReasonText'></a>
### DeclinedReasonText `property`

##### Summary

The user-facing description of the reason the order was not given.

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-DeletedDateTime'></a>
### DeletedDateTime `property`

##### Summary

Date/time (ISO 8601) the document was deleted

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-DepartmentId'></a>
### DepartmentId `property`

##### Summary

Department for the document

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-DocumentClass'></a>
### DocumentClass `property`

##### Summary

Class of document

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-DocumentDescription'></a>
### DocumentDescription `property`

##### Summary

Description of the document type

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-DocumentRoute'></a>
### DocumentRoute `property`

##### Summary

Explains method by which the document was entered into the AthenaNet (INTERFACE
(digital), FAX, etc.)

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-DocumentSource'></a>
### DocumentSource `property`

##### Summary

Explains where this document originated.

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-DocumentSubclass'></a>
### DocumentSubclass `property`

##### Summary

Specific type of document

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-DocumentTypeId'></a>
### DocumentTypeId `property`

##### Summary

A specific document type identifier.

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-EncounterId'></a>
### EncounterId `property`

##### Summary

Encounter ID

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-ExternalAccessionId'></a>
### ExternalAccessionId `property`

##### Summary

The external accession ID for this document. Format depends on the system the ID belongs to.

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-ExternalNote'></a>
### ExternalNote `property`

##### Summary

External note for the patient.

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-FacilityId'></a>
### FacilityId `property`

##### Summary

The ID of the clinical provider associated with this clinical document. Clinical
providers are a master list of providers throughout the country. These include providers
as well as radiology centers, labs and pharmacies.

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-Id'></a>
### Id `property`

##### Summary

ID of a prescription document

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-InternalAccessionId'></a>
### InternalAccessionId `property`

##### Summary

The internal accession ID for this document. Format depends on the system the ID belongs to.

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-InternalNote'></a>
### InternalNote `property`

##### Summary

The 'Internal Note' attached to this document

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-LastModifiedDateTime'></a>
### LastModifiedDateTime `property`

##### Summary

Date/time (ISO 8601) the document was last modified

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-ObservationDate'></a>
### ObservationDate `property`

##### Summary



<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-ObservationDateTime'></a>
### ObservationDateTime `property`

##### Summary

Date/time (ISO 8601) the observation was taken

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-OrderType'></a>
### OrderType `property`

##### Summary

Order type group name

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-OrderingMode'></a>
### OrderingMode `property`

##### Summary

Ordering Mode for a prescription. One of Prescribe, Adminster, Dispense

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-PatientCaseId'></a>
### PatientCaseId `property`

##### Summary

The patient case id

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-Priority'></a>
### Priority `property`

##### Summary

Document priority, when available. 1 is high, 2 is normal. Some labs use other numbers or
characters that are lab-specific.

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-ProviderId'></a>
### ProviderId `property`

##### Summary

Provider ID for this document

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-ProviderNPI'></a>
### ProviderNPI `property`

##### Summary

NPI (National Provider Identity) of the provider for this prescription.

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-Status'></a>
### Status `property`

##### Summary

Status of the document

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-Subject'></a>
### Subject `property`

##### Summary

Subject of the document

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-TieToOrderId'></a>
### TieToOrderId `property`

##### Summary

Order ID of the order this document is tied to, if any

<a name='T-AthenaHealth-Sdk-Models-Response-PrivacyInformationResponse'></a>
## PrivacyInformationResponse `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-PrivacyInformationResponse-NumberOfCheckboxesConfigured'></a>
### NumberOfCheckboxesConfigured `property`

##### Summary

The number of checkboxes the practice has configured.

<a name='T-AthenaHealth-Sdk-Models-Response-PrivacyNote'></a>
## PrivacyNote `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-PrivacyNote-GivenDate'></a>
### GivenDate `property`

##### Summary

Date the privacy notice was given.

<a name='P-AthenaHealth-Sdk-Models-Response-PrivacyNote-GivenNote'></a>
### GivenNote `property`

##### Summary

Note for not giving privacy notice.

<a name='P-AthenaHealth-Sdk-Models-Response-PrivacyNote-GivenReason'></a>
### GivenReason `property`

##### Summary

Reason for not giving privacy notice.

<a name='P-AthenaHealth-Sdk-Models-Response-PrivacyNote-IsOnFile'></a>
### IsOnFile `property`

##### Summary

Flag that indicates whether or not the privacy notice check is set.
This is set to false if it is expired.

<a name='T-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem'></a>
## Problem `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.ProblemResponse

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-BestmatchICD10Code'></a>
### BestmatchICD10Code `property`

##### Summary

If this was added from the chart or from an encounter without a selected ICD10 code, and if the primary codeset is SNOMED, then this contains the best matching ICD10 code mapped. Because SNOMED to ICD10 is a many to many map, this will tend to give the most generic diagnosis.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Code'></a>
### Code `property`

##### Summary

Problem code

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Codeset'></a>
### Codeset `property`

##### Summary

Problem codeset (SNOMED, ICD9, ICD10, etc)

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-DeactivatedDate'></a>
### DeactivatedDate `property`

##### Summary

Date of problem deactivation.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-DeactivatedUser'></a>
### DeactivatedUser `property`

##### Summary

The name of the user who deactivated the problem.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Events'></a>
### Events `property`

##### Summary

List of start and stop events for this problem, which can occur multiple times.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Id'></a>
### Id `property`

##### Summary

Athena ID for this problem

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-LastModifiedBy'></a>
### LastModifiedBy `property`

##### Summary

The username of the user who last modified this problem.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-LastModifiedDateTime'></a>
### LastModifiedDateTime `property`

##### Summary

The date the problem was last modified. Currently only date precision.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-MostRecentDiagnosisNote'></a>
### MostRecentDiagnosisNote `property`

##### Summary

The data will be displayed when the showdiagnosisinfo flag is set to true

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problem-Name'></a>
### Name `property`

##### Summary

Problem name

<a name='T-AthenaHealth-Sdk-Models-Response-ProblemResponse'></a>
## ProblemResponse `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-LastModifiedBy'></a>
### LastModifiedBy `property`

##### Summary

The username of the user who last modified the note, no known problems checkbox, or problems.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-LastModifiedDateTime'></a>
### LastModifiedDateTime `property`

##### Summary

The date and time the note, no known problems checkbox, or problems were last updated.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-LastUpdated'></a>
### LastUpdated `property`

##### Summary

Deprecated, used LASTMODIFIEDDATETIME instead. The last date any of the problems in the returned list were updated. Does not include no known problems or the section note, and is date precision.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-NoKnownProblems'></a>
### NoKnownProblems `property`

##### Summary

Whether the no known problems checkbox is checked. This is an explicit statement separate from a patient who has no documented problems so far.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-NoteLastModifiedBy'></a>
### NoteLastModifiedBy `property`

##### Summary

The username of the user who last modified the note.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-NoteLastModifiedDateTime'></a>
### NoteLastModifiedDateTime `property`

##### Summary

The date and time the section note was last updated.

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-Problems'></a>
### Problems `property`

##### Summary

List of problems, grouped by problem code

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-SectionNote'></a>
### SectionNote `property`

##### Summary

The problem section note

<a name='P-AthenaHealth-Sdk-Models-Response-ProblemResponse-TotalCount'></a>
### TotalCount `property`

##### Summary

Total number of problems

<a name='T-AthenaHealth-Sdk-Models-Response-Appointment-Procedure'></a>
## Procedure `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Appointment

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-AllowableAmount'></a>
### AllowableAmount `property`

##### Summary

The total amount expected from payer for all services from this procedure.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-AllowableMax'></a>
### AllowableMax `property`

##### Summary

The maximum amount expected from payer for all services from this procedure.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-AllowableMin'></a>
### AllowableMin `property`

##### Summary

The minimum amount expected from payer for all services from this procedure.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-ChargeAmount'></a>
### ChargeAmount `property`

##### Summary

The amount charged for this procedure.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-ProcedureCategory'></a>
### ProcedureCategory `property`

##### Summary

The category name associated with this procedure.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-ProcedureCode'></a>
### ProcedureCode `property`

##### Summary

The CPT code associated with this procedure.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-ProcedureDescription'></a>
### ProcedureDescription `property`

##### Summary

A description of this procedure.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Procedure-TransactionId'></a>
### TransactionId `property`

##### Summary

The ID of the last transaction associated with the claim.

<a name='T-AthenaHealth-Sdk-Models-Response-Provider'></a>
## Provider `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-AcceptingNewPatients'></a>
### AcceptingNewPatients `property`

##### Summary

Indicates whether the provider is accepting new patients.
This field is currently only for informational purposes, and does not drive any athenaNet functionality.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-AnsiNameCode'></a>
### AnsiNameCode `property`

##### Summary

This is the ANSI name with ANSI code for this provider's specialty.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-AnsiSpecialtyCode'></a>
### AnsiSpecialtyCode `property`

##### Summary

This is the ANSI code for this provider's specialty.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-Billable'></a>
### Billable `property`

##### Summary

Indicates if this is a billable provider.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-CreateEncounterOnCheckIn'></a>
### CreateEncounterOnCheckIn `property`

##### Summary

If true, appointments scheduled with this provider will create an encounter when the appointment
is checked in for encounter supported appointment types.
Only applies to the primary providerid.
If the provider has other IDs with the same API,
please use '[](#!-GetProviderFilter-ShowAllProviderIds 'GetProviderFilter.ShowAllProviderIds')' to see which IDs create encounters.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-CreateEncounterProviderIdList'></a>
### CreateEncounterProviderIdList `property`

##### Summary

A list of provider IDs for this provider NPI that will create an encounter when the appointment is checked in for encounter supported appointment types.
Only populated if 'showallproviderids' is set.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-DisplayName'></a>
### DisplayName `property`

##### Summary

The preferred name to use when displaying this provider.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-EntityType'></a>
### EntityType `property`

##### Summary

Either "Person" or "Non-Person" (e.g. X-Ray machines)

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-FirstName'></a>
### FirstName `property`

##### Summary

The provider's first name.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-HideInPortal'></a>
### HideInPortal `property`

##### Summary

If set, this provider does not appear in athenaCommunicator's web portal.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-HomeDepartment'></a>
### HomeDepartment `property`

##### Summary

For certain purposes, this can be considered to be the "home" or default department for a provider.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-Id'></a>
### Id `property`

##### Summary

The ID to be used for this provider.
Note that in athenaNet, an individual provider (as defined by a unique NPI)
may have multiple provider IDs. For the API, we have collapsed these to a single canonical ID.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-LastName'></a>
### LastName `property`

##### Summary

The provider's last name.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-Npi'></a>
### Npi `property`

##### Summary

The NPI for this provider, if available.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-OtherProviderIdList'></a>
### OtherProviderIdList `property`

##### Summary

When showallproviderids is set to true, a list of all other athenaNet providers IDs that may refer to this same provider.
If not present with showallproviderids, there are no other IDs other than the primary ID.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-ProviderGroupList'></a>
### ProviderGroupList `property`

##### Summary

When showallproviderids is set to true, a list of all provider groups that this provider is registered in.
Data is only relevant if a practice is using Provider-Group-Based Data Permissions in their practice.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-ProviderType'></a>
### ProviderType `property`

##### Summary

There is a long potential list of provider type in the form "full name (id)",
but "MD", "NP" or "NP S" (Nurse Practitioner (Supervising)), "RES" (resident),
"EQUIP", "DO", "PA" or "PASUP" (Physician's Assistant (Supervising)), "TECH",
"RN", LPT", "CRNA" or "CRNASUP" (Certified Registered Nurse Anesthesiologist (Supervising)),
and MA (Medical Assistant) are among the most common.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-ProviderTypeId'></a>
### ProviderTypeId `property`

##### Summary

This is just the ID (a text string) such as "NP" or "NP S" for the provider type.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-ProviderUsername'></a>
### ProviderUsername `property`

##### Summary

The username of the provider.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-ScheduleResourceType'></a>
### ScheduleResourceType `property`

##### Summary

Name of the scheduling resource type tied to the provider.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-SchedulingName'></a>
### SchedulingName `property`

##### Summary

The scheduling name for this provider (as used in athenaNet).

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-Specialty'></a>
### Specialty `property`

##### Summary

A friendly name for this provider's specialty.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-SupervisingProviderId'></a>
### SupervisingProviderId `property`

##### Summary

The ID of the supervising provider.

<a name='P-AthenaHealth-Sdk-Models-Response-Provider-UsualDepartmentId'></a>
### UsualDepartmentId `property`

##### Summary

The "usual" department for this provider, if SHOWUSUALDEPARTMENTGUESSTHRESHOLD is set.

<a name='T-AthenaHealth-Sdk-Models-Response-ProviderExtended'></a>
## ProviderExtended `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-ProviderExtended-FederalIdNumber'></a>
### FederalIdNumber `property`

##### Summary

The federal ID number for provider, if SHOWFEDERALIDNUMBER is set.

<a name='T-AthenaHealth-Sdk-Models-Response-ProviderType'></a>
## ProviderType `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-ProviderType-Id'></a>
### Id `property`

##### Summary

Id of [ProviderType](#T-AthenaHealth-Sdk-Models-Response-ProviderType 'AthenaHealth.Sdk.Models.Response.ProviderType').
For example: "ACNP".

<a name='P-AthenaHealth-Sdk-Models-Response-ProviderType-Name'></a>
### Name `property`

##### Summary

Name of [ProviderType](#T-AthenaHealth-Sdk-Models-Response-ProviderType 'AthenaHealth.Sdk.Models.Response.ProviderType').
For example: ""ACUTE CARE - NURSE PRACTITIONER".

<a name='T-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-Question'></a>
## Question `type`

##### Namespace

AthenaHealth.Sdk.Models.Request.UpdateMedicalHistory

<a name='T-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-Question'></a>
## Question `type`

##### Namespace

AthenaHealth.Sdk.Models.Request.UpdateSocialHistory

<a name='T-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question'></a>
## Question `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.MedicalHistory

<a name='T-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question'></a>
## Question `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.PatientSocialHistory

<a name='T-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question'></a>
## Question `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.SocialHistoryTemplate

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-Question-Answer'></a>
### Answer `property`

##### Summary

Answer to this question

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-Question-Delete'></a>
### Delete `property`

##### Summary

Remove the answer to this question

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-Question-Id'></a>
### Id `property`

##### Summary

The athenaNet question id.

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-Question-Note'></a>
### Note `property`

##### Summary

Any additional notes

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-Question-Answer'></a>
### Answer `property`

##### Summary

The answer to the question. A blank answer will delete the existing answer and the question will not show up in succeeding GETs unless includeunansweredquestions=true.

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-Question-Delete'></a>
### Delete `property`

##### Summary

Remove the answer to this question. Equivalent to submitting a null answer.

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-Question-Key'></a>
### Key `property`

##### Summary

The question key that identifies this question, irregardless of the template

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-Question-NotPerformedReason'></a>
### NotPerformedReason `property`

##### Summary

The reason the question was not performed.

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-Question-Note'></a>
### Note `property`

##### Summary

The note attached to this answer

<a name='P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question-Answer'></a>
### Answer `property`

##### Summary

The answer given by the patient to the question

<a name='P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question-Codeset'></a>
### Codeset `property`

##### Summary

Codeset the diagnosis code belongs to

<a name='P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question-Description'></a>
### Description `property`

##### Summary

Description of the code

<a name='P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question-DiagnosisCode'></a>
### DiagnosisCode `property`

##### Summary

Diagnosis code

<a name='P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question-Id'></a>
### Id `property`

##### Summary

Athena ID for the question

<a name='P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question-Note'></a>
### Note `property`

##### Summary

Any special notes

<a name='P-AthenaHealth-Sdk-Models-Response-MedicalHistory-Question-Value'></a>
### Value `property`

##### Summary

Disease being inquired about

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Answer'></a>
### Answer `property`

##### Summary

The patient answer to this question

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Id'></a>
### Id `property`

##### Summary

Unique ID for this question within this template.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Key'></a>
### Key `property`

##### Summary

Unique key for this question, can exist in multiple templates.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-LastUpdated'></a>
### LastUpdated `property`

##### Summary

The date this answer was last updated (or first answered if never updated).

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-NotPerformedReason'></a>
### NotPerformedReason `property`

##### Summary

The reason this question was not performed.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Note'></a>
### Note `property`

##### Summary

The notes associated with this question.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-NoteLastUpdatedDate'></a>
### NoteLastUpdatedDate `property`

##### Summary

The date this note was last updated (or first added if never updated).

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Ordering'></a>
### Ordering `property`

##### Summary

Display ordering for this question within this template

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-QuestionText'></a>
### QuestionText `property`

##### Summary

Human readable question

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-TemplateId'></a>
### TemplateId `property`

##### Summary

The template where this question is listed. If it exists on multiple templates, then only one of them.

<a name='P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question-Id'></a>
### Id `property`

##### Summary

Unique ID for this question within this template.

<a name='P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question-InputType'></a>
### InputType `property`

##### Summary

Input type for this question. Valid values are DROPDOWN, NUMERIC, FREETEXT, YESNO, and DATE

<a name='P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question-Key'></a>
### Key `property`

##### Summary

Unique key for this question, can exist in multiple templates.

<a name='P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question-Options'></a>
### Options `property`

##### Summary

If the inputtype is DROPDOWN, this contains the list of key => value selections.

<a name='P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question-Ordering'></a>
### Ordering `property`

##### Summary

Display ordering for this question within this template

<a name='P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question-QuestionText'></a>
### QuestionText `property`

##### Summary

Human readable question

<a name='P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Question-SocialHistoryStatus'></a>
### SocialHistoryStatus `property`

##### Summary

Indicate category of question MENTAL, FUNCTIONAL etc.

<a name='T-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Reaction'></a>
## Reaction `type`

##### Namespace

AthenaHealth.Sdk.Models.Request.SetPatientAllergies.Allergy

<a name='T-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-Reaction'></a>
## Reaction `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.PatientAllergy.Allergy

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Reaction-ReactionName'></a>
### ReactionName `property`

##### Summary

Name of the reaction

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Reaction-Severity'></a>
### Severity `property`

##### Summary

Severity of the reaction

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Reaction-SeveritySnomedCode'></a>
### SeveritySnomedCode `property`

##### Summary

SNOMED code for the severity of this reaction

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergy-Reaction-SnomedCode'></a>
### SnomedCode `property`

##### Summary

SNOMED code for this reaction

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-Reaction-ReactionName'></a>
### ReactionName `property`

##### Summary

Name of the reaction

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-Reaction-Severity'></a>
### Severity `property`

##### Summary

Severity of the reaction

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-Reaction-SeveritySnomedCode'></a>
### SeveritySnomedCode `property`

##### Summary

SNOMED code for the severity of this reaction

<a name='P-AthenaHealth-Sdk-Models-Response-PatientAllergy-Allergy-Reaction-SnomedCode'></a>
### SnomedCode `property`

##### Summary

SNOMED code for this reaction

<a name='T-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Reason'></a>
## Reason `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.PatientSocialHistory.Question

<a name='T-AthenaHealth-Sdk-Models-Response-Prescription-Reason'></a>
## Reason `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Prescription

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Reason-Code'></a>
### Code `property`

##### Summary

SNOMED code for the not performed reason, or 1 if there is no reason

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Question-Reason-Text'></a>
### Text `property`

##### Summary

Human-readable text for the not performed reason.

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-Reason-Code'></a>
### Code `property`

##### Summary

The code indicating why the order was not given.

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-Reason-Codeset'></a>
### Codeset `property`

##### Summary

The codeset that the code belongs to.

<a name='P-AthenaHealth-Sdk-Models-Response-Prescription-Reason-Description'></a>
### Description `property`

##### Summary

The plaintext description of the reason the order was not given.

<a name='T-AthenaHealth-Sdk-Models-Request-RecordPayment'></a>
## RecordPayment `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-RecordPayment-AppointmentId'></a>
### AppointmentId `property`

##### Summary

The ID of the appointment where the copay should be applied.

<a name='P-AthenaHealth-Sdk-Models-Request-RecordPayment-CardNumberLast4'></a>
### CardNumberLast4 `property`

##### Summary

The last 4 digits of the credit card number. This is required if the payment method is a credit card.

<a name='P-AthenaHealth-Sdk-Models-Request-RecordPayment-CheckNumber'></a>
### CheckNumber `property`

##### Summary

The check number.
This is required if the payment is made by check.

<a name='P-AthenaHealth-Sdk-Models-Request-RecordPayment-ClaimPayment'></a>
### ClaimPayment `property`

##### Summary

A JSON representation of claim ID and payment combinations.
For example, '[ { "1":"1.00"}, { "2":"5.00"} ].'
This indicates a payment of $1 for claim ID #1 and a payment of $5 for claim ID #2.

<a name='P-AthenaHealth-Sdk-Models-Request-RecordPayment-CopayAmount'></a>
### CopayAmount `property`

##### Summary

The amount associated with a particular appointment for a copay.

<a name='P-AthenaHealth-Sdk-Models-Request-RecordPayment-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The ID of the department where the payment or contract is being collected.

<a name='P-AthenaHealth-Sdk-Models-Request-RecordPayment-IsTodayService'></a>
### IsTodayService `property`

##### Summary

Apply the other amount value to today's service.

<a name='P-AthenaHealth-Sdk-Models-Request-RecordPayment-OtherAmount'></a>
### OtherAmount `property`

##### Summary

The amount being collected that is not associated with individual appointment.
This money goes into the "unapplied" bucket.
In the future, these payments will be able to be broken down by individual claim level.
Co-pay amounts should be in "copayamount".

<a name='P-AthenaHealth-Sdk-Models-Request-RecordPayment-PaymentMethod'></a>
### PaymentMethod `property`

##### Summary

Valid values include CASH or CHECK or anything as a result of [GetPaymentMethods](#M-AthenaHealth-Sdk-Clients-Interfaces-IDictionaryClient-GetPaymentMethods-AthenaHealth-Sdk-Models-Request-BaseLimitFilter- 'AthenaHealth.Sdk.Clients.Interfaces.IDictionaryClient.GetPaymentMethods(AthenaHealth.Sdk.Models.Request.BaseLimitFilter)')
Note that practices using Credit Card Plus (CCP) should typically NOT be using this call and should instead use the collectpayment endpoints to charge the card.
In addition, all payments recorded via this method are subject to the same policies as any other money collected by athenahealth.

<a name='P-AthenaHealth-Sdk-Models-Request-RecordPayment-PostDate'></a>
### PostDate `property`

##### Summary

The date the payment was made. Defaulted to today.

<a name='T-AthenaHealth-Sdk-Models-Response-Appointment-ReminderDetail'></a>
## ReminderDetail `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Appointment

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-ReminderDetail-CallTime'></a>
### CallTime `property`

##### Summary

Date and time of the call attempt.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-ReminderDetail-MessageResultId'></a>
### MessageResultId `property`

##### Summary

Id of the message attempt.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-ReminderDetail-MessageType'></a>
### MessageType `property`

##### Summary

The type of message that was attempted.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-ReminderDetail-Result'></a>
### Result `property`

##### Summary

A description of what happened during the call attempt.

<a name='T-AthenaHealth-Sdk-Models-Request-RescheduleAppointment'></a>
## RescheduleAppointment `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-RescheduleAppointment-AppointmentId'></a>
### AppointmentId `property`

##### Summary

The appointment slot to schedule into.

<a name='P-AthenaHealth-Sdk-Models-Request-RescheduleAppointment-IgnoreSchedulablePermission'></a>
### IgnoreSchedulablePermission `property`

##### Summary

By default, we allow booking of appointments marked as schedulable via the web.
This flag allows you to bypass that restriction for booking.

<a name='P-AthenaHealth-Sdk-Models-Request-RescheduleAppointment-NewAppointmentId'></a>
### NewAppointmentId `property`

##### Summary

The appointment ID of the new appointment.
(The appointment ID in the URL is the ID of the currently scheduled appointment.)

<a name='P-AthenaHealth-Sdk-Models-Request-RescheduleAppointment-NoPatientCase'></a>
### NoPatientCase `property`

##### Summary

By default, we create a patient case upon booking an appointment for new patients.
Setting this to true bypasses that patient case.

<a name='P-AthenaHealth-Sdk-Models-Request-RescheduleAppointment-PatientId'></a>
### PatientId `property`

##### Summary

The athenaNet patient ID.

<a name='P-AthenaHealth-Sdk-Models-Request-RescheduleAppointment-ReasonId'></a>
### ReasonId `property`

##### Summary

The appointment reason ID to be booked. If not provided, the same reason used in the original appointment will be used.
Note: when getting open appointment slots, a special reason of -1 will return appointment slots for any reason.
This is not recommended, however, because actual availability does depend on a real reason.
In addition, appointment availability when using -1 does not account for the ability to not allow appointments to be scheduled
too close to the current time (because that limit is set on a per appointment reason basis).

<a name='P-AthenaHealth-Sdk-Models-Request-RescheduleAppointment-RescheduleReason'></a>
### RescheduleReason `property`

##### Summary

A text explanation why the appointment is being rescheduled

<a name='T-AthenaHealth-Sdk-Http-Response'></a>
## Response `type`

##### Namespace

AthenaHealth.Sdk.Http

<a name='P-AthenaHealth-Sdk-Http-Response-Body'></a>
### Body `property`

##### Summary

Raw response body. Typically a string, but when requesting images, it will be a byte array.

<a name='P-AthenaHealth-Sdk-Http-Response-ContentType'></a>
### ContentType `property`

##### Summary

The content type of the response.

<a name='P-AthenaHealth-Sdk-Http-Response-Headers'></a>
### Headers `property`

##### Summary

Information about the API.

<a name='P-AthenaHealth-Sdk-Http-Response-StatusCode'></a>
### StatusCode `property`

##### Summary

The response status code.

<a name='M-AthenaHealth-Sdk-Http-Response-GetObjectContent``1-System-Boolean-'></a>
### GetObjectContent\`\`1(shouldThrowErrors) `method`

##### Summary

Deserializes response content to object of specified type.

##### Returns

Object of specified type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| shouldThrowErrors | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | True: Throws exception if invalid response object. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Object type |

<a name='T-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter'></a>
## SearchAppointmentRemindersFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='M-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter-#ctor-System-Int32,System-DateTime,System-DateTime-'></a>
### #ctor(departmentId,startDate,endDate) `constructor`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| departmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | An athenaNet department ID. |
| startDate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Find reminders for appointments whose approximate date is on or after this date. |
| endDate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Find reminders for appointments whose approximate date is on or before this date. |

<a name='P-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter-EndDate'></a>
### EndDate `property`

##### Summary

Find reminders for appointments whose approximate date is on or before this date.

<a name='P-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter-Limit'></a>
### Limit `property`

##### Summary

Number of entries to return (default 100, max 500)

<a name='P-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter-Offset'></a>
### Offset `property`

##### Summary

Starting point of entries; 0-indexed

<a name='P-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter-ShowDeleted'></a>
### ShowDeleted `property`

##### Summary

By default, we do not return reminders that have been deleted. Setting this to true will show all reminders regardless of status.

<a name='P-AthenaHealth-Sdk-Models-Request-SearchAppointmentRemindersFilter-StartDate'></a>
### StartDate `property`

##### Summary

Find reminders for appointments whose approximate date is on or after this date.

<a name='T-AthenaHealth-Sdk-Models-Request-SearchFacilitiesFilter'></a>
## SearchFacilitiesFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='M-AthenaHealth-Sdk-Models-Request-SearchFacilitiesFilter-#ctor-System-Int32,System-String,AthenaHealth-Sdk-Models-Enums-OrderTypeEnum,System-Nullable{System-Int32}-'></a>
### #ctor(departmentId,name,orderType,patientId) `constructor`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| departmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Used to help determine both whether to include which practice-configured facilities as well as help sort the results. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The facility to search for. This can include the name or address of the facility, in space delimited form. |
| orderType | [AthenaHealth.Sdk.Models.Enums.OrderTypeEnum](#T-AthenaHealth-Sdk-Models-Enums-OrderTypeEnum 'AthenaHealth.Sdk.Models.Enums.OrderTypeEnum') | The type of facility to search for. |
| patientId | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | Used to help determine which matches to return based on distance to patient and practice. |

<a name='P-AthenaHealth-Sdk-Models-Request-SearchFacilitiesFilter-DepartmentId'></a>
### DepartmentId `property`

##### Summary

Used to help determine both whether to include which practice-configured facilities
as well as help sort the results.

<a name='P-AthenaHealth-Sdk-Models-Request-SearchFacilitiesFilter-Name'></a>
### Name `property`

##### Summary

The facility to search for.
This can include the name or address of the facility, in space delimited form.

<a name='P-AthenaHealth-Sdk-Models-Request-SearchFacilitiesFilter-OrderType'></a>
### OrderType `property`

##### Summary

The type of facility to search for.

<a name='P-AthenaHealth-Sdk-Models-Request-SearchFacilitiesFilter-PatientId'></a>
### PatientId `property`

##### Summary

Used to help determine which matches to return based on distance to patient and practice.

<a name='T-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter'></a>
## SearchInsuranceFilter `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-InsuranceAddress'></a>
### InsuranceAddress `property`

##### Summary

The address of the insurer.

<a name='P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-InsuranceCity'></a>
### InsuranceCity `property`

##### Summary

The city of the insurer.

<a name='P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-InsurancePhone'></a>
### InsurancePhone `property`

##### Summary

The phone number of the insurer.

<a name='P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-InsurancePlanName'></a>
### InsurancePlanName `property`

##### Summary

The name of the insurer.

<a name='P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-InsuranceState'></a>
### InsuranceState `property`

##### Summary

The two letter state abbreviation of the insurer's location.

<a name='P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-InsuranceZip'></a>
### InsuranceZip `property`

##### Summary

The zipcode of the insurer. Nine digit zip codes are accepted in the format of 12345-6789.

<a name='P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-MemberId'></a>
### MemberId `property`

##### Summary

The patient's insurance member ID.

<a name='P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-ProductType'></a>
### ProductType `property`

##### Summary

The insurance product type ID.

<a name='P-AthenaHealth-Sdk-Models-Request-SearchInsuranceFilter-StateOfCoverage'></a>
### StateOfCoverage `property`

##### Summary

Two letter state abbreviation that filters for insurances that cover this state.

<a name='T-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence'></a>
## Sentence `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.LabResultInterpretationTemplate.Paragraph

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Findings'></a>
### Findings `property`

##### Summary

The findings in the sentence

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Name'></a>
### Name `property`

##### Summary

The name of the sentence in the paragraph.

<a name='P-AthenaHealth-Sdk-Models-Response-LabResultInterpretationTemplate-Paragraph-Sentence-Note'></a>
### Note `property`

##### Summary

The note that goes along with this sentence.

<a name='T-AthenaHealth-Sdk-Models-Request-SetPatientAllergies'></a>
## SetPatientAllergies `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-Allergies'></a>
### Allergies `property`

##### Summary

Allergies

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The ID of the department for this patient. A patient may have multiple charts, and the department determines which chart to use.

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-NoKnownDrugAllergies'></a>
### NoKnownDrugAllergies `property`

##### Summary

Whether the patient has no known drug allergies. This is an explicit statement separate from a patient with no documented allergies so far. Note that while a patient can have this checked and have allergies, that is not recommended.

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-PatientId'></a>
### PatientId `property`

##### Summary

The ID of the patient

<a name='P-AthenaHealth-Sdk-Models-Request-SetPatientAllergies-SectionNote'></a>
### SectionNote `property`

##### Summary

A section-wide note. Passing an empty string will remove any existing note.

<a name='T-AthenaHealth-Sdk-Models-Request-SetPharmacyRequest'></a>
## SetPharmacyRequest `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-SetPharmacyRequest-ClinicalProviderId'></a>
### ClinicalProviderId `property`

##### Summary

The clinical provider ID that you wish to set as the default pharmacy or add as a preferred pharmacy. This or the NCPDPID must be provided.

<a name='P-AthenaHealth-Sdk-Models-Request-SetPharmacyRequest-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department id.

<a name='P-AthenaHealth-Sdk-Models-Request-SetPharmacyRequest-NcpdpId'></a>
### NcpdpId `property`

##### Summary

The NCPDP ID of the clinical provider. Can be used instead of clinicalproviderid. Only one can be used.

<a name='T-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation'></a>
## SetPrivacyInformation `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The ID of the department where the privacy information was verified.

<a name='P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-ExpirationDate'></a>
### ExpirationDate `property`

##### Summary

The date this approval expires (for release of billing information and assignment of benefits).

<a name='P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-InsuredSignature'></a>
### InsuredSignature `property`

##### Summary

If set, this flag sets the Assignment of Benefits privacy checkbox.

<a name='P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-PatientSignature'></a>
### PatientSignature `property`

##### Summary

If set, this flag sets the Release of Billing Information privacy checkbox.

<a name='P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-PrivacyNotice'></a>
### PrivacyNotice `property`

##### Summary

If set, this flag sets the Privacy Notice privacy checkbox.

<a name='P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-ReasonPatientUnableToSign'></a>
### ReasonPatientUnableToSign `property`

##### Summary

If the patient is unable to sign a reason why.

<a name='P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-SignatureDateTime'></a>
### SignatureDateTime `property`

##### Summary

If presenting an e-signature, the mm/dd/yyyy hh24:mi:ss formatted time that the signer signed. This is required if a signature name is provided.

<a name='P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-SignatureName'></a>
### SignatureName `property`

##### Summary

If presenting an e-signature, the name the signer typed, up to 100 characters.

<a name='P-AthenaHealth-Sdk-Models-Request-SetPrivacyInformation-SignerRelationshipToPatient'></a>
### SignerRelationshipToPatient `property`

##### Summary

If presenting an e-signature, and the signer is signing on behalf of someone else, the relationship of the patient to the signer. There is a documentation page with details.

<a name='T-AthenaHealth-Sdk-Models-Response-SnomedIcdCode'></a>
## SnomedIcdCode `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

##### Summary

ICD equivalent Codes for the SNOMED Code.

<a name='P-AthenaHealth-Sdk-Models-Response-SnomedIcdCode-Code'></a>
### Code `property`

##### Summary

ICD 10 Code.

<a name='P-AthenaHealth-Sdk-Models-Response-SnomedIcdCode-CodeSet'></a>
### CodeSet `property`

##### Summary

Code set the ICD10 code belongs to.

<a name='P-AthenaHealth-Sdk-Models-Response-SnomedIcdCode-Description'></a>
### Description `property`

##### Summary

Brief description for this code.

<a name='P-AthenaHealth-Sdk-Models-Response-SnomedIcdCode-Ndc'></a>
### Ndc `property`

##### Summary

Unstripped Diagnosis Code.

<a name='T-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate'></a>
## SocialHistoryTemplate `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Id'></a>
### Id `property`

##### Summary

ID for this social history template

<a name='P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-Questions'></a>
### Questions `property`

##### Summary

List of questions contained by this template

<a name='P-AthenaHealth-Sdk-Models-Response-SocialHistoryTemplate-TemplateName'></a>
### TemplateName `property`

##### Summary

Name for this social history template

<a name='T-AthenaHealth-Sdk-Models-Response-Appointment-Claim-StatusNote'></a>
## StatusNote `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Appointment.Claim

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-StatusNote-Note'></a>
### Note `property`

##### Summary

The note that is attached to this status.

<a name='P-AthenaHealth-Sdk-Models-Response-Appointment-Claim-StatusNote-Status'></a>
### Status `property`

##### Summary

The status associated with this responsible payer.

<a name='T-AthenaHealth-Sdk-Models-Response-StatusResponse'></a>
## StatusResponse `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-StatusResponse-ErrorMessage'></a>
### ErrorMessage `property`

##### Summary

If [IsSuccess](#P-AthenaHealth-Sdk-Models-Response-BaseResponse-IsSuccess 'AthenaHealth.Sdk.Models.Response.BaseResponse.IsSuccess') is false will contain error message.

<a name='T-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel'></a>
## StructuredSigModel `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.PatientMedication.Medication

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageAction'></a>
### DosageAction `property`

##### Summary

How the medication is taken. Examples are Chew, Take, Inhale, etc.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageAdditionalInstructions'></a>
### DosageAdditionalInstructions `property`

##### Summary

Additional instructions. Example: with meals

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageDurationUnit'></a>
### DosageDurationUnit `property`

##### Summary

The unit of the duration. Example: days. So take this for days.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageDurationValue'></a>
### DosageDurationValue `property`

##### Summary

How many duration time units this medication should be taken for.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageFrequencyBalue'></a>
### DosageFrequencyBalue `property`

##### Summary

How many times (in the given time unit) this should be taken.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageFrequencyDescription'></a>
### DosageFrequencyDescription `property`

##### Summary

A standardized patient-friendly frequency. Example: 6 per day becomes "every 4 hours".

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageFrequencyUnit'></a>
### DosageFrequencyUnit `property`

##### Summary

The unit of the frequency. Example: per day, per week.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageQuantityUnit'></a>
### DosageQuantityUnit `property`

##### Summary

The unit of the quantity. Example: tablets, sprays, etc.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageQuantityValue'></a>
### DosageQuantityValue `property`

##### Summary

How many of this med is taken.

<a name='P-AthenaHealth-Sdk-Models-Response-PatientMedication-Medication-StructuredSigModel-DosageRoute'></a>
### DosageRoute `property`

##### Summary

How this medication is taken. Example: oral, inhalation, intranasal, etc.

<a name='T-AthenaHealth-Sdk-Models-Request-SubscribeToEvent'></a>
## SubscribeToEvent `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-SubscribeToEvent-EventName'></a>
### EventName `property`

##### Summary

By default, you are subscribed to all possible events. If you only wish to subscribe to
an individual event, pass the event name with this argument.

<a name='P-AthenaHealth-Sdk-Models-Request-SubscribeToEvent-IncludeReminderCall'></a>
### IncludeReminderCall `property`

##### Summary

If this is set, we will include the UpdateRemiderCall event as if it is one of the
default events. Otherwise we will ignore that it exists.

<a name='P-AthenaHealth-Sdk-Models-Request-SubscribeToEvent-IncludeSuggestedOverbooking'></a>
### IncludeSuggestedOverbooking `property`

##### Summary

If this is set, we will include the UpdateSuggestedOverbooking event as if it is one of
the default events. Otherwise we will ignore that it exists.

<a name='T-AthenaHealth-Sdk-Models-Response-AppointmentSubscriptionEvent-Subscription'></a>
## Subscription `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.AppointmentSubscriptionEvent

<a name='P-AthenaHealth-Sdk-Models-Response-AppointmentSubscriptionEvent-Subscription-EventName'></a>
### EventName `property`

##### Summary

Name of event

<a name='T-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Template'></a>
## Template `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.PatientSocialHistory

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Template-Id'></a>
### Id `property`

##### Summary

ID for this social history template

<a name='P-AthenaHealth-Sdk-Models-Response-PatientSocialHistory-Template-Name'></a>
### Name `property`

##### Summary

Name for this social history template

<a name='T-AthenaHealth-Sdk-Models-Response-TopInsurancePackage'></a>
## TopInsurancePackage `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-TopInsurancePackage-Id'></a>
### Id `property`

##### Summary

The athenaNet-wide insurance package (also know in the industry as an "insurance product") id.

<a name='P-AthenaHealth-Sdk-Models-Response-TopInsurancePackage-InsuranceProductTypeName'></a>
### InsuranceProductTypeName `property`

##### Summary

The type of product (e.g. PPO, HMO, etc.)

<a name='T-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction'></a>
## Transaction `type`

##### Namespace

AthenaHealth.Sdk.Models.Response.Patient.ClaimBalanceDetail.ClaimDetail.ChargeLevelDetail

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction-Amount'></a>
### Amount `property`

##### Summary

The amount associated with the transaction.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction-Date'></a>
### Date `property`

##### Summary

The date of the transaction.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction-Description'></a>
### Description `property`

##### Summary

Information related to the type of transaction. (For example, a co-pay.).

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction-EpaymentId'></a>
### EpaymentId `property`

##### Summary

The epayment ID of the payment receipt associated with this payment
transaction. Applicable only for e-payments.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction-Id'></a>
### Id `property`

##### Summary

The athenaNet ID of the transaction.

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction-TransferType'></a>
### TransferType `property`

##### Summary

The party responsible for the parent charge of this transaction. For
example, '1' (primary), '2' (secondary), or 'p' (patient).

<a name='P-AthenaHealth-Sdk-Models-Response-Patient-ClaimBalanceDetail-ClaimDetail-ChargeLevelDetail-Transaction-Type'></a>
### Type `property`

##### Summary

The type of the transaction. For charge, payment, adjustment, etc.

<a name='T-AthenaHealth-Sdk-Models-Request-UnsubscribeFromEvent'></a>
## UnsubscribeFromEvent `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-UnsubscribeFromEvent-EventName'></a>
### EventName `property`

##### Summary

By default, you are unsubscribed from all possible events. If you only wish to
unsubscribe from an individual event, pass the event name with this argument.

<a name='P-AthenaHealth-Sdk-Models-Request-UnsubscribeFromEvent-IncludeReminderCall'></a>
### IncludeReminderCall `property`

##### Summary

If this is set, we will include the UpdateRemiderCall event as if it is one of the
default events. Otherwise we will ignore that it exists.

<a name='P-AthenaHealth-Sdk-Models-Request-UnsubscribeFromEvent-IncludeSuggestedOverbooking'></a>
### IncludeSuggestedOverbooking `property`

##### Summary

If this is set, we will include the UpdateSuggestedOverbooking event as if it is one of
the default events. Otherwise we will ignore that it exists.

<a name='T-AthenaHealth-Sdk-Models-Request-UpdateInsuranceCardPhoto'></a>
## UpdateInsuranceCardPhoto `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateInsuranceCardPhoto-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The department ID associated with this upload.

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateInsuranceCardPhoto-Image'></a>
### Image `property`

##### Summary

Base64 encoded image, or, if multipart/form-data, unencoded image. This image may be
scaled down after submission. PUT is not recommended when using multipart/form-data.
Since POST and PUT have identical functionality, POST is recommended.

<a name='T-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory'></a>
## UpdateMedicalHistory `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department ID.

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-Questions'></a>
### Questions `property`

##### Summary

JSON array of:

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateMedicalHistory-SectionNote'></a>
### SectionNote `property`

##### Summary

Any additional section notes

<a name='T-AthenaHealth-Sdk-Models-Response-UpdateMedicalHistoryResponse'></a>
## UpdateMedicalHistoryResponse `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-UpdateMedicalHistoryResponse-Error'></a>
### Error `property`

##### Summary

If the operation failed, this will contain any error messages.

<a name='P-AthenaHealth-Sdk-Models-Response-UpdateMedicalHistoryResponse-Success'></a>
### Success `property`

##### Summary

Whether the operation was successful or not.

<a name='T-AthenaHealth-Sdk-Models-Request-UpdatePatient'></a>
## UpdatePatient `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-UpdatePatient-LookupDepartmentId'></a>
### LookupDepartmentId `property`

##### Summary

Use this in practices that register copies of patients in different departments in order
to make sure you are updating the correct version of the patient.

<a name='P-AthenaHealth-Sdk-Models-Request-UpdatePatient-RegisterPatientInDepartment'></a>
### RegisterPatientInDepartment `property`

##### Summary

If you use LOOKUPDEPARTMENTID to get the local copy of a patient to update, and if the
patient is not currently registered in that department, setting this flag will register a
new copy of this patient in that department.

<a name='T-AthenaHealth-Sdk-Models-Response-UpdatePatientResponse'></a>
## UpdatePatientResponse `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-UpdatePatientResponse-PatientId'></a>
### PatientId `property`

##### Summary

Please remember to never disclose this ID to patients since it may result in inadvertant
disclosure that a patient exists in a practice already.

<a name='T-AthenaHealth-Sdk-Models-Request-UpdatePhoto'></a>
## UpdatePhoto `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-UpdatePhoto-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The department ID associated with this upload.

<a name='P-AthenaHealth-Sdk-Models-Request-UpdatePhoto-Image'></a>
### Image `property`

##### Summary

Base64 encoded image, or, if multipart/form-data, unencoded image. This image may be
scaled down after submission. PUT is not recommended when using multipart/form-data.
Since POST and PUT have identical functionality, POST is recommended.

<a name='T-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory'></a>
## UpdateSocialHistory `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The department for this patient. A patient may have multiple charts, and the department determines which chart to retrieve.

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-Questions'></a>
### Questions `property`

##### Summary

JSON array

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistory-SectionNote'></a>
### SectionNote `property`

##### Summary

A section-wide note

<a name='T-AthenaHealth-Sdk-Models-Response-UpdateSocialHistoryResponse'></a>
## UpdateSocialHistoryResponse `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-UpdateSocialHistoryResponse-Error'></a>
### Error `property`

##### Summary

On failure, the reason for failure

<a name='P-AthenaHealth-Sdk-Models-Response-UpdateSocialHistoryResponse-Success'></a>
### Success `property`

##### Summary

Whether the operation was successfull.

<a name='T-AthenaHealth-Sdk-Models-Request-UpdateSocialHistoryTemplates'></a>
## UpdateSocialHistoryTemplates `type`

##### Namespace

AthenaHealth.Sdk.Models.Request

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistoryTemplates-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The athenaNet department id.

<a name='P-AthenaHealth-Sdk-Models-Request-UpdateSocialHistoryTemplates-TemplateIds'></a>
### TemplateIds `property`

##### Summary

A comma separated list of template IDs to subscribe to.

<a name='T-AthenaHealth-Sdk-Models-Response-UpdateSocialHistoryTemplatesResponse'></a>
## UpdateSocialHistoryTemplatesResponse `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-UpdateSocialHistoryTemplatesResponse-Error'></a>
### Error `property`

##### Summary

On failure, the reason for failure

<a name='P-AthenaHealth-Sdk-Models-Response-UpdateSocialHistoryTemplatesResponse-Success'></a>
### Success `property`

##### Summary

Whether the operation was successfull.

<a name='T-AthenaHealth-Sdk-Http-Helpers-UrlBuilder'></a>
## UrlBuilder `type`

##### Namespace

AthenaHealth.Sdk.Http.Helpers

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-String,System-Object,System-Int32-'></a>
### BuildUri(url,queryParameters,port) `method`

##### Summary

Adds query parameters to specified url.

##### Returns

Concatenated uri.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Base url. |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameter object. Parameter names are resolved basing on property name or [JsonPropertyAttribute](#T-Newtonsoft-Json-JsonPropertyAttribute 'Newtonsoft.Json.JsonPropertyAttribute'). |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | If not specified it will not be included in url. |

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-String,System-Object-'></a>
### BuildUri(url,queryParameters) `method`

##### Summary

Adds query parameters to specified url.

##### Returns

Concatenated uri.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Base url. |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameter object. Parameter names are resolved basing on property name or [JsonPropertyAttribute](#T-Newtonsoft-Json-JsonPropertyAttribute 'Newtonsoft.Json.JsonPropertyAttribute'). |

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-Uri,System-Object,System-Int32-'></a>
### BuildUri(uri,queryParameters,port) `method`

##### Summary

Adds query parameters to specified uri.

##### Returns

Concatenated uri.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Base uri. |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameter object. Parameter names are resolved basing on property name or [JsonPropertyAttribute](#T-Newtonsoft-Json-JsonPropertyAttribute 'Newtonsoft.Json.JsonPropertyAttribute'). |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | If not specified it will not be included in url. |

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-Uri,System-Object-'></a>
### BuildUri(uri,queryParameters) `method`

##### Summary

Adds query parameters to specified uri.

##### Returns

Concatenated uri.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Base uri. |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameter object. Parameter names are resolved basing on property name or [JsonPropertyAttribute](#T-Newtonsoft-Json-JsonPropertyAttribute 'Newtonsoft.Json.JsonPropertyAttribute'). |

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-String,System-Collections-Generic-IDictionary{System-String,System-String},System-Int32-'></a>
### BuildUri(url,queryParameters,port) `method`

##### Summary

Adds query parameters to specified url.

##### Returns

Concatenated uri.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Base url. |
| queryParameters | [System.Collections.Generic.IDictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,System.String}') | Query parameters dictionary |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | If not specified it will not be included in url. |

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-String,System-Collections-Generic-IDictionary{System-String,System-String}-'></a>
### BuildUri(url,queryParameters) `method`

##### Summary

Adds query parameters to specified url.

##### Returns

Concatenated uri.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Base url. |
| queryParameters | [System.Collections.Generic.IDictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,System.String}') | Query parameters dictionary |

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-Uri,System-Collections-Generic-IDictionary{System-String,System-String},System-Int32-'></a>
### BuildUri(uri,queryParameters,port) `method`

##### Summary

Adds query parameters to specified uri.

##### Returns

Concatenated uri.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Base uri. |
| queryParameters | [System.Collections.Generic.IDictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,System.String}') | Query parameters dictionary |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | If not specified it will not be included in url. |

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUri-System-Uri,System-Collections-Generic-IDictionary{System-String,System-String}-'></a>
### BuildUri(uri,queryParameters) `method`

##### Summary

Adds query parameters to specified uri.

##### Returns

Concatenated uri.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Base uri. |
| queryParameters | [System.Collections.Generic.IDictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,System.String}') | Query parameters dictionary |

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-String,System-Object,System-Int32-'></a>
### BuildUrl(url,queryParameters,port) `method`

##### Summary

Adds query parameters to specified url.

##### Returns

Concatenated url.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Base url. |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameter object. Parameter names are resolved basing on property name or [JsonPropertyAttribute](#T-Newtonsoft-Json-JsonPropertyAttribute 'Newtonsoft.Json.JsonPropertyAttribute'). |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | If not specified it will not be included in url. |

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-String,System-Object-'></a>
### BuildUrl(url,queryParameters) `method`

##### Summary

Adds query parameters to specified url.

##### Returns

Concatenated url.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Base url. |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameter object. Parameter names are resolved basing on property name or [JsonPropertyAttribute](#T-Newtonsoft-Json-JsonPropertyAttribute 'Newtonsoft.Json.JsonPropertyAttribute'). |

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-Uri,System-Object,System-Int32-'></a>
### BuildUrl(uri,queryParameters,port) `method`

##### Summary

Adds query parameters to specified uri.

##### Returns

Concatenated url.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Base uri. |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameter object. Parameter names are resolved basing on property name or [JsonPropertyAttribute](#T-Newtonsoft-Json-JsonPropertyAttribute 'Newtonsoft.Json.JsonPropertyAttribute'). |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | If not specified it will not be included in url. |

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-Uri,System-Object-'></a>
### BuildUrl(uri,queryParameters) `method`

##### Summary

Adds query parameters to specified uri.

##### Returns

Concatenated url.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Base uri. |
| queryParameters | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Query parameter object. Parameter names are resolved basing on property name or [JsonPropertyAttribute](#T-Newtonsoft-Json-JsonPropertyAttribute 'Newtonsoft.Json.JsonPropertyAttribute'). |

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-String,System-Collections-Generic-IDictionary{System-String,System-String},System-Int32-'></a>
### BuildUrl(url,queryParameters,port) `method`

##### Summary

Adds query parameters to specified url.

##### Returns

Concatenated url.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Base url. |
| queryParameters | [System.Collections.Generic.IDictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,System.String}') | Query parameters dictionary |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | If not specified it will not be included in url. |

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-String,System-Collections-Generic-IDictionary{System-String,System-String}-'></a>
### BuildUrl(url,queryParameters) `method`

##### Summary

Adds query parameters to specified url.

##### Returns

Concatenated url.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Base url. |
| queryParameters | [System.Collections.Generic.IDictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,System.String}') | Query parameters dictionary |

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-Uri,System-Collections-Generic-IDictionary{System-String,System-String},System-Int32-'></a>
### BuildUrl(uri,queryParameters,port) `method`

##### Summary

Adds query parameters to specified uri.

##### Returns

Concatenated url.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Base uri. |
| queryParameters | [System.Collections.Generic.IDictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,System.String}') | Query parameters dictionary |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | If not specified it will not be included in url. |

<a name='M-AthenaHealth-Sdk-Http-Helpers-UrlBuilder-BuildUrl-System-Uri,System-Collections-Generic-IDictionary{System-String,System-String}-'></a>
### BuildUrl(uri,queryParameters) `method`

##### Summary

Adds query parameters to specified uri.

##### Returns

Concatenated url.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Base uri. |
| queryParameters | [System.Collections.Generic.IDictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{System.String,System.String}') | Query parameters dictionary |

<a name='T-AthenaHealth-Sdk-Models-Response-WaitListItem'></a>
## WaitListItem `type`

##### Namespace

AthenaHealth.Sdk.Models.Response

<a name='P-AthenaHealth-Sdk-Models-Response-WaitListItem-AppointmentId'></a>
### AppointmentId `property`

##### Summary

The booked appointment ID of the appointment that this wait list entry would replace.

<a name='P-AthenaHealth-Sdk-Models-Response-WaitListItem-AppointmentTypeId'></a>
### AppointmentTypeId `property`

##### Summary

The appointment type ID of the desired appointment.

<a name='P-AthenaHealth-Sdk-Models-Response-WaitListItem-Created'></a>
### Created `property`

##### Summary

The date and time that this wait list entry was created.

<a name='P-AthenaHealth-Sdk-Models-Response-WaitListItem-DayOfWeekIds'></a>
### DayOfWeekIds `property`

##### Summary

A list of day of week IDs that are desired by the patient, with 1 being Sunday, and 7 being Saturday.

<a name='P-AthenaHealth-Sdk-Models-Response-WaitListItem-DepartmentId'></a>
### DepartmentId `property`

##### Summary

The department ID of the desired department.  This can be blank if any department is acceptable.

<a name='P-AthenaHealth-Sdk-Models-Response-WaitListItem-HourFrom'></a>
### HourFrom `property`

##### Summary

The hour (24 hour clock) after which an appointment is desired by a patient.  Inclusive.

<a name='P-AthenaHealth-Sdk-Models-Response-WaitListItem-HourTo'></a>
### HourTo `property`

##### Summary

The hour (24 hour clock) before which an appointment is desired by a patient.  Inclusive.

<a name='P-AthenaHealth-Sdk-Models-Response-WaitListItem-Id'></a>
### Id `property`

##### Summary

The wait list ID, used in other calls.

<a name='P-AthenaHealth-Sdk-Models-Response-WaitListItem-Note'></a>
### Note `property`

##### Summary

Practice-facing note about why the wait list entry exists.

<a name='P-AthenaHealth-Sdk-Models-Response-WaitListItem-PatientId'></a>
### PatientId `property`

##### Summary

The patient ID of the patient who is on the wait list.

<a name='P-AthenaHealth-Sdk-Models-Response-WaitListItem-Priority'></a>
### Priority `property`

##### Summary

Indicating the priority of this wait list entry.

<a name='P-AthenaHealth-Sdk-Models-Response-WaitListItem-ProviderId'></a>
### ProviderId `property`

##### Summary

The provider ID of the desired provider.  This can be blank if any provider is acceptable.
