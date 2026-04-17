# MedicationNameSearchParam - Pharmac Schedules FHIR API v1.0.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **MedicationNameSearchParam**

## SearchParameter: MedicationNameSearchParam 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/SearchParameter/medication-name | *Version*:1.0.0 |
| Active as of 2026-04-17 | *Computable Name*:MedicationName |

 
Search for medications by the text representation of the medication code (e.g., 'Gaviscon Infant', 'Acidex oral liquid'). Enables discovery by the full medication name or formulation description. 



## Resource Content

```json
{
  "resourceType" : "SearchParameter",
  "id" : "MedicationNameSearchParam",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/SearchParameter/medication-name",
  "version" : "1.0.0",
  "name" : "MedicationName",
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
  "description" : "Search for medications by the text representation of the medication code (e.g., 'Gaviscon Infant', 'Acidex oral liquid'). Enables discovery by the full medication name or formulation description.",
  "code" : "name",
  "base" : ["Medication"],
  "type" : "string",
  "expression" : "Medication.code.text"
}

```
