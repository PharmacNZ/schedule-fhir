# Medication Form Codes - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Medication Form Codes**

## ValueSet: Medication Form Codes 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/ValueSet/medication-form-codes | *Version*:1.0.1 |
| Draft as of 2026-04-24 | *Computable Name*:MedicationFormCodes |

 **References** 

This value set is not used here; it may be used elsewhere (e.g. specifications and/or implementations that use this content)

### Logical Definition (CLD)

 

### Expansion

No Expansion for this valueset (Unsupported Code System Version)

-------

 Explanation of the columns that may appear on this page: 

| | |
| :--- | :--- |
| Level | A few code lists that FHIR defines are hierarchical - each code is assigned a level. In this scheme, some codes are under other codes, and imply that the code they are under also applies |
| System | The source of the definition of the code (when the value set draws in codes defined elsewhere) |
| Code | The code (used as the code in the resource instance) |
| Display | The display (used in the*display*element of a[Coding](http://hl7.org/fhir/R4/datatypes.html#Coding)). If there is no display, implementers should not simply display the code, but map the concept into their application |
| Definition | An explanation of the meaning of the concept |
| Comments | Additional notes about how to use the code |



## Resource Content

```json
{
  "resourceType" : "ValueSet",
  "id" : "medication-form-codes",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ValueSet/medication-form-codes",
  "version" : "1.0.1",
  "name" : "MedicationFormCodes",
  "title" : "Medication Form Codes",
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
  "compose" : {
    "include" : [{
      "system" : "http://snomed.info/sct",
      "filter" : [{
        "property" : "concept",
        "op" : "is-a",
        "value" : "385055003"
      }]
    }]
  }
}

```
