# SearchSet-Bundle-Nitisinone-Hospital-Restriction - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **SearchSet-Bundle-Nitisinone-Hospital-Restriction**

## Example Bundle: SearchSet-Bundle-Nitisinone-Hospital-Restriction



## Resource Content

```json
{
  "resourceType" : "Bundle",
  "id" : "SearchSet-Bundle-Nitisinone-Hospital-Restriction",
  "type" : "searchset",
  "total" : 1,
  "link" : [{
    "relation" : "self",
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/Medication?code=50324571000117108&_revinclude=ChargeItemDefinition:instance"
  }],
  "entry" : [{
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/Medication/50324571000117108",
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50324571000117108",
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
              "code" : "50324571000117108",
              "display" : "Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle"
            }],
            "text" : "Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "A16AX04",
            "display" : "nitisinone"
          }],
          "text" : "nitisinone"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 60,
            "unit" : "capsule"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 676,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50324571000117108",
          "display" : "Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2677687"
        }],
        "text" : "Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle"
      },
      "status" : "active",
      "form" : {
        "text" : "Cap 2 mg"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Nitisinone"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50324571000117108-Community-Case-1",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-50324571000117108-Community-Case-1",
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
            "value" : 676,
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
          "valueBoolean" : false
        },
        {
          "url" : "wastageClaimable",
          "valueBoolean" : false
        },
        {
          "url" : "contractType",
          "valueString" : "PSS"
        },
        {
          "url" : "dvLimitPercent",
          "valueDecimal" : 5
        },
        {
          "url" : "brandSwitchFee",
          "valueBoolean" : false
        },
        {
          "url" : "statim",
          "valueString" : "n/a"
        },
        {
          "url" : "inCombination",
          "valueCode" : "no"
        },
        {
          "url" : "section29",
          "valueBoolean" : false
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
          "valueBoolean" : false
        },
        {
          "url" : "productMultiplier",
          "valueInteger" : 0
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
        "valueBase64Binary" : "ewogICIkc2NoZW1hIjogImh0dHA6Ly9qc29uLXNjaGVtYS5vcmcvZHJhZnQtMDcvc2NoZW1hIyIsCiAgInRpdGxlIjogIkNvbmRpdGlvbnMtNTAzMjQ1NzEwMDAxMTcxMDgtQ2FzZS0xIiwKICAidHlwZSI6ICJvYmplY3QiLAogICJwcm9wZXJ0aWVzIjogewogICAgImF1dGhvcml0eSI6IHsKICAgICAgInRpdGxlIjogIlNwZWNpYWwgQXV0aG9yaXR5IiwKICAgICAgInR5cGUiOiAiaW50ZWdlciIsCiAgICAgICJkZXNjcmlwdGlvbiI6ICJodHRwczovL3NjaGVkdWxlLnBoYXJtYWMuZ292dC5uei9sYXRlc3QvU0EyNTYxLnBkZiIsCiAgICAgICJjb25zdCI6IDI1NjEKICAgIH0sCiAgICAicHJvdmlkZXIiOiB7CiAgICAgICJ0aXRsZSI6ICJQcm92aWRlciBJbmZvcm1hdGlvbiIsCiAgICAgICJ0eXBlIjogImJvb2xlYW4iLAogICAgICAiZGVzY3JpcHRpb24iOiAiQXV0aG9yaXNlZCBwcmVzY3JpYmVyIgogICAgfSwKICAgICJub3RlIjogewogICAgICAidGl0bGUiOiAiTm90ZSIsCiAgICAgICJ0eXBlIjogImJvb2xlYW4iLAogICAgICAiZGVzY3JpcHRpb24iOiAiU3BlY2lhbCBBdXRob3JpdHkgcmVxdWlyZWQgZm9yIHN1YnNpZHkiCiAgICB9CiAgfSwKICAicmVxdWlyZWQiOiBbCiAgICAiYXV0aG9yaXR5IiwKICAgICJwcm92aWRlciIsCiAgICAibm90ZSIKICBdCn0K"
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50324571000117108-Community-Case-1",
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
      "description" : "Rules for Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle. community Prescription.",
      "instance" : [{
        "reference" : "Medication/50324571000117108",
        "display" : "Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle"
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
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50324571000117108-Hospital-Case-5",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-50324571000117108-Hospital-Case-5",
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
          "valueBoolean" : false
        },
        {
          "url" : "wastageClaimable",
          "valueBoolean" : false
        },
        {
          "url" : "contractType",
          "valueString" : "PSS"
        },
        {
          "url" : "dvLimitPercent",
          "valueDecimal" : 5
        },
        {
          "url" : "brandSwitchFee",
          "valueBoolean" : false
        },
        {
          "url" : "statim",
          "valueString" : "n/a"
        },
        {
          "url" : "inCombination",
          "valueCode" : "no"
        },
        {
          "url" : "section29",
          "valueBoolean" : false
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
          "valueBoolean" : false
        },
        {
          "url" : "productMultiplier",
          "valueInteger" : 0
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
        "valueBase64Binary" : "ewogICIkc2NoZW1hIjogImh0dHA6Ly9qc29uLXNjaGVtYS5vcmcvZHJhZnQtMDcvc2NoZW1hIyIsCiAgInRpdGxlIjogIkNvbmRpdGlvbnMtNTAzMjQ1NzEwMDAxMTcxMDgtQ2FzZS01IiwKICAidHlwZSI6ICJvYmplY3QiLAogICJwcm9wZXJ0aWVzIjogewogICAgInJlc3RyaWN0aW9uIjogewogICAgICAidGl0bGUiOiAiUmVzdHJpY3Rpb24iLAogICAgICAidHlwZSI6ICJpbnRlZ2VyIiwKICAgICAgImRlc2NyaXB0aW9uIjogImh0dHBzOi8vc2NoZWR1bGUucGhhcm1hYy5nb3Z0Lm56L2xhdGVzdC9SUzIxNjQucGRmIiwKICAgIH0sCiAgICAibm90ZSI6IHsKICAgICAgInRpdGxlIjogIk5vdGUiLAogICAgICAidHlwZSI6ICJib29sZWFuIiwKICAgICAgImRlc2NyaXB0aW9uIjogIkhvc3BpdGFsIGluZGljYXRpb24gcmVzdHJpY3Rpb24iCiAgICB9ICAgIAogIH0sCiAgInJlcXVpcmVkIjogWwogICAgInJlc3RyaWN0aW9uIiwKICAgICJub3RlIgogIF0KfQo="
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50324571000117108-Hospital-Case-5",
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
      "description" : "Rules for Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle. hospital n/a.",
      "instance" : [{
        "reference" : "Medication/50324571000117108",
        "display" : "Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle"
      }],
      "applicability" : [{
        "description" : "Case 5 - Hospital - n/a - None"
      }]
    },
    "search" : {
      "mode" : "include"
    }
  },
  {
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-SA2561-Authorization",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-SA2561-Authorization",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date",
        "valueDate" : "2026-03-11"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count",
        "valueInteger" : 1
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema",
        "valueBase64Binary" : "U3BlY2lhbCBBdXRob3JpdHkgQ29uZGl0aW9uIExvZ2ljIFRvIEJlIFByb3ZpZGVkIFNvb24="
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-form",
        "valueString" : "SA2561"
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-SA2561-Authorization",
      "version" : "1",
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
      "description" : "Special Authority SA2561. Detailed eligibility criteria available via authorization form.",
      "code" : {
        "coding" : [{
          "system" : "http://pharmac.govt.nz/fhir/sa",
          "code" : "SA2561"
        }],
        "text" : "SA2561"
      },
      "instance" : [{
        "reference" : "Medication/50324571000117108",
        "display" : "Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle"
      }]
    },
    "search" : {
      "mode" : "include"
    }
  }]
}

```
