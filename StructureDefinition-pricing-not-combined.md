# Pricing Not Combined - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Pricing Not Combined**

## Extension: Pricing Not Combined 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-not-combined | *Version*:1.1.0 |
| Draft as of 2026-06-24 | *Computable Name*:PricingNotCombined |

Indicates whether Not Combined applies to this pricing record.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/resource/pharmac.fhir.pharmac-schedules|current/StructureDefinition/StructureDefinition-pricing-not-combined.json)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-pricing-not-combined.csv), [Excel](StructureDefinition-pricing-not-combined.xlsx), [Schematron](StructureDefinition-pricing-not-combined.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "pricing-not-combined",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-not-combined",
  "version" : "1.1.0",
  "name" : "PricingNotCombined",
  "title" : "Pricing Not Combined",
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
  "description" : "Indicates whether Not Combined applies to this pricing record.",
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
      "short" : "Pricing Not Combined",
      "definition" : "Indicates whether Not Combined applies to this pricing record."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-not-combined"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Not Combined applicability.",
      "type" : [{
        "code" : "boolean"
      }]
    }]
  }
}

```
