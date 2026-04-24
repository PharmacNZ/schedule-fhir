# ChargeItemDefinitionSACodeSearchParam - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinitionSACodeSearchParam**

## SearchParameter: ChargeItemDefinitionSACodeSearchParam 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/SearchParameter/chargeitemdefinition-special-authority-code | *Version*:1.0.1 |
| Active as of 2026-04-24 | *Computable Name*:ChargeItemDefinitionSACode |

 
Allow ChargeItemDefinition search by code eg special authority code 



## Resource Content

```json
{
  "resourceType" : "SearchParameter",
  "id" : "ChargeItemDefinitionSACodeSearchParam",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/SearchParameter/chargeitemdefinition-special-authority-code",
  "version" : "1.0.1",
  "name" : "ChargeItemDefinitionSACode",
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
  "description" : "Allow ChargeItemDefinition search by code eg special authority code",
  "code" : "cid-code",
  "base" : ["ChargeItemDefinition"],
  "type" : "token",
  "expression" : "ChargeItemDefinition.code.coding",
  "xpathUsage" : "normal"
}

```
