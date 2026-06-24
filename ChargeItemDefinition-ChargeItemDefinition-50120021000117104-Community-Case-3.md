# ChargeItemDefinition-50120021000117104-Community-Case-3 - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinition-50120021000117104-Community-Case-3**

## Example ChargeItemDefinition: ChargeItemDefinition-50120021000117104-Community-Case-3

| |
| :--- |
| Active as of 2026-04-24 |



## Resource Content

```json
{
  "resourceType" : "ChargeItemDefinition",
  "id" : "ChargeItemDefinition-50120021000117104-Community-Case-3",
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
        "value" : 412,
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
    "valueBase64Binary" : "ewogICIkc2NoZW1hIjogImh0dHA6Ly9qc29uLXNjaGVtYS5vcmcvZHJhZnQtMDcvc2NoZW1hIyIsCiAgInRpdGxlIjogIkNvbmRpdGlvbnMtNTAxMjAwMjEwMDAxMTcxMDQtQ2FzZS0zIiwKICAidHlwZSI6ICJvYmplY3QiLAogICJwcm9wZXJ0aWVzIjogewogICAgInByb3ZpZGVyIjogewogICAgICAidGl0bGUiOiAiUHJvdmlkZXIgSW5mb3JtYXRpb24iLAogICAgICAidHlwZSI6ICJib29sZWFuIiwKICAgICAgImRlc2NyaXB0aW9uIjogIkF1dGhvcmlzZWQgcHJlc2NyaWJlciIKICAgIH0sCiAgICAic3BlY2lhbGlzdCI6IHsKICAgICAgInRpdGxlIjogIlNwZWNpYWxpc3QiLAogICAgICAidHlwZSI6ICJib29sZWFuIiwKICAgICAgImRlc2NyaXB0aW9uIjogIlNwZWNpYWxpc3QgcmVjb21tZW5kYXRpb24iCiAgICB9CiAgfSwKICAic3BlY2lhbGlzdCI6IFsKICAgICJwcm92aWRlciIsCiAgICAic3BlY2lhbGlzdCIKICBdCn0K"
  }],
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50120021000117104-Community-Case-3",
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
  "description" : "Rules for Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack. community Rural PSO.",
  "instance" : [{
    "reference" : "Medication/50120021000117104",
    "display" : "Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack"
  }],
  "applicability" : [{
    "description" : "Case 3 - Community - Rural PSO - Subsidy"
  }]
}

```
