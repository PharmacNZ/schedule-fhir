# API - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* **API**

## API

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
| `pricing-effective-date` | date | Search by pricing effective date extension - date search so literal or greater than / less than | `ChargeItemDefinition?pricing-effective-date=2024-01-01``ChargeItemDefinition?pricing-effective-date=gt2024-01-01``ChargeItemDefinition?pricing-effective-date=lt2024-01-01` |
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

