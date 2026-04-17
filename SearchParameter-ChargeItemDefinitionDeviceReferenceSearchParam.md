# ChargeItemDefinitionDeviceReferenceSearchParam - Pharmac Schedules FHIR API v1.0.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinitionDeviceReferenceSearchParam**

## SearchParameter: ChargeItemDefinitionDeviceReferenceSearchParam 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/SearchParameter/chargeitemdefinition-device | *Version*:1.0.0 |
| Active as of 2026-04-17 | *Computable Name*:device-definition-reference |

 
Reference from ChargeItemDefinition to DeviceDefinition via IG extension. Enables searching for pricing and authorization rules by associated device. 



## Resource Content

```json
{
  "resourceType" : "SearchParameter",
  "id" : "ChargeItemDefinitionDeviceReferenceSearchParam",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/SearchParameter/chargeitemdefinition-device",
  "version" : "1.0.0",
  "name" : "device-definition-reference",
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
  "description" : "Reference from ChargeItemDefinition to DeviceDefinition via IG extension. Enables searching for pricing and authorization rules by associated device.",
  "code" : "device-definition-reference",
  "base" : ["ChargeItemDefinition"],
  "type" : "reference",
  "expression" : "ChargeItemDefinition.extension.where(url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/device-definition-reference').value",
  "target" : ["DeviceDefinition"]
}

```
