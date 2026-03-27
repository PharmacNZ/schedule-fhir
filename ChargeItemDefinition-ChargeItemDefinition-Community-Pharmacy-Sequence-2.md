# ChargeItemDefinition-Community-Pharmacy-Sequence-2 - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinition-Community-Pharmacy-Sequence-2**

## Example ChargeItemDefinition: ChargeItemDefinition-Community-Pharmacy-Sequence-2

| |
| :--- |
| Active as of 2026-03-27 |



## Resource Content

```json
{
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
  "version" : "0.0.1",
  "status" : "active",
  "date" : "2026-03-27T00:29:47+00:00",
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
}

```
