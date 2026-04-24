# Artifacts Summary - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* **Artifacts Summary**

## Artifacts Summary

This page provides a list of the FHIR artifacts defined as part of this implementation guide.

### Behavior: Capability Statements 

The following artifacts define the specific capabilities that different types of systems are expected to have in order to comply with this implementation guide. Systems conforming to this implementation guide are expected to declare conformance to one or more of the following capability statements.

| | |
| :--- | :--- |
| [Pharmac Schedules Capability Statement](CapabilityStatement-PharmacSchedulesCapabilityStatement.md) | Pharmac Schedules Capability Statement. This FHIR resource declares the capabilities of the Pharmac Schedules FHIR API, including supported interactions, resources, and security mechanisms. |

### Behavior: Search Parameters 

These define the properties by which a RESTful server can be searched. They can also be used for sorting and including related resources.

| | |
| :--- | :--- |
| [ChargeItemDefinitionCodeSearchParam](SearchParameter-ChargeItemDefinitionCodeSearchParam.md) | Allow ChargeItemDefinition search by code (usually special authority code) |
| [ChargeItemDefinitionDeviceReferenceSearchParam](SearchParameter-ChargeItemDefinitionDeviceReferenceSearchParam.md) | Reference from ChargeItemDefinition to DeviceDefinition via IG extension. Enables searching for pricing and authorization rules by associated device. |
| [ChargeItemDefinitionInstanceSearchParam](SearchParameter-ChargeItemDefinitionInstanceSearchParam.md) | Allow _revinclude from Medication to ChargeItemDefinition |
| [ChargeItemDefinitionPricingEffectiveDateSearchParam](SearchParameter-ChargeItemDefinitionPricingEffectiveDateSearchParam.md) | Search ChargeItemDefinition by pricing effective date extension |
| [ChargeItemDefinitionSACodeSearchParam](SearchParameter-ChargeItemDefinitionSACodeSearchParam.md) | Allow ChargeItemDefinition search by code eg special authority code |
| [MedicationBrandNameSearchParam](SearchParameter-MedicationBrandNameSearchParam.md) | Search for medications by brand name (e.g., 'Gaviscon', 'Acidex', 'Budesonide'). Enables fuzzy matching on the medication-brand-name extension for discovery by product name. |
| [MedicationCategorySearchParam](SearchParameter-MedicationCategorySearchParam.md) | Search for medications by category |
| [MedicationNameSearchParam](SearchParameter-MedicationNameSearchParam.md) | Search for medications by the text representation of the medication code (e.g., 'Gaviscon Infant', 'Acidex oral liquid'). Enables discovery by the full medication name or formulation description. |

### Structures: Resource Profiles 

These define constraints on FHIR resources for systems conforming to this implementation guide.

| | |
| :--- | :--- |
| [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md) | Profile for ChargeItemDefinition resources representing pricing, subsidy, and rules for devices and medications in the PHARMAC schedule. This profile allows FHIR consumers to use the _include search parameter to retrieve pricing information alongside device or medication resources. |
| [PHARMAC Charge Item Definition - Funding Rules](StructureDefinition-pharmac-charge-item-definition-funding-rules.md) | Profile for ChargeItemDefinition resources representing funding mechanisms and reimbursement rules in the PHARMAC schedule. This profile captures funding conditions, provider requirements, endorsement criteria, case sequences, and funding mechanism types (Prescription, BSO, Rural PSO, etc.). |
| [PHARMAC Charge Item Definition - Pricing](StructureDefinition-pharmac-charge-item-definition-pricing.md) | Profile for ChargeItemDefinition resources representing product pricing information for medications and devices in the PHARMAC schedule. This profile captures listed prices, PHARMAC subsidies, patient co-payments, and pricing-specific attributes such as contract type, DV limits, and statim requirements. |
| [PHARMAC Charge Item Definition - Special Authority](StructureDefinition-pharmac-charge-item-definition-special-authority.md) | Profile for ChargeItemDefinition resources representing Special Authorization (SA) requirements and clinical eligibility criteria in the PHARMAC schedule. This profile captures SA codes, authorization case counts, clinical eligibility, and references to medications requiring special authorization. |
| [PHARMAC Medication](StructureDefinition-pharmac-medication.md) | Profile for Medication resources representing pharmaceutical products in the PHARMAC schedule. This profile defines the structure for medications including brand identification, pack codes, product names, form, and ingredients. Pricing information is provided via related ChargeItemDefinition resources that can be retrieved using the _include search parameter. |

### Structures: Extension Definitions 

These define constraints on FHIR data types for systems conforming to this implementation guide.

| | |
| :--- | :--- |
| [Authorization Case Count](StructureDefinition-authorization-case-count.md) | The number of authorization cases or approval criteria specified in the authorization requirement. This indicates how many different clinical scenarios or conditions have distinct approval pathways. |
| [Authorization Form](StructureDefinition-authorization-form.md) | The special authorization form code required for this medication (e.g., 'SA2535'). This identifies the specific PHARMAC authorization form that prescribers must complete for patient eligibility. |
| [Authorization Schema](StructureDefinition-authorization-schema.md) | Base64-encoded JSON Schema that defines the structure and validation rules for a Special Authorization application form. The decoded content is a JSON Schema (application/schema+json). |
| [Authorization Title](StructureDefinition-authorization-title.md) | A human-readable title for the authorization requirement (e.g., 'Budesonide - Special Authorization Required'). This provides context for the authorization need. |
| [Brand Switch Fee](StructureDefinition-brand-switch-fee.md) | Indicates whether a brand switch fee applies for this item. |
| [Contract Type](StructureDefinition-contract-type.md) | Type of PHARMAC contract that applies to this item (for example, sole-supply, preferred). |
| [Cost Brand Source](StructureDefinition-cost-brand-source.md) | Indicates whether pricing for this item is sourced from a cost brand. |
| [Daily Volume Limit Percent](StructureDefinition-dv-limit-percent.md) | Percentage daily volume limit that applies to this item. |
| [Device Definition Reference](StructureDefinition-device-definition-reference.md) | Reference to a DeviceDefinition that this pricing applies to. Used because ChargeItemDefinition.instance can only reference Device, Medication, or Substance instances, not DeviceDefinition. For Medication, use ChargeItemDefinition.instance directly. |
| [Funding Rule](StructureDefinition-funding-rule.md) | Funding rules that define medication and device funding conditions, restrictions, and special requirements |
| [In-Combination](StructureDefinition-in-combination.md) | Indicates whether this item is only subsidised when used in combination with other medicines or treatments. |
| [Medication ATC Category 1](StructureDefinition-medication-atc-category-1.md) | Used to describe ATC Category 1 (including id and name) |
| [Medication ATC Category 2](StructureDefinition-medication-atc-category-2.md) | Used to describe ATC Category 2 (including id and name) |
| [Medication ATC Category 3](StructureDefinition-medication-atc-category-3.md) | Used to describe ATC Category 3 (including id and name) |
| [Medication Brand Name](StructureDefinition-medication-brand-name.md) | The brand or trade name of the medication. For example, 'Budesonide Te Arai' or 'Gaviscon Infant'. |
| [Medication In Combination](StructureDefinition-medication-in-combination.md) | Indicates whether this medication is only subsidised when used in combination with other medicines. |
| [Medication Legal Classification](StructureDefinition-medication-legal-classification.md) | Legal classification for a medication. |
| [Medication Original Pack](StructureDefinition-medication-original-pack.md) | Indicates whether this pack represents the original pack supplied by the manufacturer. |
| [Medication Package Size](StructureDefinition-medication-package-size.md) | Package size for a scheduled medication. For example, '30 x 650 mg sachets' would be represented as 'Sachet' in the form property and 30 in the packageSize extension property. |
| [Medication Product Created Date](StructureDefinition-medication-product-created-date.md) | The date a medication product record was created. |
| [Medication Product Multiple](StructureDefinition-medication-product-multiple.md) | Indicates whether this pack uses product multiples when calculating pricing or claims. |
| [Medication Product Multiplier](StructureDefinition-medication-product-multiplier.md) | Numeric multiplier applied when calculating pricing or claims for this pack. |
| [Medication Rank](StructureDefinition-medication-rank.md) | Ranking or priority of this medication formulation within the schedule. Lower numbers typically indicate higher priority or preferred formulations. |
| [Medication Safety List Medicine](StructureDefinition-medication-safety-list-medicine.md) | Indicates whether this medication is on a PHARMAC safety list. |
| [Medication Statim](StructureDefinition-medication-statim.md) | Indicates whether stat (urgent) dispensing rules apply for this medication. |
| [Medication Strength](StructureDefinition-medication-strength.md) | Strength for a medication. |
| [Medication Unit of Measure](StructureDefinition-medication-unit-of-measure.md) | The unit of measure used for this medication. For example, 'tab' (tablet), 'cap' (capsule), 'ml' (milliliter), 'sach' (sachet). |
| [Pricing Co-Payment Max](StructureDefinition-pricing-copayment-max.md) | Indicates whether Co-Payment Max applies to this pricing record. |
| [Pricing Effective Date](StructureDefinition-pricing-effective-date.md) | The date from which this pricing becomes effective. |
| [Pricing Expiry Date](StructureDefinition-pricing-expiry-date.md) | The date on which this pricing expires or ceases to be valid. |
| [Pricing Not Combined](StructureDefinition-pricing-not-combined.md) | Indicates whether Not Combined applies to this pricing record. |
| [Pricing Section 29](StructureDefinition-pricing-section-29.md) | Indicates whether Section 29 applies to this pricing record. |
| [Statim (Urgent Dispensing)](StructureDefinition-statim.md) | Indicates whether stat (urgent) dispensing rules apply for this item. |
| [Wastage Claimable](StructureDefinition-wastage-claimable.md) | Indicates whether wastage for this item may be claimed. |

### Terminology: Value Sets 

These define sets of codes used by systems conforming to this implementation guide.

| | |
| :--- | :--- |
| [Medication Form Codes](ValueSet-medication-form-codes.md) |  |
| [PHARMAC Medication Code ValueSet](ValueSet-pharmac-medication-code.md) | ValueSet containing medication codes from NZMT CTPP, PackID, and SNOMED CT code systems used for PHARMAC pharmaceutical schedule medications. |
| [SNOMED CT Device Types](ValueSet-snomed-ct-device-types.md) |  |

### Example: Example Instances 

These are example instances that show what data produced and consumed by systems conforming with this implementation guide might look like.

| | |
| :--- | :--- |
| [APIError-Unauthorised](OperationOutcome-APIError-Unauthorised.md) | An example of an OperationOutcome resource representing an unauthorised access error. |
| [ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1](ChargeItemDefinition-ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1.md) | Rules for Clexane 100 mg in 1 ml syringe - Case 1. |
| [ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2](ChargeItemDefinition-ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2.md) | Rules for Clexane 100 mg in 1 ml syringe - Case 2. |
| [ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-3](ChargeItemDefinition-ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-3.md) | Rules for Clexane 100 mg in 1 ml syringe - Case 3. |
| [ChargeItemDefinition-SA9999-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA9999-Authorization.md) | Special Authorization SA9999 |
| [Clexane - Pricing](ChargeItemDefinition-ChargeItemDefinition-Clexane-Pricing.md) | Pricing information for Clexane (enoxaparin sodium injection). Demonstrates fully subsidized community and HML pricing. |
| [Medication-Clexane-100mg-1ml-Syringe](Medication-Medication-Clexane-100mg-1ml-Syringe.md) | Medication representation of Clexane (enoxaparin sodium) Inj 100 mg in 1 ml syringe. |
| [Medication-Fortisip-Multi-Fibre-Chocolate](Medication-Medication-Fortisip-Multi-Fibre-Chocolate.md) | Supplmentrepresentation of Fortisip Multi Fibre (chocolate) oral feed with fibre 1.5 kcal/ml. |
| [Medication-Nutrison-800-Complete-Multi-Fibre](Medication-Medication-Nutrison-800-Complete-Multi-Fibre.md) | Supplement representation of Nutrison 800 Complete Multi Fibre (enteral feed with fibre 0.83 kcal/ml). |
| [SearchSet-Bundle-All-Medications](Bundle-SearchSet-Bundle-All-Medications.md) | Example search result demonstrating a bulk medication search with GET [base]/Medication?_count=1000&_total=accurate |
| [SearchSet-Bundle-All-Special-Authorities](Bundle-SearchSet-Bundle-All-Special-Authorities.md) | Example search result demonstrating a search for all special authorization definitions. GET [base]/pharmac-charge-item-definition-special-authority?_count=1000&_total=accurate |
| [SearchSet-Bundle-Clexane-Pricing](Bundle-SearchSet-Bundle-Clexane-Pricing.md) | Example search result demonstrating _include to retrieve Medication resources with their associated ChargeItemDefinition pricing information. This would be the result of a query like: GET /Medication?name=Clexane&_include=ChargeItemDefinition:instance |

