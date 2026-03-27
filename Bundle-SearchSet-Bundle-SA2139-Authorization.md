# SearchSet-Bundle-SA2139-Authorization - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **SearchSet-Bundle-SA2139-Authorization**

## Example Bundle: SearchSet-Bundle-SA2139-Authorization



## Resource Content

```json
{
  "resourceType" : "Bundle",
  "id" : "SearchSet-Bundle-SA2139-Authorization",
  "type" : "searchset",
  "total" : 1,
  "link" : [{
    "relation" : "self",
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition?code=SA2139&_include=ChargeItemDefinition:instance&_total=accurate"
  }],
  "entry" : [{
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Tenofovir-Emtricitabine-SA2139-Authorization",
    "resource" : {
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
      "version" : "1.0",
      "status" : "active",
      "publisher" : "Pharmac",
      "contact" : [{
        "name" : "Pharmac",
        "telecom" : [{
          "system" : "url",
          "value" : "https://www.pharmac.govt.nz/about/contact"
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
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/Medication/Medication-Tenofovir",
    "resource" : {
      "resourceType" : "Medication",
      "id" : "Medication-Ricovir-Tenofovir",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-brand-name",
        "valueString" : "Ricovir"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-package-size",
        "valueString" : "30"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-unit-of-measure",
        "valueString" : "tab"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-rank",
        "valueInteger" : 1
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-1",
        "valueString" : "Infections - Agents for Systemic Use"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-2",
        "valueString" : "Antivirals"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-3",
        "valueString" : "Hepatitis B Treatment"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-product-multiple",
        "valueBoolean" : false
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-product-multiplier",
        "valueInteger" : 0
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-original-pack",
        "valueBoolean" : false
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-safety-list-medicine",
        "valueBoolean" : false
      }],
      "identifier" : [{
        "system" : "http://schedule.pharmac.govt.nz/ids/brand",
        "value" : "B16190538672526"
      },
      {
        "system" : "http://schedule.pharmac.govt.nz/ids/pack",
        "value" : "P2703122"
      },
      {
        "system" : "http://schedule.pharmac.govt.nz/ids/chemical",
        "value" : "C1619053867"
      },
      {
        "system" : "http://schedule.pharmac.govt.nz/ids/formulation",
        "value" : "F161905386725"
      },
      {
        "system" : "http://schedule.pharmac.govt.nz/ids/pharmacode",
        "value" : "2703122"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50348251000117105",
          "display" : "Tenofovir disoproxil 300 tab, 30 tab"
        }],
        "text" : "Tenofovir disoproxil"
      },
      "status" : "active",
      "form" : {
        "coding" : [{
          "system" : "http://snomed.info/sct",
          "code" : "385055001",
          "display" : "Tablet"
        }],
        "text" : "Tab 245 mg (300 mg as a fumarate)"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "coding" : [{
            "system" : "http://nzmt.org.nz",
            "code" : "46616121000116103",
            "display" : "tenofovir disoproxil"
          }],
          "text" : "tenofovir disoproxil"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "include"
    }
  },
  {
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/Medication/Medication-Viramune-Suspension",
    "resource" : {
      "resourceType" : "Medication",
      "id" : "Medication-Viramune-Suspension",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-brand-name",
        "valueString" : "Viramune Suspension"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-package-size",
        "valueString" : "240"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-unit-of-measure",
        "valueString" : "ml"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-rank",
        "valueInteger" : 3
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-1",
        "valueString" : "Infections - Agents for Systemic Use"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-2",
        "valueString" : "Antiretrovirals"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-3",
        "valueString" : "Non-nucleosides Reverse Transcriptase Inhibitors"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-product-multiple",
        "valueBoolean" : false
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-product-multiplier",
        "valueInteger" : 0
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-original-pack",
        "valueBoolean" : false
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-safety-list-medicine",
        "valueBoolean" : false
      }],
      "identifier" : [{
        "system" : "http://schedule.pharmac.govt.nz/ids/brand",
        "value" : "B16200111702525"
      },
      {
        "system" : "http://schedule.pharmac.govt.nz/ids/pack",
        "value" : "P2014947"
      },
      {
        "system" : "http://schedule.pharmac.govt.nz/ids/chemical",
        "value" : "C1620011170"
      },
      {
        "system" : "http://schedule.pharmac.govt.nz/ids/formulation",
        "value" : "F162001117025"
      },
      {
        "system" : "http://schedule.pharmac.govt.nz/ids/pharmacode",
        "value" : "2014947"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50002451000117104",
          "display" : "Nevirapine 10 ml, 240 ml"
        }],
        "text" : "Nevirapine"
      },
      "status" : "active",
      "form" : {
        "coding" : [{
          "system" : "http://snomed.info/sct",
          "code" : "385013001",
          "display" : "Liquid"
        }],
        "text" : "Oral suspension 10 mg per ml"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "coding" : [{
            "system" : "http://nzmt.org.nz",
            "code" : "2391011000036108",
            "display" : "nevirapine"
          }],
          "text" : "nevirapine"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "include"
    }
  }]
}

```
