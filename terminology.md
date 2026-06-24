# Terminology - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* **Terminology**

## Terminology

# Pharmac FHIR API Terminology Guidance

This implementation guide uses a number of terminology components

## List of terminology services used

| | |
| :--- | :--- |
| NZMT | The New Zealand Medicines Terminology code set is the standard coding system used in New Zealand to uniquely identify medicines, including generic/trade names, strengths, forms, and pack sizes. Codes from this code set are used in`Medication.code`. For a simple way to browse the codes you can use the[NZMT Shrimp browser](https://ontoserver.csiro.au/shrimp/?view=vs&system=http%3A%2F%2Fnzmt.org.nz&concept=10334421000116108&version=20251106&valueset=https%3A%2F%2Fnzhts.digital.health.nz%2Ffhir%2FValueSet%2Fnzmt-tpp&fhir=https%3A%2F%2Fnzhts.digital.health.nz%2Ffhir)or progamatically you could use a tool such as Postman to search the terminology service -[example search string](https://nzhts.digital.health.nz/fhir/ValueSet/$expand?_format=json&url=https%3A%2F%2Fnzhts.digital.health.nz%2Ffhir%2FValueSet%2Fnzmt-ctpp&filter=Gaviscon-Infant&valueSetVersion=20251106&includeDesignations=true&count=100&elements=expansion.contains.code,expansion.contains.display,expansion.contains.fullySpecifiedName,expansion.contains.active) |

