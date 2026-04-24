# MedicationCategorySearchParam - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **MedicationCategorySearchParam**

## SearchParameter: MedicationCategorySearchParam 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/SearchParameter/medication-category | *Version*:1.0.1 |
| Active as of 2026-04-24 | *Computable Name*:medication-category |

 
Search for medications by category 



## Resource Content

```json
{
  "resourceType" : "SearchParameter",
  "id" : "MedicationCategorySearchParam",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/SearchParameter/medication-category",
  "version" : "1.0.1",
  "name" : "medication-category",
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
  "description" : "Search for medications by category",
  "code" : "category",
  "base" : ["Medication"],
  "type" : "string",
  "expression" : "Medication.extension.where(url='https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-1').value.ofType(string) | Medication.extension.where(url='https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-2').value.ofType(string) | DeviceDefinition.extension.where(url='https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-3').value.ofType(string)",
  "xpathUsage" : "normal",
  "target" : ["Medication"]
}

```
