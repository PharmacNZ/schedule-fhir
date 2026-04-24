# ChargeItemDefinitionPricingEffectiveDateSearchParam - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinitionPricingEffectiveDateSearchParam**

## SearchParameter: ChargeItemDefinitionPricingEffectiveDateSearchParam 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/SearchParameter/chargeitemdefinition-pricing-effective-date | *Version*:1.0.1 |
| Active as of 2026-04-24 | *Computable Name*:PricingEffectiveDate |

 
Search ChargeItemDefinition by pricing effective date extension 



## Resource Content

```json
{
  "resourceType" : "SearchParameter",
  "id" : "ChargeItemDefinitionPricingEffectiveDateSearchParam",
  "url" : "https://fhir-ig.digital.health.nz/SearchParameter/chargeitemdefinition-pricing-effective-date",
  "version" : "1.0.1",
  "name" : "PricingEffectiveDate",
  "status" : "active",
  "date" : "2026-04-24T01:18:12+00:00",
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
  "description" : "Search ChargeItemDefinition by pricing effective date extension",
  "code" : "pricing-effective-date",
  "base" : ["ChargeItemDefinition"],
  "type" : "date",
  "expression" : "ChargeItemDefinition.extension.where(url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date').value"
}

```
