# Api - Pharmac Schedules FHIR API v0.0.1

* [**Table of Contents**](toc.md)
* **Api**

## Api

# FHIR API search examples

This page shows example REST searches against the Pharmac Schedules FHIR API.

## Search example: Medication option

HTTP Search request for Medications. This search will return **all** `Medication` resources in the system. Bulk searches return a total of 10 results per page by default however the server supports a maximum page size of 1000 results. This can be controlled using the `_count` request parameter. FHIR clients should use pagination to retrieve the full result set - see [paging in the FHIR specification for details](https://hl7.org/fhir/R4/search.html#count) By default the server will not return the `total` property in the response payload [See details in the FHIR specification here](https://hl7.org/fhir/R4/search.html#total). This can however be included by specifying the `_total=accurate` query parameter.

```
GET [base]/Medication?_count=1000&_total=accurate HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

## Search example: Medication with associated ChargeItemDefinition

HTTP Search request for Medications including associated `ChargeItemDefinition` resources. A `Medication` may have multiple associated `ChargeItemDefinition` resources e.g. a `ChargeItemDefinition` that lists the price associated with a `Medication` and another indicating it's rules or special authorities

```
GET [base]/Medication?name=Leuprorelin&_revinclude=ChargeItemDefinition:instance HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

## Search example: Complex medication with pricing and special authorization

HTTP Search request for a medication by NZMT code, returning pricing and special authorization requirements

```
GET [base]/fhir/Medication?code=46616121000116103&_revinclude=ChargeItemDefinition:instance HTTP/1.1
Accept: application/fhir+json
Authorization: Bearer xyz

```

This search demonstrates a real-world scenario where a pharmaceutical product has multiple `ChargeItemDefinition` resources:

1. **Medication Resource**- The base medication record containing product identifiers, brand name, dosage form, and clinical information
1. **Pricing ChargeItemDefinition**- Contains listed price, PHARMAC subsidy amount, patient surcharge, and calculated patient co-payment
1. **Authorization ChargeItemDefinition**- Contains special authorization (SA) requirements, including the SA form code and eligibility criteria

In this example:

* **Product**: Tenofovir disoproxil
* **Pricing**: Listed at NZD with PHARMAC subsidy
* **Authorization**: Requires SA2139 or SA2520 form with different approval criteria for conditions like HIV positive status

The search response returns all three resources, allowing clients to:

* Display medication details and brand information
* Calculate patient costs using pricing components
* Check authorization requirements before dispensing
* Access eligibility criteria for special authorization

