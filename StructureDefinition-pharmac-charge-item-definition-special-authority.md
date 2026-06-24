# PHARMAC Charge Item Definition - Special Authority - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **PHARMAC Charge Item Definition - Special Authority**

## Resource Profile: PHARMAC Charge Item Definition - Special Authority 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority | *Version*:1.1.0 |
| Active as of 2026-03-25 | *Computable Name*:PharmacChargeItemDefinitionSpecialAuthority |

 
Profile for ChargeItemDefinition resources representing Special Authorization (SA) requirements and clinical eligibility criteria in the PHARMAC schedule. This profile captures SA codes, authorization case counts, clinical eligibility, and references to medications requiring special authorization. 

 
To define the structure for PHARMAC Special Authorization requirements including SA codes, clinical eligibility criteria, approval pathways, and authorization case counts. 

### Overview

The **PHARMAC Charge Item Definition - Special Authority** profile represents a Special Authority form definition published as part of the PHARMAC Schedule API.

A Special Authority definition is kept separate from the Funding Rules record that may refer to it. This allows the same SA definition to be associated with more than one scheduled product where applicable.

### Profile

| | |
| :--- | :--- |
| FSH profile name | `PharmacChargeItemDefinitionSpecialAuthority` |
| StructureDefinition id | `pharmac-charge-item-definition-special-authority` |
| Parent profile | `PharmacChargeItemDefinition` |
| FHIR resource | `ChargeItemDefinition` |

### Key elements

| | |
| :--- | :--- |
| `id` | Resource identifier for the Special Authority definition |
| `meta.profile` | Declares conformance to`pharmac-charge-item-definition-special-authority` |
| `url` | Canonical identifier for the definition |
| `version` | Business version of the definition |
| `status` | Publication status |
| `date` | Date the definitional resource was created or revised |
| `description` | Human-readable summary of the Special Authority definition |
| `code` | Special Authority code, such as`SA1098` |
| `instance` | Reference to an associated`Medication`, where applicable |
| `pricing-effective-date` | Date from which the definition applies |
| `authorization-form` | Special Authority form identifier |
| `authorization-case-count` | Number of application pathways represented by the definition |
| `authorization-schema` | Structured Special Authority form content |

### Special Authority identifier

The Special Authority code is represented in `ChargeItemDefinition.code` and repeated in the `authorization-form` extension.

Example:

```
{
  "code": {
    "coding": [
      {
        "system": "http://pharmac.govt.nz/fhir/sa",
        "code": "SA1098"
      }
    ],
    "text": "SA1098"
  }
}

```

### Relationship to funding rules

A Funding Rules record may indicate that a Special Authority applies. The Funding Rules record and the Special Authority definition remain separate `ChargeItemDefinition` resources and are related by the SA identifier and, where applicable, their references to the same `Medication`.

The relationship is described in more detail on the [Resource Relationships](relationships.md) page.

### Example

For further information about the structured form content, see [JSON Schema for Special Authorities](sa-json-schema-guide.md).

**Usages:**

* Examples for this Profile: [ChargeItemDefinition/ChargeItemDefinition-SA1098-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA1098-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA1329-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA1329-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA1683-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA1683-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2139-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2139-Authorization.md)... Show 6 more, [ChargeItemDefinition/ChargeItemDefinition-SA2185-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2185-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2453-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2453-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2536-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2536-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2561-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2561-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2620-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2620-Authorization.md) and [ChargeItemDefinition/ChargeItemDefinition-SA2628-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2628-Authorization.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/resource/pharmac.fhir.pharmac-schedules|current/StructureDefinition/StructureDefinition-pharmac-charge-item-definition-special-authority.json)

### Formal Views of Profile Content

 [Description of Profiles, Differentials, Snapshots and how the different presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-pharmac-charge-item-definition-special-authority.csv), [Excel](StructureDefinition-pharmac-charge-item-definition-special-authority.xlsx), [Schematron](StructureDefinition-pharmac-charge-item-definition-special-authority.sch) 



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "pharmac-charge-item-definition-special-authority",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority",
  "version" : "1.1.0",
  "name" : "PharmacChargeItemDefinitionSpecialAuthority",
  "title" : "PHARMAC Charge Item Definition - Special Authority",
  "status" : "active",
  "date" : "2026-03-25",
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
  "description" : "Profile for ChargeItemDefinition resources representing Special Authorization (SA) requirements and clinical eligibility criteria in the PHARMAC schedule. This profile captures SA codes, authorization case counts, clinical eligibility, and references to medications requiring special authorization.",
  "purpose" : "To define the structure for PHARMAC Special Authorization requirements including SA codes, clinical eligibility criteria, approval pathways, and authorization case counts.",
  "fhirVersion" : "4.0.1",
  "mapping" : [{
    "identity" : "rim",
    "uri" : "http://hl7.org/v3",
    "name" : "RIM Mapping"
  },
  {
    "identity" : "workflow",
    "uri" : "http://hl7.org/fhir/workflow",
    "name" : "Workflow Pattern"
  },
  {
    "identity" : "w5",
    "uri" : "http://hl7.org/fhir/fivews",
    "name" : "FiveWs Pattern Mapping"
  },
  {
    "identity" : "objimpl",
    "uri" : "http://hl7.org/fhir/object-implementation",
    "name" : "Object Implementation Information"
  }],
  "kind" : "resource",
  "abstract" : false,
  "type" : "ChargeItemDefinition",
  "baseDefinition" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition",
  "derivation" : "constraint",
  "differential" : {
    "element" : [{
      "id" : "ChargeItemDefinition",
      "path" : "ChargeItemDefinition"
    },
    {
      "id" : "ChargeItemDefinition.extension",
      "path" : "ChargeItemDefinition.extension",
      "min" : 3
    },
    {
      "id" : "ChargeItemDefinition.extension:effectiveDate",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "effectiveDate",
      "short" : "Effective date for this special authorization",
      "definition" : "The date from which this special authorization becomes effective"
    },
    {
      "id" : "ChargeItemDefinition.extension:expiryDate",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "expiryDate",
      "short" : "Expiry date for this special authorization",
      "definition" : "The date on which this special authorization expires (optional)"
    },
    {
      "id" : "ChargeItemDefinition.extension:authorizationForm",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "authorizationForm",
      "definition" : "The PHARMAC special authorization form code (e.g., 'SA2139', 'SA2520') - may duplicate the code element for consistency"
    },
    {
      "id" : "ChargeItemDefinition.extension:authorizationTitle",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "authorizationTitle",
      "definition" : "A human-readable title describing the authorization requirement (e.g., 'Tenofovir Disoproxil Emtricitabine Viatr - Special Authorization Required')"
    },
    {
      "id" : "ChargeItemDefinition.extension:authorizationCaseCount",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "authorizationCaseCount",
      "short" : "Number of authorization cases (REQUIRED)",
      "definition" : "The count of distinct authorization approval criteria or clinical scenarios defined in this special authorization. This indicates how many different applicability rules will be present.",
      "min" : 1
    },
    {
      "id" : "ChargeItemDefinition.extension:deviceDefinition",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "deviceDefinition",
      "definition" : "Reference to DeviceDefinition resources that require this special authorization"
    },
    {
      "id" : "ChargeItemDefinition.extension:fundingRule",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "fundingRule",
      "short" : "Optional funding context",
      "definition" : "Optional funding rules for context (e.g., community funding, case sequence). The primary focus is on authorization criteria rather than funding mechanisms."
    },
    {
      "id" : "ChargeItemDefinition.extension:costBrandSource",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "costBrandSource",
      "max" : "0"
    },
    {
      "id" : "ChargeItemDefinition.extension:wastageClaimable",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "wastageClaimable",
      "max" : "0"
    },
    {
      "id" : "ChargeItemDefinition.extension:contractType",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "contractType",
      "max" : "0"
    },
    {
      "id" : "ChargeItemDefinition.extension:dvLimitPercent",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "dvLimitPercent",
      "max" : "0"
    },
    {
      "id" : "ChargeItemDefinition.extension:brandSwitchFee",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "brandSwitchFee",
      "max" : "0"
    },
    {
      "id" : "ChargeItemDefinition.extension:statim",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "statim",
      "max" : "0"
    },
    {
      "id" : "ChargeItemDefinition.extension:inCombination",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "inCombination",
      "max" : "0"
    },
    {
      "id" : "ChargeItemDefinition.extension:authorizationSchema",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "authorizationSchema",
      "short" : "JSON Schema for this SA form",
      "definition" : "Base64-encoded JSON Schema (application/schema+json) that defines the structure and validation rules for this Special Authority application form. Clients should base64-decode the value and use the resulting JSON Schema for form rendering and input validation.",
      "min" : 1,
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.url",
      "path" : "ChargeItemDefinition.url",
      "short" : "Canonical identifier for this special authorization definition",
      "definition" : "Unique canonical URL for this special authorization definition"
    },
    {
      "id" : "ChargeItemDefinition.title",
      "path" : "ChargeItemDefinition.title",
      "short" : "Special authorization name"
    },
    {
      "id" : "ChargeItemDefinition.description",
      "path" : "ChargeItemDefinition.description",
      "short" : "Description of special authorization requirements"
    },
    {
      "id" : "ChargeItemDefinition.code",
      "path" : "ChargeItemDefinition.code",
      "short" : "Special Authorization code (REQUIRED)",
      "definition" : "The Special Authorization code that identifies this authorization requirement (e.g., SA2139, SA2520, SA2535)",
      "min" : 1
    },
    {
      "id" : "ChargeItemDefinition.code.coding",
      "path" : "ChargeItemDefinition.code.coding",
      "short" : "Coded SA identifier",
      "min" : 1,
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.code.coding.system",
      "path" : "ChargeItemDefinition.code.coding.system",
      "short" : "PHARMAC SA code system",
      "definition" : "The code system for PHARMAC Special Authorization codes (typically 'http://pharmac.govt.nz/fhir/sa')",
      "min" : 1,
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.code.coding.code",
      "path" : "ChargeItemDefinition.code.coding.code",
      "short" : "SA code (e.g., SA2139, SA2520)",
      "definition" : "The specific Special Authorization code",
      "min" : 1,
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.code.text",
      "path" : "ChargeItemDefinition.code.text",
      "short" : "SA code text representation",
      "definition" : "Text representation of the SA code (e.g., 'SA2139')",
      "min" : 1,
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.instance",
      "path" : "ChargeItemDefinition.instance",
      "short" : "Medications/devices requiring this special authorization (REQUIRED)",
      "definition" : "Direct references to Medication or Device resources that require this special authorization. At least one instance must be specified. Multiple instances indicate that the same SA applies to multiple medications (e.g., SA2139 applies to both Ricovir and Viramune).",
      "min" : 1
    }]
  }
}

```
