# Statim (Urgent Dispensing) - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Statim (Urgent Dispensing)**

## Extension: Statim (Urgent Dispensing) 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/statim | *Version*:0.0.1 |
| Draft as of 2026-03-27 | *Computable Name*:Statim |

Indicates whether stat (urgent) dispensing rules apply for this item.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-Leuprorelin-Pricing](Bundle-SearchSet-Bundle-Leuprorelin-Pricing.md), [Bundle/SearchSet-Bundle-Ricovir-Pricing](Bundle-SearchSet-Bundle-Ricovir-Pricing.md), [ChargeItemDefinition/ChargeItemDefinition-Lucrin-Depot-1-Month-Pricing](ChargeItemDefinition-ChargeItemDefinition-Lucrin-Depot-1-Month-Pricing.md) and [ChargeItemDefinition/ChargeItemDefinition-Ricovir-Pricing](ChargeItemDefinition-ChargeItemDefinition-Ricovir-Pricing.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/statim)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-statim.csv), [Excel](StructureDefinition-statim.xlsx), [Schematron](StructureDefinition-statim.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "statim",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/statim",
  "version" : "0.0.1",
  "name" : "Statim",
  "title" : "Statim (Urgent Dispensing)",
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
  "description" : "Indicates whether stat (urgent) dispensing rules apply for this item.",
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
    "expression" : "ChargeItemDefinition"
  }],
  "type" : "Extension",
  "baseDefinition" : "http://hl7.org/fhir/StructureDefinition/Extension",
  "derivation" : "constraint",
  "differential" : {
    "element" : [{
      "id" : "Extension",
      "path" : "Extension",
      "short" : "Statim (Urgent Dispensing)",
      "definition" : "Indicates whether stat (urgent) dispensing rules apply for this item."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/statim"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Statim flag",
      "type" : [{
        "code" : "string"
      }]
    }]
  }
}

```
