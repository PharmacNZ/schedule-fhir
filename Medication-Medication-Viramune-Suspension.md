# Medication-Viramune-Suspension - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Medication-Viramune-Suspension**

## Example Medication: Medication-Viramune-Suspension



## Resource Content

```json
{
  "resourceType" : "Medication",
  "id" : "Medication-Viramune-Suspension",
  "meta" : {
    "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
  },
  "extension" : [{
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-brand-name",
    "valueString" : "Viramune Suspension"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-package-size",
    "valueString" : "240"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-unit-of-measure",
    "valueString" : "ml"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-rank",
    "valueInteger" : 3
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-1",
    "valueString" : "Infections - Agents for Systemic Use"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-2",
    "valueString" : "Antiretrovirals"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-3",
    "valueString" : "Non-nucleosides Reverse Transcriptase Inhibitors"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-product-multiple",
    "valueBoolean" : false
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-product-multiplier",
    "valueInteger" : 0
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-original-pack",
    "valueBoolean" : false
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-safety-list-medicine",
    "valueBoolean" : false
  }],
  "identifier" : [{
    "system" : "http://schedule.pharmac.govt.nz/ids/brand",
    "value" : "B16200111702525"
  },
  {
    "system" : "http://schedule.pharmac.govt.nz/ids/pack",
    "value" : "P2014947"
  },
  {
    "system" : "http://schedule.pharmac.govt.nz/ids/chemical",
    "value" : "C1620011170"
  },
  {
    "system" : "http://schedule.pharmac.govt.nz/ids/formulation",
    "value" : "F162001117025"
  },
  {
    "system" : "http://schedule.pharmac.govt.nz/ids/pharmacode",
    "value" : "2014947"
  }],
  "code" : {
    "coding" : [{
      "system" : "http://nzmt.org.nz",
      "code" : "50002451000117104",
      "display" : "Nevirapine 10 ml, 240 ml"
    }],
    "text" : "Nevirapine"
  },
  "status" : "active",
  "form" : {
    "coding" : [{
      "system" : "http://snomed.info/sct",
      "code" : "385013001",
      "display" : "Liquid"
    }],
    "text" : "Oral suspension 10 mg per ml"
  },
  "ingredient" : [{
    "itemCodeableConcept" : {
      "coding" : [{
        "system" : "http://nzmt.org.nz",
        "code" : "2391011000036108",
        "display" : "nevirapine"
      }],
      "text" : "nevirapine"
    },
    "isActive" : true
  }]
}

```
