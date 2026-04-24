# Authorization Schema - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Authorization Schema**

## Extension: Authorization Schema 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema | *Version*:1.0.1 |
| Draft as of 2026-04-24 | *Computable Name*:AuthorizationSchema |

Base64-encoded JSON Schema that defines the structure and validation rules for a Special Authorization application form. The decoded content is a JSON Schema (application/schema+json).

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-All-Special-Authorities](Bundle-SearchSet-Bundle-All-Special-Authorities.md), [Bundle/SearchSet-Bundle-Clexane-Pricing](Bundle-SearchSet-Bundle-Clexane-Pricing.md), [ChargeItemDefinition/ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1](ChargeItemDefinition-ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2](ChargeItemDefinition-ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2.md)... Show 2 more, [ChargeItemDefinition/ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-3](ChargeItemDefinition-ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-3.md) and [ChargeItemDefinition/ChargeItemDefinition-SA9999-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA9999-Authorization.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/authorization-schema)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-authorization-schema.csv), [Excel](StructureDefinition-authorization-schema.xlsx), [Schematron](StructureDefinition-authorization-schema.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "authorization-schema",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema",
  "version" : "1.0.1",
  "name" : "AuthorizationSchema",
  "title" : "Authorization Schema",
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
  "description" : "Base64-encoded JSON Schema that defines the structure and validation rules for a Special Authorization application form. The decoded content is a JSON Schema (application/schema+json).",
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
      "short" : "Authorization Schema",
      "definition" : "Base64-encoded JSON Schema that defines the structure and validation rules for a Special Authorization application form. The decoded content is a JSON Schema (application/schema+json)."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Base64-encoded JSON Schema for authorization form",
      "type" : [{
        "code" : "base64Binary"
      }]
    }]
  }
}

```
