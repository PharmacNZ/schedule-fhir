# Pricing Section 29 - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Pricing Section 29**

## Extension: Pricing Section 29 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-section-29 | *Version*:1.0.1 |
| Draft as of 2026-04-24 | *Computable Name*:PricingSection29 |

Indicates whether Section 29 applies to this pricing record.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/pricing-section-29)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-pricing-section-29.csv), [Excel](StructureDefinition-pricing-section-29.xlsx), [Schematron](StructureDefinition-pricing-section-29.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "pricing-section-29",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-section-29",
  "version" : "1.0.1",
  "name" : "PricingSection29",
  "title" : "Pricing Section 29",
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
  "description" : "Indicates whether Section 29 applies to this pricing record.",
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
      "short" : "Pricing Section 29",
      "definition" : "Indicates whether Section 29 applies to this pricing record."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-section-29"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Section 29 applicability.",
      "type" : [{
        "code" : "boolean"
      }]
    }]
  }
}

```
