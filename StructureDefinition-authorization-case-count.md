# Authorization Case Count - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Authorization Case Count**

## Extension: Authorization Case Count 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count | *Version*:0.0.1 |
| Draft as of 2026-03-27 | *Computable Name*:AuthorizationCaseCount |

The number of authorization cases or approval criteria specified in the authorization requirement. This indicates how many different clinical scenarios or conditions have distinct approval pathways.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-Ricovir-Pricing](Bundle-SearchSet-Bundle-Ricovir-Pricing.md), [Bundle/SearchSet-Bundle-SA2139-Authorization](Bundle-SearchSet-Bundle-SA2139-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2139-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2139-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-Tenofovir-Case-Sequence-1](ChargeItemDefinition-ChargeItemDefinition-Tenofovir-Case-Sequence-1.md) and [ChargeItemDefinition/ChargeItemDefinition-Tenofovir-Case-Sequence-2](ChargeItemDefinition-ChargeItemDefinition-Tenofovir-Case-Sequence-2.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/authorization-case-count)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-authorization-case-count.csv), [Excel](StructureDefinition-authorization-case-count.xlsx), [Schematron](StructureDefinition-authorization-case-count.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "authorization-case-count",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count",
  "version" : "0.0.1",
  "name" : "AuthorizationCaseCount",
  "title" : "Authorization Case Count",
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
  "description" : "The number of authorization cases or approval criteria specified in the authorization requirement. This indicates how many different clinical scenarios or conditions have distinct approval pathways.",
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
      "short" : "Authorization Case Count",
      "definition" : "The number of authorization cases or approval criteria specified in the authorization requirement. This indicates how many different clinical scenarios or conditions have distinct approval pathways."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Number of authorization cases",
      "type" : [{
        "code" : "integer"
      }]
    }]
  }
}

```
