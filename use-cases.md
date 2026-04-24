# Use Cases - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* **Use Cases**

## Use Cases

### Pharmacy system retrieves Pharmac Schedule data

Pharmacy dispensing systems can query the Pharmac Schedules FHIR API to keep local catalogs up to date with funded medicines and devices.

Typical flow:

1. The pharmacy system authenticates with the API using approved client credentials.
1. It queries`Medication`resources for relevant medicines (e.g., by identifier, code, or name).
1. It queries`DeviceDefinition`resources for relevant devices (e.g., by identifier, code, or name).
1. The system stores key schedule attributes locally for dispensing and decision support.
1. It periodically refreshes data to reflect schedule changes.

### Real-time lookup during dispensing

During dispensing, a pharmacist can search the API for the current schedule status of a medicine or device:

1. Search by medicine code or name in`Medication`.
1. Search by device code or name in`DeviceDefinition`.
1. Display returned details to confirm funding and restrictions.

