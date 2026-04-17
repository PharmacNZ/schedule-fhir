# ChargeItemDefinitionCodeSearchParam - Pharmac Schedules FHIR API v1.0.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinitionCodeSearchParam**

## SearchParameter: ChargeItemDefinitionCodeSearchParam 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/SearchParameter/chargeitemdefinition-code | *Version*:1.0.0 |
| Active as of 2026-04-17 | *Computable Name*:ChargeItemDefinitionCode |

 
Allow ChargeItemDefinition search by code (usually special authority code) 



## Resource Content

```json
{
  "resourceType" : "SearchParameter",
  "id" : "ChargeItemDefinitionCodeSearchParam",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/SearchParameter/chargeitemdefinition-code",
  "version" : "1.0.0",
  "name" : "ChargeItemDefinitionCode",
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
  "description" : "Allow ChargeItemDefinition search by code (usually special authority code)",
  "code" : "code",
  "base" : ["ChargeItemDefinition"],
  "type" : "token",
  "expression" : "ChargeItemDefinition.code",
  "xpathUsage" : "normal"
}

```
