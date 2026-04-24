# JSON Schema for Funding Rules - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* **JSON Schema for Funding Rules**

## JSON Schema for Funding Rules

This page explains how Pharmac defines funding rule conditions and authorization cases for medications — the eligibility criteria, provider restrictions, and special conditions that determine how medications are funded.

#### Funding Condition Relationship Overview

Within Pharmac’s implementation of FHIR, a linked resource model is used rather than placing all funding conditions, pricing, and Special Authority content directly on the `Medication` resource. The `Medication` resource acts as the anchor resource, while related `ChargeItemDefinition` resources carry the associated funding conditions, pricing, and Special Authority information.

This approach is important because it reflects the underlying business structure of the Schedule. A medicine is not represented as having one single flat reimbursement or approval value. Instead, multiple linked records may exist to describe different pricing, funding, and authorisation contexts for the same medicine.

The approach can be broken into three main principles:

1. The medication product is always the anchor resource and may have multiple linked`ChargeItemDefinition`resources.
1. The relationship is carried through the`instance`element on`ChargeItemDefinition`, which references the associated`Medication`.
1. The API supports retrieval patterns that allow a vendor to query a medication and return the linked`ChargeItemDefinition`resources in the same response.

#### Pharmac ChargeItemDefinition Funding Rules

The funding conditions `ChargeItemDefinition` defines particular funding scenarios and reimbursement rules. It includes a `funding-rule` extension, case sequence information, funding mechanism type, and the condition logic that provides the circumstances in which the funding scenario applies.

Where a Special Authority is present, the detailed approval criteria and case logic is held within the linked Special Authority `ChargeItemDefinition`, rather than being duplicated in the reimbursement condition logic itself.

From a business perspective, it provides the contextual funding scenarios for the medicine, where reimbursement is determined through context, ordering, and conditions rather than through a single flat value.

#### Funding Conditions Context Overview

At a high level, funding conditions begin at the pack level and are then assessed through a series of contextual steps.

* A medicine / product may have multiple funding conditions, each dependent on a particular combination of dispensary type, funding mechanism, ordered sequence, and condition set.
* A medicine may be linked to one or more funding condition cases. Within a given dispensary context, one or more funding mechanisms may apply. Within a funding mechanism, one or more ordered sequences may exist. Each sequence may contain one or more conditions. Each condition set leads to a single reimbursement outcome.
* This means that one medicine may have multiple distinct funding condition cases. Those cases may differ in funding mechanism, processing order, applicable conditions, and reimbursement result.

#### Funding Condition Case Types

##### Case 1 - JSON Payload

The following JSON shows the returned payload for the Clexane example. While three cases exist, the example below shows only **Case 1**.

```
{
  "fullUrl": "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1",
  "resource": {
    "resourceType": "ChargeItemDefinition",
    "id": "ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1",
    "meta": {
      "profile": [
        "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
      ]
    },
    "extension": [
      {
        "url": "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date",
        "valueDate": "2026-02-01"
      },
      {
        "extension": [
          {
            "url": "type",
            "valueCode": "community"
          },
          {
            "extension": [
              {
                "url": "type",
                "valueCode": "CaseSequence"
              },
              {
                "url": "value",
                "valueInteger": 1
              }
            ],
            "url": "rule"
          },
          {
            "extension": [
              {
                "url": "type",
                "valueCode": "FundingMechanism"
              },
              {
                "url": "attribute",
                "valueCode": "Prescription"
              }
            ],
            "url": "rule"
          },
          {
            "extension": [
              {
                "url": "type",
                "valueCode": "SubsidyType"
              },
              {
                "url": "attribute",
                "valueCode": "Full"
              }
            ],
            "url": "rule"
          }
        ],
        "url": "http://schedule.pharmac.govt.nz/fhir/StructureDefinition/funding-rule"
      },
      {
        "url": "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema",
        "valueBase64Binary": "ewogICIkc2NoZW1hIjogImh0dHA6Ly9qc29uLXNjaGVtYS5vcmcvZHJhZnQtMDcvc2NoZW1hIyIsCiAgInRpdGxlIjogIkNsZXhhbmUgMTAwbWcgMW1sIFN5cmluZ2UgQ2FzZSAxIiwKICAidHlwZSI6ICJvYmplY3QiLAogICJwcm9wZXJ0aWVzIjogewogICAgImF1dGhvcml0eSI6IHsKICAgICAgInRpdGxlIjogIlNBOTk5OSIsCiAgICAgICIkdXJsIjogImh0dHBzOi8vZmhpci1pZy5kaWdpdGFsLmhlYWx0aC5uei9waGFybWFjLXNjaGVkdWxlcy9DaGFyZ2VJdGVtRGVmaW5pdGlvbi9DaGFyZ2VJdGVtRGVmaW5pdGlvbi1TQTk5OTktQXV0aG9yaXphdGlvbiIsCiAgICAgICJ0eXBlIjogImJvb2xlYW4iLAogICAgICAiZGVzY3JpcHRpb24iOiAiSGFzIFNBOTk5OSIKICAgIH0sCiAgICAicHJvdmlkZXIiOiB7CiAgICAgICJ0aXRsZSI6ICJBdXRob3Jpc2VkIFByb3ZpZGVycyIsCiAgICAgICJ0eXBlIjogImJvb2xlYW4iLAogICAgICAiZGVzY3JpcHRpb24iOiAiUHJvdmlkZXIgVHlwZSBpcyBBdXRob3Jpc2VkIFByb3ZpZGVycyIKICAgIH0KICB9LAogICJyZXF1aXJlZCI6IFsKICAgICJhdXRob3JpdHkiLAogICAgInByb3ZpZGVyIgogIF0KfQo="
      }
    ],
    "url": "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-Sequence-1",
    "version": "1.0",
    "status": "active",
    "publisher": "Pharmac",
    "contact": [
      {
        "name": "Pharmac",
        "telecom": [
          {
            "system": "url",
            "value": "https://www.pharmac.govt.nz/about/contact"
          }
        ]
      }
    ],
    "description": "Rules for Clexane 100 mg in 1 ml syringe. Community pharmacy prescription case sequence 1.",
    "instance": [
      {
        "reference": "Medication/Medication-Clexane-100mg-1ml-Syringe"
      }
    ],
    "propertyGroup": [
      {
        "priceComponent": [
          {
            "type": "discount",
            "code": {
              "text": "PHARMAC Subsidy"
            },
            "amount": {
              "value": 70.91,
              "currency": "NZD"
            }
          }
        ]
      }
    ]
  },
  "search": {
    "mode": "include"
  }
}

```

#### Funding Rule Attributes

| | | | |
| :--- | :--- | :--- | :--- |
| **Pack / Product Anchor** | The medicine remains the anchor point for the case. | `resource.instance.reference = Medication/Medication-Clexane-100mg-1ml-Syringe` | This is the element that links the funding condition case back to the medicine. |
| **Profile / Resource Type** | The profile identifies the type of`ChargeItemDefinition`being returned. | `resource.meta.profile = pharmac-charge-item-definition-funding-rules` | This shows that the payload is a funding rules`ChargeItemDefinition` |
| **Dispensary Type** | A medicine may be associated with one or many dispensary contexts. (Community, Wholesale, General Practice, and Hospital) | `resource.extension.valueCode = community` | The same medicine may be reimbursed differently depending on the dispensary context in which it is assessed.In this case, the dispensary context is`Community` |
| **Funding Mechanism** | Within a given dispensary context, reimbursement is further qualified by the funding mechanism. (Prescription, BSO, PSO, Rural PSO, and Quitcard) | `resource.extension.valueCode = Prescription` | Funding mechanism forms part of the reimbursement context. It affects how the reimbursement case is assessed and what outcome may result.In this case, the Funding mechinism is`Prescription` |
| **Sequence** | Sequence represents the order in which reimbursement cases are to be assessed. Where multiple cases exist for the same medicine within a broader context, they are assumed to be ordered.Each sequence may have one or more conditions which form the rule set that determines whether the reimbursement case applies. A condition set may include a single condition or multiple conditions grouped together within the same case. | `resource.extension.valueInteger = 1` | Sequence is an important part of case evaluation and must be preserved as ordered logic.In this case, the sequence is`1`meaning there is only a single sequence |
| **Conditions / Case Logic** | Conditions may represent matters such as endorsement, provider, authority, restriction-based criteria, or other qualifying rules. | `resource.extension.valueBase64Binary = "Encoded base64 string"` | Condtional logic is held in a encoded base64 string.This is an important distinction. The funding case is not holding the detailed logic as flat text. Instead, the case logic is encoded into the`valueBase64Binary`element and must be decoded to retrieve the JSON Schema.(Refer to later in this guide for a full explanation) |
| **Reimbursement Outcome / Price Component** | Each condition set results in one reimbursement outcome. One assessed case leads to**one**reimbursement outcome, even where that case contains multiple conditions.Reimbursment Outcomes include Subsidy, Alternate, Price, and None. | `resource.propertyGroup.priceComponent.type = discount``resource.propertyGroup.priceComponent.code.text = PHARMAC Subsidy``resource.propertyGroup.priceComponent.amount.value = 70.91``resource.propertyGroup.priceComponent.amount.currency = NZD` | In this example, the reimbursement outcome is held in the`priceComponent`block. This is the part of the payload that holds the actual funding value returned for the case. |

#### What is JSON Schema?

**JSON Schema** is a standard language for describing the structure and validation rules of JSON data. Think of it as a "blueprint" that specifies:

* What fields must be present
* What type each field must be (text, number, true/false)
* What values are acceptable
* When certain fields become mandatory based on other values

**Real-world analogy:** If a funding rule is a set of eligibility criteria, JSON Schema is the structured specification that says: "This medication is funded only if: Provider type is X, AND special conditions Y are met."

#### How Pharmac Uses JSON Schema for Funding Rules

Pharmac embeds a **JSON Schema** inside each Funding Rules ChargeItemDefinition resource. This schema defines:

1. **Funding Case Structure**— What different scenarios apply (e.g., "Hospital use", "Community use with Special Authority")
1. **Eligibility Conditions**— What criteria must be met for funding to apply
1. **Provider Restrictions**— Who is eligible to prescribe (e.g., specialists, hospitals, authorized providers)
1. **Special Authorizations**— When a Special Authority (SA) is required
1. **Validation Rules**— What combination of conditions is valid

#### Example Flow

```
Pharmacy requests reimbursement for a medication
                    ↓
System checks applicable funding rules using the embedded JSON Schema:
  • Identify which case applies (e.g., provider type: hospital vs. community)
  • Validate required conditions are met (e.g., SA required?)
  • Check special endorsements or restrictions
                    ↓
Schema validates the claim data against the defined rules
                    ↓
If valid → Reimbursement approved
If invalid → Error shows what conditions are not met

```

#### Funding Rule Schema Structure

Each Funding Rule schema is an object containing **Case definitions**. Each case represents a specific funding scenario with its own set of conditions and requirements.

##### Key Components

| | | |
| :--- | :--- | :--- |
| **Case** | A distinct funding scenario (e.g., "Hospital use", "Community with SA") | `"Case-1"` |
| **Properties** | Fields/conditions that apply to that case | `{"authority", "provider"}` |
| **Required** | Fields that MUST be met for the case to apply | `["provider"]` |
| **Type** | Data type for each field | `boolean`,`string`,`integer` |
| **Description** | Explanation of what the field represents | `"Authorised Providers"`,`"Hospital"` |

#### Pharmac Custom Schema Extensions

Pharmac uses custom keywords (prefixed with `$`) to add metadata specific to funding rules:

| | | | |
| :--- | :--- | :--- | :--- |
| `$caseNumber` | string | Identifier for the funding case | `"Case-1"` |
| `$description` | string | Clinical/funding scenario this case covers | `"For use within a Primary Response in Medical Emergencies"` |
| `$authority` | string | Special Authority code if required | `"SA9999"` |

-------

#### Clexane 100mg 1ml Syringe — Example Cases

The medication **Clexane 100mg 1ml Syringe** has **three distinct funding cases**, each with different conditions:

#### Case 1: Special Authority Required

```
{
  "$schema": "http://json-schema.org/draft-07/schema#",
  "title": "Clexane 100mg 1ml Syringe Case 1",
  "type": "object",
  "properties": {
    "authority": {
      "title": "SA9999",
      "$url": "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-SA9999-Authorization",
      "type": "boolean",
      "description": "Has SA9999"
    },
    "provider": {
      "title": "Authorised Providers",
      "type": "boolean",
      "description": "Provider Type is Authorised Providers"
    }
  },
  "required": [
    "authority",
    "provider"
  ]
}

```

**When this case applies:**

* The medication is funded **only** when prescribed by an Authorised Provider
* A **Special Authority (SA9999)** approval is mandatory
* Both conditions must be satisfied for funding to be approved

-------

#### Case 2: Endorsed Service Use

```
{
  "$schema": "http://json-schema.org/draft-07/schema#",
  "title": "Clexane 100mg 1ml Syringe Case 2",
  "type": "object",
  "properties": {
    "endorsement": {
      "title": "PRIME Service Endorsement",
      "type": "boolean",
      "description": "For use within a Primary Response in Medical Emergencies (PRIME) service"
    },
    "provider": {
      "title": "Authorised Providers",
      "type": "boolean",
      "description": "Provider Type is Authorised Providers"
    }
  },
  "required": [
    "endorsement",
    "provider"
  ]
}

```

**When this case applies:**

* The medication is funded for use **only** within an approved PRIME service
* The provider must be an **Authorised Provider** for the PRIME service
* Endorsement documentation from the service is required
* Both conditions must be satisfied

-------

#### Case 3: Hospital Use Only

```
{
  "$schema": "http://json-schema.org/draft-07/schema#",
  "title": "Clexane 100mg 1ml Syringe Case 3",
  "type": "object",
  "properties": {
    "provider": {
      "title": "Hospital",
      "type": "boolean",
      "description": "Provider Type is Hospital"
    }
  },
  "required": [
    "provider"
  ]
}

```

**When this case applies:**

* The medication is funded **only** for hospital use
* No Special Authority or additional endorsement required
* Prescriber must be hospital-based

-------

#### How Cases Are Applied

When a claim for Clexane is submitted, the funding system:

1. **Identifies the prescriber/provider**(Hospital, Authorized Provider, PRIME service, etc.)
1. **Determines which case(s) might apply**based on the provider type
1. **Validates the claim against the case schema**:
* **Case 1 applies?** → Check SA9999 approval exists AND provider is authorized
* **Case 2 applies?** → Check PRIME endorsement AND provider is authorized
* **Case 3 applies?** → Check provider is hospital-based

1. **Returns approval if any case is satisfied**

-------

#### Key Concepts

#### Required vs. Optional Fields

* **`"required": ["authority", "provider"]`** means **both** fields must be true for the case to apply
* **`"required": ["provider"]`** means only the provider restriction applies; other conditions are optional
* If a field is not in `required`, it doesn't need to be checked

#### Field Types

* **`"type": "boolean"`** → Yes/No decision (true = condition met, false = not met)
* **`"type": "string"`** → Text value (e.g., provider name, authorization code)
* **`"type": "integer"`** → Numeric value (e.g., age, dosage quantity)

#### Property Descriptions

The `description` field explains what each condition means in plain language. This helps:

* Implementers understand the funding rule
* Form builders present clear questions to users
* Audit systems document what was checked

-------

## Integration with ChargeItemDefinition

Each Funding Rule case maps directly to a **ChargeItemDefinition** resource with profile `PharmacChargeItemDefinitionFundingRules`.

The JSON Schema is embedded in the resource's `applicability` element, making it part of the FHIR representation and available for:

* Dynamic form generation
* Automated eligibility checking
* Integration with pharmacy systems
* Regulatory reporting

For details on how to retrieve and use these schemas, see [API documentation](api.md) and [Examples](examples.md).

