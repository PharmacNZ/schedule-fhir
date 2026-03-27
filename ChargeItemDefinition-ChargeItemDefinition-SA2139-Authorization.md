# ChargeItemDefinition-SA2139-Authorization - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinition-SA2139-Authorization**

## Example ChargeItemDefinition: ChargeItemDefinition-SA2139-Authorization

| |
| :--- |
| Active as of 2026-03-27 |



## Resource Content

```json
{
  "resourceType" : "ChargeItemDefinition",
  "id" : "ChargeItemDefinition-SA2139-Authorization",
  "meta" : {
    "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition"]
  },
  "extension" : [{
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date",
    "valueDate" : "2026-03-11"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count",
    "valueInteger" : 7
  }],
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-SA2139-Authorization",
  "version" : "0.0.1",
  "status" : "active",
  "date" : "2026-03-27T00:29:47+00:00",
  "publisher" : "Pharmac",
  "contact" : [{
    "name" : "Pharmac",
    "telecom" : [{
      "system" : "url",
      "value" : "https://www.pharmac.govt.nz/about/contact"
    }]
  },
  {
    "name" : "Pharmac",
    "telecom" : [{
      "system" : "email",
      "value" : "enquiry@pharmac.govt.nz",
      "use" : "work"
    }]
  }],
  "description" : "Special Authorization SA2139. Detailed eligibility criteria available via authorization form.",
  "code" : {
    "coding" : [{
      "system" : "http://pharmac.govt.nz/fhir/sa",
      "code" : "SA2139"
    }],
    "text" : "SA2139"
  },
  "instance" : [{
    "reference" : "Medication/Medication-Ricovir-Tenofovir"
  },
  {
    "reference" : "Medication/Medication-Viramune-Suspension"
  }],
  "applicability" : [{
    "description" : "Initial application - Confirmed HIV (Applications from named specialist. Approvals valid without further renewal unless notified).",
    "language" : "text/cql",
    "expression" : "exists(Condition where code in 'ConfirmedHIVInfection')"
  },
  {
    "description" : "Renewal - Confirmed HIV (Applications from named specialist. Approvals valid without further renewal unless notified).",
    "language" : "text/cql",
    "expression" : "exists(Condition where code in 'TreatmentRemainsAppropriate') and exists(Condition where code in 'PatientBenefitingFromTreatment')"
  },
  {
    "description" : "Initial application - Prevention of maternal transmission (Applications from named specialist. Approvals valid for 1 year).",
    "language" : "text/cql",
    "expression" : "exists(Condition where code in 'PreventionOfMaternalFoetalTransmission') or exists(Condition where code in 'TreatmentOfNewbornUpToEightWeeks')"
  },
  {
    "description" : "Initial application - pre-exposure prophylaxis following exposure to HIV (Applications from any relevant practitioner. Approvals valid for 4 weeks).",
    "language" : "text/cql",
    "expression" : "exists(Condition where code in 'TreatmentInitiatedWithin72HoursPostExposure') and (exists(Condition where code in 'CondomlessAnalOrReceptiveVaginalIntercourseWithKnownHIVPositiveVL>200') or exists(Condition where code in 'SharedInjectingEquipmentWithKnownHIVPositive') or exists(Condition where code in 'NonConsensualIntercourseRiskAssessmentIndicatesProphylaxisAppropriate') or exists(Condition where code in 'CondomlessAnalIntercourseWithHighPrevalenceCountryOrRiskGroupStatusUnknown'))"
  },
  {
    "description" : "Renewal - second or subsequent post-exposure prophylaxis (Applications from any relevant practitioner. Approvals valid for 4 weeks).",
    "language" : "text/cql",
    "expression" : "exists(Condition where code in 'TreatmentInitiatedWithin72HoursPostExposure') and (exists(Condition where code in 'CondomlessAnalOrReceptiveVaginalIntercourseWithKnownHIVPositiveVL>200') or exists(Condition where code in 'SharedInjectingEquipmentWithKnownHIVPositive') or exists(Condition where code in 'NonConsensualIntercourseRiskAssessmentIndicatesProphylaxisAppropriate') or exists(Condition where code in 'CondomlessAnalIntercourseWithHighPrevalenceCountryOrRiskGroupStatusUnknown'))"
  },
  {
    "description" : "Initial application - Percutaneous exposure (Applications from named specialist. Approvals valid for 6 weeks).",
    "language" : "text/cql",
    "expression" : "exists(Condition where code in 'PercutaneousExposureToHIVPositiveBlood')"
  },
  {
    "description" : "Renewal - Second or subsequent percutaneous exposure (Applications from named specialist. Approvals valid for 6 weeks).",
    "language" : "text/cql",
    "expression" : "exists(Condition where code in 'PercutaneousExposureToHIVPositiveBlood')"
  }]
}

```
