# Authorization Form - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Authorization Form**

## Extension: Authorization Form 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-form | *Version*:1.1.0 |
| Draft as of 2026-06-24 | *Computable Name*:AuthorizationForm |

The special authorization form code required for this medication (e.g., 'SA2535'). This identifies the specific PHARMAC authorization form that prescribers must complete for patient eligibility.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-All-Special-Authorities](Bundle-SearchSet-Bundle-All-Special-Authorities.md), [Bundle/SearchSet-Bundle-Nitisinone-Hospital-Restriction](Bundle-SearchSet-Bundle-Nitisinone-Hospital-Restriction.md), [ChargeItemDefinition/ChargeItemDefinition-SA1098-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA1098-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA1329-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA1329-Authorization.md)... Show 8 more, [ChargeItemDefinition/ChargeItemDefinition-SA1683-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA1683-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2139-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2139-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2185-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2185-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2453-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2453-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2536-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2536-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2561-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2561-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2620-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2620-Authorization.md) and [ChargeItemDefinition/ChargeItemDefinition-SA2628-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2628-Authorization.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/resource/pharmac.fhir.pharmac-schedules|current/StructureDefinition/StructureDefinition-authorization-form.json)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-authorization-form.csv), [Excel](StructureDefinition-authorization-form.xlsx), [Schematron](StructureDefinition-authorization-form.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "authorization-form",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-form",
  "version" : "1.1.0",
  "name" : "AuthorizationForm",
  "title" : "Authorization Form",
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
  "description" : "The special authorization form code required for this medication (e.g., 'SA2535'). This identifies the specific PHARMAC authorization form that prescribers must complete for patient eligibility.",
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
      "short" : "Authorization Form",
      "definition" : "The special authorization form code required for this medication (e.g., 'SA2535'). This identifies the specific PHARMAC authorization form that prescribers must complete for patient eligibility."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-form"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Authorization form code",
      "type" : [{
        "code" : "string"
      }]
    }]
  }
}

```
