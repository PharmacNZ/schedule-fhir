# SearchSet-Bundle-Famotidine-Endorsement-And-Note - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **SearchSet-Bundle-Famotidine-Endorsement-And-Note**

## Example Bundle: SearchSet-Bundle-Famotidine-Endorsement-And-Note



## Resource Content

```json
{
  "resourceType" : "Bundle",
  "id" : "SearchSet-Bundle-Famotidine-Endorsement-And-Note",
  "type" : "searchset",
  "total" : 1,
  "link" : [{
    "relation" : "self",
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/Medication?code=50270251000117100&_revinclude=ChargeItemDefinition:instance"
  }],
  "entry" : [{
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/Medication/50270251000117100",
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50270251000117100",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50270251000117100",
              "display" : "Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials"
            }],
            "text" : "Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "A02BA03",
            "display" : "famotidine"
          }],
          "text" : "famotidine"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 10,
            "unit" : "vial"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 57.02,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50270251000117100",
          "display" : "Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2602776"
        }],
        "text" : "Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials"
      },
      "status" : "active",
      "form" : {
        "text" : "Inj 10 mg per ml, 4 ml"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Famotidine"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50270251000117100-Community-Case-1",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-50270251000117100-Community-Case-1",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date",
        "valueDate" : "2026-04-24"
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
        "extension" : [{
          "url" : "subsidyType",
          "valueCode" : "subsidy"
        },
        {
          "url" : "subsidyStatus",
          "valueCode" : "full"
        },
        {
          "url" : "amount",
          "valueMoney" : {
            "value" : 57.02,
            "currency" : "NZD"
          }
        },
        {
          "url" : "display",
          "valueString" : "Subsidy"
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/funding-subsidy-amount"
      },
      {
        "extension" : [{
          "url" : "costBrandSource",
          "valueBoolean" : true
        },
        {
          "url" : "wastageClaimable",
          "valueBoolean" : true
        },
        {
          "url" : "contractType",
          "valueString" : "n/a"
        },
        {
          "url" : "dvLimitPercent",
          "valueDecimal" : 0
        },
        {
          "url" : "brandSwitchFee",
          "valueBoolean" : false
        },
        {
          "url" : "statim",
          "valueString" : "Must"
        },
        {
          "url" : "inCombination",
          "valueCode" : "no"
        },
        {
          "url" : "section29",
          "valueBoolean" : true
        },
        {
          "url" : "coPaymentMin",
          "valueCode" : "na"
        },
        {
          "url" : "coPaymentMax",
          "valueCode" : "no"
        },
        {
          "url" : "productMultiple",
          "valueBoolean" : true
        },
        {
          "url" : "productMultiplier",
          "valueInteger" : 1
        },
        {
          "url" : "originalPack",
          "valueBoolean" : false
        },
        {
          "url" : "safetyListMedicine",
          "valueBoolean" : false
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/schedule-funding-attributes"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema",
        "valueBase64Binary" : "ewogICIkc2NoZW1hIjogImh0dHA6Ly9qc29uLXNjaGVtYS5vcmcvZHJhZnQtMDcvc2NoZW1hIyIsCiAgInRpdGxlIjogIkNvbmRpdGlvbnMtNTAyNzAyNTEwMDAxMTcxMDAtQ2FzZS0xIiwKICAidHlwZSI6ICJvYmplY3QiLAogICJwcm9wZXJ0aWVzIjogewogICAgInByb3ZpZGVyIjogewogICAgICAidGl0bGUiOiAiUHJvdmlkZXIgSW5mb3JtYXRpb24iLAogICAgICAidHlwZSI6ICJib29sZWFuIiwKICAgICAgImRlc2NyaXB0aW9uIjogIkF1dGhvcmlzZWQgcHJlc2NyaWJlciIKICAgIH0sCiAgICAiZW5kb3JzZW1lbnQiOiB7CiAgICAgICJ0aXRsZSI6ICJTdWJzaWR5IGJ5IGVuZG9yc2VtZW50IiwKICAgICAgInR5cGUiOiAiYm9vbGVhbiIsCiAgICAgICJkZXNjcmlwdGlvbiI6ICJTdWJzaWR5IGJ5IGVuZG9yc2VtZW50LiBTdWJzaWRpc2VkIGZvciBwYXRpZW50cyByZWNlaXZpbmcgdHJlYXRtZW50IGFzIHBhcnQgb2YgcGFsbGlhdGl2ZSBjYXJlLiIKICAgIH0KICB9LAogICJyZXF1aXJlZCI6IFsKICAgICJwcm92aWRlciIsCiAgICAiZW5kb3JzZW1lbnQiCiAgXQp9Cg=="
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50270251000117100-Community-Case-1",
      "version" : "1.0.1",
      "status" : "active",
      "date" : "2026-04-24T00:58:18+00:00",
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
      "description" : "Rules for Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials. community Prescription.",
      "instance" : [{
        "reference" : "Medication/50270251000117100",
        "display" : "Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials"
      }],
      "applicability" : [{
        "description" : "Case 1 - Community - Prescription - Subsidy"
      }]
    },
    "search" : {
      "mode" : "include"
    }
  },
  {
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50270251000117100-Hospital-Case-5",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-50270251000117100-Hospital-Case-5",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date",
        "valueDate" : "2026-04-24"
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCode" : "hospital"
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
            "valueCode" : "na"
          }],
          "url" : "rule"
        }],
        "url" : "http://schedule.pharmac.govt.nz/fhir/StructureDefinition/funding-rule"
      },
      {
        "extension" : [{
          "url" : "subsidyType",
          "valueCode" : "none"
        },
        {
          "url" : "subsidyStatus",
          "valueCode" : "none"
        },
        {
          "url" : "amount",
          "valueMoney" : {
            "value" : 0,
            "currency" : "NZD"
          }
        },
        {
          "url" : "display",
          "valueString" : "None"
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/funding-subsidy-amount"
      },
      {
        "extension" : [{
          "url" : "costBrandSource",
          "valueBoolean" : true
        },
        {
          "url" : "wastageClaimable",
          "valueBoolean" : true
        },
        {
          "url" : "contractType",
          "valueString" : "n/a"
        },
        {
          "url" : "dvLimitPercent",
          "valueDecimal" : 0
        },
        {
          "url" : "brandSwitchFee",
          "valueBoolean" : false
        },
        {
          "url" : "statim",
          "valueString" : "Must"
        },
        {
          "url" : "inCombination",
          "valueCode" : "no"
        },
        {
          "url" : "section29",
          "valueBoolean" : true
        },
        {
          "url" : "coPaymentMin",
          "valueCode" : "na"
        },
        {
          "url" : "coPaymentMax",
          "valueCode" : "no"
        },
        {
          "url" : "productMultiple",
          "valueBoolean" : true
        },
        {
          "url" : "productMultiplier",
          "valueInteger" : 1
        },
        {
          "url" : "originalPack",
          "valueBoolean" : false
        },
        {
          "url" : "safetyListMedicine",
          "valueBoolean" : false
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/schedule-funding-attributes"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema",
        "valueBase64Binary" : "e30K"
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50270251000117100-Hospital-Case-5",
      "version" : "1.0.1",
      "status" : "active",
      "date" : "2026-04-24T00:58:18+00:00",
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
      "description" : "Rules for Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials. hospital n/a.",
      "instance" : [{
        "reference" : "Medication/50270251000117100",
        "display" : "Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials"
      }],
      "applicability" : [{
        "description" : "Case 5 - Hospital - n/a - None"
      }]
    },
    "search" : {
      "mode" : "include"
    }
  }]
}

```
