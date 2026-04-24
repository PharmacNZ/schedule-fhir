# PHARMAC Medication Code ValueSet - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **PHARMAC Medication Code ValueSet**

## ValueSet: PHARMAC Medication Code ValueSet 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/ValueSet/pharmac-medication-code | *Version*:1.0.1 |
| Active as of 2025-01-27 | *Computable Name*:PharmacMedicationCode |

 
ValueSet containing medication codes from NZMT CTPP, PackID, and SNOMED CT code systems used for PHARMAC pharmaceutical schedule medications. 

 
To define the set of medication codes that can be used to identify medications in the PHARMAC schedule 

 **References** 

* [PHARMAC Medication](StructureDefinition-pharmac-medication.md)

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
  "id" : "pharmac-medication-code",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ValueSet/pharmac-medication-code",
  "version" : "1.0.1",
  "name" : "PharmacMedicationCode",
  "title" : "PHARMAC Medication Code ValueSet",
  "status" : "active",
  "date" : "2025-01-27",
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
  "description" : "ValueSet containing medication codes from NZMT CTPP, PackID, and SNOMED CT code systems used for PHARMAC pharmaceutical schedule medications.",
  "immutable" : false,
  "purpose" : "To define the set of medication codes that can be used to identify medications in the PHARMAC schedule",
  "compose" : {
    "include" : [{
      "system" : "http://snomed.info/sct",
      "filter" : [{
        "property" : "concept",
        "op" : "is-a",
        "value" : "373873005"
      }]
    },
    {
      "valueSet" : ["https://nzhts.digital.health.nz/fhir/ValueSet/nzmt-mp"]
    },
    {
      "system" : "http://snomed.info/sct",
      "filter" : [{
        "property" : "concept",
        "op" : "is-a",
        "value" : "763158003"
      }]
    }]
  }
}

```
