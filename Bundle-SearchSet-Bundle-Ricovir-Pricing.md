# SearchSet-Bundle-Ricovir-Pricing - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **SearchSet-Bundle-Ricovir-Pricing**

## Example Bundle: SearchSet-Bundle-Ricovir-Pricing



## Resource Content

```json
{
  "resourceType" : "Bundle",
  "id" : "SearchSet-Bundle-Ricovir-Pricing",
  "type" : "searchset",
  "total" : 1,
  "link" : [{
    "relation" : "self",
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/Medication?name=Tenofovir&_include=ChargeItemDefinition:instance"
  }],
  "entry" : [{
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
      "mode" : "match"
    }
  },
  {
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Ricovir-Pricing",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-Ricovir-Pricing",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date",
        "valueDate" : "2025-12-01"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/cost-brand-source",
        "valueBoolean" : false
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/wastage-claimable",
        "valueBoolean" : false
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/contract-type",
        "valueString" : "PSS"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/dv-limit-percent",
        "valueDecimal" : 5
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/brand-switch-fee",
        "valueBoolean" : false
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/statim",
        "valueString" : "Must"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/in-combination",
        "valueString" : "n/a"
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Ricovir-Pricing",
      "version" : "1.0",
      "title" : "Ricovir - Pricing",
      "status" : "active",
      "publisher" : "Pharmac",
      "contact" : [{
        "name" : "Pharmac",
        "telecom" : [{
          "system" : "url",
          "value" : "https://www.pharmac.govt.nz/about/contact"
        }]
      }],
      "description" : "Listed price, PHARMAC subsidy, and patient co-payment for Ricovir (Tenofovir disoproxil 300 tab, 30 tab)",
      "instance" : [{
        "reference" : "Medication/Medication-Ricovir-Tenofovir"
      }],
      "applicability" : [{
        "description" : "Community (subsidized) pricing - fully subsidized"
      }],
      "propertyGroup" : [{
        "applicability" : [{
          "description" : "Community (subsidized) pricing"
        }],
        "priceComponent" : [{
          "type" : "base",
          "code" : {
            "text" : "Listed Price"
          },
          "amount" : {
            "value" : 13.45,
            "currency" : "NZD"
          }
        },
        {
          "type" : "discount",
          "code" : {
            "text" : "PHARMAC Subsidy"
          },
          "amount" : {
            "value" : 13.45,
            "currency" : "NZD"
          }
        },
        {
          "type" : "surcharge",
          "code" : {
            "text" : "Patient Surcharge"
          },
          "amount" : {
            "value" : 0,
            "currency" : "NZD"
          }
        },
        {
          "type" : "informational",
          "code" : {
            "text" : "Patient Co-Payment (with limit)"
          },
          "amount" : {
            "value" : 0,
            "currency" : "NZD"
          }
        }]
      },
      {
        "applicability" : [{
          "description" : "Alternative pricing structure"
        }],
        "priceComponent" : [{
          "type" : "base",
          "code" : {
            "text" : "Alternative Listed Price"
          },
          "amount" : {
            "value" : 13.45,
            "currency" : "NZD"
          }
        },
        {
          "type" : "discount",
          "code" : {
            "text" : "Alternative Subsidy/Reimbursement"
          },
          "amount" : {
            "value" : 13.45,
            "currency" : "NZD"
          }
        },
        {
          "type" : "informational",
          "code" : {
            "text" : "Alternative Patient Cost"
          },
          "amount" : {
            "value" : 0,
            "currency" : "NZD"
          }
        }]
      }]
    },
    "search" : {
      "mode" : "include"
    }
  },
  {
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Tenofovir-Case-Sequence-1",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-Tenofovir-Case-Sequence-1",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date",
        "valueDate" : "2025-12-01"
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCode" : "community"
        },
        {
          "extension" : [{
            "url" : "type",
            "valueCode" : "CaseSequence"
          },
          {
            "url" : "value",
            "valueInteger" : 1
          }],
          "url" : "rule"
        },
        {
          "extension" : [{
            "url" : "type",
            "valueCode" : "FundingMechanism"
          },
          {
            "url" : "attribute",
            "valueCode" : "Prescription"
          }],
          "url" : "rule"
        }],
        "url" : "http://schedule.pharmac.govt.nz/fhir/StructureDefinition/funding-rule"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-form",
        "valueString" : "SA2520"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-title",
        "valueString" : "Special Authorization Required"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count",
        "valueInteger" : 2
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Tenofovir-Case-Sequence-1",
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
      "description" : "Rules for Tenofovir Disoproxil. Demonstrates CQL expressions for clinical conditions relevant to authorization rules.",
      "applicability" : [{
        "description" : "Condition (provider): Prescription must be from an authorised prescriber.",
        "language" : "text/cql",
        "expression" : "exists(Condition where code in 'AuthorisedPrescriber')"
      }],
      "propertyGroup" : [{
        "applicability" : [{
          "description" : "Case 1 - community pharmacy prescription"
        }],
        "priceComponent" : [{
          "type" : "discount",
          "code" : {
            "text" : "PHARMAC Subsidy"
          },
          "amount" : {
            "value" : 13.45,
            "currency" : "NZD"
          }
        }]
      }]
    },
    "search" : {
      "mode" : "include"
    }
  },
  {
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Tenofovir-Case-Sequence-2",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-Tenofovir-Case-Sequence-2",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date",
        "valueDate" : "2025-12-01"
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCode" : "community"
        },
        {
          "extension" : [{
            "url" : "type",
            "valueCode" : "CaseSequence"
          },
          {
            "url" : "value",
            "valueInteger" : 2
          }],
          "url" : "rule"
        },
        {
          "extension" : [{
            "url" : "type",
            "valueCode" : "FundingMechanism"
          },
          {
            "url" : "attribute",
            "valueCode" : "Prescription"
          }],
          "url" : "rule"
        }],
        "url" : "http://schedule.pharmac.govt.nz/fhir/StructureDefinition/funding-rule"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-form",
        "valueString" : "SA2139"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-title",
        "valueString" : "Special Authorization Required"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count",
        "valueInteger" : 1
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Tenofovir-Case-Sequence-2",
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
      "description" : "Rules for Tenofovir Disoproxil. Demonstrates CQL expressions for clinical conditions relevant to authorization rules.",
      "applicability" : [{
        "description" : "Condition (provider): Prescription must be from an authorised prescriber.",
        "language" : "text/cql",
        "expression" : "exists(Condition where code in 'AuthorisedPrescriber')"
      }],
      "propertyGroup" : [{
        "applicability" : [{
          "description" : "Case 2 - community pharmacy prescription"
        }],
        "priceComponent" : [{
          "type" : "discount",
          "code" : {
            "text" : "PHARMAC Subsidy"
          },
          "amount" : {
            "value" : 13.45,
            "currency" : "NZD"
          }
        }]
      }]
    },
    "search" : {
      "mode" : "include"
    }
  },
  {
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
      "mode" : "include"
    }
  },
  {
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Tenofovir-Emtricitabine-SA2520-Authorization",
    "resource" : {
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
    },
    "search" : {
      "mode" : "include"
    }
  }]
}

```
