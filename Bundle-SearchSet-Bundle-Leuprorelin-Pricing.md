# SearchSet-Bundle-Leuprorelin-Pricing - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **SearchSet-Bundle-Leuprorelin-Pricing**

## Example Bundle: SearchSet-Bundle-Leuprorelin-Pricing



## Resource Content

```json
{
  "resourceType" : "Bundle",
  "id" : "SearchSet-Bundle-Leuprorelin-Pricing",
  "type" : "searchset",
  "total" : 1,
  "link" : [{
    "relation" : "self",
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/Medication?name=Leuprorelin&_include=ChargeItemDefinition:instance"
  }],
  "entry" : [{
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/Medication/Medication-Lucrin-Depot-1-Month",
    "resource" : {
      "resourceType" : "Medication",
      "id" : "Medication-Lucrin-Depot-1-Month",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-brand-name",
        "valueString" : "Lucrin Depot 1-month"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-package-size",
        "valueString" : "1"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-unit-of-measure",
        "valueString" : "inj"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-rank",
        "valueInteger" : 4
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-1",
        "valueString" : "Hormone Preparations - Systemic Excluding Contraceptive Hormones"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-2",
        "valueString" : "Trophic Hormones"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-3",
        "valueString" : "GnRH Analogues"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-product-multiple",
        "valueBoolean" : true
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-product-multiplier",
        "valueInteger" : 1
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
        "value" : "B14160310092925"
      },
      {
        "system" : "http://schedule.pharmac.govt.nz/ids/pack",
        "value" : "P2330148"
      },
      {
        "system" : "http://schedule.pharmac.govt.nz/ids/chemical",
        "value" : "C1416031009"
      },
      {
        "system" : "http://schedule.pharmac.govt.nz/ids/formulation",
        "value" : "F141603100929"
      },
      {
        "system" : "http://schedule.pharmac.govt.nz/ids/pharmacode",
        "value" : "2330148"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50049431000117108",
          "display" : "Leuprorelin 3.75 inj, 1 inj"
        }],
        "text" : "Leuprorelin"
      },
      "status" : "active",
      "form" : {
        "coding" : [{
          "system" : "http://snomed.info/sct",
          "code" : "412946008",
          "display" : "Injectable solution"
        }],
        "text" : "Inj 3.75 mg prefilled dual chamber syringe"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "coding" : [{
            "system" : "http://nzmt.org.nz",
            "code" : "2268011000036106",
            "display" : "leuprorelin"
          }],
          "text" : "leuprorelin"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Lucrin-Depot-1-Month-Pricing",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-Lucrin-Depot-1-Month-Pricing",
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
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/statim",
        "valueString" : "n/a"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/in-combination",
        "valueString" : "n/a"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/contract-type",
        "valueString" : "n/a"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/dv-limit-percent",
        "valueDecimal" : 0
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/brand-switch-fee",
        "valueBoolean" : false
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Lucrin-Depot-1-Month-Pricing",
      "version" : "1.0",
      "title" : "Lucrin Depot 1-month - Pricing",
      "status" : "active",
      "publisher" : "Pharmac",
      "contact" : [{
        "name" : "Pharmac",
        "telecom" : [{
          "system" : "url",
          "value" : "https://www.pharmac.govt.nz/about/contact"
        }]
      }],
      "description" : "Listed price, PHARMAC subsidy, and patient co-payment for Lucrin Depot 1-month (Leuprorelin 3.75 inj, 1 inj)",
      "instance" : [{
        "reference" : "Medication/Medication-Lucrin-Depot-1-Month"
      }],
      "applicability" : [{
        "description" : "Community (subsidized) pricing applicable with valid prescription"
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
            "value" : 221.6,
            "currency" : "NZD"
          }
        },
        {
          "type" : "discount",
          "code" : {
            "text" : "PHARMAC Subsidy"
          },
          "amount" : {
            "value" : 66.48,
            "currency" : "NZD"
          }
        },
        {
          "type" : "surcharge",
          "code" : {
            "text" : "Patient Surcharge"
          },
          "amount" : {
            "value" : 155.12,
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
            "value" : 221.6,
            "currency" : "NZD"
          }
        },
        {
          "type" : "discount",
          "code" : {
            "text" : "Alternative Subsidy/Reimbursement"
          },
          "amount" : {
            "value" : 221.6,
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
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-Sequence-1",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-Community-Pharmacy-Sequence-1",
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
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-Sequence-1",
      "status" : "active",
      "publisher" : "Pharmac",
      "contact" : [{
        "name" : "Pharmac",
        "telecom" : [{
          "system" : "url",
          "value" : "https://www.pharmac.govt.nz/about/contact"
        }]
      }],
      "description" : "Case 1 community pharmacy prescription subsidy where the patient is unable to tolerate administration of goserelin.",
      "applicability" : [{
        "description" : "Condition (endorsement): Additional subsidy by endorsement where the patient is a child or adolescent and is unable to tolerate administration of goserelin and the prescription is endorsed accordingly.",
        "language" : "text/cql",
        "expression" : "exists(Condition where code in 'ChildOrAdolescent') and exists(Condition where code in 'UnableToTolerateGoserelin') and exists(Condition where code in 'PrescriptionEndorsedForAdditionalSubsidy')"
      },
      {
        "description" : "Condition (provider): Prescription must be from an authorised prescriber.",
        "language" : "text/cql",
        "expression" : "exists(Condition where code in 'AuthorisedPrescriber')"
      }],
      "propertyGroup" : [{
        "applicability" : [{
          "description" : "Case 1 - community pharmacy prescription (intolerance to goserelin)"
        }],
        "priceComponent" : [{
          "type" : "discount",
          "code" : {
            "text" : "PHARMAC Subsidy"
          },
          "amount" : {
            "value" : 221.6,
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
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-Sequence-2",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-Community-Pharmacy-Sequence-2",
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
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-Sequence-2",
      "status" : "active",
      "publisher" : "Pharmac",
      "contact" : [{
        "name" : "Pharmac",
        "telecom" : [{
          "system" : "url",
          "value" : "https://www.pharmac.govt.nz/about/contact"
        }]
      }],
      "description" : "Case 2 community pharmacy prescription subsidy.",
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
            "value" : 66.48,
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
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-BSO-Sequence-1",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-Community-Pharmacy-BSO-Sequence-1",
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
            "valueCode" : "BSO"
          }],
          "url" : "rule"
        }],
        "url" : "http://schedule.pharmac.govt.nz/fhir/StructureDefinition/funding-rule"
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-BSO-Sequence-1",
      "status" : "active",
      "publisher" : "Pharmac",
      "contact" : [{
        "name" : "Pharmac",
        "telecom" : [{
          "system" : "url",
          "value" : "https://www.pharmac.govt.nz/about/contact"
        }]
      }],
      "description" : "Case 1 community pharmacy BSO subsidy.",
      "applicability" : [{
        "description" : "Condition (provider): Prescription must be from a hospital care operator.",
        "language" : "text/cql",
        "expression" : "exists(Condition where code in 'HospitalCareOperator')"
      }],
      "propertyGroup" : [{
        "applicability" : [{
          "description" : "Case 1 - community pharmacy BSO"
        }],
        "priceComponent" : [{
          "type" : "discount",
          "code" : {
            "text" : "PHARMAC Subsidy"
          },
          "amount" : {
            "value" : 66.48,
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
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-Rural-PSO-Sequence-1",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-Community-Pharmacy-Rural-PSO-Sequence-1",
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
            "valueCode" : "RuralPSO"
          }],
          "url" : "rule"
        }],
        "url" : "http://schedule.pharmac.govt.nz/fhir/StructureDefinition/funding-rule"
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-Rural-PSO-Sequence-1",
      "status" : "active",
      "publisher" : "Pharmac",
      "contact" : [{
        "name" : "Pharmac",
        "telecom" : [{
          "system" : "url",
          "value" : "https://www.pharmac.govt.nz/about/contact"
        }]
      }],
      "description" : "Case 1 community pharmacy Rural PSO subsidy.",
      "applicability" : [{
        "description" : "Condition (provider): Prescription must be from an authorised prescriber.",
        "language" : "text/cql",
        "expression" : "exists(Condition where code in 'AuthorisedPrescriber')"
      }],
      "propertyGroup" : [{
        "applicability" : [{
          "description" : "Case 1 - community pharmacy Rural PSO"
        }],
        "priceComponent" : [{
          "type" : "discount",
          "code" : {
            "text" : "PHARMAC Subsidy"
          },
          "amount" : {
            "value" : 66.48,
            "currency" : "NZD"
          }
        }]
      }]
    },
    "search" : {
      "mode" : "include"
    }
  }]
}

```
