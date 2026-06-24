# Use Cases - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* **Use Cases**

## Use Cases

### Pharmacy system retrieves PHARMAC Schedule data

Pharmacy and clinical systems can use the PHARMAC Schedule FHIR API to retrieve current product, funding, and Special Authority information.

A typical retrieval flow is:

1. The client authenticates using its approved credentials.
1. The client retrieves the relevant`Medication`resource.
1. The client retrieves related Funding Rules and Special Authority`ChargeItemDefinition`resources.
1. The client displays or stores the returned Schedule information for its own business processes.
1. The client periodically refreshes the data to reflect Schedule changes.

### Funding-rule lookup

A consumer can retrieve the product and the related funding-rule records needed to understand the Schedule context for that product.

The API returns structured Schedule resources. It does not receive or process funding applications, validate submitted case data, or determine approval outcomes.

