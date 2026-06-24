# ChargeItemDefinition-SA2139-Authorization - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinition-SA2139-Authorization**

## Example ChargeItemDefinition: ChargeItemDefinition-SA2139-Authorization

| |
| :--- |
| Active as of 2026-04-24 |



## Resource Content

```json
{
  "resourceType" : "ChargeItemDefinition",
  "id" : "ChargeItemDefinition-SA2139-Authorization",
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
    "valueString" : "SA2139"
  }],
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-SA2139-Authorization",
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
  "description" : "Special Authority SA2139. Detailed eligibility criteria available via authorization form.",
  "code" : {
    "coding" : [{
      "system" : "http://pharmac.govt.nz/fhir/sa",
      "code" : "SA2139"
    }],
    "text" : "SA2139"
  },
  "instance" : [{
    "reference" : "Medication/50350151000117104",
    "display" : "Teevir tablet: film-coated, 30 tablets, bottle"
  }]
}

```
