# ChargeItemDefinition-SA2520-Authorization - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinition-SA2520-Authorization**

## Example ChargeItemDefinition: ChargeItemDefinition-SA2520-Authorization

| |
| :--- |
| Active as of 2026-03-27 |



## Resource Content

```json
{
  "resourceType" : "ChargeItemDefinition",
  "id" : "ChargeItemDefinition-SA2520-Authorization",
  "meta" : {
    "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition"]
  },
  "extension" : [{
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date",
    "valueDate" : "2026-03-11"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-form",
    "valueString" : "SA2520"
  }],
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-SA2520-Authorization",
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
  "description" : "Special Authorization SA2520. Detailed eligibility criteria available via authorization form.",
  "code" : {
    "coding" : [{
      "system" : "http://pharmac.govt.nz/fhir/sa",
      "code" : "SA2520"
    }],
    "text" : "SA2520"
  },
  "instance" : [{
    "reference" : "Medication/Medication-Ricovir-Tenofovir"
  }],
  "applicability" : [{
    "description" : "Initial application - Pre-exposure prophylaxis (PrEP). Applications from any relevant practitioner. Approvals valid for 24 months.",
    "language" : "text/cql",
    "expression" : "exists(Condition where code in 'HIVNegativeNoAcuteSymptomsAndSeroconversionAssessed') and exists(Condition where code in 'ElevatedRiskOfHIVExposurePrEPClinicallyAppropriate')"
  },
  {
    "description" : "Renewal - Pre-exposure prophylaxis (PrEP). Applications from any relevant practitioner. Approvals valid for 24 months.",
    "language" : "text/cql",
    "expression" : "exists(Condition where code in 'HIVNegativeNoAcuteSymptomsAndSeroconversionAssessed') and exists(Condition where code in 'ElevatedRiskOfHIVExposurePrEPClinicallyAppropriate')"
  },
  {
    "description" : "Initial application - post-exposure prophylaxis (PEP) following exposure to HIV. Applications from any relevant practitioner. Approvals valid for 4 weeks.",
    "language" : "text/cql",
    "expression" : "exists(Condition where code in 'TreatmentInitiatedWithin72HoursPostExposure') and (exists(Condition where code in 'CondomlessAnalOrReceptiveVaginalIntercourseWithKnownHIVPositiveVL>200') or exists(Condition where code in 'SharedInjectingEquipmentWithKnownHIVPositive') or exists(Condition where code in 'NonConsensualIntercourseRiskAssessmentIndicatesProphylaxisAppropriate') or exists(Condition where code in 'CondomlessAnalIntercourseWithHighPrevalenceCountryOrRiskGroupStatusUnknown'))"
  },
  {
    "description" : "Renewal - second or subsequent post-exposure prophylaxis (PEP). Applications from any relevant practitioner. Approvals valid for 4 weeks.",
    "language" : "text/cql",
    "expression" : "exists(Condition where code in 'TreatmentInitiatedWithin72HoursPostExposure') and (exists(Condition where code in 'CondomlessAnalOrReceptiveVaginalIntercourseWithKnownHIVPositiveVL>200') or exists(Condition where code in 'SharedInjectingEquipmentWithKnownHIVPositive') or exists(Condition where code in 'NonConsensualIntercourseRiskAssessmentIndicatesProphylaxisAppropriate') or exists(Condition where code in 'CondomlessAnalIntercourseWithHighPrevalenceCountryOrRiskGroupStatusUnknown'))"
  }]
}

```
