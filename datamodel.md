# Data Models - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* **Data Models**

## Data Models

This section provides an overview of the FHIR data model used by the PHARMAC Schedule API.

The data model separates scheduled product information, funding case information, and Special Authority form information into distinct profiled FHIR resources.

### Overview

### Model structure

The current Schedule data model uses the following core profiles:

| | | |
| :--- | :--- | :--- |
| Scheduled pharmaceutical product | `Medication` | [pharmac-medication](./StructureDefinition-pharmac-medication.md) |
| Funding and reimbursement rules | `ChargeItemDefinition` | [pharmac-charge-item-definition-funding-rules](./StructureDefinition-pharmac-charge-item-definition-funding-rules.md) |
| Special Authority form definition | `ChargeItemDefinition` | [pharmac-charge-item-definition-special-authority](./StructureDefinition-pharmac-charge-item-definition-special-authority.md) |

Each profile represents a separate Schedule concept:

* `Medication` represents the scheduled product package.
* Funding Rules `ChargeItemDefinition` represents a funding or reimbursement rules record for a scheduled product.
* Special Authority `ChargeItemDefinition` represents a Special Authority form definition.

### Medication

The `PharmacMedication` profile represents a scheduled pharmaceutical product package.

It contains product-level data used to identify, describe, classify, and price the scheduled item.

Key data elements include:

| | |
| :--- | :--- |
| `id` | Resource identifier for the Medication record. In the examples this is the NZMT CTPP identifier. |
| `meta.profile` | Declares conformance to`pharmac-medication`. |
| `status` | Indicates the Medication record status. |
| `code.coding` | Holds product coding, including NZMT CTPP, GTIN where available, and PHARMAC subsidy code where available. |
| `form` | Describes the dose form. |
| `ingredient` | Describes active ingredient information. |
| `medication-nzmt-type` | Identifies the NZMT concept type represented by the Medication. |
| `medication-description` | Holds structured product description information. |
| `medication-atc` | Holds ATC classification where available. |
| `medication-pack` | Holds package quantity and pack information. |
| `medication-price` | Holds product price information. |

#### Medication identifiers

The FSH instance name may include a descriptive prefix, for example:

```
Instance: Medication-50014861000117106

```

The actual FHIR resource `id` uses the CTPP identifier:

```
* id = "50014861000117106"

```

This distinction is important when constructing references and Bundle `fullUrl` values.

#### Product coding

`Medication.code.coding` is used to carry product identifiers and product coding.

The coding set may include:

* NZMT CTPP code;
* GTIN, where available; and
* PHARMAC subsidy code, where available.

Where required, the `pharmac-is-primary-coding` extension identifies the primary product coding.

#### Product price

Price is represented on `Medication` using the `medication-price` extension.

Example:

```
{
  "url": "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price",
  "extension": [
    {
      "url": "price",
      "valueMoney": {
        "value": 180,
        "currency": "NZD"
      }
    }
  ]
}

```

### Funding Rules ChargeItemDefinition

Funding and reimbursement rules are represented using the `PharmacChargeItemDefinitionFundingRules` profile on `ChargeItemDefinition`.

The canonical profile id is:

```
pharmac-charge-item-definition-funding-rules

```

A Funding Rules `ChargeItemDefinition` represents a specific funding or reimbursement rules record for a scheduled product.

Key data elements include:

| | |
| :--- | :--- |
| `id` | Resource identifier for the funding rules record. |
| `meta.profile` | Declares conformance to`pharmac-charge-item-definition-funding-rules`. |
| `url` | Canonical URL for the funding rules definition. |
| `version` | Version of the funding rules definition. |
| `status` | Status of the funding rules definition. |
| `date` | Date associated with the resource definition. |
| `publisher` | Publisher of the definition. |
| `contact` | Contact details for the publisher. |
| `description` | Human-readable summary of the funding rules record. |
| `instance` | References the relevant scheduled item. |
| `pricing-effective-date` | Effective date for the funding rules record. |
| `funding-rule` | Holds funding rule and case information. |
| `authorization-schema` | Holds authorisation or condition information where applicable. |
| `funding-subsidy-amount` | Holds subsidy amount information. |
| `schedule-funding-attributes` | Holds additional Schedule funding attributes. |
| `applicability.description` | Human-readable applicability summary for the funding rules record. |

#### Funding rules identifiers

Funding Rules examples use the `PharmacChargeItemDefinitionFundingRules` profile:

```
InstanceOf: PharmacChargeItemDefinitionFundingRules

```

and declare the matching canonical profile:

```
* meta.profile[0] = "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"

```

#### Effective date

Funding Rules `ChargeItemDefinition` examples include the required effective date extension:

```
* extension[0].url = "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date"
* extension[0].valueDate = "2026-02-01"

```

Where the source case effective date is not populated, the examples use the Schedule publication date from the source Schedule file.

### Special Authority ChargeItemDefinition

Special Authority form definitions are represented using the `PharmacChargeItemDefinitionSpecialAuthority` profile on `ChargeItemDefinition`.

A Special Authority `ChargeItemDefinition` represents the Schedule definition for a Special Authority form.

Key data elements include:

| | |
| :--- | :--- |
| `id` | Resource identifier for the Special Authority definition. |
| `meta.profile` | Declares conformance to`pharmac-charge-item-definition-special-authority`. |
| `url` | Canonical URL for the Special Authority definition. |
| `version` | Version of the Special Authority definition. |
| `status` | Status of the Special Authority definition. |
| `date` | Date associated with the definition. |
| `publisher` | Publisher of the definition. |
| `contact` | Contact details for the publisher. |
| `description` | Human-readable summary of the Special Authority definition. |
| `code` | Special Authority form code, such as`SA1098`. |
| `instance` | References the relevant scheduled item where applicable. |
| `pricing-effective-date` | Effective date associated with the definition. |
| `authorization-case-count` | Number of Special Authority cases or pathways represented. |
| `authorization-schema` | Holds Special Authority content. |
| `authorization-form` | Holds the Special Authority form identifier. |

### Data model boundaries

The Schedule API provides structured Schedule data for scheduled products, funding rules records, and Special Authority form definitions.

The data model includes:

| | |
| :--- | :--- |
| Product identity and product-level attributes | `Medication` |
| Product pack information | `Medication.medication-pack` |
| Product price | `Medication.medication-price` |
| ATC classification | `Medication.medication-atc` |
| Funding and reimbursement rules | Funding Rules`ChargeItemDefinition` |
| Funding rule details | Funding Rules`ChargeItemDefinition.funding-rule` |
| Subsidy amount | Funding Rules`ChargeItemDefinition.funding-subsidy-amount` |
| Schedule funding attributes | Funding Rules`ChargeItemDefinition.schedule-funding-attributes` |
| Special Authority form definition | Special Authority`ChargeItemDefinition` |
| Special Authority form identifier | Special Authority`ChargeItemDefinition.authorization-form` |
| Special Authority case count | Special Authority`ChargeItemDefinition.authorization-case-count` |

The data model does not define:

* a funding application workflow;
* a Special Authority application workflow;
* approval processing; or
* case submission processing.

