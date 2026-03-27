# Pricing Effective Date - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Pricing Effective Date**

## Extension: Pricing Effective Date 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date | *Version*:0.0.1 |
| Draft as of 2026-03-27 | *Computable Name*:PricingEffectiveDate |

The date from which this pricing becomes effective.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-Leuprorelin-Pricing](Bundle-SearchSet-Bundle-Leuprorelin-Pricing.md), [Bundle/SearchSet-Bundle-Ricovir-Pricing](Bundle-SearchSet-Bundle-Ricovir-Pricing.md), [Bundle/SearchSet-Bundle-SA2139-Authorization](Bundle-SearchSet-Bundle-SA2139-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-BSO-Sequence-1](ChargeItemDefinition-ChargeItemDefinition-Community-Pharmacy-BSO-Sequence-1.md)... Show 9 more, [ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-Rural-PSO-Sequence-1](ChargeItemDefinition-ChargeItemDefinition-Community-Pharmacy-Rural-PSO-Sequence-1.md), [ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-Sequence-1](ChargeItemDefinition-ChargeItemDefinition-Community-Pharmacy-Sequence-1.md), [ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-Sequence-2](ChargeItemDefinition-ChargeItemDefinition-Community-Pharmacy-Sequence-2.md), [ChargeItemDefinition/ChargeItemDefinition-Lucrin-Depot-1-Month-Pricing](ChargeItemDefinition-ChargeItemDefinition-Lucrin-Depot-1-Month-Pricing.md), [ChargeItemDefinition/ChargeItemDefinition-Ricovir-Pricing](ChargeItemDefinition-ChargeItemDefinition-Ricovir-Pricing.md), [ChargeItemDefinition/ChargeItemDefinition-SA2139-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2139-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2520-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2520-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-Tenofovir-Case-Sequence-1](ChargeItemDefinition-ChargeItemDefinition-Tenofovir-Case-Sequence-1.md) and [ChargeItemDefinition/ChargeItemDefinition-Tenofovir-Case-Sequence-2](ChargeItemDefinition-ChargeItemDefinition-Tenofovir-Case-Sequence-2.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/pricing-effective-date)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-pricing-effective-date.csv), [Excel](StructureDefinition-pricing-effective-date.xlsx), [Schematron](StructureDefinition-pricing-effective-date.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "pricing-effective-date",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date",
  "version" : "0.0.1",
  "name" : "PricingEffectiveDate",
  "title" : "Pricing Effective Date",
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
  "description" : "The date from which this pricing becomes effective.",
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
      "short" : "Pricing Effective Date",
      "definition" : "The date from which this pricing becomes effective."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Effective date for pricing",
      "type" : [{
        "code" : "date"
      }]
    }]
  }
}

```
