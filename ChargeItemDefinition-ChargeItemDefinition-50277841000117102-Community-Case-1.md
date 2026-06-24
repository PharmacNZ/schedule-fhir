# ChargeItemDefinition-50277841000117102-Community-Case-1 - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinition-50277841000117102-Community-Case-1**

## Example ChargeItemDefinition: ChargeItemDefinition-50277841000117102-Community-Case-1

| |
| :--- |
| Active as of 2026-04-24 |



## Resource Content

```json
{
  "resourceType" : "ChargeItemDefinition",
  "id" : "ChargeItemDefinition-50277841000117102-Community-Case-1",
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
        "value" : 219,
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
      "valueString" : "Must"
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
      "valueBoolean" : true
    },
    {
      "url" : "safetyListMedicine",
      "valueBoolean" : false
    }],
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/schedule-funding-attributes"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema",
    "valueBase64Binary" : "ewogICIkc2NoZW1hIjogImh0dHA6Ly9qc29uLXNjaGVtYS5vcmcvZHJhZnQtMDcvc2NoZW1hIyIsCiAgInRpdGxlIjogIkNvbmRpdGlvbnMtNTAyNzc4NDEwMDAxMTcxMDItQ2FzZS0xIiwKICAidHlwZSI6ICJvYmplY3QiLAogICJwcm9wZXJ0aWVzIjogewogICAgImF1dGhvcml0eSI6IHsKICAgICAgInRpdGxlIjogIlNwZWNpYWwgQXV0aG9yaXR5IiwKICAgICAgInR5cGUiOiAiaW50ZWdlciIsCiAgICAgICJkZXNjcmlwdGlvbiI6ICJodHRwczovL3NjaGVkdWxlLnBoYXJtYWMuZ292dC5uei9sYXRlc3QvU0EyNTM2LnBkZiIsCiAgICAgICJjb25zdCI6IDI1MzYKICAgIH0sCiAgICAicHJvdmlkZXIiOiB7CiAgICAgICJ0aXRsZSI6ICJQcm92aWRlciBJbmZvcm1hdGlvbiIsCiAgICAgICJ0eXBlIjogImJvb2xlYW4iLAogICAgICAiZGVzY3JpcHRpb24iOiAiQXV0aG9yaXNlZCBwcmVzY3JpYmVyIgogICAgfSwKICAgICJub3RlIjogewogICAgICAidGl0bGUiOiAiTm90ZSIsCiAgICAgICJ0eXBlIjogImJvb2xlYW4iLAogICAgICAiZGVzY3JpcHRpb24iOiAiU3BlY2lhbCBBdXRob3JpdHkgcmVxdWlyZWQgZm9yIHN1YnNpZHkiCiAgICB9CiAgfSwKICAicmVxdWlyZWQiOiBbCiAgICAiYXV0aG9yaXR5IiwKICAgICJwcm92aWRlciIsCiAgICAibm90ZSIKICBdCn0K"
  }],
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50277841000117102-Community-Case-1",
  "version" : "1.1.0",
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
  "description" : "Rules for MiniMed Sure-T MMT-864A insulin pump infusion set (6 mm x 29 gauge steel needle x 10, 60 cm line x 10), 1 pack, composite pack. community Prescription.",
  "instance" : [{
    "reference" : "Medication/50277841000117102",
    "display" : "MiniMed Sure-T MMT-864A insulin pump infusion set (6 mm x 29 gauge steel needle x 10, 60 cm line x 10), 1 pack, composite pack"
  }],
  "applicability" : [{
    "description" : "Case 1 - Community - Prescription - Subsidy"
  }]
}

```
