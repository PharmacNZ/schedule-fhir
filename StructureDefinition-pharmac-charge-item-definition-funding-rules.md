# PHARMAC Charge Item Definition - Funding Rules - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **PHARMAC Charge Item Definition - Funding Rules**

## Resource Profile: PHARMAC Charge Item Definition - Funding Rules 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules | *Version*:1.0.1 |
| Active as of 2026-03-25 | *Computable Name*:PharmacChargeItemDefinitionFundingRules |

 
Profile for ChargeItemDefinition resources representing funding mechanisms and reimbursement rules in the PHARMAC schedule. This profile captures funding conditions, provider requirements, endorsement criteria, case sequences, and funding mechanism types (Prescription, BSO, Rural PSO, etc.). 

 
To define the structure for PHARMAC funding mechanisms and reimbursement rules including case sequences, provider conditions, endorsement requirements, and eligibility criteria. 

### Overview

The **PHARMAC Charge Item Definition - Funding Rules** profile captures funding mechanisms and reimbursement rules for medications and devices in the PHARMAC schedule. Each instance represents a single funding "case" — a specific combination of dispensary type, funding mechanism, case sequence, and associated conditions.

### When to use this profile

Use this profile when you need to represent how a medication or device is funded. A single product may have multiple funding rule instances, each representing a different funding pathway. For example, Leuprorelin (Lucrin Depot) has five cases:

1. **Community pharmacy — Prescription**(Case Sequence 1): with endorsement and provider conditions
1. **Community pharmacy — Prescription**(Case Sequence 2): with provider condition only
1. **Community pharmacy — BSO**(Case Sequence 1): for hospital care operator prescriptions
1. **Community pharmacy — Rural PSO**(Case Sequence 1): for authorised prescribers
1. **Hospital**(Case Sequence 1): default condition, zero reimbursement

### Key constraints (vs. base profile)

| | | | |
| :--- | :--- | :--- | :--- |
| `code` | **Prohibited**(0..0) — SA codes are not relevant to funding rules. |   |   |
| `authorizationForm`,`authorizationTitle`,`authorizationCaseCount` | **Prohibited**(0..0) — authorization extensions are not used. |   |   |
| Pricing extensions (`costBrandSource`,`contractType`, etc.) | **Prohibited**(0..0) — pricing attributes belong on the Pricing profile. |   |   |
| `fundingRule` | **Required**(1..*) — at least one funding rule must be specified. |   |   |
| <!– | `applicability` | **Required**(1..*) — conditions for when this funding applies. | –> |

### Funding rule extension structure

The `fundingRule` complex extension contains:

| | | |
| :--- | :--- | :--- |
| `type` | code | Dispensary type — typically`community`or`hospital`. |
| `rule[].type` | code | Rule type — common values:`CaseSequence`,`FundingMechanism`. |
| `rule[].value` | integer | Numeric value, e.g., the case sequence number (1, 2, etc.). |
| `rule[].attribute` | code | Attribute code, e.g.,`Prescription`,`BSO`,`RuralPSO`. |

### Applicability conditions

**Approach:** Each funding rule instance includes an `authorizationSchema` extension containing a Base64-encoded JSON Schema that defines:

* **Provider conditions** — e.g., validation that prescription is from an authorised prescriber
* **Endorsement conditions** — e.g., required form fields for endorsement scenarios (patient is a child/adolescent, specific intolerance documented)
* **Case scenarios** — using `oneOf` to define distinct case structures

API clients should:

1. Base64-decode the`authorizationSchema`value
1. Use the resulting JSON Schema for client-side form validation
1. Validate submitted data against the schema before submission

**For detailed examples and explanation of funding rule schemas, see the [JSON Schema for Funding Rules guide](fr-json-schema-guide.md).**

### Reimbursement amounts

The optional `propertyGroup` contains the subsidy or reimbursement amount for this funding case. When present, the `priceComponent` uses:

* **type**: `discount` (representing the PHARMAC subsidy)
* **amount**: The reimbursement amount in NZD (may be `0` for hospital cases with no reimbursement)

### Examples

* [Clexane Case 1](ChargeItemDefinition-ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1.md): Special Authority (SA9999) required + Authorised Providers
* [Clexane Case 2](ChargeItemDefinition-ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2.md): PRIME service endorsement + Authorised Providers
* [Clexane Case 3](ChargeItemDefinition-ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-3.md): Hospital use only

**Usages:**

* Examples for this Profile: [ChargeItemDefinition/ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1](ChargeItemDefinition-ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2](ChargeItemDefinition-ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2.md) and [ChargeItemDefinition/ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-3](ChargeItemDefinition-ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-3.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/pharmac-charge-item-definition-funding-rules)

### Formal Views of Profile Content

 [Description of Profiles, Differentials, Snapshots and how the different presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-pharmac-charge-item-definition-funding-rules.csv), [Excel](StructureDefinition-pharmac-charge-item-definition-funding-rules.xlsx), [Schematron](StructureDefinition-pharmac-charge-item-definition-funding-rules.sch) 



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "pharmac-charge-item-definition-funding-rules",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules",
  "version" : "1.0.1",
  "name" : "PharmacChargeItemDefinitionFundingRules",
  "title" : "PHARMAC Charge Item Definition - Funding Rules",
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
  "description" : "Profile for ChargeItemDefinition resources representing funding mechanisms and reimbursement rules in the PHARMAC schedule. This profile captures funding conditions, provider requirements, endorsement criteria, case sequences, and funding mechanism types (Prescription, BSO, Rural PSO, etc.).",
  "purpose" : "To define the structure for PHARMAC funding mechanisms and reimbursement rules including case sequences, provider conditions, endorsement requirements, and eligibility criteria.",
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
      "min" : 2
    },
    {
      "id" : "ChargeItemDefinition.extension:effectiveDate",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "effectiveDate",
      "short" : "Effective date for this funding rule",
      "definition" : "The date from which this funding rule becomes effective"
    },
    {
      "id" : "ChargeItemDefinition.extension:expiryDate",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "expiryDate",
      "short" : "Expiry date for this funding rule",
      "definition" : "The date on which this funding rule expires (optional)"
    },
    {
      "id" : "ChargeItemDefinition.extension:authorizationForm",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "authorizationForm",
      "max" : "0"
    },
    {
      "id" : "ChargeItemDefinition.extension:authorizationTitle",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "authorizationTitle",
      "max" : "0"
    },
    {
      "id" : "ChargeItemDefinition.extension:authorizationCaseCount",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "authorizationCaseCount",
      "max" : "0"
    },
    {
      "id" : "ChargeItemDefinition.extension:deviceDefinition",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "deviceDefinition",
      "definition" : "Reference to the DeviceDefinition that these funding rules apply to"
    },
    {
      "id" : "ChargeItemDefinition.extension:fundingRule",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "fundingRule",
      "short" : "Funding rules and conditions (REQUIRED)",
      "definition" : "Funding rules that define conditions, restrictions, case sequences, and funding mechanism types (e.g., Prescription, BSO, Rural PSO). This is the primary defining characteristic of this profile.",
      "min" : 1
    },
    {
      "id" : "ChargeItemDefinition.extension:fundingRule.extension:type",
      "path" : "ChargeItemDefinition.extension.extension",
      "sliceName" : "type",
      "short" : "Funding type (e.g., community, hospital)",
      "definition" : "The type of funding context - typically 'community' or 'hospital'"
    },
    {
      "id" : "ChargeItemDefinition.extension:fundingRule.extension:rule",
      "path" : "ChargeItemDefinition.extension.extension",
      "sliceName" : "rule",
      "short" : "Specific funding rules",
      "definition" : "Array of specific funding rules including case sequences, funding mechanisms, and other conditions"
    },
    {
      "id" : "ChargeItemDefinition.extension:fundingRule.extension:rule.extension:type",
      "path" : "ChargeItemDefinition.extension.extension.extension",
      "sliceName" : "type",
      "short" : "Rule type (e.g., CaseSequence, FundingMechanism)",
      "definition" : "The type of funding rule - common types include CaseSequence (ordered case number), FundingMechanism (Prescription, BSO, RuralPSO)"
    },
    {
      "id" : "ChargeItemDefinition.extension:fundingRule.extension:rule.extension:value",
      "path" : "ChargeItemDefinition.extension.extension.extension",
      "sliceName" : "value",
      "short" : "Rule value (e.g., case sequence number)",
      "definition" : "Numeric value associated with the funding rule, such as the case sequence number (1, 2, etc.)"
    },
    {
      "id" : "ChargeItemDefinition.extension:fundingRule.extension:rule.extension:attribute",
      "path" : "ChargeItemDefinition.extension.extension.extension",
      "sliceName" : "attribute",
      "short" : "Rule attribute (e.g., Prescription, BSO, RuralPSO)",
      "definition" : "Attribute code that qualifies the rule type, such as the specific funding mechanism"
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
      "short" : "Optional JSON schema for authorization/funding validation",
      "definition" : "Base64-encoded JSON schema document that describes the structured format for funding/authorization case submissions.",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.url",
      "path" : "ChargeItemDefinition.url",
      "short" : "Canonical identifier for this funding rule definition",
      "definition" : "Unique canonical URL for this funding rule definition"
    },
    {
      "id" : "ChargeItemDefinition.title",
      "path" : "ChargeItemDefinition.title",
      "short" : "Funding mechanism name"
    },
    {
      "id" : "ChargeItemDefinition.description",
      "path" : "ChargeItemDefinition.description",
      "short" : "Description of funding rules and conditions"
    },
    {
      "id" : "ChargeItemDefinition.code",
      "path" : "ChargeItemDefinition.code",
      "short" : "Not used for funding rule definitions",
      "max" : "0"
    },
    {
      "id" : "ChargeItemDefinition.instance",
      "path" : "ChargeItemDefinition.instance",
      "definition" : "Optional references to specific Medication or Device resources that these funding rules apply to. May be absent for generic funding mechanism definitions."
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup",
      "path" : "ChargeItemDefinition.propertyGroup",
      "short" : "Subsidy/reimbursement amounts (optional)",
      "definition" : "Optional group of pricing properties that specify the subsidy or reimbursement amount for this funding mechanism. Typically contains a single priceComponent of type 'discount' representing the PHARMAC subsidy."
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.applicability",
      "path" : "ChargeItemDefinition.propertyGroup.applicability",
      "definition" : "Description of when this funding amount applies (e.g., 'Case 1 - community pharmacy prescription')"
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent",
      "short" : "Subsidy/reimbursement amount",
      "definition" : "The subsidy or reimbursement amount for this funding mechanism. Typically a single component of type 'discount' with code.text 'PHARMAC Subsidy'"
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.type",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.type",
      "short" : "Type of price component (typically 'discount' for subsidy)",
      "definition" : "For funding rules, this is typically 'discount' to represent a subsidy or reimbursement amount"
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.code",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.code",
      "short" : "Code or label for subsidy",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.code.text",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.code.text",
      "short" : "Text label (e.g., 'PHARMAC Subsidy')",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.amount",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.amount",
      "short" : "Subsidy/reimbursement amount",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.amount.value",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.amount.value",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.amount.currency",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.amount.currency",
      "patternCode" : "NZD",
      "mustSupport" : true
    }]
  }
}

```
