# Medication Unit of Measure - Pharmac Schedules FHIR API v1.0.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Medication Unit of Measure**

## Extension: Medication Unit of Measure 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-unit-of-measure | *Version*:1.0.0 |
| Draft as of 2026-04-17 | *Computable Name*:MedicationUnitOfMeasure |

The unit of measure used for this medication. For example, 'tab' (tablet), 'cap' (capsule), 'ml' (milliliter), 'sach' (sachet).

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Medication](StructureDefinition-pharmac-medication.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-Clexane-Pricing](Bundle-SearchSet-Bundle-Clexane-Pricing.md), [Bundle/SearchSet-Bundle-Medication](Bundle-SearchSet-Bundle-Medication.md), [Medication/Medication-Clexane-100mg-1ml-Syringe](Medication-Medication-Clexane-100mg-1ml-Syringe.md), [Medication/Medication-Fortisip-Multi-Fibre-Chocolate](Medication-Medication-Fortisip-Multi-Fibre-Chocolate.md) and [Medication/Medication-Nutrison-800-Complete-Multi-Fibre](Medication-Medication-Nutrison-800-Complete-Multi-Fibre.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/medication-unit-of-measure)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-medication-unit-of-measure.csv), [Excel](StructureDefinition-medication-unit-of-measure.xlsx), [Schematron](StructureDefinition-medication-unit-of-measure.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "medication-unit-of-measure",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-unit-of-measure",
  "version" : "1.0.0",
  "name" : "MedicationUnitOfMeasure",
  "title" : "Medication Unit of Measure",
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
  "description" : "The unit of measure used for this medication. For example, 'tab' (tablet), 'cap' (capsule), 'ml' (milliliter), 'sach' (sachet).",
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
      "short" : "Medication Unit of Measure",
      "definition" : "The unit of measure used for this medication. For example, 'tab' (tablet), 'cap' (capsule), 'ml' (milliliter), 'sach' (sachet)."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-unit-of-measure"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Unit of measure (e.g., tab, cap, ml, sach)",
      "type" : [{
        "code" : "string"
      }]
    }]
  }
}

```
