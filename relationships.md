# Relationships - Pharmac Schedules FHIR API v0.0.1

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

### 1. Product Pricing ChargeItemDefinition

Represents the base pricing information for a medication or device.

**Key Characteristics:**

* Contains `propertyGroup` with `priceComponent` elements
* Includes pricing attributes via extensions (costBrandSource, wastageClaimable, contractType, dvLimitPercent, brandSwitchFee, statim, inCombination)
* References the product via `instance` element
* May include multiple pricing scenarios (community pricing vs alternative pricing)

**Example:** `ChargeItemDefinition-Ricovir-Pricing`

**Price Components:**

* **Listed Price** (type: `base`) - The pharmaceutical supplier's price
* **PHARMAC Subsidy** (type: `discount`) - The amount PHARMAC subsidizes
* **Patient Surcharge** (type: `surcharge`) - The additional cost to the patient
* **Patient Co-Payment** (type: `informational`) - The final calculated patient cost

### 2. Special Authorization ChargeItemDefinition

Represents authorization requirements for restricted medications.

**Key Characteristics:**

* Contains authorization extensions (authorizationForm, authorizationTitle, authorizationCaseCount)
* Uses `code` element to identify the special authority form (e.g., SA2139, SA2520)
* Contains `applicability` rules with CQL expressions defining eligibility criteria
* May have multiple applicability entries representing different authorization cases
* References the medication via `instance` element

**Example:** `ChargeItemDefinition-Tenofovir-Emtricitabine-SA2139-Authorization`

**Authorization Cases (SA2139 - Antiretrovirals):**

1. Initial application - Confirmed HIV
1. Renewal - Confirmed HIV
1. Initial application - Prevention of maternal transmission
1. Initial application - Pre-exposure prophylaxis (PEP)
1. Renewal - Second/subsequent post-exposure prophylaxis
1. Initial application - Percutaneous exposure
1. Renewal - Second/subsequent percutaneous exposure

### 3. Funding Mechanism ChargeItemDefinition

Represents specific funding scenarios and reimbursement rules.

**Key Characteristics:**

* Contains `fundingRule` extension with type and rule details
* Includes case sequence number and funding mechanism type (Prescription, BSO, RuralPSO, Pharmacy)
* Contains `applicability` rules defining when this funding applies (e.g., provider requirements, endorsement conditions)
* References the medication indirectly (applies to goserelin prescriptions in example)

**Example:** `ChargeItemDefinition-Community-Pharmacy-Sequence-1`

**Funding Mechanism Types:**

* **Prescription** - Standard community pharmacy prescription subsidy
* **BSO** - Bulk Supply Order subsidy
* **RuralPSO** - Rural Practitioner Supply Order subsidy
* **Pharmacy** - Pharmacy-specific funding mechanism

## Relationship Diagram

## Search Patterns

### Pattern 1: Search Medication with Pricing

Retrieve a medication and all its associated ChargeItemDefinitions:

```
GET /Medication?name=Ricovir&_revinclude=ChargeItemDefinition:instance

```

**Returns:**

* Medication-Ricovir-Tenofovir (match)
* ChargeItemDefinition-Ricovir-Pricing (included)

### Pattern 2: Search Medication with Authorizations

Retrieve a medication and its authorization requirements:

```
GET /Medication?code=50348251000117105&_revinclude=ChargeItemDefinition:instance

```

**Returns:**

* Medication-Ricovir-Tenofovir (match)
* ChargeItemDefinition-Ricovir-Pricing (included)
* ChargeItemDefinition-Tenofovir-Emtricitabine-SA2139-Authorization (included)
* ChargeItemDefinition-Tenofovir-Emtricitabine-SA2520-Authorization (included)

### Pattern 3: Search by Special Authority Code

Retrieve all ChargeItemDefinitions for a specific special authority form:

```
GET /ChargeItemDefinition?code=SA2139

```

**Returns:**

* All ChargeItemDefinitions with authorization code SA2139

### Pattern 4: Reverse Include from Medication

Retrieve a medication and include all ChargeItemDefinitions that reference it:

```
GET /Medication/Medication-Ricovir-Tenofovir?_revinclude=ChargeItemDefinition:instance

```

**Returns:**

* Medication-Ricovir-Tenofovir
* All ChargeItemDefinitions that reference this medication

### Pattern 5: Search by Special Authority and Include Medications

Retrieve a Special Authority `ChargeItemDefinition` and all associated `Medication` resources

```
GET /ChargeItemDefinition?code=SA2139?_include=*

```

```
GET /ChargeItemDefinition?code=SA2139?_include=ChargeItemDefinition:instance

```

## Complete Example: Ricovir (Tenofovir)

Ricovir demonstrates the full complexity of the relationship model:

```
Medication-Ricovir-Tenofovir
  └── Referenced by:
      ├── ChargeItemDefinition-Ricovir-Pricing (Product Pricing)
      │   ├── Listed Price: $13.45
      │   ├── PHARMAC Subsidy: $13.45 (fully subsidized)
      │   ├── Contract Type: PSS
      │   ├── DV Limit: 5%
      │   ├── Statim: Must
      │   └── In-Combination: n/a
      │
      ├── ChargeItemDefinition-Tenofovir-Emtricitabine-SA2139-Authorization (SA2139 - Antiretrovirals)
      │   ├── Case 1: Initial - Confirmed HIV
      │   ├── Case 2: Renewal - Confirmed HIV
      │   ├── Case 3: Initial - Maternal transmission prevention
      │   ├── Case 4: Initial - Post-exposure prophylaxis (PEP)
      │   ├── Case 5: Renewal - Second/subsequent PEP
      │   ├── Case 6: Initial - Percutaneous exposure
      │   └── Case 7: Renewal - Second/subsequent percutaneous exposure
      │
      └── ChargeItemDefinition-Tenofovir-Emtricitabine-SA2520-Authorization (SA2520 - PrEP/PEP)
          ├── Case 1: Initial - Pre-exposure prophylaxis (PrEP)
          ├── Case 2: Renewal - PrEP
          ├── Case 3: Initial - Post-exposure prophylaxis (PEP)
          └── Case 4: Renewal - Second/subsequent PEP

```

## Understanding Applicability Rules

ChargeItemDefinitions use the `applicability` element with CQL expressions to define when they apply:

### Pricing Applicability

```
* applicability[0].description = "Community (subsidized) pricing - fully subsidized"

```

Simple text-based rules for pricing scenarios.

### Authorization Applicability

```
* applicability[0].description = "Initial application - Confirmed HIV"
* applicability[0].language = #text/cql
* applicability[0].expression = "exists(Condition where code in 'ConfirmedHIVInfection')"

```

CQL expressions that define clinical eligibility criteria, allowing for:

* Complex conditional logic
* Multiple requirement combinations (AND/OR)
* Clinical condition checks
* Provider requirement validation

### Funding Mechanism Applicability

```
* applicability[0].description = "Condition (endorsement): Additional subsidy by endorsement..."
* applicability[0].language = #text/cql
* applicability[0].expression = "exists(Condition where code in 'ChildOrAdolescent') and 
                                  exists(Condition where code in 'UnableToTolerateGoserelin') and 
                                  exists(Condition where code in 'PrescriptionEndorsedForAdditionalSubsidy')"

```

Complex rules combining patient demographics, clinical conditions, and administrative requirements.

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

### Funding Rule Attributes

| | | |
| :--- | :--- | :--- |
| fundingRule.type | code | Funding type (e.g., community) |
| fundingRule.rule.type | code | Rule type (e.g., CaseSequence, FundingMechanism) |
| fundingRule.rule.value | integer/decimal | Rule value |
| fundingRule.rule.attribute | code | Rule attribute (e.g., Prescription, BSO) |

## Best Practices

### For API Consumers

1. **Always use _include**: When retrieving Medication resources, use `_include=ChargeItemDefinition:instance` to get all related pricing and authorization information in a single request.
1. **Check ChargeItemDefinition types**: Examine the content to determine the type:
* Has `propertyGroup`? → Product Pricing
* Has `code` with SA prefix? → Special Authorization
* Has `fundingRule` extension? → Funding Mechanism

1. **Process multiple scenarios**: A medication may have multiple authorization forms (SA2139, SA2520) and multiple funding mechanisms (Sequence 1, 2, etc.). Process all applicable ChargeItemDefinitions.
1. **Evaluate applicability rules**: Use the CQL expressions in `applicability` to determine if a ChargeItemDefinition applies to a specific clinical scenario.
1. **Check effective dates**: Always verify that the ChargeItemDefinition is currently effective by checking`effectiveDate`and`expiryDate`extensions.

### For API Implementers

1. **Create separate ChargeItemDefinitions**: Don't combine pricing, authorization, and funding rules in a single ChargeItemDefinition. Create separate instances for each concern.
1. **Use consistent URL patterns**: Follow the pattern `ChargeItemDefinition/{Type}-{Product}-{Identifier}` for URLs.
1. **Implement proper search parameters**: Support searching by:
* `instance` (to find ChargeItemDefinitions for a Medication)
* `code` (to find ChargeItemDefinitions by special authority code)
* `effectiveDate` (to find current ChargeItemDefinitions)

1. **Maintain referential integrity**: Ensure all ChargeItemDefinitions reference valid Medication or Device resources via `instance` or `deviceDefinition` extensions.
1. **Document CQL expressions**: Provide clear, human-readable descriptions for all`applicability`rules alongside the CQL expressions.

## Related Resources

* [ChargeItemDefinition Profile](StructureDefinition-pharmac-charge-item-definition.md)
* [Medication Profile](StructureDefinition-pharmac-medication.md)
* [Search Parameters](searchparameters.md)
* [Examples](examples.md)

