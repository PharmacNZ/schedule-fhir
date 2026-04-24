# Contract Type - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Contract Type**

## Extension: Contract Type 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/contract-type | *Version*:1.0.1 |
| Draft as of 2026-04-24 | *Computable Name*:ContractType |

Type of PHARMAC contract that applies to this item (for example, sole-supply, preferred).

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-Clexane-Pricing](Bundle-SearchSet-Bundle-Clexane-Pricing.md) and [ChargeItemDefinition/ChargeItemDefinition-Clexane-Pricing](ChargeItemDefinition-ChargeItemDefinition-Clexane-Pricing.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/contract-type)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-contract-type.csv), [Excel](StructureDefinition-contract-type.xlsx), [Schematron](StructureDefinition-contract-type.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "contract-type",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/contract-type",
  "version" : "1.0.1",
  "name" : "ContractType",
  "title" : "Contract Type",
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
  "description" : "Type of PHARMAC contract that applies to this item (for example, sole-supply, preferred).",
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
      "short" : "Contract Type",
      "definition" : "Type of PHARMAC contract that applies to this item (for example, sole-supply, preferred)."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/contract-type"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Contract type value",
      "type" : [{
        "code" : "string"
      }]
    }]
  }
}

```
