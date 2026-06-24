# Device Definition Reference - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Device Definition Reference**

## Extension: Device Definition Reference 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/device-definition-reference | *Version*:1.1.0 |
| Draft as of 2026-06-24 | *Computable Name*:DeviceDefinitionReference |

Reference to a DeviceDefinition that this pricing applies to. Used because ChargeItemDefinition.instance can only reference Device, Medication, or Substance instances, not DeviceDefinition. For Medication, use ChargeItemDefinition.instance directly.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/resource/pharmac.fhir.pharmac-schedules|current/StructureDefinition/StructureDefinition-device-definition-reference.json)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-device-definition-reference.csv), [Excel](StructureDefinition-device-definition-reference.xlsx), [Schematron](StructureDefinition-device-definition-reference.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "device-definition-reference",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/device-definition-reference",
  "version" : "1.1.0",
  "name" : "DeviceDefinitionReference",
  "title" : "Device Definition Reference",
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
  "description" : "Reference to a DeviceDefinition that this pricing applies to. Used because ChargeItemDefinition.instance can only reference Device, Medication, or Substance instances, not DeviceDefinition. For Medication, use ChargeItemDefinition.instance directly.",
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
      "short" : "Device Definition Reference",
      "definition" : "Reference to a DeviceDefinition that this pricing applies to. Used because ChargeItemDefinition.instance can only reference Device, Medication, or Substance instances, not DeviceDefinition. For Medication, use ChargeItemDefinition.instance directly."
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/device-definition-reference"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "short" : "Reference to DeviceDefinition",
      "type" : [{
        "code" : "Reference",
        "targetProfile" : ["http://hl7.org/fhir/StructureDefinition/DeviceDefinition"]
      }]
    }]
  }
}

```
