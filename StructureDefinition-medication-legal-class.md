# Medication Legal Class - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Medication Legal Class**

## Extension: Medication Legal Class 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-legal-class | *Version*:1.1.0 |
| Draft as of 2026-06-24 | *Computable Name*:MedicationLegalClass |

Structured legal class code for a medication.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Medication](StructureDefinition-pharmac-medication.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/resource/pharmac.fhir.pharmac-schedules|current/StructureDefinition/StructureDefinition-medication-legal-class.json)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-medication-legal-class.csv), [Excel](StructureDefinition-medication-legal-class.xlsx), [Schematron](StructureDefinition-medication-legal-class.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "medication-legal-class",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-legal-class",
  "version" : "1.1.0",
  "name" : "MedicationLegalClass",
  "title" : "Medication Legal Class",
  "status" : "draft",
  "date" : "2026-06-24T20:43:54+00:00",
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
  "description" : "Structured legal class code for a medication.",
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
      "short" : "Medication Legal Class",
      "definition" : "Structured legal class code for a medication."
    },
    {
      "id" : "Extension.extension:code",
      "path" : "Extension.extension",
      "sliceName" : "code",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:code.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:code.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "code"
    },
    {
      "id" : "Extension.extension:code.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Legal class code",
      "type" : [{
        "code" : "CodeableConcept"
      }]
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-legal-class"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "max" : "0"
    }]
  }
}

```
