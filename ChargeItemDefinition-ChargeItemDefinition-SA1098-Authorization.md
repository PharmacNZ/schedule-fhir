# ChargeItemDefinition-SA1098-Authorization - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinition-SA1098-Authorization**

## Example ChargeItemDefinition: ChargeItemDefinition-SA1098-Authorization

| |
| :--- |
| Active as of 2026-04-24 |



## Resource Content

```json
{
  "resourceType" : "ChargeItemDefinition",
  "id" : "ChargeItemDefinition-SA1098-Authorization",
  "meta" : {
    "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority"]
  },
  "extension" : [{
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date",
    "valueDate" : "2026-03-11"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count",
    "valueInteger" : 1
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema",
    "valueBase64Binary" : "U3BlY2lhbCBBdXRob3JpdHkgQ29uZGl0aW9uIExvZ2ljIFRvIEJlIFByb3ZpZGVkIFNvb24="
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-form",
    "valueString" : "SA1098"
  }],
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-SA1098-Authorization",
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
  "description" : "Special Authority SA1098. Detailed eligibility criteria available via authorization form.",
  "code" : {
    "coding" : [{
      "system" : "http://pharmac.govt.nz/fhir/sa",
      "code" : "SA1098"
    }],
    "text" : "SA1098"
  },
  "instance" : [{
    "reference" : "Medication/50289761000117107",
    "display" : "Heparon Junior (2021 Formulation) oral liquid: powder for, 400 g, can"
  }]
}

```
