# PHARMAC Charge Item Definition - Funding Rules - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **PHARMAC Charge Item Definition - Funding Rules**

## Resource Profile: PHARMAC Charge Item Definition - Funding Rules 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules | *Version*:1.1.0 |
| Active as of 2026-03-25 | *Computable Name*:PharmacChargeItemDefinitionFundingRules |

 
Profile for ChargeItemDefinition resources representing funding mechanisms and reimbursement rules in the PHARMAC schedule. This profile captures funding conditions, provider requirements, endorsement criteria, case sequences, and funding mechanism types (Prescription, BSO, Rural PSO, etc.). 

 
To define the structure for PHARMAC funding mechanisms and reimbursement rules including case sequences, provider conditions, endorsement requirements, and eligibility criteria. 

### Overview

The **PHARMAC Charge Item Definition - Funding Rules** profile represents a funding or reimbursement rule record for a scheduled product.

Each instance represents one funding case for a product, such as a community or hospital case. A product may have multiple Funding Rules records where different funding contexts or case sequences apply.

### Profile

| | |
| :--- | :--- |
| FSH profile name | `PharmacChargeItemDefinitionFundingRules` |
| StructureDefinition id | `pharmac-charge-item-definition-funding-rules` |
| Parent profile | `PharmacChargeItemDefinition` |
| FHIR resource | `ChargeItemDefinition` |

### Key elements

| | |
| :--- | :--- |
| `id` | Resource identifier for the funding rules record |
| `meta.profile` | Declares conformance to`pharmac-charge-item-definition-funding-rules` |
| `url` | Canonical identifier for the funding rules definition |
| `version` | Business version of the definition |
| `status` | Publication status |
| `date` | Date the definitional resource was created or revised |
| `description` | Human-readable description of the funding case |
| `instance` | Reference to the associated`Medication` |
| `pricing-effective-date` | Date from which the funding rules record applies |
| `funding-rule` | Funding context, case sequence, and funding mechanism information |
| `funding-subsidy-amount` | Subsidy type, status, amount, and display text |
| `schedule-funding-attributes` | Grouped Schedule funding attributes |
| `authorization-schema` | Structured condition information where the funding case has conditions |
| `applicability.description` | Human-readable summary of the funding case |

### Funding rule context

The `funding-rule` extension identifies the funding context represented by the record. It can include:

* funding type, such as `community` or `hospital`;
* case sequence; and
* funding mechanism, such as `Prescription`.

### Subsidy and Schedule attributes

Subsidy information is represented using `funding-subsidy-amount`.

Additional Schedule attributes are grouped under `schedule-funding-attributes`. These can include contract, dispensing, co-payment, product multiple, original pack, and related indicators.

### Effective date

The effective date is represented using the `pricing-effective-date` extension.

```
* extension[effectiveDate].valueDate = "2026-04-24"

```

`ChargeItemDefinition.date` and the effective-date extension have different purposes. `date` records when the definitional resource was created or revised, while the effective-date extension records when the funding rules apply.

### Example

For further information about condition schemas carried by Funding Rules records, see [JSON Schema for Funding Rules](fr-json-schema-guide.md).

**Usages:**

* Examples for this Profile: [ChargeItemDefinition/ChargeItemDefinition-50003171000117108-Hospital-Case-7](ChargeItemDefinition-ChargeItemDefinition-50003171000117108-Hospital-Case-7.md), [ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-3.md)... Show 46 more, [ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-4.md), [ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50021721000117104-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50021721000117104-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50021721000117104-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50021721000117104-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50038111000117102-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50038111000117102-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50038111000117102-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50038111000117102-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-4.md), [ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-4.md), [ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50055641000117102-Hospital-Case-7](ChargeItemDefinition-ChargeItemDefinition-50055641000117102-Hospital-Case-7.md), [ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Community-Case-4.md), [ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50074861000117103-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50074861000117103-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50074861000117103-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50074861000117103-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50083491000117102-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50083491000117102-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50083491000117102-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50083491000117102-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50085781000117107-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50085781000117107-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50085781000117107-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50085781000117107-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50085781000117107-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50085781000117107-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50085781000117107-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50085781000117107-Community-Case-4.md), [ChargeItemDefinition/ChargeItemDefinition-50085781000117107-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50085781000117107-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50120021000117104-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50120021000117104-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50120021000117104-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50120021000117104-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50120021000117104-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50120021000117104-Community-Case-3.md) and [ChargeItemDefinition/ChargeItemDefinition-50120021000117104-Hospital-Case-7](ChargeItemDefinition-ChargeItemDefinition-50120021000117104-Hospital-Case-7.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/resource/pharmac.fhir.pharmac-schedules|current/StructureDefinition/StructureDefinition-pharmac-charge-item-definition-funding-rules.json)

### Formal Views of Profile Content

 [Description of Profiles, Differentials, Snapshots and how the different presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-pharmac-charge-item-definition-funding-rules.csv), [Excel](StructureDefinition-pharmac-charge-item-definition-funding-rules.xlsx), [Schematron](StructureDefinition-pharmac-charge-item-definition-funding-rules.sch) 



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "pharmac-charge-item-definition-funding-rules",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules",
  "version" : "1.1.0",
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
      "id" : "ChargeItemDefinition.extension:fundingSubsidyAmount",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "fundingSubsidyAmount",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:scheduleFundingAttributes",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "scheduleFundingAttributes",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:scheduleFundingAttributes.extension:productMultiple",
      "path" : "ChargeItemDefinition.extension.extension",
      "sliceName" : "productMultiple",
      "short" : "Product multiple applies",
      "definition" : "Indicates whether this pack uses product multiples when calculating pricing or claims."
    },
    {
      "id" : "ChargeItemDefinition.extension:scheduleFundingAttributes.extension:productMultiplier",
      "path" : "ChargeItemDefinition.extension.extension",
      "sliceName" : "productMultiplier",
      "short" : "Product multiplier value",
      "definition" : "Numeric multiplier applied when calculating pricing or claims for this pack."
    },
    {
      "id" : "ChargeItemDefinition.extension:scheduleFundingAttributes.extension:originalPack",
      "path" : "ChargeItemDefinition.extension.extension",
      "sliceName" : "originalPack",
      "short" : "Original pack flag",
      "definition" : "Indicates whether this pack represents the original pack supplied by the manufacturer."
    },
    {
      "id" : "ChargeItemDefinition.extension:scheduleFundingAttributes.extension:safetyListMedicine",
      "path" : "ChargeItemDefinition.extension.extension",
      "sliceName" : "safetyListMedicine",
      "short" : "Safety list medicine flag",
      "definition" : "Indicates whether this medication is on a PHARMAC safety list."
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
