# Version History - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* **Version History**

## Version History

### 1.1.0 (2026-06-23)

**Profiles and Data Model**

* Updated the [Medication profile](StructureDefinition-pharmac-medication.md)
* Updated the [Funding Rule profile](StructureDefinition-pharmac-charge-item-definition-funding-rules.md)
* Updated the [Special Authority profile](StructureDefinition-pharmac-charge-item-definition-special-authority.md)
* Moved medication-specific funding attributes to Funding Rules
* Consolidated pricing and subsidy information into Funding Rules
* Removed the separate Pricing ChargeItemDefinition
* Removed deprecated product create date and brand elements
* Updated the [Data Models](datamodel.md)

**JSON Schema**

* Updated the [JSON Schema for Funding Rules](fr-json-schema-guide.md)
* Updated the [JSON Schema for Special Authorities](sa-json-schema-guide.md)
* Added support for Authority, Restriction, Limit, Provider, Endorsement, and Note conditions

**Examples**

* Updated [Medication, Funding Rule, Special Authority, Bundle, and search examples](examples.md)
* Corrected resource references, identifiers, effective dates, and search examples

**Documentation**

* Updated the [XML to FHIR Mapping](fhir-ig-to-xml.md)
* Updated the [API documentation](api.md)
* Updated the [resource relationships](relationships.md)

-------

### 1.0.1 (2026-04-24)

**Documentation**

* New guide: Added [XML to FHIR Mapping](fhir-ig-to-xml.md) — a guide for converting FHIR IG resources to XML
* [JSON Schema for Funding Rules](fr-json-schema-guide.md): Significant rewrite for clarity and conciseness
* [JSON Schema for Special Authorities](sa-json-schema-guide.md): Layout and content improvements
* [Data Models](datamodel.md): Minor corrections

**Examples**

* [Search examples](examples.md): Minor corrections

-------

### 1.0.0 (2026-04-17)

Initial release. ```

