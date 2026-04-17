# Api - Pharmac Schedules FHIR API v1.0.0

* [**Table of Contents**](toc.md)
* **Api**

## Api

# FHIR API search examples

This page describes the search capabilities of the Pharmac Schedules FHIR API, including custom search parameters and example queries.

## General search behaviour

The API follows standard [FHIR R4 search](https://hl7.org/fhir/R4/search.html) conventions. Key points:

* **Pagination** — Bulk searches return 10 results per page by default. The server supports up to 1000 results per page via the `_count` parameter. FHIR clients should use pagination to retrieve the full result set — see [paging in the FHIR specification](https://hl7.org/fhir/R4/search.html#count).
* **Totals** — By default the server does not return the `total` property. Include `_total=accurate` to request an accurate total count.
* **Format** — The server returns JSON (`application/fhir+json`) only.
* **Authentication** — All requests require a Bearer token via the `Authorization` header.

## Custom search parameters

This IG defines custom search parameters that extend the standard FHIR search capabilities. These enable searching on Pharmac-specific extensions and fields.

### Medication search parameters

| | | | |
| :--- | :--- | :--- | :--- |
| `name` | string | Search by medication name (`code.text`) | `Medication?name=Leuprorelin` |
| `brand` | string | Search by brand name extension | `Medication?brand=Gaviscon` |
| `category` | string | Search by ATC category (levels 1, 2, or 3) | `Medication?category=Alimentary tract` |
| `code` | token | Search by NZMT code (standard FHIR) | `Medication?code=46616121000116103` |

String search parameters support the FHIR [string search](https://hl7.org/fhir/R4/search.html#string) modifiers including `:contains` and `:exact`:

```
GET [base]/Medication?name:contains=paracetamol HTTP/1.1

```

### ChargeItemDefinition search parameters

| | | | |
| :--- | :--- | :--- | :--- |
| `instance` | reference | Reference to associated Medication — enables`_revinclude` | `ChargeItemDefinition?instance=Medication/123` |
| `cid-code` | token | Search by code (e.g. special authority code) | `ChargeItemDefinition?cid-code=SA2520` |
| `device-definition-reference` | reference | Reference to associated DeviceDefinition via extension | `ChargeItemDefinition?device-definition-reference=DeviceDefinition/456` |
| `_profile` | uri | Filter by profile (standard FHIR) | `ChargeItemDefinition?_profile=...special-authority` |

### DeviceDefinition search parameters

| | | | |
| :--- | :--- | :--- | :--- |
| `device-name` | string | Search by device name | `DeviceDefinition?device-name=BIOGLUE` |
| `manufacturer` | string | Search by manufacturer name | `DeviceDefinition?manufacturer=Obex` |
| `category` | string | Search by device category (levels 1, 2, or 3) | `DeviceDefinition?category=Surgical` |

## Using _revinclude to retrieve related resources

The `_revinclude` parameter allows you to retrieve a `Medication` (or `DeviceDefinition`) together with its associated `ChargeItemDefinition` resources (pricing, funding rules, special authorities) in a single request. This is the recommended pattern for retrieving complete schedule information.

```
GET [base]/Medication?name=Leuprorelin&_revinclude=ChargeItemDefinition:instance HTTP/1.1

```

This works because `ChargeItemDefinition.instance` references the `Medication` resource. The custom `instance` search parameter defined in this IG enables the server to resolve these reverse references.

## Search examples

### Retrieve all Medications

Search for all `Medication` resources in the system.

```
GET [base]/Medication?_count=1000&_total=accurate HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

### Search Medication by brand name

```
GET [base]/Medication?brand=Gaviscon HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

### Search Medication by ATC category

```
GET [base]/Medication?category=Alimentary+tract HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

### Search Medication with associated ChargeItemDefinitions

Search for Medications including associated `ChargeItemDefinition` resources. A `Medication` may have multiple associated `ChargeItemDefinition` resources — e.g. one for pricing and another for special authority rules.

```
GET [base]/Medication?name=Clexane&_revinclude=ChargeItemDefinition:instance HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

### Complex medication with pricing and special authorization

Search for a medication by NZMT code, returning pricing and special authorization requirements.

```
GET [base]/Medication?code=46616121000116103&_revinclude=ChargeItemDefinition:instance HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

This search demonstrates a real-world scenario where a pharmaceutical product has multiple `ChargeItemDefinition` resources:

1. **Medication Resource**— The base medication record containing product identifiers, brand name, dosage form, and clinical information
1. **Pricing ChargeItemDefinition**— Contains listed price, PHARMAC subsidy amount, patient surcharge, and calculated patient co-payment
1. **Authorization ChargeItemDefinition**— Contains special authorization (SA) requirements, including the SA form code and eligibility criteria

In this example:

* **Product**: Tenofovir disoproxil
* **Pricing**: Listed at NZD with PHARMAC subsidy
* **Authorization**: Requires SA2139 or SA2520 form with different approval criteria for conditions like HIV positive status

The search response returns all three resources, allowing clients to:

* Display medication details and brand information
* Calculate patient costs using pricing components
* Check authorization requirements before dispensing
* Access eligibility criteria for special authorization

