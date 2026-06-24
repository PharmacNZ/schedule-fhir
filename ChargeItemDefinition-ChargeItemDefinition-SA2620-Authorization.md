# ChargeItemDefinition-SA2620-Authorization - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinition-SA2620-Authorization**

## Example ChargeItemDefinition: ChargeItemDefinition-SA2620-Authorization

| |
| :--- |
| Active as of 2026-04-24 |



## Resource Content

```json
{
  "resourceType" : "ChargeItemDefinition",
  "id" : "ChargeItemDefinition-SA2620-Authorization",
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
    "valueString" : "SA2620"
  }],
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-SA2620-Authorization",
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
  "description" : "Special Authority SA2620. Detailed eligibility criteria available via authorization form.",
  "code" : {
    "coding" : [{
      "system" : "http://pharmac.govt.nz/fhir/sa",
      "code" : "SA2620"
    }],
    "text" : "SA2620"
  },
  "instance" : [{
    "reference" : "Medication/50003171000117108",
    "display" : "Remicade 100 mg injection: powder for, 1 x 100 mg vial"
  }]
}

```
