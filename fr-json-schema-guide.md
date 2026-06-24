# JSON Schema for Funding Rules - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* **JSON Schema for Funding Rules**

## JSON Schema for Funding Rules

# JSON Schema for Funding Rules

## Overview

Funding and reimbursement cases are represented by `ChargeItemDefinition` resources conforming to the `PharmacChargeItemDefinitionFundingRules` profile.

Each resource represents one funding case for a scheduled product. The record carries the funding context, subsidy outcome, Schedule attributes, effective date, and—where conditions apply—a JSON Schema document in the `authorization-schema` extension.

The API publishes this structured information for consumers. It does not receive funding applications, validate submitted case data, or determine reimbursement outcomes.

## Relationship to Medication

The Funding Rules resource references the scheduled product through `ChargeItemDefinition.instance`.

```
Funding Rules ChargeItemDefinition.instance -> Medication

```

A single Medication can have multiple Funding Rules records, including different community or hospital cases and multiple case sequences.

## Funding Rules resource context

The following elements provide the FHIR context around the condition schema.

| | |
| :--- | :--- |
| `instance` | References the associated`Medication` |
| `pricing-effective-date` | Date from which the funding case applies |
| `funding-rule` | Funding type, case sequence, and funding mechanism |
| `funding-subsidy-amount` | Subsidy type, status, amount, and display label |
| `schedule-funding-attributes` | Grouped Schedule funding attributes |
| `authorization-schema` | Base64-encoded JSON Schema where conditions apply |
| `applicability.description` | Human-readable summary of the funding case |

### Example FHIR context

```
{
  "resourceType": "ChargeItemDefinition",
  "id": "ChargeItemDefinition-50289761000117107-Community-Case-1",
  "meta": {
    "profile": [
      "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    ]
  },
  "instance": [
    {
      "reference": "Medication/50289761000117107"
    }
  ],
  "extension": [
    {
      "url": "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/funding-rule",
      "extension": [
        {
          "url": "type",
          "valueCode": "community"
        },
        {
          "url": "rule",
          "extension": [
            {
              "url": "type",
              "valueCode": "CaseSequence"
            },
            {
              "url": "value",
              "valueInteger": 1
            }
          ]
        },
        {
          "url": "rule",
          "extension": [
            {
              "url": "type",
              "valueCode": "FundingMechanism"
            },
            {
              "url": "attribute",
              "valueCode": "Prescription"
            }
          ]
        }
      ]
    },
    {
      "url": "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/funding-subsidy-amount",
      "extension": [
        {
          "url": "subsidyType",
          "valueCode": "subsidy"
        },
        {
          "url": "subsidyStatus",
          "valueCode": "full"
        },
        {
          "url": "amount",
          "valueMoney": {
            "value": 93.94,
            "currency": "NZD"
          }
        },
        {
          "url": "display",
          "valueString": "Subsidy"
        }
      ]
    },
    {
      "url": "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema",
      "valueBase64Binary": "..."
    },
    {
      "url": "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date",
      "valueDate": "2026-04-24"
    }
  ]
}

```

## Funding-condition schema

The `authorization-schema` extension contains a Base64-encoded JSON Schema document. After decoding, the schema describes the conditions associated with the funding case.

A funding-condition schema uses the standard JSON Schema object structure:

* `$schema` identifies the JSON Schema draft;
* `title` identifies the product and case;
* `type` is `object`;
* `properties` contains the condition fields; and
* `required` identifies the mandatory conditions for that case.

### Example decoded schema

The following example represents the community funding case for `Medication/50289761000117107`.

```
{
  "$schema": "http://json-schema.org/draft-07/schema#",
  "title": "Conditions-50289761000117107-Case-1",
  "type": "object",
  "properties": {
    "authority": {
      "title": "Special Authority",
      "type": "integer",
      "description": "https://schedule.pharmac.govt.nz/latest/SA1098.pdf",
      "const": 1098
    },
    "provider": {
      "title": "Provider Information",
      "type": "boolean",
      "description": "Provider Information Here"
    }
  },
  "required": [
    "authority",
    "provider"
  ]
}

```

## Condition types

Funding schemas can contain the following condition types, depending on the Schedule case.

| | | |
| :--- | :--- | :--- |
| `authority` | Identifies a required Special Authority | `integer` |
| `restriction` | Identifies a restriction form | `integer` |
| `limit` | Represents a numeric funding limit | `number` |
| `provider` | Represents provider information or requirements | `boolean` |
| `endorsement` | Represents an endorsement requirement | `boolean` |
| `note` | Carries a Schedule note or memorandum condition | `boolean` |

### Authority and restriction conditions

Authority and restriction properties use a numeric constant for the form number. The `description` contains the relevant form URL.

```
{
  "authority": {
    "title": "Special Authority",
    "type": "integer",
    "description": "https://schedule.pharmac.govt.nz/latest/SA1098.pdf",
    "const": 1098
  }
}

```

### Limit conditions

Limit properties use the numeric value as `const` and can include the unit using `$unit`.

```
{
  "limit": {
    "title": "FormMax",
    "type": "number",
    "description": "Maximum quantity limit per dose",
    "const": 5,
    "$unit": "tab"
  }
}

```

### Text-based conditions

Provider, endorsement, and note conditions use the `description` field for the Schedule wording.

```
{
  "endorsement": {
    "title": "Endorsement",
    "type": "boolean",
    "description": "Prescription must be endorsed accordingly."
  }
}

```

## Required conditions

The schema-level `required` array identifies which condition properties are mandatory for the funding case.

```
{
  "required": [
    "authority",
    "provider"
  ]
}

```

A property can appear in `properties` without being listed in `required` when it is optional for that case.

## Cases without condition logic

Where a hospital funding record exists but has no associated condition logic, the example data uses the literal value `N/A` in `authorization-schema.valueBase64Binary`.

This indicates that the funding record exists but no condition schema is supplied for that case.

## Consumer use

A consuming application may decode the schema to:

* display the funding conditions associated with the case;
* guide local user-interface generation;
* map the condition structure into its own business processes; or
* perform local validation where appropriate to the consumer's implementation.

These activities are performed by the consuming system. The PHARMAC Schedule API publishes the structured data and does not process or approve submitted cases.

## Related pages

* [Funding Rules profile](StructureDefinition-pharmac-charge-item-definition-funding-rules.md)
* [Resource Relationships](relationships.md)
* [API](api.md)
* [Examples](examples.md)

