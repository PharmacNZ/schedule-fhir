# Medication Package Size - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Medication Package Size**

## Extension: Medication Package Size 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-package-size | *Version*:1.0.1 |
| Draft as of 2026-04-24 | *Computable Name*:MedicationPackageSize |

Package size for a scheduled medication. For example, '30 x 650 mg sachets' would be represented as 'Sachet' in the form property and 30 in the packageSize extension property.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Medication](StructureDefinition-pharmac-medication.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-All-Medications](Bundle-SearchSet-Bundle-All-Medications.md), [Bundle/SearchSet-Bundle-Clexane-Pricing](Bundle-SearchSet-Bundle-Clexane-Pricing.md), [Medication/Medication-Clexane-100mg-1ml-Syringe](Medication-Medication-Clexane-100mg-1ml-Syringe.md), [Medication/Medication-Fortisip-Multi-Fibre-Chocolate](Medication-Medication-Fortisip-Multi-Fibre-Chocolate.md) and [Medication/Medication-Nutrison-800-Complete-Multi-Fibre](Medication-Medication-Nutrison-800-Complete-Multi-Fibre.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/medication-package-size)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-medication-package-size.csv), [Excel](StructureDefinition-medication-package-size.xlsx), [Schematron](StructureDefinition-medication-package-size.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "medication-package-size",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-package-size",
  "version" : "1.0.1",
  "name" : "MedicationPackageSize",
  "title" : "Medication Package Size",
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
  "description" : "Package size for a scheduled medication. For example, '30 x 650 mg sachets' would be represented as 'Sachet' in the form property and 30 in the packageSize extension property.",
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
      "short" : "Medication Package Size",
      "definition" : "Package size for a scheduled medication. For example, '30 x 650 mg sachets' would be represented as 'Sachet' in the form property and 30 in the packageSize extension property."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-package-size"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Package size value.",
      "type" : [{
        "code" : "string"
      }]
    }]
  }
}

```
