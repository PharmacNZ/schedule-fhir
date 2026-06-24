# ChargeItemDefinition-50270251000117100-Community-Case-1 - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinition-50270251000117100-Community-Case-1**

## Example ChargeItemDefinition: ChargeItemDefinition-50270251000117100-Community-Case-1

| |
| :--- |
| Active as of 2026-04-24 |



## Resource Content

```json
{
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
  "description" : "Rules for Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials. community Prescription.",
  "instance" : [{
    "reference" : "Medication/50270251000117100",
    "display" : "Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials"
  }],
  "applicability" : [{
    "description" : "Case 1 - Community - Prescription - Subsidy"
  }]
}

```
