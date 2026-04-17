# Clexane - Pricing - Pharmac Schedules FHIR API v1.0.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Clexane - Pricing**

## Example ChargeItemDefinition: Clexane - Pricing

| |
| :--- |
| Active as of 2026-04-17 |



## Resource Content

```json
{
  "resourceType" : "ChargeItemDefinition",
  "id" : "ChargeItemDefinition-Clexane-Pricing",
  "meta" : {
    "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-pricing"]
  },
  "extension" : [{
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date",
    "valueDate" : "2026-05-01"
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
    "valueString" : "n/a"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/in-combination",
    "valueString" : "n/a"
  }],
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Clexane-Pricing",
  "version" : "1.0.0",
  "title" : "Clexane - Pricing",
  "status" : "active",
  "date" : "2026-04-17T06:29:04+00:00",
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
  "description" : "Listed price, PHARMAC subsidy, and patient co-payment for Clexane (Inj 100 mg in 1 ml syringe, pack of 10).",
  "instance" : [{
    "reference" : "Medication/Medication-Clexane-100mg-1ml-Syringe"
  }],
  "propertyGroup" : [{
    "applicability" : [{
      "description" : "Community pricing - fully subsidized where endorsed, including PRIME PSO use, or waived by Special Authority SA2628"
    }],
    "priceComponent" : [{
      "type" : "base",
      "code" : {
        "text" : "Listed Price"
      },
      "amount" : {
        "value" : 70.91,
        "currency" : "NZD"
      }
    },
    {
      "type" : "discount",
      "code" : {
        "text" : "PHARMAC Subsidy"
      },
      "amount" : {
        "value" : 70.91,
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
        "text" : "Patient Co-Payment"
      },
      "amount" : {
        "value" : 0,
        "currency" : "NZD"
      }
    }]
  },
  {
    "applicability" : [{
      "description" : "HML pricing - PSS with 5% DV limit"
    }],
    "priceComponent" : [{
      "type" : "base",
      "code" : {
        "text" : "Listed Price"
      },
      "amount" : {
        "value" : 70.91,
        "currency" : "NZD"
      }
    },
    {
      "type" : "discount",
      "code" : {
        "text" : "PHARMAC Subsidy"
      },
      "amount" : {
        "value" : 70.91,
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
    }]
  }]
}

```
