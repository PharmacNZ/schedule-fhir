# Medication Safety List Medicine - Pharmac Schedules FHIR API v1.0.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Medication Safety List Medicine**

## Extension: Medication Safety List Medicine 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-safety-list-medicine | *Version*:1.0.0 |
| Draft as of 2026-04-17 | *Computable Name*:MedicationSafetyListMedicine |

Indicates whether this medication is on a PHARMAC safety list.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Medication](StructureDefinition-pharmac-medication.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-Clexane-Pricing](Bundle-SearchSet-Bundle-Clexane-Pricing.md), [Bundle/SearchSet-Bundle-Medication](Bundle-SearchSet-Bundle-Medication.md) and [Medication/Medication-Clexane-100mg-1ml-Syringe](Medication-Medication-Clexane-100mg-1ml-Syringe.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/medication-safety-list-medicine)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-medication-safety-list-medicine.csv), [Excel](StructureDefinition-medication-safety-list-medicine.xlsx), [Schematron](StructureDefinition-medication-safety-list-medicine.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "medication-safety-list-medicine",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-safety-list-medicine",
  "version" : "1.0.0",
  "name" : "MedicationSafetyListMedicine",
  "title" : "Medication Safety List Medicine",
  "status" : "draft",
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
  "description" : "Indicates whether this medication is on a PHARMAC safety list.",
  "fhirVersion" : "4.0.1",
  "mapping" : [{
    "identity" : "rim",
    "uri" : "http://hl7.org/v3",
    "name" : "RIM Mapping"
  }],
  "kind" : "complex-type",
  "abstract" : false,
  "context" : [{
    "type" : "element",
    "expression" : "Medication"
  }],
  "type" : "Extension",
  "baseDefinition" : "http://hl7.org/fhir/StructureDefinition/Extension",
  "derivation" : "constraint",
  "differential" : {
    "element" : [{
      "id" : "Extension",
      "path" : "Extension",
      "short" : "Medication Safety List Medicine",
      "definition" : "Indicates whether this medication is on a PHARMAC safety list."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-safety-list-medicine"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Safety list medicine flag",
      "type" : [{
        "code" : "boolean"
      }]
    }]
  }
}

```
