# PHARMAC Charge Item Definition - Special Authority - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **PHARMAC Charge Item Definition - Special Authority**

## Resource Profile: PHARMAC Charge Item Definition - Special Authority 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority | *Version*:1.0.1 |
| Active as of 2026-03-25 | *Computable Name*:PharmacChargeItemDefinitionSpecialAuthority |

 
Profile for ChargeItemDefinition resources representing Special Authorization (SA) requirements and clinical eligibility criteria in the PHARMAC schedule. This profile captures SA codes, authorization case counts, clinical eligibility, and references to medications requiring special authorization. 

 
To define the structure for PHARMAC Special Authorization requirements including SA codes, clinical eligibility criteria, approval pathways, and authorization case counts. 

### Overview

The **PHARMAC Charge Item Definition - Special Authority** profile captures Special Authorization (SA) requirements and clinical eligibility criteria for medications in the PHARMAC schedule. Each instance represents a single SA form with its associated authorization cases — the distinct clinical scenarios under which a medication may be approved for subsidy.

### When to use this profile

Use this profile when a medication requires Special Authority approval before it can be subsidised. The profile captures:

* The SA form code (e.g., SA2139, SA2520)
* The number of authorization cases
* Clinical eligibility criteria for each case
* An optional inline JSON Schema that defines the structure and validation rules for the SA application form

### Key constraints (vs. base profile)

| | |
| :--- | :--- |
| `code` | **Required**(1..1) — must contain the SA code (e.g.,`SA2139`). |
| `authorizationCaseCount` | **Required**(1..1) — the number of authorization cases. |
| `instance` | **Required**(1..*) — references to medications requiring this SA. |
| `propertyGroup.priceComponent` | **Prohibited**(0..0) — SA definitions don't carry pricing. |
| Pricing extensions (`costBrandSource`,`contractType`, etc.) | **Prohibited**(0..0). |

### Authorization schema

The `authorizationSchema` extension allows the SA's application form structure to be included directly in the resource as a base64-encoded JSON Schema. This means API clients receive the form definition in a single request — no additional calls needed.

Clients should:

1. Read the`valueBase64Binary`value
1. Base64-decode it to obtain a JSON Schema (draft-07)
1. Use the schema for form rendering and input validation

For a detailed walkthrough of JSON Schema patterns and examples, see the [JSON Schema for SAs Guide](sa-json-schema-guide.md).

The schema uses `oneOf` to define the distinct authorization cases. Each case specifies required prerequisites and any conditional fields. For example, SA2139 has 7 cases (Confirmed HIV initial/renewal, maternal transmission, PEP initial/renewal, percutaneous initial/renewal) while SA2520 has 4 cases (PrEP initial/renewal, PEP initial/renewal).

**Approach:** The `authorizationSchema` extension contains a Base64-encoded JSON Schema that defines the application form structure. The schema uses `oneOf` to represent distinct authorization cases, with each case specifying:

* Required fields (e.g., diagnosis, treatment date, prescriber credentials)
* Conditional fields and validation rules
* Field types and constraints

Clients decode the schema to dynamically generate and validate authorization application forms.

### Examples

* [SA9999 — Example Template](ChargeItemDefinition-ChargeItemDefinition-SA9999-Authorization.md): Demonstration schema showing different validation patterns (text, numeric ranges, boolean checkboxes, conditional fields). For reference and developer guidance.

### Typical search patterns

To retrieve special authorities for a specific medication:

```
GET /Medication?identifier=http://schedule.pharmac.govt.nz/ids/pack|1234
    &_revinclude=ChargeItemDefinition:instance

```

The returned Bundle will include the Medication along with all ChargeItemDefinition resources — pricing, funding rules, and special authorities — that reference it. The SA instances will be identifiable by the presence of a `code` element with the SA code.

**Usages:**

* Examples for this Profile: [ChargeItemDefinition/ChargeItemDefinition-SA9999-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA9999-Authorization.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/pharmac-charge-item-definition-special-authority)

### Formal Views of Profile Content

 [Description of Profiles, Differentials, Snapshots and how the different presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-pharmac-charge-item-definition-special-authority.csv), [Excel](StructureDefinition-pharmac-charge-item-definition-special-authority.xlsx), [Schematron](StructureDefinition-pharmac-charge-item-definition-special-authority.sch) 



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "pharmac-charge-item-definition-special-authority",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority",
  "version" : "1.0.1",
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
