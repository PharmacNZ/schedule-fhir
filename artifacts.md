# Artifacts Summary - Pharmac Schedules FHIR API v0.0.1

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
| [MedicationBrandNameSearchParam](SearchParameter-MedicationBrandNameSearchParam.md) | Search for medications by brand name (e.g., 'Gaviscon', 'Acidex', 'Budesonide'). Enables fuzzy matching on the medication-brand-name extension for discovery by product name. |
| [MedicationNameSearchParam](SearchParameter-MedicationNameSearchParam.md) | Search for medications by the text representation of the medication code (e.g., 'Gaviscon Infant', 'Acidex oral liquid'). Enables discovery by the full medication name or formulation description. |

### Structures: Resource Profiles 

These define constraints on FHIR resources for systems conforming to this implementation guide.

| | |
| :--- | :--- |
| [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md) | Profile for ChargeItemDefinition resources representing pricing, subsidy, and rules for devices and medications in the PHARMAC schedule. This profile allows FHIR consumers to use the _include search parameter to retrieve pricing information alongside device or medication resources. |
| [PHARMAC Medication](StructureDefinition-pharmac-medication.md) | Profile for Medication resources representing pharmaceutical products in the PHARMAC schedule. This profile defines the structure for medications including brand identification, pack codes, product names, form, and ingredients. Pricing information is provided via related ChargeItemDefinition resources that can be retrieved using the _include search parameter. |

### Structures: Extension Definitions 

These define constraints on FHIR data types for systems conforming to this implementation guide.

| | |
| :--- | :--- |
| [Authorization Case Count](StructureDefinition-authorization-case-count.md) | The number of authorization cases or approval criteria specified in the authorization requirement. This indicates how many different clinical scenarios or conditions have distinct approval pathways. |
| [Authorization Form](StructureDefinition-authorization-form.md) | The special authorization form code required for this medication (e.g., 'SA2535'). This identifies the specific PHARMAC authorization form that prescribers must complete for patient eligibility. |
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
| [Medication Original Pack](StructureDefinition-medication-original-pack.md) | Indicates whether this pack represents the original pack supplied by the manufacturer. |
| [Medication Package Size](StructureDefinition-medication-package-size.md) | Package size for a scheduled medication. For example, '30 x 650 mg sachets' would be represented as 'Sachet' in the form property and 30 in the packageSize extension property. |
| [Medication Product Multiple](StructureDefinition-medication-product-multiple.md) | Indicates whether this pack uses product multiples when calculating pricing or claims. |
| [Medication Product Multiplier](StructureDefinition-medication-product-multiplier.md) | Numeric multiplier applied when calculating pricing or claims for this pack. |
| [Medication Rank](StructureDefinition-medication-rank.md) | Ranking or priority of this medication formulation within the schedule. Lower numbers typically indicate higher priority or preferred formulations. |
| [Medication Safety List Medicine](StructureDefinition-medication-safety-list-medicine.md) | Indicates whether this medication is on a PHARMAC safety list. |
| [Medication Statim](StructureDefinition-medication-statim.md) | Indicates whether stat (urgent) dispensing rules apply for this medication. |
| [Medication Unit of Measure](StructureDefinition-medication-unit-of-measure.md) | The unit of measure used for this medication. For example, 'tab' (tablet), 'cap' (capsule), 'ml' (milliliter), 'sach' (sachet). |
| [Pricing Effective Date](StructureDefinition-pricing-effective-date.md) | The date from which this pricing becomes effective. |
| [Pricing Expiry Date](StructureDefinition-pricing-expiry-date.md) | The date on which this pricing expires or ceases to be valid. |
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
| [ChargeItemDefinition-Community-Pharmacy-BSO-Sequence-1](ChargeItemDefinition-ChargeItemDefinition-Community-Pharmacy-BSO-Sequence-1.md) | Community pharmacy BSO subsidy (Case 1) with provider condition for hospital care operators. |
| [ChargeItemDefinition-Community-Pharmacy-Rural-PSO-Sequence-1](ChargeItemDefinition-ChargeItemDefinition-Community-Pharmacy-Rural-PSO-Sequence-1.md) | Community pharmacy Rural PSO subsidy (Case 1) with provider condition for authorised prescribers. |
| [ChargeItemDefinition-Community-Pharmacy-Sequence-1](ChargeItemDefinition-ChargeItemDefinition-Community-Pharmacy-Sequence-1.md) | Community pharmacy prescription subsidy for patients unable to tolerate administration of goserelin. Demonstrates reimbursement with endorsement and provider conditions. |
| [ChargeItemDefinition-Community-Pharmacy-Sequence-2](ChargeItemDefinition-ChargeItemDefinition-Community-Pharmacy-Sequence-2.md) | Community pharmacy prescription subsidy (Case 2) with provider condition only. |
| [ChargeItemDefinition-SA2139-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2139-Authorization.md) | Special Authorization SA2139. |
| [ChargeItemDefinition-SA2520-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2520-Authorization.md) | Special Authorization SA2520 |
| [ChargeItemDefinition-Tenofovir-Case-Sequence-1](ChargeItemDefinition-ChargeItemDefinition-Tenofovir-Case-Sequence-1.md) | Rules for Tenofovir Disoproxil |
| [ChargeItemDefinition-Tenofovir-Case-Sequence-2](ChargeItemDefinition-ChargeItemDefinition-Tenofovir-Case-Sequence-2.md) | Rules for Tenofovir Disoproxil |
| [Lucrin Depot 1-month - Pricing](ChargeItemDefinition-ChargeItemDefinition-Lucrin-Depot-1-Month-Pricing.md) | Pricing information for Lucrin Depot 1-month (leuprorelin injection). Demonstrates community subsidized pricing with subsidy, alternative pricing, and new pricing attributes including cost brand source, wastage claimable, DV limit percentage, and brand switch fee. |
| [Medication-Lucrin-Depot-1-Month](Medication-Medication-Lucrin-Depot-1-Month.md) | Medication representation of Lucrin Depot 1-month (leuprorelin injection). |
| [Medication-Ricovir-Tenofovir](Medication-Medication-Ricovir-Tenofovir.md) | Medication representation of Ricovir (tenofovir disoproxil tablets). |
| [Medication-Viramune-Suspension](Medication-Medication-Viramune-Suspension.md) | Medication representation of Viramune Suspension (nevirapine oral suspension). |
| [Ricovir - Pricing](ChargeItemDefinition-ChargeItemDefinition-Ricovir-Pricing.md) | Pricing information for Ricovir (tenofovir disoproxil tablets). Demonstrates fully subsidized community pricing with PSS contract type and DV limit. |
| [SearchSet-Bundle-Leuprorelin-Pricing](Bundle-SearchSet-Bundle-Leuprorelin-Pricing.md) | Example search result demonstrating _include to retrieve Medication resources with their associated ChargeItemDefinition pricing information. This would be the result of a query like: GET /Medication?name=Leuprorelin&_include=ChargeItemDefinition:instance |
| [SearchSet-Bundle-Medication](Bundle-SearchSet-Bundle-Medication.md) | Example search result demonstrating a bulk medication search. |
| [SearchSet-Bundle-Ricovir-Pricing](Bundle-SearchSet-Bundle-Ricovir-Pricing.md) | Example search result demonstrating _include to retrieve Medication resources with their associated ChargeItemDefinition pricing information. This would be the result of a query like: GET /Medication?name=Tenofovir&_include=ChargeItemDefinition:instance |
| [SearchSet-Bundle-SA2139-Authorization](Bundle-SearchSet-Bundle-SA2139-Authorization.md) | Example search result demonstrating _include to retrieve ChargeItemDefinition resource using the Special Authority ID and it's associated Medication(s) Query: GET /ChargeItemDefinition?code=SA2139&_include=ChargeItemDefinition:instance |

