# PHARMAC Medication - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **PHARMAC Medication**

## Resource Profile: PHARMAC Medication 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication | *Version*:0.0.1 |
| Active as of 2025-01-26 | *Computable Name*:PharmacMedication |

 
Profile for Medication resources representing pharmaceutical products in the PHARMAC schedule. This profile defines the structure for medications including brand identification, pack codes, product names, form, and ingredients. Pricing information is provided via related ChargeItemDefinition resources that can be retrieved using the _include search parameter. 

 
To define the structure for PHARMAC scheduled medications including brand and pack identifiers, product names, dosage forms, and ingredients. Pricing information should be accessed via ChargeItemDefinition resources using _include=Medication:medication in search queries. 

**Usages:**

* Examples for this Profile: [Medication/Medication-Lucrin-Depot-1-Month](Medication-Medication-Lucrin-Depot-1-Month.md), [Medication/Medication-Ricovir-Tenofovir](Medication-Medication-Ricovir-Tenofovir.md) and [Medication/Medication-Viramune-Suspension](Medication-Medication-Viramune-Suspension.md)
* CapabilityStatements using this Profile: [Pharmac Schedules Capability Statement](CapabilityStatement-PharmacSchedulesCapabilityStatement.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/pharmac-medication)

### Formal Views of Profile Content

 [Description of Profiles, Differentials, Snapshots and how the different presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-pharmac-medication.csv), [Excel](StructureDefinition-pharmac-medication.xlsx), [Schematron](StructureDefinition-pharmac-medication.sch) 



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "pharmac-medication",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication",
  "version" : "0.0.1",
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
  "description" : "Profile for Medication resources representing pharmaceutical products in the PHARMAC schedule. This profile defines the structure for medications including brand identification, pack codes, product names, form, and ingredients. Pricing information is provided via related ChargeItemDefinition resources that can be retrieved using the _include search parameter.",
  "purpose" : "To define the structure for PHARMAC scheduled medications including brand and pack identifiers, product names, dosage forms, and ingredients. Pricing information should be accessed via ChargeItemDefinition resources using _include=Medication:medication in search queries.",
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
      "id" : "Medication.extension:MedicationBrandName",
      "path" : "Medication.extension",
      "sliceName" : "MedicationBrandName",
      "short" : "Brand name of the medication",
      "definition" : "The marketed brand name for the medication (e.g., 'Budesonide Te Arai', 'Gaviscon Infant')",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-brand-name"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "Medication.extension:MedicationPackageSize",
      "path" : "Medication.extension",
      "sliceName" : "MedicationPackageSize",
      "short" : "Package size/quantity",
      "definition" : "The quantity of medication per pack (e.g., '30' for 30 sachets, '100' for 100 tablets)",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-package-size"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "Medication.extension:MedicationUnitOfMeasure",
      "path" : "Medication.extension",
      "sliceName" : "MedicationUnitOfMeasure",
      "short" : "Unit of measure",
      "definition" : "The unit used for the package size (e.g., 'tab', 'cap', 'ml', 'sach')",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-unit-of-measure"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "Medication.extension:MedicationRank",
      "path" : "Medication.extension",
      "sliceName" : "MedicationRank",
      "short" : "Medication preference rank",
      "definition" : "The preference rank for this medication in the schedule (1=preferred, 2=less preferred, 3=least preferred)",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-rank"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "Medication.extension:MedicationATCCategory1",
      "path" : "Medication.extension",
      "sliceName" : "MedicationATCCategory1",
      "short" : "ATC Category Level 1",
      "definition" : "First level ATC classification (e.g., 'Alimentary tract and metabolism')",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-1"]
      }]
    },
    {
      "id" : "Medication.extension:MedicationATCCategory2",
      "path" : "Medication.extension",
      "sliceName" : "MedicationATCCategory2",
      "short" : "ATC Category Level 2",
      "definition" : "Second level ATC classification (e.g., 'Drugs for acid related disorders')",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-2"]
      }]
    },
    {
      "id" : "Medication.extension:MedicationATCCategory3",
      "path" : "Medication.extension",
      "sliceName" : "MedicationATCCategory3",
      "short" : "ATC Category Level 3",
      "definition" : "Third level ATC classification (e.g., 'Antacids')",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-3"]
      }]
    },
    {
      "id" : "Medication.extension:MedicationProductMultiple",
      "path" : "Medication.extension",
      "sliceName" : "MedicationProductMultiple",
      "short" : "Product multiple applies",
      "definition" : "Indicates whether this pack uses product multiples when calculating pricing or claims.",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-product-multiple"]
      }]
    },
    {
      "id" : "Medication.extension:MedicationProductMultiplier",
      "path" : "Medication.extension",
      "sliceName" : "MedicationProductMultiplier",
      "short" : "Product multiplier value",
      "definition" : "Numeric multiplier applied when calculating pricing or claims for this pack.",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-product-multiplier"]
      }]
    },
    {
      "id" : "Medication.extension:MedicationOriginalPack",
      "path" : "Medication.extension",
      "sliceName" : "MedicationOriginalPack",
      "short" : "Original pack flag",
      "definition" : "Indicates whether this pack represents the original pack supplied by the manufacturer.",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-original-pack"]
      }]
    },
    {
      "id" : "Medication.extension:MedicationSafetyListMedicine",
      "path" : "Medication.extension",
      "sliceName" : "MedicationSafetyListMedicine",
      "short" : "Safety list medicine flag",
      "definition" : "Indicates whether this medication is on a PHARMAC safety list.",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-safety-list-medicine"]
      }]
    },
    {
      "id" : "Medication.identifier",
      "path" : "Medication.identifier",
      "slicing" : {
        "discriminator" : [{
          "type" : "value",
          "path" : "system"
        }],
        "description" : "Slice based on identifier system",
        "rules" : "open"
      },
      "min" : 3,
      "mustSupport" : true
    },
    {
      "id" : "Medication.identifier:pharmaCode",
      "path" : "Medication.identifier",
      "sliceName" : "pharmaCode",
      "short" : "PHARMAC code",
      "definition" : "The unique PHARMAC code for this medication - commonly referred to as PharmaCode - superseeded by NZMT.",
      "min" : 0,
      "max" : "1",
      "mustSupport" : true
    },
    {
      "id" : "Medication.identifier:pharmaCode.system",
      "path" : "Medication.identifier.system",
      "min" : 1,
      "fixedUri" : "http://schedule.pharmac.govt.nz/ids/pharmacode"
    },
    {
      "id" : "Medication.identifier:pharmaCode.value",
      "path" : "Medication.identifier.value",
      "min" : 1
    },
    {
      "id" : "Medication.identifier:brandId",
      "path" : "Medication.identifier",
      "sliceName" : "brandId",
      "short" : "PHARMAC brand identifier",
      "definition" : "The unique PHARMAC brand code for this medication",
      "min" : 1,
      "max" : "1",
      "mustSupport" : true
    },
    {
      "id" : "Medication.identifier:brandId.system",
      "path" : "Medication.identifier.system",
      "min" : 1,
      "fixedUri" : "http://schedule.pharmac.govt.nz/ids/brand"
    },
    {
      "id" : "Medication.identifier:brandId.value",
      "path" : "Medication.identifier.value",
      "min" : 1
    },
    {
      "id" : "Medication.identifier:packId",
      "path" : "Medication.identifier",
      "sliceName" : "packId",
      "short" : "PHARMAC pack identifier",
      "definition" : "The unique PHARMAC pack code for this specific pack size/formulation",
      "min" : 1,
      "max" : "1",
      "mustSupport" : true
    },
    {
      "id" : "Medication.identifier:packId.system",
      "path" : "Medication.identifier.system",
      "min" : 1,
      "fixedUri" : "http://schedule.pharmac.govt.nz/ids/pack"
    },
    {
      "id" : "Medication.identifier:packId.value",
      "path" : "Medication.identifier.value",
      "min" : 1
    },
    {
      "id" : "Medication.identifier:chemicalId",
      "path" : "Medication.identifier",
      "sliceName" : "chemicalId",
      "short" : "PHARMAC chemical identifier",
      "definition" : "The unique PHARMAC code for the chemical substance (e.g., 'C0104041168')",
      "min" : 0,
      "max" : "1",
      "mustSupport" : true
    },
    {
      "id" : "Medication.identifier:chemicalId.system",
      "path" : "Medication.identifier.system",
      "min" : 1,
      "fixedUri" : "http://schedule.pharmac.govt.nz/ids/chemical"
    },
    {
      "id" : "Medication.identifier:chemicalId.value",
      "path" : "Medication.identifier.value",
      "min" : 1
    },
    {
      "id" : "Medication.identifier:formulationId",
      "path" : "Medication.identifier",
      "sliceName" : "formulationId",
      "short" : "PHARMAC formulation identifier",
      "definition" : "The unique PHARMAC code for this formulation (e.g., 'F010404116809')",
      "min" : 0,
      "max" : "1",
      "mustSupport" : true
    },
    {
      "id" : "Medication.identifier:formulationId.system",
      "path" : "Medication.identifier.system",
      "min" : 1,
      "fixedUri" : "http://schedule.pharmac.govt.nz/ids/formulation"
    },
    {
      "id" : "Medication.identifier:formulationId.value",
      "path" : "Medication.identifier.value",
      "min" : 1
    },
    {
      "id" : "Medication.code",
      "path" : "Medication.code",
      "min" : 1,
      "mustSupport" : true,
      "binding" : {
        "strength" : "extensible",
        "description" : "Codes for medications from NZMT CTPP, PackID, and SNOMED CT",
        "valueSet" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ValueSet/pharmac-medication-code"
      }
    },
    {
      "id" : "Medication.code.text",
      "path" : "Medication.code.text",
      "short" : "Brand name of the medication",
      "definition" : "The marketed name or brand name of the medication (e.g., 'Gaviscon Infant', 'Acidex', 'Alu-Tab')",
      "min" : 1,
      "mustSupport" : true
    },
    {
      "id" : "Medication.status",
      "path" : "Medication.status",
      "short" : "Active status for scheduled medications",
      "definition" : "All medications in the PHARMAC schedule are active",
      "min" : 1,
      "fixedCode" : "active",
      "mustSupport" : true
    },
    {
      "id" : "Medication.form",
      "path" : "Medication.form",
      "min" : 1,
      "mustSupport" : true
    },
    {
      "id" : "Medication.form.text",
      "path" : "Medication.form.text",
      "short" : "Dosage form (e.g., 'tablet', 'oral liquid', 'sachet')",
      "definition" : "The pharmaceutical dosage form of the medication"
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
        "description" : "Codes for medication ingredients from NZMT CTPP, PackID, and SNOMED CT",
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
