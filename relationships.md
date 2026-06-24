# Resource Relationships - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* **Resource Relationships**

## Resource Relationships

# Medication and ChargeItemDefinition Relationships

## Overview

This page describes how PHARMAC Schedule FHIR resources are related to each other.

The relationship model is centred on the scheduled product, represented as a `Medication`, and the related `ChargeItemDefinition` resources that describe funding rules and Special Authority definitions.

This page focuses on how resources link together. Resource structure and profile-specific data elements are described in the data model section. API query syntax and search behaviour are described in the API section.

## Relationship diagram

## Core relationship model

The current relationship model uses the following resource relationships:

```
Medication
  ├── Funding Rules ChargeItemDefinition
  └── Special Authority ChargeItemDefinition

```

A `Medication` represents the scheduled product. Related `ChargeItemDefinition` resources describe the funding rules and Special Authority definitions that apply to that product.

The relationship is held from the `ChargeItemDefinition` back to the `Medication` using the `instance` element.

```
ChargeItemDefinition.instance -> Medication

```

This means the `Medication` does not need to contain a list of all related funding or authorisation records. Instead, each related `ChargeItemDefinition` identifies the product it applies to.

## Medication to Funding Rules ChargeItemDefinition

A `Medication` may have one or more related Funding Rules `ChargeItemDefinition` resources.

Each Funding Rules `ChargeItemDefinition` represents a funding or reimbursement rules record for the product.

Examples of funding rules relationships include:

```
Medication
  ├── Community funding rules record
  ├── Community funding rules case sequence
  └── Hospital funding rules record

```

A product may have multiple funding records because the Schedule can describe different funding contexts for the same product.

For example, a single `Medication` may have:

* one or more community funding rules records;
* one or more hospital funding rules records; or
* multiple case sequences for the same funding type.

Each funding rules record links back to the relevant `Medication` through `ChargeItemDefinition.instance`.

## Medication to Special Authority ChargeItemDefinition

A `Medication` may also have one or more related Special Authority `ChargeItemDefinition` resources.

A Special Authority `ChargeItemDefinition` represents a Special Authority form definition, such as `SA1098`.

The relationship allows a consumer to identify which Special Authority definitions are associated with a scheduled product.

```
Medication
  └── Special Authority ChargeItemDefinition
        └── SA form code

```

A Special Authority definition may apply to one product or to multiple products, depending on how the Schedule represents the authority.

Where applicable, the Special Authority `ChargeItemDefinition` references the associated product using `instance`.

## Funding Rules ChargeItemDefinition to Special Authority ChargeItemDefinition

A Funding Rules `ChargeItemDefinition` may indicate that a Special Authority applies to a funding rules record.

This creates a logical relationship between:

* the funding rules record; and
* the Special Authority form definition.

The funding record represents the funding rules for the product. The Special Authority record represents the form definition for the authority referenced by those rules.

```
Funding Rules ChargeItemDefinition
  └── authority requirement
        └── Special Authority ChargeItemDefinition

```

This relationship is based on the Special Authority identifier, such as `SA1098`.

For example:

```
Medication-50289761000117107
  ├── ChargeItemDefinition-50289761000117107-Community-Case-1
  │     └── authority requirement: SA1098
  │
  └── ChargeItemDefinition-SA1098-Authorization
        └── Special Authority definition for SA1098

```

The funding rules record and the Special Authority record remain separate resources because they describe different concepts:

| | |
| :--- | :--- |
| Funding Rules`ChargeItemDefinition` | Describes the funding rules record that applies to the product |
| Special Authority`ChargeItemDefinition` | Describes the Special Authority form definition |
| `Medication` | Represents the scheduled product both records relate to |

## Example relationship

The following example shows how a product, its funding rules records, and its Special Authority definition relate to each other.

```
Medication-50289761000117107
  Heparon Junior

  Referenced by:
    ChargeItemDefinition-50289761000117107-Community-Case-1
      Funding rules record for the product
      May indicate Special Authority SA1098 applies

    ChargeItemDefinition-50289761000117107-Hospital-Case-5
      Hospital funding rules record for the product

    ChargeItemDefinition-SA1098-Authorization
      Special Authority definition for SA1098

```

In this example:

* the `Medication` represents the product;
* the Funding Rules `ChargeItemDefinition` records represent funding rules records for that product; and
* the Special Authority `ChargeItemDefinition` represents the form definition associated with the relevant SA code.

## Relationship principles

The relationship model follows these principles:

| | |
| :--- | :--- |
| Product-centred | `Medication`is the central product resource |
| Referenced by rule resources | Funding Rules and Special Authority`ChargeItemDefinition`resources reference the relevant`Medication` |
| Multiple related records | A single product may have multiple related`ChargeItemDefinition`resources |
| Separate concerns | Funding rules records and Special Authority definitions are represented separately |
| Shared authority definitions | A Special Authority definition may be associated with more than one product where applicable |
| Logical authority link | A funding rules record may point to a Special Authority by SA identifier |

## Bundle interpretation

When related resources are returned together in a Bundle, consumers should distinguish between:

| | |
| :--- | :--- |
| Match resource | The resource directly matched by the request |
| Included resource | A related resource returned because it is linked to the matched resource |

In a product-centred result, the `Medication` is typically the matched resource and the related `ChargeItemDefinition` resources are included resources.

The API section describes the specific search parameters used to request these relationships.

## Relationship boundaries

The relationship model describes how Schedule resources are connected.

It does not define:

* product field structure;
* funding rules field structure;
* Special Authority field structure;
* application workflow;
* approval workflow;
* case submission processing; or
* consumer-side validation behaviour.

Those topics are covered separately where required.

