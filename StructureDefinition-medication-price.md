# Medication Price - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Medication Price**

## Extension: Medication Price 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price | *Version*:1.1.0 |
| Draft as of 2026-06-24 | *Computable Name*:MedicationPrice |

Medication-level schedule date and display price information.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Medication](StructureDefinition-pharmac-medication.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-Adrenaline-Note-And-Limit](Bundle-SearchSet-Bundle-Adrenaline-Note-And-Limit.md), [Bundle/SearchSet-Bundle-All-Medications](Bundle-SearchSet-Bundle-All-Medications.md), [Bundle/SearchSet-Bundle-Estradiol-Limit](Bundle-SearchSet-Bundle-Estradiol-Limit.md), [Bundle/SearchSet-Bundle-Etoposide-Authority-Endorsement](Bundle-SearchSet-Bundle-Etoposide-Authority-Endorsement.md)... Show 33 more, [Bundle/SearchSet-Bundle-Famotidine-Endorsement-And-Note](Bundle-SearchSet-Bundle-Famotidine-Endorsement-And-Note.md), [Bundle/SearchSet-Bundle-Fluanxol-Multiple-Community-And-Hospital](Bundle-SearchSet-Bundle-Fluanxol-Multiple-Community-And-Hospital.md), [Bundle/SearchSet-Bundle-Nitisinone-Hospital-Restriction](Bundle-SearchSet-Bundle-Nitisinone-Hospital-Restriction.md), [Medication/50003171000117108](Medication-50003171000117108.md), [Medication/50014861000117106](Medication-50014861000117106.md), [Medication/50021691000117107](Medication-50021691000117107.md), [Medication/50021721000117104](Medication-50021721000117104.md), [Medication/50021991000117100](Medication-50021991000117100.md), [Medication/50038111000117102](Medication-50038111000117102.md), [Medication/50046921000117106](Medication-50046921000117106.md), [Medication/50046931000117109](Medication-50046931000117109.md), [Medication/50048881000117104](Medication-50048881000117104.md), [Medication/50055641000117102](Medication-50055641000117102.md), [Medication/50058961000117103](Medication-50058961000117103.md), [Medication/50074861000117103](Medication-50074861000117103.md), [Medication/50083491000117102](Medication-50083491000117102.md), [Medication/50085781000117107](Medication-50085781000117107.md), [Medication/50120021000117104](Medication-50120021000117104.md), [Medication/50121491000117102](Medication-50121491000117102.md), [Medication/50148261000117103](Medication-50148261000117103.md), [Medication/50225401000117106](Medication-50225401000117106.md), [Medication/50227471000117107](Medication-50227471000117107.md), [Medication/50242281000117106](Medication-50242281000117106.md), [Medication/50248381000117100](Medication-50248381000117100.md), [Medication/50270251000117100](Medication-50270251000117100.md), [Medication/50277841000117102](Medication-50277841000117102.md), [Medication/50283011000117109](Medication-50283011000117109.md), [Medication/50289761000117107](Medication-50289761000117107.md), [Medication/50301271000117101](Medication-50301271000117101.md), [Medication/50308221000117108](Medication-50308221000117108.md), [Medication/50320741000117103](Medication-50320741000117103.md), [Medication/50324571000117108](Medication-50324571000117108.md) and [Medication/50350151000117104](Medication-50350151000117104.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/resource/pharmac.fhir.pharmac-schedules|current/StructureDefinition/StructureDefinition-medication-price.json)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-medication-price.csv), [Excel](StructureDefinition-medication-price.xlsx), [Schematron](StructureDefinition-medication-price.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "medication-price",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price",
  "version" : "1.1.0",
  "name" : "MedicationPrice",
  "title" : "Medication Price",
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
  "description" : "Medication-level schedule date and display price information.",
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
      "short" : "Medication Price",
      "definition" : "Medication-level schedule date and display price information."
    },
    {
      "id" : "Extension.extension:scheduleDate",
      "path" : "Extension.extension",
      "sliceName" : "scheduleDate",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:scheduleDate.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:scheduleDate.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "scheduleDate"
    },
    {
      "id" : "Extension.extension:scheduleDate.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Schedule date",
      "type" : [{
        "code" : "date"
      }]
    },
    {
      "id" : "Extension.extension:price",
      "path" : "Extension.extension",
      "sliceName" : "price",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:price.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:price.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "price"
    },
    {
      "id" : "Extension.extension:price.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Medication price",
      "type" : [{
        "code" : "Money"
      }]
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "max" : "0"
    }]
  }
}

```
