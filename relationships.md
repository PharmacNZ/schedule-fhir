# Relationships - Pharmac Schedules FHIR API v1.0.0

* [**Table of Contents**](toc.md)
* **Relationships**

## Relationships

# Medication and ChargeItemDefinition Relationships

## Overview

The PHARMAC Schedule Implementation Guide uses a sophisticated relationship model to represent medications, devices, and their associated pricing, authorization requirements, and funding rules. This page explains the relationships between these resources and how to query them effectively.

## Core Relationship Model

The relationship between Medications and ChargeItemDefinitions is fundamental to the PHARMAC Schedule API:

```
Medication ←→ ChargeItemDefinition (multiple types)
    ├── Product Pricing ChargeItemDefinition
    ├── Special Authorization ChargeItemDefinition
    └── Funding Mechanism ChargeItemDefinition(s)

```

### Key Principles

1. **One Medication, Multiple ChargeItemDefinitions**: A single Medication resource may have multiple ChargeItemDefinition resources associated with it, each representing different aspects:
* Product pricing information
* Special authorization requirements
* Different funding mechanism scenarios

1. **ChargeItemDefinition References Medication**: ChargeItemDefinitions reference Medication resources via the `instance` element, establishing the relationship from pricing/authorization back to the product.
1. **Search with _revinclude**: The API supports`_revinclude=ChargeItemDefinition:instance`to retrieve all related ChargeItemDefinitions alongside Medication resources in a single query.

## ChargeItemDefinition Types

The PHARMAC Schedule Implementation Guide defines three specialized ChargeItemDefinition profiles to represent distinct types of information:

1. **PharmacChargeItemDefinitionPricing**- Product pricing information
1. **PharmacChargeItemDefinitionSpecialAuthority**- Special authorization requirements
1. **PharmacChargeItemDefinitionFundingRules**- Funding mechanisms and reimbursement rules

Each profile has specific constraints and required elements appropriate to its purpose.

### Product Pricing ChargeItemDefinition (PharmacChargeItemDefinitionPricing)

Represents the base pricing information for a medication or device.

**Profile:** `PharmacChargeItemDefinitionPricing`

**Key Characteristics:**

* Contains `propertyGroup` with `priceComponent` elements (REQUIRED)
* Includes pricing attributes via extensions (costBrandSource, wastageClaimable, contractType, dvLimitPercent, brandSwitchFee, statim, inCombination)
* References the product via `instance` element (REQUIRED)
* May include multiple pricing scenarios (community pricing vs alternative pricing)
* Does NOT use `code` element (reserved for SA codes)
* Does NOT use authorization extensions

**Example:** `ChargeItemDefinition-Clexane-Pricing`

**Price Components:**

* **Listed Price** (type: `base`) - The pharmaceutical supplier's price
* **PHARMAC Subsidy** (type: `discount`) - The amount PHARMAC subsidizes
* **Patient Surcharge** (type: `surcharge`) - The additional cost to the patient
* **Patient Co-Payment** (type: `informational`) - The final calculated patient cost

### Special Authorization ChargeItemDefinition (PharmacChargeItemDefinitionSpecialAuthority)

Represents authorization requirements for restricted medications.

NOTE: The following makes reference to SA-2139, which as of this writing is not provided fully for reference as an example. For the nature of the link as expressed in the legacy system, feel free to consult the existing Pharmac Schedule. SA-2139 will be provided as an example soon.

**Profile:** `PharmacChargeItemDefinitionSpecialAuthority`

**Key Characteristics:**

* Uses `code` element to identify the special authority form (e.g., SA2139, SA2520) (REQUIRED)
* Contains authorization extensions: authorizationCaseCount (REQUIRED), authorizationForm, authorizationTitle
* Contains `authorizationSchema` extension with Base64-encoded JSON schema defining case submission structure (RECOMMENDED) 
* May have multiple applicability entries representing different authorization cases
* References the medication via `instance` element (REQUIRED)
* Does NOT use pricing attribute extensions (costBrandSource, etc.)

**Example:** `ChargeItemDefinition-SA9999-Authorization`

A single Special Authority ChargeItemDefinition may reference multiple Medications. For example, SA9999 is a demonstration schema showing various validation patterns.

**Authorization Cases (SA9999 - Example Template):** Multiple authorization patterns demonstrating text fields, numeric ranges, boolean selections, conditional fields, and combined logic.

### Funding Mechanism ChargeItemDefinition (PharmacChargeItemDefinitionFundingRules)

Represents specific funding scenarios and reimbursement rules.

**Profile:** `PharmacChargeItemDefinitionFundingRules`

**Key Characteristics:**

* Contains `fundingRule` extension with type and rule details (REQUIRED)
* Includes case sequence number and funding mechanism type (Prescription, BSO, RuralPSO, Pharmacy)
* **NEW:** Contains optional `authorizationSchema` extension with Base64-encoded JSON schema for case submission validation (RECOMMENDED) 
* May include `propertyGroup` with subsidy amounts
* References the medication optionally via `instance` element
* Does NOT use `code` element (reserved for SA codes)
* Does NOT use pricing attribute extensions or authorization extensions

**Example:** `ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1`

**Funding Mechanism Types:**

* **Prescription** - Standard community pharmacy prescription subsidy
* **BSO** - Bulk Supply Order subsidy
* **RuralPSO** - Rural Practitioner Supply Order subsidy
* **Pharmacy** - Pharmacy-specific funding mechanism

## Relationship Diagram

## Search Patterns

### Pattern 1: Search Medication with Pricing

Retrieve a medication and all its associated ChargeItemDefinitions (pricing, funding rules):

```
GET /Medication?name=Clexane&_revinclude=ChargeItemDefinition:instance

```

**Returns:** (see `SearchSet-Bundle-Clexane-Pricing`)

* Medication-Clexane-100mg-1ml-Syringe (match)
* ChargeItemDefinition-Clexane-Pricing (included)
* ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1 (included)
* ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2 (included)
* ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-3 (included)

### Pattern 2: Search Medication with Pricing, Funding Rules, and Authorizations

Retrieve a medication and all associated ChargeItemDefinitions — pricing, funding rules, and special authorizations:

```
GET /Medication?name=Clexane&_revinclude=ChargeItemDefinition:instance

```

**Returns:** (see `SearchSet-Bundle-Clexane-Pricing`)

* Medication-Clexane-100mg-1ml-Syringe (match)
* ChargeItemDefinition-Clexane-Pricing (included)
* ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1 (included)
* ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2 (included)
* ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-3 (included)
* ChargeItemDefinition-SA9999-Authorization (included)

### Pattern 3: Search by Special Authority Code

Retrieve all ChargeItemDefinitions for a specific special authority form:

```
GET /ChargeItemDefinition?code=SA9999

```

**Returns:**

* All ChargeItemDefinitions with authorization code SA9999

### Pattern 4: Reverse Include from Medication

Retrieve a medication and include all ChargeItemDefinitions that reference it:

```
GET /Medication/Medication-Clexane?_revinclude=ChargeItemDefinition:instance

```

**Returns:**

* Medication-Clexane-100mg-1ml-Syringe
* All ChargeItemDefinitions that reference this medication

### Pattern 5: Search by Special Authority and Include Medications

Retrieve a Special Authority `ChargeItemDefinition` and all associated `Medication` resources:

```
GET /ChargeItemDefinition?code=SA9999&_include=ChargeItemDefinition:instance

```

**Returns:** (see `SearchSet-Bundle-SA9999-Authorization`)

* ChargeItemDefinition-SA9999-Authorization (match)
* Medication-Clexane-100mg-1ml-Syringe

Note: A single Special Authority ChargeItemDefinition may reference multiple Medications via the `instance` element.

## Complete Example: Clexane

Clexane demonstrates the full complexity of the relationship model, with pricing, funding rules, and a special authority:

```
Medication-Clexane-100mg-1ml-Syringe
  └── Referenced by:
      ├── ChargeItemDefinition-Clexane-Pricing (Product Pricing)
      │   ├── Listed Price: [See actual pricing]
      │   ├── PHARMAC Subsidy: [See actual pricing]
      │   ├── Contract Type: [See actual contract type]
      │   └── Other pricing attributes: [See full resource]
      │
      ├── ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1 (Funding Rules)
      │   └── Special Authority (SA9999) + Authorised Providers
      │
      ├── ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2 (Funding Rules)
      │   └── PRIME Service Endorsement + Authorised Providers
      │
      ├── ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-3 (Funding Rules)
      │   └── Hospital Use Only
      │
      └── ChargeItemDefinition-SA9999-Authorization (SA9999 - Example Template)
          ├── Demonstration schema with various validation patterns
          ├── Text fields, numeric ranges, and boolean selections
          ├── Conditional fields and combined logic patterns
          └── For reference and developer guidance
          └── For reference and developer guidance

```

## Resources in this Implementation Guide

The primary examples in this IG are based on **Clexane (enoxaparin sodium) 100mg 1ml Syringe**:

* **Medication:** `Medication-Clexane-100mg-1ml-Syringe` 
* Identifiers: Brand ID, Pack ID, Chemical ID, Formulation ID, Pharma Code, and GTINs
* Form: Injectable solution
* Ingredients: Enoxaparin sodium
 
* **Pricing:** `ChargeItemDefinition-Clexane-Pricing` 
* Represents the listed price, subsidy, surcharge, and co-payment for this medication
 
* **Funding Rules:** Three cases demonstrating different funding scenarios 
* Case 1: Special Authority (SA9999) required + Authorised Providers
* Case 2: PRIME service endorsement + Authorised Providers
* Case 3: Hospital use only
 
* **Special Authorization:** `ChargeItemDefinition-SA9999-Authorization` 
* Demonstration schema showing various validation patterns
* Text fields, numeric ranges, booleans, conditional logic
* For reference and developer guidance
 

## JSON Schema Validation and Authorization Structure

ChargeItemDefinitions now use the `authorizationSchema` extension containing a Base64-encoded JSON schema document to define validation rules for authorization case submissions and funding rules.

### Purpose of authorizationSchema

The `authorizationSchema` extension serves to:

1. **Define structural requirements**- Specify the exact properties and data types expected in an authorization form submission
1. **Enable client-side validation**- Allow systems submitting authorizations to validate form data before submission
1. **Document submission format**- Provide machine-readable documentation of the expected JSON structure

### Dual-Validation Architecture

Authorization and funding rules now use **JSON schema validation exclusively**:

* **JSON Schema**: Validates structured format for case submissions, ensures required fields are present with correct data types

## Extensions and Attributes

### Pricing Attributes

| | | |
| :--- | :--- | :--- |
| effectiveDate | date | When pricing becomes effective |
| expiryDate | date | When pricing expires (optional) |
| costBrandSource | boolean | Pricing sourced from cost brand |
| wastageClaimable | boolean | Wastage may be claimed |
| contractType | string | PHARMAC contract type (e.g., PSS) |
| dvLimitPercent | decimal | Daily volume limit percentage |
| brandSwitchFee | boolean | Brand switch fee applies |
| statim | string | Urgent dispensing rules (Must/n/a) |
| inCombination | string | Combination therapy requirement (n/a) |

### Authorization Attributes

| | | |
| :--- | :--- | :--- |
| authorizationForm | string | Special authority form code (e.g., SA2139) |
| authorizationTitle | string | Human-readable authorization title |
| authorizationCaseCount | integer | Number of distinct authorization cases |
| authorizationSchema | Base64Binary | Base64-encoded JSON schema defining structured format for authorization case submissions. |

### Funding Rule Attributes

| | | |
| :--- | :--- | :--- |
| fundingRule.type | code | Funding type (e.g., community) |
| fundingRule.rule.type | code | Rule type (e.g., CaseSequence, FundingMechanism) |
| fundingRule.rule.value | integer/decimal | Rule value |
| fundingRule.rule.attribute | code | Rule attribute (e.g., Prescription, BSO) |
| authorizationSchema | Base64Binary | Optional: Base64-encoded JSON schema defining structured format for funding case submissions. |

## Best Practices

### For API Consumers

1. **Always use _revinclude**: When retrieving Medication resources, use`_revinclude=ChargeItemDefinition:instance`to get all related ChargeItemDefinitions in a single request. When retrieving ChargeItemDefinitions, use`_include=ChargeItemDefinition:instance`to get the referenced Medication(s).
1. **Check ChargeItemDefinition types**: Examine the content to determine the type:
* Has `propertyGroup` with pricing and no `fundingRule`? → Product Pricing
* Has `code` with SA prefix? → Special Authorization
* Has `fundingRule` extension? → Funding Rules

1. **Process multiple scenarios**: A medication may have multiple authorization forms (SA2139, SA2520), multiple funding mechanisms (Prescription, BSO, Rural PSO), and multiple case sequences. Process all applicable ChargeItemDefinitions. A single Special Authority may reference multiple medications.
1. **Validate against JSON schema**: If`authorizationSchema`is present, decode and use the Base64-encoded JSON schema to validate incoming authorization or funding case submissions.
1. **Check effective dates**: Always verify that the ChargeItemDefinition is currently effective by checking`effectiveDate`and`expiryDate`extensions.

### For API Implementers

1. **Create separate ChargeItemDefinitions**: Don't combine pricing, authorization, and funding rules in a single ChargeItemDefinition. Create separate instances for each concern.
1. **Use consistent URL patterns**: Follow the pattern`ChargeItemDefinition/{Type}-{Product}-{Identifier}`for URLs.
1. **Implement proper search parameters**: Support searching by:
* `instance` (to find ChargeItemDefinitions for a Medication)
* `code` (to find ChargeItemDefinitions by special authority code)
* `effectiveDate` (to find current ChargeItemDefinitions)

1. **Maintain referential integrity**: Ensure all ChargeItemDefinitions reference valid Medication or Device resources via`instance`or`deviceDefinition`extensions.
1. **Document JSON schemas**: Provide clear documentation of all`authorizationSchema`JSON documents, including the meaning of each required field and validation constraints.

## Related Resources

* [ChargeItemDefinition Profile](StructureDefinition-pharmac-charge-item-definition.md)
* [Medication Profile](StructureDefinition-pharmac-medication.md)
* [Search Parameters](searchparameters.md)
* [Examples](examples.md)

