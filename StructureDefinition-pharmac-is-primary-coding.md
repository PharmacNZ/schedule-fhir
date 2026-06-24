# Pharmac Is Primary Coding - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Pharmac Is Primary Coding**

## Extension: Pharmac Is Primary Coding 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding | *Version*:1.1.0 |
| Draft as of 2026-06-24 | *Computable Name*:PharmacIsPrimaryCoding |

Marks the primary pharmac subsidy coding within Medication.code.coding.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Medication](StructureDefinition-pharmac-medication.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-Adrenaline-Note-And-Limit](Bundle-SearchSet-Bundle-Adrenaline-Note-And-Limit.md), [Bundle/SearchSet-Bundle-All-Medications](Bundle-SearchSet-Bundle-All-Medications.md), [Bundle/SearchSet-Bundle-Estradiol-Limit](Bundle-SearchSet-Bundle-Estradiol-Limit.md), [Bundle/SearchSet-Bundle-Etoposide-Authority-Endorsement](Bundle-SearchSet-Bundle-Etoposide-Authority-Endorsement.md)... Show 33 more, [Bundle/SearchSet-Bundle-Famotidine-Endorsement-And-Note](Bundle-SearchSet-Bundle-Famotidine-Endorsement-And-Note.md), [Bundle/SearchSet-Bundle-Fluanxol-Multiple-Community-And-Hospital](Bundle-SearchSet-Bundle-Fluanxol-Multiple-Community-And-Hospital.md), [Bundle/SearchSet-Bundle-Nitisinone-Hospital-Restriction](Bundle-SearchSet-Bundle-Nitisinone-Hospital-Restriction.md), [Medication/50003171000117108](Medication-50003171000117108.md), [Medication/50014861000117106](Medication-50014861000117106.md), [Medication/50021691000117107](Medication-50021691000117107.md), [Medication/50021721000117104](Medication-50021721000117104.md), [Medication/50021991000117100](Medication-50021991000117100.md), [Medication/50038111000117102](Medication-50038111000117102.md), [Medication/50046921000117106](Medication-50046921000117106.md), [Medication/50046931000117109](Medication-50046931000117109.md), [Medication/50048881000117104](Medication-50048881000117104.md), [Medication/50055641000117102](Medication-50055641000117102.md), [Medication/50058961000117103](Medication-50058961000117103.md), [Medication/50074861000117103](Medication-50074861000117103.md), [Medication/50083491000117102](Medication-50083491000117102.md), [Medication/50085781000117107](Medication-50085781000117107.md), [Medication/50120021000117104](Medication-50120021000117104.md), [Medication/50121491000117102](Medication-50121491000117102.md), [Medication/50148261000117103](Medication-50148261000117103.md), [Medication/50225401000117106](Medication-50225401000117106.md), [Medication/50227471000117107](Medication-50227471000117107.md), [Medication/50242281000117106](Medication-50242281000117106.md), [Medication/50248381000117100](Medication-50248381000117100.md), [Medication/50270251000117100](Medication-50270251000117100.md), [Medication/50277841000117102](Medication-50277841000117102.md), [Medication/50283011000117109](Medication-50283011000117109.md), [Medication/50289761000117107](Medication-50289761000117107.md), [Medication/50301271000117101](Medication-50301271000117101.md), [Medication/50308221000117108](Medication-50308221000117108.md), [Medication/50320741000117103](Medication-50320741000117103.md), [Medication/50324571000117108](Medication-50324571000117108.md) and [Medication/50350151000117104](Medication-50350151000117104.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/resource/pharmac.fhir.pharmac-schedules|current/StructureDefinition/StructureDefinition-pharmac-is-primary-coding.json)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-pharmac-is-primary-coding.csv), [Excel](StructureDefinition-pharmac-is-primary-coding.xlsx), [Schematron](StructureDefinition-pharmac-is-primary-coding.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "pharmac-is-primary-coding",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
  "version" : "1.1.0",
  "name" : "PharmacIsPrimaryCoding",
  "title" : "Pharmac Is Primary Coding",
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
  "description" : "Marks the primary pharmac subsidy coding within Medication.code.coding.",
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
    "expression" : "Medication.code.coding"
  }],
  "type" : "Extension",
  "baseDefinition" : "http://hl7.org/fhir/StructureDefinition/Extension",
  "derivation" : "constraint",
  "differential" : {
    "element" : [{
      "id" : "Extension",
      "path" : "Extension",
      "short" : "Pharmac Is Primary Coding",
      "definition" : "Marks the primary pharmac subsidy coding within Medication.code.coding."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Whether this coding is the primary coding",
      "type" : [{
        "code" : "boolean"
      }]
    }]
  }
}

```
