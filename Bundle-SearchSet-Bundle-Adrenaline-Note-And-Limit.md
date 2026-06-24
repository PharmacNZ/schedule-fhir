# SearchSet-Bundle-Adrenaline-Note-And-Limit - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **SearchSet-Bundle-Adrenaline-Note-And-Limit**

## Example Bundle: SearchSet-Bundle-Adrenaline-Note-And-Limit



## Resource Content

```json
{
  "resourceType" : "Bundle",
  "id" : "SearchSet-Bundle-Adrenaline-Note-And-Limit",
  "type" : "searchset",
  "total" : 1,
  "link" : [{
    "relation" : "self",
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/Medication?code=50046931000117109&_revinclude=ChargeItemDefinition:instance"
  }],
  "entry" : [{
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/Medication/50046931000117109",
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50046931000117109",
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
              "code" : "50046931000117109",
              "display" : "Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules"
            }],
            "text" : "Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "C01CA24",
            "display" : "epinephrine"
          }],
          "text" : "epinephrine"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 5,
            "unit" : "ampoule"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 4.98,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50046931000117109",
          "display" : "Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "9331134001405"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2309823"
        }],
        "text" : "Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules"
      },
      "status" : "active",
      "form" : {
        "text" : "Inj 1 in 1,000, 1 ml ampoule"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Adrenaline"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-1",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-50046931000117109-Community-Case-1",
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
            "value" : 4.98,
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
        "valueBase64Binary" : "ewogICIkc2NoZW1hIjogImh0dHA6Ly9qc29uLXNjaGVtYS5vcmcvZHJhZnQtMDcvc2NoZW1hIyIsCiAgInRpdGxlIjogIkNvbmRpdGlvbnMtNTAwNDY5MzEwMDAxMTcxMDktQ2FzZS0xIiwKICAidHlwZSI6ICJvYmplY3QiLAogICJwcm9wZXJ0aWVzIjogewogICAgInByb3ZpZGVyIjogewogICAgICAidGl0bGUiOiAiUHJvdmlkZXIgSW5mb3JtYXRpb24iLAogICAgICAidHlwZSI6ICJib29sZWFuIiwKICAgICAgImRlc2NyaXB0aW9uIjogIkF1dGhvcmlzZWQgcHJlc2NyaWJlciwgcGhhcm1hY2lzdCIKICAgIH0KICB9LAogICJyZXF1aXJlZCI6IFsKICAgICJwcm92aWRlciIKICBdCn0K"
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-1",
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
      "description" : "Rules for Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. community Prescription.",
      "instance" : [{
        "reference" : "Medication/50046931000117109",
        "display" : "Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules"
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
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-2",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-50046931000117109-Community-Case-2",
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
            "valueCode" : "BSO"
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
            "value" : 4.98,
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
        "valueBase64Binary" : "ewogICIkc2NoZW1hIjogImh0dHA6Ly9qc29uLXNjaGVtYS5vcmcvZHJhZnQtMDcvc2NoZW1hIyIsCiAgInRpdGxlIjogIkNvbmRpdGlvbnMtNTAwNDY5MzEwMDAxMTcxMDktQ2FzZS0yIiwKICAidHlwZSI6ICJvYmplY3QiLAogICJwcm9wZXJ0aWVzIjogewogICAgInByb3ZpZGVyIjogewogICAgICAidGl0bGUiOiAiUHJvdmlkZXIgSW5mb3JtYXRpb24iLAogICAgICAidHlwZSI6ICJib29sZWFuIiwKICAgICAgImRlc2NyaXB0aW9uIjogIlZhY2NpbmF0b3IsIEhvc3BpdGFsIGNhcmUgb3BlcmF0b3IiCiAgICB9CiAgfSwKICAicmVxdWlyZWQiOiBbCiAgICAicHJvdmlkZXIiCiAgXQp9Cg=="
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-2",
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
      "description" : "Rules for Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. community BSO.",
      "instance" : [{
        "reference" : "Medication/50046931000117109",
        "display" : "Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules"
      }],
      "applicability" : [{
        "description" : "Case 2 - Community - BSO - Subsidy"
      }]
    },
    "search" : {
      "mode" : "include"
    }
  },
  {
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-3",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-50046931000117109-Community-Case-3",
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
            "valueCode" : "RuralPSO"
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
            "value" : 4.98,
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
        "valueBase64Binary" : "ewogICIkc2NoZW1hIjogImh0dHA6Ly9qc29uLXNjaGVtYS5vcmcvZHJhZnQtMDcvc2NoZW1hIyIsCiAgInRpdGxlIjogIkNvbmRpdGlvbnMtNTAwNDY5MzEwMDAxMTcxMDktQ2FzZS0zIiwKICAidHlwZSI6ICJvYmplY3QiLAogICJwcm9wZXJ0aWVzIjogewogICAgInByb3ZpZGVyIjogewogICAgICAidGl0bGUiOiAiUHJvdmlkZXIgSW5mb3JtYXRpb24iLAogICAgICAidHlwZSI6ICJib29sZWFuIiwKICAgICAgImRlc2NyaXB0aW9uIjogIkF1dGhvcmlzZWQgcHJlc2NyaWJlciIKICAgIH0KICB9LAogICJyZXF1aXJlZCI6IFsKICAgICJwcm92aWRlciIKICBdCn0K"
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-3",
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
      "description" : "Rules for Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. community Rural PSO.",
      "instance" : [{
        "reference" : "Medication/50046931000117109",
        "display" : "Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules"
      }],
      "applicability" : [{
        "description" : "Case 3 - Community - Rural PSO - Subsidy"
      }]
    },
    "search" : {
      "mode" : "include"
    }
  },
  {
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-4",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-50046931000117109-Community-Case-4",
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
            "valueCode" : "PSO"
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
            "value" : 4.98,
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
        "valueBase64Binary" : "ewogICIkc2NoZW1hIjogImh0dHA6Ly9qc29uLXNjaGVtYS5vcmcvZHJhZnQtMDcvc2NoZW1hIyIsCiAgInRpdGxlIjogIkNvbmRpdGlvbnMtNTAwNDY5MzEwMDAxMTcxMDktQ2FzZS00IiwKICAidHlwZSI6ICJvYmplY3QiLAogICJwcm9wZXJ0aWVzIjogewogICAgImxpbWl0IjogewogICAgICAidGl0bGUiOiAiRm9ybU1heCIsCiAgICAgICJ0eXBlIjogIm51bWJlciIsCiAgICAgICJkZXNjcmlwdGlvbiI6ICJNYXhpbXVtIG51bWJlciBvZiB1bml0cyBwZXIgUFNPIiwKICAgICAgImNvbnN0IjogNSwKICAgICAgIiR1bml0IjogImFtcG91bGUiCiAgICB9LAogICAgInByb3ZpZGVyIjogewogICAgICAidGl0bGUiOiAiUHJvdmlkZXIgSW5mb3JtYXRpb24iLAogICAgICAidHlwZSI6ICJib29sZWFuIiwKICAgICAgImRlc2NyaXB0aW9uIjogIkF1dGhvcmlzZWQgcHJlc2NyaWJlciIKICAgIH0KICB9LAogICJyZXF1aXJlZCI6IFsKICAgICJsaW1pdCIsCiAgICAicHJvdmlkZXIiCiAgXQp9Cg=="
      }],
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-4",
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
      "description" : "Rules for Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. community PSO.",
      "instance" : [{
        "reference" : "Medication/50046931000117109",
        "display" : "Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules"
      }],
      "applicability" : [{
        "description" : "Case 4 - Community - PSO - Subsidy"
      }]
    },
    "search" : {
      "mode" : "include"
    }
  },
  {
    "fullUrl" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Hospital-Case-5",
    "resource" : {
      "resourceType" : "ChargeItemDefinition",
      "id" : "ChargeItemDefinition-50046931000117109-Hospital-Case-5",
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
      "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Hospital-Case-5",
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
      "description" : "Rules for Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. hospital n/a.",
      "instance" : [{
        "reference" : "Medication/50046931000117109",
        "display" : "Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules"
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
