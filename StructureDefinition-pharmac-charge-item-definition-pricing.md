# PHARMAC Charge Item Definition - Pricing - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **PHARMAC Charge Item Definition - Pricing**

## Resource Profile: PHARMAC Charge Item Definition - Pricing 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-pricing | *Version*:1.0.1 |
| Active as of 2026-03-25 | *Computable Name*:PharmacChargeItemDefinitionPricing |

 
Profile for ChargeItemDefinition resources representing product pricing information for medications and devices in the PHARMAC schedule. This profile captures listed prices, PHARMAC subsidies, patient co-payments, and pricing-specific attributes such as contract type, DV limits, and statim requirements. 

 
To define the structure for PHARMAC product pricing information including listed price, subsidy amounts, patient costs, and pricing attributes such as contract type and DV limits. 

### Overview

The **PHARMAC Charge Item Definition - Pricing** profile captures product pricing information for medications and devices in the PHARMAC schedule. Each instance represents the listed price, PHARMAC subsidy, patient surcharge, and patient co-payment for a specific product.

### When to use this profile

Use this profile when you need to represent the price of a medication or device as listed in the PHARMAC schedule. This includes:

* The manufacturer's listed price
* The PHARMAC subsidy (government contribution)
* Any patient surcharge
* The resulting patient co-payment

### Key constraints (vs. base profile)

| | |
| :--- | :--- |
| `code` | **Prohibited**(0..0) — SA codes are not relevant to pricing. |
| `authorizationForm`,`authorizationTitle`,`authorizationCaseCount` | **Prohibited**(0..0) — authorization extensions are not used for pricing. |
| `propertyGroup` | **Required**(1..*) — at least one pricing group with price components. |
| `instance` | **Required**(1..*) — must reference the Medication or Device being priced. |

### Pricing extensions

The following pricing-specific extensions are available (all optional):

| | | |
| :--- | :--- | :--- |
| `costBrandSource` | boolean | `true`/`false` |
| `wastageClaimable` | boolean | `true`/`false` |
| `contractType` | string | `"PSS"`,`"n/a"` |
| `dvLimitPercent` | decimal | `100.0` |
| `brandSwitchFee` | boolean | `true`/`false` |
| `statim` | string | `"Must"`,`"n/a"` |
| `inCombination` | string | combination details or`"n/a"` |

### Price components

Each `propertyGroup` contains one or more `priceComponent` entries. The standard structure uses `type` codes from FHIR's charge item price component types:

| | | |
| :--- | :--- | :--- |
| `base` | Listed Price | The manufacturer's listed price |
| `discount` | PHARMAC Subsidy | The government subsidy amount |
| `surcharge` | Patient Surcharge | Any additional surcharge payable by the patient |
| `informational` | Patient Co-Payment | The calculated co-payment the patient pays |

All amounts are in NZD.

### Example

See [ChargeItemDefinition-Clexane-Pricing](ChargeItemDefinition-ChargeItemDefinition-Clexane-Pricing.md) for a complete pricing example showing listed price, subsidy, surcharge, and co-payment for Clexane 100mg 1ml Syringe.

### Typical search pattern

To retrieve pricing for a specific medication:

```
GET /Medication?identifier=http://schedule.pharmac.govt.nz/ids/pack|1234
    &_revinclude=ChargeItemDefinition:instance

```

The returned Bundle will include the Medication resource and its associated ChargeItemDefinition pricing resource(s).

**Usages:**

* Examples for this Profile: [ChargeItemDefinition/ChargeItemDefinition-Clexane-Pricing](ChargeItemDefinition-ChargeItemDefinition-Clexane-Pricing.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/pharmac-charge-item-definition-pricing)

### Formal Views of Profile Content

 [Description of Profiles, Differentials, Snapshots and how the different presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-pharmac-charge-item-definition-pricing.csv), [Excel](StructureDefinition-pharmac-charge-item-definition-pricing.xlsx), [Schematron](StructureDefinition-pharmac-charge-item-definition-pricing.sch) 



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "pharmac-charge-item-definition-pricing",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-pricing",
  "version" : "1.0.1",
  "name" : "PharmacChargeItemDefinitionPricing",
  "title" : "PHARMAC Charge Item Definition - Pricing",
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
  "description" : "Profile for ChargeItemDefinition resources representing product pricing information for medications and devices in the PHARMAC schedule. This profile captures listed prices, PHARMAC subsidies, patient co-payments, and pricing-specific attributes such as contract type, DV limits, and statim requirements.",
  "purpose" : "To define the structure for PHARMAC product pricing information including listed price, subsidy amounts, patient costs, and pricing attributes such as contract type and DV limits.",
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
      "id" : "ChargeItemDefinition.extension:effectiveDate",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "effectiveDate",
      "definition" : "The date from which this pricing becomes effective (required)"
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
      "id" : "ChargeItemDefinition.extension:fundingRule",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "fundingRule",
      "short" : "Optional funding context",
      "definition" : "Optional funding rules for basic context (e.g., community vs hospital). For complex funding rules, use the FundingRules profile instead."
    },
    {
      "id" : "ChargeItemDefinition.extension:costBrandSource",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "costBrandSource",
      "definition" : "Indicates whether pricing for this item is sourced from a cost brand",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:wastageClaimable",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "wastageClaimable",
      "definition" : "Indicates whether wastage for this item may be claimed",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:contractType",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "contractType",
      "short" : "Contract type (e.g., PSS, n/a)",
      "definition" : "Type of PHARMAC contract that applies to this item (e.g., 'PSS' for Pharmaceutical Schedule sole supply)",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:dvLimitPercent",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "dvLimitPercent",
      "definition" : "Percentage daily volume limit that applies to this item",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:brandSwitchFee",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "brandSwitchFee",
      "definition" : "Indicates whether a brand switch fee applies for this item",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:statim",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "statim",
      "short" : "Statim (urgent dispensing) requirement",
      "definition" : "Indicates whether stat (urgent) dispensing rules apply for this item (values: 'Must', 'n/a')",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:inCombination",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "inCombination",
      "short" : "In-combination funding requirement",
      "definition" : "Indicates whether this item is only subsidised when used in combination with other medicines or treatments (values: combination details, 'n/a')",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:PricingSection29",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "PricingSection29",
      "short" : "Pricing Section 29",
      "definition" : "Indicates whether Section 29 applies to this pricing record.",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:PricingNotCombined",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "PricingNotCombined",
      "short" : "Pricing Not Combined",
      "definition" : "Indicates whether Not Combined applies to this pricing record.",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:PricingCoPaymentMax",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "PricingCoPaymentMax",
      "short" : "Co-Payment Max",
      "definition" : "Indicates whether Co-Payment Max applies to this pricing record.",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.url",
      "path" : "ChargeItemDefinition.url",
      "short" : "Canonical identifier for this pricing definition",
      "definition" : "Unique canonical URL for this pricing definition, typically including the product name"
    },
    {
      "id" : "ChargeItemDefinition.title",
      "path" : "ChargeItemDefinition.title",
      "short" : "Product name for pricing"
    },
    {
      "id" : "ChargeItemDefinition.description",
      "path" : "ChargeItemDefinition.description",
      "short" : "Description of pricing information"
    },
    {
      "id" : "ChargeItemDefinition.code",
      "path" : "ChargeItemDefinition.code",
      "short" : "Not used for pricing definitions",
      "max" : "0"
    },
    {
      "id" : "ChargeItemDefinition.instance",
      "path" : "ChargeItemDefinition.instance",
      "short" : "Reference to the Medication or Device being priced",
      "definition" : "Direct reference to the Medication resource that this pricing applies to. For DeviceDefinition, use the deviceDefinition extension instead.",
      "min" : 1
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup",
      "path" : "ChargeItemDefinition.propertyGroup",
      "short" : "Pricing components (REQUIRED)",
      "definition" : "Group of pricing properties including listed price, PHARMAC subsidy, patient surcharge, and patient co-payment amounts. At least one propertyGroup is required for pricing definitions.",
      "min" : 1
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.applicability",
      "path" : "ChargeItemDefinition.propertyGroup.applicability",
      "definition" : "Rules for when this set of price components applies (e.g., 'Community (subsidized) pricing' vs 'Alternative pricing structure')"
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent",
      "short" : "Price components (listed price, subsidy, surcharge, co-payment)",
      "definition" : "Components that make up the pricing structure. Common types: base (listed price), discount (PHARMAC subsidy), surcharge (patient surcharge), informational (patient co-payment)",
      "min" : 1
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.type",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.type",
      "definition" : "base = primary/listed price; discount = reduction/subsidy; surcharge = addition to base; informational = calculated/derived value (e.g., co-payment)"
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.code",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.code",
      "short" : "Code or label for price component",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.code.text",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.code.text",
      "short" : "Text label (e.g., 'Listed Price', 'PHARMAC Subsidy', 'Patient Co-Payment')"
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.amount",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.amount",
      "short" : "Amount for this price component",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.amount.value",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.amount.value",
      "min" : 1
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.amount.currency",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.amount.currency",
      "min" : 1,
      "patternCode" : "NZD"
    }]
  }
}

```
