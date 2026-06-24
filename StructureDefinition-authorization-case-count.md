# Authorization Case Count - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Authorization Case Count**

## Extension: Authorization Case Count 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count | *Version*:1.1.0 |
| Draft as of 2026-06-24 | *Computable Name*:AuthorizationCaseCount |

The number of authorization cases or approval criteria specified in the authorization requirement. This indicates how many different clinical scenarios or conditions have distinct approval pathways.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-All-Special-Authorities](Bundle-SearchSet-Bundle-All-Special-Authorities.md), [Bundle/SearchSet-Bundle-Nitisinone-Hospital-Restriction](Bundle-SearchSet-Bundle-Nitisinone-Hospital-Restriction.md), [ChargeItemDefinition/ChargeItemDefinition-SA1098-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA1098-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA1329-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA1329-Authorization.md)... Show 8 more, [ChargeItemDefinition/ChargeItemDefinition-SA1683-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA1683-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2139-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2139-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2185-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2185-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2453-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2453-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2536-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2536-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2561-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2561-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2620-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2620-Authorization.md) and [ChargeItemDefinition/ChargeItemDefinition-SA2628-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2628-Authorization.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/resource/pharmac.fhir.pharmac-schedules|current/StructureDefinition/StructureDefinition-authorization-case-count.json)

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
  "version" : "1.1.0",
  "name" : "AuthorizationCaseCount",
  "title" : "Authorization Case Count",
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
