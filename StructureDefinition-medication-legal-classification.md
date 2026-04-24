# Medication Legal Classification - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Medication Legal Classification**

## Extension: Medication Legal Classification 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-legal-classification | *Version*:1.0.1 |
| Draft as of 2026-04-24 | *Computable Name*:MedicationLegalClassification |

Legal classification for a medication.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Medication](StructureDefinition-pharmac-medication.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-All-Medications](Bundle-SearchSet-Bundle-All-Medications.md), [Bundle/SearchSet-Bundle-Clexane-Pricing](Bundle-SearchSet-Bundle-Clexane-Pricing.md) and [Medication/Medication-Clexane-100mg-1ml-Syringe](Medication-Medication-Clexane-100mg-1ml-Syringe.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/medication-legal-classification)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-medication-legal-classification.csv), [Excel](StructureDefinition-medication-legal-classification.xlsx), [Schematron](StructureDefinition-medication-legal-classification.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "medication-legal-classification",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-legal-classification",
  "version" : "1.0.1",
  "name" : "MedicationLegalClassification",
  "title" : "Medication Legal Classification",
  "status" : "draft",
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
  "description" : "Legal classification for a medication.",
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
      "short" : "Medication Legal Classification",
      "definition" : "Legal classification for a medication."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-legal-classification"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Legal classification Text.",
      "type" : [{
        "code" : "string"
      }]
    }]
  }
}

```
