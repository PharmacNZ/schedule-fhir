# Medication-Fortisip-Multi-Fibre-Chocolate - Pharmac Schedules FHIR API v1.0.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Medication-Fortisip-Multi-Fibre-Chocolate**

## Example Medication: Medication-Fortisip-Multi-Fibre-Chocolate



## Resource Content

```json
{
  "resourceType" : "Medication",
  "id" : "Medication-Fortisip-Multi-Fibre-Chocolate",
  "meta" : {
    "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
  },
  "extension" : [{
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-brand-name",
    "valueString" : "Fortisip Multi Fibre (chocolate)"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-package-size",
    "valueString" : "200"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-unit-of-measure",
    "valueString" : "ml"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-1",
    "valueString" : "Special Foods"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-2",
    "valueString" : "Standard Feeds"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-3",
    "valueString" : "Standard Feeds"
  }],
  "identifier" : [{
    "system" : "http://schedule.pharmac.govt.nz/ids/brand",
    "value" : "B42063138522825"
  },
  {
    "system" : "http://schedule.pharmac.govt.nz/ids/pack",
    "value" : "P2702614"
  },
  {
    "system" : "http://schedule.pharmac.govt.nz/ids/chemical",
    "value" : "C4206313852"
  },
  {
    "system" : "http://schedule.pharmac.govt.nz/ids/formulation",
    "value" : "F420631385228"
  },
  {
    "system" : "http://schedule.pharmac.govt.nz/ids/pharmacode",
    "value" : "2702614"
  }],
  "code" : {
    "coding" : [{
      "system" : "http://nzmt.org.nz",
      "code" : "50035701000117108"
    }],
    "text" : "Fortisip Multi Fibre (chocolate)"
  },
  "status" : "active",
  "form" : {
    "text" : "Liquid"
  }
}

```
