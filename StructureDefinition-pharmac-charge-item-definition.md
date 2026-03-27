# PHARMAC Charge Item Definition - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **PHARMAC Charge Item Definition**

## Resource Profile: PHARMAC Charge Item Definition 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition | *Version*:0.0.1 |
| Active as of 2025-01-26 | *Computable Name*:PharmacChargeItemDefinition |

 
Profile for ChargeItemDefinition resources representing pricing, subsidy, and rules for devices and medications in the PHARMAC schedule. This profile allows FHIR consumers to use the _include search parameter to retrieve pricing information alongside device or medication resources. 

 
To define the structure for PHARMAC pricing information including listed price, subsidy amounts, and applicability rules for devices and medications. Supports the use of _include search parameter for efficient data retrieval. 

**Usages:**

* Examples for this Profile: [ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-BSO-Sequence-1](ChargeItemDefinition-ChargeItemDefinition-Community-Pharmacy-BSO-Sequence-1.md), [ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-Rural-PSO-Sequence-1](ChargeItemDefinition-ChargeItemDefinition-Community-Pharmacy-Rural-PSO-Sequence-1.md), [ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-Sequence-1](ChargeItemDefinition-ChargeItemDefinition-Community-Pharmacy-Sequence-1.md), [ChargeItemDefinition/ChargeItemDefinition-Community-Pharmacy-Sequence-2](ChargeItemDefinition-ChargeItemDefinition-Community-Pharmacy-Sequence-2.md)... Show 6 more, [ChargeItemDefinition/ChargeItemDefinition-Lucrin-Depot-1-Month-Pricing](ChargeItemDefinition-ChargeItemDefinition-Lucrin-Depot-1-Month-Pricing.md), [ChargeItemDefinition/ChargeItemDefinition-Ricovir-Pricing](ChargeItemDefinition-ChargeItemDefinition-Ricovir-Pricing.md), [ChargeItemDefinition/ChargeItemDefinition-SA2139-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2139-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-SA2520-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2520-Authorization.md), [ChargeItemDefinition/ChargeItemDefinition-Tenofovir-Case-Sequence-1](ChargeItemDefinition-ChargeItemDefinition-Tenofovir-Case-Sequence-1.md) and [ChargeItemDefinition/ChargeItemDefinition-Tenofovir-Case-Sequence-2](ChargeItemDefinition-ChargeItemDefinition-Tenofovir-Case-Sequence-2.md)
* CapabilityStatements using this Profile: [Pharmac Schedules Capability Statement](CapabilityStatement-PharmacSchedulesCapabilityStatement.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/pharmac-charge-item-definition)

### Formal Views of Profile Content

 [Description of Profiles, Differentials, Snapshots and how the different presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-pharmac-charge-item-definition.csv), [Excel](StructureDefinition-pharmac-charge-item-definition.xlsx), [Schematron](StructureDefinition-pharmac-charge-item-definition.sch) 



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "pharmac-charge-item-definition",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition",
  "version" : "0.0.1",
  "name" : "PharmacChargeItemDefinition",
  "title" : "PHARMAC Charge Item Definition",
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
  "description" : "Profile for ChargeItemDefinition resources representing pricing, subsidy, and rules for devices and medications in the PHARMAC schedule. This profile allows FHIR consumers to use the _include search parameter to retrieve pricing information alongside device or medication resources.",
  "purpose" : "To define the structure for PHARMAC pricing information including listed price, subsidy amounts, and applicability rules for devices and medications. Supports the use of _include search parameter for efficient data retrieval.",
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
  "baseDefinition" : "http://hl7.org/fhir/StructureDefinition/ChargeItemDefinition",
  "derivation" : "constraint",
  "differential" : {
    "element" : [{
      "id" : "ChargeItemDefinition",
      "path" : "ChargeItemDefinition"
    },
    {
      "id" : "ChargeItemDefinition.extension",
      "path" : "ChargeItemDefinition.extension",
      "slicing" : {
        "discriminator" : [{
          "type" : "value",
          "path" : "url"
        }],
        "ordered" : false,
        "rules" : "open"
      },
      "min" : 1
    },
    {
      "id" : "ChargeItemDefinition.extension:effectiveDate",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "effectiveDate",
      "short" : "Effective date for this pricing",
      "definition" : "The date from which this pricing becomes effective",
      "min" : 1,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:expiryDate",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "expiryDate",
      "short" : "Expiry date for this pricing",
      "definition" : "The date on which this pricing expires (optional)",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-expiry-date"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:authorizationForm",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "authorizationForm",
      "short" : "Special authorization form code",
      "definition" : "The PHARMAC special authorization form code (e.g., 'SA2535') required for this medication",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-form"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:authorizationTitle",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "authorizationTitle",
      "short" : "Authorization requirement title",
      "definition" : "A human-readable title describing the authorization requirement",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-title"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:authorizationCaseCount",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "authorizationCaseCount",
      "short" : "Number of authorization cases",
      "definition" : "The count of distinct authorization approval criteria or conditions",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:deviceDefinition",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "deviceDefinition",
      "short" : "Reference to DeviceDefinition",
      "definition" : "Reference to the DeviceDefinition that this pricing applies to. Use this for devices. For medications, use the instance element directly.",
      "min" : 0,
      "max" : "*",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/device-definition-reference"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:fundingRule",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "fundingRule",
      "short" : "Funding rules and conditions",
      "definition" : "Funding rules that define conditions, restrictions, and special requirements for this funding",
      "min" : 0,
      "max" : "*",
      "type" : [{
        "code" : "Extension",
        "profile" : ["http://schedule.pharmac.govt.nz/fhir/StructureDefinition/funding-rule"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.extension:costBrandSource",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "costBrandSource",
      "short" : "Cost brand source flag",
      "definition" : "Indicates whether pricing for this item is sourced from a cost brand.",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/cost-brand-source"]
      }]
    },
    {
      "id" : "ChargeItemDefinition.extension:wastageClaimable",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "wastageClaimable",
      "short" : "Wastage claimable flag",
      "definition" : "Indicates whether wastage for this item may be claimed.",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/wastage-claimable"]
      }]
    },
    {
      "id" : "ChargeItemDefinition.extension:contractType",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "contractType",
      "short" : "Contract type",
      "definition" : "Type of PHARMAC contract that applies to this item (for example, sole-supply, preferred).",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/contract-type"]
      }]
    },
    {
      "id" : "ChargeItemDefinition.extension:dvLimitPercent",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "dvLimitPercent",
      "short" : "DV limit percentage",
      "definition" : "Percentage daily volume limit that applies to this item.",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/dv-limit-percent"]
      }]
    },
    {
      "id" : "ChargeItemDefinition.extension:brandSwitchFee",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "brandSwitchFee",
      "short" : "Brand switch fee flag",
      "definition" : "Indicates whether a brand switch fee applies for this item.",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/brand-switch-fee"]
      }]
    },
    {
      "id" : "ChargeItemDefinition.extension:statim",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "statim",
      "short" : "Statim (urgent dispensing) flag",
      "definition" : "Indicates whether stat (urgent) dispensing rules apply for this item.",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/statim"]
      }]
    },
    {
      "id" : "ChargeItemDefinition.extension:inCombination",
      "path" : "ChargeItemDefinition.extension",
      "sliceName" : "inCombination",
      "short" : "In-combination funding flag",
      "definition" : "Indicates whether this item is only subsidised when used in combination with other medicines or treatments.",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "Extension",
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/in-combination"]
      }]
    },
    {
      "id" : "ChargeItemDefinition.url",
      "path" : "ChargeItemDefinition.url",
      "short" : "Canonical identifier for this charge item definition",
      "definition" : "Unique canonical URL for this pricing definition",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.version",
      "path" : "ChargeItemDefinition.version",
      "short" : "Version of this pricing definition",
      "definition" : "The business version of this pricing definition",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.title",
      "path" : "ChargeItemDefinition.title",
      "short" : "Name for this pricing definition",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.status",
      "path" : "ChargeItemDefinition.status",
      "short" : "Status of this pricing definition",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.publisher",
      "path" : "ChargeItemDefinition.publisher",
      "short" : "Organization responsible for this pricing",
      "definition" : "The organization (typically PHARMAC) responsible for publishing and maintaining this pricing definition",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.contact",
      "path" : "ChargeItemDefinition.contact",
      "definition" : "Contact information for inquiries or issues related to this pricing",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.description",
      "path" : "ChargeItemDefinition.description",
      "short" : "Natural language description of pricing rules",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.code",
      "path" : "ChargeItemDefinition.code",
      "short" : "Classification or authorization code",
      "definition" : "Optional code for classifying this definition, such as a special authorization form code",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.instance",
      "path" : "ChargeItemDefinition.instance",
      "short" : "References to Medication or Device resources",
      "definition" : "Direct references to Medication resources that this pricing applies to. For DeviceDefinition, use the deviceDefinition extension instead since instance can only reference Device instances, not DeviceDefinition.",
      "type" : [{
        "code" : "Reference",
        "targetProfile" : ["http://hl7.org/fhir/StructureDefinition/Medication",
        "http://hl7.org/fhir/StructureDefinition/Device"]
      }],
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.applicability",
      "path" : "ChargeItemDefinition.applicability",
      "short" : "Applicability rules for this pricing",
      "definition" : "Rules or conditions that determine when this pricing applies (e.g., patient eligibility, prescriber requirements, clinical criteria)",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.applicability.description",
      "path" : "ChargeItemDefinition.applicability.description",
      "short" : "Natural language description of the rule",
      "definition" : "A human-readable description of when this applicability rule applies",
      "min" : 1
    },
    {
      "id" : "ChargeItemDefinition.applicability.language",
      "path" : "ChargeItemDefinition.applicability.language",
      "short" : "Expression language",
      "definition" : "The language in which the expression is written (e.g., 'text/cql' for Clinical Quality Language)"
    },
    {
      "id" : "ChargeItemDefinition.applicability.expression",
      "path" : "ChargeItemDefinition.applicability.expression",
      "short" : "Expression code",
      "definition" : "The formal expression defining the condition (e.g., CQL expression for clinical criteria)"
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup",
      "path" : "ChargeItemDefinition.propertyGroup",
      "short" : "Pricing components (listed price, subsidy, patient co-payment)",
      "definition" : "Group of pricing properties including listed price, PHARMAC subsidy, and patient co-payment amounts",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.applicability",
      "path" : "ChargeItemDefinition.propertyGroup.applicability",
      "short" : "Applicability for this property group",
      "definition" : "Rules for when this set of price components applies (e.g., 'Community pricing' vs 'Alternative pricing')",
      "type" : [{
        "code" : "BackboneElement"
      }]
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.applicability.description",
      "path" : "ChargeItemDefinition.propertyGroup.applicability.description",
      "min" : 1
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent",
      "short" : "Pricing components (base price, discounts, surcharges, informational amounts)",
      "definition" : "Components that make up the pricing structure (listed price, PHARMAC subsidy, patient surcharge, patient co-payment, alternative pricing)",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.type",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.type",
      "short" : "Type of price component",
      "definition" : "base = primary price; discount = reduction (subsidy); surcharge = addition to base; informational = calculated/derived value",
      "mustSupport" : true
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.code",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.code",
      "min" : 1
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.code.text",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.code.text",
      "short" : "Component label (e.g., 'Listed Price', 'PHARMAC Subsidy', 'Patient Cost')",
      "definition" : "Human-readable name for this pricing component",
      "min" : 1
    },
    {
      "id" : "ChargeItemDefinition.propertyGroup.priceComponent.amount",
      "path" : "ChargeItemDefinition.propertyGroup.priceComponent.amount",
      "short" : "Component amount",
      "definition" : "The monetary amount for this component (value and currency)",
      "min" : 1
    }]
  }
}

```
