# PHARMAC Medication - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **PHARMAC Medication**

## Resource Profile: PHARMAC Medication 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication | *Version*:1.1.0 |
| Active as of 2025-01-26 | *Computable Name*:PharmacMedication |

 
Profile for Medication resources representing pharmaceutical products in the PHARMAC schedule. This profile defines the structure for medications including product names, coding, form, ingredients, and medication-level extensions such as ATC, pack, price, and legal class. 

 
To define the structure for PHARMAC scheduled medications including product names, dosage forms, coding, ingredients, and medication-level metadata such as pack, ATC, legal class, and price. 

### Overview

The **PHARMAC Medication** profile represents a pharmaceutical product package published through the PHARMAC Schedule API.

The resource is the product-level record used to identify, describe, classify, and price a scheduled medicine.

### Profile

| | |
| :--- | :--- |
| FSH profile name | `PharmacMedication` |
| StructureDefinition id | `pharmac-medication` |
| Parent resource | `Medication` |

### Key elements

| | |
| :--- | :--- |
| `id` | Resource identifier. In the current examples this is the NZMT CTPP identifier |
| `meta.profile` | Declares conformance to`pharmac-medication` |
| `status` | Status of the Medication record |
| `code.coding` | Product coding, including NZMT CTPP, GTIN, and PHARMAC subsidy code where available |
| `code.text` | Human-readable product name |
| `form` | Dose form |
| `ingredient` | Active ingredient information |
| `medication-nzmt-type` | NZMT concept type represented by the resource |
| `medication-description` | Structured product description terms |
| `medication-atc` | ATC classification where available |
| `medication-pack` | Pack code, quantity, and size information where available |
| `medication-legal-classification` | Legal classification display text where supplied |
| `medication-legal-class` | Structured legal-class code where supplied |
| `medication-price` | Schedule date and product price information |
| `pharmac-is-primary-coding` | Identifies the primary PHARMAC subsidy coding within`Medication.code.coding` |

### Resource identifier

The FSH instance name and the FHIR resource `id` are separate values.

```
Instance: Medication-50225401000117106
* id = "50225401000117106"

```

References to this Medication use the FHIR resource id:

```
* instance[0] = Reference(Medication/50225401000117106)

```

### Product coding

`Medication.code.coding` carries the product codes associated with the package. The NZMT CTPP coding identifies the product package represented by the resource. Other coding, such as GTIN or PHARMAC subsidy coding, can be included where available.

The `pharmac-is-primary-coding` extension can be applied to a coding entry to identify the primary PHARMAC subsidy code.

### Product price

Product price is represented on the Medication using `medication-price`.

```
{
  "url": "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price",
  "extension": [
    {
      "url": "price",
      "valueMoney": {
        "value": 180,
        "currency": "NZD"
      }
    }
  ]
}

```

### Related Schedule records

Funding Rules and Special Authority `ChargeItemDefinition` resources reference the relevant Medication using `ChargeItemDefinition.instance`.

The relationship model is described on the [Resource Relationships](relationships.md) page, and API retrieval examples are provided on the [API](api.md) page.

### Example

**Usages:**

* Examples for this Profile: [Medication/50003171000117108](Medication-50003171000117108.md), [Medication/50014861000117106](Medication-50014861000117106.md), [Medication/50021691000117107](Medication-50021691000117107.md), [Medication/50021721000117104](Medication-50021721000117104.md)... Show 26 more, [Medication/50021991000117100](Medication-50021991000117100.md), [Medication/50038111000117102](Medication-50038111000117102.md), [Medication/50046921000117106](Medication-50046921000117106.md), [Medication/50046931000117109](Medication-50046931000117109.md), [Medication/50048881000117104](Medication-50048881000117104.md), [Medication/50055641000117102](Medication-50055641000117102.md), [Medication/50058961000117103](Medication-50058961000117103.md), [Medication/50074861000117103](Medication-50074861000117103.md), [Medication/50083491000117102](Medication-50083491000117102.md), [Medication/50085781000117107](Medication-50085781000117107.md), [Medication/50120021000117104](Medication-50120021000117104.md), [Medication/50121491000117102](Medication-50121491000117102.md), [Medication/50148261000117103](Medication-50148261000117103.md), [Medication/50225401000117106](Medication-50225401000117106.md), [Medication/50227471000117107](Medication-50227471000117107.md), [Medication/50242281000117106](Medication-50242281000117106.md), [Medication/50248381000117100](Medication-50248381000117100.md), [Medication/50270251000117100](Medication-50270251000117100.md), [Medication/50277841000117102](Medication-50277841000117102.md), [Medication/50283011000117109](Medication-50283011000117109.md), [Medication/50289761000117107](Medication-50289761000117107.md), [Medication/50301271000117101](Medication-50301271000117101.md), [Medication/50308221000117108](Medication-50308221000117108.md), [Medication/50320741000117103](Medication-50320741000117103.md), [Medication/50324571000117108](Medication-50324571000117108.md) and [Medication/50350151000117104](Medication-50350151000117104.md)
* CapabilityStatements using this Profile: [Pharmac Schedules Capability Statement](CapabilityStatement-PharmacSchedulesCapabilityStatement.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/resource/pharmac.fhir.pharmac-schedules|current/StructureDefinition/StructureDefinition-pharmac-medication.json)

### Formal Views of Profile Content

 [Description of Profiles, Differentials, Snapshots and how the different presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-pharmac-medication.csv), [Excel](StructureDefinition-pharmac-medication.xlsx), [Schematron](StructureDefinition-pharmac-medication.sch) 



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "pharmac-medication",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication",
  "version" : "1.1.0",
  "name" : "PharmacMedication",
  "title" : "PHARMAC Medication",
  "status" : "active",
  "date" : "2025-01-26",
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
  "description" : "Profile for Medication resources representing pharmaceutical products in the PHARMAC schedule. This profile defines the structure for medications including product names, coding, form, ingredients, and medication-level extensions such as ATC, pack, price, and legal class.",
  "purpose" : "To define the structure for PHARMAC scheduled medications including product names, dosage forms, coding, ingredients, and medication-level metadata such as pack, ATC, legal class, and price.",
  "fhirVersion" : "4.0.1",
  "mapping" : [{
    "identity" : "script10.6",
    "uri" : "http://ncpdp.org/SCRIPT10_6",
    "name" : "Mapping to NCPDP SCRIPT 10.6"
  },
  {
    "identity" : "rim",
    "uri" : "http://hl7.org/v3",
    "name" : "RIM Mapping"
  },
  {
    "identity" : "w5",
    "uri" : "http://hl7.org/fhir/fivews",
    "name" : "FiveWs Pattern Mapping"
  },
  {
    "identity" : "v2",
    "uri" : "http://hl7.org/v2",
    "name" : "HL7 v2 Mapping"
  }],
  "kind" : "resource",
  "abstract" : false,
  "type" : "Medication",
  "baseDefinition" : "http://hl7.org/fhir/StructureDefinition/Medication",
  "derivation" : "constraint",
  "differential" : {
    "element" : [{
      "id" : "Medication",
      "path" : "Medication"
    },
    {
      "id" : "Medication.extension",
      "path" : "Medication.extension",
      "slicing" : {
        "discriminator" : [{
          "type" : "value",
          "path" : "url"
        }],
        "ordered" : false,
        "rules" : "open"
      }
    },
    {
      "id" : "Medication.extension:MedicationNZMTType",
      "path" : "Medication.extension",
      "sliceName" : "MedicationNZMTType",
      "short" : "NZMT type",
      "definition" : "NZMT concept type for the medication code (e.g., CTPP).",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "Medication.extension:MedicationDescription",
      "path" : "Medication.extension",
      "sliceName" : "MedicationDescription",
      "short" : "Medication description",
      "definition" : "Structured description fields (type and term) for the medication.",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "Medication.extension:MedicationATC",
      "path" : "Medication.extension",
      "sliceName" : "MedicationATC",
      "short" : "ATC code",
      "definition" : "ATC code and display for the medication.",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "Medication.extension:MedicationPack",
      "path" : "Medication.extension",
      "sliceName" : "MedicationPack",
      "short" : "Pack details",
      "definition" : "Structured pack details including NZMT medicine code, quantity, and size.",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "Medication.extension:MedicationPrice",
      "path" : "Medication.extension",
      "sliceName" : "MedicationPrice",
      "short" : "Medication price",
      "definition" : "Medication-level schedule date and display price information.",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "Medication.extension:MedicationLegalClass",
      "path" : "Medication.extension",
      "sliceName" : "MedicationLegalClass",
      "short" : "Legal class code",
      "definition" : "Structured legal class coding for the medication.",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-legal-class"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "Medication.code",
      "path" : "Medication.code",
      "min" : 1,
      "mustSupport" : true,
      "binding" : {
        "strength" : "extensible",
        "description" : "Codes for medications from NZMT and SNOMED CT",
        "valueSet" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ValueSet/pharmac-medication-code"
      }
    },
    {
      "id" : "Medication.code.coding",
      "path" : "Medication.code.coding",
      "slicing" : {
        "discriminator" : [{
          "type" : "value",
          "path" : "system"
        }],
        "rules" : "open"
      },
      "min" : 1,
      "mustSupport" : true
    },
    {
      "id" : "Medication.code.coding:nzmt",
      "path" : "Medication.code.coding",
      "sliceName" : "nzmt",
      "min" : 1,
      "max" : "1",
      "mustSupport" : true
    },
    {
      "id" : "Medication.code.coding:nzmt.system",
      "path" : "Medication.code.coding.system",
      "min" : 1,
      "fixedUri" : "http://nzmt.org.nz"
    },
    {
      "id" : "Medication.code.coding:nzmt.code",
      "path" : "Medication.code.coding.code",
      "min" : 1
    },
    {
      "id" : "Medication.code.coding:gtin",
      "path" : "Medication.code.coding",
      "sliceName" : "gtin",
      "min" : 0,
      "max" : "*",
      "mustSupport" : true
    },
    {
      "id" : "Medication.code.coding:gtin.system",
      "path" : "Medication.code.coding.system",
      "min" : 1,
      "fixedUri" : "https://www.gs1.org/gtin"
    },
    {
      "id" : "Medication.code.coding:gtin.code",
      "path" : "Medication.code.coding.code",
      "min" : 1
    },
    {
      "id" : "Medication.code.coding:pharmacSubsidyCode",
      "path" : "Medication.code.coding",
      "sliceName" : "pharmacSubsidyCode",
      "min" : 0,
      "max" : "*",
      "mustSupport" : true
    },
    {
      "id" : "Medication.code.coding:pharmacSubsidyCode.extension:PharmacIsPrimaryCoding",
      "path" : "Medication.code.coding.extension",
      "sliceName" : "PharmacIsPrimaryCoding",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding"]
      }]
    },
    {
      "id" : "Medication.code.coding:pharmacSubsidyCode.system",
      "path" : "Medication.code.coding.system",
      "min" : 1,
      "fixedUri" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code"
    },
    {
      "id" : "Medication.code.coding:pharmacSubsidyCode.code",
      "path" : "Medication.code.coding.code",
      "min" : 1
    },
    {
      "id" : "Medication.code.text",
      "path" : "Medication.code.text",
      "short" : "Medication display name",
      "definition" : "Human-readable display name for the medication product represented by the coded concept.",
      "min" : 1,
      "mustSupport" : true
    },
    {
      "id" : "Medication.ingredient",
      "path" : "Medication.ingredient",
      "short" : "Active and inactive ingredients",
      "mustSupport" : true
    },
    {
      "id" : "Medication.ingredient.item[x]",
      "path" : "Medication.ingredient.item[x]",
      "type" : [{
        "code" : "CodeableConcept"
      }],
      "binding" : {
        "strength" : "extensible",
        "description" : "Codes for medication ingredients from NZMT and SNOMED CT",
        "valueSet" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ValueSet/pharmac-medication-code"
      }
    },
    {
      "id" : "Medication.ingredient.item[x].text",
      "path" : "Medication.ingredient.item[x].text",
      "short" : "Ingredient name(s)",
      "definition" : "Name of the ingredient. May contain multiple ingredients in a single text string for simplicity.",
      "min" : 1
    },
    {
      "id" : "Medication.ingredient.isActive",
      "path" : "Medication.ingredient.isActive",
      "short" : "Whether this is an active ingredient",
      "definition" : "True for active pharmaceutical ingredients, false for excipients",
      "comment" : "For PHARMAC schedule purposes, typically set to true for active ingredients. Excipients are usually not listed.",
      "min" : 1,
      "mustSupport" : true
    }]
  }
}

```
