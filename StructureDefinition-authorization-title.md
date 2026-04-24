# Authorization Title - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Authorization Title**

## Extension: Authorization Title 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-title | *Version*:1.0.1 |
| Draft as of 2026-04-24 | *Computable Name*:AuthorizationTitle |

A human-readable title for the authorization requirement (e.g., 'Budesonide - Special Authorization Required'). This provides context for the authorization need.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/authorization-title)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-authorization-title.csv), [Excel](StructureDefinition-authorization-title.xlsx), [Schematron](StructureDefinition-authorization-title.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "authorization-title",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-title",
  "version" : "1.0.1",
  "name" : "AuthorizationTitle",
  "title" : "Authorization Title",
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
  "description" : "A human-readable title for the authorization requirement (e.g., 'Budesonide - Special Authorization Required'). This provides context for the authorization need.",
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
      "short" : "Authorization Title",
      "definition" : "A human-readable title for the authorization requirement (e.g., 'Budesonide - Special Authorization Required'). This provides context for the authorization need."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-title"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Authorization title",
      "type" : [{
        "code" : "string"
      }]
    }]
  }
}

```
