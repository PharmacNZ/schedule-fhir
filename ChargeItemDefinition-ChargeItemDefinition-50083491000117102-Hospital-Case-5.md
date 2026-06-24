# ChargeItemDefinition-50083491000117102-Hospital-Case-5 - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinition-50083491000117102-Hospital-Case-5**

## Example ChargeItemDefinition: ChargeItemDefinition-50083491000117102-Hospital-Case-5

| |
| :--- |
| Active as of 2026-04-24 |



## Resource Content

```json
{
  "resourceType" : "ChargeItemDefinition",
  "id" : "ChargeItemDefinition-50083491000117102-Hospital-Case-5",
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
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-50083491000117102-Hospital-Case-5",
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
  "description" : "Rules for Clexane 80 mg/0.8 mL injection: solution, 10 x 0.8 mL syringes. hospital n/a.",
  "instance" : [{
    "reference" : "Medication/50083491000117102",
    "display" : "Clexane 80 mg/0.8 mL injection: solution, 10 x 0.8 mL syringes"
  }],
  "applicability" : [{
    "description" : "Case 5 - Hospital - n/a - None"
  }]
}

```
