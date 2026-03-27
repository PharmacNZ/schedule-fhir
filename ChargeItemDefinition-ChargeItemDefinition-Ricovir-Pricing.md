# Ricovir - Pricing - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Ricovir - Pricing**

## Example ChargeItemDefinition: Ricovir - Pricing

| |
| :--- |
| Active as of 2026-03-27 |



## Resource Content

```json
{
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
  "version" : "0.0.1",
  "title" : "Ricovir - Pricing",
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
}

```
