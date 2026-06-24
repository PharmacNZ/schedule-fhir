# API - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* **API**

## API

# FHIR API search examples

This page describes the search capabilities of the PHARMAC Schedule FHIR API, including the custom search parameters defined by this Implementation Guide and examples of the resulting search Bundles.

## General search behaviour

The API follows standard [FHIR R4 search](https://hl7.org/fhir/R4/search.html) conventions.

* **Pagination** — Searches return 10 matching resources per page by default. The server supports up to 1000 matching resources per page using the `_count` parameter. Clients should follow the paging links in the returned Bundle to retrieve the complete result set.
* **Totals** — The server does not return an accurate `Bundle.total` by default. Include `_total=accurate` when an accurate count of matching resources is required.
* **Format** — The API returns FHIR JSON using the `application/fhir+json` media type.
* **Authentication** — Requests require a Bearer token in the `Authorization` header.

## Custom search parameters

This Implementation Guide defines custom search parameters for PHARMAC-specific elements and extensions.

### Medication search parameters

| | | | |
| :--- | :--- | :--- | :--- |
| `name` | string | Search by the Medication name represented in`Medication.code.text` | `Medication?name=Etoposide` |
| `category` | string | Search by the Medication ATC classification | `Medication?category=L01CB01` |
| `code` | token | Search by a code in`Medication.code`, including an NZMT CTPP code | `Medication?code=50225401000117106` |

String search parameters may support the standard FHIR string modifiers, including `:contains` and `:exact`.

```
GET [base]/Medication?name:contains=etoposide HTTP/1.1

```

### ChargeItemDefinition search parameters

| | | | |
| :--- | :--- | :--- | :--- |
| `instance` | reference | Search by the associated`Medication`reference and support reverse inclusion from Medication searches | `ChargeItemDefinition?instance=Medication/50225401000117106` |
| `cid-code` | token | Search by a value held in`ChargeItemDefinition.code`, including a Special Authority code | `ChargeItemDefinition?cid-code=SA1683` |
| `device-definition-reference` | reference | Search by an associated`DeviceDefinition`reference where device records are supported | `ChargeItemDefinition?device-definition-reference=DeviceDefinition/456` |
| `pricing-effective-date` | date | Search by the effective date extension using a literal date or a FHIR date prefix | `ChargeItemDefinition?pricing-effective-date=2026-02-01` |
| `_profile` | uri | Restrict the search to resources conforming to a specified profile | `ChargeItemDefinition?_profile=pharmac-charge-item-definition-funding-rules` |

Date searches may use standard FHIR date prefixes.

```
GET [base]/ChargeItemDefinition?pricing-effective-date=gt2026-02-01 HTTP/1.1

```

```
GET [base]/ChargeItemDefinition?pricing-effective-date=lt2026-02-01 HTTP/1.1

```

## Retrieving related resources

A Funding Rules or Special Authority `ChargeItemDefinition` can reference an associated `Medication` through `ChargeItemDefinition.instance`.

The `_revinclude` parameter can therefore be used to return a matching `Medication` together with the `ChargeItemDefinition` resources that reference it.

```
GET [base]/Medication?code=50225401000117106&_revinclude=ChargeItemDefinition:instance HTTP/1.1

```

The resulting search Bundle can contain:

* the matching `Medication` resource;
* related Funding Rules `ChargeItemDefinition` resources; and
* related Special Authority `ChargeItemDefinition` resources, where applicable.

The directly matched Medication has `Bundle.entry.search.mode` set to `match`. Resources returned through `_revinclude` have `Bundle.entry.search.mode` set to `include`.

`Bundle.total` counts matching resources only. It does not include resources added to the Bundle through `_revinclude`.

## Search examples

### Retrieve all Medications

Retrieve all `Medication` resources available through the API.

```
GET [base]/Medication?_count=1000&_total=accurate HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

### Search Medication by name

Search for Medications by their product name.

```
GET [base]/Medication?name=Etoposide HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

A partial name search can be requested using `:contains`.

```
GET [base]/Medication?name:contains=etoposide HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

### Search Medication by product code

Search for the Etoposide Medication using its NZMT CTPP code.

```
GET [base]/Medication?code=50225401000117106 HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

### Search Medication by ATC classification

Search for Medications using an ATC classification value.

```
GET [base]/Medication?category=L01CB01 HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

### Retrieve a Medication with related ChargeItemDefinitions

Retrieve the Etoposide Medication together with the Funding Rules and Special Authority `ChargeItemDefinition` resources that reference it.

```
GET [base]/Medication?code=50225401000117106&_revinclude=ChargeItemDefinition:instance HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

The sample Bundle contains:

* `Medication-50225401000117106` as the matching resource;
* three community Funding Rules records;
* one hospital Funding Rules record; and
* `ChargeItemDefinition-SA1683-Authorization` as an included Special Authority definition.

### Retrieve all Funding Rules ChargeItemDefinitions

Retrieve all `ChargeItemDefinition` resources conforming to the `PharmacChargeItemDefinitionFundingRules` profile.

```
GET [base]/ChargeItemDefinition?_profile=pharmac-charge-item-definition-funding-rules&_count=1000&_total=accurate HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

### Search Funding Rules by Medication reference

Retrieve Funding Rules records that reference a particular Medication.

```
GET [base]/ChargeItemDefinition?instance=Medication/50225401000117106 HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

### Search Funding Rules by effective date

Retrieve Funding Rules records with the specified effective date.

```
GET [base]/ChargeItemDefinition?_profile=pharmac-charge-item-definition-funding-rules&pricing-effective-date=2026-02-01 HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

Retrieve Funding Rules records effective after the specified date.

```
GET [base]/ChargeItemDefinition?_profile=pharmac-charge-item-definition-funding-rules&pricing-effective-date=gt2026-02-01 HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

### Search ChargeItemDefinition by Special Authority code

Search for the Special Authority definition identified by `SA1683`.

```
GET [base]/ChargeItemDefinition?cid-code=SA1683 HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

### Retrieve all Special Authority ChargeItemDefinitions

Retrieve all `ChargeItemDefinition` resources conforming to the `PharmacChargeItemDefinitionSpecialAuthority` profile.

```
GET [base]/ChargeItemDefinition?_profile=pharmac-charge-item-definition-special-authority&_count=1000&_total=accurate HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

