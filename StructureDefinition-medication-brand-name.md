# Medication Brand Name - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Medication Brand Name**

## Extension: Medication Brand Name 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-brand-name | *Version*:0.0.1 |
| Draft as of 2026-03-27 | *Computable Name*:MedicationBrandName |

The brand or trade name of the medication. For example, 'Budesonide Te Arai' or 'Gaviscon Infant'.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Medication](StructureDefinition-pharmac-medication.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-Leuprorelin-Pricing](Bundle-SearchSet-Bundle-Leuprorelin-Pricing.md), [Bundle/SearchSet-Bundle-Medication](Bundle-SearchSet-Bundle-Medication.md), [Bundle/SearchSet-Bundle-Ricovir-Pricing](Bundle-SearchSet-Bundle-Ricovir-Pricing.md), [Bundle/SearchSet-Bundle-SA2139-Authorization](Bundle-SearchSet-Bundle-SA2139-Authorization.md)... Show 3 more, [Medication/Medication-Lucrin-Depot-1-Month](Medication-Medication-Lucrin-Depot-1-Month.md), [Medication/Medication-Ricovir-Tenofovir](Medication-Medication-Ricovir-Tenofovir.md) and [Medication/Medication-Viramune-Suspension](Medication-Medication-Viramune-Suspension.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/medication-brand-name)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-medication-brand-name.csv), [Excel](StructureDefinition-medication-brand-name.xlsx), [Schematron](StructureDefinition-medication-brand-name.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "medication-brand-name",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-brand-name",
  "version" : "0.0.1",
  "name" : "MedicationBrandName",
  "title" : "Medication Brand Name",
  "status" : "draft",
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
  "description" : "The brand or trade name of the medication. For example, 'Budesonide Te Arai' or 'Gaviscon Infant'.",
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
      "short" : "Medication Brand Name",
      "definition" : "The brand or trade name of the medication. For example, 'Budesonide Te Arai' or 'Gaviscon Infant'."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-brand-name"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Brand name of the medication",
      "type" : [{
        "code" : "string"
      }]
    }]
  }
}

```
