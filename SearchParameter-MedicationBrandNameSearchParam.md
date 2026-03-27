# MedicationBrandNameSearchParam - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **MedicationBrandNameSearchParam**

## SearchParameter: MedicationBrandNameSearchParam 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/SearchParameter/medication-brand-name | *Version*:0.0.1 |
| Active as of 2026-03-27 | *Computable Name*:brand |

 
Search for medications by brand name (e.g., 'Gaviscon', 'Acidex', 'Budesonide'). Enables fuzzy matching on the medication-brand-name extension for discovery by product name. 



## Resource Content

```json
{
  "resourceType" : "SearchParameter",
  "id" : "MedicationBrandNameSearchParam",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/SearchParameter/medication-brand-name",
  "version" : "0.0.1",
  "name" : "brand",
  "status" : "active",
  "date" : "2026-03-27T00:29:47+00:00",
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
  "description" : "Search for medications by brand name (e.g., 'Gaviscon', 'Acidex', 'Budesonide'). Enables fuzzy matching on the medication-brand-name extension for discovery by product name.",
  "code" : "brand",
  "base" : ["Medication"],
  "type" : "string",
  "expression" : "Medication.extension.where(url='https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-brand-name').value.ofType(string)",
  "xpathUsage" : "normal"
}

```
