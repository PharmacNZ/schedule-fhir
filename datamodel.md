# Datamodel - Pharmac Schedules FHIR API v1.0.0

* [**Table of Contents**](toc.md)
* **Datamodel**

## Datamodel

### FHIR Data Models

This section provides an overview of the design of the FHIR data representations that authorised applications can use to record and interchange PHARMAC FHIR data.

#### Overview

### Relationships

Our API utilises relationships to link resources together. There is only ever one instance of a [Medication](./StructureDefinition-pharmac-medication.md) or a [DeviceDefinition](./StructureDefinition-pharmac-device-definition.md). There may be multiple `ChargeItemDefinitions` related to an instance of a `Medication` or `DeviceDefinition`.

### ChargeItemDefinition Pricing

Each instance of a `Medication` or `DeviceDefinition` will have an associated `ChargeItemDefinition` that indicates lists the price.

The pricing is contained in the `propertyGroup` component of the resource. Note that this structure is extensible and contains a number of `priceComponent` properties - see example below.

```
"propertyGroup": [
    {
        "applicability": [
            {
                "description": "Community (subsidized) pricing"
            }
        ],
        "priceComponent": [
            {
                "type": "base",
                "code": {
                    "text": "Listed Price"
                },
                "amount": {
                    "value": 8.06,
                    "currency": "NZD"
                }
            },
            {
                "type": "discount",
                "code": {
                    "text": "PHARMAC Subsidy"
                },
                "amount": {
                    "value": 8.06,
                    "currency": "NZD"
                }
            },
            {
                "type": "surcharge",
                "code": {
                    "text": "Patient Surcharge"
                },
                "amount": {
                    "value": 0.00000,
                    "currency": "NZD"
                }
            },
            {
                "type": "informational",
                "code": {
                    "text": "Patient Co-Payment"
                },
                "amount": {
                    "value": 0.00,
                    "currency": "NZD"
                }
            }
        ]
    },
    {
        "applicability": [
            {
                "description": "Alternative pricing structure"
            }
        ],
        "priceComponent": [
            {
                "type": "base",
                "code": {
                    "text": "Alternative Listed Price"
                },
                "amount": {
                    "value": 8.06,
                    "currency": "NZD"
                }
            },
            {
                "type": "discount",
                "code": {
                    "text": "Alternative Subsidy/Reimbursement"
                },
                "amount": {
                    "value": 8.06,
                    "currency": "NZD"
                }
            },
            {
                "type": "informational",
                "code": {
                    "text": "Alternative Patient Cost"
                },
                "amount": {
                    "value": 0.00,
                    "currency": "NZD"
                }
            }
        ]
    }
]

```

### Charge Item Definition Conditions and Authorisations

A `ChargeItemDefinition` may also exist where there are additional rules that apply to the resource. For example, a special authority or a set of funding conditions or rules.

**Approach:** The API stores authorization and funding rules as Base64-encoded JSON Schema documents in the `authorizationSchema` extension. These schemas enable:

* Client-side form validation
* Dynamic form generation based on authorization case requirements
* Structured data submission validation

