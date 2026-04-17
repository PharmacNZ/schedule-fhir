# ChargeItemDefinitionInstanceSearchParam - Pharmac Schedules FHIR API v1.0.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinitionInstanceSearchParam**

## SearchParameter: ChargeItemDefinitionInstanceSearchParam 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/SearchParameter/chargeitemdefinition-instance | *Version*:1.0.0 |
| Active as of 2026-04-17 | *Computable Name*:ChargeItemDefinitionInstance |

 
Allow _revinclude from Medication to ChargeItemDefinition 



## Resource Content

```json
{
  "resourceType" : "SearchParameter",
  "id" : "ChargeItemDefinitionInstanceSearchParam",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/SearchParameter/chargeitemdefinition-instance",
  "version" : "1.0.0",
  "name" : "ChargeItemDefinitionInstance",
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
  "description" : "Allow _revinclude from Medication to ChargeItemDefinition",
  "code" : "instance",
  "base" : ["ChargeItemDefinition"],
  "type" : "reference",
  "expression" : "ChargeItemDefinition.instance",
  "xpathUsage" : "normal"
}

```
